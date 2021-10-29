using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTarea2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngreso_Clicked(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            if(Usuario == "estudiante2021" && clave == "uisrael2021")
            {
                await Navigation.PushAsync(new MainPage(Usuario));
            }
            else
            {
                await DisplayAlert("Advertencia", "Clave o Usuario incorrecto", "OK");
            }
        }
    }
}