namespace ControleAceso.UI
{
    partial class Inicial
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
            btnRegistro = new Button();
            bntRegistros = new Button();
            SuspendLayout();
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(397, 197);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(99, 23);
            btnRegistro.TabIndex = 0;
            btnRegistro.Text = "Cadastro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += bntCadastro_Click;
            // 
            // bntRegistros
            // 
            bntRegistros.Location = new Point(227, 197);
            bntRegistros.Name = "bntRegistros";
            bntRegistros.Size = new Size(75, 23);
            bntRegistros.TabIndex = 1;
            bntRegistros.Text = "Registro";
            bntRegistros.UseVisualStyleBackColor = true;
            bntRegistros.Click += bntRegistros_Click;
            // 
            // Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntRegistros);
            Controls.Add(btnRegistro);
            Name = "Inicial";
            Text = "Inicial";
            Load += Inicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistro;
        private Button bntRegistros;
    }
}