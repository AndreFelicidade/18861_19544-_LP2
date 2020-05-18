using Objects.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

///<copyright file = "Enfermeiros.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace Objects
{
    /// <summary>
    /// Class that manages nurse data
    /// </summary>
    [Serializable]//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
    //Serialization is the process of converting an object into a stream of bytes 
    //to store the object or transmit it to memory, a database, or a file. 
    //Its main purpose is to save the state of an object in order to be able to recreate it when needed.
    //The reverse process is called deserialization.
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
        /// Static because i only need to work with the object nurse
        /// https://www.c-sharpcorner.com/article/when-to-use-static-classes-in-c-sharp/
        /// "All static members are called directly using the class name."
        /// Making them usefull for easy communication between the data management and business rules layer
        /// </summary>
        public static bool AddNurse(Enfermeiro enf)
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

        /// <summary>
        /// Save nurse data to file
        /// </summary>
        /// <returns></returns>
        public bool SaveNurses()
        {
            if (File.Exists(@"D:\IPCA\LP II\TP1LP2\TP2Files\NurseFile.bin"))
            {
                try
                {
                    Stream s = File.Open(@"D:\IPCA\LP II\TP1LP2\TP2Files\NurseFile.bin", FileMode.Create, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(s, enfermeiros);//serializing nurse list -> putting them in the binary file
                    s.Flush();//ending and
                    s.Close();//closing anything
                    s.Dispose();//file related
                    return true;
            }
                catch (Exception e)
                {
                    throw new Exception("WARNING: Something went wrong when saving nurse data!");
                    //MessageBox.Show(e.Message);

                }
            }
            return false;
        }

        /// <summary>
        /// Loads nurses from file
        /// </summary>
        public bool LoadNurses()
        {
           if(File.Exists(@"D:\IPCA\LP II\TP1LP2\TP2Files\NurseFile.bin"))
            {
                try
                {
                    Stream s = File.Open(@"D:\IPCA\LP II\TP1LP2\TP2Files\NurseFile.bin", FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    enfermeiros = (List<Enfermeiro>)bf.Deserialize(s);//Convert the saved data back into its collection type(List with the shape of Enfermeiro)
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