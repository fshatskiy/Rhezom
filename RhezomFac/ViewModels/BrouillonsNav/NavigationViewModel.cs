﻿using Android.OS;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using System.Diagnostics;
using NavigationModel = RhezomFac.Models.BrouillonsNav.NavigationModel;
using System;

namespace RhezomFac.ViewModels.BrouillonsNav
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
            // A l'ouverture d'un brouillon
            System.Diagnostics.Debug.WriteLine("Ouverture d'un brouillon clicked");
            await App.Current.MainPage.Navigation.PopAsync(); //retourne en arrière
        }


        #endregion
    }
}