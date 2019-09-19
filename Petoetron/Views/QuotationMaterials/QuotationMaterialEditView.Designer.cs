namespace Petoetron.Views.QuotationMaterials
{
    partial class QuotationMaterialEditView
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
            this.bsQuotationMaterial = new System.Windows.Forms.BindingSource(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.AmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.DateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.InfoMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.MaterialIdSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bsMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaterialUnitImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.CodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMaterialUnit = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMaterialId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCode = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuotationMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialIdSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialUnitImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaterialUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaterialId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).BeginInit();
            this.SuspendLayout();
            // 
            // bsQuotationMaterial
            // 
            this.bsQuotationMaterial.DataSource = typeof(Petoetron.Classes.QuotationMaterial);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.Controls.Add(this.AmountSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.DateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.InfoMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.MaterialIdSearchLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.MaterialUnitImageComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.CodeTextEdit);
            this.dataLayoutControl1.DataSource = this.bsQuotationMaterial;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(649, 313);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // AmountSpinEdit
            // 
            this.AmountSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotationMaterial, "Amount", true));
            this.AmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AmountSpinEdit.Location = new System.Drawing.Point(68, 64);
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
            this.DateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotationMaterial, "Date", true));
            this.DateDateEdit.EditValue = null;
            this.DateDateEdit.Location = new System.Drawing.Point(68, 92);
            this.DateDateEdit.Name = "DateDateEdit";
            this.DateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Size = new System.Drawing.Size(569, 22);
            this.DateDateEdit.StyleController = this.dataLayoutControl1;
            this.DateDateEdit.TabIndex = 5;
            // 
            // InfoMemoEdit
            // 
            this.InfoMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotationMaterial, "Info", true));
            this.InfoMemoEdit.Location = new System.Drawing.Point(12, 137);
            this.InfoMemoEdit.Name = "InfoMemoEdit";
            this.InfoMemoEdit.Size = new System.Drawing.Size(625, 164);
            this.InfoMemoEdit.StyleController = this.dataLayoutControl1;
            this.InfoMemoEdit.TabIndex = 6;
            // 
            // MaterialIdSearchLookUpEdit
            // 
            this.MaterialIdSearchLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotationMaterial, "MaterialId", true));
            this.MaterialIdSearchLookUpEdit.Location = new System.Drawing.Point(68, 12);
            this.MaterialIdSearchLookUpEdit.Name = "MaterialIdSearchLookUpEdit";
            this.MaterialIdSearchLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.MaterialIdSearchLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.MaterialIdSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MaterialIdSearchLookUpEdit.Properties.DataSource = this.bsMaterials;
            this.MaterialIdSearchLookUpEdit.Properties.DisplayMember = "Code";
            this.MaterialIdSearchLookUpEdit.Properties.NullText = "";
            this.MaterialIdSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.MaterialIdSearchLookUpEdit.Properties.ValueMember = "Id";
            this.MaterialIdSearchLookUpEdit.Size = new System.Drawing.Size(569, 22);
            this.MaterialIdSearchLookUpEdit.StyleController = this.dataLayoutControl1;
            this.MaterialIdSearchLookUpEdit.TabIndex = 7;
            // 
            // bsMaterials
            // 
            this.bsMaterials.DataSource = typeof(Petoetron.Classes.Material);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnitPrice,
            this.colUnit,
            this.colWeight,
            this.colType,
            this.colDescription,
            this.colInfo,
            this.colId,
            this.colCode});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            // 
            // colWeight
            // 
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "Type.Code";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.ReadOnly = true;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 0;
            this.colType.Width = 250;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 455;
            // 
            // colInfo
            // 
            this.colInfo.FieldName = "Info";
            this.colInfo.Name = "colInfo";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 452;
            // 
            // MaterialUnitImageComboBoxEdit
            // 
            this.MaterialUnitImageComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotationMaterial, "Material.Unit", true));
            this.MaterialUnitImageComboBoxEdit.Location = new System.Drawing.Point(460, 64);
            this.MaterialUnitImageComboBoxEdit.Name = "MaterialUnitImageComboBoxEdit";
            this.MaterialUnitImageComboBoxEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.MaterialUnitImageComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MaterialUnitImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MaterialUnitImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("lm", Petoetron.Classes.Helpers.MaterialUnit.lm, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("kg", Petoetron.Classes.Helpers.MaterialUnit.kg, 1)});
            this.MaterialUnitImageComboBoxEdit.Properties.UseCtrlScroll = true;
            this.MaterialUnitImageComboBoxEdit.Size = new System.Drawing.Size(177, 22);
            this.MaterialUnitImageComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.MaterialUnitImageComboBoxEdit.TabIndex = 8;
            // 
            // CodeTextEdit
            // 
            this.CodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsQuotationMaterial, "Code", true));
            this.CodeTextEdit.Location = new System.Drawing.Point(68, 38);
            this.CodeTextEdit.Name = "CodeTextEdit";
            this.CodeTextEdit.Size = new System.Drawing.Size(569, 22);
            this.CodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CodeTextEdit.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(649, 313);
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
            this.ItemForMaterialUnit,
            this.ItemForMaterialId,
            this.ItemForCode});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(629, 293);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountSpinEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 52);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(448, 28);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(53, 16);
            // 
            // ItemForDate
            // 
            this.ItemForDate.Control = this.DateDateEdit;
            this.ItemForDate.Location = new System.Drawing.Point(0, 80);
            this.ItemForDate.Name = "ItemForDate";
            this.ItemForDate.Size = new System.Drawing.Size(629, 26);
            this.ItemForDate.Text = "Date";
            this.ItemForDate.TextSize = new System.Drawing.Size(53, 16);
            // 
            // ItemForInfo
            // 
            this.ItemForInfo.Control = this.InfoMemoEdit;
            this.ItemForInfo.Location = new System.Drawing.Point(0, 106);
            this.ItemForInfo.Name = "ItemForInfo";
            this.ItemForInfo.Size = new System.Drawing.Size(629, 187);
            this.ItemForInfo.StartNewLine = true;
            this.ItemForInfo.Text = "Info";
            this.ItemForInfo.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForInfo.TextSize = new System.Drawing.Size(53, 16);
            // 
            // ItemForMaterialUnit
            // 
            this.ItemForMaterialUnit.Control = this.MaterialUnitImageComboBoxEdit;
            this.ItemForMaterialUnit.Location = new System.Drawing.Point(448, 52);
            this.ItemForMaterialUnit.Name = "ItemForMaterialUnit";
            this.ItemForMaterialUnit.Size = new System.Drawing.Size(181, 28);
            this.ItemForMaterialUnit.Text = "Unit";
            this.ItemForMaterialUnit.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForMaterialUnit.TextVisible = false;
            // 
            // ItemForMaterialId
            // 
            this.ItemForMaterialId.Control = this.MaterialIdSearchLookUpEdit;
            this.ItemForMaterialId.Location = new System.Drawing.Point(0, 0);
            this.ItemForMaterialId.Name = "ItemForMaterialId";
            this.ItemForMaterialId.Size = new System.Drawing.Size(629, 26);
            this.ItemForMaterialId.Text = "Muturiuul";
            this.ItemForMaterialId.TextSize = new System.Drawing.Size(53, 16);
            // 
            // ItemForCode
            // 
            this.ItemForCode.Control = this.CodeTextEdit;
            this.ItemForCode.Location = new System.Drawing.Point(0, 26);
            this.ItemForCode.Name = "ItemForCode";
            this.ItemForCode.Size = new System.Drawing.Size(629, 26);
            this.ItemForCode.Text = "Code";
            this.ItemForCode.TextSize = new System.Drawing.Size(53, 16);
            // 
            // QuotationMaterialEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "QuotationMaterialEditView";
            this.Size = new System.Drawing.Size(649, 313);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuotationMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialIdSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialUnitImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaterialUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMaterialId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsQuotationMaterial;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource bsMaterials;
        private DevExpress.XtraEditors.SpinEdit AmountSpinEdit;
        private DevExpress.XtraEditors.DateEdit DateDateEdit;
        private DevExpress.XtraEditors.MemoEdit InfoMemoEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit MaterialIdSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.ImageComboBoxEdit MaterialUnitImageComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit CodeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInfo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaterialUnit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMaterialId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
    }
}
