using RhezomFac.Views.Login;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.Parametres
{
    /// <summary>
    /// Page to show article master page
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParametresPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParametresPage" /> class.
        /// </summary>
        public ParametresPage()
        {
            InitializeComponent();
        }

        private void ClickToShowPopup_Clicked(object sender, System.EventArgs e)
        {
            //popupLayout.Show();
        }

        private async void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            bool answer = await DisplayAlert("Déconnexion", "Voulez-vous vraiment vous déconnecter ?", "Oui", "Non");
            System.Diagnostics.Debug.WriteLine("Answer: " + answer);
            if(answer)
                await App.Current.MainPage.Navigation.PushAsync(new SimpleLoginPage());
        }
    }
}