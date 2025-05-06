namespace ControleAceso.UI
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtCpf = new TextBox();
            btnSalvar = new Button();
            btnEditar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Cadastro = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            label5 = new Label();
            cmbTipo = new ComboBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(247, 112);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(241, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += textNome_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(247, 158);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(241, 23);
            txtSenha.TabIndex = 1;
            txtSenha.TextChanged += textSenha_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(247, 228);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(241, 23);
            txtCpf.TabIndex = 2;
            txtCpf.TextChanged += txtCpf_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(247, 292);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(328, 292);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Cadastro
            // 
            Cadastro.AutoSize = true;
            Cadastro.Location = new Point(318, 9);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(97, 15);
            Cadastro.TabIndex = 6;
            Cadastro.Text = "Cadastro Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 115);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 138);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 161);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 231);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 10;
            label4.Text = "Cpf";
            // 
            // txtId
            // 
            txtId.Location = new Point(247, 68);
            txtId.Name = "txtId";
            txtId.Size = new Size(241, 23);
            txtId.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 71);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 12;
            label5.Text = "Id";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Adminstrador" });
            cmbTipo.Location = new Point(381, 187);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(107, 23);
            cmbTipo.TabIndex = 13;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(413, 292);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 14;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrar);
            Controls.Add(cmbTipo);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cadastro);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(txtCpf);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Name = "FormCadastro";
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtCpf;
        private Button btnSalvar;
        private Button btnEditar;
        private ContextMenuStrip contextMenuStrip1;
        private Label Cadastro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private Label label5;
        private ComboBox cmbTipo;
        private Button btnEntrar;
    }
}