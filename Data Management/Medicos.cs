using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects;

///<copyright file = "Medicos.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace Objects
{
    class Medicos
    {
        /// <summary>
        /// Where medicos are stored
        /// </summary>
        public static List<Medico> medicos = new List<Medico>();

        #region Methods

        /// <summary>
        /// Adding an utente to the list
        /// </summary>
        public bool AddMedico(Medico med)
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
        /// Printing all medicos
        /// </summary>
        public void ShowAllMedicos()
        {
            //Show all medicos
            foreach (Medico m in medicos)
            {
                Console.WriteLine("Name: {0}\tBirthdate: {1}\tNHS Number: {2}\tGender:{3}\tDoctor Code:{4}\tSpecialty:{5}"
            , m.name, m.birthDate, m.nhsNumber, m.gender,m.doctorCode, m.specialty);
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
        /// Gets doctors that aren't busy
        /// </summary>
        /// <returns></returns>
        public List<Medico> GetAvaliableDoctors()
        {

            return medicos.Where(medico => medico.avaliable).ToList();
        }

        #endregion
    }
}
