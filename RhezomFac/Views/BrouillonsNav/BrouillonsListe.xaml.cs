using RhezomFac.DataService;
using System.Diagnostics;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.BrouillonsNav
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrouillonsListe
    {
        public BrouillonsListe()
        {
            InitializeComponent();
            this.BindingContext = DevisDataService.Instance.NavigationViewModel;
        }

        private void BackButton_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("back button clicked clicked");
            App.Current.MainPage.Navigation.PopAsync();
        }

        //private async void CreerBrouillon_Clicked(object sender, System.EventArgs e)
        //{
        //    Debug.WriteLine("Créer brouillon clicked");
        //    await App.Current.MainPage.Navigation.PushAsync(new CreationBrouillonFormPage());
        //}
    }
}