using Objects;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Control
{
    /// <summary>
    /// Class that dictates how the user accesses the data of utentes
    /// </summary>
    class UtenteRules
    {
        private CustomComparer comparer = new CustomComparer();

        /// <summary>
        /// Adds a doctor to the system list after validating it 
        /// </summary>
        /// <param name="med"></param>
        /// <returns></returns>
        public int AddUtente(Utente u)
        {
            ValidateUtente(u);
            Utentes.AddUtente(u);
            return u.nhsNumber;
        }

        /// <summary>
        /// Compares a new utente to utentes already registered
        /// </summary>
        /// <param name="u"></param>
        public void ValidateUtente(Utente u)
        {
            if (Utentes.utentes.Any(y => comparer.Compare(y, u) == -1))
            {
                throw new Exception("Utente already exists!");
            }
        }

        /// <summary>
        /// returns list of all utentes
        /// </summary>
        /// <returns></returns>
        public List<Utente> SeeRegisteredUtentes()
        {
            return Utentes.utentes;
        }

        /// <summary>
        /// Enables editing of the information of an utente
        /// </summary>
        /// <param name="u"></param>
        /// <param name="birthDate"></param>
        /// <param name="nhsNumber"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="address"></param>
        /// <param name="patNum"></param>
        /// <param name="cP"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public Utente EditingUtente(Utente u, DateTime birthDate, int nhsNumber, string name,
           string gender, string address, int patNum, ProcessoClinico cP, bool active)
        {
            Utentes.EditUtente(u, birthDate, nhsNumber, name,
                gender, address, patNum, cP, active);
            return u;
        }

        /// <summary>
        /// Gets the utente list ordered by the nhs number, readies it to send to the front end layer
        /// </summary>
        /// <returns></returns>
        public List<Utente> OrderUtenteByNhsNumber()
        {
            if (Utentes.OrderByNhsNumber() == true)
            {
                return Utentes.utentes;
            }
            else
            {
                throw new Exception();
            }
        }

    }
}

