using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMain.Model
{
    public class RouteModel
    {

        public Guid uid { get; set; } = Guid.NewGuid();
        public CityModel CityStart { get; set; }
        public CityModel CityEnd { get; set; }
        public int Distance { get; set;}
    }
}
