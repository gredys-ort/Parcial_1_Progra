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
    public partial class Resultado_de_adivinar_tu_numero : ContentPage
    {
        public Resultado_de_adivinar_tu_numero()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            Buton4.Clicked += Buton4_Clicked;
        }

        private void Buton4_Clicked(object sender, EventArgs e)
        {
            var enter = gr.Text;
            var largo = enter.Length;
            var nuevo = enter.Substring(0, largo - 1);
            var convert = Convert.ToInt32(nuevo);
            var fin = convert - 4;
            Resul.Text = fin.ToString();
        }

      
    }
}