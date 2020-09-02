using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RhezomFac.ViewModels.ProfilEntreprise
{
    /// <summary>
    /// ViewModel for Business Registration Form page
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ProfilEntrepriseFormViewModel : BaseViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilEntrepriseFormViewModel" /> class
        /// </summary>
        public ProfilEntrepriseFormViewModel()
        {
            this.SubmitCommand = new Command(this.SubmitClicked);
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the property that bounds with a ComboBox that gets the Business from user.
        /// vérif max caract + null + isEmpty
        /// </summary>
        public string NumTVAEntr { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Phone Number from user.
        /// + max caract + null + isEmpty
        /// </summary>
        public string AdrEntr { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Street Address from user.
        /// + max caract + null + isEmpty
        /// </summary>
        public string Pays { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// vérif max caract + null + isEmpty
        /// </summary>
        public string BCE { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// vérif max caract + null + isEmpty
        /// </summary>
        public string IBAN { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// vérif max caract + null + isEmpty
        /// </summary>
        public string BIC { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// + max caract + possible de ne rien avoir
        /// </summary>
        public string NumTelFixe { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// + max caract + null + isEmpty
        /// </summary>
        public string NumMobile { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// + max caract + possible de ne rien avoir
        /// </summary>
        public string NumFax { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// vérif présence du @ + max caract + null + isEmpty
        /// </summary>
        public string MailEntr { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// + max caract + possible de ne rien avoir
        /// </summary>
        public string LienWeb { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// + max caract : possible de ne rien avoir
        /// </summary>
        public string InfoAdd { get; set; }

        #endregion

        #region Comments

        /// <summary>
        /// Gets or sets the command is executed when the Submit button is clicked.
        /// </summary>
        public Command SubmitCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Submit button clicked : enregistrer avant de quitter
        /// </summary>
        /// <param name="obj">The object</param>
        private async void SubmitClicked(Object obj)
        {
            Debug.WriteLine("Brouillons clicked");
            await App.Current.MainPage.Navigation.PopAsync(); //pr le moment retourne juste en arriere
        }

        #endregion
    }
}