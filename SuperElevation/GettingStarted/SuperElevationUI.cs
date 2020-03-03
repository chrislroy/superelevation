using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.Civil.DatabaseServices;
using Autodesk.Civil;

namespace GettingStarted
{
    public partial class SuperElevationUI : Form
    {
        // global
        Document doc;
        ObjectId alignId = ObjectId.Null; // alignment id
        ObjectId seId = ObjectId.Null; // superelevation id
        Point3d seLocationPt; // super elevation point
        Point3d xSlopePt; // cross slope point
        System.Timers.Timer timer;

        public SuperElevationUI()
        {
            InitializeComponent();

            doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            //             xlocation.Enabled = false;
            //             ylocation.Enabled = false;
            //             zlocation.Enabled = false;
            timer = new System.Timers.Timer(750);
            timer.Elapsed += OnTimedEvent;

            graphRangeOptions.DataSource = new List<string> { "None", "From Alignment", "User Specified" };

            nameText.Text = "default name";
            descriptionText.Text = "default description";
            baselayerText.Text = "default base layer";

            List<string> layerList = LayersToList(doc.Database);
            layerList.Insert(0, "Select a layer");
            layerCombo.DataSource = layerList;
        }

        public List<string> LayersToList(Database db)
        {
            List<string> lstlay = new List<string>();

            LayerTableRecord layer;
            using (Transaction tr = db.TransactionManager.StartOpenCloseTransaction())
            {
                LayerTable lt = tr.GetObject(db.LayerTableId, OpenMode.ForRead) as LayerTable;
                foreach (ObjectId layerId in lt)
                {
                    layer = tr.GetObject(layerId, OpenMode.ForWrite) as LayerTableRecord;
                    lstlay.Add(layer.Name);
                }

            }
            return lstlay;
        }

        private ObjectId SelectAlignment(Editor ed)
        {
            ObjectId result = ObjectId.Null;
            PromptEntityOptions entOpts = new PromptEntityOptions("\nSelect alignment: ");
            entOpts.SetRejectMessage("...not an Alignment, try again!:");
            entOpts.AddAllowedClass(typeof(Alignment), true);
            PromptEntityResult entRes = ed.GetEntity(entOpts);
            if (entRes.Status == PromptStatus.OK)
                result = entRes.ObjectId;
            return result;
        }

        private void PickAlignment_Click(object sender, EventArgs e)
        {
            alignId = SelectAlignment(doc.Editor);
        }

        private void CreateSuperelevation_Click(object sender, EventArgs e)
        {
            Hide();
            timer.Start();

            bool useLayerName = layerCombo.SelectedIndex != 0;
            seId = SuperelevationView.Create(alignId, nameText.Text, descriptionText.Text, useLayerName, layerCombo.Items[layerCombo.SelectedIndex].ToString(), baselayerText.Text, seLocationPt);

            if (seId.IsNull)
            {
                doc.Editor.WriteMessage("\nError creating Super Elevation");
                return;
            }
            else
            {
                doc.Editor.WriteMessage("\nSuper Elevation created :)");
            }
        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();
        
            Show();
        }

        private void PickLocation_Click(object sender, EventArgs e)
        {
            PromptPointOptions ptOpts = new PromptPointOptions("\nPick a point: ");
            ptOpts.AllowNone = false;
            PromptPointResult ptRes = doc.Editor.GetPoint(ptOpts);
            seLocationPt = ptRes.Value;
        }

        private void getStationAndCrossSlope(object sender, EventArgs e)
        {
            Transaction acTrans = doc.TransactionManager.StartTransaction();
            using (acTrans)
            {
                var se = acTrans.GetObject(seId, OpenMode.ForRead);
                var ser = se as SuperelevationView;
                double station = 0;
                double xslope = 0;
                ser.getStationAndCrossSlope(xSlopePt, ref station, ref xslope);
                stationVal.Text = station.ToString();
                crossSlopeVal.Text = xslope.ToString();
            }
        }

        private void XSlope_click(object sender, EventArgs e)
        {
            PromptPointOptions ptOpts = new PromptPointOptions("\nPick point for XSlope test: ");
            ptOpts.AllowNone = false;
            PromptPointResult ptRes = doc.Editor.GetPoint(ptOpts);
            xSlopePt = ptRes.Value;
        }

