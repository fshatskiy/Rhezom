using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RhezomFac.ViewModels.CreationDevis
{
    /// <summary>
    /// ViewModel for Business Registration Form page
    /// </summary>
    [Preserve(AllMembers = true)]
    public class CreationDevisFormViewModel : BaseViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CreationDevisFormViewModel" /> class
        /// </summary>
        public CreationDevisFormViewModel()
        {
            this.SubmitCommand = new Command(this.SubmitClicked);
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Full Name from user.
        /// </summary> + null + isEmpty
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Business Name from user.
        /// vérif max caract + null + isEmpty
        /// </summary>
        public string NumTVAClient { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with a ComboBox that gets the Business from user.
        /// vérif max caract + null + isEmpty
        /// </summary>
        public string NumTVAEntr { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Email ID from user.
        /// + max caract + null + isEmpty
        /// </summary>
        public string AdrClient { get; set; }

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
        /// vérif présence du @ + max caract + null + isEmpty
        /// </summary>
        public string MailClient { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// + max caract + possible de ne rien avoir
        /// </summary>
        public string LienWeb { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        ///  + isEmpty + null
        /// </summary>
        public List<string> ListeProd { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// vérif valeurs négatives + null
        /// </summary>
        public int QtiteProd { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// vérif valeurs négatives + null + isEmpty
        /// </summary>
        public float TotalHT { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// vérif valeurs négatives + null + isEmpty
        /// </summary>
        public float TotalTVA { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// + max caract : possible de ne rien avoir
        /// </summary>
        public string InfoAdd { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// </summary>
        public DateTime DateEmission { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// </summary>
        public DateTime DateValidite { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// que 3 possibilités + oblig d'avoir un statut par défaut + isEmpty
        /// </summary>
        public int Statut { get; set; }



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
            Debug.WriteLine("Enregistrer clicked");
            await App.Current.MainPage.Navigation.PopAsync();
        }

        #endregion
    }
}