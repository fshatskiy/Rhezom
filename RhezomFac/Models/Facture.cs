﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class Facture : Document
    {

        #region variables

        private DateTime _dateEcheance;

        public DateTime DateEcheance
        {
            get { return _dateEcheance; }
            set { _dateEcheance = value; }
        }

        #endregion

        #region constructeur
        public Facture(DateTime dateEcheance,
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
            this._dateEcheance = dateEcheance;
        }
        #endregion

        #region methodes

        #endregion

    }
}
