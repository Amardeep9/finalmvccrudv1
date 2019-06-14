using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PracticingCrud.Models
{
    public class StudentDataAccessLayer
    {

        Student S1 = new Student();
        string connectionString = "Data Source=DELL;Initial Catalog=StudentManagementSystem; Integrated Security=true;";

        //To View all employees details    
        public List<Student> GetAllStudent()
        {
            List<Student> lststudent = new List<Student>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllStudentDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Student student = new Student();

                    student.StudentID = Convert.ToInt32(rdr["StudentID"]);
                    
                    student.FirstName = rdr["FirstName"].ToString();
                    student.LastName = rdr["LastName"].ToString();
                    student.Address= rdr["Address"].ToString();
                    student.City = rdr["City"].ToString();
                    student.State = rdr["State"].ToString();
                    if(Convert.ToString(rdr["Mobile"])!="")
                    { 
                    student.Mobile = Convert.ToString(rdr["Mobile"]);
                    }
                    student.Emailid = rdr["Emailid"].ToString();


                    lststudent.Add(student);
                }
                con.Close();
            }
            return lststudent;
        }

        public void AddStudent(Student student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("FirstName",student.FirstName);
                cmd.Parameters.AddWithValue("LastName", student.LastName);
                cmd.Parameters.AddWithValue("Address", student.Address);
                cmd.Parameters.AddWithValue("City", student.City);
                cmd.Parameters.AddWithValue("State", student.State);
                cmd.Parameters.AddWithValue("Mobile", student.Mobile);
                cmd.Parameters.AddWithValue("Emailid", student.Emailid);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudentData", con);
                cmd.CommandType = CommandType.StoredProcedure;

                
                cmd.Parameters.AddWithValue("@StudentID",student.StudentID);
                cmd.Parameters.AddWithValue("FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("LastName", student.LastName);
                cmd.Parameters.AddWithValue("Address", student.Address);
                cmd.Parameters.AddWithValue("City", student.City);
                cmd.Parameters.AddWithValue("State", student.State);
                cmd.Parameters.AddWithValue("Mobile", student.Mobile);
                cmd.Parameters.AddWithValue("Emailid", student.Emailid);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteStudent(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudentDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        public Student GetStudentData(int? id)
        {
            Student student = new Student();


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetStudentbyID", con);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentID", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {


                    student.StudentID = Convert.ToInt32(rdr["StudentID"]);
                    student.FirstName = rdr["FirstName"].ToString();
                    student.LastName = rdr["LastName"].ToString();
                    student.Address = rdr["Address"].ToString();
                    student.City = rdr["City"].ToString();
                    student.State = rdr["State"].ToString();
                    student.Mobile = Convert.ToString(rdr["Mobile"]);
                    student.Emailid = rdr["Emailid"].ToString();

                }
            }
            return student;
        }
        
       

    }
}