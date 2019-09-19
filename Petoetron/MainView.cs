using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils.MVVM.Services;
using DevExpress.LookAndFeel;
using Petoetron.Services;
using Database;
using Petoetron.Resources;
using DevExpress.XtraBars.Navigation;
using Petoetron.Models;
using Petoetron.Views.Reports;
using Petoetron.Classes;
using DevExpress.XtraReports.UI;

namespace Petoetron
{
    public partial class MainView : RibbonForm
    {
        public MainView()
        {
            InitializeComponent();
            Win32SubclasserException.Allow = false;
            if (!mvvmContext.IsDesignMode)
            {
                InitializeBindings();
                InitializeServices();
                InitializeLayouts();
            }
        }

        protected void InitializeLayouts()
        {
            // Ribbon and Dock panels
            ribbonControl.Images = images.Images24x24;
            ribbonControl.LargeImages = images.Images48x48;
            documentManager.RibbonAndBarsMergeStyle = RibbonAndBarsMergeStyle.WhenNotFloating;
            Ribbon.MdiMergeStyle = RibbonMdiMergeStyle.Always;
            Ribbon.Merge += Ribbon_Merge;

            dpNavigation.Options.ShowCloseButton = false;
            bbiShowInfo.ImageOptions.ImageIndex = 32;
            bbiShowInfo.ImageOptions.LargeImageIndex = 32;

            // Accordion
            accordionControl.Images = images.Images24x24;
            accordionControl.AllowItemSelection = true;

            images.DefaultSize = ImageSize.i16x16;
            aceCustomers.Image = images.GetIcon(ModuleTypes.CustomerListModule);
            aceMaterialTypes.Image = images.GetIcon(ModuleTypes.MaterialTypeListModule);
            aceMaterials.Image = images.GetIcon(ModuleTypes.MaterialListModule);
            acePriceTypes.Image = images.GetIcon(ModuleTypes.PriceTypeListModule);

            aceCustomers.Tag = ModuleTypes.CustomerListModule;
            aceMaterialTypes.Tag = ModuleTypes.MaterialTypeListModule;
            aceMaterials.Tag = ModuleTypes.MaterialListModule;
            acePriceTypes.Tag = ModuleTypes.PriceTypeListModule;


            bbiReport.ItemClick += BbiReport_ItemClick;
        }

        private void BbiReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var fluent = mvvmContext.OfType<MainViewModel>();
            var report = new QuotationReport();
            report.SetDataSource(new Quotation());
            report.ShowPreview();
        }

