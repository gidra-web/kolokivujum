using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class StudentRepository
    {
        public List<Student> GetAllStudents()
        {
            List<Student> result=new List<Student>();
            using(SqlConnection sqlConnection=new SqlConnection(Constant.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Students";

                SqlDataReader sqlDataReader=sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Student s = new Student();
                    s.Id = sqlDataReader.GetInt32(0);   //kolone krecu od 0
                    s.Name = sqlDataReader.GetString(1);
                    s.InexNumber = sqlDataReader.GetString(2);
                    s.AverageMark = sqlDataReader.GetDecimal(3);

                    result.Add(s);
                }
            }

            return result;
        }
        public int InsertStudent(Student s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                SqlCommand sqlCommand=new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = 
                    string.Format("INSERT INTO Students VALUES('{0}','{1}',{2})",s.Name,s.InexNumber,s.AverageMark);  //placeholders

                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
