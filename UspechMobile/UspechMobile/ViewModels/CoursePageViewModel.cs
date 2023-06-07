using System.Collections.ObjectModel;
using UspechMobile.Models;
using UspechMobile.DBModels;

namespace UspechMobile.ViewModels
{
    internal class CoursePageViewModel : BaseViewModel
    {
        private ICoursePageModel CoursePageModel;

        public Courses Course
        {
            get
            {
                return CoursePageModel.Course;
            }
            set
            {
                CoursePageModel.Course = value;
                NotifyPropertyChanged(nameof(Course));
            }
        }

        public string PassPercentage
        {
            get
            {
                return CoursePageModel.PassPercentage;
            }
            set
            {
                CoursePageModel.PassPercentage = value;
                NotifyPropertyChanged(nameof(PassPercentage));
            }
        }

        public ObservableCollection<Lectures> LectureItems
        {
            get
            {
                return CoursePageModel.LectureItems;
            }
            set
            {
                CoursePageModel.LectureItems = value;
                NotifyPropertyChanged(nameof(LectureItems));
            }
        }

        public ObservableCollection<Tests> TestItems
        {
            get
            {
                return CoursePageModel.TestItems;
            }
            set
            {
                CoursePageModel.TestItems = value;
                NotifyPropertyChanged(nameof(TestItems));
            }
        }

        public ObservableCollection<Exercises> ExerciseItems
        {
            get
            {
                return CoursePageModel.ExerciseItems;
            }
            set
            {
                CoursePageModel.ExerciseItems = value;
                NotifyPropertyChanged(nameof(ExerciseItems));
            }
        }

        public CoursePageViewModel(Courses course)
        {
            CoursePageModel = new CoursePageModel(Course);
        }
    }
}