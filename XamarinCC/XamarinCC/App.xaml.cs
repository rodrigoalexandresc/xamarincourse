using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCC.Pages;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinCC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
