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
            #region Cities
            CityList.Add(new CityModel()
            {
                Name = "Петропавловск-Камчатский",
                uid = new Guid()
            });
            CityList.Add(new CityModel()
            {
                Name = "Пермь",
                uid = new Guid()
            });
            CityList.Add(new CityModel()
            {
                Name = "Москва",
                uid = new Guid()
            });
            CityList.Add(new CityModel()
            {
                Name = "Омск",
                uid = new Guid()
            });
            CityList.Add(new CityModel()
            {
                Name = "Тюмень",
                uid = new Guid()
            });
            CityList.Add(new CityModel()
            {
                Name = "Санкт-Петербург",
                uid = new Guid()
            });
            CityList.Add(new CityModel()
            {
                Name = "Ростов-на-Дону",
                uid = new Guid()
            });
            CityList.Add(new CityModel()
            {
                Name = "Рязань",
                uid = new Guid()
            });
            CityList.Add(new CityModel()
            {
                Name = "Иркутск",
                uid = new Guid()
            });
            CityList.Add(new CityModel()
            {
                Name = "Самара",
                uid = new Guid()
            });
            #endregion

            #region Airplanes
            AirplaneList.Add(new AirplaneModel()
            {
                uid = new Guid(),
                Name = "Боинг 747",
                FuelConsumption = 1190,
                CurrentCity = CityList.Where(x => x.Name == "Петропавловск-Камчатский").FirstOrDefault(),
                MaxDistance = 12100,
                AirplaneType = 1,
                Capacity = 425,
                Price = 10000
            });
            AirplaneList.Add(new AirplaneModel()
            {
                uid = new Guid(),
                Name = "ТУ 134",
                FuelConsumption = 360,
                CurrentCity = CityList.Where(x => x.Name == "Пермь").FirstOrDefault(),
                MaxDistance = 2800,
                AirplaneType = 1,
                Capacity = 80,
                Price = 2500
            });
            AirplaneList.Add(new AirplaneModel()
            {
                uid = new Guid(),
                Name = "Sukhoi SuperJet-100 ",
                FuelConsumption = 530,
                CurrentCity = CityList.Where(x => x.Name == "Москва").FirstOrDefault(),
                MaxDistance = 4500,
                AirplaneType = 1,
                Capacity = 95,
                Price = 3900
            });
            AirplaneList.Add(new AirplaneModel()
            {
                uid = new Guid(),
                Name = "ИЛ 62",
                FuelConsumption = 600,
                CurrentCity = CityList.Where(x => x.Name == "Омск").FirstOrDefault(),
                MaxDistance = 10000,
                AirplaneType = 1,
                Capacity = 138,
                Price = 5000
            });
            AirplaneList.Add(new AirplaneModel()
            {
                uid = new Guid(),
                Name = "ИЛ 86",
                FuelConsumption = 570,
                CurrentCity = CityList.Where(x => x.Name == "Тюмень").FirstOrDefault(),
                MaxDistance = 4350,
                AirplaneType = 1,
                Capacity = 243,
                Price = 4700
            });
            AirplaneList.Add(new AirplaneModel()
            {
                uid = new Guid(),
                Name = "АН 12",
                FuelConsumption = 600,
                CurrentCity = CityList.Where(x => x.Name == "Санкт-Петербург").FirstOrDefault(),
                MaxDistance = 4300,
                AirplaneType = 0,
                Capacity = 20,
                Price = 6000
            });
            AirplaneList.Add(new AirplaneModel()
            {
                uid = new Guid(),
                Name = "ТУ 154",
                FuelConsumption = 590,
                CurrentCity = CityList.Where(x => x.Name == "Ростов-на-Дону").FirstOrDefault(),
                MaxDistance = 5000,
                AirplaneType = 0,
                Capacity = 18,
                Price = 5700
            });
            AirplaneList.Add(new AirplaneModel()
            {
                uid = new Guid(),
                Name = "ТУ 154",
                FuelConsumption = 1200,
                CurrentCity = CityList.Where(x => x.Name == "Рязань").FirstOrDefault(),
                MaxDistance = 3200,
                AirplaneType = 0,
                Capacity = 100,
                Price = 11000
            });
            #endregion

            #region Routes
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), CityEnd = CityList.Where(x => x.Name == "Пермь").First(), Distance = 5836 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), CityEnd = CityList.Where(x => x.Name == "Москва").First(), Distance = 6776 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), CityEnd = CityList.Where(x => x.Name == "Омск").First(), Distance = 5221 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), CityEnd = CityList.Where(x => x.Name == "Тюмень").First(), Distance = 5471 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), CityEnd = CityList.Where(x => x.Name == "Санкт-Петербург").First(), Distance = 6639 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), CityEnd = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), Distance = 7465 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), CityEnd = CityList.Where(x => x.Name == "Рязань").First(), Distance = 6797 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), CityEnd = CityList.Where(x => x.Name == "Иркутск").First(), Distance = 3579 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), CityEnd = CityList.Where(x => x.Name == "Самара").First(), Distance = 6487 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Пермь").First(), CityEnd = CityList.Where(x => x.Name == "Москва").First(), Distance = 1154 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Пермь").First(), CityEnd = CityList.Where(x => x.Name == "Омск").First(), Distance = 1100 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Пермь").First(), CityEnd = CityList.Where(x => x.Name == "Тюмень").First(), Distance = 562 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Пермь").First(), CityEnd = CityList.Where(x => x.Name == "Санкт-Петербург").First(), Distance = 1491 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Пермь").First(), CityEnd = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), Distance = 1629 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Пермь").First(), CityEnd = CityList.Where(x => x.Name == "Рязань").First(), Distance = 1081 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Пермь").First(), CityEnd = CityList.Where(x => x.Name == "Иркутск").First(), Distance = 3050 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Пермь").First(), CityEnd = CityList.Where(x => x.Name == "Самара").First(), Distance = 659 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Пермь").First(), CityEnd = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), Distance = 5836 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Москва").First(), CityEnd = CityList.Where(x => x.Name == "Пермь").First(), Distance = 1154 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Москва").First(), CityEnd = CityList.Where(x => x.Name == "Омск").First(), Distance = 2235 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Москва").First(), CityEnd = CityList.Where(x => x.Name == "Тюмень").First(), Distance = 1710 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Москва").First(), CityEnd = CityList.Where(x => x.Name == "Санкт-Петербург").First(), Distance = 634 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Москва").First(), CityEnd = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), Distance = 959 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Москва").First(), CityEnd = CityList.Where(x => x.Name == "Рязань").First(), Distance = 183 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Москва").First(), CityEnd = CityList.Where(x => x.Name == "Иркутск").First(), Distance = 4202 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Москва").First(), CityEnd = CityList.Where(x => x.Name == "Самара").First(), Distance = 853 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Москва").First(), CityEnd = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), Distance = 6776 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Омск").First(), CityEnd = CityList.Where(x => x.Name == "Пермь").First(), Distance = 1100 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Омск").First(), CityEnd = CityList.Where(x => x.Name == "Москва").First(), Distance = 2235 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Омск").First(), CityEnd = CityList.Where(x => x.Name == "Тюмень").First(), Distance = 542 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Омск").First(), CityEnd = CityList.Where(x => x.Name == "Санкт-Петербург").First(), Distance = 2584 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Омск").First(), CityEnd = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), Distance = 2474 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Омск").First(), CityEnd = CityList.Where(x => x.Name == "Рязань").First(), Distance = 2135 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Омск").First(), CityEnd = CityList.Where(x => x.Name == "Иркутск").First(), Distance = 2043 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Омск").First(), CityEnd = CityList.Where(x => x.Name == "Самара").First(), Distance = 1523 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Омск").First(), CityEnd = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), Distance = 5221 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Тюмень").First(), CityEnd = CityList.Where(x => x.Name == "Пермь").First(), Distance = 562 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Тюмень").First(), CityEnd = CityList.Where(x => x.Name == "Москва").First(), Distance = 1710 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Тюмень").First(), CityEnd = CityList.Where(x => x.Name == "Омск").First(), Distance = 542 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Тюмень").First(), CityEnd = CityList.Where(x => x.Name == "Санкт-Петербург").First(), Distance = 2042 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Тюмень").First(), CityEnd = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), Distance = 2059 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Тюмень").First(), CityEnd = CityList.Where(x => x.Name == "Рязань").First(), Distance = 1623 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Тюмень").First(), CityEnd = CityList.Where(x => x.Name == "Иркутск").First(), Distance = 2510 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Тюмень").First(), CityEnd = CityList.Where(x => x.Name == "Самара").First(), Distance = 1071 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Тюмень").First(), CityEnd = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), Distance = 5471 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Санкт-Петербург").First(), CityEnd = CityList.Where(x => x.Name == "Пермь").First(), Distance = 1491 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Санкт-Петербург").First(), CityEnd = CityList.Where(x => x.Name == "Москва").First(), Distance = 634 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Санкт-Петербург").First(), CityEnd = CityList.Where(x => x.Name == "Омск").First(), Distance = 2584 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Санкт-Петербург").First(), CityEnd = CityList.Where(x => x.Name == "Тюмень").First(), Distance = 2042 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Санкт-Петербург").First(), CityEnd = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), Distance = 1541 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Санкт-Петербург").First(), CityEnd = CityList.Where(x => x.Name == "Рязань").First(), Distance = 816 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Санкт-Петербург").First(), CityEnd = CityList.Where(x => x.Name == "Иркутск").First(), Distance = 4416 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Санкт-Петербург").First(), CityEnd = CityList.Where(x => x.Name == "Самара").First(), Distance = 1417 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Санкт-Петербург").First(), CityEnd = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), Distance = 6639 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), CityEnd = CityList.Where(x => x.Name == "Пермь").First(), Distance = 1629 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), CityEnd = CityList.Where(x => x.Name == "Москва").First(), Distance = 959 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), CityEnd = CityList.Where(x => x.Name == "Омск").First(), Distance = 2474 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), CityEnd = CityList.Where(x => x.Name == "Тюмень").First(), Distance = 2059 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), CityEnd = CityList.Where(x => x.Name == "Санкт-Петербург").First(), Distance = 1541 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), CityEnd = CityList.Where(x => x.Name == "Рязань").First(), Distance = 823 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), CityEnd = CityList.Where(x => x.Name == "Иркутск").First(), Distance = 4040 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), CityEnd = CityList.Where(x => x.Name == "Самара").First(), Distance = 991 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), CityEnd = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), Distance = 7465 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Рязань").First(), CityEnd = CityList.Where(x => x.Name == "Пермь").First(), Distance = 1081 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Рязань").First(), CityEnd = CityList.Where(x => x.Name == "Москва").First(), Distance = 183 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Рязань").First(), CityEnd = CityList.Where(x => x.Name == "Омск").First(), Distance = 2135 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Рязань").First(), CityEnd = CityList.Where(x => x.Name == "Тюмень").First(), Distance = 1623 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Рязань").First(), CityEnd = CityList.Where(x => x.Name == "Санкт-Петербург").First(), Distance = 816 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Рязань").First(), CityEnd = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), Distance = 823 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Рязань").First(), CityEnd = CityList.Where(x => x.Name == "Иркутск").First(), Distance = 4129 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Рязань").First(), CityEnd = CityList.Where(x => x.Name == "Самара").First(), Distance = 696 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Рязань").First(), CityEnd = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), Distance = 6797 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Иркутск").First(), CityEnd = CityList.Where(x => x.Name == "Пермь").First(), Distance = 3050 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Иркутск").First(), CityEnd = CityList.Where(x => x.Name == "Москва").First(), Distance = 4202 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Иркутск").First(), CityEnd = CityList.Where(x => x.Name == "Омск").First(), Distance = 2043 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Иркутск").First(), CityEnd = CityList.Where(x => x.Name == "Тюмень").First(), Distance = 2510 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Иркутск").First(), CityEnd = CityList.Where(x => x.Name == "Санкт-Петербург").First(), Distance = 4416 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Иркутск").First(), CityEnd = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), Distance = 4040 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Иркутск").First(), CityEnd = CityList.Where(x => x.Name == "Рязань").First(), Distance = 4129 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Иркутск").First(), CityEnd = CityList.Where(x => x.Name == "Самара").First(), Distance = 3561 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Иркутск").First(), CityEnd = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), Distance = 3579 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Самара").First(), CityEnd = CityList.Where(x => x.Name == "Пермь").First(), Distance = 659 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Самара").First(), CityEnd = CityList.Where(x => x.Name == "Москва").First(), Distance = 853 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Самара").First(), CityEnd = CityList.Where(x => x.Name == "Омск").First(), Distance = 1523 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Самара").First(), CityEnd = CityList.Where(x => x.Name == "Тюмень").First(), Distance = 1071 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Самара").First(), CityEnd = CityList.Where(x => x.Name == "Санкт-Петербург").First(), Distance = 1417 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Самара").First(), CityEnd = CityList.Where(x => x.Name == "Ростов-на-Дону").First(), Distance = 991 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Самара").First(), CityEnd = CityList.Where(x => x.Name == "Рязань").First(), Distance = 696 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Самара").First(), CityEnd = CityList.Where(x => x.Name == "Иркутск").First(), Distance = 3561 });
            RouteList.Add(new RouteModel() { CityStart = CityList.Where(x => x.Name == "Самара").First(), CityEnd = CityList.Where(x => x.Name == "Петропавловск-Камчатский").First(), Distance = 6487 });

            #endregion

            FlightList.Add(new FlightModel(AirplaneList.Last()) { uid = new Guid(), Route = RouteList.First(), DateStart = DateTime.Now, DateEnd = DateTime.Now.AddMinutes(20), Forfeit = 100, Reward = 10 });
            TimeTableList.Add(new TimeTableModel() { Flight = FlightList.First() });
        }
    }
}
