using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal interface ISchedulePageModel
    {
        ObservableCollection<Schedule> ScheduleItems { get; set; }
    }
}