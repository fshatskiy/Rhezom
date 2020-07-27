using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    public class Produit
    {
        #region constructeur
        public Produit(string nom, string description, int qtiteRest, float prixHT, float tauxTVA)
        {
            this._nom = nom;
            this._description = description;
            this._qtiteRest = qtiteRest;
            this._prixHT = prixHT;
            this._tauxTVA = tauxTVA;
        }
        #endregion

        #region variables
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _qtiteRest;

        public int QtiteRest
        {
            get { return _qtiteRest; }
            set { _qtiteRest = value; }
        }

        private float _prixHT;

        public float PrixHT
        {
            get { return _prixHT; }
            set { _prixHT = value; }
        }

        private float _tauxTVA;

        public float TauxTVA
        {
            get { return _tauxTVA; }
            set { _tauxTVA = value; }
        }




        #endregion
        #region methodes
        #endregion
    }
}
