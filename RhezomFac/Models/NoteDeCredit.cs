using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class NoteDeCredit : Document
    {

        #region variables

        #endregion

        #region constructeur
        public NoteDeCredit(
                       string logo,
                       DateTime dateEmission,
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
                       List<Produit> listeProd,
                       int qtiteProd,
                       float totalHT,
                       float totalTVA,
                       string infoAdd)
            : base(logo, dateEmission, numTVAClient, numTVAEntr, adrClient, adrEntr, pays, bCE, iBAN, bIC, numTelFixe, numMobile, numFax, mailEntr, mailClient, lienWeb, listeProd, qtiteProd, totalHT, totalTVA, infoAdd)
        {

        }
        #endregion

        #region methodes

        #endregion
    }
}
