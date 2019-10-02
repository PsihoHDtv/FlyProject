using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace FlyMain.Common
{
    public class NotifierWindow : Window
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
