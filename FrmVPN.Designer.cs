﻿namespace ProyectoIng_Economica
{
    partial class FrmVPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVPN));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgCalculo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.ANIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flujoNeE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtAnios = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvFlujosNetos = new System.Windows.Forms.DataGridView();
            this.AÑO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flujoNE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTasaDescuento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInversionInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbgCalculo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlujosNetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbgCalculo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1572, 939);
            this.tabControl1.TabIndex = 0;
            // 
            // tbgCalculo
            // 
            this.tbgCalculo.BackColor = System.Drawing.Color.White;
            this.tbgCalculo.Controls.Add(this.label6);
            this.tbgCalculo.Controls.Add(this.label4);
            this.tbgCalculo.Controls.Add(this.txtInversionInicial);
            this.tbgCalculo.Controls.Add(this.txtAnios);
            this.tbgCalculo.Controls.Add(this.label1);
            this.tbgCalculo.Controls.Add(this.label5);
            this.tbgCalculo.Controls.Add(this.pictureBox2);
            this.tbgCalculo.Controls.Add(this.btnCalcular);
            this.tbgCalculo.Controls.Add(this.label3);
            this.tbgCalculo.Controls.Add(this.txtTasaDescuento);
            this.tbgCalculo.Controls.Add(this.btnLimpiar);
            this.tbgCalculo.Controls.Add(this.label2);
            this.tbgCalculo.Controls.Add(this.panel1);
            this.tbgCalculo.Controls.Add(this.panel11);
            this.tbgCalculo.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgCalculo.Location = new System.Drawing.Point(4, 38);
            this.tbgCalculo.Name = "tbgCalculo";
            this.tbgCalculo.Padding = new System.Windows.Forms.Padding(3);
            this.tbgCalculo.Size = new System.Drawing.Size(1564, 897);
            this.tbgCalculo.TabIndex = 1;
            this.tbgCalculo.Text = "Calculo VPN";
            this.tbgCalculo.Click += new System.EventHandler(this.tbgCalculo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.dgvResultados);
            this.panel1.Location = new System.Drawing.Point(196, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 245);
            this.panel1.TabIndex = 16;
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ANIO,
            this.flujoNeE,
            this.ValPN});
            this.dgvResultados.Location = new System.Drawing.Point(19, 19);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.Size = new System.Drawing.Size(450, 177);
            this.dgvResultados.TabIndex = 5;
            // 
            // ANIO
            // 
            this.ANIO.HeaderText = "AÑO";
            this.ANIO.MinimumWidth = 6;
            this.ANIO.Name = "ANIO";
            this.ANIO.Width = 125;
            // 
            // flujoNeE
            // 
            this.flujoNeE.HeaderText = "FNE";
            this.flujoNeE.MinimumWidth = 6;
            this.flujoNeE.Name = "flujoNeE";
            this.flujoNeE.Width = 125;
            // 
            // ValPN
            // 
            this.ValPN.HeaderText = "VPN";
            this.ValPN.MinimumWidth = 6;
            this.ValPN.Name = "ValPN";
            this.ValPN.Width = 125;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel11.Controls.Add(this.dgvFlujosNetos);
            this.panel11.Location = new System.Drawing.Point(737, 405);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(523, 245);
            this.panel11.TabIndex = 15;
            // 
            // txtAnios
            // 
            this.txtAnios.Location = new System.Drawing.Point(892, 147);
            this.txtAnios.Name = "txtAnios";
            this.txtAnios.Size = new System.Drawing.Size(172, 53);
            this.txtAnios.TabIndex = 8;
            this.txtAnios.TextChanged += new System.EventHandler(this.txtAnios_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(782, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Años";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(1101, 278);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(166, 65);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Black;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(1101, 206);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(166, 66);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvFlujosNetos
            // 
            this.dgvFlujosNetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlujosNetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AÑO,
            this.flujoNE});
            this.dgvFlujosNetos.Location = new System.Drawing.Point(22, 19);
            this.dgvFlujosNetos.Name = "dgvFlujosNetos";
            this.dgvFlujosNetos.RowHeadersWidth = 51;
            this.dgvFlujosNetos.Size = new System.Drawing.Size(474, 150);
            this.dgvFlujosNetos.TabIndex = 4;
            // 
            // AÑO
            // 
            this.AÑO.HeaderText = "AÑO";
            this.AÑO.MinimumWidth = 6;
            this.AÑO.Name = "AÑO";
            this.AÑO.Width = 125;
            // 
            // flujoNE
            // 
            this.flujoNE.HeaderText = "FNE";
            this.flujoNE.MinimumWidth = 6;
            this.flujoNE.Name = "flujoNE";
            this.flujoNE.Width = 125;
            // 
            // txtTasaDescuento
            // 
            this.txtTasaDescuento.Location = new System.Drawing.Point(892, 206);
            this.txtTasaDescuento.Name = "txtTasaDescuento";
            this.txtTasaDescuento.Size = new System.Drawing.Size(172, 53);
            this.txtTasaDescuento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(611, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tasa Descuento";
            // 
            // txtInversionInicial
            // 
            this.txtInversionInicial.Location = new System.Drawing.Point(892, 88);
            this.txtInversionInicial.Name = "txtInversionInicial";
            this.txtInversionInicial.Size = new System.Drawing.Size(172, 53);
            this.txtInversionInicial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(607, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inversion Inicial";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(323, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ecuación ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(196, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(207, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 45);
            this.label5.TabIndex = 17;
            this.label5.Text = "Resultado:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(949, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 45);
            this.label6.TabIndex = 18;
            this.label6.Text = "Flujos:";
            // 
            // FrmVPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 939);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVPN";
            this.Text = "FrmVPN";
            this.tabControl1.ResumeLayout(false);
            this.tbgCalculo.ResumeLayout(false);
            this.tbgCalculo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlujosNetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbgCalculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTasaDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInversionInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvFlujosNetos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AÑO;
        private System.Windows.Forms.DataGridViewTextBoxColumn flujoNE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn flujoNeE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValPN;
        private System.Windows.Forms.TextBox txtAnios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}