using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    public class Personne
    {

        #region variables
        private string _adresse;

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        private string _mail;

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        private string _tel;

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        //par defaut = null
        // val readonly = en lecture seule partout ailleurs à part le constructeur
        private readonly string _numTVA = null;


        #endregion

        #region constructeur
        public Personne(string adresse,
                        string mail,
                        string tel,
                        string numTVA)
        {
            this._adresse = adresse;
            this._mail = mail;
            this._tel = tel;
            this._numTVA = numTVA;
        }
        #endregion

        #region methodes



        #endregion
    }
}
