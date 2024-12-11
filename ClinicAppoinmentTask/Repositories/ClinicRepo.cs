﻿using ClinicAppoinmentTask.Model;

namespace ClinicAppoinmentTask.Repositories
{
    public class ClinicRepo
    {
        private readonly AppDbContext _context;

        public ClinicRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddClinic(Clinic clinic)
        {   
            _context.Clinics.Add(clinic);
            _context.SaveChanges();
        }

        public IEnumerable<Clinic>GetClinics() => _context.Clinics.ToList();

        public void RemoveClinic(Clinic clinic)
        {
            _context.Clinics?.Remove(clinic);
            _context.SaveChanges();
        }

        public void UpdateClinic(Clinic clinic) 
        {
            _context.Clinics.Update(clinic);
            _context.SaveChanges();
        }

    }
}
