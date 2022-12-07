namespace JOGOS.API.Models
{
    public class Jogo
    {

        public string Nome { get; set; }
        public int IdadeMinima { get; set; }
        public int AnoLancamento { get; set; }
        public int ModeloPlaystation { get; set; }
        public double Preco { get; set; }
    }
}