        private void getGraphRangeOption(object sender, EventArgs e)
        {
            Transaction acTrans = doc.TransactionManager.StartTransaction();
            using (acTrans)
            {
                var se = acTrans.GetObject(seId, OpenMode.ForRead);
                var ser = se as SuperelevationView;
                graphRangeOptions.SelectedIndex = (int)ser.RangeOption;
            }
        }

        private void GraphRangeOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transaction acTrans = doc.TransactionManager.StartTransaction();
            using (acTrans)
            {
                var se = acTrans.GetObject(seId, OpenMode.ForWrite);
                var ser = se as SuperelevationView;
                ser.RangeOption = (GraphRangeOptions)graphRangeOptions.SelectedIndex;
            }
        }

        private void getStationRange(object sender, EventArgs e)
        {
            Transaction acTrans = doc.TransactionManager.StartTransaction();
            using (acTrans)
            {
                var se = acTrans.GetObject(seId, OpenMode.ForRead);
                var ser = se as SuperelevationView;
                stationStart.Text = ser.StationStart.ToString();
                stationEnd.Text = ser.StationEnd.ToString();
            }
        }

        private void setLocation(object sender, EventArgs e)
        {
            Transaction acTrans = doc.TransactionManager.StartTransaction();
            using (acTrans)
            {
                var se = acTrans.GetObject(seId, OpenMode.ForWrite);
                var ser = se as SuperelevationView;
                double x = Convert.ToDouble(xlocation.Text);
                Point3d pt = new Point3d(Convert.ToDouble(xlocation.Text), Convert.ToDouble(ylocation.Text), Convert.ToDouble(zlocation.Text));
                ser.Location = pt;
            }
        }

        private void getLocation(object sender, EventArgs e)
        {
            Transaction acTrans = doc.TransactionManager.StartTransaction();
            using (acTrans)
            {
                var se = acTrans.GetObject(seId, OpenMode.ForRead);
                var ser = se as SuperelevationView;
                Point3d location = ser.Location;

                xlocation.Text = location.X.ToString();
                ylocation.Text = location.Y.ToString();
                zlocation.Text = location.Z.ToString();
            }
        }

        private ObjectId SelectSuperElevation(Editor ed)
        {
            ObjectId result = ObjectId.Null;
            PromptEntityOptions entOpts = new PromptEntityOptions("\nSelect super elevation: ");
            entOpts.SetRejectMessage("...not a super elevation, try again!:");
            entOpts.AddAllowedClass(typeof(SuperelevationView), true);
            PromptEntityResult entRes = ed.GetEntity(entOpts);
            if (entRes.Status == PromptStatus.OK)
                result = entRes.ObjectId;
            return result;
        }

        // list tab

        private void PickSuperElevationButton_Click(object sender, EventArgs e)
        {
            seId = SelectSuperElevation(doc.Editor);
            var ok = !seId.IsNull;
            xlocation.Enabled = ok;
            ylocation.Enabled = ok;
            zlocation.Enabled = ok;
        }

        private void ListSE_Click(object sender, EventArgs e)
        {
            if (alignId.IsNull)
                return;

            Transaction acTrans = doc.TransactionManager.StartTransaction();
            using (acTrans)
            {
                ObjectIdCollection seCollection = SuperelevationView.getAvailSuperelevationDiagramsForHA(alignId);

                foreach (ObjectId id in seCollection)
                {
                    var se = acTrans.GetObject(id, OpenMode.ForRead);
                    var ser = se as SuperelevationView;

                    superElevationList.Items.Add(ser.Name + " " + id.ToString());
                }
            }
        }

        private void PickLocationButton_Click(object sender, EventArgs e)
        {
            PromptPointOptions ptOpts = new PromptPointOptions("\nSelect super-elevation view origin: ");
            ptOpts.AllowNone = false;
            PromptPointResult ptRes = doc.Editor.GetPoint(ptOpts);
            seLocationPt = ptRes.Value;
//             create.Enabled = true;
        }

    }
}
