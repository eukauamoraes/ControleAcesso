namespace ControleAceso.UI
{
    partial class RegistroTeste
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
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            bntVoltar = new Button();
            textBox1 = new TextBox();
            bntConsultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(106, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 183);
            dataGridView1.TabIndex = 2;
            // 
            // bntVoltar
            // 
            bntVoltar.Location = new Point(466, 161);
            bntVoltar.Name = "bntVoltar";
            bntVoltar.Size = new Size(103, 23);
            bntVoltar.TabIndex = 3;
            bntVoltar.Text = "Voltar";
            bntVoltar.UseVisualStyleBackColor = true;
            bntVoltar.Click += bntVoltar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 4;
            // 
            // bntConsultar
            // 
            bntConsultar.Location = new Point(165, 161);
            bntConsultar.Name = "bntConsultar";
            bntConsultar.Size = new Size(104, 23);
            bntConsultar.TabIndex = 5;
            bntConsultar.Text = "Consultar";
            bntConsultar.UseVisualStyleBackColor = true;
            // 
            // RegistroTeste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntConsultar);
            Controls.Add(textBox1);
            Controls.Add(bntVoltar);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Name = "RegistroTeste";
            Text = "RegistroTeste";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button bntVoltar;
        private TextBox textBox1;
        private Button bntConsultar;
    }
}