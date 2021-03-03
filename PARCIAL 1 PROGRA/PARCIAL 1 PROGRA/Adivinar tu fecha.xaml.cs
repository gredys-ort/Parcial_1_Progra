using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PARCIAL_1_PROGRA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Adivinar_tu_fecha : ContentPage
    {
        public Adivinar_tu_fecha()
        {
            InitializeComponent();

            inicializar();
           
        }

        private void inicializar()
        {
            Buton5.Clicked += Buton5_Clicked;
        }

        private void Buton5_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resultado_de_adivinar_tu_fecha());
        }
    }
}