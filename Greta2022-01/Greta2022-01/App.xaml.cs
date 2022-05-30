using Greta202201.Vues;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Greta2022_01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VuesCombats();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
