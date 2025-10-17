using System;

namespace DU_AN_CUOI_KI_OOP.Models
{
    // Person của bạn đã có Id/Name → Patient kế thừa Person
    public class Patient : Person
    {
        public int Age { get; set; }
        public string Notes { get; set; } = "";

        // Cho phép đa hình
        public virtual string PatientType => "Normal";

        public override string GetInfo()
        {
            return base.GetInfo() + $", Age: {Age}";
        }

        /// <summary>
        /// Factory tạo đúng lớp con theo text từ ComboBox.
        /// Hỗ trợ: Normal / Inpatient / Outpatient / Emergency
        /// </summary>
        public static Patient FromType(string type, int id, string name, int age, string notes = "")
        {
            var key = (type ?? "Normal").Trim().ToLowerInvariant();
            switch (key)
            {
                case "inpatient": return new Inpatient { Id = id, Name = name, Age = age, Notes = notes };
                case "outpatient": return new Outpatient { Id = id, Name = name, Age = age, Notes = notes };
                case "emergency": return new EmergencyPatient { Id = id, Name = name, Age = age, Notes = notes };
                case "normal":
                default: return new NormalPatient { Id = id, Name = name, Age = age, Notes = notes };
            }
        }
    }
}
