namespace ProyectoIng_Economica
{
    partial class FrmTIR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTIR));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbgCalculo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDatosTIR = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnLimpiarTIR = new System.Windows.Forms.Button();
            this.btnCalCularTIR = new System.Windows.Forms.Button();
            this.txtInt2TIR = new System.Windows.Forms.TextBox();
            this.txtInt1Tir = new System.Windows.Forms.TextBox();
            this.txtVpn2TIR = new System.Windows.Forms.TextBox();
            this.txtVpn1TIR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tbgCalculo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosTIR)).BeginInit();
            this.panel11.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1576, 832);
            this.tabControl1.TabIndex = 0;
            // 
            // tbgCalculo
            // 
            this.tbgCalculo.BackColor = System.Drawing.Color.White;
            this.tbgCalculo.Controls.Add(this.pictureBox2);
            this.tbgCalculo.Controls.Add(this.label2);
            this.tbgCalculo.Controls.Add(this.panel1);
            this.tbgCalculo.Controls.Add(this.panel11);
            this.tbgCalculo.Location = new System.Drawing.Point(4, 39);
            this.tbgCalculo.Name = "tbgCalculo";
            this.tbgCalculo.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbgCalculo.Size = new System.Drawing.Size(1568, 789);
            this.tbgCalculo.TabIndex = 1;
            this.tbgCalculo.Text = "Calculo";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.dgvDatosTIR);
            this.panel1.Location = new System.Drawing.Point(252, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 371);
            this.panel1.TabIndex = 17;
            // 
            // dgvDatosTIR
            // 
            this.dgvDatosTIR.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDatosTIR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosTIR.Location = new System.Drawing.Point(25, 16);
            this.dgvDatosTIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatosTIR.Name = "dgvDatosTIR";
            this.dgvDatosTIR.RowHeadersWidth = 51;
            this.dgvDatosTIR.RowTemplate.Height = 24;
            this.dgvDatosTIR.Size = new System.Drawing.Size(513, 297);
            this.dgvDatosTIR.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.btnLimpiarTIR);
            this.panel11.Controls.Add(this.btnCalCularTIR);
            this.panel11.Controls.Add(this.txtInt2TIR);
            this.panel11.Controls.Add(this.txtInt1Tir);
            this.panel11.Controls.Add(this.txtVpn2TIR);
            this.panel11.Controls.Add(this.txtVpn1TIR);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Location = new System.Drawing.Point(849, 44);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(572, 545);
            this.panel11.TabIndex = 16;
            // 
            // btnLimpiarTIR
            // 
            this.btnLimpiarTIR.BackColor = System.Drawing.Color.Black;
            this.btnLimpiarTIR.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarTIR.Location = new System.Drawing.Point(297, 430);
            this.btnLimpiarTIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarTIR.Name = "btnLimpiarTIR";
            this.btnLimpiarTIR.Size = new System.Drawing.Size(251, 99);
            this.btnLimpiarTIR.TabIndex = 16;
            this.btnLimpiarTIR.Text = "Limpiar";
            this.btnLimpiarTIR.UseVisualStyleBackColor = false;
            this.btnLimpiarTIR.Click += new System.EventHandler(this.btnLimpiarTIR_Click);
            // 
            // btnCalCularTIR
            // 
            this.btnCalCularTIR.BackColor = System.Drawing.Color.Black;
            this.btnCalCularTIR.ForeColor = System.Drawing.Color.White;
            this.btnCalCularTIR.Location = new System.Drawing.Point(38, 430);
            this.btnCalCularTIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalCularTIR.Name = "btnCalCularTIR";
            this.btnCalCularTIR.Size = new System.Drawing.Size(229, 99);
            this.btnCalCularTIR.TabIndex = 15;
            this.btnCalCularTIR.Text = "Calcular";
            this.btnCalCularTIR.UseVisualStyleBackColor = false;
            this.btnCalCularTIR.Click += new System.EventHandler(this.btnCalCularTIR_Click);
            // 
            // txtInt2TIR
            // 
            this.txtInt2TIR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInt2TIR.Location = new System.Drawing.Point(370, 256);
            this.txtInt2TIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInt2TIR.Name = "txtInt2TIR";
            this.txtInt2TIR.Size = new System.Drawing.Size(125, 37);
            this.txtInt2TIR.TabIndex = 14;
            this.txtInt2TIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInt2TIR_KeyPress);
            // 
            // txtInt1Tir
            // 
            this.txtInt1Tir.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInt1Tir.Location = new System.Drawing.Point(369, 206);
            this.txtInt1Tir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInt1Tir.Name = "txtInt1Tir";
            this.txtInt1Tir.Size = new System.Drawing.Size(125, 37);
            this.txtInt1Tir.TabIndex = 13;
            this.txtInt1Tir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInt1Tir_KeyPress);
            // 
            // txtVpn2TIR
            // 
            this.txtVpn2TIR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtVpn2TIR.Location = new System.Drawing.Point(370, 161);
            this.txtVpn2TIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVpn2TIR.Name = "txtVpn2TIR";
            this.txtVpn2TIR.Size = new System.Drawing.Size(125, 37);
            this.txtVpn2TIR.TabIndex = 12;
            this.txtVpn2TIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVpn2TIR_KeyPress);
            // 
            // txtVpn1TIR
            // 
            this.txtVpn1TIR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtVpn1TIR.Location = new System.Drawing.Point(370, 115);
            this.txtVpn1TIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVpn1TIR.Name = "txtVpn1TIR";
            this.txtVpn1TIR.Size = new System.Drawing.Size(125, 37);
            this.txtVpn1TIR.TabIndex = 11;
            this.txtVpn1TIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVpn1TIR_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(207, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 45);
            this.label6.TabIndex = 9;
            this.label6.Text = "Interés 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(207, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "Interés 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-8, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Presente Neto 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(-8, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Presente Neto 1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(243, 31);
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
            this.pictureBox2.Location = new System.Drawing.Point(252, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FrmTIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 832);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTIR";
            this.Text = "FrmTIR";
            this.tabControl1.ResumeLayout(false);
            this.tbgCalculo.ResumeLayout(false);
            this.tbgCalculo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosTIR)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbgCalculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnCalCularTIR;
        private System.Windows.Forms.TextBox txtInt2TIR;
        private System.Windows.Forms.TextBox txtInt1Tir;
        private System.Windows.Forms.TextBox txtVpn2TIR;
        private System.Windows.Forms.TextBox txtVpn1TIR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiarTIR;
        private System.Windows.Forms.DataGridView dgvDatosTIR;
    }
}