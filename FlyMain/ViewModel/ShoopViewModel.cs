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
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using FlyMain.Data;
using FlyMain.Model;
namespace FlyMain.ViewModel
{
   public class ShoopViewModel : ISupportParentViewModel
    {
        public object ParentViewModel { get; set; }
        public DataModel Data { get; set; }

        public ObservableCollection<AirplaneModel> AirplaneList { get; set; }
        public ShoopViewModel(DataModel data)
        {
            Data = data;
            AirplaneList = Data.AirplaneList;
        }
        public ShoopViewModel()
        {
        }
        internal static ShoopViewModel Create()
        {
            return ViewModelSource.Create(() => new ShoopViewModel());
        }
        internal static ShoopViewModel Create(DataModel data)
        {
            return ViewModelSource.Create(() => new ShoopViewModel(data));
        }
        /// <summary>
        /// Метод покупки самолета и добавления в ангар
        /// </summary>
        /// <param name="uid"></param>
        public bool ByAirplane(Guid uid)
        {
            FleetModel fleet = new FleetModel(Data.AirplaneList.Where(x => x.uid == uid).FirstOrDefault());
            if (fleet.Airplane != null && Data.Ballance > fleet.Airplane.Price)
            {
                Data.Ballance = Data.Ballance - fleet.Airplane.Price;
                Data.FleetList.Add(fleet);
                return true;
            }
            return false;
        }

    }
}
