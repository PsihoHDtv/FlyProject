using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using FlyMain.Data;
using FlyMain.Model;
namespace FlyMain.ViewModel
{
   public class FleetViewModel : ISupportParentViewModel
    {
        public object ParentViewModel { get; set; }
        private DataModel Data { get; set; }

        public FleetViewModel(DataModel data)
        {
            Data = data;
        }
        public FleetViewModel()
        {
        }
        internal static FleetViewModel Create()
        {
            return ViewModelSource.Create(() => new FleetViewModel());
        }
        internal static FleetViewModel Create(DataModel data)
        {
            return ViewModelSource.Create(() => new FleetViewModel(data));
        }
        public ObservableCollection<FleetModel> FleetList { get; set; } = new ObservableCollection<FleetModel>();
        public void Reload(DataModel Data)
        {
            FleetList.Clear();
            foreach (FleetModel item in Data.FleetList)
                FleetList.Add(item);
        }
    }
}
