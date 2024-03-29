﻿using System.Reflection;
using System.Runtime.Serialization.Json;
using RhezomFac.ViewModels.DevisNav;

namespace RhezomFac.DataService
{
    public class DevisDataService
    {
        #region fields

        private static DevisDataService instance;

        private NavigationViewModel navigationViewModel;

        #endregion

        #region Properties

        /// <summary>
        /// Gets an instance of the <see cref="DevisDataService"/>.
        /// </summary>
        //public static NavigationDataService Instance => instance ?? (instance = new NavigationDataService());
        public static DevisDataService Instance => instance ??= new DevisDataService();

        /// <summary>
        /// Gets or sets the value of navigation page view model.
        /// </summary>
        public NavigationViewModel NavigationViewModel =>
            //this.navigationViewModel ??
            //(this.navigationViewModel = PopulateData<NavigationViewModel>("navigation.json"));
            this.navigationViewModel ??= PopulateData<NavigationViewModel>("navigation.json");

        #endregion

        #region Methods

        /// <summary>
        /// Populates the data for view model from json file.
        /// </summary>
        /// <typeparam name="T">Type of view model.</typeparam>
        /// <param name="fileName">Json file to fetch data.</param>
        /// <returns>Returns the view model object.</returns>
        private static T PopulateData<T>(string fileName)
        {
            var file = "RhezomFac.Data." + fileName;

            var assembly = typeof(App).GetTypeInfo().Assembly;

            T obj;

            using (var stream = assembly.GetManifestResourceStream(file))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                obj = (T)serializer.ReadObject(stream);
            }

            return obj;
        }

        #endregion
    }
}
