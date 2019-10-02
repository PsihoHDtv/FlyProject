using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyMain.Data;

namespace FlyMain.ViewModel
{
   public class FleetViewModel
    {
        private DataModel Data { get; set; }

        public FleetViewModel(DataModel data)
        {
            Data = data;
        }
    }
}
