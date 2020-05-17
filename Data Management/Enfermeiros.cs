using Objects.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;

///<copyright file = "Enfermeiros.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace Objects
{
    public class Enfermeiros
    {

        /// <summary>
        /// Where enfermeiros are stored
        /// </summary>
        public static List<Enfermeiro> enfermeiros = new List<Enfermeiro>();

        #region Methods
        /// <summary>
        /// returns list of nurses
        /// </summary>
        /// <returns></returns>
        public static List<Enfermeiro> GetList()
        {
            return enfermeiros;
        }
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
        public List<Enfermeiro> GetAvaliableNurses()
        {

            return enfermeiros.Where(enfermeiro => enfermeiro.avaliable).ToList();
        }

        /// <summary>
        /// Allows editing of the data of a nurse
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
        public static void EditNurse(Enfermeiro enf, DateTime birthDate, int nhsNumber, string name,
            string gender, string address, int nurseCode, string specialty, bool avaliable)
        {
            enf.birthDate = birthDate;
            enf.nhsNumber = nhsNumber;
            enf.name = name;
            enf.gender = gender;
            enf.address = address;
            enf.avaliable = avaliable;
            enf.specialty = specialty;
            enf.nurseCode = nurseCode;
        }

        #endregion
    }
}