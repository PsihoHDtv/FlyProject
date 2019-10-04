using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
    }
}
