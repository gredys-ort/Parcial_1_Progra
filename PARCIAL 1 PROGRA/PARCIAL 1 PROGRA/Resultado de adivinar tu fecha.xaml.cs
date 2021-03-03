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
    public partial class Resultado_de_adivinar_tu_fecha : ContentPage
    {
        public Resultado_de_adivinar_tu_fecha()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            Buton6.Clicked += Buton6_Clicked;
        }

        private void Buton6_Clicked(object sender, EventArgs e)
        {
            var par = el.Text;
            var per = Convert.ToInt64(par);
            var por = per - 365;
            var pir = Convert.ToString(por);
            var ar = pir.Length;
            if (ar != 4)
            {
                var er = pir.Substring(0, ar - 2);
                var or = pir.Substring(ar - 2);
                var ir = Convert.ToDouble(er);
                var ur = Convert.ToDouble(or);
                var fin = ir + "/" + ur;
                Resul2.Text = fin.ToString();
            }
            else
            {
                var fg = pir.Substring(0, ar - 2);
                var lp = pir.Substring(ar - 2);
                var kj = Convert.ToInt32(fg);
                var mn= Convert.ToInt32(lp);
                var fin = kj + "/" + mn;
                Resul2.Text = fin.ToString();
            }
        }
    }
}