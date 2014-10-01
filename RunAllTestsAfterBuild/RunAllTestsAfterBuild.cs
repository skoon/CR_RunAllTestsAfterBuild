using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.PlugInCore;
using DevExpress.DXCore.PlugInCore;
using DevExpress.CodeRush.StructuralParser;

namespace RunAllTestsAfterBuild
{
    public partial class RunAllTestsAfterBuild : StandardPlugIn
    {
        // DXCore-generated code...
        #region InitializePlugIn
        public override void InitializePlugIn()
        {
            base.InitializePlugIn();
            RunAllTestsAction.Execute += RunAllTests;
            this.BuildDone += new BuildEventHandler(handle_builddone);

            //
            // TODO: Add your initialization code here.
            //
        }
        #endregion

        private void RunAllTests(ExecuteEventArgs args)
        {
            CodeRush.UnitTests.Execute();
        }

        private void handle_builddone(EnvDTE.vsBuildScope scope, EnvDTE.vsBuildAction action)
        {
            RunAllTestsAction.DoExecute();
        }

        #region FinalizePlugIn
        public override void FinalizePlugIn()
        {
            //
            // TODO: Add your finalization code here.
            //

            base.FinalizePlugIn();
        }
        #endregion
    }
}