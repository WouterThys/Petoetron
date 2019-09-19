namespace Petoetron.Views.Reports
{
    partial class QuotationReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.detailTable = new DevExpress.XtraReports.UI.XRTable();
            this.detailTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.productName = new DevExpress.XtraReports.UI.XRTableCell();
            this.productDescription = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.invoiceInfoTable = new DevExpress.XtraReports.UI.XRTable();
            this.invoiceInfoTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceLabel = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceNumberRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceNumberCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceNumber = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceDateRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceDateCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceDueDateRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceDueDateCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.invoiceDueDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerTable = new DevExpress.XtraReports.UI.XRTable();
            this.customerTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.billToLabel = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerNameRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.customerName = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerAddressRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.customerAddress = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorTable = new DevExpress.XtraReports.UI.XRTable();
            this.vendorNameRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorName = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorAddressRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorAddress = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorEmailRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorEmail = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorPhoneRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorPhone = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorVatNumberRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorVATNumber = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.totalTable = new DevExpress.XtraReports.UI.XRTable();
            this.subtotalRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.subtotalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.subtotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.taxRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.taxCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.tax = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.totalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.total = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.headerTable = new DevExpress.XtraReports.UI.XRTable();
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.productNameCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.productDescriptionCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantityCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPriceCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceInfoTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.detailTable});
            this.Detail.HeightF = 40F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // detailTable
            // 
            this.detailTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(9.999164F, 10.00001F);
            this.detailTable.Name = "detailTable";
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow});
            this.detailTable.SizeF = new System.Drawing.SizeF(710F, 30F);
            this.detailTable.StylePriority.UseBackColor = false;
            this.detailTable.StylePriority.UseFont = false;
            // 
            // detailTableRow
            // 
            this.detailTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productName,
            this.productDescription,
            this.quantity,
            this.unitPrice,
            this.lineTotal});
            this.detailTableRow.Name = "detailTableRow";
            this.detailTableRow.Weight = 10.58D;
            // 
            // productName
            // 
            this.productName.Name = "productName";
            this.productName.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 5, 5, 5, 100F);
            this.productName.StylePriority.UsePadding = false;
            this.productName.Text = "ProductName";
            this.productName.Weight = 0.49905592520620479D;
            // 
            // productDescription
            // 
            this.productDescription.Name = "productDescription";
            this.productDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 5, 100F);
            this.productDescription.StylePriority.UsePadding = false;
            this.productDescription.Text = "ProductDescription";
            this.productDescription.Weight = 1.3224986339409652D;
            // 
            // quantity
            // 
            this.quantity.Name = "quantity";
            this.quantity.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 5, 100F);
            this.quantity.StylePriority.UsePadding = false;
            this.quantity.StylePriority.UseTextAlignment = false;
            this.quantity.Text = "1";
            this.quantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.quantity.Weight = 0.19962213837594336D;
            // 
            // unitPrice
            // 
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 5, 100F);
            this.unitPrice.StylePriority.UsePadding = false;
            this.unitPrice.StylePriority.UseTextAlignment = false;
            this.unitPrice.Text = "€0.00";
            this.unitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.unitPrice.TextFormatString = "{0:$0.00}";
            this.unitPrice.Weight = 0.37427719738871562D;
            // 
            // lineTotal
            // 
            this.lineTotal.Name = "lineTotal";
            this.lineTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 5, 5, 100F);
            this.lineTotal.StylePriority.UseFont = false;
            this.lineTotal.StylePriority.UseForeColor = false;
            this.lineTotal.StylePriority.UsePadding = false;
            this.lineTotal.StylePriority.UseTextAlignment = false;
            this.lineTotal.Text = "€0.00";
            this.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.lineTotal.TextFormatString = "{0:$0.00}";
            this.lineTotal.Weight = 0.53573238258834288D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 65F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.invoiceInfoTable,
            this.customerTable,
            this.vendorTable,
            this.vendorLogo});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 218F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StyleName = "baseControlStyle";
            this.GroupHeader2.StylePriority.UseBackColor = false;
            // 
            // invoiceInfoTable
            // 
            this.invoiceInfoTable.LocationFloat = new DevExpress.Utils.PointFloat(420.8333F, 10.00001F);
            this.invoiceInfoTable.Name = "invoiceInfoTable";
            this.invoiceInfoTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.invoiceInfoTableRow1,
            this.invoiceNumberRow,
            this.invoiceDateRow,
            this.invoiceDueDateRow});
            this.invoiceInfoTable.SizeF = new System.Drawing.SizeF(299.1659F, 110F);
            // 
            // invoiceInfoTableRow1
            // 
            this.invoiceInfoTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.invoiceLabel});
            this.invoiceInfoTableRow1.Name = "invoiceInfoTableRow1";
            this.invoiceInfoTableRow1.StylePriority.UseFont = false;
            this.invoiceInfoTableRow1.StylePriority.UseTextAlignment = false;
            this.invoiceInfoTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.invoiceInfoTableRow1.Weight = 2.0000001203963937D;
            // 
            // invoiceLabel
            // 
            this.invoiceLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceLabel.Name = "invoiceLabel";
            this.invoiceLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.invoiceLabel.StylePriority.UseFont = false;
            this.invoiceLabel.StylePriority.UsePadding = false;
            this.invoiceLabel.StylePriority.UseTextAlignment = false;
            this.invoiceLabel.Text = "INVOICE";
            this.invoiceLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.invoiceLabel.Weight = 1.6426447605650874D;
            // 
            // invoiceNumberRow
            // 
            this.invoiceNumberRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.invoiceNumberCaption,
            this.invoiceNumber});
            this.invoiceNumberRow.Name = "invoiceNumberRow";
            this.invoiceNumberRow.Weight = 0.80000006941199275D;
            // 
            // invoiceNumberCaption
            // 
            this.invoiceNumberCaption.CanShrink = true;
            this.invoiceNumberCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNumberCaption.Name = "invoiceNumberCaption";
            this.invoiceNumberCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.invoiceNumberCaption.StylePriority.UseFont = false;
            this.invoiceNumberCaption.StylePriority.UsePadding = false;
            this.invoiceNumberCaption.StylePriority.UseTextAlignment = false;
            this.invoiceNumberCaption.Text = "INVOICE #";
            this.invoiceNumberCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.invoiceNumberCaption.Weight = 0.54753422741896873D;
            // 
            // invoiceNumber
            // 
            this.invoiceNumber.CanShrink = true;
            this.invoiceNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Code]")});
            this.invoiceNumber.Name = "invoiceNumber";
            this.invoiceNumber.StylePriority.UseFont = false;
            this.invoiceNumber.StylePriority.UsePadding = false;
            this.invoiceNumber.Weight = 1.0951105331461186D;
            // 
            // invoiceDateRow
            // 
            this.invoiceDateRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.invoiceDateCaption,
            this.invoiceDate});
            this.invoiceDateRow.Name = "invoiceDateRow";
            this.invoiceDateRow.Weight = 0.80000006941199264D;
            // 
            // invoiceDateCaption
            // 
            this.invoiceDateCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDateCaption.Name = "invoiceDateCaption";
            this.invoiceDateCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.invoiceDateCaption.StylePriority.UseFont = false;
            this.invoiceDateCaption.StylePriority.UsePadding = false;
            this.invoiceDateCaption.StylePriority.UseTextAlignment = false;
            this.invoiceDateCaption.Text = "INVOICE DATE";
            this.invoiceDateCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.invoiceDateCaption.Weight = 0.54753422741896873D;
            // 
            // invoiceDate
            // 
            this.invoiceDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DeliveryDate]")});
            this.invoiceDate.Name = "invoiceDate";
            this.invoiceDate.StylePriority.UseFont = false;
            this.invoiceDate.StylePriority.UsePadding = false;
            this.invoiceDate.TextFormatString = "{0:d MMMM yyyy}";
            this.invoiceDate.Weight = 1.0951105331461186D;
            // 
            // invoiceDueDateRow
            // 
            this.invoiceDueDateRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.invoiceDueDateCaption,
            this.invoiceDueDate});
            this.invoiceDueDateRow.Name = "invoiceDueDateRow";
            this.invoiceDueDateRow.Weight = 0.799999993118043D;
            // 
            // invoiceDueDateCaption
            // 
            this.invoiceDueDateCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDueDateCaption.Name = "invoiceDueDateCaption";
            this.invoiceDueDateCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.invoiceDueDateCaption.StylePriority.UseFont = false;
            this.invoiceDueDateCaption.StylePriority.UsePadding = false;
            this.invoiceDueDateCaption.StylePriority.UseTextAlignment = false;
            this.invoiceDueDateCaption.Text = "DUE DATE";
            this.invoiceDueDateCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.invoiceDueDateCaption.Weight = 0.54753422741896873D;
            // 
            // invoiceDueDate
            // 
            this.invoiceDueDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DueDate]")});
            this.invoiceDueDate.Name = "invoiceDueDate";
            this.invoiceDueDate.StylePriority.UseFont = false;
            this.invoiceDueDate.StylePriority.UsePadding = false;
            this.invoiceDueDate.TextFormatString = "{0:d MMMM yyyy}";
            this.invoiceDueDate.Weight = 1.0951105331461186D;
            // 
            // customerTable
            // 
            this.customerTable.LocationFloat = new DevExpress.Utils.PointFloat(470.0001F, 120F);
            this.customerTable.Name = "customerTable";
            this.customerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.customerTableRow1,
            this.customerNameRow,
            this.customerAddressRow});
            this.customerTable.SizeF = new System.Drawing.SizeF(250F, 65F);
            // 
            // customerTableRow1
            // 
            this.customerTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.billToLabel});
            this.customerTableRow1.Name = "customerTableRow1";
            this.customerTableRow1.Weight = 1.0000001017252733D;
            // 
            // billToLabel
            // 
            this.billToLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billToLabel.Name = "billToLabel";
            this.billToLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.billToLabel.StylePriority.UseFont = false;
            this.billToLabel.StylePriority.UsePadding = false;
            this.billToLabel.StylePriority.UseTextAlignment = false;
            this.billToLabel.Text = "BILL TO";
            this.billToLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.billToLabel.Weight = 2.3302581457621914D;
            // 
            // customerNameRow
            // 
            this.customerNameRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.customerName});
            this.customerNameRow.Name = "customerNameRow";
            this.customerNameRow.Weight = 0.80000011444093255D;
            // 
            // customerName
            // 
            this.customerName.CanShrink = true;
            this.customerName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Customer.Code]")});
            this.customerName.Name = "customerName";
            this.customerName.StylePriority.UseFont = false;
            this.customerName.StylePriority.UsePadding = false;
            this.customerName.Weight = 2.3302581457621914D;
            // 
            // customerAddressRow
            // 
            this.customerAddressRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.customerAddress});
            this.customerAddressRow.Name = "customerAddressRow";
            this.customerAddressRow.Weight = 0.80000011444093244D;
            // 
            // customerAddress
            // 
            this.customerAddress.CanShrink = true;
            this.customerAddress.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Customer.Street]")});
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Weight = 2.3302581457621914D;
            // 
            // vendorTable
            // 
            this.vendorTable.LocationFloat = new DevExpress.Utils.PointFloat(166.876F, 0F);
            this.vendorTable.Name = "vendorTable";
            this.vendorTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.vendorNameRow,
            this.vendorAddressRow,
            this.vendorEmailRow,
            this.vendorPhoneRow,
            this.vendorVatNumberRow});
            this.vendorTable.SizeF = new System.Drawing.SizeF(250F, 130F);
            // 
            // vendorNameRow
            // 
            this.vendorNameRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorName});
            this.vendorNameRow.Name = "vendorNameRow";
            this.vendorNameRow.StylePriority.UseTextAlignment = false;
            this.vendorNameRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.vendorNameRow.Weight = 1.8181822191978998D;
            // 
            // vendorName
            // 
            this.vendorName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MyInfo.CompanyName]")});
            this.vendorName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorName.Name = "vendorName";
            this.vendorName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.vendorName.StylePriority.UseFont = false;
            this.vendorName.StylePriority.UsePadding = false;
            this.vendorName.Weight = 1D;
            // 
            // vendorAddressRow
            // 
            this.vendorAddressRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorAddress});
            this.vendorAddressRow.Name = "vendorAddressRow";
            this.vendorAddressRow.Weight = 0.72727266295882753D;
            // 
            // vendorAddress
            // 
            this.vendorAddress.CanShrink = true;
            this.vendorAddress.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MyInfo].[Address]")});
            this.vendorAddress.Multiline = true;
            this.vendorAddress.Name = "vendorAddress";
            this.vendorAddress.StylePriority.UseFont = false;
            this.vendorAddress.StylePriority.UsePadding = false;
            this.vendorAddress.Weight = 1D;
            // 
            // vendorEmailRow
            // 
            this.vendorEmailRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorEmail});
            this.vendorEmailRow.Name = "vendorEmailRow";
            this.vendorEmailRow.Weight = 0.72727266295882731D;
            // 
            // vendorEmail
            // 
            this.vendorEmail.CanShrink = true;
            this.vendorEmail.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MyInfo].[Email]")});
            this.vendorEmail.Name = "vendorEmail";
            this.vendorEmail.StylePriority.UseFont = false;
            this.vendorEmail.Weight = 1D;
            // 
            // vendorPhoneRow
            // 
            this.vendorPhoneRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorPhone});
            this.vendorPhoneRow.Name = "vendorPhoneRow";
            this.vendorPhoneRow.Weight = 0.72727273231695466D;
            // 
            // vendorPhone
            // 
            this.vendorPhone.CanShrink = true;
            this.vendorPhone.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MyInfo].[Phone]")});
            this.vendorPhone.Name = "vendorPhone";
            this.vendorPhone.StylePriority.UseFont = false;
            this.vendorPhone.Weight = 1D;
            // 
            // vendorVatNumberRow
            // 
            this.vendorVatNumberRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorVATNumber});
            this.vendorVatNumberRow.Name = "vendorVatNumberRow";
            this.vendorVatNumberRow.Weight = 0.72727273231695466D;
            // 
            // vendorVATNumber
            // 
            this.vendorVATNumber.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MyInfo].[VATNumber]")});
            this.vendorVATNumber.Multiline = true;
            this.vendorVATNumber.Name = "vendorVATNumber";
            this.vendorVATNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.vendorVATNumber.Text = "vendorVATNumber";
            this.vendorVATNumber.Weight = 1D;
            // 
            // vendorLogo
            // 
            this.vendorLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleLeft;
            this.vendorLogo.ImageUrl = "Config\\logo.jpg";
            this.vendorLogo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.vendorLogo.Name = "vendorLogo";
            this.vendorLogo.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.vendorLogo.SizeF = new System.Drawing.SizeF(166.876F, 130F);
            this.vendorLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.vendorLogo.StylePriority.UseBorderColor = false;
            this.vendorLogo.StylePriority.UseBorders = false;
            this.vendorLogo.StylePriority.UsePadding = false;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.totalTable});
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 128F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry;
            this.GroupFooter1.StyleName = "baseControlStyle";
            // 
            // totalTable
            // 
            this.totalTable.BorderColor = System.Drawing.Color.White;
            this.totalTable.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.totalTable.BorderWidth = 10F;
            this.totalTable.ForeColor = System.Drawing.Color.Black;
            this.totalTable.LocationFloat = new DevExpress.Utils.PointFloat(374.9999F, 22.50001F);
            this.totalTable.Name = "totalTable";
            this.totalTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.subtotalRow,
            this.taxRow,
            this.totalRow});
            this.totalTable.SizeF = new System.Drawing.SizeF(345.0002F, 105F);
            this.totalTable.StylePriority.UseBorderColor = false;
            this.totalTable.StylePriority.UseBorders = false;
            this.totalTable.StylePriority.UseBorderWidth = false;
            this.totalTable.StylePriority.UseForeColor = false;
            // 
            // subtotalRow
            // 
            this.subtotalRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.subtotalCaption,
            this.subtotal});
            this.subtotalRow.Name = "subtotalRow";
            this.subtotalRow.Weight = 1.4000000000000001D;
            // 
            // subtotalCaption
            // 
            this.subtotalCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalCaption.Name = "subtotalCaption";
            this.subtotalCaption.StylePriority.UseFont = false;
            this.subtotalCaption.StylePriority.UseTextAlignment = false;
            this.subtotalCaption.Text = "SUBTOTAL";
            this.subtotalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.subtotalCaption.Weight = 0.84464081370499255D;
            // 
            // subtotal
            // 
            this.subtotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subtotal.Name = "subtotal";
            this.subtotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.subtotal.StylePriority.UseBackColor = false;
            this.subtotal.StylePriority.UseFont = false;
            this.subtotal.StylePriority.UsePadding = false;
            this.subtotal.StylePriority.UseTextAlignment = false;
            this.subtotal.Text = "€0.00";
            this.subtotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.subtotal.TextFormatString = "{0:$0.00}";
            this.subtotal.Weight = 1.6893521735999855D;
            // 
            // taxRow
            // 
            this.taxRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.taxCaption,
            this.tax});
            this.taxRow.Name = "taxRow";
            this.taxRow.Weight = 1.4000000000000001D;
            // 
            // taxCaption
            // 
            this.taxCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxCaption.Name = "taxCaption";
            this.taxCaption.StylePriority.UseFont = false;
            this.taxCaption.StylePriority.UseTextAlignment = false;
            this.taxCaption.Text = "TAX";
            this.taxCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.taxCaption.Weight = 0.84464081370499255D;
            // 
            // tax
            // 
            this.tax.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tax.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tax]")});
            this.tax.Name = "tax";
            this.tax.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
            this.tax.StylePriority.UseBackColor = false;
            this.tax.StylePriority.UseFont = false;
            this.tax.StylePriority.UsePadding = false;
            this.tax.StylePriority.UseTextAlignment = false;
            this.tax.Text = "$0";
            this.tax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tax.TextFormatString = "{0:$0.00}";
            this.tax.Weight = 1.6893521735999855D;
            // 
            // totalRow
            // 
            this.totalRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.totalCaption,
            this.total});
            this.totalRow.Name = "totalRow";
            this.totalRow.Weight = 1.3999999999999997D;
            // 
            // totalCaption
            // 
            this.totalCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCaption.Name = "totalCaption";
            this.totalCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 5, 100F);
            this.totalCaption.StylePriority.UseFont = false;
            this.totalCaption.StylePriority.UsePadding = false;
            this.totalCaption.StylePriority.UseTextAlignment = false;
            this.totalCaption.Text = "TOTAL";
            this.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.totalCaption.Weight = 0.84464081370499255D;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.total.Name = "total";
            this.total.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 5, 100F);
            this.total.StylePriority.UseBackColor = false;
            this.total.StylePriority.UseFont = false;
            this.total.StylePriority.UsePadding = false;
            this.total.StylePriority.UseTextAlignment = false;
            this.total.Text = "€0.00";
            this.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.total.TextFormatString = "{0:$0.00}";
            this.total.Weight = 1.6893521735999855D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.headerTable});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 25F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StyleName = "baseControlStyle";
            // 
            // headerTable
            // 
            this.headerTable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTable.LocationFloat = new DevExpress.Utils.PointFloat(10.00126F, 0F);
            this.headerTable.Name = "headerTable";
            this.headerTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.headerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.headerTableRow});
            this.headerTable.SizeF = new System.Drawing.SizeF(709.9987F, 25F);
            this.headerTable.StylePriority.UseFont = false;
            this.headerTable.StylePriority.UsePadding = false;
            // 
            // headerTableRow
            // 
            this.headerTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productNameCaption,
            this.productDescriptionCaption,
            this.quantityCaption,
            this.unitPriceCaption,
            this.lineTotalCaption});
            this.headerTableRow.Name = "headerTableRow";
            this.headerTableRow.Weight = 11.5D;
            // 
            // productNameCaption
            // 
            this.productNameCaption.Name = "productNameCaption";
            this.productNameCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 5, 0, 100F);
            this.productNameCaption.StylePriority.UsePadding = false;
            this.productNameCaption.Text = "ITEM";
            this.productNameCaption.Weight = 0.62501539444733323D;
            // 
            // productDescriptionCaption
            // 
            this.productDescriptionCaption.Name = "productDescriptionCaption";
            this.productDescriptionCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.productDescriptionCaption.StylePriority.UsePadding = false;
            this.productDescriptionCaption.Text = "DESCRIPTION";
            this.productDescriptionCaption.Weight = 1.6563109818698798D;
            // 
            // quantityCaption
            // 
            this.quantityCaption.Name = "quantityCaption";
            this.quantityCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.quantityCaption.StylePriority.UsePadding = false;
            this.quantityCaption.StylePriority.UseTextAlignment = false;
            this.quantityCaption.Text = "QTY";
            this.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.quantityCaption.Weight = 0.25000923340865683D;
            // 
            // unitPriceCaption
            // 
            this.unitPriceCaption.Name = "unitPriceCaption";
            this.unitPriceCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.unitPriceCaption.StylePriority.UsePadding = false;
            this.unitPriceCaption.StylePriority.UseTextAlignment = false;
            this.unitPriceCaption.Text = "PRICE";
            this.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.unitPriceCaption.Weight = 0.46874727898816382D;
            // 
            // lineTotalCaption
            // 
            this.lineTotalCaption.Name = "lineTotalCaption";
            this.lineTotalCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 5, 0, 100F);
            this.lineTotalCaption.StylePriority.UsePadding = false;
            this.lineTotalCaption.StylePriority.UseTextAlignment = false;
            this.lineTotalCaption.Text = "TOTAL";
            this.lineTotalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.lineTotalCaption.Weight = 0.68754517279656213D;
            // 
            // baseControlStyle
            // 
            this.baseControlStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baseControlStyle.Name = "baseControlStyle";
            this.baseControlStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(Petoetron.Classes.Quotation);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // QuotationReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader2,
            this.GroupFooter1,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(60, 60, 65, 100);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceInfoTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable detailTable;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow;
        private DevExpress.XtraReports.UI.XRTableCell productName;
        private DevExpress.XtraReports.UI.XRTableCell productDescription;
        private DevExpress.XtraReports.UI.XRTableCell quantity;
        private DevExpress.XtraReports.UI.XRTableCell unitPrice;
        private DevExpress.XtraReports.UI.XRTableCell lineTotal;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRTable invoiceInfoTable;
        private DevExpress.XtraReports.UI.XRTableRow invoiceInfoTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell invoiceLabel;
        private DevExpress.XtraReports.UI.XRTableRow invoiceNumberRow;
        private DevExpress.XtraReports.UI.XRTableCell invoiceNumberCaption;
        private DevExpress.XtraReports.UI.XRTableCell invoiceNumber;
        private DevExpress.XtraReports.UI.XRTableRow invoiceDateRow;
        private DevExpress.XtraReports.UI.XRTableCell invoiceDateCaption;
        private DevExpress.XtraReports.UI.XRTableCell invoiceDate;
        private DevExpress.XtraReports.UI.XRTableRow invoiceDueDateRow;
        private DevExpress.XtraReports.UI.XRTableCell invoiceDueDateCaption;
        private DevExpress.XtraReports.UI.XRTableCell invoiceDueDate;
        private DevExpress.XtraReports.UI.XRTable customerTable;
        private DevExpress.XtraReports.UI.XRTableRow customerTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell billToLabel;
        private DevExpress.XtraReports.UI.XRTableRow customerNameRow;
        private DevExpress.XtraReports.UI.XRTableCell customerName;
        private DevExpress.XtraReports.UI.XRTableRow customerAddressRow;
        private DevExpress.XtraReports.UI.XRTableCell customerAddress;
        private DevExpress.XtraReports.UI.XRTable vendorTable;
        private DevExpress.XtraReports.UI.XRTableRow vendorNameRow;
        private DevExpress.XtraReports.UI.XRTableCell vendorName;
        private DevExpress.XtraReports.UI.XRTableRow vendorAddressRow;
        private DevExpress.XtraReports.UI.XRTableCell vendorAddress;
        private DevExpress.XtraReports.UI.XRTableRow vendorEmailRow;
        private DevExpress.XtraReports.UI.XRTableCell vendorEmail;
        private DevExpress.XtraReports.UI.XRTableRow vendorPhoneRow;
        private DevExpress.XtraReports.UI.XRTableCell vendorPhone;
        private DevExpress.XtraReports.UI.XRPictureBox vendorLogo;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRTable totalTable;
        private DevExpress.XtraReports.UI.XRTableRow subtotalRow;
        private DevExpress.XtraReports.UI.XRTableCell subtotalCaption;
        private DevExpress.XtraReports.UI.XRTableCell subtotal;
        private DevExpress.XtraReports.UI.XRTableRow taxRow;
        private DevExpress.XtraReports.UI.XRTableCell taxCaption;
        private DevExpress.XtraReports.UI.XRTableCell tax;
        private DevExpress.XtraReports.UI.XRTableRow totalRow;
        private DevExpress.XtraReports.UI.XRTableCell totalCaption;
        private DevExpress.XtraReports.UI.XRTableCell total;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable headerTable;
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow;
        private DevExpress.XtraReports.UI.XRTableCell productNameCaption;
        private DevExpress.XtraReports.UI.XRTableCell productDescriptionCaption;
        private DevExpress.XtraReports.UI.XRTableCell quantityCaption;
        private DevExpress.XtraReports.UI.XRTableCell unitPriceCaption;
        private DevExpress.XtraReports.UI.XRTableCell lineTotalCaption;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.UI.XRTableRow vendorVatNumberRow;
        private DevExpress.XtraReports.UI.XRTableCell vendorVATNumber;
    }
}
