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
        /// <summary>
        /// Список рейсов
        /// </summary>
        public ObservableCollection<FlightModel> FlightList = new ObservableCollection<FlightModel>();


        public DataModel()
        {
            //Тут нужно сформировать списки
            CityList.Add(new CityModel() { uid = new Guid(), Name = "Пермь" });
            CityList.Add(new CityModel() { uid = new Guid(), Name = "Екат" });
            CityList.Add(new CityModel() { uid = new Guid(), Name = "Москва" });
            CityList.Add(new CityModel() { uid = new Guid(), Name = "Питер" });
            CityList.Add(new CityModel() { uid = new Guid(), Name = "Тюмень" });
            CityList.Add(new CityModel() { uid = new Guid(), Name = "Киров" });
            CityList.Add(new CityModel() { uid = new Guid(), Name = "Саратов" });

            AirplaneList.Add(new AirplaneModel() {uid=new Guid(), Name = "самолет1", FuelConsumption = 100, CurrentCity = CityList.First(), MaxDistance = 2000, Price = 5000 });
            AirplaneList.Add(new AirplaneModel() { uid = new Guid(), Name = "самолет2", FuelConsumption = 120, CurrentCity = CityList.First(), MaxDistance = 5000, Price = 7000 });
            AirplaneList.Add(new AirplaneModel() { uid = new Guid(), Name = "самолет3", FuelConsumption = 160, CurrentCity = CityList.Last(), MaxDistance = 10000, Price = 10000 });

            //FleetList.Add(new FleetModel(AirplaneList.Last()));//эта строчка для тестов 
            RouteList.Add(new RouteModel() { uid = new Guid(), CityStart = CityList.First(), CityEnd = CityList.Last(), Distance = 100 });
            FlightList.Add(new FlightModel(AirplaneList.Last()) { uid = new Guid(), Route = RouteList.First(), DateStart = DateTime.Now, DateEnd = DateTime.Now.AddMinutes(20), Forfeit = 100, Reward = 10 });
            TimeTableList.Add(new TimeTableModel() { Flight = FlightList.First() });
        }
    }
}
