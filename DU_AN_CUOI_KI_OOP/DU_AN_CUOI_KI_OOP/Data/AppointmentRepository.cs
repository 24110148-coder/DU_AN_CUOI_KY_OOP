using DU_AN_CUOI_KI_OOP.Models;
using System.Collections.Generic;
using System.Linq;

namespace DU_AN_CUOI_KI_OOP.Data
{
    public class AppointmentRepository
    {
        private readonly List<Appointment> _appointments = new List<Appointment>();
        private int _nextId = 1; // 👉 biến để sinh Id tự động

        public void AddAppointment(Appointment appointment)
        {
            appointment.Id = _nextId++;  // 👉 mỗi lần add sẽ gán Id mới
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
    }
}
