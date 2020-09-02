using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.ProfilEntreprise
{
    /// <summary>
    /// Page to add business details such as name, email address, and phone number.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilEntrepriseFormPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilEntrepriseFormPage" /> class.
        /// </summary>
        public ProfilEntrepriseFormPage()
        {
            InitializeComponent();
        }
    }
}