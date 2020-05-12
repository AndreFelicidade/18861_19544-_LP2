
using System.Collections;
///<copyright file = "Urgencia.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>
namespace DataManagement
{
    /// <summary>
    /// This class manages utentes that arrive on Urgencia
    /// </summary>
    public class Urgencia
    {


        #region Behavior
        /// <summary>
        /// Urgency level 1 queue
        /// Up to 4 hours of waiting
        /// </summary>
        Queue lv1Q = new Queue();

        /// <summary>
        /// Urgency level 2 queue
        /// Up to 1 hour of waiting
        /// </summary>
        Queue lv2Q = new Queue();

        /// <summary>
        /// Urgency level 3 queue
        /// Up to 30 minutes of wait
        /// </summary>
        Queue lv3Q = new Queue();

        /// <summary>
        /// Urgency level 4 queue
        /// Up to 10 minutes of wait
        /// </summary>
        Queue lv4Q = new Queue();

       
        
        /// <summary>
        /// Finds urgency level of an utente and attributes it to the respective queue
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int FindUrgencyLevel(Utente u)
        {
            if (u.levelOfUrgency > 4)
            {
                //Immediate consultation
            }

            else if (u.levelOfUrgency > 3)
            {
                lv4Q.Enqueue(u);
            }

            else if (u.levelOfUrgency > 2)
            {
                lv3Q.Enqueue(u);
            }

            else if (u.levelOfUrgency > 1)
            {
                lv2Q.Enqueue(u);
            }

            else if (u.levelOfUrgency > 0)
            {
                lv1Q.Enqueue(u);
            }
            return 0;
        }

        
        #region Builders
        /// <summary>
        /// Builder by omission
        /// </summary>
        public Urgencia()
        {

        }

        
        #endregion
        #endregion
    }
}
