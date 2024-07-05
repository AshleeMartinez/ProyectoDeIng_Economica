namespace ProyectoIng_Economica
{
    partial class FrmaAnualidadAnticipada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmaAnualidadAnticipada));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgPresente = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.dgvResultadosPresente = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cmbPeriodoPresente = new System.Windows.Forms.ComboBox();
            this.cmbInteresPresente = new System.Windows.Forms.ComboBox();
            this.txtPeriodoPresente = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtInteresPresente = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtValorAnualidadPresente = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbInteresFuturo = new System.Windows.Forms.TabPage();
            this.dgvResultadosFuturo = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValorAnualidadFuturo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbNoFuturo = new System.Windows.Forms.RadioButton();
            this.rdbSiFuturo = new System.Windows.Forms.RadioButton();
            this.cmbPeriodoFuturo = new System.Windows.Forms.ComboBox();
            this.cmbInteresAnualidadF = new System.Windows.Forms.ComboBox();
            this.btnLimpiarFuturo = new System.Windows.Forms.Button();
            this.btnCalcularFuturo = new System.Windows.Forms.Button();
            this.txtPeriodoFuturo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTasaInteresFuturo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tbgPresente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosPresente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel11.SuspendLayout();
            this.cmbInteresFuturo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosFuturo)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbgPresente);
            this.tabControl1.Controls.Add(this.cmbInteresFuturo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 668);
            this.tabControl1.TabIndex = 0;
            // 
            // tbgPresente
            // 
            this.tbgPresente.BackColor = System.Drawing.Color.White;
            this.tbgPresente.Controls.Add(this.groupBox1);
            this.tbgPresente.Controls.Add(this.dgvResultadosPresente);
            this.tbgPresente.Controls.Add(this.button3);
            this.tbgPresente.Controls.Add(this.label2);
            this.tbgPresente.Controls.Add(this.button4);
            this.tbgPresente.Controls.Add(this.label24);
            this.tbgPresente.Controls.Add(this.pictureBox2);
            this.tbgPresente.Controls.Add(this.panel11);
            this.tbgPresente.Location = new System.Drawing.Point(4, 39);
            this.tbgPresente.Name = "tbgPresente";
            this.tbgPresente.Padding = new System.Windows.Forms.Padding(3);
            this.tbgPresente.Size = new System.Drawing.Size(1150, 625);
            this.tbgPresente.TabIndex = 1;
            this.tbgPresente.Text = "Presente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNo);
            this.groupBox1.Controls.Add(this.rdbSi);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(931, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capitalizable";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(6, 62);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(68, 34);
            this.rdbNo.TabIndex = 1;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Location = new System.Drawing.Point(6, 30);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(52, 34);
            this.rdbSi.TabIndex = 0;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // dgvResultadosPresente
            // 
            this.dgvResultadosPresente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultadosPresente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosPresente.Location = new System.Drawing.Point(46, 426);
            this.dgvResultadosPresente.Name = "dgvResultadosPresente";
            this.dgvResultadosPresente.RowHeadersWidth = 51;
            this.dgvResultadosPresente.Size = new System.Drawing.Size(600, 150);
            this.dgvResultadosPresente.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(707, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 61);
            this.button3.TabIndex = 11;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ecuación ";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(707, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 66);
            this.button4.TabIndex = 10;
            this.button4.Text = "Calcular";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(37, 350);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(231, 49);
            this.label24.TabIndex = 12;
            this.label24.Text = "Resultados";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.cmbPeriodoPresente);
            this.panel11.Controls.Add(this.cmbInteresPresente);
            this.panel11.Controls.Add(this.txtPeriodoPresente);
            this.panel11.Controls.Add(this.label20);
            this.panel11.Controls.Add(this.txtInteresPresente);
            this.panel11.Controls.Add(this.label21);
            this.panel11.Controls.Add(this.txtValorAnualidadPresente);
            this.panel11.Controls.Add(this.label22);
            this.panel11.Controls.Add(this.label23);
            this.panel11.Location = new System.Drawing.Point(504, 30);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(627, 369);
            this.panel11.TabIndex = 14;
            // 
            // cmbPeriodoPresente
            // 
            this.cmbPeriodoPresente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodoPresente.FormattingEnabled = true;
            this.cmbPeriodoPresente.Items.AddRange(new object[] {
            "Años",
            "Meses",
            "Semestres",
            "Trimestres"});
            this.cmbPeriodoPresente.Location = new System.Drawing.Point(459, 227);
            this.cmbPeriodoPresente.Name = "cmbPeriodoPresente";
            this.cmbPeriodoPresente.Size = new System.Drawing.Size(121, 38);
            this.cmbPeriodoPresente.TabIndex = 13;
            // 
            // cmbInteresPresente
            // 
            this.cmbInteresPresente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteresPresente.FormattingEnabled = true;
            this.cmbInteresPresente.Items.AddRange(new object[] {
            "Anual",
            "Mensual",
            "Semestral",
            "Trimestral"});
            this.cmbInteresPresente.Location = new System.Drawing.Point(459, 163);
            this.cmbInteresPresente.Name = "cmbInteresPresente";
            this.cmbInteresPresente.Size = new System.Drawing.Size(121, 38);
            this.cmbInteresPresente.TabIndex = 12;
            // 
            // txtPeriodoPresente
            // 
            this.txtPeriodoPresente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPeriodoPresente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtPeriodoPresente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeriodoPresente.ForeColor = System.Drawing.Color.White;
            this.txtPeriodoPresente.Location = new System.Drawing.Point(236, 229);
            this.txtPeriodoPresente.Name = "txtPeriodoPresente";
            this.txtPeriodoPresente.Size = new System.Drawing.Size(123, 30);
            this.txtPeriodoPresente.TabIndex = 9;
            this.txtPeriodoPresente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodoPresente_KeyPress);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(2, 227);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 33);
            this.label20.TabIndex = 8;
            this.label20.Text = "Periodo";
            // 
            // txtInteresPresente
            // 
            this.txtInteresPresente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInteresPresente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtInteresPresente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInteresPresente.ForeColor = System.Drawing.Color.White;
            this.txtInteresPresente.Location = new System.Drawing.Point(235, 163);
            this.txtInteresPresente.Name = "txtInteresPresente";
            this.txtInteresPresente.Size = new System.Drawing.Size(123, 30);
            this.txtInteresPresente.TabIndex = 7;
            this.txtInteresPresente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInteresPresente_KeyPress);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(2, 163);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(165, 33);
            this.label21.TabIndex = 6;
            this.label21.Text = "Tasa interés";
            // 
            // txtValorAnualidadPresente
            // 
            this.txtValorAnualidadPresente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorAnualidadPresente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtValorAnualidadPresente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorAnualidadPresente.ForeColor = System.Drawing.Color.White;
            this.txtValorAnualidadPresente.Location = new System.Drawing.Point(236, 101);
            this.txtValorAnualidadPresente.Name = "txtValorAnualidadPresente";
            this.txtValorAnualidadPresente.Size = new System.Drawing.Size(123, 30);
            this.txtValorAnualidadPresente.TabIndex = 5;
            this.txtValorAnualidadPresente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorAnualidadPresente_KeyPress);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(2, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(228, 33);
            this.label22.TabIndex = 4;
            this.label22.Text = "Valor Anualidad";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(28, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(348, 49);
            this.label23.TabIndex = 3;
            this.label23.Text = "Ingresa los datos";
            // 
            // cmbInteresFuturo
            // 
            this.cmbInteresFuturo.BackColor = System.Drawing.Color.White;
            this.cmbInteresFuturo.Controls.Add(this.dgvResultadosFuturo);
            this.cmbInteresFuturo.Controls.Add(this.pictureBox3);
            this.cmbInteresFuturo.Controls.Add(this.label7);
            this.cmbInteresFuturo.Controls.Add(this.label1);
            this.cmbInteresFuturo.Controls.Add(this.btnLimpiarFuturo);
            this.cmbInteresFuturo.Controls.Add(this.panel2);
            this.cmbInteresFuturo.Controls.Add(this.btnCalcularFuturo);
            this.cmbInteresFuturo.Location = new System.Drawing.Point(4, 39);
            this.cmbInteresFuturo.Name = "cmbInteresFuturo";
            this.cmbInteresFuturo.Size = new System.Drawing.Size(1150, 625);
            this.cmbInteresFuturo.TabIndex = 2;
            this.cmbInteresFuturo.Text = "Futuro";
            // 
            // dgvResultadosFuturo
            // 
            this.dgvResultadosFuturo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultadosFuturo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosFuturo.Location = new System.Drawing.Point(21, 450);
            this.dgvResultadosFuturo.Name = "dgvResultadosFuturo";
            this.dgvResultadosFuturo.RowHeadersWidth = 51;
            this.dgvResultadosFuturo.Size = new System.Drawing.Size(615, 150);
            this.dgvResultadosFuturo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 49);
            this.label7.TabIndex = 12;
            this.label7.Text = "Resultados";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtValorAnualidadFuturo);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.cmbPeriodoFuturo);
            this.panel2.Controls.Add(this.cmbInteresAnualidadF);
            this.panel2.Controls.Add(this.txtPeriodoFuturo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTasaInteresFuturo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(489, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 375);
            this.panel2.TabIndex = 15;
            // 
            // txtValorAnualidadFuturo
            // 
            this.txtValorAnualidadFuturo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorAnualidadFuturo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtValorAnualidadFuturo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorAnualidadFuturo.ForeColor = System.Drawing.Color.White;
            this.txtValorAnualidadFuturo.Location = new System.Drawing.Point(270, 140);
            this.txtValorAnualidadFuturo.Name = "txtValorAnualidadFuturo";
            this.txtValorAnualidadFuturo.Size = new System.Drawing.Size(123, 30);
            this.txtValorAnualidadFuturo.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbNoFuturo);
            this.groupBox2.Controls.Add(this.rdbSiFuturo);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(411, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 116);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capitalizable";
            // 
            // rdbNoFuturo
            // 
            this.rdbNoFuturo.AutoSize = true;
            this.rdbNoFuturo.Location = new System.Drawing.Point(69, 64);
            this.rdbNoFuturo.Name = "rdbNoFuturo";
            this.rdbNoFuturo.Size = new System.Drawing.Size(68, 34);
            this.rdbNoFuturo.TabIndex = 1;
            this.rdbNoFuturo.TabStop = true;
            this.rdbNoFuturo.Text = "No";
            this.rdbNoFuturo.UseVisualStyleBackColor = true;
            // 
            // rdbSiFuturo
            // 
            this.rdbSiFuturo.AutoSize = true;
            this.rdbSiFuturo.Location = new System.Drawing.Point(69, 36);
            this.rdbSiFuturo.Name = "rdbSiFuturo";
            this.rdbSiFuturo.Size = new System.Drawing.Size(52, 34);
            this.rdbSiFuturo.TabIndex = 0;
            this.rdbSiFuturo.TabStop = true;
            this.rdbSiFuturo.Text = "Si";
            this.rdbSiFuturo.UseVisualStyleBackColor = true;
            // 
            // cmbPeriodoFuturo
            // 
            this.cmbPeriodoFuturo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodoFuturo.FormattingEnabled = true;
            this.cmbPeriodoFuturo.Items.AddRange(new object[] {
            "Años",
            "Meses",
            "Semestres",
            "Trimestres"});
            this.cmbPeriodoFuturo.Location = new System.Drawing.Point(429, 273);
            this.cmbPeriodoFuturo.Name = "cmbPeriodoFuturo";
            this.cmbPeriodoFuturo.Size = new System.Drawing.Size(121, 38);
            this.cmbPeriodoFuturo.TabIndex = 13;
            // 
            // cmbInteresAnualidadF
            // 
            this.cmbInteresAnualidadF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteresAnualidadF.FormattingEnabled = true;
            this.cmbInteresAnualidadF.Items.AddRange(new object[] {
            "Anual",
            "Mensual",
            "Semestral",
            "Trimestral"});
            this.cmbInteresAnualidadF.Location = new System.Drawing.Point(429, 191);
            this.cmbInteresAnualidadF.Name = "cmbInteresAnualidadF";
            this.cmbInteresAnualidadF.Size = new System.Drawing.Size(121, 38);
            this.cmbInteresAnualidadF.TabIndex = 12;
            // 
            // btnLimpiarFuturo
            // 
            this.btnLimpiarFuturo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarFuturo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLimpiarFuturo.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFuturo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFuturo.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFuturo.Location = new System.Drawing.Point(844, 541);
            this.btnLimpiarFuturo.Name = "btnLimpiarFuturo";
            this.btnLimpiarFuturo.Size = new System.Drawing.Size(177, 76);
            this.btnLimpiarFuturo.TabIndex = 11;
            this.btnLimpiarFuturo.Text = "Limpiar";
            this.btnLimpiarFuturo.UseVisualStyleBackColor = false;
            this.btnLimpiarFuturo.Click += new System.EventHandler(this.btnLimpiarFuturo_Click);
            // 
            // btnCalcularFuturo
            // 
            this.btnCalcularFuturo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcularFuturo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCalcularFuturo.FlatAppearance.BorderSize = 0;
            this.btnCalcularFuturo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularFuturo.ForeColor = System.Drawing.Color.White;
            this.btnCalcularFuturo.Location = new System.Drawing.Point(844, 466);
            this.btnCalcularFuturo.Name = "btnCalcularFuturo";
            this.btnCalcularFuturo.Size = new System.Drawing.Size(177, 69);
            this.btnCalcularFuturo.TabIndex = 10;
            this.btnCalcularFuturo.Text = "Calcular";
            this.btnCalcularFuturo.UseVisualStyleBackColor = false;
            this.btnCalcularFuturo.Click += new System.EventHandler(this.btnCalcularFuturo_Click);
            // 
            // txtPeriodoFuturo
            // 
            this.txtPeriodoFuturo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPeriodoFuturo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtPeriodoFuturo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeriodoFuturo.ForeColor = System.Drawing.Color.White;
            this.txtPeriodoFuturo.Location = new System.Drawing.Point(270, 276);
            this.txtPeriodoFuturo.Name = "txtPeriodoFuturo";
            this.txtPeriodoFuturo.Size = new System.Drawing.Size(123, 30);
            this.txtPeriodoFuturo.TabIndex = 9;
            this.txtPeriodoFuturo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodoFuturo_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(134, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Periodo";
            // 
            // txtTasaInteresFuturo
            // 
            this.txtTasaInteresFuturo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTasaInteresFuturo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtTasaInteresFuturo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTasaInteresFuturo.ForeColor = System.Drawing.Color.White;
            this.txtTasaInteresFuturo.Location = new System.Drawing.Point(270, 199);
            this.txtTasaInteresFuturo.Name = "txtTasaInteresFuturo";
            this.txtTasaInteresFuturo.Size = new System.Drawing.Size(123, 30);
            this.txtTasaInteresFuturo.TabIndex = 7;
            this.txtTasaInteresFuturo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaInteresFuturo_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(87, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tasa interés";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Anualidad";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 49);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ingresa los datos";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ecuación ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(388, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // FrmaAnualidadAnticipada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 668);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmaAnualidadAnticipada";
            this.Text = "FrmaAnualidadAnticipada";
            this.tabControl1.ResumeLayout(false);
            this.tbgPresente.ResumeLayout(false);
            this.tbgPresente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosPresente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.cmbInteresFuturo.ResumeLayout(false);
            this.cmbInteresFuturo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosFuturo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbgPresente;
        private System.Windows.Forms.TabPage cmbInteresFuturo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox cmbPeriodoPresente;
        private System.Windows.Forms.ComboBox cmbInteresPresente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtPeriodoPresente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtInteresPresente;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtValorAnualidadPresente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dgvResultadosFuturo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbPeriodoFuturo;
        private System.Windows.Forms.ComboBox cmbInteresAnualidadF;
        private System.Windows.Forms.Button btnLimpiarFuturo;
        private System.Windows.Forms.Button btnCalcularFuturo;
        private System.Windows.Forms.TextBox txtPeriodoFuturo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTasaInteresFuturo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgvResultadosPresente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbNoFuturo;
        private System.Windows.Forms.RadioButton rdbSiFuturo;
        private System.Windows.Forms.TextBox txtValorAnualidadFuturo;
    }
}