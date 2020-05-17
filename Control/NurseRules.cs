using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement;

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

        public void ValidateNurse(Enfermeiro enf)
        {
            if(Enfermeiros.enfermeiros.Any(y => comparer.Compare(y,enf) == -1))
            {
                throw new Exception("Nurse already exists!");
            }
        }

        

        
    }
}
