using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class ProfilEntreprise
    {
        private string _logo;
        private string _nomCommercial;
        private string _adrEntr;
        private string _numTVA;
        private string _pays;
        private int _telEntr;
        private int _numFax;
        private string _mailEntr;
        private string _lienWeb;
        private string _iBAN;
        private string _bIC;
        private string _bCE;

        public string Logo { get => _logo; set => _logo = value; }
        public string NomCommercial { get => _nomCommercial; set => _nomCommercial = value; }
        public string AdrEntr { get => _adrEntr; set => _adrEntr = value; }
        public string NumTVA { get => _numTVA; set => _numTVA = value; }
        public string Pays { get => _pays; set => _pays = value; }
        public int TelEntr { get => _telEntr; set => _telEntr = value; }
        public int NumFax { get => _numFax; set => _numFax = value; }
        public string MailEntr { get => _mailEntr; set => _mailEntr = value; }
        public string LienWeb { get => _lienWeb; set => _lienWeb = value; }
        public string IBAN { get => _iBAN; set => _iBAN = value; }
        public string BIC { get => _bIC; set => _bIC = value; }
        public string BCE { get => _bCE; set => _bCE = value; }

        public ProfilEntreprise(string logo, string nomCommercial, string adrEntr, string numTVA, string pays, int telEntr, int numFax, string mailEntr, string lienWeb, string iBAN, string bIC, string bCE)
        {
            _logo = logo;
            _nomCommercial = nomCommercial;
            _adrEntr = adrEntr;
            _numTVA = numTVA;
            _pays = pays;
            _telEntr = telEntr;
            _numFax = numFax;
            _mailEntr = mailEntr;
            _lienWeb = lienWeb;
            _iBAN = iBAN;
            _bIC = bIC;
            _bCE = bCE;
        }

        public void EnregistrerProfil()
        {

        }

        public void ImporterLogo()
        {

        }
    }
}
