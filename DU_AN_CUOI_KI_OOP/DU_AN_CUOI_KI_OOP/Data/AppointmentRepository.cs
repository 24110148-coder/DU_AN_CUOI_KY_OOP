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
            var d1 = new Doctor { Id = 1, Name = "Dr. Nguyen Van An", Specialty = "Cardiology" };
            var d2 = new Doctor { Id = 2, Name = "Dr. Tran Thi Binh", Specialty = "Neurology" };
            var d3 = new Doctor { Id = 3, Name = "Dr. Le Hoang Cuong", Specialty = "Pediatrics" };

            var p1 = Patient.FromType("Normal", 101, "Pham Van Dung", 32, "Healthy check-up");
            var p2 = Patient.FromType("Inpatient", 102, "Nguyen Thi Phi", 45, "Admitted for observation");
            var p3 = Patient.FromType("Outpatient", 103, "Le Van Nam", 28, "Follow-up for cold");
            var p4 = Patient.FromType("Emergency", 104, "Tran Thi Giang", 55, "Emergency surgery");

            _appointments.Add(new Appointment
            {
                Id = 1,
                Doctor = d1,
                Patient = p1,
                StartTime = DateTime.Today.AddHours(8),
                EndTime = DateTime.Today.AddHours(9),
                Date = DateTime.Today,
                Notes = "Routine check-up"
            });
            _appointments.Add(new Appointment
            {
                Id = 2,
                Doctor = d2,
                Patient = p2,
                StartTime = DateTime.Today.AddHours(9),
                EndTime = DateTime.Today.AddHours(10.5),
                Date = DateTime.Today,
                Notes = "MRI scheduled"
            });
            _appointments.Add(new Appointment
            {
                Id = 3,
                Doctor = d3,
                Patient = p3,
                StartTime = DateTime.Today.AddHours(10.5),
                EndTime = DateTime.Today.AddHours(11.5),
                Date = DateTime.Today.AddDays(1),
                Notes = "Cold follow-up"
            });
            _appointments.Add(new Appointment
            {
                Id = 4,
                Doctor = d1,
                Patient = p4,
                StartTime = DateTime.Today.AddHours(14),
                EndTime = DateTime.Today.AddHours(15.5),
                Date = DateTime.Today.AddDays(-1),
                Notes = "Emergency operation completed"
            });
        }
    }

}
