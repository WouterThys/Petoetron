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
            this.components = new System.ComponentModel.Container();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndDone = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCopy = new DevExpress.XtraBars.BarButtonItem();
            this.bsObject = new System.Windows.Forms.BindingSource(this.components);
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.CodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.peObjectIcon = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.InfoMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.tabbedControlGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            this.lcgData = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgDocuments = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgLogs = new DevExpress.XtraLayout.LayoutControlGroup();
            this.flyoutPanel = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl = new DevExpress.Utils.FlyoutPanelControl();
            this.lcSaving = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            this.dataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peObjectIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel)).BeginInit();
            this.flyoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl)).BeginInit();
            this.flyoutPanelControl.SuspendLayout();
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
            this.bbiCopy});
            this.ribbonControl.MaxItemId = 6;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Text = "Tub1";
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
            // bsObject
            // 
            this.bsObject.DataSource = typeof(Petoetron.Classes.Helpers.AbstractBaseObject);
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.Controls.Add(this.dataLayoutControl1);
            this.dataLayoutControl.Controls.Add(this.peObjectIcon);
            this.dataLayoutControl.Controls.Add(this.CodeTextEdit);
            this.dataLayoutControl.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl.DataSource = this.bsObject;
            this.dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl.Location = new System.Drawing.Point(0, 194);
            this.dataLayoutControl.Name = "dataLayoutControl";
            this.dataLayoutControl.Root = this.Root;
            this.dataLayoutControl.Size = new System.Drawing.Size(663, 499);
            this.dataLayoutControl.TabIndex = 1;
            this.dataLayoutControl.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(663, 499);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDescription,
            this.layoutControlItem1,
            this.ItemForCode,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(643, 479);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.Location = new System.Drawing.Point(133, 26);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(510, 105);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForDescription.TextVisible = false;
            // 
            // CodeTextEdit
            // 
            this.CodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsObject, "Code", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CodeTextEdit.Location = new System.Drawing.Point(145, 12);
            this.CodeTextEdit.MenuManager = this.ribbonControl;
            this.CodeTextEdit.Name = "CodeTextEdit";
            this.CodeTextEdit.Size = new System.Drawing.Size(506, 22);
            this.CodeTextEdit.StyleController = this.dataLayoutControl;
            this.CodeTextEdit.TabIndex = 5;
            // 
            // ItemForCode
            // 
            this.ItemForCode.Control = this.CodeTextEdit;
            this.ItemForCode.Location = new System.Drawing.Point(133, 0);
            this.ItemForCode.Name = "ItemForCode";
            this.ItemForCode.Size = new System.Drawing.Size(510, 26);
            this.ItemForCode.Text = "Code";
            this.ItemForCode.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForCode.TextVisible = false;
            // 
            // peObjectIcon
            // 
            this.peObjectIcon.Location = new System.Drawing.Point(12, 12);
            this.peObjectIcon.MenuManager = this.ribbonControl;
            this.peObjectIcon.Name = "peObjectIcon";
            this.peObjectIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peObjectIcon.Size = new System.Drawing.Size(129, 127);
            this.peObjectIcon.StyleController = this.dataLayoutControl;
            this.peObjectIcon.TabIndex = 6;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.peObjectIcon;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(133, 131);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsObject, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DescriptionTextEdit.Location = new System.Drawing.Point(145, 38);
            this.DescriptionTextEdit.MenuManager = this.ribbonControl;
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Size = new System.Drawing.Size(506, 101);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl;
            this.DescriptionTextEdit.TabIndex = 4;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.InfoMemoEdit);
            this.dataLayoutControl1.DataSource = this.bsObject;
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 143);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup2;
            this.dataLayoutControl1.Size = new System.Drawing.Size(639, 344);
            this.dataLayoutControl1.TabIndex = 7;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dataLayoutControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 131);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(643, 348);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(639, 344);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AllowDrawBackground = false;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "autoGeneratedGroup0";
            this.layoutControlGroup3.Size = new System.Drawing.Size(619, 324);
            // 
            // InfoMemoEdit
            // 
            this.InfoMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsObject, "Info", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InfoMemoEdit.Location = new System.Drawing.Point(24, 75);
            this.InfoMemoEdit.MenuManager = this.ribbonControl;
            this.InfoMemoEdit.Name = "InfoMemoEdit";
            this.InfoMemoEdit.Size = new System.Drawing.Size(591, 245);
            this.InfoMemoEdit.StyleController = this.dataLayoutControl1;
            this.InfoMemoEdit.TabIndex = 4;
            // 
            // tabbedControlGroup
            // 
            this.tabbedControlGroup.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup.Name = "tabbedControlGroup";
            this.tabbedControlGroup.SelectedTabPage = this.lcgData;
            this.tabbedControlGroup.Size = new System.Drawing.Size(619, 324);
            this.tabbedControlGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgData,
            this.lcgDocuments,
            this.lcgLogs});
            // 
            // lcgData
            // 
            this.lcgData.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForInfo});
            this.lcgData.Location = new System.Drawing.Point(0, 0);
            this.lcgData.Name = "lcgData";
            this.lcgData.Size = new System.Drawing.Size(595, 268);
            this.lcgData.Text = "Data";
            // 
            // ItemForInfo
            // 
            this.ItemForInfo.Control = this.InfoMemoEdit;
            this.ItemForInfo.Location = new System.Drawing.Point(0, 0);
            this.ItemForInfo.Name = "ItemForInfo";
            this.ItemForInfo.Size = new System.Drawing.Size(595, 268);
            this.ItemForInfo.StartNewLine = true;
            this.ItemForInfo.Text = "Info";
            this.ItemForInfo.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForInfo.TextSize = new System.Drawing.Size(22, 16);
            // 
            // lcgDocuments
            // 
            this.lcgDocuments.Location = new System.Drawing.Point(0, 0);
            this.lcgDocuments.Name = "lcgDocuments";
            this.lcgDocuments.Size = new System.Drawing.Size(595, 268);
            this.lcgDocuments.Text = "Ducumunten";
            // 
            // lcgLogs
            // 
            this.lcgLogs.Location = new System.Drawing.Point(0, 0);
            this.lcgLogs.Name = "lcgLogs";
            this.lcgLogs.Size = new System.Drawing.Size(595, 268);
            this.lcgLogs.Text = "Lugs";
            // 
            // flyoutPanel
            // 
            this.flyoutPanel.Controls.Add(this.flyoutPanelControl);
            this.flyoutPanel.Location = new System.Drawing.Point(421, 94);
            this.flyoutPanel.Name = "flyoutPanel";
            this.flyoutPanel.OwnerControl = this;
            this.flyoutPanel.Size = new System.Drawing.Size(460, 46);
            this.flyoutPanel.TabIndex = 2;
            // 
            // flyoutPanelControl
            // 
            this.flyoutPanelControl.AutoSize = true;
            this.flyoutPanelControl.Controls.Add(this.lcSaving);
            this.flyoutPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl.FlyoutPanel = this.flyoutPanel;
            this.flyoutPanelControl.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl.Name = "flyoutPanelControl";
            this.flyoutPanelControl.Size = new System.Drawing.Size(460, 46);
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
            this.lcSaving.Name = "lcSaving";
            this.lcSaving.Size = new System.Drawing.Size(456, 42);
            this.lcSaving.TabIndex = 0;
            this.lcSaving.Text = "Upsluun...";
            // 
            // BaseEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flyoutPanel);
            this.Controls.Add(this.dataLayoutControl);
            this.Name = "BaseEditView";
            this.Size = new System.Drawing.Size(663, 693);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.dataLayoutControl, 0);
            this.Controls.SetChildIndex(this.flyoutPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            this.dataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peObjectIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel)).EndInit();
            this.flyoutPanel.ResumeLayout(false);
            this.flyoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl)).EndInit();
            this.flyoutPanelControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraBars.BarButtonItem bbiSave;
        protected DevExpress.XtraBars.BarButtonItem bbiSaveAndDone;
        protected DevExpress.XtraBars.BarButtonItem bbiReset;
        protected DevExpress.XtraBars.BarButtonItem bbiDelete;
        protected DevExpress.XtraBars.BarButtonItem bbiCopy;
        protected System.Windows.Forms.BindingSource bsObject;
        protected DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
        protected DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
        protected DevExpress.XtraLayout.LayoutControlGroup Root;
        protected DevExpress.XtraEditors.PictureEdit peObjectIcon;
        protected DevExpress.XtraEditors.TextEdit CodeTextEdit;
        protected DevExpress.XtraEditors.MemoEdit DescriptionTextEdit;
        protected DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        protected DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        protected DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        protected DevExpress.XtraLayout.LayoutControlItem ItemForCode;
        protected DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        protected DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        protected DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        protected DevExpress.XtraEditors.MemoEdit InfoMemoEdit;
        protected DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        protected DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgData;
        protected DevExpress.XtraLayout.LayoutControlItem ItemForInfo;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgDocuments;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgLogs;
        protected DevExpress.Utils.FlyoutPanel flyoutPanel;
        protected DevExpress.Utils.FlyoutPanelControl flyoutPanelControl;
        protected DevExpress.XtraEditors.LabelControl lcSaving;
    }
}
