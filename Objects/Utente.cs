using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///<copyright file = "Utente.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>
///<summary>This class is for the object Utente, which does X and Y</summary>

namespace DataManagement
{
    public class Utente : Pessoa
    {
        #region State Of Class
        /// <summary>
        /// Initializing attributes
        /// </summary>
        public int patientNumber;
        public string clinicalCase;
        public Medico doctor; // Doctor seeing the patient
        public int nurseCode;
        public bool triageState;
        public bool seenByDoctor;
        public bool active;

        #endregion

        #region Behavior

        #region Builder

        /// <summary>
        /// Builder by omission
        /// </summary>
        public Utente()
        {

        }

        /// <summary>
        /// Creates a new Utente, taking parameters
        /// </summary>
        /// <param name="lou"></param>
        /// <param name="pn"></param>
        /// <param name="cc"></param>
        /// <param name="dc"></param>
        /// <param name="nc"></param>
        /// <param name="ts"></param>
        /// <param name="sbd"></param>
        public Utente(int pn, string cc, Medico dc, int nc, bool ts, bool sbd)
        {
            patientNumber = pn;
            clinicalCase = cc;
            doctor = dc;//Code of the doctor seeing to the patient
            nurseCode = nc;
            triageState = ts;
            seenByDoctor = sbd;
        }
        #endregion

        #region Methods
        //remover utente nao é apagar, é teve alta, ou desativar, e por no historico do doente...
        //metodos a começar por maiuscula, variaveis por minuscula
        //fora com os voids
        //fazer overrides



        #region Properties
        /// <summary>
        /// Gets patient number for an Utente
        /// </summary>
        public int PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }

        /// <summary>
        /// Gets Clinical case for an Utente
        /// </summary>
        public string ClinicalCase
        {
            get { return clinicalCase; }
            set { clinicalCase = value; }
        }

        /// <summary>
        /// Gets doctor code for an Utente
        /// </summary>
        public Medico Doctor
        {
            get { return doctor; }
            set { doctor = value; }
        }

        /// <summary>
        /// Gets nurse code for an Utente
        /// </summary>
        public int NurseCode
        {
            get { return nurseCode; }
            set { nurseCode = value; }
        }

        /// <summary>
        /// Gets triage state for an Utente
        /// </summary>
        public bool TriageState
        {
            get { return triageState; }
            set
            {
                if (value == true || value == false)
                    triageState = value;
            }
        }

        /// <summary>
        /// Gets triage state for an Utente
        /// </summary>
        public bool SeenByDoctor
        {
            get { return seenByDoctor; }
            set
            {
                if (value == true || value == false)
                    seenByDoctor = value;
            }
        }

        /// <summary>
        /// If true, utente is currently not discharged.
        /// </summary>
        public bool Active
        {
            get { return active; }
            set
            {
                if (value == true || value == false)
                    active = value;
            }
        }

        #endregion


        #endregion
        #endregion
    }
}
