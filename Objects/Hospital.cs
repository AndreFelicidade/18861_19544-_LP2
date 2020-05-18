using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "Enfermeiro.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace Objects
{
    /// <summary>
    /// Hospital Class , contains variables to store its info
    /// </summary>
    [Serializable]
    class Hospital
    {
        #region Class stats
        public int hospitalCode;
        public string hospitalAddress;
        public int hospitalNif;
        #endregion

        #region Behaviour

        #region Builders
        /// <summary>
        /// Builder by omission for enfermeiro
        /// </summary>
        public Hospital()
        {

        }

       /// <summary>
       /// Builder for hospital
       /// </summary>
       /// <param name="hc"></param>
       /// <param name="ha"></param>
       /// <param name="hnif"></param>
        public Hospital(int hc, string ha, int hnif)
        {
            hospitalCode = hc;
            hospitalAddress = ha;
            hospitalNif = hnif;
            
        }

        #endregion

        #region Methods
        #region Overrides
        public override string ToString()
        {
            return "Hospital:" + hospitalCode + " " + hospitalAddress +
                " " + hospitalNif;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Getting hospital code
        /// </summary>
        public int HospitalCode
        {
            get { return hospitalCode; }
            set { hospitalCode = value; }
        }

        /// <summary>
        /// Getting hospital address
        /// </summary>
        public string HospitalAddress
        {
            get { return hospitalAddress; }
            set { hospitalAddress = value; }
        }

        /// <summary>
        /// Getting hospital nif
        /// </summary>
        public int HospitalNif
        {
            get { return hospitalNif; }
            set { hospitalNif = value; }
        }

        #endregion
        #endregion
        #endregion
    }
}
