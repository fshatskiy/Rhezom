using Xamarin.Forms.Internals;

namespace RhezomFac.Models
{
    /// <summary>
    /// Model for SocialProfile
    /// </summary>
    [Preserve(AllMembers = true)]
    public class DevisProduitsModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the country name.
        /// </summary>
        public string Produit { get; set; }

        /// <summary>
        /// Gets or sets the states collection.
        /// </summary>
        public string[] States { get; set; }

        #endregion
    }
}
