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
            SkyriausPavadinimas = skyriausPavadinimas;
            ProjektoId = projektoId;
        }

        public string AsmensKodas { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateTime DirbaNuo { get; set; }
        public DateTime GimimoMetai { get; set; }
        public string Pareigos { get; set; }
        public string SkyriausPavadinimas { get; set; }
        public int ProjektoId { get; set; }
    }
}
