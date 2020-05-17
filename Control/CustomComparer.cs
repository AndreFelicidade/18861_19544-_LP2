using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement;



namespace Control
{
    /// <summary>
    /// This class introduces object comparison
    /// </summary>
    class CustomComparer : IComparer
    {
        /// <summary>
        /// Compares 2 Objects
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(object x, object y)
        {
            //Checks if both objects are of type Utente and compares them if first condition is true
            if(x.GetType() == typeof(Utente)&& y.GetType() == typeof(Utente))
            {
                string n1 = ((Utente)x).name;
                string n2 = ((Utente)y).name;
                int nhs1 = ((Utente)x).nhsNumber;
                int nhs2 = ((Utente)y).nhsNumber;
                DateTime birth1 = ((Utente)x).birthDate;
                DateTime birth2 = ((Utente)y).birthDate;
                //if utente data is the same, returns -1
                if ( n1 == n2 && nhs1 == nhs2 && birth1 == birth2)
                {
                    return -1;
                }
            }
            //Checks if both objects are of type Medico and compares them if first condition is true
            if (x.GetType() == typeof(Medico) && y.GetType() == typeof(Medico))
            {
                string dspec1 = ((Medico)x).specialty;
                string dspec2 = ((Medico)y).specialty;
                int dcode1 = ((Medico)x).doctorCode;
                int dcode2 = ((Medico)y).doctorCode;
                //if doctor data is the same, returns -1
                if ( dspec1 == dspec2 && dcode1 == dcode2)
                {
                    return -1;
                }
            }
            //Checks if both objects are of type Enfermeiro and compares them if first condition is true
            if (x.GetType() == typeof(Enfermeiro) && y.GetType() == typeof(Enfermeiro))
            {
                string nsp1 = ((Enfermeiro)x).specialty;
                string nsp2 = ((Enfermeiro)y).specialty;
                int ncode1 = ((Enfermeiro)x).nurseCode;
                int ncode2 = ((Enfermeiro)y).nurseCode;
                //if nurse data is the same, returns -1
                if (nsp1 == nsp2 && ncode1 == ncode2)
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
