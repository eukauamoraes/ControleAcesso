namespace ControleAceso.UI
{
    partial class RegistrodeAcesso
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Saida = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 124);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Entrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 170);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Saida";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(279, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(279, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(293, 73);
            label4.Name = "label4";
            label4.Size = new Size(164, 18);
            label4.TabIndex = 15;
            label4.Text = "Registro de Acesso";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(279, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(76, 23);
            textBox3.TabIndex = 16;
            textBox3.Text = "Filtrar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Saida, Column2 });
            dataGridView1.Location = new Point(210, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(363, 139);
            dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.HeaderText = "Usuario";
            Column1.Name = "Column1";
            Column1.Width = 120;
            // 
            // Saida
            // 
            Saida.HeaderText = "Entrada";
            Saida.Name = "Saida";
            Saida.Width = 120;
            // 
            // Column2
            // 
            Column2.HeaderText = "Saida";
            Column2.Name = "Column2";
            Column2.Width = 120;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(524, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(398, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(79, 23);
            textBox4.TabIndex = 19;
            textBox4.Text = "Salvar";
            // 
            // RegistrodeAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrodeAcesso";
            Text = "RegistrodeAcesso";
            Load += RegistrodeAcesso_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Saida;
        private DataGridViewTextBoxColumn Column2;
        private TextBox textBox4;
    }
}