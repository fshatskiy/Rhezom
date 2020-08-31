using RhezomFac.Views.PageConditions;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RhezomFac.ViewModels.ConditionsGenerales
{
    /// <summary>
    /// ViewModel for burger menu expand page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ConditionsViewModel : BaseViewModel
    {

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="ConditionsViewModel" /> class.
        /// </summary>
        public ConditionsViewModel()
        {

            this.CondGenCommand = new Command(this.CondGenClicked);
            this.EffacerDonneesCommand = new Command(this.EffacerDonneesButtonClicked);
            //this.BookmarkCommand = new Command(this.BookmarkButtonClicked);
            //this.ActivityCommand = new Command(this.ActivityButtonClicked);
            //this.ProfileCommand = new Command(this.ProfileButtonClicked);
        }

        #endregion

        #region Command
        /// <summary>
        /// Gets or sets the command that is executed when the home view is clicked.
        /// </summary>
        public Command CondGenCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the interests view is clicked.
        /// </summary>
        public Command EffacerDonneesCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the bookmark view is clicked.
        /// </summary>
        //public Command BookmarkCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the activity view is clicked.
        /// </summary>
        //public Command ActivityCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the profile view is clicked.
        /// </summary>
        //public Command ProfileCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the home button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void CondGenClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
            Debug.WriteLine("Conditions générales d'utilisation clicked");
            await App.Current.MainPage.Navigation.PushAsync(new PageConditionsPage());
        }

        /// <summary>
        /// Invoked when the EffacerDonnees button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void EffacerDonneesButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
            Debug.WriteLine("Effacer données clicked");

            var exit = await App.Current.MainPage.DisplayAlert("Attention !", "Êtes-vous sûr de vouloir effacer vos données personnelles ?\n" +
                "Après l'effacement, le propriétaire du logiciel RhezomFac aura le droit de garder vos données pendant une période \n" +
                "de maximum 5 ans afin de garantir la preuve d'achat de l'application.", "Oui", "Non").ConfigureAwait(false);
            if(exit)
                Debug.WriteLine("On lance la méthode d'effacement des données (attente de 5 ans àpd cette date)");
            return;

        }

        /// <summary>
        /// Invoked when the bookmark button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        //private void BookmarkButtonClicked(object obj)
        //{
        //    this.UpdateSelectedItemColor(obj);
        //}

        /// <summary>
        /// Invoked when the activity button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        //private void ActivityButtonClicked(object obj)
        //{
        //    this.UpdateSelectedItemColor(obj);
        //}

        /// <summary>
        /// Invoked when the profile button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        //private void ProfileButtonClicked(object obj)
        //{
        //    this.UpdateSelectedItemColor(obj);
        //}

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
