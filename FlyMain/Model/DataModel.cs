using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyMain.Model;
namespace FlyMain.Data
{
   /// <summary>
   /// Корневой класс модели данных, все остальные структуры должны работать через него
   /// </summary>
  public  class DataModel
    {
        public int Ballance { get; set; } = 500000;
        public DateTime Date { get; set; } = DateTime.Now;
        public int FuelPrice { get; set; } = 2;
        /// <summary>
        /// Список маршрутов
        /// </summary>
        public ObservableCollection<RouteModel> RouteList = new ObservableCollection<RouteModel>();
        /// <summary>
        /// Список городов
        /// </summary>
        public ObservableCollection<CityModel> CityList = new ObservableCollection<CityModel>();
        /// <summary>
        /// Список самолетов
        /// </summary>
        public ObservableCollection<AirplaneModel> AirplaneList = new ObservableCollection<AirplaneModel>();
        /// <summary>
        /// Список самолетов пользователя
        /// </summary>
        public ObservableCollection<FleetModel> FleetList = new ObservableCollection<FleetModel>();
        /// <summary>
        /// Расписание полетов
        /// </summary>
        public ObservableCollection<TimeTableModel> TimeTableList = new ObservableCollection<TimeTableModel>();


        public DataModel()
        {
            //Тут нужно сформировать списки

        }
    }
}
