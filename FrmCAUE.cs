﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIng_Economica
{
    public partial class FrmCAUE : Form
    {
        public FrmCAUE()
        {
            InitializeComponent();
        }

        private void txtValorI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorVs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarCAUE1_Click(object sender, EventArgs e)
        {
            txtValorI.Text = "";
            txtValorVs.Text = "";
            txtInteres.Text = "";
            txtPeriodo.Text = "";
            txtValorC.Text = "";
        }
        private List<object> ResultadosCAUE1 = new List<object>();
        private void btnCalcularCAUE1_Click(object sender, EventArgs e)
        {
            try
            {
                double ValorI = Convert.ToDouble(txtValorI.Text);
                double ValorVs = Convert.ToDouble(txtValorVs.Text);
                double Interes = Convert.ToDouble(txtInteres.Text) / 100;
                int Periodo = Convert.ToInt32(txtPeriodo.Text);
                double ValorC = Convert.ToDouble(txtValorC.Text);

                double Resultado1 = CalcularAnualidadVencidaPresente(Interes, Periodo);
                double Resultado2 = CalcularAnualidadVencipdaFuturo(Interes, Periodo);
                double CAUE = ValorI * (Resultado1) - 2600 * (Resultado2) + 500;
                ResultadosCAUE1.Add(new {ValorI = ValorI, ValorVs = ValorVs, Interes = Interes,Periodo = Periodo,ValorC = ValorC,Caue = CAUE });
                dgvResultadosCAUE1.DataSource = null;
                dgvResultadosCAUE1.DataSource = ResultadosCAUE1.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Rellene los campos necesarios "+ex);
            }
        }

        private double CalcularAnualidadVencidaPresente(double i, int n)
        {
            double parteSuperior = i * Math.Pow(1 + i, n);
            double parteInferior = Math.Pow(1 + i, n) - 1;
            return parteSuperior / parteInferior;
        }

        private double CalcularAnualidadVencipdaFuturo(double i,int n)
        {
            double parteInferior = Math.Pow(1 + i, n) - 1;
            return i / parteInferior;
        }

        private void txtValorP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorVs2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInteres2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPlazo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPlazo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorC2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            txtValorP2.Text = "";
            txtValorVs2.Text = "";
            txtInteres2.Text = "";
            txtPlazo1.Text = "";
            txtPlazo2.Text = "";
            txtValorC2.Text = "";
            txtCRE.Text = "";
        }
        private List<object> ResultadosCAUE2 = new List<object>();
        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            try
            { 
                double ValorP = Convert.ToDouble(txtValorP2.Text);
                double ValorVs = Convert.ToDouble(txtValorVs2.Text);
                double Interes = Convert.ToDouble(txtInteres2.Text) / 100;
                int Periodo1 = Convert.ToInt32(txtPlazo1.Text);
                int Periodo2 = Convert.ToInt32(txtPlazo2.Text);
                double ValorC = Convert.ToDouble(txtValorC2.Text);
                double Cre = Convert.ToDouble(txtCRE.Text);

                double Resultado1 = CalcularPresente(Interes,Periodo1);
                double Resultado2 = CalcularPresente(Interes, Periodo2);
                double Resultado3 = CalcularAnualidadVencidaPresente(Interes, Periodo1);

                double Caue = (ValorP - ValorVs * (Resultado1) + Cre * (Resultado2)) * (Resultado3) + ValorC;
                ResultadosCAUE2.Add(new {ValorP = ValorP, ValorVs = ValorVs, Interes = Interes, Plazo1 = Periodo1, Plazo2 = Periodo2,ValorC = ValorC,Cre = Cre, CAUE = Caue });
                dgvResultados2.DataSource = null;
                dgvResultados2.DataSource = ResultadosCAUE2.ToList();
            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios"+x);
            }

        }

        private double CalcularPresente(double i, int n)
        {
            return Math.Pow(1 + i,-n);
        }


    }
}
