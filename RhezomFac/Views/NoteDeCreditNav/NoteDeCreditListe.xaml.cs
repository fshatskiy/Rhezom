using RhezomFac.DataService;
using System.Diagnostics;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.NoteDeCreditNav
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteDeCreditListe
    {
        public NoteDeCreditListe()
        {
            InitializeComponent();
            this.BindingContext = NavigationDataService.Instance.NavigationViewModel;
        }

        private async void NoteDeCredit_Clicked(object sender, System.EventArgs e)
        {
            Debug.WriteLine("Créer factures clicked");
            //await App.Current.MainPage.Navigation.PushAsync(new CreationFactureFormPage());
        }
    }
}