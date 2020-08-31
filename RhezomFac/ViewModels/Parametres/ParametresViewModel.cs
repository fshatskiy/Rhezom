using RhezomFac.Views.ConditionsGenerales;
using RhezomFac.Views.Login;
using System.ComponentModel;
using System.Diagnostics;
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
            this.ConditionsCommand = new Command(this.ConditionsButtonClicked);
            this.ChangeMDPCommand = new Command(this.ChangeMDPButtonClicked);
            this.DeconnexionCommand = new Command(this.DeconnexionButtonClicked);
        }


        #endregion

        #region Command

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
        /// Invoked when the bookmark button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void ConditionsButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
            Debug.WriteLine("Conditions clicked");
            await App.Current.MainPage.Navigation.PushAsync(new ConditionsPage()); //pas PageConditionsPage
        }

        /// <summary>
        /// Invoked when the activity button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void ChangeMDPButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
            Debug.WriteLine("Conditions clicked");
            await App.Current.MainPage.Navigation.PushAsync(new SimpleResetPasswordPage());
        }

        /// <summary>
        /// Invoked when the profile button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void DeconnexionButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
            Debug.WriteLine("Deconnexion clicked");
            //bool rep = await DisplayAlert("Titre", "Question", "Oui", "Non");
            //await App.Current.MainPage.Navigation.PushAsync(new SimpleLoginPage());

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
