using System;

namespace Objects.CustomExceptions
{
    class MedicosListNotFoundException : ApplicationException
    {
        #region Constructors
        /// <summary>
        /// Sends to father class (ApplicationException) a message defined here (base(...))
        /// base calls for the builder in ApplicationException
        /// </summary>
        public MedicosListNotFoundException() : base("Doctor list does not exist") { }

        /// <summary>
        /// gets message (string) and passes it to the base constructor
        /// </summary>
        /// <param name="message"></param>
        public MedicosListNotFoundException(string message) : base(message) { }

        /// <summary>
        /// Gets received <paramref name="innerException"/> and <paramref name="message"/>,
        /// and adds it to the base message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public MedicosListNotFoundException(string message, Exception innerException)
        {
            ///Throw here means creating a new exception
            throw new UtentesListNotFoundException(innerException.Message + message);
        }
        #endregion
    }
}
