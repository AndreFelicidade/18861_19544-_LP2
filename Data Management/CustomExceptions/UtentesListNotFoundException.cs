using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.CustomExceptions
{
    /// <summary>
    /// Class that handles customs exceptions for list of Utente
    /// </summary>
    class UtentesListNotFoundException : ApplicationException
    {
        #region Constructors
        /// <summary>
        /// Sends to father class (ApplicationException) a message defined here (base(...))
        /// base calls for the builder in ApplicationException
        /// </summary>
        public UtentesListNotFoundException() : base("Utente list does not exist") { }

        /// <summary>
        /// gets message (string) and passes it to the base constructor
        /// </summary>
        /// <param name="message"></param>
        public UtentesListNotFoundException(string message) : base(message) { }

        /// <summary>
        /// Gets received <paramref name="innerException"/> and <paramref name="message"/>,
        /// and adds it to the base message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public UtentesListNotFoundException(string message, Exception innerException)
        {
            ///Throw here means creating a new exception
            throw new UtentesListNotFoundException(innerException.Message + message);
        }
        #endregion
    }
}