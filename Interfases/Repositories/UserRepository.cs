using Interfaces;
using Models;
using System.Data.SqlClient;
using Data;


namespace Repositories
{
    public class UserRepository : IUserRepository
    {
       private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# GUI\Interfases\DataBase\Database.mdf;Integrated Security=True";
        public bool UserLogin(User user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * [User] WHERE Name =" + user.Name + "AND" + user.Password + "Password = @Password ", sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                sqlCommand.ExecuteNonQuery();
                if (reader.HasRows)
                {
                    reader.Close();
                    DataUser.Name = reader.GetString(2);
                    DataUser.Role = reader.GetString(4);
                    return true;
                }
                reader.Close();
                return false;



            }

        }
    }
}
