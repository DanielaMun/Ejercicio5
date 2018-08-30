using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
		}

        private async void btntres_Clicked(object sender, EventArgs e)
        {
            this.lbOpcion.Text = string.Empty;
            await Navigation.PushAsync(new Page3());
        }

        private  async void btnTest_Clicked(object sender, EventArgs e)
        {
            this.lbOpcion.Text = string.Empty;
            var resp = await DisplayAlert("Test", "Estas seguro de realizar el test", "Si", "No");
            if (resp)
            {
                await DisplayAlert("Inicio de test", "Super Bienvenido", "Aceptar");
                var opcion = await DisplayActionSheet("Opciones", "cancelar",null,"opcion1","opcion2","opcion3");
                lbOpcion.Text = opcion.ToString();
            }
            else
            {
                await DisplayAlert("Test Fallido", "En otra ocasion sera", "Aceptar");
            }
        }
    }
}
