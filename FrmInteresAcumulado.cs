﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ProyectoIng_Economica
{
    public partial class FrmInteresAcumulado : Form
    {
        public FrmInteresAcumulado()
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

        private void txtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorPresente.Text = "";
            txtTasaInteres.Text = "";
            txtPeriodo.Text = "";
        }
        private List<object> ResultadosAcumulado = new List<object>();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double P, i = 0, I = 0, n = 0;
            double i1, n1;
            P = double.Parse(txtValorPresente.Text);
            i1 = double.Parse(txtTasaInteres.Text);
            n1 = double.Parse(txtPeriodo.Text);

            try
            {
                if (cmbInteresAcum.SelectedItem != null || cmbPeriodoAcum.SelectedItem != null)
                {
                    if (cmbInteresAcum.SelectedItem.Equals("Anual") && cmbPeriodoAcum.SelectedItem.Equals("Años"))
                    {
                        n = n1;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Anual") && cmbPeriodoAcum.SelectedItem.Equals("Meses"))
                    {
                        n = n1;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Anual") && cmbPeriodoAcum.SelectedItem.Equals("Semestres"))
                    {
                        n = (int)(n1 * 0.5);
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Anual") && cmbPeriodoAcum.SelectedItem.Equals("Trimestres"))
                    {
                        n = n1 / 4;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Mensual") && cmbPeriodoAcum.SelectedItem.Equals("Años"))
                    {
                        n = n1 * 12;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Mensual") && cmbPeriodoAcum.SelectedItem.Equals("Meses"))
                    {
                        n = n1;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Mensual") && cmbPeriodoAcum.SelectedItem.Equals("Semestres"))
                    {
                        n = n1 * 6;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Mensual") && cmbPeriodoAcum.SelectedItem.Equals("Trimestres"))
                    {
                        n = n1 * 3;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Semestral") && cmbPeriodoAcum.SelectedItem.Equals("Años"))
                    {
                        n = n1* 2;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Semestral") && cmbPeriodoAcum.SelectedItem.Equals("Meses"))
                    {
                        n = n1 / 6;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Semestral") && cmbPeriodoAcum.SelectedItem.Equals("Semestres"))
                    {
                        n = n1;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Semestral") && cmbPeriodoAcum.SelectedItem.Equals("Trimestral"))
                    {
                        n = n1 / 2;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Trimestral") && cmbPeriodoAcum.SelectedItem.Equals("Años"))
                    {
                        n = n1 * 4;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Trimestral") && cmbPeriodoAcum.SelectedItem.Equals("Meses"))
                    {
                        n = n1 / 3;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Trimestral") && cmbPeriodoAcum.SelectedItem.Equals("Semestres"))
                    {
                        n = n1 * 2;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Trimestral") && cmbPeriodoAcum.SelectedItem.Equals("Trimestres"))
                    {
                        n = n1;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                }
            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios");
            }
        }
    }
}
