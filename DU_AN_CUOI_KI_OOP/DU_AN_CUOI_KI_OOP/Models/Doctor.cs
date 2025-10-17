namespace DU_AN_CUOI_KI_OOP.Models
{
    public class Doctor : Person
    {
        public virtual string SpecialtyType => "internal medicine";
        public static Doctor FromSpecialty(string specialty, int id, string name)
        {
            var key = (specialty ?? "internal medicine").Trim().ToLowerInvariant();
            switch (key)
            {
                case "surgical":
                    return new SurgicalDoctor { Id = id, Name = name };
                case "internal medicine":
                default:
                    return new InternalMedicineDoctor { Id = id, Name = name };

            }
        }
    }
}
