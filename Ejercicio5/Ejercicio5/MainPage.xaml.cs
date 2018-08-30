using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio5
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btn1_Clicked(object sender, EventArgs e)
        {
            panel.Children.Add(new Button()
            {
                Text=$"Boton{ panel.Children.Count + 1 }"
            });
        }
    }
}
