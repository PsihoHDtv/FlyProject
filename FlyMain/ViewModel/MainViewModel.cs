using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FlyMain.Data;
namespace FlyMain.ViewModel
{
    public class MainViewModel
    {
        public FlightViewModel Flight { get; set; }
        public FleetViewModel Fleet { get; set; }
        public ShoopViewModel Shoop { get; set; }
        public TimeTableViewModel TimeTable { get; set; }

        public DataModel Data { get; set; }
        public virtual WindowState WindowState { get; set; } = WindowState.Maximized;

        protected MainViewModel()
        {
            Data = new DataModel();

            Flight =new FlightViewModel(Data);
            Fleet = new FleetViewModel(Data);
            Shoop = new ShoopViewModel(Data);
            TimeTable = new TimeTableViewModel(Data);
        }
    }
}
