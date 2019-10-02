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
   public class FleetModel
    {
        /// <summary>
        /// Гуид самолета пользователя, так как самолетов у пользователя может быть несколько 1 типа
        /// </summary>
        public Guid uid { get; set; } = new Guid();
        /// <summary>
        /// Самолет
        /// </summary>
        public AirplaneModel Airplane { get; set; }
        /// <summary>
        /// Состояние в рейсе или нет
        /// </summary>
        public bool InFlight { get; set; } = false;

        public FleetModel(AirplaneModel airplane)
        {
            if(airplane!=null)
                Airplane = airplane;
        }
    }
}
