using Petoetron.Classes.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron
{
    public class ClientContext : INotifyPropertyChanged
    {
        public const int MAX_OBJECT_CODE_LENGTH = 45;
        public const int MIN_OBJECT_CODE_LENGTH = 3;
        public const int MAX_OBJECT_DESC_LENGTH = 255;
        public const int MAX_OBJECT_INFO_LENGTH = 1023;

        private static readonly ClientContext INSTANCE = new ClientContext();
        public static ClientContext Context { get { return INSTANCE; } }
        private ClientContext() { }

        private IniFile iniFile;

        private string dbServer;
        private string dbSchema;
        private string dbUser;
        private string dbPassword;
        private string dbProvider;

        private bool logErrors;
        private bool logWarnings;
        private bool logInfo;

        private string dataDirectory;
        private int maxIconSide;

        private string viewSkin;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public void Initialize()
        {
            iniFile = new IniFile(@"Config\Settings.ini");

            dbServer = iniFile.ReadString("Database", "DbServer");
            dbSchema = iniFile.ReadString("Database", "DbSchema");
            dbUser = iniFile.ReadString("Database", "DbUser");
            dbPassword = iniFile.ReadString("Database", "DbPassword");
            dbProvider = iniFile.ReadString("Database", "DbProvider");

            logErrors = iniFile.ReadBool("Logs", "LogErrors");
            logWarnings = iniFile.ReadBool("Logs", "LogWarnings");
            logInfo = iniFile.ReadBool("Logs", "LogInfo");

            dataDirectory = iniFile.ReadString("Files", "DataDirectory");
            maxIconSide = iniFile.ReadInt("Files", "MaxIconSide");

            viewSkin = iniFile.ReadString("View", "ViewSkin");
        }



        public string DbServer { get => dbServer; set => dbServer = value; }
        public string DbSchema { get => dbSchema; set => dbSchema = value; }
        public string DbUser { get => dbUser; set => dbUser = value; }
        public string DbPassword { get => dbPassword; set => dbPassword = value; }
        public string DbProvider { get => dbProvider; set => dbProvider = value; }

        public bool LogErrors { get => logErrors; set => logErrors = value; }
        public bool LogWarnings { get => logWarnings; set => logWarnings = value; }
        public bool LogInfo { get => logInfo; set => logInfo = value; }

        public string DataDirectory { get => dataDirectory; set => dataDirectory = value; }
        public int MaxIconSide { get => maxIconSide; set => maxIconSide = value; }

        public string ViewSkin
        {
            get { return viewSkin; }
            set
            {
                viewSkin = value;
                iniFile.WriteString("View", "ViewSkin", value);
                OnPropertyChanged("ViewSkin");
            }
        }
    }
}
