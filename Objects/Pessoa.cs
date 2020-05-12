using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "Pessoa.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace DataManagement
{
    public class Pessoa
    {

        #region Class state
        /// <summary>
        /// Initializing attributes of Pessoa
        /// </summary>
        public DateTime birthDate;
        public int nhsNumber;
        public string name;
        public string gender;
        public string address;
        #endregion



        #region Behavior
        #region Builders
        /// <summary>
        /// Builder by omission
        /// </summary>
        public Pessoa()
        {

        }

        /// <summary>
        /// Builder of Pessoa
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="nn"></param>
        /// <param name="gen"></param>
        /// <param name="addr"></param>
        public Pessoa(string n, DateTime a, int nn, string gen, string addr)
        {
            name = n;
            birthDate = a;
            nhsNumber = nn;
            gender = gen;
            address = addr;
        }
        #endregion

        #region Methods
        
        #region Properties
        /// <summary>
        /// Property to manipulate name of person
        /// </summary>
        /// <returns></returns>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Property to manipulate age of person, validates 
        /// whether the date is valid in a way that the date 
        /// has to be from today( for a newborn ) or earlier than today
        /// </summary>
        /// <returns></returns>
        public DateTime BirthDate
        {
            get { return birthDate; }
            set {if (value <= DateTime.Today) 
                birthDate = value; }
        }

        /// <summary>
        /// Property to manipulate gender of person
        /// </summary>
        /// <returns></returns>
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        /// <summary>
        /// Property to manipulate national health system number of person
        /// </summary>
        /// <returns></returns>
        public int NhsNumber
        {
            get { return nhsNumber; }
            set { nhsNumber = value; }
        }

        /// <summary>
        /// Property to manipulate address of person
        /// </summary>
        public string Adress
        {
            get { return address; }
            set { address = value; }
        }
        #endregion
        #endregion
        #endregion
    }
}
