using System.Collections.ObjectModel;
using RhezomFac.Models.PageConditions;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RhezomFac.ViewModels.PageConditions
{
    /// <summary>
    /// ViewModel of AboutUs templates.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class PageConditionsViewModel : BaseViewModel
    {
        #region Fields

        private string productDescription;

        private string productIcon;

        private string cardsTopImage;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="T:RhezomFac.ViewModels.PageConditions.AboutUsViewModel"/> class.
        /// </summary>
        public PageConditionsViewModel()
        {
            this.productDescription =
                "Conditions générales à compléter" +
                "\n" +
                "\n1)	Champ d’application" +
                "\n" +
                "\nCes conditions générales d’utilisation (CGU) s’appliquent à toute visite ou utilisation de notre application et de ses informations par ses utilisateurs." +
                "\nEn visitant ou en utilisant l’application, l’utilisateur reconnait avoir pris connaissance des présentes CGU et accepte les droits et obligations qui y sont mentionnées." +
                "\nNous nous réservons le droit de modifier nos CGU à tout moment, sans notification préalable, mais nous nous engageons à appliquer les disposition qui étaient en vigueur au moment où vous avez utilisé notre application." +
                "\n" +
                "\n2)	Application" +
                "\n  a.	Accès" +
                "\n" +
                "\nNous prenons toutes les mesures raisonnables et nécessaires pour assurer le bon fonctionnement, la sécurité ainsi que l’accessibilité de notre application. Cependant, nous ne pouvons offrir une garantie d’opérabilité absolue et il faut dès lors considérer nos actions comme étant couvertes par une obligation de moyen." +
                "\nNous nous réservons le droit de restreindre l’accès à l’application ou d’interrompre son fonctionnement à tout moment, sans obligation de notification préalable." +
                "\n" +
                "\n  b.	Contenu" +
                "\n" +
                "\nLe règlement général sur la protection des données (RGPD) concerne tout organisme public ou privé quels que soient sa taille, son pays d’implantation et son activité, qui traite des données personnelles pour son compte ou non, dès lors qu’il est établi sur le territoire de l’Union européenne, ou que son activité cible directement les résidents européens." +
                "\nRGPD contient en grande partie le contenu de l’application en lui apportant toute la protection nécessaire." +
                "\nNous mettons tous nos efforts en œuvre pour maintenir notre application aussi complète, précise et à jour que possible. Nous nous réservons le droit de modifier, compléter ou supprimer à tout moment l’application et son contenu, sans que sa responsabilité ne puisse être engagée." +
                "\n" +
                "\n3)	Protection des données personnelles" +
                "\n" +
                "\nLes données personnelles fournies par l’utilisateur lors de son utilisation de l’application sont collectées et traitées par RGPD a des fins internes. RGPD assure aux utilisateurs qu’elle attache la plus grande importance à la protection de leur vie privée et de leurs données personnelles, et qu’elle s’engage toujours à communiquer de manière claire et transparente sur ce point." +
                "\nDe plus, RGPD s’engage à respecter la législation applicable en la matière, à savoir la Loi du 8 décembre 1992 relative à la protection de la vie privée à l’égard des traitements de données à caractère personnel ainsi que le Règlement européen du 27 avril 2016 relatif à la protection des personnes physiques à l’égard du traitement des données à caractère personnel et à la libre circulation de ces données." +
                "\n" +
                "\n4)	Conservation des données personnelles" +
                "\n" +
                "\nAprès la suppression de nos données personnelles, nous nous octroyons le droit de garder celles-ci pendant une période déterminée de 5 ans. Vos données personnelles serviront aux propriétaire de cette application en guise de preuve d’achat, de la bonne gestion de comptabilité et de facturation conformes aux conditions générales." +
                "\n" +
                "\n5)	Sécurité des données personnelles" +
                "\n" +
                "\nAfin de protéger vos données personnelles, toutes les données que vous nous fournissez sont cryptées selon la norme de sécurité TLS (Transport Layer Security). Celui-ci est une norme de sécurité fiable, testée et utilisée par des services bancaires en ligne par exemple."
                ;
            //this.productIcon = App.BaseImageUrl + "Icon.png";
            //this.cardsTopImage = App.BaseImageUrl + "Mask.png";
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the top image source of the About us with cards view.
        /// </summary>
        /// <value>Image source location.</value>
        public string CardsTopImage
        {
            get
            {
                return this.cardsTopImage;
            }

            set
            {
                this.cardsTopImage = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the description of a product or a company.
        /// </summary>
        /// <value>The product description.</value>
        public string ProductDescription
        {
            get
            {
                return this.productDescription;
            }

            set
            {
                this.productDescription = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the product icon.
        /// </summary>
        /// <value>The product icon.</value>
        public string ProductIcon
        {
            get
            {
                return this.productIcon;
            }

            set
            {
                this.productIcon = value;
                this.NotifyPropertyChanged();
            }
        }

        #endregion
    }
}