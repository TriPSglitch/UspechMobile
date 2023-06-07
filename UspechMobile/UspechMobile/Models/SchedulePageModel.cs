using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal class SchedulePageModel : ISchedulePageModel
    {
        private ObservableCollection<Schedule> scheduleItems;
        public ObservableCollection<Schedule> ScheduleItems { get => scheduleItems; set => scheduleItems = value; }

        public SchedulePageModel()
        {
            Task.Run(() => this.GetData()).Wait();
        }

        private async void GetData()
        {
            List<Courses> CourseItems = new List<Courses>();

            List<UserCourses> userCourses = await App.Connection.db.Table<UserCourses>().Where(item => item.IDUser == User.IDUser).ToListAsync();

            foreach (UserCourses course in userCourses)
            {
                CourseItems.Add(await App.Connection.db.Table<Courses>().Where(item => item.ID == course.IDCourse).FirstOrDefaultAsync());
            }

            ScheduleItems = new ObservableCollection<Schedule>();

            foreach (UserCourses course in userCourses)
            {
                List<Schedule> courseSchedule = await App.Connection.db.Table<Schedule>().Where(item => item.IDCourse == course.ID).ToListAsync();

                ScheduleItems.Concat(courseSchedule);
            }

            ScheduleItems = new ObservableCollection<Schedule>(ScheduleItems.OrderBy(item => item.Date));
        }
    }
}