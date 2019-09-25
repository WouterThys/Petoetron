namespace Petoetron.Views.QuotationMaterials
{
    partial class QuotationMaterialListView
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
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.MenuBar = new DevExpress.XtraBars.Bar();
            this.bbiAddMaterial = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeleteMaterial = new DevExpress.XtraBars.BarButtonItem();
            this.bbiZoom = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bsQuotationMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.bsMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.gcMaterials = new DevExpress.XtraGrid.GridControl();
            this.gvMaterials = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaterialType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riSpinEditAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riSpinEditValue = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riSearchLookUpEditMaterial = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIconPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dragDropEvents = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            this.colGroupCode = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuotationMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSpinEditAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSpinEditValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEditDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSearchLookUpEditMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.AllowMoveBarOnToolbar = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MenuBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAddMaterial,
            this.bbiDeleteMaterial,
            this.bbiZoom});
            this.barManager.MainMenu = this.MenuBar;
            this.barManager.MaxItemId = 3;
            // 
            // MenuBar
            // 
            this.MenuBar.BarName = "Main menu";
            this.MenuBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.MenuBar.DockCol = 0;
            this.MenuBar.DockRow = 0;
            this.MenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddMaterial),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDeleteMaterial),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiZoom)});
            this.MenuBar.OptionsBar.DrawDragBorder = false;
            this.MenuBar.OptionsBar.MultiLine = true;
            this.MenuBar.OptionsBar.UseWholeRow = true;
            this.MenuBar.Text = "Main menu";
            // 
            // bbiAddMaterial
            // 
            this.bbiAddMaterial.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiAddMaterial.Caption = "Tuvugen";
            this.bbiAddMaterial.Id = 0;
            this.bbiAddMaterial.Name = "bbiAddMaterial";
            // 
            // bbiDeleteMaterial
            // 
            this.bbiDeleteMaterial.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiDeleteMaterial.Caption = "Wug";
            this.bbiDeleteMaterial.Id = 1;
            this.bbiDeleteMaterial.Name = "bbiDeleteMaterial";
            // 
            // bbiZoom
            // 
            this.bbiZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiZoom.Caption = "Upen";
            this.bbiZoom.Id = 2;
            this.bbiZoom.Name = "bbiZoom";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(555, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 535);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(555, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 502);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(555, 33);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 502);
            // 
            // bsQuotationMaterials
            // 
            this.bsQuotationMaterials.DataSource = typeof(Petoetron.Classes.QuotationMaterial);
            // 
            // bsMaterials
            // 
            this.bsMaterials.DataSource = typeof(Petoetron.Classes.Material);
            // 
            // gcMaterials
            // 
            this.gcMaterials.DataSource = this.bsQuotationMaterials;
            this.gcMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMaterials.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcMaterials.Location = new System.Drawing.Point(0, 33);
            this.gcMaterials.MainView = this.gvMaterials;
            this.gcMaterials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcMaterials.MenuManager = this.barManager;
            this.gcMaterials.Name = "gcMaterials";
            this.gcMaterials.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riSpinEditAmount,
            this.riSpinEditValue,
            this.riDateEditDate,
            this.riSearchLookUpEditMaterial});
            this.gcMaterials.Size = new System.Drawing.Size(555, 502);
            this.gcMaterials.TabIndex = 4;
            this.gcMaterials.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaterials});
            // 
            // gvMaterials
            // 
            this.behaviorManager.SetBehaviors(this.gvMaterials, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, this.dragDropEvents)))});
            this.gvMaterials.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaterialType,
            this.colMaterialUnit,
            this.colAmount,
            this.colValue,
            this.colDate,
            this.colInfo,
            this.colQuotationId,
            this.colMaterialId,
            this.colId,
            this.colCode,
            this.colGroupCode});
            this.gvMaterials.DetailHeight = 431;
            this.gvMaterials.GridControl = this.gcMaterials;
            this.gvMaterials.GroupCount = 1;
            this.gvMaterials.Name = "gvMaterials";
            this.gvMaterials.OptionsView.ShowGroupPanel = false;
            this.gvMaterials.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroupCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMaterialType
            // 
            this.colMaterialType.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Italic;
            this.colMaterialType.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colMaterialType.AppearanceCell.Options.UseFont = true;
            this.colMaterialType.AppearanceCell.Options.UseForeColor = true;
            this.colMaterialType.Caption = "Type";
            this.colMaterialType.FieldName = "Material.Type.Code";
            this.colMaterialType.MinWidth = 23;
            this.colMaterialType.Name = "colMaterialType";
            this.colMaterialType.OptionsColumn.AllowEdit = false;
            this.colMaterialType.OptionsColumn.ReadOnly = true;
            this.colMaterialType.Visible = true;
            this.colMaterialType.VisibleIndex = 2;
            this.colMaterialType.Width = 87;
            // 
            // colMaterialUnit
            // 
            this.colMaterialUnit.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Italic;
            this.colMaterialUnit.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colMaterialUnit.AppearanceCell.Options.UseFont = true;
            this.colMaterialUnit.AppearanceCell.Options.UseForeColor = true;
            this.colMaterialUnit.Caption = "Unit";
            this.colMaterialUnit.FieldName = "Material.Unit";
            this.colMaterialUnit.MinWidth = 23;
            this.colMaterialUnit.Name = "colMaterialUnit";
            this.colMaterialUnit.OptionsColumn.AllowEdit = false;
            this.colMaterialUnit.OptionsColumn.ReadOnly = true;
            this.colMaterialUnit.Visible = true;
            this.colMaterialUnit.VisibleIndex = 4;
            this.colMaterialUnit.Width = 87;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "#";
            this.colAmount.ColumnEdit = this.riSpinEditAmount;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colAmount.MaxWidth = 58;
            this.colAmount.MinWidth = 23;
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 0;
            this.colAmount.Width = 58;
            // 
            // riSpinEditAmount
            // 
            this.riSpinEditAmount.AutoHeight = false;
            this.riSpinEditAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riSpinEditAmount.IsFloatValue = false;
            this.riSpinEditAmount.Mask.EditMask = "N00";
            this.riSpinEditAmount.Name = "riSpinEditAmount";
            // 
            // colValue
            // 
            this.colValue.ColumnEdit = this.riSpinEditValue;
            this.colValue.DisplayFormat.FormatString = "N";
            this.colValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValue.FieldName = "Value";
            this.colValue.MinWidth = 23;
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 3;
            this.colValue.Width = 195;
            // 
            // riSpinEditValue
            // 
            this.riSpinEditValue.AutoHeight = false;
            this.riSpinEditValue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riSpinEditValue.Mask.EditMask = "N";
            this.riSpinEditValue.Name = "riSpinEditValue";
            // 
            // colDate
            // 
            this.colDate.ColumnEdit = this.riDateEditDate;
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 23;
            this.colDate.Name = "colDate";
            this.colDate.Width = 195;
            // 
            // riDateEditDate
            // 
            this.riDateEditDate.AutoHeight = false;
            this.riDateEditDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateEditDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateEditDate.Name = "riDateEditDate";
            // 
            // colInfo
            // 
            this.colInfo.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Italic;
            this.colInfo.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colInfo.AppearanceCell.Options.UseFont = true;
            this.colInfo.AppearanceCell.Options.UseForeColor = true;
            this.colInfo.FieldName = "Info";
            this.colInfo.MinWidth = 23;
            this.colInfo.Name = "colInfo";
            this.colInfo.OptionsColumn.AllowEdit = false;
            this.colInfo.OptionsColumn.ReadOnly = true;
            this.colInfo.Width = 195;
            // 
            // colQuotationId
            // 
            this.colQuotationId.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Italic;
            this.colQuotationId.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colQuotationId.AppearanceCell.Options.UseFont = true;
            this.colQuotationId.AppearanceCell.Options.UseForeColor = true;
            this.colQuotationId.FieldName = "QuotationId";
            this.colQuotationId.MinWidth = 23;
            this.colQuotationId.Name = "colQuotationId";
            this.colQuotationId.OptionsColumn.AllowEdit = false;
            this.colQuotationId.OptionsColumn.ReadOnly = true;
            this.colQuotationId.Width = 195;
            // 
            // colMaterialId
            // 
            this.colMaterialId.Caption = "Muturiuul";
            this.colMaterialId.ColumnEdit = this.riSearchLookUpEditMaterial;
            this.colMaterialId.FieldName = "MaterialId";
            this.colMaterialId.MinWidth = 23;
            this.colMaterialId.Name = "colMaterialId";
            this.colMaterialId.Visible = true;
            this.colMaterialId.VisibleIndex = 1;
            this.colMaterialId.Width = 195;
            // 
            // riSearchLookUpEditMaterial
            // 
            this.riSearchLookUpEditMaterial.AutoHeight = false;
            this.riSearchLookUpEditMaterial.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riSearchLookUpEditMaterial.DataSource = this.bsMaterials;
            this.riSearchLookUpEditMaterial.DisplayMember = "Code";
            this.riSearchLookUpEditMaterial.Name = "riSearchLookUpEditMaterial";
            this.riSearchLookUpEditMaterial.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.riSearchLookUpEditMaterial.ValueMember = "Id";
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnitPrice,
            this.colUnit,
            this.colWeight,
            this.colTypeId,
            this.colType,
            this.colDescription,
            this.colInfo1,
            this.colIconPath,
            this.colEnabled,
            this.colLastModified,
            this.colId1,
            this.colCode1});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 3;
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 4;
            // 
            // colWeight
            // 
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            // 
            // colTypeId
            // 
            this.colTypeId.FieldName = "TypeId";
            this.colTypeId.Name = "colTypeId";
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "Type.Code";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.ReadOnly = true;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colInfo1
            // 
            this.colInfo1.FieldName = "Info";
            this.colInfo1.Name = "colInfo1";
            // 
            // colIconPath
            // 
            this.colIconPath.FieldName = "IconPath";
            this.colIconPath.Name = "colIconPath";
            // 
            // colEnabled
            // 
            this.colEnabled.FieldName = "Enabled";
            this.colEnabled.Name = "colEnabled";
            // 
            // colLastModified
            // 
            this.colLastModified.FieldName = "LastModified";
            this.colLastModified.Name = "colLastModified";
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // colCode1
            // 
            this.colCode1.FieldName = "Code";
            this.colCode1.Name = "colCode1";
            this.colCode1.Visible = true;
            this.colCode1.VisibleIndex = 0;
            // 
            // colId
            // 
            this.colId.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Italic;
            this.colId.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colId.AppearanceCell.Options.UseFont = true;
            this.colId.AppearanceCell.Options.UseForeColor = true;
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 23;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Width = 195;
            // 
            // colCode
            // 
            this.colCode.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Italic;
            this.colCode.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colCode.AppearanceCell.Options.UseFont = true;
            this.colCode.AppearanceCell.Options.UseForeColor = true;
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 23;
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowEdit = false;
            this.colCode.OptionsColumn.ReadOnly = true;
            this.colCode.Width = 208;
            // 
            // colGroupCode
            // 
            this.colGroupCode.Caption = "Grup";
            this.colGroupCode.FieldName = "GroupCode";
            this.colGroupCode.MinWidth = 25;
            this.colGroupCode.Name = "colGroupCode";
            this.colGroupCode.Visible = true;
            this.colGroupCode.VisibleIndex = 5;
            this.colGroupCode.Width = 94;
            // 
            // QuotationMaterialListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcMaterials);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "QuotationMaterialListView";
            this.Size = new System.Drawing.Size(555, 535);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuotationMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSpinEditAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSpinEditValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEditDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSearchLookUpEditMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar MenuBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiAddMaterial;
        private DevExpress.XtraBars.BarButtonItem bbiDeleteMaterial;
        private System.Windows.Forms.BindingSource bsQuotationMaterials;
        private System.Windows.Forms.BindingSource bsMaterials;
        private DevExpress.XtraGrid.GridControl gcMaterials;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMaterials;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationId;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialId;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riSpinEditAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riSpinEditValue;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialType;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEditDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit riSearchLookUpEditMaterial;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo1;
        private DevExpress.XtraGrid.Columns.GridColumn colIconPath;
        private DevExpress.XtraGrid.Columns.GridColumn colEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModified;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode1;
        private DevExpress.XtraBars.BarButtonItem bbiZoom;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupCode;
    }
}
