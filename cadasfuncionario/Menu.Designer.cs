namespace cadasfuncionario
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tx_empresa = new System.Windows.Forms.Button();
            this.tx_funcionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.tx_empresa);
            this.panel1.Controls.Add(this.tx_funcionario);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 460);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tx_empresa
            // 
            this.tx_empresa.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tx_empresa.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_empresa.ForeColor = System.Drawing.Color.White;
            this.tx_empresa.Location = new System.Drawing.Point(19, 210);
            this.tx_empresa.Name = "tx_empresa";
            this.tx_empresa.Size = new System.Drawing.Size(131, 47);
            this.tx_empresa.TabIndex = 1;
            this.tx_empresa.Text = "EMPRESA";
            this.tx_empresa.UseVisualStyleBackColor = false;
            this.tx_empresa.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // tx_funcionario
            // 
            this.tx_funcionario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tx_funcionario.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_funcionario.ForeColor = System.Drawing.Color.White;
            this.tx_funcionario.Location = new System.Drawing.Point(19, 113);
            this.tx_funcionario.Name = "tx_funcionario";
            this.tx_funcionario.Size = new System.Drawing.Size(131, 48);
            this.tx_funcionario.TabIndex = 0;
            this.tx_funcionario.Text = "FUNCIONÁRIO";
            this.tx_funcionario.UseVisualStyleBackColor = false;
            this.tx_funcionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(358, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "BEM VINDO(A)!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(285, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Por favor, selecione a opção que você deseja!";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cadasfuncionario.Properties.Resources.wp1920773;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tx_funcionario;
        private System.Windows.Forms.Button tx_empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}