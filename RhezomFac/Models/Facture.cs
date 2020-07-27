using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class Facture : Document
    {
        #region constructeur
        public Facture(DateTime echeance, string modalite, int numDevis, string logo, DateTime date, string numTVAClient, string numTVAEntr, string adrClient, string adrEntr, string pays, string bCE, string iBAN, string bIC, string numTelFixe, string numMobile, string numFax, string mailEntr, string mailClient, string lienWeb, List<string> listeProd, int qtiteProd, float totalHT, float totalTVA, string infoAdd)
            : base(logo, date, numTVAClient, numTVAEntr, adrClient, adrEntr, pays, bCE, iBAN, bIC, numTelFixe, numMobile, numFax, mailEntr, mailClient, lienWeb, listeProd, qtiteProd, totalHT, totalTVA, infoAdd)
        {
            this._echeance = echeance;
            this._modalite = modalite;
        }
        #endregion

        #region variables

        private DateTime _echeance;

        public DateTime Echeance
        {
            get { return _echeance; }
            set { _echeance = value; }
        }

        /// <summary>
        /// nombre de jours restants
        /// </summary>
        private string _modalite;

        public string Modalite
        {
            get { return _modalite; }
            set { _modalite = value; }
        }

        #endregion

        #region methodes

        #endregion

    }
}
