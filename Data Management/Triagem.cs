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
    class Triagem
    {
        #region State Of Class
        /// <summary>
        /// Initializing attributes
        /// </summary>
        protected int nurseCode = 0;
        protected int levelOfUrgency = 0;
        protected string symptoms;
        protected float temperature = 0;
        protected float bloodPressure = 0;




        #endregion



        #region Behavior

        #region Builder

        /// <summary>
        /// Builder by omission
        /// </summary>
        public Triagem()
        {

        }

        /// <summary>
        /// Builder for triagem
        /// </summary>
        /// <param name="nc"></param>
        /// <param name="lou"></param>
        /// <param name="symp"></param>
        /// <param name="temp"></param>
        /// <param name="bp"></param>
        public Triagem(int nc, int lou, string symp, float temp, float bp)
        {
            nurseCode = nc;
            levelOfUrgency = lou;
            symptoms = symp;
            temperature = temp;
            bloodPressure = bp;
    }
        #endregion

        #region Methods
        public int SetUrgencyLevelOFUtente(Utente u)
        {
            u.levelOfUrgency = //nurse input
                return u.levelOfUrgency;
        }

        #region Properties


        /// <summary>
        /// Gets nurse code for triagem 
        /// </summary>
        public int NurseCode
        {
            get { return nurseCode; }
            set { nurseCode = value; }
        }

        /// <summary>
        /// Gets level of urgency of patient for triagem 
        /// </summary>
        public int LevelOfUrgency
        {
            get { return levelOfUrgency; }
            set { levelOfUrgency = value; }
        }

        /// <summary>
        /// Gets symptoms of patient for triagem
        /// </summary>
        public string Symptoms
        {
            get { return symptoms; }
            set { symptoms = value; }
        }

        /// <summary>
        /// Gets temperature of patient for triagem 
        /// </summary>
        public float Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        /// <summary>
        /// Gets blood pressure of patient for triagem 
        /// </summary>
        public float BloodPressure
        {
            get { return bloodPressure; }
            set { bloodPressure = value; }
        }
        #endregion


        #endregion
        #endregion
    }
}
