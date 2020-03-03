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
using Autodesk.Civil;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.Civil.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace GettingStarted
{
    public partial class CreateSEForm : Form
    {
        public CreateSEForm()
        {
            InitializeComponent();
            doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;

            pickLocation.Enabled = false;
            create.Enabled = false;

            name.Text = "default name";
            description.Text = "default description";
            baselayer.Text = "default base layer";

            List<string> layerList = LayersToList(doc.Database);
            layerList.Insert(0, "Select a layer");
            layers.DataSource = layerList;
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


        private void PickAlignment_Click(object sender, EventArgs e)
        {
            Database db = doc.Database;
            alignId = SelectAlignment(doc.Editor);
            pickLocation.Enabled = !alignId.IsNull;
        }

        private void PickLocation_Click(object sender, EventArgs e)
        {
            PromptPointOptions ptOpts = new PromptPointOptions("\nSelect super-elevation view origin: ");
            ptOpts.AllowNone = false;
            PromptPointResult ptRes = doc.Editor.GetPoint(ptOpts);
            location = ptRes.Value;
            create.Enabled = true;
        }

        private void CreateSuperelevation_Click(object sender, EventArgs e)
        {
            bool useLayerName = layers.SelectedIndex != 0;
            seId = SuperelevationView.Create(alignId, name.Text, description.Text, useLayerName, layers.Items[layers.SelectedIndex].ToString(), baselayer.Text, location);
            if (seId.IsNull)
            {
                doc.Editor.WriteMessage("\nError creating Super Elevation");
                return;
            }
            else
            {
                doc.Editor.WriteMessage("\nSuper Elevation created :)");
            }

            Close();
        }

        Document doc;
        ObjectId seId = ObjectId.Null;
        ObjectId alignId = ObjectId.Null;
        Point3d location;
    }
}
