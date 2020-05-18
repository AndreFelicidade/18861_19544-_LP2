using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "Medico.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace Objects
{
    /// <summary>
    /// Doctor class
    /// </summary>
    [Serializable]
    public class Medico : Pessoa
    {
        #region Class stats
        public int doctorCode;
        public string specialty;
        public bool avaliable;
        #endregion

        #region Behaviour

        #region Builders
        /// <summary>
        /// Builder by omission for medico
        /// </summary>
        public Medico()
        {

        }

        /// <summary>
        /// Builder for medico
        /// </summary>
        /// <param name="nc"></param>
        /// <param name="spec"></param>
        public Medico(int dc, string spec, bool av)
        {
            doctorCode = dc;
            specialty = spec;
            avaliable = av;
        }

        #endregion

        #region Methods

        #region Overrides
        public override string ToString()
        {
            return "Doctor:" + name + " " + birthDate +
                " " + doctorCode + " " + specialty;
        }
        #endregion
        #region Properties

        /// <summary>
        /// Getting nurse code for enfermeiro
        /// </summary>
        public int DoctorCode
        {
            get { return doctorCode; }
            set { doctorCode = value; }
        }

        /// <summary>
        /// Getting nurse code for enfermeiro
        /// </summary>
        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        /// <summary>
        /// determines whether medico is avaliable or not
        /// </summary>
        public bool Avaliable
        {
            get { return avaliable; }
            set { avaliable = value; }
        }

        #endregion
        #endregion
        #endregion
    }
}
