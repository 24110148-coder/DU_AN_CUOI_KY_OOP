namespace DU_AN_CUOI_KI_OOP.Models
{
    public class Inpatient : Patient
    {
        // Có thể mở rộng: RoomNumber, AdmissionDate...
        public override string PatientType => "Inpatient";
    }
}
