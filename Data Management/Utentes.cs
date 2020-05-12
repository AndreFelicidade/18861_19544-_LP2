using System;
using System.Collections.Generic;
using System.Linq;
using DataManagement;
using DataManagement.CustomExceptions;

///<copyright file = "Utentes.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace DataManagement
{
    public class Utentes
    {
        /// <summary>
        /// Where utentes are stored
        /// </summary>
        public static List<Utente> utentes = new List<Utente>();

        #region Methods

        /// <summary>
        /// Adding an utente to the list
        /// </summary>
        public bool AddUtente(Utente utente)
        {
            try
            {
                if(String.IsNullOrEmpty(utente.name))
                {
                    throw new Exception("Invalid Name");
                }
                utentes.Add(utente);
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }
        }
        
    /// <summary>
    /// Printing all utentes
    /// </summary>
        public void ShowAllUtentes()
    {
        //Show all Utentes
        foreach (Utente u in utentes)
        {
            Console.WriteLine("Name: {0}\tBirthdate: {1}\tNHS Number: {2}\tGender:{3}\tLevel Of urgency:{4}"
        , u.name, u.birthDate, u.nhsNumber, u.gender, u.levelOfUrgency);
        }
    }


        /// <summary>
        /// Orders utentes by urgency level
        /// </summary>
        /// <returns></returns>
        public static bool OrderByUrgencyLevel()
        {
            try
            {
                if (utentes == null)
                {
                    throw new UtentesListNotFoundException();
                }
                utentes = utentes.OrderBy(x => x.levelOfUrgency).ToList();
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }
        }
    #endregion

}
}
