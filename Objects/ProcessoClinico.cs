﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "ProfissionalDeSaude.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace Objects
{
    public class ProcessoClinico
    {
        #region State Of Class
        /// <summary>
        /// Initializing attributes
        /// </summary>
        public Triagem triage;//consulta medica tambem tem triagem?
        public ConsultaMedica doctorAppointment;
        

        #endregion

        #region Behavior

        #region Builder

        /// <summary>
        /// Builder for processo clinico
        /// </summary>
        /// <param name="tr"></param>
        /// <param name="da"></param>
        public ProcessoClinico(Triagem tr, ConsultaMedica da)
        {
            triage = tr;
            doctorAppointment = da;
        }
        #endregion

        #region Methods

        #region Properties


        /// <summary>
        /// Gets triage stats 
        /// </summary>
        public Triagem Triage
        {
            get { return triage; }
            set { triage = value; }
        }

        /// <summary>
        /// something something doctor appointment
        /// </summary>
        public ConsultaMedica DoctorAppointment
        {
            get { return doctorAppointment; }
            set { doctorAppointment = value; }
        }
        #endregion


        #endregion
        #endregion
    }
}