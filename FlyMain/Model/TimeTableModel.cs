using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMain.Model
{
    public class TimeTableModel
    {
        public FlightModel Flight { get; set; }
        public string StatusName { get
            {
                if (Flight.DateStart > DateTime.Now) return "Подготовка к вылету";
                if (Flight.DateEnd < DateTime.Now) return "Вылет завершен";
                return "В полете";
            } }
    }
}
