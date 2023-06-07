using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal class MyCoursesPageModel : IMyCoursesPageModel
    {
        private ObservableCollection<Courses> courseItems;

        public ObservableCollection<Courses> CourseItems { get => courseItems; set => courseItems = value; }

        public MyCoursesPageModel()
        {
            Task.Run(() => this.GetData()).Wait();
        }

        private async void GetData()
        {
            CourseItems = new ObservableCollection<Courses>();

            List<UserCourses> userCourses = await App.Connection.db.Table<UserCourses>().Where(item => item.IDUser == User.IDUser).ToListAsync();

            foreach(UserCourses course in userCourses)
            {
                CourseItems.Add(await App.Connection.db.Table<Courses>().Where(item => item.ID == course.IDCourse).FirstOrDefaultAsync());
            }
        }
    }
}