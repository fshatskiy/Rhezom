using RhezomFac.DataService;
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
            this.BindingContext = NavigationDataService.Instance.NavigationViewModel;
        }

        private void BackButton_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("back button clicked clicked");
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}