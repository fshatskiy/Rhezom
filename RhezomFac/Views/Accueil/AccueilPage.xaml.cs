using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.Accueil
{
    /// <summary>
    /// Page to show article master page
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccueilPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccueilPage" /> class.
        /// </summary>
        public AccueilPage()
        {
            InitializeComponent();
        }
    }
}