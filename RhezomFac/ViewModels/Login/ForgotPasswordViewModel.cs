﻿using RhezomFac.Views.SignUp;
using RhezomFac.Views.Login;
using System.Diagnostics;
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
            this.SignUpCommand = new Command(this.SignUpClicked);
            this.SendCommand = new Command(this.SendClicked);
        }

        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Send button is clicked.
        /// </summary>
        public Command SendCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Sign Up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Send button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void SendClicked(object obj)
        {
            // Do Something
            Debug.WriteLine("Envoyer clicked");
            await App.Current.MainPage.Navigation.PushAsync(new SimpleLoginPage());
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

        #endregion
    }
}