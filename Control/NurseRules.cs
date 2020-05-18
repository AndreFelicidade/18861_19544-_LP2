using Objects;
using System;
using System.Collections.Generic;
using System.Linq;

///<copyright file = "Program.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>
namespace Control
{
    /// <summary>
    /// Rules that dictate how the user accesses the data
    /// </summary>
    [Serializable]
    class NurseRules
    {
        [NonSerialized]
        private CustomComparer comparer = new CustomComparer();

        /// <summary>
        /// Adds a nurse to the system list after validating it 
        /// </summary>
        /// <param name="enf"></param>
        /// <returns></returns>
        public int AddNurse(Enfermeiro enf)
        {
            ValidateNurse(enf);
            Enfermeiros.AddNurse(enf);
            return enf.nurseCode;
        }

        /// <summary>
        /// Compares a new nurse to nurses already registered
        /// </summary>
        /// <param name="enf"></param>
        
        public void ValidateNurse(Enfermeiro enf)
        {
            if (Enfermeiros.enfermeiros.Any(y => comparer.Compare(y, enf) == -1))
            {
                throw new Exception("Nurse already exists!");
            }
        }

        /// <summary>
        /// returns list of all nurses
        /// </summary>
        /// <returns></returns>
        
        public List<Enfermeiro> SeeRegisteredNurses()
        {
            return Enfermeiros.enfermeiros;
        }

        /// <summary>
        /// Enables editing of the information of a nurse
        /// </summary>
        /// <param name="enf"></param>
        /// <param name="birthDate"></param>
        /// <param name="nhsNumber"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="address"></param>
        /// <param name="nurseCode"></param>
        /// <param name="specialty"></param>
        /// <param name="avaliable"></param>
        /// <returns></returns>
        public Enfermeiro EditingNurse(Enfermeiro enf, DateTime birthDate, int nhsNumber, string name,
            string gender, string address, int nurseCode, string specialty, bool avaliable)
        {
            Enfermeiros.EditNurse(enf, birthDate, nhsNumber, name,
                gender, address, nurseCode, specialty, avaliable);
            return enf;
        }

        /// <summary>
        /// Gets the nurse list ordered by specialty, readies it to send to the front end layer
        /// </summary>
        /// <returns></returns>
       
        public List<Enfermeiro> OrderNurseBySpecialty()
        {
            if (Enfermeiros.OrderBySpecialty() == true)
            {
                return Enfermeiros.enfermeiros;
            }
            else
            {
                throw new Exception();
            }
        }


    }
}
