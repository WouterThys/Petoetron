namespace Petoetron.Views.Quotations.Helpers
{
    partial class PriceTypeItemView
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
            this.dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.AmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.PriceTypePriceTypeUnitImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.PriceTypeDescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPriceTypeDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPriceTypePriceTypeUnit = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            this.dataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTypePriceTypeUnitImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTypeDescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPriceTypeDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPriceTypePriceTypeUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionBar
            // 
            this.OptionBar.OptionsBar.MultiLine = true;
            this.OptionBar.OptionsBar.UseWholeRow = true;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Size = new System.Drawing.Size(467, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 110);
            this.barDockControlBottom.Size = new System.Drawing.Size(467, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 84);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Location = new System.Drawing.Point(467, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 84);
            // 
            // bsData
            // 
            this.bsData.DataSource = typeof(Petoetron.Classes.QuotationPrice);
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl.Controls.Add(this.AmountSpinEdit);
            this.dataLayoutControl.Controls.Add(this.PriceTypePriceTypeUnitImageComboBoxEdit);
            this.dataLayoutControl.Controls.Add(this.PriceTypeDescriptionTextEdit);
            this.dataLayoutControl.DataSource = this.bsData;
            this.dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl.Location = new System.Drawing.Point(0, 26);
            this.dataLayoutControl.Name = "dataLayoutControl";
            this.dataLayoutControl.Root = this.Root;
            this.dataLayoutControl.Size = new System.Drawing.Size(467, 84);
            this.dataLayoutControl.TabIndex = 4;
            this.dataLayoutControl.Text = "dataLayoutControl1";
            // 
            // AmountSpinEdit
            // 
            this.AmountSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsData, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AmountSpinEdit.Location = new System.Drawing.Point(52, 36);
            this.AmountSpinEdit.MenuManager = this.barManager;
            this.AmountSpinEdit.Name = "AmountSpinEdit";
            this.AmountSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AmountSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AmountSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.AmountSpinEdit.Properties.Mask.EditMask = "F";
            this.AmountSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountSpinEdit.Size = new System.Drawing.Size(325, 20);
            this.AmountSpinEdit.StyleController = this.dataLayoutControl;
            this.AmountSpinEdit.TabIndex = 4;
            // 
            // PriceTypePriceTypeUnitImageComboBoxEdit
            // 
            this.PriceTypePriceTypeUnitImageComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsData, "PriceType.PriceTypeUnit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PriceTypePriceTypeUnitImageComboBoxEdit.Location = new System.Drawing.Point(381, 36);
            this.PriceTypePriceTypeUnitImageComboBoxEdit.MenuManager = this.barManager;
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
            this.PriceTypePriceTypeUnitImageComboBoxEdit.Size = new System.Drawing.Size(74, 20);
            this.PriceTypePriceTypeUnitImageComboBoxEdit.StyleController = this.dataLayoutControl;
            this.PriceTypePriceTypeUnitImageComboBoxEdit.TabIndex = 5;
            // 
            // PriceTypeDescriptionTextEdit
            // 
            this.PriceTypeDescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsData, "PriceType.Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PriceTypeDescriptionTextEdit.Location = new System.Drawing.Point(12, 12);
            this.PriceTypeDescriptionTextEdit.MenuManager = this.barManager;
            this.PriceTypeDescriptionTextEdit.Name = "PriceTypeDescriptionTextEdit";
            this.PriceTypeDescriptionTextEdit.Size = new System.Drawing.Size(443, 20);
            this.PriceTypeDescriptionTextEdit.StyleController = this.dataLayoutControl;
            this.PriceTypeDescriptionTextEdit.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(467, 84);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAmount,
            this.ItemForPriceTypeDescription,
            this.ItemForPriceTypePriceTypeUnit});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(447, 64);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountSpinEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 24);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(369, 40);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(37, 13);
            // 
            // ItemForPriceTypeDescription
            // 
            this.ItemForPriceTypeDescription.Control = this.PriceTypeDescriptionTextEdit;
            this.ItemForPriceTypeDescription.Location = new System.Drawing.Point(0, 0);
            this.ItemForPriceTypeDescription.Name = "ItemForPriceTypeDescription";
            this.ItemForPriceTypeDescription.Size = new System.Drawing.Size(447, 24);
            this.ItemForPriceTypeDescription.Text = "Description";
            this.ItemForPriceTypeDescription.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForPriceTypeDescription.TextVisible = false;
            // 
            // ItemForPriceTypePriceTypeUnit
            // 
            this.ItemForPriceTypePriceTypeUnit.Control = this.PriceTypePriceTypeUnitImageComboBoxEdit;
            this.ItemForPriceTypePriceTypeUnit.Location = new System.Drawing.Point(369, 24);
            this.ItemForPriceTypePriceTypeUnit.Name = "ItemForPriceTypePriceTypeUnit";
            this.ItemForPriceTypePriceTypeUnit.Size = new System.Drawing.Size(78, 40);
            this.ItemForPriceTypePriceTypeUnit.Text = "Price Type Unit";
            this.ItemForPriceTypePriceTypeUnit.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForPriceTypePriceTypeUnit.TextVisible = false;
            // 
            // PriceTypeItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl);
            this.Name = "PriceTypeItemView";
            this.Size = new System.Drawing.Size(467, 110);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.dataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            this.dataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTypePriceTypeUnitImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTypeDescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPriceTypeDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPriceTypePriceTypeUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SpinEdit AmountSpinEdit;
        private DevExpress.XtraEditors.ImageComboBoxEdit PriceTypePriceTypeUnitImageComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit PriceTypeDescriptionTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPriceTypePriceTypeUnit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPriceTypeDescription;
    }
}
