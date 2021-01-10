using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class Devis : Document
    {
        private DateTime _dateValidite;

        public DateTime DateValidite { get => _dateValidite; set => _dateValidite = value; }

        public Devis(DateTime dateValidite, DateTime dateEmission, string infoAdd, string reference)
            : base( dateEmission,  infoAdd,  reference)
        {
            _dateValidite = dateValidite;
        }

        public void statut(bool signe, bool resilie, DateTime dateDebut, DateTime dateFin)
        {

        }

        public void SauverBrouillons()
        {

        }
    }
}
