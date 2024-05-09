using _01_dapper.Models;
using _01_dapper.Services.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace _01_dapper.Services
{
    internal class DarbuotojasService : IDarbuotojasService
    {
        public Darbuotojas CreateEmployee(
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

        public IEnumerable<Darbuotojas> GetEmployeeBySurename(SqlConnection connection, string pavarde)
        {
            var sql = "EXECUTE [getAllFromDarbuotojasWherePavarde_exNo8] @pavarde";
            var values = new
            {
                @pavarde = pavarde
            };

            var gotAnEmployee = connection.Query<Darbuotojas>(sql, values);

            return gotAnEmployee;
        }

        public void AddEmployee(SqlConnection connection, Darbuotojas newEmployee)
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
                @skyrius = newEmployee.Skyrius_pavadinimas,
                @projektoId = newEmployee.Projektas_Id
            };
            connection.Query<Darbuotojas>(sql, values);
        }

        public void UpdateEmployees(SqlConnection connection, string pavarde, string newPareigos)
        {
            var sql = "EXECUTE [updatePareigosWhereDarbuotojas_exNo15] @pavarde, @pareigos";
            var values = new
            {
                @pavarde = pavarde,
                @pareigos = newPareigos
            };
            connection.Query<Darbuotojas>(sql, values);
        }

        public void DeleteEmployeeByPersonalCode(SqlConnection connection, string ak)
        {
            var sql = "EXECUTE [removeFromDarbuotojasWhereAsmensKodas_exNo13] @ak";
            var values = new
            {
                @ak = ak
            };
            connection.Query<Darbuotojas>(sql, values);
        }

        internal void PrintInformation(IEnumerable<Darbuotojas> newEmployee)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Information about employee:");
            foreach (var employee in newEmployee)
            {
                Console.WriteLine($"Personal code: {employee.AsmensKodas}");
                Console.WriteLine($"Name: {employee.Vardas}");
                Console.WriteLine($"Surename: {employee.Pavarde}");
                Console.WriteLine($"Works from: {employee.DirbaNuo.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Birth date: {employee.GimimoMetai.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Job: {employee.Pareigos}");
                Console.WriteLine($"Department: {employee.Skyrius_pavadinimas}");
                Console.WriteLine($"Project ID: {employee.Projektas_Id}");
                Console.WriteLine("---------------");
            }
        }
    }
}
