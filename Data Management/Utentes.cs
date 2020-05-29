using Objects.CustomExceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

///<copyright file = "Utentes.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace Objects
{
    /// <summary>
    /// Class that manages Utentes data
    /// </summary>
    [Serializable]
    public class Utentes
    {
        /// <summary>
        /// Where utentes are stored
        /// </summary>
        public static List<Utente> utentes = new List<Utente>();

        #region Methods
        /// <summary>
        /// find for IdUtente
        /// </summary>

        public Utente FindUtenteID(int patientNumber)
        {
            return utentes.Find(u => u.patientNumber == patientNumber);

        }
        /// <summary>
        /// find for name and nhsnumber
        /// </summary>

        public Utente FindUtenteName(int nhsNumber, string name)
        {
            return utentes.Find(u => u.name == name && u.nhsNumber == nhsNumber);

        }


        /// <summary>
        /// Adding an utente to the list
        /// </summary>
        public static bool AddUtente(Utente utente)
        {
            try
            {
                if (String.IsNullOrEmpty(utente.name))
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
        public Utente ShowAllUtentes()//
        {
            Utente ut = null;
            try
            {
                if (utentes == null)
                {
                    throw new UtentesListNotFoundException();
                }
                //Show all Utentes--not in windows form yet
                foreach (Utente u in utentes)
                {
                    return u;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return ut;
            }
            return ut;
        }




        /// <summary>
        /// Orders utentes by urgency level
        /// </summary>
        /// <returns></returns>
        public static bool OrderByNhsNumber()
        {
            try
            {
                if (utentes == null)
                {
                    throw new UtentesListNotFoundException();
                }
                utentes = utentes.OrderBy(x => x.nhsNumber).ToList();
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Allows editing of an utentes data
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
        public static void EditUtente(Utente u, DateTime birthDate, int nhsNumber, string name,
           string gender, string address, int patNum, ProcessoClinico cP, bool active)
        {
            u.birthDate = birthDate;
            u.nhsNumber = nhsNumber;
            u.name = name;
            u.gender = gender;
            u.address = address;
            u.active = active;
            u.clinicalProcess = cP;
            u.patientNumber = patNum;
        }


        /// <summary>
        /// List all clinical processes
        /// </summary>
        /// <returns></returns>
        public List<ProcessoClinico> AllClinicalProcess()
        {
            return utentes.Select(utente => utente.clinicalProcess).ToList();
        }


        /// <summary>
        /// Save utentes data to file
        /// </summary>
        /// <returns></returns>
        public bool SaveUtentes()
        {
            if (File.Exists(@"D:\IPCA\LP II\TP1LP2\TP2Files\UtentesFile.bin"))
            {
                try
                {
                    Stream s = File.Open(@"D:\IPCA\LP II\TP1LP2\TP2Files\UtentesFile.bin", FileMode.Create, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(s, utentes);//serializing utente list -> putting them in the binary file
                    s.Flush();//ending and
                    s.Close();//closing anything
                    s.Dispose();//file related
                    return true;
                }
                catch (Exception e)
                {
                    throw new Exception("WARNING: Something went wrong when saving utentes data!");
                    //MessageBox.Show(e.Message);

                }
            }
            return false;
        }

        /// <summary>
        /// Loads utentes from file
        /// </summary>
        public bool LoadUtentes()
        {
            if (File.Exists(@"D:\IPCA\LP II\TP1LP2\TP2Files\UtentesFile.bin"))
            {
                try
                {
                    Stream s = File.Open(@"D:\IPCA\LP II\TP1LP2\TP2Files\UtentesFile.bin", FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    utentes = (List<Utente>)bf.Deserialize(s);//Convert the saved data back into its collection type(List with the shape of Enfermeiro)
                    s.Flush();//ending and
                    s.Close();//closing anything
                    s.Dispose();//file related
                    return true;
                }
                catch (Exception e)
                {
                    throw new Exception("WARNING: Something went wrong when loading nurse data!");
                    //MessageBox.Show(e.Message);

                }
            }
            return false;
        }
        #endregion

    }
}
