﻿using RhezomFac.Views.Accueil;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using NavigationModel = RhezomFac.Models.DevisNav.NavigationModel;

namespace RhezomFac.ViewModels.DevisNav
{
    /// <summary>
    /// ViewModel for the Navigation list with cards page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class NavigationViewModel
    {
        #region Fields

        private Command<object> itemTappedCommand;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="NavigationViewModel"/> class.
        /// </summary>
        public NavigationViewModel()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the command that will be executed when an item is selected.
        /// </summary>
        public Command<object> ItemTappedCommand
        {
            get
            {
                //return this.itemTappedCommand ?? (this.itemTappedCommand = new Command<object>(this.NavigateToNextPage));
                return this.itemTappedCommand ??= new Command<object>(this.NavigateToNextPage);
            }
        }

        /// <summary>
        /// Gets or sets a collection of values to be displayed in the Navigation list page.
        /// </summary>
        [DataMember(Name = "navigationList")]
        public ObservableCollection<NavigationModel> NavigationList { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when an item is selected from the navigation list.
        /// </summary>
        /// <param name="selectedItem">Selected item from the list view.</param>
        private async void NavigateToNextPage(object selectedItem)
        {
            // Do something
            Debug.WriteLine("Carte clicked");
            await App.Current.MainPage.Navigation.PushAsync(new AccueilPage());
        }

        #endregion
    }
}