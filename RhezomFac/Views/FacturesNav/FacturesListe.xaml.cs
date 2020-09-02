using RhezomFac.DataService;
using RhezomFac.Views.CreationFacture;
using System.Diagnostics;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.FacturesNav
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FacturesListe
    {
        public FacturesListe()
        {
            InitializeComponent();
            this.BindingContext = DevisDataService.Instance.NavigationViewModel;
        }

        private void BackButton_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("back button clicked clicked");
            App.Current.MainPage.Navigation.PopAsync();
        }

        private async void CreerFacture_Clicked(object sender, System.EventArgs e)
        {
            Debug.WriteLine("Créer factures clicked");
            await App.Current.MainPage.Navigation.PushAsync(new CreationFactureFormPage());
        }
    }
}