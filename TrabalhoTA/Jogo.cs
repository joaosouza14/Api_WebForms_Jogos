using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoTA
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
