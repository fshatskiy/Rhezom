using System.ComponentModel;
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

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the home button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void DevisButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
        }

        /// <summary>
        /// Invoked when the interests button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void FacturesButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
        }

        /// <summary>
        /// Invoked when the bookmark button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void BrouillonsButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
        }

        /// <summary>
        /// Invoked when the activity button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void ParamButtonClicked(object obj)
        {
            this.UpdateSelectedItemColor(obj);
        }

        /// <summary>
        /// Invoked when the profile button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void EntrDataButtonClicked(object obj)
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
