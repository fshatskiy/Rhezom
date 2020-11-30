using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    public class Document
    {


        #region variables
        private string _logo;

        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

        /// <summary>
        /// voir si get est bon
        /// </summary>
        private DateTime _dateEmission;

        public DateTime DateEmission
        {
            get { return DateTime.Today; }
            set { _dateEmission = value; }
        }

        private string _numTVAClient;

        public string NumTVAClient
        {
            get { return _numTVAClient; }
            set { _numTVAClient = value; }
        }

        private string _numTVAEntr;

        public string NumTVAEntr
        {
            get { return _numTVAEntr; }
            set { _numTVAEntr = value; }
        }

        private string _adrClient;

        public string AdrClient
        {
            get { return _adrClient; }
            set { _adrClient = value; }
        }

        private string _adrEntr;

        public string AdrEntr
        {
            get { return _adrEntr; }
            set { _adrEntr = value; }
        }

        private string _pays;

        public string Pays
        {
            get { return _pays; }
            set { _pays = value; }
        }

        private string _BCE;

        public string BCE
        {
            get { return _BCE; }
            set { _BCE = value; }
        }

        private string _IBAN;

        public string IBAN
        {
            get { return _IBAN; }
            set { _IBAN = value; }
        }

        private string _BIC;

        public string BIC
        {
            get { return _BIC; }
            set { _BIC = value; }
        }

        private string _numTelFixe;

        public string NumTelFixe
        {
            get { return _numTelFixe; }
            set { _numTelFixe = value; }
        }

        private string _numMobile;

        public string NumMobile
        {
            get { return _numMobile; }
            set { _numMobile = value; }
        }

        private string _numFax;

        public string NumFax
        {
            get { return _numFax; }
            set { _numFax = value; }
        }

        private string _mailEntr;

        public string MailEntr
        {
            get { return _mailEntr; }
            set { _mailEntr = value; }
        }

        private string _mailClient;

        public string MailClient
        {
            get { return _mailClient; }
            set { _mailClient = value; }
        }

        private string _lienWeb;

        public string LienWeb
        {
            get { return _lienWeb; }
            set { _lienWeb = value; }
        }


        /// <summary>
        /// liste de produits
        /// </summary>
        private List<Produit> _listeProd;

        public List<Produit> ListeProd
        {
            get { return _listeProd; }
            set { _listeProd = value; }
        }

        private int _qtiteProd;

        /// <summary>
        /// à vérif la fct count
        /// </summary>
        public int QtiteProd
        {
            get { return ListeProd.Count; }
            set { _qtiteProd = value; }
        }

        /// <summary>
        /// Mettre le calcul en place :
        /// </summary>
        private float _totalHT;

        public float TotalHT
        {
            get { return _totalHT; }
            set { _totalHT = value; }
        }

        private float _totalTVA;

        public float TotalTVA
        {
            get { return _totalTVA; }
            set { _totalTVA = value; }
        }

        private string _infoAdd;

        public string InfoAdd
        {
            get { return _infoAdd; }
            set { _infoAdd = value; }
        }

        #endregion

        #region constructeur(s)
        //constr par def
        public Document() { }
        public Document(string logo,
                        DateTime dateEmission,
                        string numTVAClient,
                        string numTVAEntr,
                        string adrClient,
                        string adrEntr,
                        string pays,
                        string bCE,
                        string iBAN,
                        string bIC,
                        string numTelFixe,
                        string numMobile,
                        string numFax,
                        string mailEntr,
                        string mailClient,
                        string lienWeb,
                        List<Produit> listeProd,
                        int qtiteProd,
                        float totalHT,
                        float totalTVA,
                        string infoAdd
                        )
        {
            this._logo = logo;
            this._dateEmission = dateEmission;
            this._numTVAClient = numTVAClient;
            this._numTVAEntr = numTVAEntr; //client final
            this._adrClient = adrClient;
            this._adrEntr = adrEntr;
            this._pays = pays;
            this._BCE = bCE;
            this._IBAN = iBAN;
            this._BIC = bIC;
            this._numTelFixe = numTelFixe;
            this._numMobile = numMobile;
            this._numFax = numFax;
            this._mailEntr = mailEntr;
            this._mailClient = mailClient; //client final
            this._lienWeb = lienWeb;
            this._listeProd = listeProd;
            this._qtiteProd = qtiteProd;
            this._totalHT = totalHT;
            this._totalTVA = totalTVA;
            this._infoAdd = infoAdd;
        }
        #endregion

        #region methodes

        #endregion
    }
}
