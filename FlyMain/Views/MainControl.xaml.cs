using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using FlyMain.ViewModel;
namespace FlyMain.Views
{
    /// <summary>
    /// Логика взаимодействия для MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }
        private MainViewModel dc
        {
            get
            {
                return this.DataContext as MainViewModel;
            }
        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var tc = sender as TabControl;
            var custSender = tc.SelectedItem; 
            if (custSender == null) return;
            var selectedDataContext = ((ContentControl)((TabItem)custSender).Content).DataContext;
            var dc = this.DataContext as MainViewModel;
            if (dc != null) dc.OnSeletedViewModel(1, selectedDataContext);
        }
    }
}
