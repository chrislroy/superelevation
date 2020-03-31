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

        [CommandMethod("ListFL")]
        public void ListFL()
        {
            ListFeatureLines f = new ListFeatureLines();
            f.ShowDialog();
        }

    }
}

