namespace DU_AN_CUOI_KI_OOP.Models
{
    public class Patient : Person
    {
        public int Age { get; set; }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Tuổi: {Age}";
        }
    }
}
