using _01_dapper.Models;
using Microsoft.Data.SqlClient;

namespace _01_dapper.Services.Interfaces
{
    public interface IDarbuotojasService
    {
        internal Darbuotojas CreateEmployee(string aK,
            string vardas,
            string pavarde,
            DateTime dirbaNuo,
            DateTime gimimoMetai,
            string pareigos,
            string skyrius,
            int projektoId);
        internal IEnumerable<Darbuotojas> GetEmployeeBySurename(SqlConnection connection, string pavarde);
        internal void AddEmployee(SqlConnection connection, Darbuotojas newEmployee);
        internal void UpdateEmployees(SqlConnection connection, string pavarde, string newPareigos);
        internal void DeleteEmployeeByPersonalCode(SqlConnection connection, string ak);
    }
}
