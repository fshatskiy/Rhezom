using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class Document
    {
        private DateTime _dateEmission;
        private string _infoAdd;
        private string _reference;

        public DateTime DateEmission { get => _dateEmission; set => _dateEmission = value; }
        public string InfoAdd { get => _infoAdd; set => _infoAdd = value; }
        public string Reference { get => _reference; set => _reference = value; }

        public Document(DateTime dateEmission, string infoAdd, string reference) //mettre en place envoi d'un email
        {
            DateEmission = dateEmission;
            InfoAdd = infoAdd;
            Reference = reference;
        }

        public void NumRef()
        {

        }

        public void Imprimer()
        {

        }

        public void CreerDevis()
        {

        }

        public void CreerFacture()
        {

        }

        public void EnvoyerMail()
        {

        }

        public void Total()
        {

        }

        public void TotalHT()
        {

        }

        public void AjoutInfoAdd()
        {

        }
    }
}
