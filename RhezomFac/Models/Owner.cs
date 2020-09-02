using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    public class Owner : Personne
    {

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

        #region constructeur
        public Owner(string nomCommercial,
                     string mdp,
                     int idBDD,
                     string adresse,
                     string mail,
                     string tel,
                     string numTVA)
            : base(adresse, mail, tel, numTVA)
        {
            this._nomCommercial = nomCommercial;
            this._mdp = mdp;
            this._idBDD = idBDD;
        }
        #endregion

        #region methodes

        //public bool CheckInformation()
        //{
        //    if (!this.Mail.Equals("") && !this.Mdp.Equals(""))
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        //private void Btn_login_Clicked(object sender, System.EventArgs e)
        //{
        //    Owner user = new Owner(EmailEntry.Text, PasswordEntry.Text, 1, "Rue de la rue", "test@test.be", "025", "BE25");
        //    if (!user.CheckInformation())
        //    {
        //        DisplayAlert("Mauvais Identifiant", "Votre adresse mail ou mot de passe est incorrect.", "ok");
        //    }
        //}

        #endregion
    }
}
