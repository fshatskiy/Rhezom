using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.DonneesEntreprise
{
    /// <summary>
    /// Page to show article master page
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DonneesEntreprisePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DonneesEntreprisePage" /> class.
        /// </summary>
        public DonneesEntreprisePage()
        {
            InitializeComponent();
        }

        private void BackButton_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("back button clicked clicked");
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}