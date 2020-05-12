using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement;
using DataManagement.CustomExceptions;

///<copyright file = "Enfermeiros.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace DataManagement
{
    class Enfermeiros
    {

        /// <summary>
        /// Where enfermeiros are stored
        /// </summary>
        public static List<Enfermeiro> enfermeiros = new List<Enfermeiro>();

        #region Methods

        /// <summary>
        /// Adding an enfermeiro to the list
        /// </summary>
        public bool AddEnfermeiro(Enfermeiro enf)
        {
            try
            {
                if (String.IsNullOrEmpty(enf.name))
                {
                    throw new Exception("Invalid Name");
                }
                enfermeiros.Add(enf);
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Printing all enfermeiros
        /// </summary>
        public void ShowAllNurses()
        {
            //Show all Utentes
            foreach (Enfermeiro e in enfermeiros)
            {
                Console.WriteLine("Name: {0}\tBirthdate: {1}\tNHS Number: {2}\tGender:{3}\tNurse Code:{4}\tSpecialty:{5}"
            , e.name, e.birthDate, e.nhsNumber, e.gender,e.nurseCode, e.specialty);
            }
        }

        /// <summary>
        /// Orders Enfermeiros by specialty
        /// </summary>
        /// <returns></returns>
        public static bool OrderBySpecialty()
        {
            try
            {
                if (enfermeiros == null)
                {
                    throw new EnfermeirosListNotFoundException();
                }
                enfermeiros = enfermeiros.OrderBy(x => x.specialty).ToList();
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Gets avaliable number of nurses
        /// </summary>
        /// <returns></returns>
        public int GetAvaliableNurses()
        {
            
        }
    }
}
