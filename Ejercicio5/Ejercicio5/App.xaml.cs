using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Ejercicio5
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            //var navigationpage = new NavigationPage(new Navegacion());
            //navigationpage.BackgroundColor = Color.Chartreuse;
            //navigationpage.BarTextColor = Color.White;
            //MainPage = navigationpage;



            //MainPage = new NavigationPage(new Navegacion() );
            MainPage = new DemoCarouse();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
