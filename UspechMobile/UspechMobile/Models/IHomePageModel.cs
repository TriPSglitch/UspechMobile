using System.Collections.Generic;
using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal interface IHomePageModel
    {
        List<Courses> CourseItems { get; set; }
        ObservableCollection<Courses> FilteredCourses { get; set; }
        Categories SelectedCategory { get; set; }
        string SearchText { get; set; }
        void ApplyFilters();
    }
}