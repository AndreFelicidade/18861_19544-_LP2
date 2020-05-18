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

namespace Objects
{
    /// <summary>
    /// Class of triagem
    /// </summary>
    
    public class Triagem
    {
        /// <summary>
        /// Levels of urgency attributed in triagem, red = 0, is the most serious one
        /// blue = 4, least serious one
        /// </summary>
        public enum LevelsOfUrgency : ushort
        {
            Red = 0,
            Orange = 1,
            Yellow = 2,
            Green = 3,
            Blue = 4
        }

        #region State Of Class
        /// <summary>
        /// Initializing attributes
        /// </summary>
        protected Enfermeiro nurse;
        protected string symptoms;
        protected float temperature;
        protected float bloodPressure;
        protected Utente utente;
        protected DateTime time;
        protected LevelsOfUrgency levelOfUrgency;
        #endregion

        #region Behavior

        #region Builder
        /// <summary>
        /// Builder for triagem
        /// </summary>
        /// <param name="nc"></param>
        /// <param name="lou"></param>
        /// <param name="symp"></param>
        /// <param name="temp"></param>
        /// <param name="bp"></param>
        public Triagem(Enfermeiro nc, Utente u, string symp, float temp, float bp, LevelsOfUrgency lou, DateTime t)
        {
            nurse = nc;
            symptoms = symp;
            temperature = temp;
            bloodPressure = bp;
            utente = u;
            time = t;
            levelOfUrgency = lou;
        }
        #endregion

        #region Methods


        #region Properties


        /// <summary>
        /// Gets nurse for triagem 
        /// </summary>
        public Enfermeiro Nurse
        {
            get { return nurse; }
            set { nurse = value; }
        }

        /// <summary>
        /// Gets time for triagem 
        /// </summary>
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        /// <summary>
        /// Gets level of urgency of patient for triagem 
        /// </summary>
        public LevelsOfUrgency LevelOfUrgency
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
