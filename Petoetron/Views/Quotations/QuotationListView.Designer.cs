namespace Petoetron.Views.Quotations
{
    partial class QuotationListView
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
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIconPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpgReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiInvoice = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntities
            // 
            this.bsEntities.DataSource = typeof(Petoetron.Classes.Quotation);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bsEntities;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerId,
            this.colDeliveryDate,
            this.colDescription,
            this.colInfo,
            this.colIconPath,
            this.colEnabled,
            this.colLastModified,
            this.colId,
            this.colCode});
            // 
            // bbiAdd
            // 
            this.bbiAdd.ImageOptions.ImageIndex = 0;
            this.bbiAdd.ImageOptions.LargeImageIndex = 0;
            // 
            // bbiEdit
            // 
            this.bbiEdit.ImageOptions.ImageIndex = 1;
            this.bbiEdit.ImageOptions.LargeImageIndex = 1;
            // 
            // bbiDelete
            // 
            this.bbiDelete.ImageOptions.ImageIndex = 2;
            this.bbiDelete.ImageOptions.LargeImageIndex = 2;
            // 
            // bbiPrint
            // 
            this.bbiPrint.ImageOptions.ImageIndex = 8;
            this.bbiPrint.ImageOptions.LargeImageIndex = 8;
            // 
            // bbiExport
            // 
            this.bbiExport.ImageOptions.ImageIndex = 10;
            this.bbiExport.ImageOptions.LargeImageIndex = 10;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiInvoice});
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.ribbonControl.MaxItemId = 7;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgReports});
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Width = 64;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.FieldName = "DeliveryDate";
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.Visible = true;
            this.colDeliveryDate.VisibleIndex = 2;
            this.colDeliveryDate.Width = 551;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 549;
            // 
            // colInfo
            // 
            this.colInfo.FieldName = "Info";
            this.colInfo.Name = "colInfo";
            this.colInfo.Width = 64;
            // 
            // colIconPath
            // 
            this.colIconPath.FieldName = "IconPath";
            this.colIconPath.Name = "colIconPath";
            this.colIconPath.Width = 64;
            // 
            // colEnabled
            // 
            this.colEnabled.FieldName = "Enabled";
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.Width = 64;
            // 
            // colLastModified
            // 
            this.colLastModified.FieldName = "LastModified";
            this.colLastModified.Name = "colLastModified";
            this.colLastModified.Width = 64;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colId.Name = "colId";
            this.colId.Width = 64;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 136;
            // 
            // rpgReports
            // 
            this.rpgReports.ItemLinks.Add(this.bbiInvoice);
            this.rpgReports.Name = "rpgReports";
            this.rpgReports.Text = "Rupurten";
            // 
            // bbiInvoice
            // 
            this.bbiInvoice.Caption = "Fuctuur";
            this.bbiInvoice.Id = 6;
            this.bbiInvoice.ImageOptions.ImageIndex = 21;
            this.bbiInvoice.ImageOptions.LargeImageIndex = 21;
            this.bbiInvoice.Name = "bbiInvoice";
            // 
            // QuotationListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "QuotationListView";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colIconPath;
        private DevExpress.XtraGrid.Columns.GridColumn colEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModified;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraBars.BarButtonItem bbiInvoice;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgReports;
    }
}
