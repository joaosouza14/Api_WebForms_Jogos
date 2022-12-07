using JOGOS.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WEBAPIConsultaCEP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : ControllerBase
    {
        [HttpPost("adicionaJogo")]
        public IActionResult AdicionarJogo(Jogo jogo)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5001/api/v1/jogo");

            client.PostAsync("adicionaJogo", new StringContent(System.Text.Json.JsonSerializer.Serialize(jogo)));


            BancoDados.Tb_Jogos.Add(jogo);
            return Ok(jogo);
        }

        [HttpGet("listaJogos")]
        public IActionResult ListarJogos()
        {
            return Ok(BancoDados.Tb_Jogos);
        }

        [HttpDelete("remove/{nome}")]
        public IActionResult RemoverJogo(string nome)
        {
            var jogoParaRemover = BancoDados.Tb_Jogos.FirstOrDefault(x => x.Nome == nome);
            return Ok(BancoDados.Tb_Jogos.Remove(jogoParaRemover));
        }

        [HttpPut("alterar/{nome}")]
        public IActionResult Put(Jogo jogo)
        {
            var jogoParaAtualizar = BancoDados.Tb_Jogos.FirstOrDefault(x => x.Nome == jogo.Nome);
           
            if (jogoParaAtualizar == null) return NotFound();

            jogoParaAtualizar.Nome = jogo.Nome;
            jogoParaAtualizar.IdadeMinima = jogo.IdadeMinima;
            jogoParaAtualizar.AnoLancamento = jogo.AnoLancamento;
            jogoParaAtualizar.ModeloPlaystation = jogo.ModeloPlaystation;
            jogoParaAtualizar.Preco = jogo.Preco;
        
            return Ok();
        }
    }

    public static class BancoDados
    {
        public static List<Jogo> Tb_Jogos = new List<Jogo>
        {
                new Jogo { Nome = "Call Of Duty", IdadeMinima = 18, AnoLancamento = 2022, ModeloPlaystation = 5, Preco = 259.5 },
                new Jogo { Nome = "Far Cry", IdadeMinima = 18, AnoLancamento = 2020, ModeloPlaystation = 5, Preco = 259.5 }
        };
    }


}

