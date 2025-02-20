﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIng_Economica
{
    public partial class FrmPerpetua : Form
    {
        public FrmPerpetua()
        {
            InitializeComponent();
        }

        private void txtValorPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarPerpetuo_Click(object sender, EventArgs e)
        {
            txtValorAnualidad.Text = "";
            txtTasaInteres.Text = "";
        }
        private List<object> ResultadosPerpetuo = new List<object>();
        private void btnCalcularPerpetuo_Click(object sender, EventArgs e)
        {
            try
            {
                double A;
                int N = Convert.ToInt32(txtPeriodo.Text);
                int N2 = N * 12;
                int n3 = N2 - 1;
                A = Convert.ToDouble(txtValorAnualidad.Text);
                double i = Convert.ToDouble(txtTasaInteres.Text) / 100;
                double P = A / i;
                double p2 = P * (Math.Pow(1+i,-n3));
                ResultadosPerpetuo.Add(new { Presente = p2, Interes = i,Anualidad = A});
                dgvResultadoresPerpetuos.DataSource = null;
                dgvResultadoresPerpetuos.DataSource = ResultadosPerpetuo.ToList();
            }catch(FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios"+x);
            }
        }

        private void tbgCalculo_Click(object sender, EventArgs e)
        {

        }
    }
}
