using System;
using System.Data;
using System.Data.SqlClient;
using DU_AN_CUOI_KI_OOP.Models;

namespace DU_AN_CUOI_KI_OOP.Data
{
    public class AppointmentRepository
    {
        public bool AddAppointment(Appointment appointment)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"INSERT INTO Appointments (DoctorId, DoctorName, PatientId, PatientName, StartTime, EndTime) 
                               VALUES (@DoctorId, @DoctorName, @PatientId, @PatientName, @StartTime, @EndTime)";
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorId", appointment.DoctorId);
                    cmd.Parameters.AddWithValue("@DoctorName", appointment.DoctorName);
                    cmd.Parameters.AddWithValue("@PatientId", appointment.PatientId);
                    cmd.Parameters.AddWithValue("@PatientName", appointment.PatientName);
                    cmd.Parameters.AddWithValue("@StartTime", appointment.StartTime);
                    cmd.Parameters.AddWithValue("@EndTime", appointment.EndTime);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetAllAppointments()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Appointments";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public bool UpdateAppointment(Appointment appointment)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"UPDATE Appointments 
                               SET DoctorName = @DoctorName, 
                                   PatientName = @PatientName, 
                                   StartTime = @StartTime, 
                                   EndTime = @EndTime 
                               WHERE DoctorId = @DoctorId AND PatientId = @PatientId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorId", appointment.DoctorId);
                    cmd.Parameters.AddWithValue("@DoctorName", appointment.DoctorName);
                    cmd.Parameters.AddWithValue("@PatientId", appointment.PatientId);
                    cmd.Parameters.AddWithValue("@PatientName", appointment.PatientName);
                    cmd.Parameters.AddWithValue("@StartTime", appointment.StartTime);
                    cmd.Parameters.AddWithValue("@EndTime", appointment.EndTime);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteAppointment(string doctorId, string patientId)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "DELETE FROM Appointments WHERE DoctorId = @DoctorId AND PatientId = @PatientId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                    cmd.Parameters.AddWithValue("@PatientId", patientId);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}