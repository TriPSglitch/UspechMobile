using System.Collections.ObjectModel;
using UspechMobile.Models;
using UspechMobile.DBModels;

namespace UspechMobile.ViewModels
{
    internal class SchedulePageViewModel : BaseViewModel
    {
        private ISchedulePageModel SchedulePageModel;

        public ObservableCollection<Schedule> scheduleItems;

        public ObservableCollection<Schedule> ScheduleItems
        {
            get
            {
                return SchedulePageModel.ScheduleItems;
            }
            set
            {
                SchedulePageModel.ScheduleItems = value;
                NotifyPropertyChanged(nameof(ScheduleItems));
            }
        }

        public SchedulePageViewModel()
        {
            SchedulePageModel = new SchedulePageModel();
        }
    }
}