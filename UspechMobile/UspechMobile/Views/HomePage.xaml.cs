using Xamarin.Forms;
using UspechMobile.ViewModels;
using UspechMobile.DBModels;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace UspechMobile.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            //this.BindingContext = new HomePageViewModel();

            Courses course1 = new Courses();
            course1.ID = 1;
            course1.Title = "Математика";
            course1.Description = "Математика 11 класс";
            Categories category1 = new Categories();
            category1.ID = 1;
            category1.Title = "Точные науки";
            CourseCategories courseCategories1 = new CourseCategories();
            courseCategories1.ID = 1;
            courseCategories1.IDCourse = 1;
            courseCategories1.IDCategory = 1;

            Courses course2 = new Courses();
            course2.ID = 2;
            course2.Title = "Русский язык";
            course2.Description = "Русский язык 11 класс";
            Categories category2 = new Categories();
            category2.ID = 2;
            category2.Title = "Гуманитарные науки";
            CourseCategories courseCategories2 = new CourseCategories();
            courseCategories2.ID = 2;
            courseCategories2.IDCourse = 2;
            courseCategories2.IDCategory = 2;

            Courses course3 = new Courses();
            course3.ID = 3;
            course3.Title = "Обществознание";
            course3.Description = "Обществознание 9 класс";
            CourseCategories courseCategories3 = new CourseCategories();
            courseCategories3.ID = 3;
            courseCategories3.IDCourse = 3;
            courseCategories3.IDCategory = 2;

            Categories category3 = new Categories();
            category3.ID = 3;
            category3.Title = "11 класс";
            CourseCategories courseCategories4 = new CourseCategories();
            courseCategories4.ID = 4;
            courseCategories4.IDCourse = 1;
            courseCategories4.IDCategory = 3;
            CourseCategories courseCategories5 = new CourseCategories();
            courseCategories5.ID = 5;
            courseCategories5.IDCourse = 2;
            courseCategories5.IDCategory = 3;

            Categories category4 = new Categories();
            category4.ID = 4;
            category4.Title = "9 класс";
            CourseCategories courseCategories6 = new CourseCategories();
            courseCategories6.ID = 6;
            courseCategories6.IDCourse = 3;
            courseCategories6.IDCategory = 4;

            course1.CourseCategories.Add(courseCategories1);
            course1.CourseCategories.Add(courseCategories4);
            category1.CourseCategories.Add(courseCategories1);
            category3.CourseCategories.Add(courseCategories4);

            course2.CourseCategories.Add(courseCategories2);
            course2.CourseCategories.Add(courseCategories5);
            category2.CourseCategories.Add(courseCategories2);
            category3.CourseCategories.Add(courseCategories5);

            course3.CourseCategories.Add(courseCategories3);
            course3.CourseCategories.Add(courseCategories6);
            category2.CourseCategories.Add(courseCategories3);
            category4.CourseCategories.Add(courseCategories6);

            App.Connection.db.InsertAsync(course1);
            App.Connection.db.InsertAsync(category1);
            App.Connection.db.InsertAsync(course2);
            App.Connection.db.InsertAsync(category2);
            App.Connection.db.InsertAsync(course3);
            App.Connection.db.InsertAsync(category3);
            App.Connection.db.InsertAsync(category4);
            App.Connection.db.InsertAsync(courseCategories1);
            App.Connection.db.InsertAsync(courseCategories2);
            App.Connection.db.InsertAsync(courseCategories3);
            App.Connection.db.InsertAsync(courseCategories4);
            App.Connection.db.InsertAsync(courseCategories5);
            App.Connection.db.InsertAsync(courseCategories6);

            Task.Run(() => GetData()).Wait();
        }
        private async void GetData()
        {
            //CategoryPicker.ItemsSource = await App.Connection.db.Table<Categories>().ToListAsync();

            //this.CategoryItems = await App.Connection.db.Table<Categories>().ToListAsync();

            //this.courseItems = await App.Connection.db.Table<Courses>().ToListAsync();
            //this.FilteredCourses = new ObservableCollection<Courses>(courseItems);
        }
    }
}