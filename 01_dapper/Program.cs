using _01_dapper.Services;
using Microsoft.Data.SqlClient;

namespace _01_dapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=LENOVOY520\\SQLEXPRESS;Initial Catalog=Testing_Database;" +
                 "Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var darbuotojasService = new DarbuotojasService();
                var newEmployee = darbuotojasService.CreateEmployee("123456", "Jurgis", "Antaninas", DateTime.Parse("2000-06-06"), DateTime.Parse("1999-05-08"), "NeSargas", "JavaScript", 2);

                //darbuotojasService.AddEmployee(connection, newEmployee);
                //var sabutis = darbuotojasService.GetEmployeeBySurename(connection, "Sabutis");

            }
        }
    }
}
