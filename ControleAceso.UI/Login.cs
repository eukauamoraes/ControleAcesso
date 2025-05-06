using ControleAceso;
using ControleAcesso.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace ControleAceso.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {




            var usuario = Usuario.EfetuarLogin(txtUsuario.Text, txtSenha.Text);

            if (usuario != null && usuario.Ativo)

            {




                if (usuario.Id > 0)

                {

                    if (usuario.Ativo)

                    {

                        FormCadastro formcadastrar = new();

                        formcadastrar.Show();

                        this.Hide();

                    }

                    else

                    {

                        MessageBox.Show("Sua conta está inativa.\nProcure o administrador.", "Conta inativa");

                    }

                }

                else

                {

                    MessageBox.Show("Usuario ou senha incorretos ou inexistentes!", "Erro de Login");

                }


            }
        }
    }
}
 
        
            



        
    

