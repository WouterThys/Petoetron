namespace Petoetron
{
    partial class MainView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bbiDbState = new DevExpress.XtraBars.BarButtonItem();
            this.bbiShowInfo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgGeneral = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager();
            this.dpNavigation = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceInvoices = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceData = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceCustomers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceMaterialTypes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceMaterials = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acePriceTypes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext();
            this.images = new Petoetron.Resources.Images();
            this.behaviorManager = new DevExpress.Utils.Behaviors.BehaviorManager();
            this.acePauses = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dpNavigation.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem,
            this.bbiDbState,
            this.bbiShowInfo});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 49;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1630, 198);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // bbiDbState
            // 
            this.bbiDbState.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiDbState.Id = 46;
            this.bbiDbState.Name = "bbiDbState";
            // 
            // bbiShowInfo
            // 
            this.bbiShowInfo.Caption = "Unfu";
            this.bbiShowInfo.Id = 47;
            this.bbiShowInfo.Name = "bbiShowInfo";
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup,
            this.rpgGeneral});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "View";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
            this.ribbonPageGroup.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            this.ribbonPageGroup.Text = "Appearance";
            // 
            // rpgGeneral
            // 
            this.rpgGeneral.ItemLinks.Add(this.bbiShowInfo);
            this.rpgGeneral.Name = "rpgGeneral";
            this.rpgGeneral.Text = "Ulgumuun";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bbiDbState);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 794);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1630, 32);
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.ribbonControl;
            this.documentManager.View = this.tabbedView1;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpNavigation});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // dpNavigation
            // 
            this.dpNavigation.Controls.Add(this.dockPanel1_Container);
            this.dpNavigation.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dpNavigation.ID = new System.Guid("0c0b11d5-6b38-4575-8be9-7a7a08070e26");
            this.dpNavigation.Location = new System.Drawing.Point(0, 198);
            this.dpNavigation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpNavigation.Name = "dpNavigation";
            this.dpNavigation.OriginalSize = new System.Drawing.Size(379, 200);
            this.dpNavigation.SavedSizeFactor = 0D;
            this.dpNavigation.Size = new System.Drawing.Size(379, 596);
            this.dpNavigation.Text = "Kuus Iets";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.accordionControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 37);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(369, 555);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // accordionControl
            // 
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceInvoices,
            this.aceData});
            this.accordionControl.Location = new System.Drawing.Point(0, 0);
            this.accordionControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.Size = new System.Drawing.Size(369, 555);
            this.accordionControl.TabIndex = 0;
            // 
            // aceInvoices
            // 
            this.aceInvoices.Expanded = true;
            this.aceInvoices.Name = "aceInvoices";
            this.aceInvoices.Text = "Fuctuur";
            // 
            // aceData
            // 
            this.aceData.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceCustomers,
            this.aceMaterialTypes,
            this.aceMaterials,
            this.acePriceTypes,
            this.acePauses});
            this.aceData.Expanded = true;
            this.aceData.Name = "aceData";
            this.aceData.Text = "Dutu";
            // 
            // aceCustomers
            // 
            this.aceCustomers.Name = "aceCustomers";
            this.aceCustomers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceCustomers.Text = "Klunten";
            // 
            // aceMaterialTypes
            // 
            this.aceMaterialTypes.Name = "aceMaterialTypes";
            this.aceMaterialTypes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceMaterialTypes.Text = "Muturiuul Suurten";
            // 
            // aceMaterials
            // 
            this.aceMaterials.Name = "aceMaterials";
            this.aceMaterials.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceMaterials.Text = "Muturiuul";
            // 
            // acePriceTypes
            // 
            this.acePriceTypes.Name = "acePriceTypes";
            this.acePriceTypes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acePriceTypes.Text = "Pruuzen";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(Petoetron.MainViewModel);
            // 
            // images
            // 
            this.images.DefaultSize = Petoetron.Resources.ImageSize.i16x16;
            // 
            // acePauses
            // 
            this.acePauses.Name = "acePauses";
            this.acePauses.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acePauses.Text = "Puzes";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.behaviorManager.SetBehaviors(this, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.PersistenceBehavior.Create(typeof(DevExpress.Utils.BehaviorSource.PersistenceBehaviorSourceForForm), null, DevExpress.Utils.Behaviors.Common.Storage.File, DevExpress.Utils.DefaultBoolean.True)))});
            this.ClientSize = new System.Drawing.Size(1630, 826);
            this.Controls.Add(this.dpNavigation);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainView";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dpNavigation.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking.DockPanel dpNavigation;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceInvoices;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceData;
        private Resources.Images images;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceCustomers;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceMaterialTypes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceMaterials;
        private DevExpress.XtraBars.BarButtonItem bbiDbState;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acePriceTypes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGeneral;
        private DevExpress.XtraBars.BarButtonItem bbiShowInfo;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acePauses;
    }
}