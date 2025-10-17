using DU_AN_CUOI_KI_OOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DU_AN_CUOI_KI_OOP.Data
{
    public class AppointmentRepository
    {
        private static readonly BindingList<Appointment> _appointments = new BindingList<Appointment>();
        private static int _nextId = 1;

        public void AddAppointment(Appointment appointment)
        {
            appointment.Id = _nextId++;
            _appointments.Add(appointment);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            var existing = _appointments.FirstOrDefault(a => a.Id == appointment.Id);
            if (existing != null)
            {
                existing.Doctor = appointment.Doctor;
                existing.Patient = appointment.Patient;
                existing.StartTime = appointment.StartTime;
                existing.EndTime = appointment.EndTime;
                existing.Date = appointment.Date;
                existing.Notes = appointment.Notes;
            }
        }

        public void DeleteAppointment(int id)
        {
            var appt = _appointments.FirstOrDefault(a => a.Id == id);
            if (appt != null)
                _appointments.Remove(appt);
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _appointments;
        }

        public BindingList<Appointment> GetBindingList()
        {
            return _appointments;
        }

        static AppointmentRepository()
        {
            if (_appointments.Count == 0)
            {
                SeedSamples();
            }

            _nextId = _appointments.Any() ? _appointments.Max(a => a.Id) + 1 : 1;
        }

        private static void SeedSamples()
        {
            // ✅ Use factory method to ensure correct SpecialtyType
            var d1 = Doctor.FromSpecialty("Internal Medicine Doctor", 1, "Dr. Nguyen Van An");
            var d2 = Doctor.FromSpecialty("Surgical Doctor", 2, "Dr. Tran Thi Binh");
            var d3 = Doctor.FromSpecialty("Internal Medicine Doctor", 3, "Dr. Le Hoang Cuong");

            var p1 = Patient.FromType("First Visit", 101, "Pham Van Dung", 32, "Routine check-up");
            var p2 = Patient.FromType("Follow-up Visit", 102, "Nguyen Thi Phi", 45, "Post-operation visit");
            var p3 = Patient.FromType("General Check-up", 103, "Le Van Nam", 28, "Annual health screening");
            var p4 = Patient.FromType("First Visit", 104, "Tran Thi Giang", 55, "Initial consultation");

            _appointments.Add(new Appointment
            {
                Id = 1,
                Doctor = d1,
                Patient = p1,
                StartTime = DateTime.Today.AddHours(8),
                EndTime = DateTime.Today.AddHours(9),
                Date = DateTime.Today,
                Notes = "Routine blood test"
            });

            _appointments.Add(new Appointment
            {
                Id = 2,
                Doctor = d2,
                Patient = p2,
                StartTime = DateTime.Today.AddHours(9.5),
                EndTime = DateTime.Today.AddHours(10.5),
                Date = DateTime.Today,
                Notes = "Stitch removal follow-up"
            });

            _appointments.Add(new Appointment
            {
                Id = 3,
                Doctor = d3,
                Patient = p3,
                StartTime = DateTime.Today.AddHours(11),
                EndTime = DateTime.Today.AddHours(12),
                Date = DateTime.Today.AddDays(1),
                Notes = "Full body check-up"
            });

            _appointments.Add(new Appointment
            {
                Id = 4,
                Doctor = d1,
                Patient = p4,
                StartTime = DateTime.Today.AddHours(14),
                EndTime = DateTime.Today.AddHours(15),
                Date = DateTime.Today.AddDays(-1),
                Notes = "Consultation for fatigue symptoms"
            });
        }
    }
}
