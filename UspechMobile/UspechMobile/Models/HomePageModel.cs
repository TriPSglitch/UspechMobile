using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using UspechMobile.DBModels;

namespace UspechMobile.Models
{
    internal class HomePageModel : IHomePageModel
    {
        private List<Courses> courseItems;
        private ObservableCollection<Courses> filteredCourses;
        private Categories selectedCategory;
        private string searchText;

        public List<Courses> CourseItems { get => courseItems; set => courseItems = value; }
        public ObservableCollection<Courses> FilteredCourses { get => filteredCourses; set => filteredCourses = value; }
        public Categories SelectedCategory { get => selectedCategory; set => selectedCategory = value; }
        public string SearchText { get => searchText; set => searchText = value; }

        public HomePageModel()
        {
            Task.Run(() => this.GetData()).Wait();
        }

        private async void GetData()
        {
            this.courseItems = await App.Connection.db.Table<Courses>().ToListAsync();
            this.filteredCourses = new ObservableCollection<Courses>(courseItems);
        }

        public async void ApplyFilters()
        {
            ObservableCollection<Courses> filteredCourses = new ObservableCollection<Courses>();

            // Применяем фильтры по категории
            if (SelectedCategory != null)
            {
                List<CourseCategories> courseCategories = await App.Connection.db.Table<CourseCategories>().Where(item => item.IDCategory == SelectedCategory.ID).ToListAsync();

                foreach(CourseCategories course in courseCategories.Distinct())
                {
                    filteredCourses.Add(await App.Connection.db.Table<Courses>().Where(item => item.ID == course.ID).FirstOrDefaultAsync());
                }
            }
            else
            {
                filteredCourses = new ObservableCollection<Courses>(this.CourseItems);
            }

            // Применяем поиск по тексту
            if (!string.IsNullOrEmpty(SearchText))
            {
                filteredCourses = new ObservableCollection<Courses>(filteredCourses.Where(item => item.Title.ToLower().Contains(SearchText.ToLower())).ToList());
            }

            // Обновляем список отфильтрованных курсов
            FilteredCourses = new ObservableCollection<Courses>(filteredCourses);
        }
    }
}