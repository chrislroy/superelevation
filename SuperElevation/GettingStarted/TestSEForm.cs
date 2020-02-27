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
    public partial class TestSEForm : Form
    {
        Document doc;
        ObjectId seId;
        Point3d xSlopePt;
        public TestSEForm()
        {
            InitializeComponent();
            doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            xlocation.Enabled = false;
            ylocation.Enabled = false;
            zlocation.Enabled = false;

            graphRangeOptions.DataSource = new List<string> { "None", "From Alignment", "User Specified" };
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

        private void PickSE_Click(object sender, EventArgs e)
        {
            seId = SelectSuperElevation(doc.Editor);
            var ok = !seId.IsNull;
            xlocation.Enabled = ok;
            ylocation.Enabled = ok;
            zlocation.Enabled = ok;
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


        private void GraphRangeOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transaction acTrans = doc.TransactionManager.StartTransaction();
            using (acTrans)
            {
                var se = acTrans.GetObject(seId, OpenMode.ForWrite);
                var ser = se as SuperelevationView;
                ser.RangeOption = (GraphRangeOptions) graphRangeOptions.SelectedIndex;
            }
        }

        private void getGraphRangeOption(object sender, EventArgs e)
        {
            Transaction acTrans = doc.TransactionManager.StartTransaction();
            using (acTrans)
            {
                var se = acTrans.GetObject(seId, OpenMode.ForRead);
                var ser = se as SuperelevationView;
                graphRangeOptions.SelectedIndex = (int) ser.RangeOption;
            }
        }

        private void XSlope_click(object sender, EventArgs e)
        {
            PromptPointOptions ptOpts = new PromptPointOptions("\nPick point for XSlope test: ");
            ptOpts.AllowNone = false;
            PromptPointResult ptRes = doc.Editor.GetPoint(ptOpts);
            xSlopePt = ptRes.Value;
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
    }


}
