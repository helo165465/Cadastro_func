namespace cadasfuncionario
{
    partial class forminicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.rb_lucro = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.rb_real = new System.Windows.Forms.RadioButton();
            this.rb_nacional = new System.Windows.Forms.RadioButton();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.rb_lucro);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.rb_real);
            this.panel3.Controls.Add(this.rb_nacional);
            this.panel3.Location = new System.Drawing.Point(64, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 462);
            this.panel3.TabIndex = 37;
            // 
            // rb_lucro
            // 
            this.rb_lucro.AutoSize = true;
            this.rb_lucro.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_lucro.ForeColor = System.Drawing.Color.White;
            this.rb_lucro.Location = new System.Drawing.Point(186, 45);
            this.rb_lucro.Name = "rb_lucro";
            this.rb_lucro.Size = new System.Drawing.Size(135, 20);
            this.rb_lucro.TabIndex = 33;
            this.rb_lucro.TabStop = true;
            this.rb_lucro.Text = "Lucro Presumido";
            this.rb_lucro.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(17, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "REGIME TRIBUTÁRIO:";
            // 
            // rb_real
            // 
            this.rb_real.AutoSize = true;
            this.rb_real.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_real.ForeColor = System.Drawing.Color.White;
            this.rb_real.Location = new System.Drawing.Point(186, 116);
            this.rb_real.Name = "rb_real";
            this.rb_real.Size = new System.Drawing.Size(56, 20);
            this.rb_real.TabIndex = 35;
            this.rb_real.TabStop = true;
            this.rb_real.Text = "Real";
            this.rb_real.UseVisualStyleBackColor = true;
            // 
            // rb_nacional
            // 
            this.rb_nacional.AutoSize = true;
            this.rb_nacional.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_nacional.ForeColor = System.Drawing.Color.White;
            this.rb_nacional.Location = new System.Drawing.Point(186, 78);
            this.rb_nacional.Name = "rb_nacional";
            this.rb_nacional.Size = new System.Drawing.Size(137, 20);
            this.rb_nacional.TabIndex = 34;
            this.rb_nacional.TabStop = true;
            this.rb_nacional.Text = "Simples Nacional";
            this.rb_nacional.UseVisualStyleBackColor = true;
            // 
            // forminicio
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::cadasfuncionario.Properties.Resources._33;
            this.ClientSize = new System.Drawing.Size(889, 551);
            this.Controls.Add(this.panel3);
            this.Name = "forminicio";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_rg;
        private System.Windows.Forms.MaskedTextBox tx_datanasc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_civil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_confirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_funcao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tx_rua;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.TextBox tx_estado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_cpf;
        private System.Windows.Forms.MaskedTextBox tx_tel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rb_lucro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rb_real;
        private System.Windows.Forms.RadioButton rb_nacional;
    }
}

