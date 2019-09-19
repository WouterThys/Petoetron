namespace Petoetron.Views.Quotations.Helpers
{
    partial class QuotationItemView
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.AmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.PriceTypePriceTypeUnitImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.sbDelete = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPriceTypePriceTypeUnit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sbEdit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTypePriceTypeUnitImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPriceTypePriceTypeUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.Controls.Add(this.AmountSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.PriceTypePriceTypeUnitImageComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.sbDelete);
            this.dataLayoutControl1.Controls.Add(this.sbEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(500, 30);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // AmountSpinEdit
            // 
            this.AmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AmountSpinEdit.Location = new System.Drawing.Point(49, 2);
            this.AmountSpinEdit.Name = "AmountSpinEdit";
            this.AmountSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AmountSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AmountSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.AmountSpinEdit.Properties.Mask.EditMask = "F";
            this.AmountSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountSpinEdit.Size = new System.Drawing.Size(243, 24);
            this.AmountSpinEdit.StyleController = this.dataLayoutControl1;
            this.AmountSpinEdit.TabIndex = 4;
            // 
            // PriceTypePriceTypeUnitImageComboBoxEdit
            // 
            this.PriceTypePriceTypeUnitImageComboBoxEdit.Location = new System.Drawing.Point(296, 2);
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
            this.PriceTypePriceTypeUnitImageComboBoxEdit.Size = new System.Drawing.Size(144, 22);
            this.PriceTypePriceTypeUnitImageComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.PriceTypePriceTypeUnitImageComboBoxEdit.TabIndex = 5;
            // 
            // sbDelete
            // 
            this.sbDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sbDelete.Location = new System.Drawing.Point(473, 2);
            this.sbDelete.MaximumSize = new System.Drawing.Size(25, 25);
            this.sbDelete.MinimumSize = new System.Drawing.Size(25, 25);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(25, 25);
            this.sbDelete.TabIndex = 6;
            this.sbDelete.Text = " ";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(500, 30);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAmount,
            this.ItemForPriceTypePriceTypeUnit,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(500, 30);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountSpinEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 0);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(294, 30);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(44, 16);
            // 
            // ItemForPriceTypePriceTypeUnit
            // 
            this.ItemForPriceTypePriceTypeUnit.Control = this.PriceTypePriceTypeUnitImageComboBoxEdit;
            this.ItemForPriceTypePriceTypeUnit.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemForPriceTypePriceTypeUnit.Location = new System.Drawing.Point(294, 0);
            this.ItemForPriceTypePriceTypeUnit.Name = "ItemForPriceTypePriceTypeUnit";
            this.ItemForPriceTypePriceTypeUnit.Size = new System.Drawing.Size(148, 30);
            this.ItemForPriceTypePriceTypeUnit.Text = "Price Type Unit";
            this.ItemForPriceTypePriceTypeUnit.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForPriceTypePriceTypeUnit.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbDelete;
            this.layoutControlItem1.Location = new System.Drawing.Point(471, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(29, 30);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // sbEdit
            // 
            this.sbEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sbEdit.Location = new System.Drawing.Point(444, 2);
            this.sbEdit.MaximumSize = new System.Drawing.Size(25, 25);
            this.sbEdit.MinimumSize = new System.Drawing.Size(25, 25);
            this.sbEdit.Name = "sbEdit";
            this.sbEdit.Size = new System.Drawing.Size(25, 25);
            this.sbEdit.TabIndex = 7;
            this.sbEdit.Text = " ";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(442, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(29, 30);
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // QuotationItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.MaximumSize = new System.Drawing.Size(5000, 30);
            this.Name = "QuotationItemView";
            this.Size = new System.Drawing.Size(500, 30);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTypePriceTypeUnitImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPriceTypePriceTypeUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SpinEdit AmountSpinEdit;
        private DevExpress.XtraEditors.ImageComboBoxEdit PriceTypePriceTypeUnitImageComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPriceTypePriceTypeUnit;
        private DevExpress.XtraEditors.SimpleButton sbDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton sbEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
