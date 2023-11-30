namespace cadasfuncionario
{
    partial class Consultar_Funcionario
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
            this.con = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.con)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.con.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.con.Location = new System.Drawing.Point(169, 139);
            this.con.Name = "con";
            this.con.RowHeadersWidth = 51;
            this.con.RowTemplate.Height = 24;
            this.con.Size = new System.Drawing.Size(619, 343);
            this.con.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "FUNCIONÁRIOS REGISTRADOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.bt_voltar);
            this.panel1.Location = new System.Drawing.Point(-11, -14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 72);
            this.panel1.TabIndex = 2;
            // 
            // bt_voltar
            // 
            this.bt_voltar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_voltar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_voltar.ForeColor = System.Drawing.Color.White;
            this.bt_voltar.Location = new System.Drawing.Point(23, 26);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(85, 33);
            this.bt_voltar.TabIndex = 0;
            this.bt_voltar.Text = "VOLTAR";
            this.bt_voltar.UseVisualStyleBackColor = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // Consultar_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::cadasfuncionario.Properties.Resources.wp1920773;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.con);
            this.Name = "Consultar_Funcionario";
            this.Text = "Consultar_Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.con)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView con;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_voltar;
    }
}