using RhezomFac.Views.AboutUs;
using RhezomFac.Views.DonneesEntreprise;
using RhezomFac.Views.Parametres;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RhezomFac.ViewModels.Accueil
{
    /// <summary>
    /// ViewModel for burger menu expand page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class AccueilViewModel : BaseViewModel
    {
        #region Fields

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="AccueilViewModel" /> class.
        /// </summary>
        public AccueilViewModel()
        {
            //this.profileName = "John Doe";
            //this.profileImage = App.BaseImageUrl + "ProfileImage1.png";
            //this.email = "johndoe@gmail.com";

            this.DevisCommand = new Command(this.DevisButtonClicked);
            this.FacturesCommand = new Command(this.FacturesButtonClicked);
            this.BrouillonsCommand = new Command(this.BrouillonsButtonClicked);
            this.ParamCommand = new Command(this.ParamButtonClicked);
            this.EntrDataCommand = new Command(this.EntrDataButtonClicked);
            this.AboutUsCommand = new Command(this.AboutUsButtonClicked);
        }

        #endregion

        #region Public properties


        #endregion

        #region Command
        /// <summary>
        /// Gets or sets the command that is executed when the home view is clicked.
        /// </summary>
        public Command DevisCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the interests view is clicked.
        /// </summary>
        public Command FacturesCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the bookmark view is clicked.
        /// </summary>
        public Command BrouillonsCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the activity view is clicked.
        /// </summary>
        public Command ParamCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the profile view is clicked.
        /// </summary>
        public Command EntrDataCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the AboutUs view is clicked.
        /// </summary>
        public Command AboutUsCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Devis button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void DevisButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
        }

        /// <summary>
        /// Invoked when the Factures button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void FacturesButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
        }

        /// <summary>
        /// Invoked when the Brouillons button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void BrouillonsButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
        }

        /// <summary>
        /// Invoked when the Paramètres button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void ParamButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
            Debug.WriteLine("Paramètres clicked");
            await App.Current.MainPage.Navigation.PushAsync(new ParametresPage());
        }

        /// <summary>
        /// Invoked when the Données de l'entreprise button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void EntrDataButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
            Debug.WriteLine("Données de l'entreprise clicked");
            await App.Current.MainPage.Navigation.PushAsync(new DonneesEntreprisePage());
        }

        /// <summary>
        /// Invoked when the A propos de nous button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void AboutUsButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
            Debug.WriteLine("A propos de nous clicked");
            await App.Current.MainPage.Navigation.PushAsync(new AboutUsSimplePage());
        }

        /// <summary>
        /// Changes the selection color when an item is tapped.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void UpdateSelectedItemColor(object obj)
        {
            var grid = obj as Grid;
            Application.Current.Resources.TryGetValue("Gray-100", out var retVal);
            grid.BackgroundColor = (Color)retVal;

            // Makes the selected item color change for 100 milliseconds.
            await Task.Delay(100);
            Application.Current.Resources.TryGetValue("Gray-White", out var retValue);
            grid.BackgroundColor = (Color)retValue;
        }

        #endregion
    }
}
