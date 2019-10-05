using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using DevExpress.Mvvm.POCO;
using FlyMain.Data;
namespace FlyMain.ViewModel
{
    public class MainViewModel
    {
        
        public FlightViewModel Flight { get; set; }
        public FleetViewModel Fleet { get; set; }
        public ShopViewModel Shop { get; set; }
        public TimeTableViewModel TimeTable { get; set; }

        public DataModel Data { get; set; }
        public virtual WindowState WindowState { get; set; } = WindowState.Maximized;

        public MainViewModel()
        {
            Data = new DataModel();

            Flight = FlightViewModel.Create(Data);
            Fleet =  FleetViewModel.Create(Data);
            Shop = ShopViewModel.Create(Data);
            TimeTable =  TimeTableViewModel.Create(Data);

            Flight.ParentViewModel = this;
            Fleet.ParentViewModel = this;
            Shop.ParentViewModel = this;
            TimeTable.ParentViewModel = this;
            Flight.Reload(Data);

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        public static MainViewModel Create()
        {
            return ViewModelSource.Create(() => new MainViewModel());
        }

        public void OnSeletedViewModel(int newIndexTab, object newViewModelTab)
        {
            if (CurrentTab!= Flight && newViewModelTab == Flight)
            {
                CurrentTab = Flight;
                Flight.Reload(Data);
            }
            if (CurrentTab != Fleet && newViewModelTab == Fleet)
            {
                CurrentTab = Fleet;
                Fleet.Reload(Data);
            }
            if (CurrentTab != Shop && newViewModelTab == Shop)
            {
                CurrentTab = Shop;
            }
            if (CurrentTab != TimeTable && newViewModelTab == TimeTable)
            {
                CurrentTab = TimeTable;
                TimeTable.Reload(Data);
            }

        }
        private object CurrentTab { get; set; } = new object();

        private void timer_Tick(object sender, EventArgs e)
        {
            Data.Date = DateTime.Now;
            Data.TimeTableList.ToList().ForEach((x) =>
            {
                if (x.Status == 0 && x.Flight.DateStart <= Data.Date)
                {
                    x.Status = 1;
                }
                else if (x.Status == 1 && x.Flight.DateEnd <= Data.Date)
                {
                    x.Status = 2;
                    Data.Ballance += x.Flight.Reward;
                    MessageBox.Show("Рейс завершен. Награда: " + x.Flight.Reward);
                }
            });
            TimeTable.Reload(Data);
        }
    }
}
