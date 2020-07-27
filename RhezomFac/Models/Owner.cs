using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    public class Owner : Personne
    {
        #region constructeur
        public Owner(string nomCommercial, string mdp, int idBDD,string adresse, string mail, string tel, string numTVA)
            : base( adresse,  mail,  tel,  numTVA)
        {
            this._nomCommercial = nomCommercial;
            this._mdp = mdp;
            this._idBDD = idBDD;
        }
        #endregion
        #region variables
        private string _nomCommercial;

        public string NomCommercial
        {
            get { return _nomCommercial; }
            set { _nomCommercial = value; }
        }

        private string _mdp;

        public string Mdp
        {
            get { return _mdp; }
            set { _mdp = value; }
        }

        private int _idBDD;

        public int IdBDD
        {
            get { return _idBDD; }
            set { _idBDD = value; }
        }



        #endregion
        #region methodes
        #endregion
    }
}
