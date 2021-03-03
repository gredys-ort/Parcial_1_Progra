using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PARCIAL_1_PROGRA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Inicializar();

         }

        private void Inicializar()
        {
            Buton1.Clicked += Buton1_Clicked;
            Buton2.Clicked += Buton2_Clicked;
        }

        private void Buton2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Adivinar_tu_fecha());
        }

        private void Buton1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Adivinar_tu_numero());
        
        }
        
    }
}
