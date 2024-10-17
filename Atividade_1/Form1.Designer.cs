namespace Atividade_1
{
    partial class Form1
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
            label1 = new Label();
            txtDataInicial = new TextBox();
            btnDataAtual = new Button();
            txtAno = new TextBox();
            txtMeses = new TextBox();
            txtDias = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRemover = new Button();
            btnAdicionar = new Button();
            label5 = new Label();
            txtDataFinal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "Incira a data inicial";
            // 
            // txtDataInicial
            // 
            txtDataInicial.Location = new Point(12, 37);
            txtDataInicial.Name = "txtDataInicial";
            txtDataInicial.Size = new Size(227, 31);
            txtDataInicial.TabIndex = 1;
            // 
            // btnDataAtual
            // 
            btnDataAtual.Location = new Point(245, 34);
            btnDataAtual.Name = "btnDataAtual";
            btnDataAtual.Size = new Size(267, 34);
            btnDataAtual.TabIndex = 2;
            btnDataAtual.Text = "Data Atual";
            btnDataAtual.UseVisualStyleBackColor = true;
            btnDataAtual.Click += btnDataAtual_Click;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(105, 148);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(134, 31);
            txtAno.TabIndex = 3;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(105, 111);
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(134, 31);
            txtMeses.TabIndex = 4;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(105, 74);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(134, 31);
            txtDias.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 77);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 6;
            label2.Text = "Dias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 148);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 7;
            label3.Text = "Anos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 114);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 8;
            label4.Text = "Meses";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(385, 71);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(127, 178);
            btnRemover.TabIndex = 9;
            btnRemover.Text = "Remover Data";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(245, 71);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(127, 178);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar Data";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 190);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 11;
            label5.Text = "Data final";
            // 
            // txtDataFinal
            // 
            txtDataFinal.Location = new Point(12, 218);
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.ReadOnly = true;
            txtDataFinal.Size = new Size(227, 31);
            txtDataFinal.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 281);
            Controls.Add(txtDataFinal);
            Controls.Add(label5);
            Controls.Add(btnAdicionar);
            Controls.Add(btnRemover);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDias);
            Controls.Add(txtMeses);
            Controls.Add(txtAno);
            Controls.Add(btnDataAtual);
            Controls.Add(txtDataInicial);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDataInicial;
        private Button btnDataAtual;
        private TextBox txtAno;
        private TextBox txtMeses;
        private TextBox txtDias;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRemover;
        private Button btnAdicionar;
        private Label label5;
        private TextBox txtDataFinal;
    }
}