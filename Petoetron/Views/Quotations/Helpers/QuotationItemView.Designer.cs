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
            this.sbDelete = new DevExpress.XtraEditors.SimpleButton();
            this.sbEdit = new DevExpress.XtraEditors.SimpleButton();
            this.UnitEditText = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitEditText = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitEditText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitEditText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl1.Controls.Add(this.AmountSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.sbDelete);
            this.dataLayoutControl1.Controls.Add(this.sbEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitEditText);
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
            this.AmountSpinEdit.Size = new System.Drawing.Size(285, 24);
            this.AmountSpinEdit.StyleController = this.dataLayoutControl1;
            this.AmountSpinEdit.TabIndex = 4;
            // 
            // sbDelete
            // 
            this.sbDelete.Location = new System.Drawing.Point(452, 2);
            this.sbDelete.MaximumSize = new System.Drawing.Size(25, 25);
            this.sbDelete.MinimumSize = new System.Drawing.Size(25, 25);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.Size = new System.Drawing.Size(25, 25);
            this.sbDelete.StyleController = this.dataLayoutControl1;
            this.sbDelete.TabIndex = 6;
            this.sbDelete.Text = " ";
            // 
            // sbEdit
            // 
            this.sbEdit.Location = new System.Drawing.Point(423, 2);
            this.sbEdit.MaximumSize = new System.Drawing.Size(25, 25);
            this.sbEdit.MinimumSize = new System.Drawing.Size(25, 25);
            this.sbEdit.Name = "sbEdit";
            this.sbEdit.Size = new System.Drawing.Size(25, 25);
            this.sbEdit.StyleController = this.dataLayoutControl1;
            this.sbEdit.TabIndex = 7;
            this.sbEdit.Text = " ";
            // 
            // UnitEditText
            // 
            this.UnitEditText.Location = new System.Drawing.Point(338, 2);
            this.UnitEditText.Name = "UnitEditText";
            this.UnitEditText.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitEditText.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UnitEditText.Size = new System.Drawing.Size(81, 22);
            this.UnitEditText.StyleController = this.dataLayoutControl1;
            this.UnitEditText.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(479, 31);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAmount,
            this.ItemForUnitEditText,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(479, 31);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountSpinEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 0);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(336, 31);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(44, 16);
            // 
            // ItemForUnitEditText
            // 
            this.ItemForUnitEditText.Control = this.UnitEditText;
            this.ItemForUnitEditText.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemForUnitEditText.Location = new System.Drawing.Point(336, 0);
            this.ItemForUnitEditText.Name = "ItemForUnitEditText";
            this.ItemForUnitEditText.Size = new System.Drawing.Size(85, 31);
            this.ItemForUnitEditText.Text = "Price Type Unit";
            this.ItemForUnitEditText.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForUnitEditText.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sbDelete;
            this.layoutControlItem1.Location = new System.Drawing.Point(450, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(29, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sbEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(421, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(29, 31);
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
            ((System.ComponentModel.ISupportInitialize)(this.UnitEditText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitEditText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SpinEdit AmountSpinEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitEditText;
        private DevExpress.XtraEditors.SimpleButton sbDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton sbEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit UnitEditText;
    }
}
