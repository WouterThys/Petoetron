namespace Petoetron.Views.QuotationPrices
{
    partial class QuotationPriceEditView
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.AmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.DateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.InfoMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.PriceTypePriceTypeUnitImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.CodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPriceTypePriceTypeUnit = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsQuotationPrice = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTypePriceTypeUnitImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPriceTypePriceTypeUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuotationPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.Controls.Add(this.AmountSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.DateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.InfoMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.PriceTypePriceTypeUnitImageComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.CodeTextEdit);
            this.dataLayoutControl1.DataSource = this.bsQuotationPrice;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(572, 259);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // AmountSpinEdit
            // 
            this.AmountSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotationPrice, "Amount", true));
            this.AmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AmountSpinEdit.Location = new System.Drawing.Point(59, 38);
            this.AmountSpinEdit.Name = "AmountSpinEdit";
            this.AmountSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AmountSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AmountSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.AmountSpinEdit.Properties.Mask.EditMask = "F";
            this.AmountSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountSpinEdit.Size = new System.Drawing.Size(388, 24);
            this.AmountSpinEdit.StyleController = this.dataLayoutControl1;
            this.AmountSpinEdit.TabIndex = 4;
            // 
            // DateDateEdit
            // 
            this.DateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotationPrice, "Date", true));
            this.DateDateEdit.EditValue = null;
            this.DateDateEdit.Location = new System.Drawing.Point(59, 66);
            this.DateDateEdit.Name = "DateDateEdit";
            this.DateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Size = new System.Drawing.Size(501, 22);
            this.DateDateEdit.StyleController = this.dataLayoutControl1;
            this.DateDateEdit.TabIndex = 5;
            // 
            // InfoMemoEdit
            // 
            this.InfoMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotationPrice, "Info", true));
            this.InfoMemoEdit.Location = new System.Drawing.Point(12, 111);
            this.InfoMemoEdit.Name = "InfoMemoEdit";
            this.InfoMemoEdit.Size = new System.Drawing.Size(548, 136);
            this.InfoMemoEdit.StyleController = this.dataLayoutControl1;
            this.InfoMemoEdit.TabIndex = 6;
            // 
            // PriceTypePriceTypeUnitImageComboBoxEdit
            // 
            this.PriceTypePriceTypeUnitImageComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotationPrice, "PriceType.PriceTypeUnit", true));
            this.PriceTypePriceTypeUnitImageComboBoxEdit.Location = new System.Drawing.Point(451, 38);
            this.PriceTypePriceTypeUnitImageComboBoxEdit.Name = "PriceTypePriceTypeUnitImageComboBoxEdit";
            this.PriceTypePriceTypeUnitImageComboBoxEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PriceTypePriceTypeUnitImageComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PriceTypePriceTypeUnitImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PriceTypePriceTypeUnitImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("PerHour", Petoetron.Classes.Helpers.PriceTypeUnit.PerHour, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("PerKm", Petoetron.Classes.Helpers.PriceTypeUnit.PerKm, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("PerKg", Petoetron.Classes.Helpers.PriceTypeUnit.PerKg, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("PerM", Petoetron.Classes.Helpers.PriceTypeUnit.PerM, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Fixed", Petoetron.Classes.Helpers.PriceTypeUnit.Fixed, 4)});
            this.PriceTypePriceTypeUnitImageComboBoxEdit.Properties.UseCtrlScroll = true;
            this.PriceTypePriceTypeUnitImageComboBoxEdit.Size = new System.Drawing.Size(109, 22);
            this.PriceTypePriceTypeUnitImageComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.PriceTypePriceTypeUnitImageComboBoxEdit.TabIndex = 7;
            // 
            // CodeTextEdit
            // 
            this.CodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotationPrice, "Code", true));
            this.CodeTextEdit.Location = new System.Drawing.Point(59, 12);
            this.CodeTextEdit.Name = "CodeTextEdit";
            this.CodeTextEdit.Size = new System.Drawing.Size(501, 22);
            this.CodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CodeTextEdit.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(572, 259);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAmount,
            this.ItemForDate,
            this.ItemForInfo,
            this.ItemForCode,
            this.ItemForPriceTypePriceTypeUnit});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(552, 239);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountSpinEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 26);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(439, 28);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(44, 16);
            // 
            // ItemForDate
            // 
            this.ItemForDate.Control = this.DateDateEdit;
            this.ItemForDate.Location = new System.Drawing.Point(0, 54);
            this.ItemForDate.Name = "ItemForDate";
            this.ItemForDate.Size = new System.Drawing.Size(552, 26);
            this.ItemForDate.Text = "Date";
            this.ItemForDate.TextSize = new System.Drawing.Size(44, 16);
            // 
            // ItemForInfo
            // 
            this.ItemForInfo.Control = this.InfoMemoEdit;
            this.ItemForInfo.Location = new System.Drawing.Point(0, 80);
            this.ItemForInfo.Name = "ItemForInfo";
            this.ItemForInfo.Size = new System.Drawing.Size(552, 159);
            this.ItemForInfo.StartNewLine = true;
            this.ItemForInfo.Text = "Info";
            this.ItemForInfo.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForInfo.TextSize = new System.Drawing.Size(44, 16);
            // 
            // ItemForCode
            // 
            this.ItemForCode.Control = this.CodeTextEdit;
            this.ItemForCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCode.Name = "ItemForCode";
            this.ItemForCode.Size = new System.Drawing.Size(552, 26);
            this.ItemForCode.Text = "Code";
            this.ItemForCode.TextSize = new System.Drawing.Size(44, 16);
            // 
            // ItemForPriceTypePriceTypeUnit
            // 
            this.ItemForPriceTypePriceTypeUnit.Control = this.PriceTypePriceTypeUnitImageComboBoxEdit;
            this.ItemForPriceTypePriceTypeUnit.Location = new System.Drawing.Point(439, 26);
            this.ItemForPriceTypePriceTypeUnit.Name = "ItemForPriceTypePriceTypeUnit";
            this.ItemForPriceTypePriceTypeUnit.Size = new System.Drawing.Size(113, 28);
            this.ItemForPriceTypePriceTypeUnit.Text = "Price Type Unit";
            this.ItemForPriceTypePriceTypeUnit.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForPriceTypePriceTypeUnit.TextVisible = false;
            // 
            // bsQuotationPrice
            // 
            this.bsQuotationPrice.DataSource = typeof(Petoetron.Classes.QuotationPrice);
            // 
            // QuotationPriceEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "QuotationPriceEditView";
            this.Size = new System.Drawing.Size(572, 259);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTypePriceTypeUnitImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPriceTypePriceTypeUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuotationPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource bsQuotationPrice;
        private DevExpress.XtraEditors.SpinEdit AmountSpinEdit;
        private DevExpress.XtraEditors.DateEdit DateDateEdit;
        private DevExpress.XtraEditors.MemoEdit InfoMemoEdit;
        private DevExpress.XtraEditors.ImageComboBoxEdit PriceTypePriceTypeUnitImageComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit CodeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInfo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPriceTypePriceTypeUnit;
    }
}
