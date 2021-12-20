using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerShop.Models;

namespace DataAccessLayerShop
{
    public class ProductRepository
    {
        public List<Product> GetAllProducts()
        {
            List<Product> result = new List<Product>();
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Products";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Product p = new Product();
                    p.Id = sqlDataReader.GetInt32(0);   //kolone krecu od 0
                    p.Name = sqlDataReader.GetString(1);
                    p.Description = sqlDataReader.GetString(2);
                    p.ExpireDate = sqlDataReader.GetDateTime(3);

                    result.Add(p);
                }
            }

            return result;
        }

        public int InsertProduct(Product p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constant.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Products VALUES('{0}','{1}','{2}')", p.Name, p.Description, p.ExpireDate);  //placeholders

                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
