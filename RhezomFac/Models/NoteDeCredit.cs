using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    class NoteDeCredit
    {
        private DateTime _dateEmission;
        private string _infoAdd;
        private string _refNote;

        public DateTime DateEmission { get => _dateEmission; set => _dateEmission = value; }
        public string InfoAdd { get => _infoAdd; set => _infoAdd = value; }
        public string RefNote { get => _refNote; set => _refNote = value; }

        public NoteDeCredit(DateTime dateEmission, string infoAdd, string refNote)
        {
            _dateEmission = dateEmission;
            _infoAdd = infoAdd;
            _refNote = refNote;
        }

        public void Total()
        {

        }

        public void CreerNote()
        {

        }
    }
}
