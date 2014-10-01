namespace RunAllTestsAfterBuild
{
    partial class RunAllTestsAfterBuild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RunAllTestsAfterBuild()
        {
            /// <summary>
            /// Required for Windows.Forms Class Composition Designer support
            /// </summary>
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RunAllTestsAction = new DevExpress.CodeRush.Core.Action(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Images16x16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunAllTestsAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // RunAllTestsAction
            // 
            this.RunAllTestsAction.ActionName = "RunAllTests";
            this.RunAllTestsAction.ButtonText = "Run All Tests";
            this.RunAllTestsAction.CommonMenu = DevExpress.CodeRush.Menus.VsCommonBar.None;
            this.RunAllTestsAction.ImageBackColor = System.Drawing.Color.Empty;
            this.RunAllTestsAction.ToolbarItem.ButtonIsPressed = false;
            this.RunAllTestsAction.ToolbarItem.Caption = null;
            this.RunAllTestsAction.ToolbarItem.Image = null;
            this.RunAllTestsAction.ToolbarItem.ToolbarName = null;
            ((System.ComponentModel.ISupportInitialize)(this.Images16x16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunAllTestsAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.CodeRush.Core.Action RunAllTestsAction;
    }
}