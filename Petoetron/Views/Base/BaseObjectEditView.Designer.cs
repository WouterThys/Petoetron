namespace Petoetron.Views.Base
{
    partial class BaseObjectEditView
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.DescriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.CodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.peObjectIcon = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
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
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            this.dataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel)).BeginInit();
            this.flyoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl)).BeginInit();
            this.flyoutPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peObjectIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // bbiSave
            // 
            this.bbiSave.ImageOptions.ImageIndex = 3;
            this.bbiSave.ImageOptions.LargeImageIndex = 3;
            // 
            // bbiSaveAndDone
            // 
            this.bbiSaveAndDone.ImageOptions.ImageIndex = 4;
            this.bbiSaveAndDone.ImageOptions.LargeImageIndex = 4;
            // 
            // bbiReset
            // 
            this.bbiReset.ImageOptions.ImageIndex = 11;
            this.bbiReset.ImageOptions.LargeImageIndex = 11;
            // 
            // bbiDelete
            // 
            this.bbiDelete.ImageOptions.ImageIndex = 2;
            this.bbiDelete.ImageOptions.LargeImageIndex = 2;
            // 
            // bbiCopy
            // 
            this.bbiCopy.ImageOptions.ImageIndex = 5;
            this.bbiCopy.ImageOptions.LargeImageIndex = 5;
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.Controls.Add(this.dataLayoutControl1);
            this.dataLayoutControl.Controls.Add(this.peObjectIcon);
            this.dataLayoutControl.Controls.Add(this.DescriptionMemoEdit);
            this.dataLayoutControl.Controls.Add(this.CodeTextEdit);
            this.dataLayoutControl.DataSource = this.bsObject;
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            // 
            // bsObject
            // 
            this.bsObject.DataSource = typeof(Petoetron.Classes.Helpers.AbstractBaseObject);
            // 
            // flyoutPanel
            // 
            this.flyoutPanel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.flyoutPanel.Appearance.Options.UseBackColor = true;
            this.flyoutPanel.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDescription,
            this.ItemForCode,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(572, 396);
            // 
            // DescriptionMemoEdit
            // 
            this.DescriptionMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsObject, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DescriptionMemoEdit.Location = new System.Drawing.Point(126, 36);
            this.DescriptionMemoEdit.MenuManager = this.ribbonControl;
            this.DescriptionMemoEdit.Name = "DescriptionMemoEdit";
            this.DescriptionMemoEdit.Size = new System.Drawing.Size(454, 80);
            this.DescriptionMemoEdit.StyleController = this.dataLayoutControl;
            this.DescriptionMemoEdit.TabIndex = 4;
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionMemoEdit;
            this.ItemForDescription.Location = new System.Drawing.Point(114, 24);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(458, 84);
            this.ItemForDescription.StartNewLine = true;
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForDescription.TextVisible = false;
            // 
            // CodeTextEdit
            // 
            this.CodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsObject, "Code", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CodeTextEdit.Location = new System.Drawing.Point(126, 12);
            this.CodeTextEdit.MenuManager = this.ribbonControl;
            this.CodeTextEdit.Name = "CodeTextEdit";
            this.CodeTextEdit.Size = new System.Drawing.Size(454, 20);
            this.CodeTextEdit.StyleController = this.dataLayoutControl;
            this.CodeTextEdit.TabIndex = 5;
            // 
            // ItemForCode
            // 
            this.ItemForCode.Control = this.CodeTextEdit;
            this.ItemForCode.Location = new System.Drawing.Point(114, 0);
            this.ItemForCode.Name = "ItemForCode";
            this.ItemForCode.Size = new System.Drawing.Size(458, 24);
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
            this.peObjectIcon.Size = new System.Drawing.Size(110, 104);
            this.peObjectIcon.StyleController = this.dataLayoutControl;
            this.peObjectIcon.TabIndex = 6;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.peObjectIcon;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(114, 108);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.InfoMemoEdit);
            this.dataLayoutControl1.DataSource = this.bsObject;
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 120);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup2;
            this.dataLayoutControl1.Size = new System.Drawing.Size(568, 284);
            this.dataLayoutControl1.TabIndex = 7;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dataLayoutControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(572, 288);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(568, 284);
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
            this.layoutControlGroup3.Size = new System.Drawing.Size(548, 264);
            // 
            // InfoMemoEdit
            // 
            this.InfoMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsObject, "Info", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InfoMemoEdit.Location = new System.Drawing.Point(24, 67);
            this.InfoMemoEdit.MenuManager = this.ribbonControl;
            this.InfoMemoEdit.Name = "InfoMemoEdit";
            this.InfoMemoEdit.Size = new System.Drawing.Size(520, 193);
            this.InfoMemoEdit.StyleController = this.dataLayoutControl1;
            this.InfoMemoEdit.TabIndex = 4;
            // 
            // tabbedControlGroup
            // 
            this.tabbedControlGroup.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup.Name = "tabbedControlGroup";
            this.tabbedControlGroup.SelectedTabPage = this.lcgData;
            this.tabbedControlGroup.Size = new System.Drawing.Size(548, 264);
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
            this.lcgData.Size = new System.Drawing.Size(524, 213);
            this.lcgData.Text = "Dutu";
            // 
            // ItemForInfo
            // 
            this.ItemForInfo.Control = this.InfoMemoEdit;
            this.ItemForInfo.Location = new System.Drawing.Point(0, 0);
            this.ItemForInfo.Name = "ItemForInfo";
            this.ItemForInfo.Size = new System.Drawing.Size(524, 213);
            this.ItemForInfo.StartNewLine = true;
            this.ItemForInfo.Text = "Info";
            this.ItemForInfo.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForInfo.TextSize = new System.Drawing.Size(20, 13);
            // 
            // lcgDocuments
            // 
            this.lcgDocuments.Location = new System.Drawing.Point(0, 0);
            this.lcgDocuments.Name = "lcgDocuments";
            this.lcgDocuments.Size = new System.Drawing.Size(524, 213);
            this.lcgDocuments.Text = "Ducumunten";
            // 
            // lcgLogs
            // 
            this.lcgLogs.Location = new System.Drawing.Point(0, 0);
            this.lcgLogs.Name = "lcgLogs";
            this.lcgLogs.Size = new System.Drawing.Size(524, 213);
            this.lcgLogs.Text = "Lugs";
            // 
            // BaseObjectEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "BaseObjectEditView";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            this.dataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel)).EndInit();
            this.flyoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl)).EndInit();
            this.flyoutPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peObjectIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        protected DevExpress.XtraEditors.MemoEdit InfoMemoEdit;
        protected DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        protected DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        protected DevExpress.XtraEditors.PictureEdit peObjectIcon;
        protected DevExpress.XtraEditors.MemoEdit DescriptionMemoEdit;
        protected DevExpress.XtraEditors.TextEdit CodeTextEdit;
        protected DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        protected DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        protected DevExpress.XtraLayout.LayoutControlItem ItemForCode;
        protected DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        protected DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        protected DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgData;
        protected DevExpress.XtraLayout.LayoutControlItem ItemForInfo;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgDocuments;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgLogs;
        protected DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
    }
}
