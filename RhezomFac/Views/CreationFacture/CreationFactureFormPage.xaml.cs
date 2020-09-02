using RhezomFac.Views.FacturesNav;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.CreationFacture
{
    /// <summary>
    /// Page to add business details such as name, email address, and phone number.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreationFactureFormPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreationFactureFormPage" /> class.
        /// </summary>
        public CreationFactureFormPage()
        {
            InitializeComponent();
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