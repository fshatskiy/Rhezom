using RhezomFac.Views.ProfilEntreprise;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RhezomFac.ViewModels.DonneesEntreprise
{
    /// <summary>
    /// ViewModel for burger menu expand page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class DonneesEntrepriseViewModel : BaseViewModel
    {
        #region Fields

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="DonneesEntrepriseViewModel" /> class.
        /// </summary>
        public DonneesEntrepriseViewModel()
        {

            this.ProfilEntrCommand = new Command(this.ProfilEntrClicked);
            this.ProduitsCommand = new Command(this.ProduitsButtonClicked);
        }

        #endregion

        #region Command
        /// <summary>
        /// Gets or sets the command that is executed when the Profil de l'entreprise view is clicked.
        /// </summary>
        public Command ProfilEntrCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Produits view is clicked.
        /// </summary>
        public Command ProduitsCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Profil de l'entreprise button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void ProfilEntrClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
            Debug.WriteLine("Factures clicked");
            await App.Current.MainPage.Navigation.PushAsync(new ProfilEntrepriseFormPage());
        }

        /// <summary>
        /// Invoked when the Produits button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void ProduitsButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
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
