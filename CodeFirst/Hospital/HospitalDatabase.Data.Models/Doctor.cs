﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalDatabase.Data.Models
{
    public class Doctor
    {
        public Doctor()
        {
            this.Visitations = new List<Visitation>();
        }

        public int DoctorId { get; set; }

        public string Name { get; set; }

        public string Speciality { get; set; }

        public ICollection<Visitation> Visitations { get; set; }
    }
}
