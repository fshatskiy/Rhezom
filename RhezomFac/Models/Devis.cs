using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    public class Devis : Document
    {
        #region constructor
        public Devis(int numDevis, string logo, DateTime date, string numTVAClient, string numTVAEntr, string adrClient, string adrEntr, string pays, string bCE, string iBAN, string bIC, string numTelFixe, string numMobile, string numFax, string mailEntr, string mailClient, string lienWeb, List<string> listeProd, int qtiteProd, float totalHT, float totalTVA, string infoAdd)
            : base( logo,  date,  numTVAClient,  numTVAEntr,  adrClient,  adrEntr,  pays,  bCE,  iBAN,  bIC,  numTelFixe,  numMobile,  numFax,  mailEntr,  mailClient,  lienWeb,  listeProd,  qtiteProd,  totalHT,  totalTVA,  infoAdd)
        {
            this._numDevis = numDevis;
        }

        #endregion

        #region variables
        private int _numDevis;

        public int NumDevis
        {
            get { return _numDevis; }
            set { _numDevis = value; }
        }

        #endregion

        #region methodes

        #endregion
    }
}
