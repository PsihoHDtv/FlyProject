using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMain.Model
{
    public class AirplaneModel
    {
        public Guid uid { get; set; } = Guid.NewGuid();
        /// <summary>
        /// Название самолета
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Расход топлива
        /// </summary>
        public int FuelConsumption { get; set; }
        /// <summary>
        /// Текущий город
        /// </summary>
        public CityModel CurrentCity { get; set; }
        /// <summary>
        /// Максимальная дальность полета
        /// </summary>
        public int MaxDistance { get; set; }
        /// <summary>
        /// Тип самолета
        /// </summary>
        public int AirplaneType { get; set; }
        /// <summary>
        /// Вместимость самолета
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Стоимость самолета
        /// </summary>
        public int Price { get; set; }

        public string CityName { get { if (CurrentCity != null) return CurrentCity.Name; return ""; } }
        public string AirpTypeName { get { if (AirplaneType == 0) return "Грузовой";return "Пасажирский"; } }

    }
}
