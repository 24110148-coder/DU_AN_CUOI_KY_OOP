namespace DU_AN_CUOI_KI_OOP.Models
{
    public class Outpatient : Patient
    {
        // Có thể mở rộng: VisitReason...
        public override string PatientType => "Outpatient";
    }
}
