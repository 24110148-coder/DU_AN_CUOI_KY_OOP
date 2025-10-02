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
        public string Notes { get; set; }

        // Thêm thuộc tính để tiện lấy DoctorName, PatientName (đóng gói dữ liệu)
        public int DoctorId => Doctor?.Id ?? 0;
        public string DoctorName => Doctor?.Name ?? "";
        public int PatientId => Patient?.Id ?? 0;
        public string PatientName => Patient?.Name ?? "";
    }
}
