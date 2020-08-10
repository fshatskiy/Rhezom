using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    public class Client : Personne
    {
        #region variables
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private string _prenom;

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        private int _numClient;

        public int NumClient
        {
            get { return _numClient; }
            set { _numClient = value; }
        }


        #endregion

        #region constructeur
        public Client(string nom,
                      string prenom,
                      int numClient,
                      string adresse,
                      string mail,
                      string tel,
                      string numTVA)
            : base(adresse,
                    mail,
                    tel,
                    numTVA)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._numClient = numClient;
        }
        #endregion

        #region methodes
        #endregion
    }
}
