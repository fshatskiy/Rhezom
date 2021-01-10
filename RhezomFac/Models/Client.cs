using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class Client : Personne
    {
        private int _numClient;
        private bool _estActif;

        public int NumClient { get => _numClient; set => _numClient = value; }
        public bool EstActif { get => _estActif; set => _estActif = value; }

        public Client(int numClient, bool estActif, string nom, string prenom, string adresse, string mail, string tel, string numTVA)
            : base(nom, prenom, adresse, mail, tel, numTVA)
        {
            _numClient = numClient;
            _estActif = estActif;
        }

        public void Etat()
        {

        }
    }
}
