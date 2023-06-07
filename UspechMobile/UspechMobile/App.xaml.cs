using Xamarin.Forms;
using System.IO;
using UspechMobile.Data;
using System;

namespace UspechMobile
{
    public partial class App : Application
    {
        static Connection connection;

        public static Connection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new Connection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "UspechDatabase.db3"));
                }
                return connection;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
