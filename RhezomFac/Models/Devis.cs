using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    public class Devis : Document
    {


        #region variables
        private DateTime _dateValidite;

        public DateTime DateValidite
        {
            get { return _dateValidite; }
            set { _dateValidite = value; }
        }

        private int _statut;

        public int Statut
        {
            get { return _statut; }
            set { _statut = value; }
        }



        #endregion

        #region constructor
        public Devis(DateTime dateValidite,
                     int statut,
                     string logo,
                     DateTime date,
                     string numTVAClient,
                     string numTVAEntr,
                     string adrClient,
                     string adrEntr,
                     string pays,
                     string bCE,
                     string iBAN,
                     string bIC,
                     string numTelFixe,
                     string numMobile,
                     string numFax,
                     string mailEntr,
                     string mailClient,
                     string lienWeb,
                     List<string> listeProd,
                     int qtiteProd,
                     float totalHT,
                     float totalTVA,
                     string infoAdd,
                     DateTime dateEmission)
            : base(logo, date, numTVAClient, numTVAEntr, adrClient, adrEntr, pays, bCE, iBAN, bIC, numTelFixe, numMobile, numFax, mailEntr, mailClient, lienWeb, listeProd, qtiteProd, totalHT, totalTVA, infoAdd, dateEmission)
        {
            this._dateValidite = dateValidite;
            this._statut = statut;
        }

        #endregion

        #region methodes

        #endregion
    }
}
