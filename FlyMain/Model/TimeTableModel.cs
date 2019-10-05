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
        public string StatusName
        {
            get
            {
                if (Status == 0) return "Подготовка";
                if (Status == 1) return "Выполняется";
                if (Status == 2) return "Завершен";
                return "Отменен";
            }
        }

        public int Status { get; set; }
    }
}
