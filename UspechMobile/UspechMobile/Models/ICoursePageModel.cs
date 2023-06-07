using System.Collections.ObjectModel;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal interface ICoursePageModel
    {
        Courses Course { get; set; }
        string PassPercentage { get; set; }
        ObservableCollection<Lectures> LectureItems { get; set; }
        ObservableCollection<Tests> TestItems { get; set; }
        ObservableCollection<Exercises> ExerciseItems { get; set; }
    }
}