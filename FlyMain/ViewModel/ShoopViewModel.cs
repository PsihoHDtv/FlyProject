using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyMain.Data;

namespace FlyMain.ViewModel
{
   public class ShoopViewModel
    {
        private DataModel Data { get; set; }

        public ShoopViewModel(DataModel data)
        {
            Data = data;
        }
    }
}
