using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "ProfissionalDeSaude.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace DataManagement
{
    /// <summary>
    /// Gets all information from triagem, doctor code that saw the patient, diagnosis, medication, tests
    /// </summary>
    class ConsultaMedica
    {
        #region State Of Class
        /// <summary>
        /// Initializing attributes
        /// </summary>
        protected Triagem triageInfo;
        protected int doctorCode;
        protected string diagnosis;
        protected string medication;
        protected string tests;

        #endregion



        #region Behavior

        #region Builder

        /// <summary>
        /// Builder by omission
        /// </summary>
        public ConsultaMedica()
        {

        }


        /// <summary>
        /// Builder for Consulta Medica
        /// </summary>
        /// <param name="ti"></param>
        /// <param name="dc"></param>
        /// <param name="diag"></param>
        /// <param name="medi"></param>
        /// <param name="te"></param>
        public ConsultaMedica(Triagem ti, int dc, string diag, string medi, string te)
        {
            triageInfo = ti;
            doctorCode = dc;
            diagnosis = diag;
            medication = medi;
            tests = te;
        }
        #endregion

        #region Methods

        #region Properties


        /// <summary>
        /// Gets triage info for consulta 
        /// </summary>
        public Triagem TriageInfo
        {
            get { return triageInfo; }
            set { triageInfo = value; }
        }

        /// <summary>
        /// Gets doctor code for consulta
        /// </summary>
        public int DoctorCode
        {
            get { return doctorCode; }
            set { doctorCode = value; }
        }

        /// <summary>
        /// gets diagnosis 
        /// </summary>
        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }

        /// <summary>
        /// gets diagnosis 
        /// </summary>
        public string Medication
        {
            get { return medication; }
            set { medication = value; }
        }

        /// <summary>
        /// gets diagnosis 
        /// </summary>
        public string Tests
        {
            get { return tests; }
            set { tests = value; }
        }
        #endregion


        #endregion
        #endregion
    }
}
