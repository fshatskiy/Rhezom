using System.Collections.ObjectModel;
using RhezomFac.Models.AboutUs;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RhezomFac.ViewModels.AboutUs
{
    /// <summary>
    /// ViewModel of AboutUs templates.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class AboutUsViewModel : BaseViewModel
    {
        #region Fields

        private string productDescription;

        //private string productVersion;

        private Image productIcon;

        private Image cardsTopImage;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="T:RhezomFac.ViewModels.AboutUs.AboutUsViewModel"/> class.
        /// </summary>
        public AboutUsViewModel()
        {
            this.productDescription =
                "Rhezom vous souhaite la bienvenue Site web : \nhttps://www.rhezom.com (En maintenance)\nRhezom est un studio de jeux vidéo basé en Belgique, dans le Hainaut. (Trazegnies) \nNos services:\n - Développement de jeux vidéo\n - Des formations dans le développement(Logiciel / Jeux ) \nN'hésitez pas à prendre contact avec nous pour toutes questions, nous sommes là pour vous répondre :\ninfo@rhezom.com \n+32 (0)455/10.56.31 \n+32 (0)71/12.63.85";
            this.productIcon = new Image { Source = "rhezom.png" };
            //this.productVersion = "1.0";
            //this.cardsTopImage = App.BaseImageUrl + "Mask.png";

            //this.EmployeeDetails = new ObservableCollection<AboutUsModel>
            //{
            //    new AboutUsModel
            //    {
            //        EmployeeName = "Alice",
            //        Image = new Image { Source = "rhezom.png" },
            //        Designation = "Project Manager"
            //    }
            //    //new AboutUsModel
            //    //{
            //    //    EmployeeName = "Jessica Park",
            //    //    Image = App.BaseImageUrl + "ProfileImage10.png",
            //    //    Designation = "Senior Manager"
            //    //}
            //};

            this.ItemSelectedCommand = new Command(this.ItemSelected);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the top image source of the About us with cards view.
        /// </summary>
        /// <value>Image source location.</value>
        public Image CardsTopImage
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
        public Image ProductIcon
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

        /// <summary>
        /// Gets or sets the product version.
        /// </summary>
        /// <value>The product version.</value>
        //public string ProductVersion
        //{
        //    get
        //    {
        //        return this.productVersion;
        //    }

        //    set
        //    {
        //        this.productVersion = value;
        //        this.NotifyPropertyChanged();
        //    }
        //}

        /// <summary>
        /// Gets or sets the employee details.
        /// </summary>
        /// <value>The employee details.</value>
        //public ObservableCollection<AboutUsModel> EmployeeDetails { get; set; }

        /// <summary>
        /// Gets or sets the command that will be executed when an item is selected.
        /// </summary>
        public Command ItemSelectedCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when an item is selected.
        /// </summary>
        private void ItemSelected(object selectedItem)
        {
            // Do something
        }

        #endregion
    }
}