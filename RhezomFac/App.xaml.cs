using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RhezomFac.Services;
using RhezomFac.Views;
using System.Diagnostics;
using RhezomFac.Views.Login;
using RhezomFac.Views.Accueil;
using RhezomFac.Views.Parametres;
using RhezomFac.Views.DonneesEntreprise;

namespace RhezomFac
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";

        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk4NjY3QDMxMzgyZTMyMmUzMGRRWXBhU0ZOWWwzb3FvUFJmRFBTRVdQaUprODhxNUtIampXWUlKN3lyWFk9;Mjk4NjY4QDMxMzgyZTMyMmUzMEJ0ZTZJOTJtY2N1Z2w2MGEvTEVFWnNocjJRZVk0UnIyRUpPVDkyTkJWZE09");

            InitializeComponent();

            //Page racine de l'application
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new SimpleLoginPage());
        }

        /// <summary>
        /// Lorsque l'app d�bute.
        /// </summary>
        protected override void OnStart()
        {
            Debug.WriteLine("OnStart");
        }

        /// <summary>
        /// Lorsque l'application entre en veille
        /// </summary>
        protected override void OnSleep()
        {
            Debug.WriteLine("OnSleep");
        }

        /// <summary>
        /// Lorsque l'app sort de la veille.
        /// </summary>
        protected override void OnResume()
        {
            Debug.WriteLine("OnResume");
        }
    }
}
