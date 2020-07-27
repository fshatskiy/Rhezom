using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Models
{
    public class ApplicationData
    {
        #region constructeur
        public ApplicationData(int numBdd)
        {
            this._numBDD = numBdd;
        }
        #endregion
        #region variables
        private int _numBDD;

        public int NumBDD
        {
            get { return _numBDD; }
            set { _numBDD = value; }
        }
        #endregion
        #region methodes
        #endregion

    }
}
