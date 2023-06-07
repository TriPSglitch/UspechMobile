using System.Collections.ObjectModel;
using UspechMobile.Models;
using UspechMobile.DBModels;
using UspechMobile.Views;

namespace UspechMobile.ViewModels
{
    internal class MyCoursesPageViewModel : BaseViewModel
    {
        private IMyCoursesPageModel MyCoursesPageModel;

        public ObservableCollection<Courses> CourseItems
        {
            get
            {
                return MyCoursesPageModel.CourseItems;
            }
            set
            {
                MyCoursesPageModel.CourseItems = value;
                NotifyPropertyChanged(nameof(CourseItems));
           
            }
        }

        private Courses SelectedCourse { get; set; }
        private void SendData()
        {
            CoursePage coursePage = new CoursePage(SelectedCourse);
        }

        public MyCoursesPageViewModel()
        {
            MyCoursesPageModel = new MyCoursesPageModel();
        }
    }
}