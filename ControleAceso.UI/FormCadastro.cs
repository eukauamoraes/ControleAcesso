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
            Usuario usuario = new(txtNome.Text, txtCpf.Text, cmbTipo.Text, txtSenha.Text);
            usuario.Inserir();
            txtId.Text = usuario.Id.ToString();
            MessageBox.Show($"Usuário {usuario.Nome} gravado com sucesso com o ID {usuario.Id}");
            FormCadastro_Load(sender, e);

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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
            
        }
    }
}
        
  
  
