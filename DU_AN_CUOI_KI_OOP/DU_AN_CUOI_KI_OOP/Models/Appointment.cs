using System;

namespace DU_AN_CUOI_KI_OOP.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        // Cột tiện cho GridView
        public int DoctorId => Doctor?.Id ?? 0;
        public string DoctorName => Doctor?.Name ?? "";
        public string Specialty => Doctor?.SpecialtyType ?? "";

        public int PatientId => Patient?.Id ?? 0;
        public string PatientName => Patient?.Name ?? "";
        public int Age => Patient?.Age ?? 0;
        public string PatientType => Patient?.PatientType ?? "";
    }
}
