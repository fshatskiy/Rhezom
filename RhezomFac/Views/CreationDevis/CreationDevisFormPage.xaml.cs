using RhezomFac.Views.DevisNav;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.CreationDevis
{
    /// <summary>
    /// Page to add business details such as name, email address, and phone number.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreationDevisFormPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessRegiCreationDevisFormPagestrationFormPage" /> class.
        /// </summary>
        public CreationDevisFormPage()
        {
            InitializeComponent();
        }

        private void EnregistreDansBrouillon_Clicked(object sender, System.EventArgs e)
        {

        }

        private async void Annuler_Clicked(object sender, System.EventArgs e)
        {
            bool answer = await DisplayAlert("Annuler", "Êtes-vous sûr d'annuler la création ? Les données renseignées seront perdues.", "Oui", "Non");
            System.Diagnostics.Debug.WriteLine("Answer: " + answer);
            if (answer)
                await App.Current.MainPage.Navigation.PopAsync();
            return;
        }
    }
}