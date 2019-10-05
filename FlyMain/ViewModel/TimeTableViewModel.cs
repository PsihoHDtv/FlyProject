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
   public class TimeTableViewModel : ISupportParentViewModel
    {
        public object ParentViewModel { get; set; }
        private DataModel Data { get; set; }

        public TimeTableViewModel(DataModel data)
        {
            Data = data;
        }
        public TimeTableViewModel()
        {
        }
        internal static TimeTableViewModel Create()
        {
            return ViewModelSource.Create(() => new TimeTableViewModel());
        }
        internal static TimeTableViewModel Create(DataModel data)
        {
            return ViewModelSource.Create(() => new TimeTableViewModel(data));
        }
        public ObservableCollection<TimeTableModel> TimeTableList { get; set; } = new ObservableCollection<TimeTableModel>();
        public void Reload(DataModel data)
        {
            TimeTableList.Clear();
            foreach (TimeTableModel item in Data.TimeTableList)
                TimeTableList.Add(item);
        }

        /// <summary>
        /// Метод отмены запланированного рейса
        /// </summary>
        /// <param name="uid"></param>
        public bool CancelFlight(Guid uid)
        {
            TimeTableModel flight = Data.TimeTableList.Where(x => x.Flight.uid == uid).FirstOrDefault();
            if (flight != null && flight.Status == 0)
            {
                Data.Ballance -= flight.Flight.Forfeit;
                flight.Status = 3;
                Reload(Data);
                return true;
            }
            return false;
        }
    }
}
