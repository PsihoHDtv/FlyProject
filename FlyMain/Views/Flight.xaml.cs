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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FlyMain.ViewModel;

namespace FlyMain.Views
{
    /// <summary>
    /// Логика взаимодействия для rs.xaml
    /// </summary>
    public partial class Flight : UserControl
    {
        public Flight()
        {
            InitializeComponent();
        }
        private FlightViewModel dc
        {
            get
            {
                return this.DataContext as FlightViewModel;
            }
        }
    }
}
