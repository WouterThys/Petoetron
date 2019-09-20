namespace Petoetron.Views.Info
{
    partial class InfoView
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
            this.CompanyNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bsInfo = new System.Windows.Forms.BindingSource(this.components);
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddressStreetTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddressPlaceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddressCityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddressCountryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.VATSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.VATNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAddressStreet = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddressPlace = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddressCity = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddressCountry = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForVAT = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCompanyName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForVATNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ContactNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForContactName = new DevExpress.XtraLayout.LayoutControlItem();
            this.WebSiteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForWebSite = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressStreetTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressPlaceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressCityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressCountryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVATNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebSiteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebSite)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CompanyNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressStreetTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressPlaceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressCityTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressCountryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.VATSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.VATNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ContactNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.WebSiteTextEdit);
            this.dataLayoutControl1.DataSource = this.bsInfo;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(570, 446);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CompanyNameTextEdit
            // 
            this.CompanyNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "CompanyName", true));
            this.CompanyNameTextEdit.Location = new System.Drawing.Point(107, 55);
            this.CompanyNameTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompanyNameTextEdit.Name = "CompanyNameTextEdit";
            this.CompanyNameTextEdit.Size = new System.Drawing.Size(439, 22);
            this.CompanyNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CompanyNameTextEdit.TabIndex = 4;
            // 
            // bsInfo
            // 
            this.bsInfo.DataSource = typeof(Petoetron.Classes.Info);
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(107, 133);
            this.EmailTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(439, 22);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 5;
            // 
            // PhoneTextEdit
            // 
            this.PhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "Phone", true));
            this.PhoneTextEdit.Location = new System.Drawing.Point(107, 159);
            this.PhoneTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhoneTextEdit.Name = "PhoneTextEdit";
            this.PhoneTextEdit.Size = new System.Drawing.Size(439, 22);
            this.PhoneTextEdit.StyleController = this.dataLayoutControl1;
            this.PhoneTextEdit.TabIndex = 6;
            // 
            // AddressStreetTextEdit
            // 
            this.AddressStreetTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "AddressStreet", true));
            this.AddressStreetTextEdit.Location = new System.Drawing.Point(107, 294);
            this.AddressStreetTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressStreetTextEdit.Name = "AddressStreetTextEdit";
            this.AddressStreetTextEdit.Size = new System.Drawing.Size(439, 22);
            this.AddressStreetTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressStreetTextEdit.TabIndex = 9;
            // 
            // AddressPlaceTextEdit
            // 
            this.AddressPlaceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "AddressPlace", true));
            this.AddressPlaceTextEdit.Location = new System.Drawing.Point(107, 320);
            this.AddressPlaceTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressPlaceTextEdit.Name = "AddressPlaceTextEdit";
            this.AddressPlaceTextEdit.Size = new System.Drawing.Size(439, 22);
            this.AddressPlaceTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressPlaceTextEdit.TabIndex = 10;
            // 
            // AddressCityTextEdit
            // 
            this.AddressCityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "AddressCity", true));
            this.AddressCityTextEdit.Location = new System.Drawing.Point(107, 346);
            this.AddressCityTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressCityTextEdit.Name = "AddressCityTextEdit";
            this.AddressCityTextEdit.Size = new System.Drawing.Size(439, 22);
            this.AddressCityTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressCityTextEdit.TabIndex = 11;
            // 
            // AddressCountryTextEdit
            // 
            this.AddressCountryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "AddressCountry", true));
            this.AddressCountryTextEdit.Location = new System.Drawing.Point(107, 372);
            this.AddressCountryTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressCountryTextEdit.Name = "AddressCountryTextEdit";
            this.AddressCountryTextEdit.Size = new System.Drawing.Size(439, 22);
            this.AddressCountryTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressCountryTextEdit.TabIndex = 12;
            // 
            // VATSpinEdit
            // 
            this.VATSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "VAT", true));
            this.VATSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.VATSpinEdit.Location = new System.Drawing.Point(107, 185);
            this.VATSpinEdit.Name = "VATSpinEdit";
            this.VATSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.VATSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.VATSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VATSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.VATSpinEdit.Properties.Mask.EditMask = "F";
            this.VATSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.VATSpinEdit.Size = new System.Drawing.Size(439, 24);
            this.VATSpinEdit.StyleController = this.dataLayoutControl1;
            this.VATSpinEdit.TabIndex = 13;
            // 
            // VATNumberTextEdit
            // 
            this.VATNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "VATNumber", true));
            this.VATNumberTextEdit.Location = new System.Drawing.Point(107, 213);
            this.VATNumberTextEdit.Name = "VATNumberTextEdit";
            this.VATNumberTextEdit.Size = new System.Drawing.Size(439, 22);
            this.VATNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.VATNumberTextEdit.TabIndex = 14;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(570, 446);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(550, 426);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAddressStreet,
            this.ItemForAddressPlace,
            this.ItemForAddressCountry,
            this.ItemForAddressCity});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 239);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(550, 187);
            this.layoutControlGroup2.Text = "Udrus";
            // 
            // ItemForAddressStreet
            // 
            this.ItemForAddressStreet.Control = this.AddressStreetTextEdit;
            this.ItemForAddressStreet.Location = new System.Drawing.Point(0, 0);
            this.ItemForAddressStreet.Name = "ItemForAddressStreet";
            this.ItemForAddressStreet.Size = new System.Drawing.Size(526, 26);
            this.ItemForAddressStreet.Text = "Struut";
            this.ItemForAddressStreet.TextSize = new System.Drawing.Size(80, 16);
            // 
            // ItemForAddressPlace
            // 
            this.ItemForAddressPlace.Control = this.AddressPlaceTextEdit;
            this.ItemForAddressPlace.Location = new System.Drawing.Point(0, 26);
            this.ItemForAddressPlace.Name = "ItemForAddressPlace";
            this.ItemForAddressPlace.Size = new System.Drawing.Size(526, 26);
            this.ItemForAddressPlace.Text = "Pluuts";
            this.ItemForAddressPlace.TextSize = new System.Drawing.Size(80, 16);
            // 
            // ItemForAddressCity
            // 
            this.ItemForAddressCity.Control = this.AddressCityTextEdit;
            this.ItemForAddressCity.Location = new System.Drawing.Point(0, 52);
            this.ItemForAddressCity.Name = "ItemForAddressCity";
            this.ItemForAddressCity.Size = new System.Drawing.Size(526, 26);
            this.ItemForAddressCity.Text = "Stud";
            this.ItemForAddressCity.TextSize = new System.Drawing.Size(80, 16);
            // 
            // ItemForAddressCountry
            // 
            this.ItemForAddressCountry.Control = this.AddressCountryTextEdit;
            this.ItemForAddressCountry.Location = new System.Drawing.Point(0, 78);
            this.ItemForAddressCountry.Name = "ItemForAddressCountry";
            this.ItemForAddressCountry.Size = new System.Drawing.Size(526, 54);
            this.ItemForAddressCountry.Text = "Lund";
            this.ItemForAddressCountry.TextSize = new System.Drawing.Size(80, 16);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForVAT,
            this.ItemForPhone,
            this.ItemForEmail,
            this.ItemForCompanyName,
            this.ItemForVATNumber,
            this.ItemForContactName,
            this.ItemForWebSite});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(550, 239);
            this.layoutControlGroup3.Text = "Ulgumuun";
            // 
            // ItemForVAT
            // 
            this.ItemForVAT.Control = this.VATSpinEdit;
            this.ItemForVAT.Location = new System.Drawing.Point(0, 130);
            this.ItemForVAT.Name = "ItemForVAT";
            this.ItemForVAT.Size = new System.Drawing.Size(526, 28);
            this.ItemForVAT.Text = "Butuwu";
            this.ItemForVAT.TextSize = new System.Drawing.Size(80, 16);
            // 
            // ItemForPhone
            // 
            this.ItemForPhone.Control = this.PhoneTextEdit;
            this.ItemForPhone.Location = new System.Drawing.Point(0, 104);
            this.ItemForPhone.Name = "ItemForPhone";
            this.ItemForPhone.Size = new System.Drawing.Size(526, 26);
            this.ItemForPhone.Text = "Tulufun";
            this.ItemForPhone.TextSize = new System.Drawing.Size(80, 16);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 78);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(526, 26);
            this.ItemForEmail.Text = "Umuul";
            this.ItemForEmail.TextSize = new System.Drawing.Size(80, 16);
            // 
            // ItemForCompanyName
            // 
            this.ItemForCompanyName.Control = this.CompanyNameTextEdit;
            this.ItemForCompanyName.Location = new System.Drawing.Point(0, 0);
            this.ItemForCompanyName.Name = "ItemForCompanyName";
            this.ItemForCompanyName.Size = new System.Drawing.Size(526, 26);
            this.ItemForCompanyName.Text = "Budruuf";
            this.ItemForCompanyName.TextSize = new System.Drawing.Size(80, 16);
            // 
            // ItemForVATNumber
            // 
            this.ItemForVATNumber.Control = this.VATNumberTextEdit;
            this.ItemForVATNumber.Location = new System.Drawing.Point(0, 158);
            this.ItemForVATNumber.Name = "ItemForVATNumber";
            this.ItemForVATNumber.Size = new System.Drawing.Size(526, 26);
            this.ItemForVATNumber.Text = "BTW Nummer";
            this.ItemForVATNumber.TextSize = new System.Drawing.Size(80, 16);
            // 
            // ContactNameTextEdit
            // 
            this.ContactNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "ContactName", true));
            this.ContactNameTextEdit.Location = new System.Drawing.Point(107, 81);
            this.ContactNameTextEdit.Name = "ContactNameTextEdit";
            this.ContactNameTextEdit.Size = new System.Drawing.Size(439, 22);
            this.ContactNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ContactNameTextEdit.TabIndex = 15;
            // 
            // ItemForContactName
            // 
            this.ItemForContactName.Control = this.ContactNameTextEdit;
            this.ItemForContactName.Location = new System.Drawing.Point(0, 26);
            this.ItemForContactName.Name = "ItemForContactName";
            this.ItemForContactName.Size = new System.Drawing.Size(526, 26);
            this.ItemForContactName.Text = "Munne Nuum";
            this.ItemForContactName.TextSize = new System.Drawing.Size(80, 16);
            // 
            // WebSiteTextEdit
            // 
            this.WebSiteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "WebSite", true));
            this.WebSiteTextEdit.Location = new System.Drawing.Point(107, 107);
            this.WebSiteTextEdit.Name = "WebSiteTextEdit";
            this.WebSiteTextEdit.Size = new System.Drawing.Size(439, 22);
            this.WebSiteTextEdit.StyleController = this.dataLayoutControl1;
            this.WebSiteTextEdit.TabIndex = 16;
            // 
            // ItemForWebSite
            // 
            this.ItemForWebSite.Control = this.WebSiteTextEdit;
            this.ItemForWebSite.Location = new System.Drawing.Point(0, 52);
            this.ItemForWebSite.Name = "ItemForWebSite";
            this.ItemForWebSite.Size = new System.Drawing.Size(526, 26);
            this.ItemForWebSite.Text = "Wubsute";
            this.ItemForWebSite.TextSize = new System.Drawing.Size(80, 16);
            // 
            // InfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "InfoView";
            this.Size = new System.Drawing.Size(570, 446);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressStreetTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressPlaceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressCityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressCountryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVATNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebSiteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWebSite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsInfo;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit CompanyNameTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit AddressStreetTextEdit;
        private DevExpress.XtraEditors.TextEdit AddressPlaceTextEdit;
        private DevExpress.XtraEditors.TextEdit AddressCityTextEdit;
        private DevExpress.XtraEditors.TextEdit AddressCountryTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddressStreet;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddressPlace;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddressCity;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddressCountry;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVAT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyName;
        private DevExpress.XtraEditors.SpinEdit VATSpinEdit;
        private DevExpress.XtraEditors.TextEdit VATNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVATNumber;
        private DevExpress.XtraEditors.TextEdit ContactNameTextEdit;
        private DevExpress.XtraEditors.TextEdit WebSiteTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContactName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWebSite;
    }
}
