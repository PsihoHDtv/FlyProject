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
using FlyMain.Model;
using FlyMain.ViewModel;

namespace FlyMain.Views
{
    /// <summary>
    /// Логика взаимодействия для TimeTable.xaml
    /// </summary>
    public partial class TimeTable : UserControl
    {
        public TimeTable()
        {
            InitializeComponent();
        }
        private TimeTableViewModel dc
        {
            get
            {
                return this.DataContext as TimeTableViewModel;
            }
        }

        void cancel_Click(object sender, RoutedEventArgs e)
        {

            for (var vis = sender as Visual; vis != null; vis = VisualTreeHelper.GetParent(vis) as Visual)
                if (vis is DataGridRow)
                {
                    Guid id = ((vis as DataGridRow).DataContext as TimeTableModel).Flight.uid;
                    if (dc.CancelFlight(id))
                    {
                        MessageBox.Show("Рейс отменен");
                    }
                    else
                    {
                        MessageBox.Show("Рейс начат и не может быть отменен");
                    }
                    break;
                }
        }
    }
}
