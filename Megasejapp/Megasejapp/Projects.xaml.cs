using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Megasejapp
{
    
    public partial class ProjectsPage : ContentPage
    {

        public IList<Project> Projects { get; private set; }
        void OnTapped(object sender, EventArgs e)
        {
            
            Console.WriteLine("tapped");
            
        }

        async void OnSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (Project) e.SelectedItem;
            await Application.Current.MainPage.DisplayAlert(obj.CompanyName, obj.Description, "OK");
            Console.WriteLine("selected");
            
        }

        public ProjectsPage()
        {
            
            InitializeComponent();


            Projects = new List<Project>();
            Projects.Add(new Project
            {
                CompanyName = "Ejner Hessel",
                JobTitle = "Elev",
                Description = "blah blah",
                StartDate = "xx-xx-xxxx",
                EndDate = "xx-xx-xxxx"
            });
            Projects.Add(new Project
            {
                CompanyName = "Nasa",
                JobTitle = "Elev",
                Description = "blah blah",
                StartDate = "xx-xx-xxxx",
                EndDate = "xx-xx-xxxx"
            });

            BindingContext = this;




        }
    }
    
    
}