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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void Inicial_Load(object sender, EventArgs e)
        {

        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {

        }

        private void bntCadastro_Click(object sender, EventArgs e)
        {


            {

                FormCadastro formCadastro = new();

                formCadastro.Show();

                this.Hide();

            }

        }

        private void bntRegistros_Click(object sender, EventArgs e)
        {
            RegistroTeste registroTeste = new();

            registroTeste.Show();

            this.Hide();
           


        }
    }
}
