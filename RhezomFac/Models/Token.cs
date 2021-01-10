using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class Token
    {
        private int _idToken;
        private string _accesToken;
        private string _descriptionError;
        private DateTime _dateExp;

        public int IdToken { get => _idToken; set => _idToken = value; }
        public string AccesToken { get => _accesToken; set => _accesToken = value; }
        public string DescriptionError { get => _descriptionError; set => _descriptionError = value; }
        public DateTime DateExp { get => _dateExp; set => _dateExp = value; }

        public Token(int idToken, string accesToken, string descriptionError, DateTime dateExp)
        {
            _idToken = idToken;
            _accesToken = accesToken;
            _descriptionError = descriptionError;
            _dateExp = dateExp;
        }
    }
}
