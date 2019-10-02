using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMain.Model
{
    public class TimeTableModel
    {
        public AirplaneModel Airplane { get; set; }
        public RouteModel Route { get; set; }
        public DateTime Date { get; set; }
    }
}
