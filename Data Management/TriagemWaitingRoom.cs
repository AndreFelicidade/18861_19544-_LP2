// autor Rita Silva
// LESI

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataManagement
{
    /// <summary>
    /// class that manages a waiting room before patients are evaluated
    /// </summary>
    public class TriagemWaitingRoom
    {
        Queue<Utente> queue = new Queue<Utente>();
        /// <summary>
        /// Add patient that arrived to the queue
        /// </summary>
        /// <param name="u"></param>
        public void AddPatient(Utente u)
        {
            queue.Enqueue(u);
        }
        /// <summary>
        /// Remove patient from queue - is going to be evaluated
        /// </summary>
        /// <returns></returns>
        public Utente NextPatient()
        {
            return queue.Dequeue();
        }
    }
}
