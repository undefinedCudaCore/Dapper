namespace _01_dapper.Models
{
    internal class Darbuotojas
    {
        public Darbuotojas()
        {
        }

        public Darbuotojas(string asmensKodas, string vardas, string pavarde, DateTime dirbaNuo, DateTime gimimoMetai, string pareigos, string skyriausPavadinimas, int projektoId)
        {
            AsmensKodas = asmensKodas;
            Vardas = vardas;
            Pavarde = pavarde;
            DirbaNuo = dirbaNuo;
            GimimoMetai = gimimoMetai;
            Pareigos = pareigos;
            Skyrius_pavadinimas = skyriausPavadinimas;
            Projektas_Id = projektoId;
        }

        public string AsmensKodas { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateTime DirbaNuo { get; set; }
        public DateTime GimimoMetai { get; set; }
        public string Pareigos { get; set; }
        public string Skyrius_pavadinimas { get; set; }
        public int Projektas_Id { get; set; }
    }
}
