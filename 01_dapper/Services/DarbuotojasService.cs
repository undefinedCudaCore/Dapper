using _01_dapper.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace _01_dapper.Services
{
    internal class DarbuotojasService
    {
        internal Darbuotojas CreateEmployee(
            string aK,
            string vardas,
            string pavarde,
            DateTime dirbaNuo,
            DateTime gimimoMetai,
            string pareigos,
            string skyrius,
            int projektoId)
        {
            var newEmployee = new Darbuotojas(
                aK,
                vardas,
                pavarde,
                dirbaNuo,
                gimimoMetai,
                pareigos,
                skyrius,
                projektoId);

            return newEmployee;
        }

        internal IEnumerable<Darbuotojas> GetEmployeeBySurename(SqlConnection connection, string pavarde)
        {
            var sql = "EXECUTE [getAllFromDarbuotojasWherePavarde_exNo8] @pavarde";
            var values = new
            {
                @pavarde = pavarde
            };

            var gotAnEmployee = connection.Query<Darbuotojas>(sql, values);

            return gotAnEmployee;
        }

        internal void AddEmployee(SqlConnection connection, Darbuotojas newEmployee)
        {
            var sql = "EXECUTE [addDarbuotojasInfoIntoDarbuotojas_exNo10] @ak, @vardas, @pavarde, @dirbaNuo, @gimimoMetai, @pareigos, @skyrius, @projektoId";
            var values = new
            {
                @ak = newEmployee.AsmensKodas,
                @vardas = newEmployee.Vardas,
                @pavarde = newEmployee.Pavarde,
                @dirbaNuo = newEmployee.DirbaNuo,
                @gimimoMetai = newEmployee.GimimoMetai,
                @pareigos = newEmployee.Pareigos,
                @skyrius = newEmployee.SkyriausPavadinimas,
                @projektoId = newEmployee.ProjektoId
            };
            var data = connection.Query<Darbuotojas>(sql, values);
        }
        internal void UpdateEmployee(SqlConnection connection)
        {

        }
        internal void DeleteEmployee(SqlConnection connection)
        {

        }

        internal void PrintInformation()
        {

        }
    }
}
