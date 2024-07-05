namespace ProyectoIng_Economica
{
    partial class FrmPerpetua
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgCalculo = new System.Windows.Forms.TabPage();
            this.dgvResultadoresPerpetuos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarPerpetuo = new System.Windows.Forms.Button();
            this.btnCalcularPerpetuo = new System.Windows.Forms.Button();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorAnualidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tbgCalculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoresPerpetuos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbgCalculo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 668);
            this.tabControl1.TabIndex = 0;
            // 
            // tbgCalculo
            // 
            this.tbgCalculo.BackColor = System.Drawing.Color.White;
            this.tbgCalculo.Controls.Add(this.label9);
            this.tbgCalculo.Controls.Add(this.dgvResultadoresPerpetuos);
            this.tbgCalculo.Controls.Add(this.label1);
            this.tbgCalculo.Controls.Add(this.txtPeriodo);
            this.tbgCalculo.Controls.Add(this.label6);
            this.tbgCalculo.Controls.Add(this.btnLimpiarPerpetuo);
            this.tbgCalculo.Controls.Add(this.label7);
            this.tbgCalculo.Controls.Add(this.pictureBox2);
            this.tbgCalculo.Controls.Add(this.btnCalcularPerpetuo);
            this.tbgCalculo.Controls.Add(this.label2);
            this.tbgCalculo.Controls.Add(this.txtTasaInteres);
            this.tbgCalculo.Controls.Add(this.label8);
            this.tbgCalculo.Controls.Add(this.txtValorAnualidad);
            this.tbgCalculo.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgCalculo.Location = new System.Drawing.Point(4, 39);
            this.tbgCalculo.Name = "tbgCalculo";
            this.tbgCalculo.Padding = new System.Windows.Forms.Padding(3);
            this.tbgCalculo.Size = new System.Drawing.Size(1150, 625);
            this.tbgCalculo.TabIndex = 1;
            this.tbgCalculo.Text = "Calculo";
            this.tbgCalculo.Click += new System.EventHandler(this.tbgCalculo_Click);
            // 
            // dgvResultadoresPerpetuos
            // 
            this.dgvResultadoresPerpetuos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvResultadoresPerpetuos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultadoresPerpetuos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoresPerpetuos.Location = new System.Drawing.Point(55, 376);
            this.dgvResultadoresPerpetuos.Name = "dgvResultadoresPerpetuos";
            this.dgvResultadoresPerpetuos.RowHeadersWidth = 51;
            this.dgvResultadoresPerpetuos.Size = new System.Drawing.Size(506, 171);
            this.dgvResultadoresPerpetuos.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(46, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 39);
            this.label9.TabIndex = 12;
            this.label9.Text = "Resultados";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPeriodo.BackColor = System.Drawing.Color.Silver;
            this.txtPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeriodo.ForeColor = System.Drawing.Color.Black;
            this.txtPeriodo.Location = new System.Drawing.Point(813, 216);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(123, 38);
            this.txtPeriodo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(650, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Periodo";
            // 
            // btnLimpiarPerpetuo
            // 
            this.btnLimpiarPerpetuo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarPerpetuo.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarPerpetuo.FlatAppearance.BorderSize = 0;
            this.btnLimpiarPerpetuo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarPerpetuo.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarPerpetuo.Location = new System.Drawing.Point(751, 432);
            this.btnLimpiarPerpetuo.Name = "btnLimpiarPerpetuo";
            this.btnLimpiarPerpetuo.Size = new System.Drawing.Size(224, 95);
            this.btnLimpiarPerpetuo.TabIndex = 11;
            this.btnLimpiarPerpetuo.Text = "Limpiar";
            this.btnLimpiarPerpetuo.UseVisualStyleBackColor = false;
            this.btnLimpiarPerpetuo.Click += new System.EventHandler(this.btnLimpiarPerpetuo_Click);
            // 
            // btnCalcularPerpetuo
            // 
            this.btnCalcularPerpetuo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcularPerpetuo.BackColor = System.Drawing.Color.Black;
            this.btnCalcularPerpetuo.FlatAppearance.BorderSize = 0;
            this.btnCalcularPerpetuo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularPerpetuo.ForeColor = System.Drawing.Color.White;
            this.btnCalcularPerpetuo.Location = new System.Drawing.Point(751, 329);
            this.btnCalcularPerpetuo.Name = "btnCalcularPerpetuo";
            this.btnCalcularPerpetuo.Size = new System.Drawing.Size(224, 82);
            this.btnCalcularPerpetuo.TabIndex = 10;
            this.btnCalcularPerpetuo.Text = "Calcular";
            this.btnCalcularPerpetuo.UseVisualStyleBackColor = false;
            this.btnCalcularPerpetuo.Click += new System.EventHandler(this.btnCalcularPerpetuo_Click);
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTasaInteres.BackColor = System.Drawing.Color.Silver;
            this.txtTasaInteres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTasaInteres.ForeColor = System.Drawing.Color.Black;
            this.txtTasaInteres.Location = new System.Drawing.Point(813, 170);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(123, 38);
            this.txtTasaInteres.TabIndex = 7;
            this.txtTasaInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaInteres_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(596, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tasa interés";
            // 
            // txtValorAnualidad
            // 
            this.txtValorAnualidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorAnualidad.BackColor = System.Drawing.Color.Silver;
            this.txtValorAnualidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorAnualidad.ForeColor = System.Drawing.Color.Black;
            this.txtValorAnualidad.Location = new System.Drawing.Point(813, 121);
            this.txtValorAnualidad.Name = "txtValorAnualidad";
            this.txtValorAnualidad.Size = new System.Drawing.Size(123, 38);
            this.txtValorAnualidad.TabIndex = 5;
            this.txtValorAnualidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPresente_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(533, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 39);
            this.label7.TabIndex = 4;
            this.label7.Text = "Valor Anualidad";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(631, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 39);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ingresa los datos";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ecuación ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProyectoIng_Economica.Properties.Resources.Captura_de_pantalla__188_;
            this.pictureBox2.Location = new System.Drawing.Point(55, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(347, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FrmPerpetua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 668);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPerpetua";
            this.Text = "FrmPerpetua";
            this.tabControl1.ResumeLayout(false);
            this.tbgCalculo.ResumeLayout(false);
            this.tbgCalculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoresPerpetuos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbgCalculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLimpiarPerpetuo;
        private System.Windows.Forms.Button btnCalcularPerpetuo;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorAnualidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvResultadoresPerpetuos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label1;
    }
}