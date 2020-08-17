using RhezomFac.Views.Login;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RhezomFac.ViewModels.SignUp
{
    /// <summary>
    /// ViewModel for sign-up page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class SignUpPageViewModel : LoginViewModel
    {
        #region Fields

        private string pseudo;

        private string password;

        private string confirmPassword;

        private string numTVA;

        private string nomCommercial;

        private string adresse;

        private string pays;

        private string tel;

        private string persContact;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="SignUpPageViewModel" /> class.
        /// </summary>
        public SignUpPageViewModel()
        {
            this.LoginCommand = new Command(this.LoginClicked);
            this.SignUpCommand = new Command(this.SignUpClicked);
        }

        #endregion

        #region Property

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Pseudo from user in the Sign Up page.
        /// </summary>
        public string Pseudo
        {
            get
            {
                return this.pseudo;
            }

            set
            {
                if (this.pseudo == value)
                {
                    return;
                }

                this.pseudo = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the password from users in the Sign Up page.
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

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the password confirmation from users in the Sign Up page.
        /// </summary>
        public string ConfirmPassword
        {
            get
            {
                return this.confirmPassword;
            }

            set
            {
                if (this.confirmPassword == value)
                {
                    return;
                }

                this.confirmPassword = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Numéro TVA de l'entreprise from user in the Sign Up page.
        /// </summary>
        public string NumTVA
        {
            get
            {
                return this.numTVA;
            }

            set
            {
                if (this.numTVA == value)
                {
                    return;
                }

                this.numTVA = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Nom commercial from user in the Sign Up page.
        /// </summary>
        public string NomCommercial
        {
            get
            {
                return this.nomCommercial;
            }

            set
            {
                if (this.nomCommercial == value)
                {
                    return;
                }

                this.nomCommercial = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the l'adresse from user in the Sign Up page.
        /// </summary>
        public string Adresse
        {
            get
            {
                return this.adresse;
            }

            set
            {
                if (this.adresse == value)
                {
                    return;
                }

                this.adresse = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the pays from user in the Sign Up page.
        /// </summary>
        public string Pays
        {
            get
            {
                return this.pays;
            }

            set
            {
                if (this.pays == value)
                {
                    return;
                }

                this.pays = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the téléphone from user in the Sign Up page.
        /// </summary>
        public string Tel
        {
            get
            {
                return this.tel;
            }

            set
            {
                if (this.tel == value)
                {
                    return;
                }

                this.tel = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the personne de contact from user in the Sign Up page.
        /// </summary>
        public string PersContact
        {
            get
            {
                return this.persContact;
            }

            set
            {
                if (this.persContact == value)
                {
                    return;
                }

                this.persContact = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Se connecter button is clicked.
        /// </summary>
        public Command LoginCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Créer un compte button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Se connecter button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void LoginClicked(object obj)
        {
            // Do something
            Debug.WriteLine("Se connecter clicked");
            await App.Current.MainPage.Navigation.PushAsync(new SimpleLoginPage());
        }

        /// <summary>
        /// Invoked when the Créer un compte button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void SignUpClicked(object obj)
        {
            // Mettre en place des conditions !
            Debug.WriteLine("Envoyer clicked");
            await App.Current.MainPage.Navigation.PushAsync(new SimpleLoginPage());
        }

        #endregion
    }
}