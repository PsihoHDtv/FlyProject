using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using FlyMain.Data;
using FlyMain.Model;

namespace FlyMain.ViewModel
{
   public class FlightViewModel : ISupportParentViewModel
    {
        public object ParentViewModel { get; set; }

        private DataModel Data { get; set; }

        public  FlightViewModel(DataModel data)
        {
            Data = data;
            RouteList.Clear();
            foreach (RouteModel item in Data.RouteList)
                RouteList.Add(item);
        }
        public FlightViewModel( )
        {
        }
        internal static FlightViewModel Create()
        {
            return ViewModelSource.Create(() => new FlightViewModel());
        }
        internal static FlightViewModel Create(DataModel data)
        {
            return ViewModelSource.Create(() => new FlightViewModel(data));
        }

        public ObservableCollection<FlightModel> FlightList { get; set; } = new ObservableCollection<FlightModel>();
        public ObservableCollection<FleetModel> FleetList { get; set; } = new ObservableCollection<FleetModel>();
        public ObservableCollection<RouteModel> RouteList { get; set; } = new ObservableCollection<RouteModel>();
        public void Reload(DataModel data)
        {

            FlightList.Clear();
            foreach (FlightModel item in Data.FlightList)
                FlightList.Add(item);
            FleetList.Clear();
            foreach (FleetModel item in Data.FleetList)
                FleetList.Add(item);
        }

        public bool UpTimeTable(Guid uid)
        {
            TimeTableModel tt = new TimeTableModel() { Flight= FlightList.Where(x=>x.uid==uid).First() };
            if (tt.Flight != null)
            {
                Data.TimeTableList.Add(tt);
                Data.FlightList.Remove(tt.Flight);
                FlightList.Remove(tt.Flight);
                return true;
            }
            return false;
        }

    }
}
