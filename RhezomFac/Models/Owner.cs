using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class Owner : Personne
    {
        private string _nomCommercial;
        private string _mdp;
        private int _idBDD;

        public string NomCommercial { get => _nomCommercial; set => _nomCommercial = value; }
        public string Mdp { get => _mdp; set => _mdp = value; }
        public int IdBDD { get => _idBDD; set => _idBDD = value; }

        public Owner(string nomCommercial, string mdp, int idBDD, string nom, string prenom, string adresse, string mail, string tel, string numTVA)
            : base(nom,  prenom,  adresse,  mail,  tel,  numTVA)
        {
            _nomCommercial = nomCommercial;
            _mdp = mdp;
            _idBDD = idBDD;
        }

        public void Acces()
        {

        }
    }
}
