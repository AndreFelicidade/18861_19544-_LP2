using Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Control
{
    /// <summary>
    /// Class that that dictates how the user accesses the data of nurses
    /// </summary>
    class DoctorRules
    {
        private CustomComparer comparer = new CustomComparer();

        /// <summary>
        /// Adds a doctor to the system list after validating it 
        /// </summary>
        /// <param name="med"></param>
        /// <returns></returns>
        public int AddDoctor(Medico med)
        {
            ValidateDoctor(med);
            Medicos.AddMedico(med);
            return med.doctorCode;
        }

        /// <summary>
        /// Compares a new doctor to doctors already registered
        /// </summary>
        /// <param name="med"></param>
        public void ValidateDoctor(Medico med)
        {
            if (Medicos.medicos.Any(y => comparer.Compare(y, med) == -1))
            {
                throw new Exception("Medico already exists!");
            }
        }

        /// <summary>
        /// returns list of all doctors
        /// </summary>
        /// <returns></returns>
        public List<Medico> SeeRegisteredDoctors()
        {
            return Medicos.medicos;
        }

        /// <summary>
        /// Enables editing of the information of a doctor
        /// </summary>
        /// <param name="med"></param>
        /// <param name="birthDate"></param>
        /// <param name="nhsNumber"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="address"></param>
        /// <param name="docCode"></param>
        /// <param name="specialty"></param>
        /// <param name="avaliable"></param>
        /// <returns></returns>
        public Medico EditingDoctor(Medico med, DateTime birthDate, int nhsNumber, string name,
            string gender, string address, int docCode, string specialty, bool avaliable)
        {
            Medicos.EditDoctor(med, birthDate, nhsNumber, name,
                gender, address, docCode, specialty, avaliable);
            return med;
        }

        /// <summary>
        /// Gets the doctor list ordered by specialty, readies it to send to the front end layer
        /// </summary>
        /// <returns></returns>
        public List<Medico> OrderDoctorBySpecialty()
        {
            if (Medicos.OrderBySpecialty() == true)
            {
                return Medicos.medicos;
            }
            else
            {
                throw new Exception();
            }
        }

    }
}
