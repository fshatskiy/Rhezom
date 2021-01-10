using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class Facture : Document
    {
        private DateTime _dateEcheance;

        public DateTime DateEcheance { get => _dateEcheance; set => _dateEcheance = value; }

        public Facture(DateTime dateEcheance, DateTime dateEmission, string infoAdd, string reference)
            : base( dateEmission,  infoAdd,  reference)
        {
            _dateEcheance = dateEcheance;
        }

        public void RetardPaiement()
        {

        }
    }
}
