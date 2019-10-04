using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMain.Model
{
    /// <summary>
    /// Объект Авиапарка пользователя
    /// </summary>
   public class FlightModel
    {
        /// <summary>
        /// Гуид самолета пользователя, так как самолетов у пользователя может быть несколько 1 типа
        /// </summary>
        public Guid uid { get; set; } = new Guid();
        /// <summary>
        /// СМаршрут
        /// </summary>
        public RouteModel Route { get; set; }
        /// <summary>
        /// Состояние в рейсе или нет
        /// </summary>
        public int Reward { get { return Route.Distance * 10; } }
        /// <summary>
        /// Самолет
        /// </summary>
        public AirplaneModel Airplane { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get { return DateStart.AddSeconds(Route.Distance / 100); } }
        /// <summary>
        /// неустойка
        /// </summary>
        public int Forfeit { get { return Route.Distance * 15; } }
        public int Сost { get { return Airplane.FuelConsumption * Route.Distance / 100; } }

        public FlightModel(AirplaneModel airplane)
        {
            if(airplane!=null)
                Airplane = airplane;
        }
    }
}
