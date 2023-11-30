namespace cadasfuncionario
{
    partial class ConsultarEmp
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
            this.tabelaEmp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaEmp
            // 
            this.tabelaEmp.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.tabelaEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaEmp.Location = new System.Drawing.Point(189, 147);
            this.tabelaEmp.Name = "tabelaEmp";
            this.tabelaEmp.RowHeadersWidth = 51;
            this.tabelaEmp.RowTemplate.Height = 24;
            this.tabelaEmp.Size = new System.Drawing.Size(576, 352);
            this.tabelaEmp.TabIndex = 0;
            this.tabelaEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaEmp_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSULTE EMPRESA:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(-28, -57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 106);
            this.panel1.TabIndex = 2;
            // 
            // ConsultarEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cadasfuncionario.Properties.Resources.wp1920773;
            this.ClientSize = new System.Drawing.Size(991, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabelaEmp);
            this.Name = "ConsultarEmp";
            this.Text = "ConsultarEmp";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelaEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}