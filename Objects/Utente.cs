using System;



///<copyright file = "Utente.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>
///<summary>This class is for the object Utente, which does X and Y</summary>

namespace Objects
{
    [Serializable]
    public class Utente : Pessoa
    {
        #region State Of Class
        /// <summary>
        /// Initializing attributes
        /// </summary>
        public int patientNumber;
        public bool active;
        public ProcessoClinico clinicalProcess;

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
        /// <param name="pn"></param>
        /// <param name="ac"></param>
        /// <param name="dc"></param>

        public Utente(int pn, bool ac, ProcessoClinico pc)
        {
            patientNumber = pn;
            active = ac;
            clinicalProcess = pc;
        }
        #endregion

        #region Methods
        //remover utente nao é apagar, é teve alta, ou desativar, e por no historico do doente...
        //metodos a começar por maiuscula, variaveis por minuscula
        //fora com os voids
        //fazer overrides

        #region Overrides
        public override string ToString()
        {
            return "Utente:" + name + " " + birthDate;
        }
        #endregion






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
        public ProcessoClinico ClinicalProcess
        {
            get { return clinicalProcess; }
            set { clinicalProcess = value; }
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
