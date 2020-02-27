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
    public partial class ListSEForm : Form
    {
        public ListSEForm()
        {
            InitializeComponent();
            doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
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

        Document doc;
        ObjectId alignId = ObjectId.Null;
    }
}
