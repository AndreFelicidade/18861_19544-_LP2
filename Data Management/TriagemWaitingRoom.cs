// autor Rita Silva
// LESI

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public class TriagemWaitingRoom
    {
        Queue<Utente> queue = new Queue<Utente>();

        public void AddPatient(Utente u)
        {
            queue.Enqueue(u);
        }

        public Utente NextPatient()
        {
            return queue.Dequeue();

        }
         
        public List<Utente> ListUtentes()
        {
           return queue.ToList();

        }

    }
}
