namespace DU_AN_CUOI_KI_OOP.Models
{
    public class EmergencyPatient : Patient
    {
        // Có thể mở rộng: EmergencyLevel (Red/Yellow/Green)...
        public override string PatientType => "Emergency";
    }
}