        protected void InitializeServices()
        {
            mvvmContext.RegisterService(DocumentManagerService.Create(tabbedView1));
            mvvmContext.RegisterService(MessageBoxService.Create(DefaultMessageBoxServiceType.XtraMessageBox));
            mvvmContext.RegisterService("FloatingDocumentService", WindowedDocumentManagerService.CreateXtraFormService(this));
            mvvmContext.RegisterDefaultService("DataChangedService", new DataChangedService());
            //mvvmContext.RegisterDefaultService("ErrorManagerService", new ErrorManagerService(mvvmContext.GetViewModel<MainViewModel>()));
            //mvvmContext.RegisterService("DisplayMessageService", new DisplayMessageService(this));
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext.OfType<MainViewModel>();

            // Triggers
            //fluent.SetTrigger(m => m.DatabaseState, (state) => DatabaseStateChanged(state));
            //fluent.SetTrigger(m => m.Context.ClientState, (clientState) => UpdateClientState(clientState));
            //fluent.SetTrigger(m => m.Context.LoggedUser, (user) => UpdateLoggedUserViews(user));

            fluent.SetBinding(bbiDbState, ss => ss.ImageIndex, m => m.DatabaseState,
                (args) => DatabaseStateToIcon(args));
            fluent.BindCommand(bbiShowInfo, m => m.ShowInfo());

            //fluent.SetBinding(bbiDatabaseState, ss => ss.ImageIndex, m => m.Context.ServerStatus.DatabaseState,
            //    (args) =>
            //    {
            //        switch (args)
            //        {
            //            default: // TODO other states
            //            case Database.DbState.Running: return 25;
            //            case Database.DbState.Error: return 26;
            //        }
            //    });

            // Binding
            //jobsFilterView.InitializeBindings(fluent.ViewModel.JobsFilterViewModel);
            //settingsFilterView.InitializeBindings(fluent.ViewModel.SettingsFilterViewModel);
            //dataFilterView.InitializeBindings(fluent.ViewModel.DataFilterViewModel);

            //fluent.SetBinding(bsiServerUi, bsi => bsi.Caption, m => m.Context.ClientSettings.Address, (adr) => adr.Name + " (" + adr.Url + ")");
            //fluent.SetBinding(bsiVersion, bsi => bsi.Caption, m => m.Context.ServerStatus.VersionString);
            //fluent.BindCommand(bbiLogOut, m => m.LogOffUser(true), m => true);

            //fluent.SetBinding(beiUseUserLanguage, cb => cb.Checked, m => m.Context.UseUserLanguage);
            //fluent.SetBinding(beiLanguage, cb => cb.Enabled, m => m.Context.UseUserLanguage, (u) => !u, (u) => !u);
            //fluent.SetBinding(beiLanguage, cb => cb.EditValue, m => m.Context.Language);

            //fluent.SetBinding(xtpJobs, xtp => xtp.PageVisible, m => m.ShowJobs);
            //fluent.SetBinding(xtpData, xtp => xtp.PageVisible, m => m.ShowData);
            //fluent.SetBinding(xtpSettings, xtp => xtp.PageVisible, m => m.ShowSettings);

            // Events
            fluent.WithEvent(this, "Load").EventToCommand(x => x.Load());
            fluent.WithEvent<FormClosingEventArgs>(this, "FormClosing").EventToCommand(m => m.OnClose(null), new Func<CancelEventArgs, object>((args) => args));
            fluent.WithEvent<AccordionControl, SelectedElementChangedEventArgs>(accordionControl, "SelectedElementChanged").SetBinding(
                (m) => m.ActiveModule,
                (args) => args.Element.Tag as IModuleType,
                (ac, mdl) =>
                {
                    if (mdl != null && ac.Elements != null)
                    {
                        foreach (var element in ac.Elements)
                        {
                            var found = element.Elements.Where(el => el.Tag != null && ((IModuleType)el.Tag).Id == mdl.Id).FirstOrDefault();
                            if (found != null)
                            {
                                ac.SelectedElement = found;
                                return;
                            }
                        }
                    }
                });

            UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;

            // Layout
            string skin = fluent.ViewModel.Context.ViewSkin;
            if (!string.IsNullOrEmpty(skin))
            {
                UserLookAndFeel defaultLF = UserLookAndFeel.Default;
                defaultLF.SkinName = skin;
            }
        }

        private void Default_StyleChanged(object sender, EventArgs e)
        {
            var fluent = mvvmContext.OfType<MainViewModel>();
            UserLookAndFeel defaultLF = UserLookAndFeel.Default;
            fluent.ViewModel.Context.ViewSkin = defaultLF.SkinName;
        }

        #region Triggers and States
        
        private int DatabaseStateToIcon(DbState state)
        {
            switch (state)
            {
                default:
                case DbState.InTheVoid:
                    return 16;
                case DbState.Initializing:
                case DbState.Initialized:
                case DbState.Updating:
                case DbState.Updated:
                    return 15;
                case DbState.Running:
                    return 14;
                case DbState.Error:
                    return 13;
            }
        }

        #endregion

        #region EVENTS
        private void Ribbon_Merge(object sender, RibbonMergeEventArgs e)
        {
            if (e.MergeOwner.MergedPages.Count > 0)
            {
                e.MergeOwner.SelectedPage = e.MergeOwner.MergedPages[0];
            }
        }

        #endregion

    }
}