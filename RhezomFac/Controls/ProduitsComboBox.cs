using RhezomFac.Models;
using Syncfusion.XForms.ComboBox;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace RhezomFac.Controls
{
    [Preserve(AllMembers = true)]
    public class ProduitsComboBox : SfComboBox, INotifyPropertyChanged
    {
        #region Fields

        private object produit;

        private string phoneNumberPlaceHolder = "Phone Number";

        private string phoneNumber;

        private string city;

        private object state;

        private string[] states;

        private string produitCode;

        #endregion

        #region Constructor
        public ProduitsComboBox()
        {
            BindingContext = this;

            Countries = new List<DevisProduitsModel>();
            Countries.Add(new DevisProduitsModel()
            {
                Produit = "Australia",
                States = new string[] { "Tasmania", "Victoria", "Queensland", "Northen Territory" }
            });
            Countries.Add(new DevisProduitsModel()
            {
                Produit = "Brazil",
                States = new string[] { "Bahia", "Ceara", "Goias", "Maranhao" }
            });
            Countries.Add(new DevisProduitsModel()
            {
                Produit = "Canada",
                States = new string[] { "Manitoba", "Ontario", "Quebec", "Yukon" }
            });
            Countries.Add(new DevisProduitsModel()
            {
                Produit = "India",
                States = new string[] { "Assam", "Gujarat", "Haryana", "Tamil Nadu" }
            });
            Countries.Add(new DevisProduitsModel()
            {
                Produit = "USA",
                States = new string[] { "California", "Florida", "New York", "Washington" }
            });

            DataSource = Countries;
            this.SetBinding(SfComboBox.SelectedItemProperty, "Produit", BindingMode.TwoWay);
            DisplayMemberPath = "Produit";
            Watermark = "Sélectionnez le produit";
            this.VerticalOptions = LayoutOptions.CenterAndExpand;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the property that bounds with a ComboBox that gets the Produit from user.
        /// </summary>
        public object Produit
        {
            get { return produit; }
            set
            {
                produit = value;
                UpdateStateAndPhoneNumberFormat();
            }
        }

        /// <summary>
        /// Gets or set the string property, that represents the phone number format based on Produit.
        /// </summary>
        public string PhoneNumberPlaceHolder
        {
            get { return phoneNumberPlaceHolder; }
            set
            {
                phoneNumberPlaceHolder = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or set the string property, that represents the phone number based on Produit.
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                NotifyPropertyChanged();
            }
        }


        /// <summary>
        /// Gets or sets the string property, which holds the contry code based on user input.
        /// </summary>
        public string ProduitCode
        {
            get { return produitCode; }
            set
            {
                produitCode = value;
                NotifyPropertyChanged();
            }
        }


        /// <summary>
        /// Gets or set the string property, that represents the user given city.
        /// </summary>
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with a ComboBox that gets the State from user.
        /// </summary>
        public object State
        {
            get { return state; }
            set
            {
                state = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets array collection that contains states based on Produit selection.
        /// </summary>
        public string[] States
        {
            get { return states; }
            set
            {
                states = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets string property that represents mask format for phone number.
        /// </summary>
        private string _mask = "";
        public string Mask
        {
            get => _mask;
            set
            {
                _mask = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the collection property, which contains the countries data.
        /// </summary>
        public List<DevisProduitsModel> Countries { get; set; }

        #endregion

        #region Event handler

        /// <summary>
        /// Occurs when the property is changed.
        /// </summary>
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        #endregion

        #region Methods

        /// <summary>
        /// Method used to rest State and City and update PhoneNumber format.
        /// </summary>
        private void UpdateStateAndPhoneNumberFormat()
        {
            State = null;
            PhoneNumber = string.Empty;
            City = string.Empty;
            DevisProduitsModel produitModel = Produit as DevisProduitsModel;
            States = produitModel.States;

            switch (produitModel.Produit)
            {
                case "Australia":
                    PhoneNumberPlaceHolder = "e.g. X XXXX XXXX";
                    Mask = "(+61)X XXXX XXXX";
                    ProduitCode = "(+61)";
                    break;
                case "Brazil":
                    PhoneNumberPlaceHolder = "e.g. XX XXXX XXXX";
                    Mask = "(+55)XX XXXX XXXX";
                    ProduitCode = "(+55)";
                    break;
                case "Canada":
                    PhoneNumberPlaceHolder = "e.g. XXXXXXXXX";
                    Mask = "(+1)XXXXXXXXX";
                    ProduitCode = "(+1)";
                    break;
                case "India":
                    PhoneNumberPlaceHolder = "e.g. XXXXX-XXXXX";
                    Mask = "(+91)XXXXX-XXXXX";
                    ProduitCode = "(+91)";
                    break;
                case "USA":
                    PhoneNumberPlaceHolder = "e.g. XXX-XXX-XXX";
                    Mask = "(+1)XXX-XXX-XXX";
                    ProduitCode = "(+1)";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// The PropertyChanged event occurs when changing the value of property.
        /// </summary>
        /// <param name="propertyName">The PropertyName</param>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}