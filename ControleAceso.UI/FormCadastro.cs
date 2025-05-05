using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleAcesso.Core;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControleAceso.UI
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string senha = txtSenha.Text;


            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(senha) )
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            string linha = $"{nome},{cpf},{senha}";
            string caminhoArquivo = @"C:\temp\usuarios.csv";

            try
            {
                // Verifica se o arquivo existe; se não, cria e adiciona o cabeçalho
                if (!File.Exists(caminhoArquivo))
                {
                    File.WriteAllText(caminhoArquivo, "Nome,CPF,Senha,Tipo\n");
                }

                // Adiciona a nova linha ao arquivo
                File.AppendAllText(caminhoArquivo, linha + Environment.NewLine);
                MessageBox.Show("Usuário salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

            

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        
  
  
