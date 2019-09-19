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
            this.gridView.DetailHeight = 284;
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
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.MinWidth = 17;
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Width = 55;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.FieldName = "DeliveryDate";
            this.colDeliveryDate.MinWidth = 17;
            this.colDeliveryDate.Name = "colDeliveryDate";
            this.colDeliveryDate.Visible = true;
            this.colDeliveryDate.VisibleIndex = 2;
            this.colDeliveryDate.Width = 472;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 17;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 471;
            // 
            // colInfo
            // 
            this.colInfo.FieldName = "Info";
            this.colInfo.MinWidth = 17;
            this.colInfo.Name = "colInfo";
            this.colInfo.Width = 55;
            // 
            // colIconPath
            // 
            this.colIconPath.FieldName = "IconPath";
            this.colIconPath.MinWidth = 17;
            this.colIconPath.Name = "colIconPath";
            this.colIconPath.Width = 55;
            // 
            // colEnabled
            // 
            this.colEnabled.FieldName = "Enabled";
            this.colEnabled.MinWidth = 17;
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.Width = 55;
            // 
            // colLastModified
            // 
            this.colLastModified.FieldName = "LastModified";
            this.colLastModified.MinWidth = 17;
            this.colLastModified.Name = "colLastModified";
            this.colLastModified.Width = 55;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colId.MinWidth = 17;
            this.colId.Name = "colId";
            this.colId.Width = 55;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colCode.MinWidth = 17;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 117;
            // 
            // QuotationListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
