using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers;
using System;
using System.Net;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;


namespace TrabalhoTA
{
    public partial class JogosPlayStation : Form
    {
        public JogosPlayStation()
        {
            InitializeComponent();
        }

        string URL = "";
        public static string _urlBase = "https://localhost:7262/Jogo";

        private void JogosPlayStation_Load(object sender, EventArgs e)
        {

        }

        private async void ListarBtn_Click(object sender, EventArgs e)
        {

            URL = _urlBase + "/listaJogos";

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jogoJsonString = await response.Content.ReadAsStringAsync();
                        dataGridView1.DataSource = JsonConvert.DeserializeObject<Jogo[]>(jogoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter os jogos : " + response.StatusCode);
                    }
                }
            }
        }

        private async void AdicionarBtn_Click(object sender, EventArgs e)
        {
            URL = _urlBase + "/adicionaJogo";
            Jogo jogo = new Jogo();
            jogo.Nome = NomeTxt.Text;
            jogo.IdadeMinima = int.Parse(IdadeTxt.Text);
            jogo.AnoLancamento = int.Parse(AnoTxt.Text);
            jogo.ModeloPlaystation = int.Parse(ModeloPsTxt.Text);
            jogo.Preco = double.Parse(PrecoTxt.Text);
            using (var client = new HttpClient())
            {
                var serializedJogo = JsonConvert.SerializeObject(jogo);
                var content = new StringContent(serializedJogo, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URL, content);

                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Jogo adicionado na lista com sucesso");
                }
                else
                {

                    MessageBox.Show("Falha ao adicionar o Jogo  : " + result.IsSuccessStatusCode);
                }
            }

        }

        private async void DeletarBtn_Click(object sender, EventArgs e)
        {
            URL = _urlBase + "/remove/" + NomeDeleteTxt.Text;
            string NomeJogo = NomeDeleteTxt.Text;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format(URL, NomeJogo));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Jogo excluído da lista com sucesso");
                }
                else
                {

                    MessageBox.Show("Falha ao excluir o Jogo  : " + responseMessage.StatusCode);
                }
            }
        }

        private async void AlterarBtn_Click(object sender, EventArgs e)
        {


            URL = _urlBase + "/alterar";
            Jogo jogo = new Jogo();

            jogo.Nome = NomeTxt.Text;
            jogo.IdadeMinima = int.Parse(IdadeTxt.Text);
            jogo.AnoLancamento = int.Parse(AnoTxt.Text);
            jogo.ModeloPlaystation = int.Parse(ModeloPsTxt.Text);
            jogo.Preco = double.Parse(PrecoTxt.Text);

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URL + "/" + jogo.Nome, jogo);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Jogo atualizado" + responseMessage.StatusCode);
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o jogo : " + responseMessage.StatusCode);
                }

            }         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IdadeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModeloPsTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomeTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
