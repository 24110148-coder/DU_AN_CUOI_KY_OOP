using System;

namespace DU_AN_CUOI_KI_OOP.Models
{
    public class Patient : Person
    {
        public int Age { get; set; }
        public string Notes { get; set; }
        public virtual string PatientType => "First Visit";

        public static Patient FromType(string type, int id, string name, int age, string notes = "")
        {
            var key = (type ?? "First Visit").Trim().ToLowerInvariant();

            switch (key)
            {
                case "follow-up visit":
                    return new Followupvisit { Id = id, Name = name, Age = age, Notes = notes };
                case "general check-up":
                    return new Generalcheckup { Id = id, Name = name, Age = age, Notes = notes };
                case "first visit":
                default:
                    return new Firstvisit { Id = id, Name = name, Age = age, Notes = notes };
            }
        }
    }
}
