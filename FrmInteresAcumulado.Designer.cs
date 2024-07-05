namespace ProyectoIng_Economica
{
    partial class FrmInteresAcumulado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvResultadosAcumulados = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPeriodoAcum = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbInteresAcum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.lblValorPresente = new System.Windows.Forms.Label();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtValorPresente = new System.Windows.Forms.TextBox();
            this.lblInteres = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultadosAcumulados)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dtgvResultadosAcumulados);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbPeriodoAcum);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbInteresAcum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPeriodo);
            this.groupBox1.Controls.Add(this.lblValorPresente);
            this.groupBox1.Controls.Add(this.txtTasaInteres);
            this.groupBox1.Controls.Add(this.lblPeriodo);
            this.groupBox1.Controls.Add(this.txtValorPresente);
            this.groupBox1.Controls.Add(this.lblInteres);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1511, 837);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interés";
            // 
            // dtgvResultadosAcumulados
            // 
            this.dtgvResultadosAcumulados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvResultadosAcumulados.Location = new System.Drawing.Point(43, 422);
            this.dtgvResultadosAcumulados.Name = "dtgvResultadosAcumulados";
            this.dtgvResultadosAcumulados.RowHeadersWidth = 51;
            this.dtgvResultadosAcumulados.Size = new System.Drawing.Size(487, 199);
            this.dtgvResultadosAcumulados.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(706, 544);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(188, 77);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Resultados";
            // 
            // cmbPeriodoAcum
            // 
            this.cmbPeriodoAcum.FormattingEnabled = true;
            this.cmbPeriodoAcum.Items.AddRange(new object[] {
            "Años",
            "Meses",
            "Semestres",
            "Trimestres"});
            this.cmbPeriodoAcum.Location = new System.Drawing.Point(1123, 274);
            this.cmbPeriodoAcum.Name = "cmbPeriodoAcum";
            this.cmbPeriodoAcum.Size = new System.Drawing.Size(121, 46);
            this.cmbPeriodoAcum.TabIndex = 13;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcular.BackColor = System.Drawing.Color.Silver;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(706, 422);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(188, 74);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 205);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ecuación:";
            // 
            // cmbInteresAcum
            // 
            this.cmbInteresAcum.FormattingEnabled = true;
            this.cmbInteresAcum.Items.AddRange(new object[] {
            "Anual",
            "Mensual",
            "Semestral",
            "Trimestral"});
            this.cmbInteresAcum.Location = new System.Drawing.Point(1123, 209);
            this.cmbInteresAcum.Name = "cmbInteresAcum";
            this.cmbInteresAcum.Size = new System.Drawing.Size(121, 46);
            this.cmbInteresAcum.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(817, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresa los datos";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPeriodo.BackColor = System.Drawing.Color.Silver;
            this.txtPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeriodo.ForeColor = System.Drawing.Color.Black;
            this.txtPeriodo.Location = new System.Drawing.Point(896, 278);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(164, 38);
            this.txtPeriodo.TabIndex = 9;
            this.txtPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodo_KeyPress);
            // 
            // lblValorPresente
            // 
            this.lblValorPresente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValorPresente.AutoSize = true;
            this.lblValorPresente.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPresente.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPresente.ForeColor = System.Drawing.Color.Black;
            this.lblValorPresente.Location = new System.Drawing.Point(650, 141);
            this.lblValorPresente.Name = "lblValorPresente";
            this.lblValorPresente.Size = new System.Drawing.Size(218, 39);
            this.lblValorPresente.TabIndex = 4;
            this.lblValorPresente.Text = "Valor Presente";
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTasaInteres.BackColor = System.Drawing.Color.Silver;
            this.txtTasaInteres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTasaInteres.ForeColor = System.Drawing.Color.Black;
            this.txtTasaInteres.Location = new System.Drawing.Point(896, 209);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(164, 38);
            this.txtTasaInteres.TabIndex = 7;
            this.txtTasaInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaInteres_KeyPress);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodo.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.Black;
            this.lblPeriodo.Location = new System.Drawing.Point(737, 274);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(126, 39);
            this.lblPeriodo.TabIndex = 8;
            this.lblPeriodo.Text = "Periodo";
            // 
            // txtValorPresente
            // 
            this.txtValorPresente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorPresente.BackColor = System.Drawing.Color.Silver;
            this.txtValorPresente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorPresente.ForeColor = System.Drawing.Color.Black;
            this.txtValorPresente.Location = new System.Drawing.Point(896, 142);
            this.txtValorPresente.Name = "txtValorPresente";
            this.txtValorPresente.Size = new System.Drawing.Size(164, 38);
            this.txtValorPresente.TabIndex = 5;
            this.txtValorPresente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPresente_KeyPress);
            // 
            // lblInteres
            // 
            this.lblInteres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInteres.AutoSize = true;
            this.lblInteres.BackColor = System.Drawing.Color.Transparent;
            this.lblInteres.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteres.ForeColor = System.Drawing.Color.Black;
            this.lblInteres.Location = new System.Drawing.Point(690, 209);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(180, 39);
            this.lblInteres.TabIndex = 6;
            this.lblInteres.Text = "Tasa interés";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoIng_Economica.Properties.Resources.Captura_de_pantalla__184_;
            this.pictureBox1.Location = new System.Drawing.Point(29, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInteresAcumulado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1511, 837);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInteresAcumulado";
            this.Text = "FrmInteresAcumulado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvResultadosAcumulados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.TextBox txtValorPresente;
        private System.Windows.Forms.Label lblValorPresente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvResultadosAcumulados;
        private System.Windows.Forms.ComboBox cmbPeriodoAcum;
        private System.Windows.Forms.ComboBox cmbInteresAcum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}