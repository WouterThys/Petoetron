namespace Petoetron.Views.QuotationPrices
{
    partial class QuotationPriceListView
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
            this.bbiAddPrice = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeletePrice = new DevExpress.XtraBars.BarButtonItem();
            this.bbiZoom = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bsQuotationPrices = new System.Windows.Forms.BindingSource(this.components);
            this.bsPrices = new System.Windows.Forms.BindingSource(this.components);
            this.gcPrices = new DevExpress.XtraGrid.GridControl();
            this.gvPrices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPriceUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riSpinEditAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riSpinEditValue = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riSearchLookUpEditPrice = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPriceTypeUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuotationPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSpinEditAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSpinEditValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEditDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSearchLookUpEditPrice)).BeginInit();
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
            this.bbiAddPrice,
            this.bbiDeletePrice,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAddPrice),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDeletePrice),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiZoom)});
            this.MenuBar.OptionsBar.DrawDragBorder = false;
            this.MenuBar.OptionsBar.MultiLine = true;
            this.MenuBar.OptionsBar.UseWholeRow = true;
            this.MenuBar.Text = "Main menu";
            // 
            // bbiAddPrice
            // 
            this.bbiAddPrice.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiAddPrice.Caption = "Tuvugen";
            this.bbiAddPrice.Id = 0;
            this.bbiAddPrice.Name = "bbiAddPrice";
            // 
            // bbiDeletePrice
            // 
            this.bbiDeletePrice.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiDeletePrice.Caption = "Wug";
            this.bbiDeletePrice.Id = 1;
            this.bbiDeletePrice.Name = "bbiDeletePrice";
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
            // bsQuotationPrices
            // 
            this.bsQuotationPrices.DataSource = typeof(Petoetron.Classes.QuotationPrice);
            // 
            // bsPrices
            // 
            this.bsPrices.DataSource = typeof(Petoetron.Classes.PriceType);
            // 
            // gcPrices
            // 
            this.gcPrices.DataSource = this.bsQuotationPrices;
            this.gcPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrices.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcPrices.Location = new System.Drawing.Point(0, 33);
            this.gcPrices.MainView = this.gvPrices;
            this.gcPrices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcPrices.MenuManager = this.barManager;
            this.gcPrices.Name = "gcPrices";
            this.gcPrices.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riSpinEditAmount,
            this.riSpinEditValue,
            this.riDateEditDate,
            this.riSearchLookUpEditPrice});
            this.gcPrices.Size = new System.Drawing.Size(555, 502);
            this.gcPrices.TabIndex = 4;
            this.gcPrices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrices});
            // 
            // gvPrices
            // 
            this.behaviorManager.SetBehaviors(this.gvPrices, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, this.dragDropEvents)))});
            this.gvPrices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPriceUnit,
            this.colAmount,
            this.colValue,
            this.colDate,
            this.colInfo,
            this.colQuotationId,
            this.colPriceId,
            this.colId,
            this.colCode});
            this.gvPrices.DetailHeight = 431;
            this.gvPrices.GridControl = this.gcPrices;
            this.gvPrices.Name = "gvPrices";
            this.gvPrices.OptionsView.ShowGroupPanel = false;
            // 
            // colPriceUnit
            // 
            this.colPriceUnit.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Italic;
            this.colPriceUnit.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colPriceUnit.AppearanceCell.Options.UseFont = true;
            this.colPriceUnit.AppearanceCell.Options.UseForeColor = true;
            this.colPriceUnit.Caption = "Unit";
            this.colPriceUnit.FieldName = "PriceType.PriceTypeUnit";
            this.colPriceUnit.MinWidth = 23;
            this.colPriceUnit.Name = "colPriceUnit";
            this.colPriceUnit.OptionsColumn.AllowEdit = false;
            this.colPriceUnit.OptionsColumn.ReadOnly = true;
            this.colPriceUnit.Visible = true;
            this.colPriceUnit.VisibleIndex = 3;
            this.colPriceUnit.Width = 87;
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
            this.colValue.FieldName = "Value";
            this.colValue.MinWidth = 23;
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 2;
            this.colValue.Width = 195;
            // 
            // riSpinEditValue
            // 
            this.riSpinEditValue.AutoHeight = false;
            this.riSpinEditValue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
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
            // colPriceId
            // 
            this.colPriceId.Caption = "Pruus";
            this.colPriceId.ColumnEdit = this.riSearchLookUpEditPrice;
            this.colPriceId.FieldName = "PriceTypeId";
            this.colPriceId.MinWidth = 23;
            this.colPriceId.Name = "colPriceId";
            this.colPriceId.Visible = true;
            this.colPriceId.VisibleIndex = 1;
            this.colPriceId.Width = 195;
            // 
            // riSearchLookUpEditPrice
            // 
            this.riSearchLookUpEditPrice.AutoHeight = false;
            this.riSearchLookUpEditPrice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riSearchLookUpEditPrice.DataSource = this.bsPrices;
            this.riSearchLookUpEditPrice.DisplayMember = "Code";
            this.riSearchLookUpEditPrice.Name = "riSearchLookUpEditPrice";
            this.riSearchLookUpEditPrice.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.riSearchLookUpEditPrice.ValueMember = "Id";
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPriceTypeUnit,
            this.colUnitPrice,
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
            // colPriceTypeUnit
            // 
            this.colPriceTypeUnit.FieldName = "PriceTypeUnit";
            this.colPriceTypeUnit.Name = "colPriceTypeUnit";
            this.colPriceTypeUnit.Visible = true;
            this.colPriceTypeUnit.VisibleIndex = 3;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 2;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
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
            // QuotationPriceEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcPrices);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "QuotationPriceEditView";
            this.Size = new System.Drawing.Size(555, 535);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuotationPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSpinEditAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSpinEditValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEditDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riSearchLookUpEditPrice)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbiAddPrice;
        private DevExpress.XtraBars.BarButtonItem bbiDeletePrice;
        private System.Windows.Forms.BindingSource bsQuotationPrices;
        private System.Windows.Forms.BindingSource bsPrices;
        private DevExpress.XtraGrid.GridControl gcPrices;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrices;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationId;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceId;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riSpinEditAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit riSpinEditValue;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEditDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit riSearchLookUpEditPrice;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraBars.BarButtonItem bbiZoom;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceTypeUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo1;
        private DevExpress.XtraGrid.Columns.GridColumn colIconPath;
        private DevExpress.XtraGrid.Columns.GridColumn colEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModified;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents;
    }
}
