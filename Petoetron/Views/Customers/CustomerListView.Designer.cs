namespace Petoetron.Views.Customers
{
    partial class CustomerListView
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
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFixedPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobilePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVat = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.bsEntities.DataSource = typeof(Petoetron.Classes.Customer);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bsEntities;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContactName,
            this.colStreet,
            this.colCity,
            this.colState,
            this.colZip,
            this.colFixedPhone,
            this.colMobilePhone,
            this.colVat,
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
            // 
            // colContactName
            // 
            this.colContactName.FieldName = "ContactName";
            this.colContactName.MinWidth = 25;
            this.colContactName.Name = "colContactName";
            this.colContactName.Visible = true;
            this.colContactName.VisibleIndex = 2;
            this.colContactName.Width = 286;
            // 
            // colStreet
            // 
            this.colStreet.FieldName = "Street";
            this.colStreet.MinWidth = 25;
            this.colStreet.Name = "colStreet";
            this.colStreet.Width = 94;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.MinWidth = 25;
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 3;
            this.colCity.Width = 286;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.MinWidth = 25;
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 4;
            this.colState.Width = 286;
            // 
            // colZip
            // 
            this.colZip.FieldName = "Zip";
            this.colZip.MinWidth = 25;
            this.colZip.Name = "colZip";
            this.colZip.Width = 94;
            // 
            // colFixedPhone
            // 
            this.colFixedPhone.FieldName = "FixedPhone";
            this.colFixedPhone.MinWidth = 25;
            this.colFixedPhone.Name = "colFixedPhone";
            this.colFixedPhone.Visible = true;
            this.colFixedPhone.VisibleIndex = 5;
            this.colFixedPhone.Width = 286;
            // 
            // colMobilePhone
            // 
            this.colMobilePhone.FieldName = "MobilePhone";
            this.colMobilePhone.MinWidth = 25;
            this.colMobilePhone.Name = "colMobilePhone";
            this.colMobilePhone.Visible = true;
            this.colMobilePhone.VisibleIndex = 6;
            this.colMobilePhone.Width = 287;
            // 
            // colVat
            // 
            this.colVat.FieldName = "Vat";
            this.colVat.MinWidth = 25;
            this.colVat.Name = "colVat";
            this.colVat.Width = 94;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 537;
            // 
            // colInfo
            // 
            this.colInfo.FieldName = "Info";
            this.colInfo.MinWidth = 25;
            this.colInfo.Name = "colInfo";
            this.colInfo.Width = 94;
            // 
            // colIconPath
            // 
            this.colIconPath.FieldName = "IconPath";
            this.colIconPath.MinWidth = 25;
            this.colIconPath.Name = "colIconPath";
            this.colIconPath.Width = 94;
            // 
            // colEnabled
            // 
            this.colEnabled.FieldName = "Enabled";
            this.colEnabled.MinWidth = 25;
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.Width = 94;
            // 
            // colLastModified
            // 
            this.colLastModified.FieldName = "LastModified";
            this.colLastModified.MinWidth = 25;
            this.colLastModified.Name = "colLastModified";
            this.colLastModified.Width = 94;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colCode.MinWidth = 25;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 94;
            // 
            // CustomerListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CustomerListView";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colStreet;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colZip;
        private DevExpress.XtraGrid.Columns.GridColumn colFixedPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colMobilePhone;
        private DevExpress.XtraGrid.Columns.GridColumn colVat;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colIconPath;
        private DevExpress.XtraGrid.Columns.GridColumn colEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModified;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
    }
}
