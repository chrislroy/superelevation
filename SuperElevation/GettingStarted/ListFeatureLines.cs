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
    public partial class ListFeatureLines : Form
    {
        public ListFeatureLines()
        {
            InitializeComponent();
            doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
        }

        private ObjectId SelectFeatureLine(Editor ed)
        {
            ObjectId result = ObjectId.Null;
            PromptEntityOptions entOpts = new PromptEntityOptions("\nSelect feature line: ");
            entOpts.SetRejectMessage("...not an feature line, try again!:");
            entOpts.AddAllowedClass(typeof(FeatureLine), true);
            PromptEntityResult entRes = ed.GetEntity(entOpts);
            if (entRes.Status == PromptStatus.OK)
                result = entRes.ObjectId;
            return result;
        }


        Document doc;
        ObjectId flId = ObjectId.Null;

        private void SetupDataGridView()
        {
//             this.Controls.Add(dataGridView);

            dataGridView.ColumnCount = 3;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(dataGridView.Font, FontStyle.Bold);

//             dataGridView.Name = "dataGridView";
//             dataGridView.Location = new System.Drawing.Point(8, 8);
//             dataGridView.Size = new Size(500, 250);
            dataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.GridColor = Color.Black;
            dataGridView.RowHeadersVisible = false;

            dataGridView.Columns[0].Name = "X";
            dataGridView.Columns[1].Name = "Y";
            dataGridView.Columns[2].Name = "Elevation";

            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
//             dataGridView.Dock = DockStyle.Fill;

//             dataGridView.CellFormatting += new
//                 DataGridViewCellFormattingEventHandler(
//                 dataGridView_CellFormatting);
        }

        private void PickFeatureLine_Click(object sender, EventArgs e)
        {

            flId = SelectFeatureLine(doc.Editor);

            SetupDataGridView();

            Transaction acTrans = doc.TransactionManager.StartTransaction();
            using (acTrans)
            {
                FeatureLine featureLine = flId.GetObject(OpenMode.ForRead) as FeatureLine;

                Point3dCollection piPts = featureLine.GetPoints(FeatureLinePointType.PIPoint);

                foreach (Point3d pt in piPts)
                {
                    string[] s = { pt.X.ToString(), pt.Y.ToString(), pt.Z.ToString() };
                    dataGridView.Rows.Add(s);
                }
            }
        }
    }
}
