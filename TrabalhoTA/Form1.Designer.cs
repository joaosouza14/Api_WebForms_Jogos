namespace TrabalhoTA
{
    partial class JogosPlayStation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomeTxt = new System.Windows.Forms.TextBox();
            this.NomeDeleteTxt = new System.Windows.Forms.TextBox();
            this.AdicionarBtn = new System.Windows.Forms.Button();
            this.ListarBtn = new System.Windows.Forms.Button();
            this.DeletarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdadeTxt = new System.Windows.Forms.TextBox();
            this.AnoTxt = new System.Windows.Forms.TextBox();
            this.ModeloPsTxt = new System.Windows.Forms.TextBox();
            this.PrecoTxt = new System.Windows.Forms.TextBox();
            this.AlterarBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeTxt
            // 
            this.NomeTxt.Location = new System.Drawing.Point(128, 25);
            this.NomeTxt.Name = "NomeTxt";
            this.NomeTxt.Size = new System.Drawing.Size(332, 23);
            this.NomeTxt.TabIndex = 0;
            this.NomeTxt.TextChanged += new System.EventHandler(this.NomeTxt_TextChanged);
            // 
            // NomeDeleteTxt
            // 
            this.NomeDeleteTxt.Location = new System.Drawing.Point(58, 197);
            this.NomeDeleteTxt.Name = "NomeDeleteTxt";
            this.NomeDeleteTxt.Size = new System.Drawing.Size(383, 23);
            this.NomeDeleteTxt.TabIndex = 2;
            // 
            // AdicionarBtn
            // 
            this.AdicionarBtn.Location = new System.Drawing.Point(466, 25);
            this.AdicionarBtn.Name = "AdicionarBtn";
            this.AdicionarBtn.Size = new System.Drawing.Size(149, 61);
            this.AdicionarBtn.TabIndex = 3;
            this.AdicionarBtn.Text = "Adicionar";
            this.AdicionarBtn.UseVisualStyleBackColor = true;
            this.AdicionarBtn.Click += new System.EventHandler(this.AdicionarBtn_Click);
            // 
            // ListarBtn
            // 
            this.ListarBtn.Location = new System.Drawing.Point(466, 252);
            this.ListarBtn.Name = "ListarBtn";
            this.ListarBtn.Size = new System.Drawing.Size(149, 23);
            this.ListarBtn.TabIndex = 4;
            this.ListarBtn.Text = "Listar";
            this.ListarBtn.UseVisualStyleBackColor = true;
            this.ListarBtn.Click += new System.EventHandler(this.ListarBtn_Click);
            // 
            // DeletarBtn
            // 
            this.DeletarBtn.Location = new System.Drawing.Point(466, 194);
            this.DeletarBtn.Name = "DeletarBtn";
            this.DeletarBtn.Size = new System.Drawing.Size(149, 29);
            this.DeletarBtn.TabIndex = 5;
            this.DeletarBtn.Text = "Deletar";
            this.DeletarBtn.UseVisualStyleBackColor = true;
            this.DeletarBtn.Click += new System.EventHandler(this.DeletarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adicionar jogo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista de Jogos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Deletar jogo";
            // 
            // IdadeTxt
            // 
            this.IdadeTxt.Location = new System.Drawing.Point(128, 54);
            this.IdadeTxt.Name = "IdadeTxt";
            this.IdadeTxt.Size = new System.Drawing.Size(332, 23);
            this.IdadeTxt.TabIndex = 12;
            this.IdadeTxt.TextChanged += new System.EventHandler(this.IdadeTxt_TextChanged);
            // 
            // AnoTxt
            // 
            this.AnoTxt.Location = new System.Drawing.Point(128, 83);
            this.AnoTxt.Name = "AnoTxt";
            this.AnoTxt.Size = new System.Drawing.Size(332, 23);
            this.AnoTxt.TabIndex = 13;
            this.AnoTxt.TextChanged += new System.EventHandler(this.AnoTxt_TextChanged);
            // 
            // ModeloPsTxt
            // 
            this.ModeloPsTxt.Location = new System.Drawing.Point(128, 112);
            this.ModeloPsTxt.Name = "ModeloPsTxt";
            this.ModeloPsTxt.Size = new System.Drawing.Size(332, 23);
            this.ModeloPsTxt.TabIndex = 14;
            this.ModeloPsTxt.TextChanged += new System.EventHandler(this.ModeloPsTxt_TextChanged);
            // 
            // PrecoTxt
            // 
            this.PrecoTxt.Location = new System.Drawing.Point(128, 141);
            this.PrecoTxt.Name = "PrecoTxt";
            this.PrecoTxt.Size = new System.Drawing.Size(332, 23);
            this.PrecoTxt.TabIndex = 15;
            this.PrecoTxt.TextChanged += new System.EventHandler(this.PrecoTxt_TextChanged);
            // 
            // AlterarBtn
            // 
            this.AlterarBtn.Location = new System.Drawing.Point(466, 103);
            this.AlterarBtn.Name = "AlterarBtn";
            this.AlterarBtn.Size = new System.Drawing.Size(149, 61);
            this.AlterarBtn.TabIndex = 17;
            this.AlterarBtn.Text = "Alterar";
            this.AlterarBtn.UseVisualStyleBackColor = true;
            this.AlterarBtn.Click += new System.EventHandler(this.AlterarBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(603, 255);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Idade Minima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ano Lançamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Modelo Playstation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Preço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nome";
            // 
            // JogosPlayStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 640);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AlterarBtn);
            this.Controls.Add(this.PrecoTxt);
            this.Controls.Add(this.ModeloPsTxt);
            this.Controls.Add(this.AnoTxt);
            this.Controls.Add(this.IdadeTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeletarBtn);
            this.Controls.Add(this.ListarBtn);
            this.Controls.Add(this.AdicionarBtn);
            this.Controls.Add(this.NomeDeleteTxt);
            this.Controls.Add(this.NomeTxt);
            this.Name = "JogosPlayStation";
            this.Text = "Jogos PlayStation";
            this.Load += new System.EventHandler(this.JogosPlayStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NomeTxt;
        private TextBox NomeDeleteTxt;
        private Button AdicionarBtn;
        private Button ListarBtn;
        private Button DeletarBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox IdadeTxt;
        private TextBox AnoTxt;
        private TextBox ModeloPsTxt;
        private TextBox PrecoTxt;
        private Button AlterarBtn;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}