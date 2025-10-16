namespace DU_AN_CUOI_KI_OOP.Models
{
    public class Doctor : Person
    {
        public string Specialty { get; set; }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Chuyên khoa: {Specialty}";
        }
    }
}
