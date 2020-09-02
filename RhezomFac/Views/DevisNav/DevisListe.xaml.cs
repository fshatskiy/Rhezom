using RhezomFac.DataService;
using RhezomFac.Views.CreationDevis;
using System.Diagnostics;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.DevisNav
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DevisListe
    {
        public DevisListe()
        {
            InitializeComponent();
            this.BindingContext = DevisDataService.Instance.NavigationViewModel;
        }

        private void BackButton_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("back button clicked clicked");
            App.Current.MainPage.Navigation.PopAsync();
        }

        private async void CreerDevis_Clicked(object sender, System.EventArgs e)
        {
            Debug.WriteLine("Créer devis clicked");
            await App.Current.MainPage.Navigation.PushAsync(new CreationDevisFormPage());
        }
    }
}