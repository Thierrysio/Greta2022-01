using Greta202201.Modeles;
using Greta202201.VuesModeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Greta202201.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VuesCombats : ContentPage
    {
        VuesModelesCombats VuesModele;
        public VuesCombats()
        {
            InitializeComponent();
            //creation de la liaison entre la vue et le VueModele
            BindingContext = VuesModele = new VuesModelesCombats();

            Personnage PA = new Personnage("Hello World", "Revolver", 80, 70);

            Resultat.Text = VuesModele.CasserLeMur(PA);


        }
    }
}