using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class Produit
    {
        private string _nom;
        private string _description;
        private int _qtiteRest;
        private float _tVA;
        private float _prixHT;
        private bool _estActif;

        public string Nom { get => _nom; set => _nom = value; }
        public string Description { get => _description; set => _description = value; }
        public int QtiteRest { get => _qtiteRest; set => _qtiteRest = value; }
        public float TVA { get => _tVA; set => _tVA = value; }
        public float PrixHT { get => _prixHT; set => _prixHT = value; }
        public bool EstActif { get => _estActif; set => _estActif = value; }

        public Produit(string nom, string description, int qtiteRest, float tVA, float prixHT, bool estActif)
        {
            _nom = nom;
            _description = description;
            _qtiteRest = qtiteRest;
            _tVA = tVA;
            _prixHT = prixHT;
            _estActif = estActif;
        }

        public void AjouterProd()
        {

        }

        public void SuppProd()
        {

        }
    }
}
