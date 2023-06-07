using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal class CoursePageModel : ICoursePageModel
    {
        private Courses course;
        private string passPercentage;
        private ObservableCollection<Lectures> lectureItems;
        private ObservableCollection<Tests> testItems;
        private ObservableCollection<Exercises> exerciseItems;

        public Courses Course { get => course; set => course = value; }
        public string PassPercentage { get => passPercentage; set => passPercentage = value; }
        public ObservableCollection<Lectures> LectureItems { get => lectureItems; set => lectureItems = value; }
        public ObservableCollection<Tests> TestItems { get => testItems; set => testItems = value; }
        public ObservableCollection<Exercises> ExerciseItems { get => exerciseItems; set => exerciseItems = value; }

        public CoursePageModel(Courses course)
        {
            this.Course = course;

            Task.Run(() => this.GetData()).Wait();
        }

        private async void GetData()
        {
            LectureItems = new ObservableCollection<Lectures>(await App.Connection.db.Table<Lectures>().Where(item => item.IDCourse == this.Course.ID).ToListAsync());
            TestItems = new ObservableCollection<Tests>(await App.Connection.db.Table<Tests>().Where(item => item.IDCourse == this.Course.ID).ToListAsync());
            ExerciseItems = new ObservableCollection<Exercises>(await App.Connection.db.Table<Exercises>().Where(item => item.IDCourse == this.Course.ID).ToListAsync());
            passPercentage = GetPassPercentage();

        }

        private string GetPassPercentage()
        {
            int countElementsOfCourse = this.LectureItems.Count + this.TestItems.Count + this.ExerciseItems.Count;

            int passedElementsOfCourse = this.LectureItems.Count(item => item.IsPassed) + this.TestItems.Count(item => item.IsPassed) + this.ExerciseItems.Count(item => item.IsPassed);

            return 100 / (countElementsOfCourse / passedElementsOfCourse) + "%";
        }
    }
}