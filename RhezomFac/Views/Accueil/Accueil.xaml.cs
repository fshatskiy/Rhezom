using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace RhezomFac.Views.Accueil
{
    /// <summary>
    /// Page to show article master page
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Accueil
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Accueil" /> class.
        /// </summary>
        public Accueil()
        {
            InitializeComponent();
        }
    }
}