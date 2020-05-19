using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

///<copyright file = "Medicos.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace Objects
{
    /// <summary>
    /// Class that manages doctor data
    /// </summary>
    [Serializable]
    public class Medicos
    {
        /// <summary>
        /// Where medicos are stored
        /// </summary>
        public static List<Medico> medicos = new List<Medico>();

        #region Methods
        /// <summary>
        /// find doctor code
        /// </summary>
        public Medico FindDoctorID(int docCod)
        {
            return medicos.Find(u => u.doctorCode == docCod);

        }

        /// <summary>
        /// find for name and nhsnumber
        /// </summary>
        public Medico FindDoctorByNameAndNhsNumber(int nhsNumber, string name)
        {
            return medicos.Find(u => u.name == name && u.nhsNumber == nhsNumber);

        }

        /// <summary>
        /// returns list of nurses
        /// </summary>
        /// <returns></returns>
        public static List<Medico> GetList()
        {
            return medicos;
        }

        /// <summary>
        /// Adding a doctor to the list
        /// </summary>
        public static bool AddMedico(Medico med)
        {
            try
            {
                if (String.IsNullOrEmpty(med.name))
                {
                    throw new Exception("Invalid Name");
                }
                medicos.Add(med);
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }
        }


        /// <summary>
        /// Orders Medicos by specialty
        /// </summary>
        /// <returns></returns>
        public static bool OrderBySpecialty()
        {
            try
            {
                if (medicos == null)
                {
                    //throw new MedicosListNotFoundException();
                }
                medicos = medicos.OrderBy(x => x.specialty).ToList();
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Gets avaliable doctors
        /// </summary>
        /// <returns></returns>
        public List<Medico> GetAvaliableDoctors()
        {

            return medicos.Where(medico => medico.avaliable).ToList();
        }

        /// <summary>
        /// Enables editing of a doctors data
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="birthDate"></param>
        /// <param name="nhsNumber"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="address"></param>
        /// <param name="docCode"></param>
        /// <param name="specialty"></param>
        /// <param name="avaliable"></param>
        public static void EditDoctor(Medico doc, DateTime birthDate, int nhsNumber, string name,
            string gender, string address, int docCode, string specialty, bool avaliable)
        {
            doc.birthDate = birthDate;
            doc.nhsNumber = nhsNumber;
            doc.name = name;
            doc.gender = gender;
            doc.address = address;
            doc.avaliable = avaliable;
            doc.specialty = specialty;
            doc.doctorCode = docCode;
        }

        /// <summary>
        /// Save doctor data to file
        /// </summary>
        /// <returns></returns>
        public bool SaveDoctors()
        {
            if (File.Exists(@"D:\IPCA\LP II\TP1LP2\TP2Files\DoctorFile.bin"))
            {
                try
                {
                    Stream s = File.Open(@"D:\IPCA\LP II\TP1LP2\TP2Files\DoctorFile.bin", FileMode.Create, FileAccess.ReadWrite);
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(s, medicos);//serializing doctor list -> putting them in the binary file
                    s.Flush();//ending and
                    s.Close();//closing anything
                    s.Dispose();//file related
                    return true;
                }
                catch (Exception e)
                {
                    throw new Exception("WARNING: Something went wrong when saving doctor data!");
                    //MessageBox.Show(e.Message);

                }
            }
            return false;
        }

        /// <summary>
        /// Loads doctors from file
        /// </summary>
        public bool LoadNurses()
        {
            if (File.Exists(@"D:\IPCA\LP II\TP1LP2\TP2Files\DoctorFile.bin"))
            {
                try
                {
                    Stream s = File.Open(@"D:\IPCA\LP II\TP1LP2\TP2Files\DoctorFile.bin", FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    medicos = (List<Medico>)bf.Deserialize(s);//Convert the saved data back into its collection type(List with the shape of Enfermeiro)
                    s.Flush();//ending and
                    s.Close();//closing anything
                    s.Dispose();//file related
                    return true;
                }
                catch (Exception e)
                {
                    throw new Exception("WARNING: Something went wrong when loading doctor data!");
                    //MessageBox.Show(e.Message);

                }
            }
            return false;
        }

        #endregion
    }
}
