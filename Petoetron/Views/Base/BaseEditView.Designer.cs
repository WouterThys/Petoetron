namespace Petoetron.Views.Base
{
    partial class BaseEditView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndDone = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCopy = new DevExpress.XtraBars.BarButtonItem();
            this.dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.bsObject = new System.Windows.Forms.BindingSource();
            this.flyoutPanel = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl = new DevExpress.Utils.FlyoutPanelControl();
            this.lcSaving = new DevExpress.XtraEditors.LabelControl();
            this.rpgOther = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiPause = new DevExpress.XtraBars.BarButtonItem();
            this.PausePopupMenu = new DevExpress.XtraBars.PopupMenu();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel)).BeginInit();
            this.flyoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl)).BeginInit();
            this.flyoutPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PausePopupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiSave,
            this.bbiSaveAndDone,
            this.bbiReset,
            this.bbiDelete,
            this.bbiCopy,
            this.bbiPause});
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ribbonControl.MaxItemId = 7;
            this.ribbonControl.Size = new System.Drawing.Size(691, 194);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgOther});
            this.ribbonPage1.Text = "Tub 1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAndDone);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiReset);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCopy);
            this.ribbonPageGroup1.Text = "Wurk";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Upsluun";
            this.bbiSave.Id = 1;
            this.bbiSave.ImageOptions.ImageIndex = 3;
            this.bbiSave.ImageOptions.LargeImageIndex = 3;
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiSaveAndDone
            // 
            this.bbiSaveAndDone.Caption = "Kluur";
            this.bbiSaveAndDone.Id = 2;
            this.bbiSaveAndDone.ImageOptions.ImageIndex = 4;
            this.bbiSaveAndDone.ImageOptions.LargeImageIndex = 4;
            this.bbiSaveAndDone.Name = "bbiSaveAndDone";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Rusut";
            this.bbiReset.Id = 3;
            this.bbiReset.ImageOptions.ImageIndex = 11;
            this.bbiReset.ImageOptions.LargeImageIndex = 11;
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Wug";
            this.bbiDelete.Id = 4;
            this.bbiDelete.ImageOptions.ImageIndex = 2;
            this.bbiDelete.ImageOptions.LargeImageIndex = 2;
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiCopy
            // 
            this.bbiCopy.Caption = "Cupy";
            this.bbiCopy.Id = 5;
            this.bbiCopy.ImageOptions.ImageIndex = 5;
            this.bbiCopy.ImageOptions.LargeImageIndex = 5;
            this.bbiCopy.Name = "bbiCopy";
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl.Location = new System.Drawing.Point(0, 194);
            this.dataLayoutControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataLayoutControl.Name = "dataLayoutControl";
            this.dataLayoutControl.Root = this.Root;
            this.dataLayoutControl.Size = new System.Drawing.Size(691, 512);
            this.dataLayoutControl.TabIndex = 1;
            this.dataLayoutControl.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(691, 512);
            this.Root.TextVisible = false;
            // 
            // flyoutPanel
            // 
            this.flyoutPanel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.flyoutPanel.Appearance.Options.UseBackColor = true;
            this.flyoutPanel.Controls.Add(this.flyoutPanelControl);
            this.flyoutPanel.Location = new System.Drawing.Point(241, 170);
            this.flyoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flyoutPanel.Name = "flyoutPanel";
            this.flyoutPanel.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.flyoutPanel.OptionsButtonPanel.ButtonPanelHeight = 37;
            this.flyoutPanel.OwnerControl = this;
            this.flyoutPanel.Size = new System.Drawing.Size(420, 47);
            this.flyoutPanel.TabIndex = 2;
            // 
            // flyoutPanelControl
            // 
            this.flyoutPanelControl.Controls.Add(this.lcSaving);
            this.flyoutPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl.FlyoutPanel = this.flyoutPanel;
            this.flyoutPanelControl.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flyoutPanelControl.Name = "flyoutPanelControl";
            this.flyoutPanelControl.Size = new System.Drawing.Size(420, 47);
            this.flyoutPanelControl.TabIndex = 0;
            // 
            // lcSaving
            // 
            this.lcSaving.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lcSaving.Appearance.FontSizeDelta = 1;
            this.lcSaving.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.lcSaving.Appearance.ForeColor = System.Drawing.Color.White;
            this.lcSaving.Appearance.Options.UseBackColor = true;
            this.lcSaving.Appearance.Options.UseFont = true;
            this.lcSaving.Appearance.Options.UseForeColor = true;
            this.lcSaving.Appearance.Options.UseTextOptions = true;
            this.lcSaving.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lcSaving.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lcSaving.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lcSaving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcSaving.Location = new System.Drawing.Point(2, 2);
            this.lcSaving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lcSaving.Name = "lcSaving";
            this.lcSaving.Size = new System.Drawing.Size(416, 43);
            this.lcSaving.TabIndex = 0;
            this.lcSaving.Text = "Upsluun...";
            // 
            // rpgOther
            // 
            this.rpgOther.ItemLinks.Add(this.bbiPause);
            this.rpgOther.Name = "rpgOther";
            this.rpgOther.Text = "Undure";
            // 
            // bbiPause
            // 
            this.bbiPause.Caption = "Puze";
            this.bbiPause.Id = 6;
            this.bbiPause.ImageOptions.ImageIndex = 33;
            this.bbiPause.ImageOptions.LargeImageIndex = 33;
            this.bbiPause.Name = "bbiPause";
            // 
            // PausePopupMenu
            // 
            this.PausePopupMenu.Name = "PausePopupMenu";
            this.PausePopupMenu.Ribbon = this.ribbonControl;
            // 
            // BaseEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flyoutPanel);
            this.Controls.Add(this.dataLayoutControl);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "BaseEditView";
            this.Size = new System.Drawing.Size(691, 706);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.dataLayoutControl, 0);
            this.Controls.SetChildIndex(this.flyoutPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel)).EndInit();
            this.flyoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl)).EndInit();
            this.flyoutPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PausePopupMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraBars.BarButtonItem bbiSave;
        protected DevExpress.XtraBars.BarButtonItem bbiSaveAndDone;
        protected DevExpress.XtraBars.BarButtonItem bbiReset;
        protected DevExpress.XtraBars.BarButtonItem bbiDelete;
        protected DevExpress.XtraBars.BarButtonItem bbiCopy;
        protected DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
        protected DevExpress.XtraLayout.LayoutControlGroup Root;
        protected System.Windows.Forms.BindingSource bsObject;
        protected DevExpress.Utils.FlyoutPanel flyoutPanel;
        protected DevExpress.Utils.FlyoutPanelControl flyoutPanelControl;
        protected DevExpress.XtraEditors.LabelControl lcSaving;
        private DevExpress.XtraBars.BarButtonItem bbiPause;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgOther;
        private DevExpress.XtraBars.PopupMenu PausePopupMenu;
    }
}
