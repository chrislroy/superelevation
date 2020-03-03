using System;
using System.Windows;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.Civil.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;

namespace GettingStarted
{
    public class SuperElevation : IExtensionApplication
    {
        #region IExtensionApplication Members

        public void Initialize()
        {
            //             throw new System.Exception("The method or operation is not implemented.");
        }

        public void Terminate()
        {
            //             throw new System.Exception("The method or operation is not implemented.");
        }

        #endregion

        [CommandMethod("CreateSE")]
        public void CreateSE()
        {
            CreateSEForm f = new CreateSEForm();
            f.ShowDialog();
        }

        [CommandMethod("TestSE")]
        public void TestSE()
        {
            TestSEForm f = new TestSEForm();
            f.ShowDialog();
        }

        [CommandMethod("ListSE")]
        public void ListSE()
        {
            ListSEForm f = new ListSEForm();
            f.ShowDialog();
        }

        [CommandMethod("SuperElevationTest")]
        public void SuperElevationTest()
        {
            SuperElevationUI f = new SuperElevationUI();
            f.ShowDialog();
        }
    }
}