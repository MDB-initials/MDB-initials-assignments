using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace notesCont.SQL
{
    public class CRUD
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());



        public string InsertPatient(Patient pt)
        {
            string message = "Successful insertion of record!";



            SqlCommand cmd = new SqlCommand("insert into PatientAppointments (name, address, gender, diagnosis, age, zip, SSN, state, appointment, symptoms) values ('" + pt.name + "','" + pt.address + "','" + pt.gender + "','" + pt.diagnosis + "','" + pt.age + "','" + pt.zip + "','" + pt.SSN + "','" + pt.state + "','" + pt.appointment + "','" + pt.symptoms + "')", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return message;
            }
            catch (Exception exception)
            {
                message = "Some error encountred.  Please report the following " + exception.Message + " Server Error of : " + exception.InnerException;
                return message;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetPatients()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from PatientAppointments", con);
            da.Fill(dt);
            return dt;

        }

        public string DeletePatient(int id)
        {
            string message = "Deletion successful!";
            SqlCommand cmd = new SqlCommand("delete from PatientAppointments where id='" + id + "'", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return message;
            }
            catch (Exception ex)
            {
                message = ex.Message + " the server error is: " + ex.InnerException;
                return message;
            }
            finally
            {
                con.Close();
            }
        }
        public String UpdatePatientRec(Patient pt)
        {
            string msg = "Update Successful";
            SqlCommand cmd = new SqlCommand("update PatientAppointments set name='" + pt.name + "',address='" + pt.address + "',gender='" + pt.gender + "',diagnosis='" + pt.diagnosis + "',age='" + pt.age + "',zip='" + pt.zip + "',SSN='" + pt.SSN + "',state='" + pt.state + "',appointment='" + pt.appointment + "',symptoms='" + pt.symptoms + "' where id='" + pt.ID + "'", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return msg;
            }
            catch (Exception ex)
            {
                msg = ex.Message + " " + ex.InnerException;
                return msg;
            }
            finally
            {
                con.Close();
            }
        }
        public String UpdatePatientRec(string chk, int id)
        {
            bool Gender = chk == "False" ? true : false;
            string msg = "Update Successful";
            SqlCommand cmd = new SqlCommand("update PatientAppointments set gender='" + Gender + "' where id = '"+ id + "'", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return msg;
            }
            catch (Exception ex)
            {
                msg = ex.Message + " " + ex.InnerException;
                return msg;
            }
            finally
            {
                con.Close();
            }
        }

        public Patient fetchPatient(int id)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from PatientAppointments where id = '" + id + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Patient pt = new Patient();
            pt.ID = id;
            pt.name = dt.Rows[0]["Name"].ToString();
            pt.address = dt.Rows[0]["Address"].ToString();
            pt.gender = bool.Parse(dt.Rows[0]["Gender"].ToString());
            pt.age = int.Parse(dt.Rows[0]["Age"].ToString());
            pt.zip = int.Parse(dt.Rows[0]["Zip"].ToString());
            pt.SSN = dt.Rows[0]["SSN"].ToString();
            pt.state = dt.Rows[0]["State"].ToString();
            pt.symptoms = dt.Rows[0]["Symptoms"].ToString();
            pt.appointment = dt.Rows[0]["Appointment"].ToString();
            return pt;
        }
    }
}
