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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.bsInfo = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CompanyNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCompanyName = new DevExpress.XtraLayout.LayoutControlItem();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.PhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.VATTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForVAT = new DevExpress.XtraLayout.LayoutControlItem();
            this.LogoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForLogo = new DevExpress.XtraLayout.LayoutControlItem();
            this.AddressStreetTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForAddressStreet = new DevExpress.XtraLayout.LayoutControlItem();
            this.AddressPlaceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForAddressPlace = new DevExpress.XtraLayout.LayoutControlItem();
            this.AddressCityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForAddressCity = new DevExpress.XtraLayout.LayoutControlItem();
            this.AddressCountryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForAddressCountry = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressStreetTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressPlaceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressCityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressCountryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CompanyNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.VATTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LogoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressStreetTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressPlaceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressCityTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressCountryTextEdit);
            this.dataLayoutControl1.DataSource = this.bsInfo;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(489, 362);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(489, 362);
            this.Root.TextVisible = false;
            // 
            // bsInfo
            // 
            this.bsInfo.DataSource = typeof(Petoetron.Classes.Info);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(469, 342);
            // 
            // CompanyNameTextEdit
            // 
            this.CompanyNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "CompanyName", true));
            this.CompanyNameTextEdit.Location = new System.Drawing.Point(89, 49);
            this.CompanyNameTextEdit.Name = "CompanyNameTextEdit";
            this.CompanyNameTextEdit.Size = new System.Drawing.Size(376, 20);
            this.CompanyNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CompanyNameTextEdit.TabIndex = 4;
            // 
            // ItemForCompanyName
            // 
            this.ItemForCompanyName.Control = this.CompanyNameTextEdit;
            this.ItemForCompanyName.Location = new System.Drawing.Point(0, 0);
            this.ItemForCompanyName.Name = "ItemForCompanyName";
            this.ItemForCompanyName.Size = new System.Drawing.Size(445, 24);
            this.ItemForCompanyName.Text = "Munne Nuum";
            this.ItemForCompanyName.TextSize = new System.Drawing.Size(62, 13);
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(89, 73);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(376, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 5;
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 24);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(445, 24);
            this.ItemForEmail.Text = "Umuul";
            this.ItemForEmail.TextSize = new System.Drawing.Size(62, 13);
            // 
            // PhoneTextEdit
            // 
            this.PhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "Phone", true));
            this.PhoneTextEdit.Location = new System.Drawing.Point(89, 97);
            this.PhoneTextEdit.Name = "PhoneTextEdit";
            this.PhoneTextEdit.Size = new System.Drawing.Size(376, 20);
            this.PhoneTextEdit.StyleController = this.dataLayoutControl1;
            this.PhoneTextEdit.TabIndex = 6;
            // 
            // ItemForPhone
            // 
            this.ItemForPhone.Control = this.PhoneTextEdit;
            this.ItemForPhone.Location = new System.Drawing.Point(0, 48);
            this.ItemForPhone.Name = "ItemForPhone";
            this.ItemForPhone.Size = new System.Drawing.Size(445, 24);
            this.ItemForPhone.Text = "Tulufun";
            this.ItemForPhone.TextSize = new System.Drawing.Size(62, 13);
            // 
            // VATTextEdit
            // 
            this.VATTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "VAT", true));
            this.VATTextEdit.Location = new System.Drawing.Point(89, 121);
            this.VATTextEdit.Name = "VATTextEdit";
            this.VATTextEdit.Size = new System.Drawing.Size(376, 20);
            this.VATTextEdit.StyleController = this.dataLayoutControl1;
            this.VATTextEdit.TabIndex = 7;
            // 
            // ItemForVAT
            // 
            this.ItemForVAT.Control = this.VATTextEdit;
            this.ItemForVAT.Location = new System.Drawing.Point(0, 72);
            this.ItemForVAT.Name = "ItemForVAT";
            this.ItemForVAT.Size = new System.Drawing.Size(445, 24);
            this.ItemForVAT.Text = "Butuwu";
            this.ItemForVAT.TextSize = new System.Drawing.Size(62, 13);
            // 
            // LogoTextEdit
            // 
            this.LogoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "Logo", true));
            this.LogoTextEdit.Location = new System.Drawing.Point(89, 145);
            this.LogoTextEdit.Name = "LogoTextEdit";
            this.LogoTextEdit.Size = new System.Drawing.Size(376, 20);
            this.LogoTextEdit.StyleController = this.dataLayoutControl1;
            this.LogoTextEdit.TabIndex = 8;
            // 
            // ItemForLogo
            // 
            this.ItemForLogo.Control = this.LogoTextEdit;
            this.ItemForLogo.Location = new System.Drawing.Point(0, 96);
            this.ItemForLogo.Name = "ItemForLogo";
            this.ItemForLogo.Size = new System.Drawing.Size(445, 24);
            this.ItemForLogo.Text = "Lugu";
            this.ItemForLogo.TextSize = new System.Drawing.Size(62, 13);
            // 
            // AddressStreetTextEdit
            // 
            this.AddressStreetTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "AddressStreet", true));
            this.AddressStreetTextEdit.Location = new System.Drawing.Point(89, 218);
            this.AddressStreetTextEdit.Name = "AddressStreetTextEdit";
            this.AddressStreetTextEdit.Size = new System.Drawing.Size(376, 20);
            this.AddressStreetTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressStreetTextEdit.TabIndex = 9;
            // 
            // ItemForAddressStreet
            // 
            this.ItemForAddressStreet.Control = this.AddressStreetTextEdit;
            this.ItemForAddressStreet.Location = new System.Drawing.Point(0, 0);
            this.ItemForAddressStreet.Name = "ItemForAddressStreet";
            this.ItemForAddressStreet.Size = new System.Drawing.Size(445, 24);
            this.ItemForAddressStreet.Text = "Struut";
            this.ItemForAddressStreet.TextSize = new System.Drawing.Size(62, 13);
            // 
            // AddressPlaceTextEdit
            // 
            this.AddressPlaceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "AddressPlace", true));
            this.AddressPlaceTextEdit.Location = new System.Drawing.Point(89, 242);
            this.AddressPlaceTextEdit.Name = "AddressPlaceTextEdit";
            this.AddressPlaceTextEdit.Size = new System.Drawing.Size(376, 20);
            this.AddressPlaceTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressPlaceTextEdit.TabIndex = 10;
            // 
            // ItemForAddressPlace
            // 
            this.ItemForAddressPlace.Control = this.AddressPlaceTextEdit;
            this.ItemForAddressPlace.Location = new System.Drawing.Point(0, 24);
            this.ItemForAddressPlace.Name = "ItemForAddressPlace";
            this.ItemForAddressPlace.Size = new System.Drawing.Size(445, 24);
            this.ItemForAddressPlace.Text = "Pluuts";
            this.ItemForAddressPlace.TextSize = new System.Drawing.Size(62, 13);
            // 
            // AddressCityTextEdit
            // 
            this.AddressCityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "AddressCity", true));
            this.AddressCityTextEdit.Location = new System.Drawing.Point(89, 266);
            this.AddressCityTextEdit.Name = "AddressCityTextEdit";
            this.AddressCityTextEdit.Size = new System.Drawing.Size(376, 20);
            this.AddressCityTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressCityTextEdit.TabIndex = 11;
            // 
            // ItemForAddressCity
            // 
            this.ItemForAddressCity.Control = this.AddressCityTextEdit;
            this.ItemForAddressCity.Location = new System.Drawing.Point(0, 48);
            this.ItemForAddressCity.Name = "ItemForAddressCity";
            this.ItemForAddressCity.Size = new System.Drawing.Size(445, 24);
            this.ItemForAddressCity.Text = "Stud";
            this.ItemForAddressCity.TextSize = new System.Drawing.Size(62, 13);
            // 
            // AddressCountryTextEdit
            // 
            this.AddressCountryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInfo, "AddressCountry", true));
            this.AddressCountryTextEdit.Location = new System.Drawing.Point(89, 290);
            this.AddressCountryTextEdit.Name = "AddressCountryTextEdit";
            this.AddressCountryTextEdit.Size = new System.Drawing.Size(376, 20);
            this.AddressCountryTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressCountryTextEdit.TabIndex = 12;
            // 
            // ItemForAddressCountry
            // 
            this.ItemForAddressCountry.Control = this.AddressCountryTextEdit;
            this.ItemForAddressCountry.Location = new System.Drawing.Point(0, 72);
            this.ItemForAddressCountry.Name = "ItemForAddressCountry";
            this.ItemForAddressCountry.Size = new System.Drawing.Size(445, 52);
            this.ItemForAddressCountry.Text = "Lund";
            this.ItemForAddressCountry.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAddressStreet,
            this.ItemForAddressPlace,
            this.ItemForAddressCity,
            this.ItemForAddressCountry});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 169);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(469, 173);
            this.layoutControlGroup2.Text = "Udrus";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForLogo,
            this.ItemForVAT,
            this.ItemForPhone,
            this.ItemForEmail,
            this.ItemForCompanyName});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(469, 169);
            this.layoutControlGroup3.Text = "Ulgumuun";
            // 
            // InfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "InfoView";
            this.Size = new System.Drawing.Size(489, 362);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VATTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressStreetTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressPlaceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressCityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressCountryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsInfo;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit CompanyNameTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit VATTextEdit;
        private DevExpress.XtraEditors.TextEdit LogoTextEdit;
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
        private DevExpress.XtraLayout.LayoutControlItem ItemForLogo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVAT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyName;
    }
}
