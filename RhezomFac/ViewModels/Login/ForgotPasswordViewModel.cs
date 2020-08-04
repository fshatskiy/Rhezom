using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RhezomFac.ViewModels.Login
{
    /// <summary>
    /// ViewModel for forgot password page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ForgotPasswordViewModel : LoginViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgotPasswordViewModel" /> class.
        /// </summary>
        public ForgotPasswordViewModel()
        {
            //this.SignUpCommand = new Command(this.SignUpClicked);
            this.SendCommand = new Command(this.SendClicked);
        }

        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Send button is clicked.
        /// </summary>
        public Command SendCommand { get; set; }

        ///// <summary>
        ///// Gets or sets the command that is executed when the Sign Up button is clicked.
        ///// </summary>
        //public Command SignUpCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Send button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void SendClicked(object obj)
        {
            // Do something
        }

        ///// <summary>
        ///// invoked when the sign up button is clicked.
        ///// </summary>
        ///// <param name="obj">the object</param>
        //private void signupclicked(object obj)
        //{
        //    // do something
        //}

        #endregion
    }
}