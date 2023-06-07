using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UspechMobile.Models;
using Xamarin.Forms;
using UspechMobile.DBModels;
using System.Threading.Tasks;

namespace UspechMobile.ViewModels
{

    internal class HomePageViewModel : BaseViewModel
    {
        private IHomePageModel HomePageModel;
        public ICommand ApplyFiltersCommand { get; private set; }

        public List<Categories> CategoryItems { get; set; }

        public ObservableCollection<Courses> FilteredCourses
        {
            get
            {
                return HomePageModel.FilteredCourses;
            }
            set
            {
                HomePageModel.FilteredCourses = value;
                NotifyPropertyChanged(nameof(FilteredCourses));
            }
        }

        public Categories SelectedCategory
        {
            get
            {
                return HomePageModel.SelectedCategory;
            }
            set
            {
                HomePageModel.SelectedCategory = value;
                NotifyPropertyChanged(nameof(SelectedCategory));
                OnApplyFilters();
            }
        }

        public string SearchText
        {
            get
            {
                return HomePageModel.SearchText;
            }
            set
            {
                HomePageModel.SearchText = value;
                NotifyPropertyChanged(nameof(SearchText));
                OnApplyFilters();
            }
        }

        public HomePageViewModel()
        {
            ApplyFiltersCommand = new Command(OnApplyFilters);

            HomePageModel = new HomePageModel();

            Task.Run(() => GetData()).Wait();
        }

        private async void GetData()
        {
            this.CategoryItems = await App.Connection.db.Table<Categories>().ToListAsync();
        }

        private void OnApplyFilters()
        {
            HomePageModel.ApplyFilters();
        }
    }
}