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

        /// <value>
        /// _date : représente la date de création de la facture
        /// </value>
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
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

        private List<string> _listeProd;

        public List<string> ListeProd
        {
            get { return _listeProd; }
            set { _listeProd = value; }
        }

        private int _qtiteProd;

        public int QtiteProd
        {
            get { return _qtiteProd; }
            set { _qtiteProd = value; }
        }

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
        public Document(string logo, DateTime date, string numTVAClient, string numTVAEntr, string adrClient, string adrEntr, string pays, string bCE, string iBAN, string bIC, string numTelFixe, string numMobile, string numFax, string mailEntr, string mailClient, string lienWeb, List<string> listeProd, int qtiteProd, float totalHT, float totalTVA, string infoAdd)
        {
            this._logo = logo;
            this._date = date;
            this._numTVAClient = numTVAClient;
            this._numTVAEntr = numTVAEntr;
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
            this._mailClient = mailClient;
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
