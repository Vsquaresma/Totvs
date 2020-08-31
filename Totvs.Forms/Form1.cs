using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Totvs.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string URI = "";
        int codigoPaciente = 1;

        private void btnObterPacientes_Click(object sender, EventArgs e)
        {
            GetAllPacientes();
        }

        private void btnPacientesPorId_Click(object sender, EventArgs e)
        {
            InputBox();
            if(codigoPaciente !=-1)
            {
                GetPacienteById(codigoPaciente);
            }
        }

        private void btnIncluirPaciente_Click(object sender, EventArgs e)
        {
             AddPaciente();
        }

        private void btnAtualizaPaciente_Click(object sender, EventArgs e)
        {
            InputBox();
            if (codigoPaciente != -1)
            {
                UpdatePaciente(codigoPaciente);
            }
        }

        private void btnDeletarPaciente_Click(object sender, EventArgs e)
        {
            InputBox();
            if (codigoPaciente != -1)
            {
                DeletePaciente(codigoPaciente);
            }
        }

        private void InputBox()
        {
            /* usando a função VB.Net para exibir um prompt para o usuário informar a senha */
            string Prompt = "Informe o código do Paciente.";
            string Titulo = "www.macoratti.net";
            string Resultado = Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "9", 600, 350);
            /* verifica se o resultado é uma string vazia o que indica que foi cancelado. */
            if (Resultado != "")
            {
                codigoPaciente = Convert.ToInt32(Resultado);
            }
            else
            {
                codigoPaciente = -1;
            }
        }
        //=================================métodos para acessar a Web API ------------------------------------------------------
        private async void GetAllPacientes()
        {
            URI = txtURI.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        //clienteUri = response.Headers.Location;
                        var PacienteJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Paciente[]>(PacienteJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o paciente : " + response.StatusCode);
                    }
                }
            }
        }

        private async void GetPacienteById(int codPaciente)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                 URI = txtURI.Text +"/"+ codPaciente.ToString();

                HttpResponseMessage response = await client.GetAsync(URI);
                 if (response.IsSuccessStatusCode)
                 {
                       var PacienteJsonString = await response.Content.ReadAsStringAsync();
                       bsDados.DataSource = JsonConvert.DeserializeObject<Paciente>(PacienteJsonString);
                       dgvDados.DataSource = bsDados;  
                 }
                 else
                 {
                     MessageBox.Show("Falha ao obter o paciente : " + response.StatusCode);
                 }
            }
        }

        private async void AddPaciente()
        {
            URI = txtURI.Text;
            Paciente prod = new Paciente();
            //prod.Id = codPaciente;
            prod.Nome = "Victor";
            prod.CPF = "092.045.826-26";
            prod.Sobrenome = "Soares Quaresma";
            prod.DataNascimento = DateTime.Parse("26/04/1993");
            prod.Sexo = "Masculino";
            prod.NomeMae = "Ghislaine";
            prod.Naturalidade = "Belo Horizonte 01";

            using (var client = new HttpClient())
            {
                var serializedPaciente = JsonConvert.SerializeObject(prod);
                var content = new StringContent(serializedPaciente, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
            GetAllPacientes();
        }

        private async void UpdatePaciente(int codPaciente)
        {
            URI = txtURI.Text;
            Paciente prod = new Paciente();
            prod.PacienteId = codPaciente;
            prod.Nome = "Victor";
            prod.CPF = "092.045.826-26";
            prod.Sobrenome = "Soares Quaresma";
            prod.DataNascimento = DateTime.Parse("26/04/1993");
            prod.Sexo = "Masculino";
            prod.NomeMae = "Ghislaine";
            prod.Naturalidade = "Belo Horizonte 02";

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + prod.PacienteId, prod);
                if (responseMessage.IsSuccessStatusCode)
                 {
                    MessageBox.Show("Paciente atualizado");
                 }
                else
                {
                    MessageBox.Show("Falha ao atualizar o paciente : " + responseMessage.StatusCode);
                }
            }
            GetAllPacientes();
        }


        private async void DeletePaciente(int codPaciente)
        {
            URI = txtURI.Text;
            int PacienteID = codPaciente;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, PacienteID));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Paciente excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o paciente  : " + responseMessage.StatusCode);
                }
            }
            GetAllPacientes();
        }
    }
}
