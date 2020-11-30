using RhezomFac.Views.Login;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.Accueil
{
    /// <summary>
    /// Page to show article master page
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccueilPage
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AccueilPage" /> class.
        /// </summary>
        public AccueilPage()
        {
            InitializeComponent();
        }


        //}        protected async override bool OnBackButtonPressed()
        //    {
        //        bool answer = await DisplayAlert("Déconnexion", "Voulez-vous vraiment vous déconnecter ?", "Oui", "Non");
        //        System.Diagnostics.Debug.WriteLine("Answer: " + answer);
        //        if (answer)
        //            await App.Current.MainPage.Navigation.PushAsync(new SimpleLoginPage());
        //    }
        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var exit = await this.DisplayAlert("Quitter l'application", "Voulez-vous réellement quitter l'application ?", "Oui", "Non").ConfigureAwait(false);
                if(exit)
                    System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
                return;
            });
            return true;
        }
    }
}