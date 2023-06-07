using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal interface IMyCoursesPageModel
    {
        ObservableCollection<Courses> CourseItems { get; set; }
    }
}