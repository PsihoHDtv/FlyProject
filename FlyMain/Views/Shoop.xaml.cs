using System;
using System.Collections;
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
using FlyMain.ViewModel;
using FlyMain.Model;
namespace FlyMain.Views
{
    /// <summary>
    /// Логика взаимодействия для Shoop.xaml
    /// </summary>
    public partial class Shoop : UserControl
    {
        public Shoop()
        {
            InitializeComponent();
        }
        private ShoopViewModel dc
        {
            get
            {
                return this.DataContext as ShoopViewModel;
            }
        }
        private IEnumerable<DataGridRow> GetDataGridRowsForButtons(DataGrid grid)
        { //IQueryable 
            var itemsSource = grid.ItemsSource as IEnumerable;
            if (null == itemsSource) yield return null;
            foreach (var item in itemsSource)
            {
                var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (null != row & row.IsSelected) yield return row;
            }
        }

        void sell_Click(object sender, RoutedEventArgs e)
        {

            for (var vis = sender as Visual; vis != null; vis = VisualTreeHelper.GetParent(vis) as Visual)
                if (vis is DataGridRow)
                {
                    // var row = (DataGrid)vis;

                    var rows = GetDataGridRowsForButtons(shop_dg);
                    Guid id;
                    foreach (DataGridRow dr in rows)
                    {
                        id = (dr.Item as AirplaneModel).uid;
                        if(dc.ByAirplane(id))
                            MessageBox.Show("Самолет куплен" );
                        break;
                    }
                    break;
                }
        }
    }

}
