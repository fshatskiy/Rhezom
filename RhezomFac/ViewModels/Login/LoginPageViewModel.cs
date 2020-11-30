using RhezomFac.Views.Accueil;
using RhezomFac.Views.SignUp;
using RhezomFac.Views.Login;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Essentials;
using System;
using System.Linq;
//using RhezomFac.Views.AccueilPage;

namespace RhezomFac.ViewModels.Login
{
    /// <summary>
    /// ViewModel for login page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class LoginPageViewModel : LoginViewModel
    {
        #region Fields

        private string password;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="LoginPageViewModel" /> class.
        /// </summary>
        public LoginPageViewModel()
        {
            this.LoginCommand = new Command(this.LoginClicked);
            this.SignUpCommand = new Command(this.SignUpClicked);
            this.ForgotPasswordCommand = new Command(this.ForgotPasswordClicked);
        }

        #endregion

        #region property

        /// <summary>
        /// Gets or sets the property that is bound with an entry that gets the password from user in the login page.
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                if (this.password == value)
                {
                    return;
                }

                this.password = value;
                this.NotifyPropertyChanged();
            }
        }
        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Log In button is clicked.
        /// </summary>
        public Command LoginCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Sign Up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Forgot Password button is clicked.
        /// </summary>
        public Command ForgotPasswordCommand { get; set; }

        #endregion

        #region methods

        /// <summary>
        /// Invoked when the Log In button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void LoginClicked(object obj)
        {
            // Faire cette vérif à tous els submit bouttons + afficher message qu'on est hors ligne en bas
            //if(Connectivity.NetworkAccess != NetworkAccess.Internet)
            //{
            //    await App.Current.MainPage.DisplayAlert("Vous n'êtes pas connecté à internet", "", "OK");
            //    return;
            //}
            // Do something
            Debug.WriteLine("Login clicked");

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Champs vides", "Veuillez indiquer votre adresse mail et votre mot de passe pour vous connecter", "Ok");
            }
            else if (Password.Length < 6)
            {
                    await App.Current.MainPage.DisplayAlert("Erreur", "Veillez indiquer une adresse mail ou un mot de passe valide", "Ok");
            }
            else
            {
                await App.Current.MainPage.Navigation.PushAsync(new AccueilPage()); //while testing
            }

            //Conditions
            //var isValid = true;

            //if (string.IsNullOrEmpty(Password) || Password.Length < 6)
            //{
            //    VisualStateManager.GoToState(getPassword(), "Invalide");
            //}
            //await App.Current.MainPage.Navigation.PushAsync(new AccueilPage()); //while testing
        }

        /// <summary>
        /// Invoked when the Sign Up button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void SignUpClicked(object obj)
        {
            // Do something
            Debug.WriteLine("S'enregistrer clicked");
            await App.Current.MainPage.Navigation.PushAsync(new SimpleSignUpPage());
        }

        /// <summary>
        /// Invoked when the Forgot Password button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void ForgotPasswordClicked(object obj)
        {
            var label = obj as Label;
            label.BackgroundColor = Color.FromHex("#70FFFFFF");
            await Task.Delay(100);
            label.BackgroundColor = Color.Transparent;

            Debug.WriteLine("Mot de passe oublié clicked");
            await App.Current.MainPage.Navigation.PushAsync(new SimpleForgotPasswordPage());
        }

        #endregion
    }
}