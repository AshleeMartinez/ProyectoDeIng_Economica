﻿namespace ProyectoIng_Economica
{
    partial class FrmCalendarioPago
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.txtPeriodos = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnGenerarCalendario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCalendario = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnExcel);
            this.panel5.Controls.Add(this.txtPeriodos);
            this.panel5.Controls.Add(this.txtInteres);
            this.panel5.Controls.Add(this.txtSaldo);
            this.panel5.Controls.Add(this.btnLimpiarCampos);
            this.panel5.Controls.Add(this.btnGenerarCalendario);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(2, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(992, 187);
            this.panel5.TabIndex = 10;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(726, 79);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(178, 34);
            this.btnExcel.TabIndex = 15;
            this.btnExcel.Text = "EXPORTAR A EXCEL";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtPeriodos
            // 
            this.txtPeriodos.Location = new System.Drawing.Point(230, 133);
            this.txtPeriodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPeriodos.Multiline = true;
            this.txtPeriodos.Name = "txtPeriodos";
            this.txtPeriodos.Size = new System.Drawing.Size(163, 31);
            this.txtPeriodos.TabIndex = 14;
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(230, 76);
            this.txtInteres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInteres.Multiline = true;
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(163, 31);
            this.txtInteres.TabIndex = 13;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(230, 14);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSaldo.Multiline = true;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(163, 31);
            this.txtSaldo.TabIndex = 12;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(726, 131);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(178, 33);
            this.btnLimpiarCampos.TabIndex = 11;
            this.btnLimpiarCampos.Text = "LIMPIAR CAMPOS";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnGenerarCalendario
            // 
            this.btnGenerarCalendario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerarCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGenerarCalendario.FlatAppearance.BorderSize = 0;
            this.btnGenerarCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCalendario.ForeColor = System.Drawing.Color.White;
            this.btnGenerarCalendario.Location = new System.Drawing.Point(726, 12);
            this.btnGenerarCalendario.Name = "btnGenerarCalendario";
            this.btnGenerarCalendario.Size = new System.Drawing.Size(178, 59);
            this.btnGenerarCalendario.TabIndex = 10;
            this.btnGenerarCalendario.Text = "GENERAR CALENDARIO DE PAGO";
            this.btnGenerarCalendario.UseVisualStyleBackColor = false;
            this.btnGenerarCalendario.Click += new System.EventHandler(this.btnGenerarCalendario_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Periodos";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tasa interés";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "Saldo Inicial";
            // 
            // dgvCalendario
            // 
            this.dgvCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendario.Location = new System.Drawing.Point(2, 219);
            this.dgvCalendario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCalendario.Name = "dgvCalendario";
            this.dgvCalendario.RowHeadersWidth = 82;
            this.dgvCalendario.RowTemplate.Height = 33;
            this.dgvCalendario.Size = new System.Drawing.Size(992, 307);
            this.dgvCalendario.TabIndex = 11;
            // 
            // FrmCalendarioPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 573);
            this.Controls.Add(this.dgvCalendario);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCalendarioPago";
            this.Text = "FrmCalendarioPago";
            this.Load += new System.EventHandler(this.FrmCalendarioPago_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox txtPeriodos;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnGenerarCalendario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvCalendario;
    }
}