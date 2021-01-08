using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Megasejapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new About());
            tabbedPage.Children.Add(new ProjectsPage());
            tabbedPage.Children.Add(new Contact());

            MainPage = new TabbedPage();
            MainPage = tabbedPage;
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
