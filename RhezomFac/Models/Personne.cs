using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class Personne
    {
        private string _nom;
        private string _prenom;
        private string _adresse;
        private string _mail;
        private string _tel;
        private string _numTVA;

        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public string Tel { get => _tel; set => _tel = value; }
        public string NumTVA { get => _numTVA; set => _numTVA = value; }

        public Personne(string nom, string prenom, string adresse, string mail, string tel, string numTVA)
        {
            _nom = nom;
            _prenom = prenom;
            _adresse = adresse;
            _mail = mail;
            _tel = tel;
            _numTVA = numTVA;
        }

        public void ChangerAdresse()
        {

        }

        public void ModifInfos()
        {

        }
    }
}
