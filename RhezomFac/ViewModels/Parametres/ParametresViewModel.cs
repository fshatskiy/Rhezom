using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RhezomFac.ViewModels.Parametres
{
    /// <summary>
    /// ViewModel for burger menu expand page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ParametresViewModel : BaseViewModel
    {

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="ParametresViewModel" /> class.
        /// </summary>
        public ParametresViewModel()
        {

            this.ModifDataEntrCommand = new Command(this.ModifDataEntrButtonClicked);
            this.ModifLogoCommand = new Command(this.ModifLogoButtonClicked);
            this.ConditionsCommand = new Command(this.ConditionsButtonClicked);
            this.ChangeMDPCommand = new Command(this.ChangeMDPButtonClicked);
            this.DeconnexionCommand = new Command(this.DeconnexionButtonClicked);
        }


        #endregion

        #region Command
        /// <summary>
        /// Gets or sets the command that is executed when the home view is clicked.
        /// </summary>
        public Command ModifDataEntrCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the interests view is clicked.
        /// </summary>
        public Command ModifLogoCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the bookmark view is clicked.
        /// </summary>
        public Command ConditionsCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the activity view is clicked.
        /// </summary>
        public Command ChangeMDPCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the profile view is clicked.
        /// </summary>
        public Command DeconnexionCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the home button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void ModifDataEntrButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
        }

        /// <summary>
        /// Invoked when the interests button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void ModifLogoButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
        }

        /// <summary>
        /// Invoked when the bookmark button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void ConditionsButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
        }

        /// <summary>
        /// Invoked when the activity button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void ChangeMDPButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
        }

        /// <summary>
        /// Invoked when the profile button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void DeconnexionButtonClicked(object obj)
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
