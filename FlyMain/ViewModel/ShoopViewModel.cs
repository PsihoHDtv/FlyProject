using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FlyMain.Data;
using FlyMain.Model;
namespace FlyMain.ViewModel
{
   public class ShoopViewModel
    {
        private DataModel Data { get; set; }

        public ShoopViewModel(DataModel data)
        {
            Data = data;
        }

        /// <summary>
        /// Метод покупки самолета и добавления в ангар
        /// </summary>
        /// <param name="uid"></param>
        public void ByAirplane(Guid uid)
        {
            FleetModel fleet = new FleetModel(Data.AirplaneList.Where(x => x.uid == uid).FirstOrDefault());
            if (fleet.Airplane != null && Data.Ballance > fleet.Airplane.Price)
            {
                Data.Ballance = Data.Ballance - fleet.Airplane.Price;
                Data.FleetList.Add(fleet);
            }
        }

    }
}
