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
        public const int MIN_OBJECT_CODE_LENGTH = 4;
        public const int MAX_OBJECT_DESC_LENGTH = 255;
        public const int MAX_OBJECT_INFO_LENGTH = 1023;

        private static readonly ClientContext INSTANCE = new ClientContext();
        public static ClientContext Context { get { return INSTANCE; } }
        private ClientContext() { }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
