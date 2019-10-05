using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyMain.Model
{
   public class CityModel
    {
        public Guid uid { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "";
    }
}
