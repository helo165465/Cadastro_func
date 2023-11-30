namespace cadasfuncionario
{
    partial class CadasEmp
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
            this.tx_voltar = new System.Windows.Forms.Button();
            this.tx_consulta_emp = new System.Windows.Forms.Button();
            this.tx_cancelar = new System.Windows.Forms.Button();
            this.tx_salvar = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label15 = new System.Windows.Forms.Label();
            this.tx_razao = new System.Windows.Forms.TextBox();
            this.tx_nome_fan = new System.Windows.Forms.TextBox();
            this.tx_situacao = new System.Windows.Forms.ComboBox();
            this.tx_data = new System.Windows.Forms.DateTimePicker();
            this.tx_medio = new System.Windows.Forms.RadioButton();
            this.tx_pequeno = new System.Windows.Forms.RadioButton();
            this.tx_natureza = new System.Windows.Forms.ComboBox();
            this.tx_grande = new System.Windows.Forms.RadioButton();
            this.tx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tx_simples = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_lucro = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_real = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_nome_pro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_filial = new System.Windows.Forms.RadioButton();
            this.tx_matriz = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tx = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.tx_capital = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tx.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_voltar
            // 
            this.tx_voltar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tx_voltar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_voltar.ForeColor = System.Drawing.Color.White;
            this.tx_voltar.Location = new System.Drawing.Point(31, 275);
            this.tx_voltar.Name = "tx_voltar";
            this.tx_voltar.Size = new System.Drawing.Size(118, 56);
            this.tx_voltar.TabIndex = 19;
            this.tx_voltar.Text = "VOLTAR";
            this.tx_voltar.UseVisualStyleBackColor = false;
            this.tx_voltar.Click += new System.EventHandler(this.tx_voltar_Click);
            // 
            // tx_consulta_emp
            // 
            this.tx_consulta_emp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tx_consulta_emp.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_consulta_emp.ForeColor = System.Drawing.Color.White;
            this.tx_consulta_emp.Location = new System.Drawing.Point(31, 121);
            this.tx_consulta_emp.Name = "tx_consulta_emp";
            this.tx_consulta_emp.Size = new System.Drawing.Size(118, 56);
            this.tx_consulta_emp.TabIndex = 20;
            this.tx_consulta_emp.Text = "CONSULTAR EMPRESA";
            this.tx_consulta_emp.UseVisualStyleBackColor = false;
            this.tx_consulta_emp.Click += new System.EventHandler(this.tx_consulta_emp_Click);
            // 
            // tx_cancelar
            // 
            this.tx_cancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tx_cancelar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tx_cancelar.Location = new System.Drawing.Point(31, 348);
            this.tx_cancelar.Name = "tx_cancelar";
            this.tx_cancelar.Size = new System.Drawing.Size(118, 56);
            this.tx_cancelar.TabIndex = 21;
            this.tx_cancelar.Text = "CANCELAR";
            this.tx_cancelar.UseVisualStyleBackColor = false;
            this.tx_cancelar.Click += new System.EventHandler(this.tx_cancelar_Click);
            // 
            // tx_salvar
            // 
            this.tx_salvar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tx_salvar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_salvar.ForeColor = System.Drawing.Color.White;
            this.tx_salvar.Location = new System.Drawing.Point(31, 195);
            this.tx_salvar.Name = "tx_salvar";
            this.tx_salvar.Size = new System.Drawing.Size(118, 56);
            this.tx_salvar.TabIndex = 22;
            this.tx_salvar.Text = "SALVAR";
            this.tx_salvar.UseVisualStyleBackColor = false;
            this.tx_salvar.Click += new System.EventHandler(this.tx_salvar_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tx_salvar);
            this.panel2.Controls.Add(this.tx_voltar);
            this.panel2.Controls.Add(this.tx_cancelar);
            this.panel2.Controls.Add(this.tx_consulta_emp);
            this.panel2.Location = new System.Drawing.Point(847, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 597);
            this.panel2.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(58, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(255, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(306, 30);
            this.label15.TabIndex = 29;
            this.label15.Text = "CADASTRE EMPRESA:";
            // 
            // tx_razao
            // 
            this.tx_razao.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_razao.Location = new System.Drawing.Point(158, 257);
            this.tx_razao.Name = "tx_razao";
            this.tx_razao.Size = new System.Drawing.Size(269, 25);
            this.tx_razao.TabIndex = 3;
            this.tx_razao.TextChanged += new System.EventHandler(this.razao_social_TextChanged);
            // 
            // tx_nome_fan
            // 
            this.tx_nome_fan.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome_fan.Location = new System.Drawing.Point(170, 44);
            this.tx_nome_fan.Name = "tx_nome_fan";
            this.tx_nome_fan.Size = new System.Drawing.Size(408, 25);
            this.tx_nome_fan.TabIndex = 4;
            // 
            // tx_situacao
            // 
            this.tx_situacao.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_situacao.FormattingEnabled = true;
            this.tx_situacao.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.tx_situacao.Location = new System.Drawing.Point(212, 215);
            this.tx_situacao.Name = "tx_situacao";
            this.tx_situacao.Size = new System.Drawing.Size(264, 24);
            this.tx_situacao.TabIndex = 8;
            // 
            // tx_data
            // 
            this.tx_data.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_data.Location = new System.Drawing.Point(179, 178);
            this.tx_data.Name = "tx_data";
            this.tx_data.Size = new System.Drawing.Size(297, 25);
            this.tx_data.TabIndex = 7;
            // 
            // tx_medio
            // 
            this.tx_medio.AutoSize = true;
            this.tx_medio.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_medio.ForeColor = System.Drawing.Color.White;
            this.tx_medio.Location = new System.Drawing.Point(6, 76);
            this.tx_medio.Name = "tx_medio";
            this.tx_medio.Size = new System.Drawing.Size(77, 20);
            this.tx_medio.TabIndex = 17;
            this.tx_medio.TabStop = true;
            this.tx_medio.Text = "MÉDIO";
            this.tx_medio.UseVisualStyleBackColor = true;
            // 
            // tx_pequeno
            // 
            this.tx_pequeno.AutoSize = true;
            this.tx_pequeno.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_pequeno.ForeColor = System.Drawing.Color.White;
            this.tx_pequeno.Location = new System.Drawing.Point(6, 49);
            this.tx_pequeno.Name = "tx_pequeno";
            this.tx_pequeno.Size = new System.Drawing.Size(98, 20);
            this.tx_pequeno.TabIndex = 16;
            this.tx_pequeno.TabStop = true;
            this.tx_pequeno.Text = "PEQUENO";
            this.tx_pequeno.UseVisualStyleBackColor = true;
            // 
            // tx_natureza
            // 
            this.tx_natureza.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_natureza.FormattingEnabled = true;
            this.tx_natureza.Items.AddRange(new object[] {
            "EI – Empresário Individual",
            "MEI – Microempreendedor Individual",
            "Sociedade Anônima",
            "Sociedade Simples Limitada",
            "Sociedade Limitada Unipessoal"});
            this.tx_natureza.Location = new System.Drawing.Point(202, 375);
            this.tx_natureza.Name = "tx_natureza";
            this.tx_natureza.Size = new System.Drawing.Size(225, 24);
            this.tx_natureza.TabIndex = 10;
            // 
            // tx_grande
            // 
            this.tx_grande.AutoSize = true;
            this.tx_grande.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_grande.ForeColor = System.Drawing.Color.White;
            this.tx_grande.Location = new System.Drawing.Point(6, 23);
            this.tx_grande.Name = "tx_grande";
            this.tx_grande.Size = new System.Drawing.Size(91, 20);
            this.tx_grande.TabIndex = 18;
            this.tx_grande.TabStop = true;
            this.tx_grande.Text = "GRANDE";
            this.tx_grande.UseVisualStyleBackColor = true;
            // 
            // tx_telefone
            // 
            this.tx_telefone.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_telefone.Location = new System.Drawing.Point(142, 90);
            this.tx_telefone.Name = "tx_telefone";
            this.tx_telefone.Size = new System.Drawing.Size(241, 25);
            this.tx_telefone.TabIndex = 24;
            // 
            // tx_simples
            // 
            this.tx_simples.AutoSize = true;
            this.tx_simples.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_simples.ForeColor = System.Drawing.Color.White;
            this.tx_simples.Location = new System.Drawing.Point(6, 19);
            this.tx_simples.Name = "tx_simples";
            this.tx_simples.Size = new System.Drawing.Size(171, 20);
            this.tx_simples.TabIndex = 13;
            this.tx_simples.TabStop = true;
            this.tx_simples.Text = "SIMPLES NACIONAL";
            this.tx_simples.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "DATA DE ÍNICIO:";
            // 
            // tx_lucro
            // 
            this.tx_lucro.AutoSize = true;
            this.tx_lucro.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_lucro.ForeColor = System.Drawing.Color.White;
            this.tx_lucro.Location = new System.Drawing.Point(6, 48);
            this.tx_lucro.Name = "tx_lucro";
            this.tx_lucro.Size = new System.Drawing.Size(169, 20);
            this.tx_lucro.TabIndex = 14;
            this.tx_lucro.TabStop = true;
            this.tx_lucro.Text = "LUCRO PRESUMIDO";
            this.tx_lucro.UseVisualStyleBackColor = true;
            this.tx_lucro.CheckedChanged += new System.EventHandler(this.tx_lucro_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "CNPJ:";
            // 
            // tx_real
            // 
            this.tx_real.AutoSize = true;
            this.tx_real.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_real.ForeColor = System.Drawing.Color.White;
            this.tx_real.Location = new System.Drawing.Point(6, 74);
            this.tx_real.Name = "tx_real";
            this.tx_real.Size = new System.Drawing.Size(67, 20);
            this.tx_real.TabIndex = 15;
            this.tx_real.TabStop = true;
            this.tx_real.Text = "REAL";
            this.tx_real.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "TELEFONE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "NOME FANTASIA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "SITUAÇÃO CADASTRAL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "RAZÃO SOCIAL:";
            // 
            // tx_nome_pro
            // 
            this.tx_nome_pro.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome_pro.Location = new System.Drawing.Point(107, 10);
            this.tx_nome_pro.Name = "tx_nome_pro";
            this.tx_nome_pro.Size = new System.Drawing.Size(471, 25);
            this.tx_nome_pro.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "CPF:";
            // 
            // tx_cpf
            // 
            this.tx_cpf.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cpf.Location = new System.Drawing.Point(158, 299);
            this.tx_cpf.Mask = "000.000.000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(115, 25);
            this.tx_cpf.TabIndex = 34;
            // 
            // tx_filial
            // 
            this.tx_filial.AutoSize = true;
            this.tx_filial.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_filial.ForeColor = System.Drawing.Color.White;
            this.tx_filial.Location = new System.Drawing.Point(6, 21);
            this.tx_filial.Name = "tx_filial";
            this.tx_filial.Size = new System.Drawing.Size(75, 20);
            this.tx_filial.TabIndex = 11;
            this.tx_filial.TabStop = true;
            this.tx_filial.Text = "FILIAL";
            this.tx_filial.UseVisualStyleBackColor = true;
            // 
            // tx_matriz
            // 
            this.tx_matriz.AutoSize = true;
            this.tx_matriz.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_matriz.ForeColor = System.Drawing.Color.White;
            this.tx_matriz.Location = new System.Drawing.Point(6, 48);
            this.tx_matriz.Name = "tx_matriz";
            this.tx_matriz.Size = new System.Drawing.Size(85, 20);
            this.tx_matriz.TabIndex = 12;
            this.tx_matriz.TabStop = true;
            this.tx_matriz.Text = "MATRIZ";
            this.tx_matriz.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(31, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "ENDEREÇO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(31, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "NATUREZA JURÍDICA:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(31, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "CAPITAL:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(31, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "NOME:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.tx);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tx_endereco);
            this.panel1.Controls.Add(this.tx_cnpj);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tx_capital);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tx_cpf);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tx_nome_pro);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tx_telefone);
            this.panel1.Controls.Add(this.tx_natureza);
            this.panel1.Controls.Add(this.tx_data);
            this.panel1.Controls.Add(this.tx_situacao);
            this.panel1.Controls.Add(this.tx_nome_fan);
            this.panel1.Controls.Add(this.tx_razao);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 458);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tx
            // 
            this.tx.Controls.Add(this.tx_filial);
            this.tx.Controls.Add(this.tx_matriz);
            this.tx.ForeColor = System.Drawing.Color.White;
            this.tx.Location = new System.Drawing.Point(522, 344);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(200, 75);
            this.tx.TabIndex = 45;
            this.tx.TabStop = false;
            this.tx.Text = "TIPO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tx_simples);
            this.groupBox2.Controls.Add(this.tx_lucro);
            this.groupBox2.Controls.Add(this.tx_real);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(522, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REGIME TRIBUTÁRIO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tx_grande);
            this.groupBox1.Controls.Add(this.tx_pequeno);
            this.groupBox1.Controls.Add(this.tx_medio);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(522, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 107);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PORTE DA EMPRESA:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tx_endereco
            // 
            this.tx_endereco.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_endereco.Location = new System.Drawing.Point(158, 335);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(269, 25);
            this.tx_endereco.TabIndex = 42;
            // 
            // tx_cnpj
            // 
            this.tx_cnpj.Location = new System.Drawing.Point(142, 140);
            this.tx_cnpj.Name = "tx_cnpj";
            this.tx_cnpj.Size = new System.Drawing.Size(241, 22);
            this.tx_cnpj.TabIndex = 41;
            // 
            // tx_capital
            // 
            this.tx_capital.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_capital.Location = new System.Drawing.Point(114, 418);
            this.tx_capital.Name = "tx_capital";
            this.tx_capital.Size = new System.Drawing.Size(269, 25);
            this.tx_capital.TabIndex = 5;
            this.tx_capital.TextChanged += new System.EventHandler(this.tx_capital_TextChanged);
            // 
            // CadasEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cadasfuncionario.Properties.Resources.wp1920773;
            this.ClientSize = new System.Drawing.Size(1008, 559);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CadasEmp";
            this.Text = "CadasEmp";
            this.Load += new System.EventHandler(this.CadasEmp_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tx.ResumeLayout(false);
            this.tx.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tx_voltar;
        private System.Windows.Forms.Button tx_consulta_emp;
        private System.Windows.Forms.Button tx_cancelar;
        private System.Windows.Forms.Button tx_salvar;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Panel panel2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tx_razao;
        private System.Windows.Forms.TextBox tx_nome_fan;
        private System.Windows.Forms.ComboBox tx_situacao;
        private System.Windows.Forms.DateTimePicker tx_data;
        private System.Windows.Forms.RadioButton tx_medio;
        private System.Windows.Forms.RadioButton tx_pequeno;
        private System.Windows.Forms.ComboBox tx_natureza;
        private System.Windows.Forms.RadioButton tx_grande;
        private System.Windows.Forms.MaskedTextBox tx_telefone;
        private System.Windows.Forms.RadioButton tx_simples;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton tx_lucro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton tx_real;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx_nome_pro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.RadioButton tx_filial;
        private System.Windows.Forms.RadioButton tx_matriz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tx_capital;
        private System.Windows.Forms.MaskedTextBox tx_cnpj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox tx;
    }
}