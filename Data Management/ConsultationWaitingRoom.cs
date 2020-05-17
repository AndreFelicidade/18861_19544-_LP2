using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
    public class ConsultationWaitingRoom
    {
        #region Behavior
        /// <summary>
        /// Urgency level 1 queue
        /// Up to 4 hours of waiting
        /// </summary>
        Queue<Triagem> lv1Q = new Queue<Triagem>();

        /// <summary>
        /// Urgency level 2 queue
        /// Up to 1 hour of waiting
        /// </summary>
        Queue<Triagem> lv2Q = new Queue<Triagem>();

        /// <summary>
        /// Urgency level 3 queue
        /// Up to 30 minutes of wait
        /// </summary>
        Queue<Triagem> lv3Q = new Queue<Triagem>();

        /// <summary>
        /// Urgency level 4 queue
        /// Up to 10 minutes of wait
        /// </summary>
        Queue<Triagem> lv4Q = new Queue<Triagem>();

        /// <summary>
        /// Urgency level 5 queue
        /// Immediate
        /// </summary>
        Queue<Triagem> lv5Q = new Queue<Triagem>();

        /// <summary>
        /// Adds triagem to the respective queue
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public void AddTriagemForMedicConsultation(Triagem t)
        {
            switch (t.LevelOfUrgency)
            {
                case Triagem.LevelsOfUrgency.Red:
                    lv5Q.Enqueue(t);
                    break;
                case Triagem.LevelsOfUrgency.Orange:
                    lv4Q.Enqueue(t);
                    break;
                case Triagem.LevelsOfUrgency.Yellow:
                    lv3Q.Enqueue(t);
                    break;
                case Triagem.LevelsOfUrgency.Green:
                    lv2Q.Enqueue(t);
                    break;
                case Triagem.LevelsOfUrgency.Blue:
                    lv1Q.Enqueue(t);
                    break;
            }
        }

        public Triagem NextPatient()
        {
            if (lv5Q.Count > 0)
            {
                return lv5Q.Dequeue();
            }
            else if (lv4Q.Count > 0)
            {
                return lv4Q.Dequeue();
            }
            else if (lv3Q.Count > 0)
            {
                return lv3Q.Dequeue();
            }
            else if (lv2Q.Count > 0)
            {
                return lv2Q.Dequeue();
            }
            else if (lv1Q.Count > 0)
            {
                return lv1Q.Dequeue();
            }

            return null;
        }
        /// <summary>
        /// ListWaitingRoom
        /// </summary>
        public List<Triagem> ListWaitingRoom()
        {
            List<Triagem> a = lv5Q.ToList();
            List<Triagem> b = lv4Q.ToList();
            List<Triagem> c = lv3Q.ToList();
            List<Triagem> d = lv2Q.ToList();
            List<Triagem> e = lv1Q.ToList();
            return a.Concat(b).Concat(c).Concat(d).Concat(e).ToList();
        }

        #region Builders
        /// <summary>
        /// Builder by omission
        /// </summary>
        public ConsultationWaitingRoom()
        {

        }


        #endregion
        #endregion
    }
}
