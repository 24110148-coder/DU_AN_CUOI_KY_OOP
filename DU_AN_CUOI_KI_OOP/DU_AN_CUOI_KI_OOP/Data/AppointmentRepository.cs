using DU_AN_CUOI_KI_OOP.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DU_AN_CUOI_KI_OOP.Data
{
    public class AppointmentRepository
    {
        // ✅ static: dữ liệu tồn tại chung cho toàn bộ app, dùng BindingList để DatagridView tự động cập nhật
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

        // Cung cấp nguồn dữ liệu dạng BindingList cho binding trực tiếp
        public BindingList<Appointment> GetBindingList()
        {
            return _appointments;
        }
    }

}
