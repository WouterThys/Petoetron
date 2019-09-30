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
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.PricesDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gcPrices = new DevExpress.XtraGrid.GridControl();
            this.bsPrices = new System.Windows.Forms.BindingSource(this.components);
            this.gvPrices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPriceTypeUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialDependant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIconPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaterialPriceDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gcPriceMaterials = new DevExpress.XtraGrid.GridControl();
            this.bsPriceMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.gvPriceMaterials = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTotalLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotationId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotation1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcQPrices = new DevExpress.XtraGrid.GridControl();
            this.bsQuotationPrices = new System.Windows.Forms.BindingSource(this.components);
            this.gvQPrices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPriceTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dragDropEvents1 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            this.dragDropEvents = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.PricesDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrices)).BeginInit();
            this.MaterialPriceDockPanel.SuspendLayout();
            this.controlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPriceMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPriceMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPriceMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcQPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuotationPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAdd,
            this.bbiDelete});
            this.ribbonControl.MaxItemId = 3;
            this.ribbonControl.Size = new System.Drawing.Size(1709, 194);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Text = "Tub1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.Text = "Pruzen";
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.PricesDockPanel,
            this.MaterialPriceDockPanel});
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
            // PricesDockPanel
            // 
            this.PricesDockPanel.Controls.Add(this.dockPanel1_Container);
            this.PricesDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.PricesDockPanel.ID = new System.Guid("9dd27291-e90e-485f-8533-3a8cf747fc79");
            this.PricesDockPanel.Location = new System.Drawing.Point(0, 194);
            this.PricesDockPanel.Name = "PricesDockPanel";
            this.PricesDockPanel.Options.ShowCloseButton = false;
            this.PricesDockPanel.OriginalSize = new System.Drawing.Size(451, 200);
            this.PricesDockPanel.SavedSizeFactor = 0D;
            this.PricesDockPanel.Size = new System.Drawing.Size(451, 401);
            this.PricesDockPanel.Text = "Pruzen";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.gcPrices);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 37);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(441, 360);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // gcPrices
            // 
            this.gcPrices.DataSource = this.bsPrices;
            this.gcPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrices.Location = new System.Drawing.Point(0, 0);
            this.gcPrices.MainView = this.gvPrices;
            this.gcPrices.MenuManager = this.ribbonControl;
            this.gcPrices.Name = "gcPrices";
            this.gcPrices.Size = new System.Drawing.Size(441, 360);
            this.gcPrices.TabIndex = 0;
            this.gcPrices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrices});
            // 
            // bsPrices
            // 
            this.bsPrices.DataSource = typeof(Petoetron.Classes.PriceType);
            // 
            // gvPrices
            // 
            this.behaviorManager.SetBehaviors(this.gvPrices, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, false, this.dragDropEvents1)))});
            this.gvPrices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPriceTypeUnit,
            this.colUnitPrice,
            this.colMaterialDependant,
            this.colFactor,
            this.colDescription,
            this.colInfo,
            this.colIconPath,
            this.colEnabled,
            this.colLastModified,
            this.colId,
            this.colCode});
            this.gvPrices.GridControl = this.gcPrices;
            this.gvPrices.Name = "gvPrices";
            this.gvPrices.OptionsFind.AlwaysVisible = true;
            this.gvPrices.OptionsView.ShowGroupPanel = false;
            // 
            // colPriceTypeUnit
            // 
            this.colPriceTypeUnit.FieldName = "PriceTypeUnit";
            this.colPriceTypeUnit.MinWidth = 25;
            this.colPriceTypeUnit.Name = "colPriceTypeUnit";
            this.colPriceTypeUnit.Visible = true;
            this.colPriceTypeUnit.VisibleIndex = 2;
            this.colPriceTypeUnit.Width = 94;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.MinWidth = 25;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 1;
            this.colUnitPrice.Width = 94;
            // 
            // colMaterialDependant
            // 
            this.colMaterialDependant.FieldName = "MaterialDependant";
            this.colMaterialDependant.MinWidth = 25;
            this.colMaterialDependant.Name = "colMaterialDependant";
            this.colMaterialDependant.Width = 94;
            // 
            // colFactor
            // 
            this.colFactor.FieldName = "Factor";
            this.colFactor.MinWidth = 25;
            this.colFactor.Name = "colFactor";
            this.colFactor.Visible = true;
            this.colFactor.VisibleIndex = 3;
            this.colFactor.Width = 94;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 94;
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
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 25;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 94;
            // 
            // MaterialPriceDockPanel
            // 
            this.MaterialPriceDockPanel.Controls.Add(this.controlContainer1);
            this.MaterialPriceDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.MaterialPriceDockPanel.ID = new System.Guid("b1e1868b-2547-4dbb-9982-d3a5e851dae5");
            this.MaterialPriceDockPanel.Location = new System.Drawing.Point(1283, 194);
            this.MaterialPriceDockPanel.Name = "MaterialPriceDockPanel";
            this.MaterialPriceDockPanel.Options.ShowCloseButton = false;
            this.MaterialPriceDockPanel.OriginalSize = new System.Drawing.Size(426, 200);
            this.MaterialPriceDockPanel.SavedSizeFactor = 0D;
            this.MaterialPriceDockPanel.Size = new System.Drawing.Size(426, 401);
            this.MaterialPriceDockPanel.Text = "Muturiuul per pruus";
            // 
            // controlContainer1
            // 
            this.controlContainer1.Controls.Add(this.gcPriceMaterials);
            this.controlContainer1.Location = new System.Drawing.Point(6, 37);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(416, 360);
            this.controlContainer1.TabIndex = 0;
            // 
            // gcPriceMaterials
            // 
            this.gcPriceMaterials.DataSource = this.bsPriceMaterials;
            this.gcPriceMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPriceMaterials.Location = new System.Drawing.Point(0, 0);
            this.gcPriceMaterials.MainView = this.gvPriceMaterials;
            this.gcPriceMaterials.MenuManager = this.ribbonControl;
            this.gcPriceMaterials.Name = "gcPriceMaterials";
            this.gcPriceMaterials.Size = new System.Drawing.Size(416, 360);
            this.gcPriceMaterials.TabIndex = 0;
            this.gcPriceMaterials.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPriceMaterials});
            // 
            // bsPriceMaterials
            // 
            this.bsPriceMaterials.DataSource = typeof(Petoetron.Classes.QuotationMaterial);
            // 
            // gvPriceMaterials
            // 
            this.gvPriceMaterials.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTotalLength,
            this.colTotalWeight,
            this.colMaterial,
            this.colGroupCode,
            this.colAmount1,
            this.colValue1,
            this.colDate1,
            this.colInfo2,
            this.colQuotationId1,
            this.colQuotation1,
            this.colId2,
            this.colCode2});
            this.gvPriceMaterials.GridControl = this.gcPriceMaterials;
            this.gvPriceMaterials.GroupCount = 1;
            this.gvPriceMaterials.Name = "gvPriceMaterials";
            this.gvPriceMaterials.OptionsView.ShowGroupPanel = false;
            this.gvPriceMaterials.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroupCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTotalLength
            // 
            this.colTotalLength.FieldName = "TotalLength";
            this.colTotalLength.MinWidth = 25;
            this.colTotalLength.Name = "colTotalLength";
            this.colTotalLength.OptionsColumn.ReadOnly = true;
            this.colTotalLength.Visible = true;
            this.colTotalLength.VisibleIndex = 3;
            this.colTotalLength.Width = 94;
            // 
            // colTotalWeight
            // 
            this.colTotalWeight.FieldName = "TotalWeight";
            this.colTotalWeight.MinWidth = 25;
            this.colTotalWeight.Name = "colTotalWeight";
            this.colTotalWeight.OptionsColumn.ReadOnly = true;
            this.colTotalWeight.Visible = true;
            this.colTotalWeight.VisibleIndex = 4;
            this.colTotalWeight.Width = 94;
            // 
            // colMaterial
            // 
            this.colMaterial.Caption = "Muturiuul";
            this.colMaterial.FieldName = "Material.Code";
            this.colMaterial.MinWidth = 25;
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.OptionsColumn.ReadOnly = true;
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 0;
            this.colMaterial.Width = 94;
            // 
            // colGroupCode
            // 
            this.colGroupCode.Caption = "Grup";
            this.colGroupCode.FieldName = "GroupCode";
            this.colGroupCode.MinWidth = 25;
            this.colGroupCode.Name = "colGroupCode";
            this.colGroupCode.Visible = true;
            this.colGroupCode.VisibleIndex = 3;
            this.colGroupCode.Width = 94;
            // 
            // colAmount1
            // 
            this.colAmount1.FieldName = "Amount";
            this.colAmount1.MinWidth = 25;
            this.colAmount1.Name = "colAmount1";
            this.colAmount1.Visible = true;
            this.colAmount1.VisibleIndex = 1;
            this.colAmount1.Width = 94;
            // 
            // colValue1
            // 
            this.colValue1.FieldName = "Value";
            this.colValue1.MinWidth = 25;
            this.colValue1.Name = "colValue1";
            this.colValue1.Visible = true;
            this.colValue1.VisibleIndex = 2;
            this.colValue1.Width = 94;
            // 
            // colDate1
            // 
            this.colDate1.FieldName = "Date";
            this.colDate1.MinWidth = 25;
            this.colDate1.Name = "colDate1";
            this.colDate1.Width = 94;
            // 
            // colInfo2
            // 
            this.colInfo2.FieldName = "Info";
            this.colInfo2.MinWidth = 25;
            this.colInfo2.Name = "colInfo2";
            this.colInfo2.Width = 94;
            // 
            // colQuotationId1
            // 
            this.colQuotationId1.FieldName = "QuotationId";
            this.colQuotationId1.MinWidth = 25;
            this.colQuotationId1.Name = "colQuotationId1";
            this.colQuotationId1.Width = 94;
            // 
            // colQuotation1
            // 
            this.colQuotation1.FieldName = "Quotation";
            this.colQuotation1.MinWidth = 25;
            this.colQuotation1.Name = "colQuotation1";
            this.colQuotation1.Width = 94;
            // 
            // colId2
            // 
            this.colId2.FieldName = "Id";
            this.colId2.MinWidth = 25;
            this.colId2.Name = "colId2";
            this.colId2.Width = 94;
            // 
            // colCode2
            // 
            this.colCode2.FieldName = "Code";
            this.colCode2.MinWidth = 25;
            this.colCode2.Name = "colCode2";
            this.colCode2.Width = 94;
            // 
            // gcQPrices
            // 
            this.gcQPrices.DataSource = this.bsQuotationPrices;
            this.gcQPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcQPrices.Location = new System.Drawing.Point(451, 194);
            this.gcQPrices.MainView = this.gvQPrices;
            this.gcQPrices.MenuManager = this.ribbonControl;
            this.gcQPrices.Name = "gcQPrices";
            this.gcQPrices.Size = new System.Drawing.Size(832, 401);
            this.gcQPrices.TabIndex = 2;
            this.gcQPrices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQPrices});
            // 
            // bsQuotationPrices
            // 
            this.bsQuotationPrices.DataSource = typeof(Petoetron.Classes.QuotationPrice);
            // 
            // gvQPrices
            // 
            this.behaviorManager.SetBehaviors(this.gvQPrices, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, this.dragDropEvents)))});
            this.gvQPrices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPriceTypeId,
            this.colPriceType,
            this.colTotalPrice,
            this.colAmount,
            this.colValue,
            this.colDate,
            this.colInfo1,
            this.colQuotationId,
            this.colQuotation,
            this.colId1,
            this.colCode1,
            this.colPriceDescription});
            this.gvQPrices.GridControl = this.gcQPrices;
            this.gvQPrices.Name = "gvQPrices";
            // 
            // colPriceTypeId
            // 
            this.colPriceTypeId.FieldName = "PriceTypeId";
            this.colPriceTypeId.MinWidth = 25;
            this.colPriceTypeId.Name = "colPriceTypeId";
            this.colPriceTypeId.Width = 94;
            // 
            // colPriceType
            // 
            this.colPriceType.Caption = "Pruus";
            this.colPriceType.FieldName = "PriceType.Code";
            this.colPriceType.MinWidth = 25;
            this.colPriceType.Name = "colPriceType";
            this.colPriceType.OptionsColumn.ReadOnly = true;
            this.colPriceType.Visible = true;
            this.colPriceType.VisibleIndex = 0;
            this.colPriceType.Width = 94;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.MinWidth = 25;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 2;
            this.colTotalPrice.Width = 94;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.MinWidth = 25;
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 94;
            // 
            // colValue
            // 
            this.colValue.FieldName = "Value";
            this.colValue.MinWidth = 25;
            this.colValue.Name = "colValue";
            this.colValue.Width = 94;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.Width = 94;
            // 
            // colInfo1
            // 
            this.colInfo1.FieldName = "Info";
            this.colInfo1.MinWidth = 25;
            this.colInfo1.Name = "colInfo1";
            this.colInfo1.Width = 94;
            // 
            // colQuotationId
            // 
            this.colQuotationId.FieldName = "QuotationId";
            this.colQuotationId.MinWidth = 25;
            this.colQuotationId.Name = "colQuotationId";
            this.colQuotationId.Width = 94;
            // 
            // colQuotation
            // 
            this.colQuotation.FieldName = "Quotation";
            this.colQuotation.MinWidth = 25;
            this.colQuotation.Name = "colQuotation";
            this.colQuotation.Width = 94;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.MinWidth = 25;
            this.colId1.Name = "colId1";
            this.colId1.Width = 94;
            // 
            // colCode1
            // 
            this.colCode1.FieldName = "Code";
            this.colCode1.MinWidth = 25;
            this.colCode1.Name = "colCode1";
            this.colCode1.Width = 94;
            // 
            // colPriceDescription
            // 
            this.colPriceDescription.Caption = "Buschruving";
            this.colPriceDescription.FieldName = "PriceType.Description";
            this.colPriceDescription.MinWidth = 25;
            this.colPriceDescription.Name = "colPriceDescription";
            this.colPriceDescription.Visible = true;
            this.colPriceDescription.VisibleIndex = 1;
            this.colPriceDescription.Width = 94;
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Tuuvugen";
            this.bbiAdd.Id = 1;
            this.bbiAdd.ImageOptions.ImageIndex = 0;
            this.bbiAdd.ImageOptions.LargeImageIndex = 0;
            this.bbiAdd.Name = "bbiAdd";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Wug";
            this.bbiDelete.Id = 2;
            this.bbiDelete.ImageOptions.ImageIndex = 2;
            this.bbiDelete.ImageOptions.LargeImageIndex = 2;
            this.bbiDelete.Name = "bbiDelete";
            // 
            // QuotationPriceEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcQPrices);
            this.Controls.Add(this.MaterialPriceDockPanel);
            this.Controls.Add(this.PricesDockPanel);
            this.Name = "QuotationPriceEditView";
            this.Size = new System.Drawing.Size(1709, 595);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.PricesDockPanel, 0);
            this.Controls.SetChildIndex(this.MaterialPriceDockPanel, 0);
            this.Controls.SetChildIndex(this.gcQPrices, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.PricesDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrices)).EndInit();
            this.MaterialPriceDockPanel.ResumeLayout(false);
            this.controlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPriceMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPriceMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPriceMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcQPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuotationPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel PricesDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridControl gcQPrices;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQPrices;
        private DevExpress.XtraGrid.GridControl gcPrices;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrices;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents1;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents;
        private System.Windows.Forms.BindingSource bsPrices;
        private System.Windows.Forms.BindingSource bsQuotationPrices;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceTypeUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialDependant;
        private DevExpress.XtraGrid.Columns.GridColumn colFactor;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colIconPath;
        private DevExpress.XtraGrid.Columns.GridColumn colEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModified;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceType;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotation;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode1;
        private DevExpress.XtraBars.Docking.DockPanel MaterialPriceDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceDescription;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraGrid.GridControl gcPriceMaterials;
        private System.Windows.Forms.BindingSource bsPriceMaterials;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPriceMaterials;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalLength;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colValue1;
        private DevExpress.XtraGrid.Columns.GridColumn colDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo2;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationId1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotation1;
        private DevExpress.XtraGrid.Columns.GridColumn colId2;
        private DevExpress.XtraGrid.Columns.GridColumn colCode2;
    }
}
