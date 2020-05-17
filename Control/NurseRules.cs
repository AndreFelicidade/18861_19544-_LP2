using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects;

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
    [Serializable()]
    class NurseRules
    {
        private CustomComparer comparer = new CustomComparer();

        /// <summary>
        /// Compares a new nurse to nurses already registered
        /// </summary>
        /// <param name="enf"></param>
        public void ValidateNurse(Enfermeiro enf)
        {
            if(Enfermeiros.enfermeiros.Any(y => comparer.Compare(y,enf) == -1))
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

        public Enfermeiro EditingNurse(Enfermeiro enf, DateTime birthDate, int nhsNumber, string name,
            string gender, string address, int nurseCode, string specialty, bool avaliable)
        {
            Enfermeiros.EditNurse(enf, birthDate, nhsNumber, name,
                gender, address, nurseCode, specialty, avaliable);
            return enf;
        }
        
    }
}
