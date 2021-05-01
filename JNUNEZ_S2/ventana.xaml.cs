using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JNUNEZ_S2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ventana : ContentPage
    {
        public ventana()
        {
            InitializeComponent();
        }

        private async void btnAbrirVentana_Clicked(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String clave = txtClave.Text;
            if (usuario.Equals("estudiante2021") && clave.Equals("uisrael2021"))
            {
                await Navigation.PushAsync(new MainPage(usuario, clave));
            }
            else
            {
                await DisplayAlert("Alerta", "Clave o usuario incorrectos", "OK");
            }
        }
    }
}