﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIng_Economica
{
    public partial class FrmAnualidadDiferidas : Form
    {
        public FrmAnualidadDiferidas()
        {
            InitializeComponent();
        }

 
        private void txtValorAnualidadPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteresPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoPresente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarPresente_Click(object sender, EventArgs e)
        {
            txtValorAnualidadPresente.Text = "";
            txtTasaInteresPresente.Text = "";
            txtPeriodoPresente.Text = "";
            txtPeriodo2.Text = "";
        }

        private void txtPeriodo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
         List<object> ResultadosPresente = new List<object>();

        private void btnCalcularPresente_Click(object sender, EventArgs e)
        {
            int Periodo1,Periodo2,p1,p2;
            double Anualidad;
            double Interes,i1,i2;
            if (rdbNop.Checked == true)
            {
                try
                {
                    Anualidad = Convert.ToDouble(txtValorAnualidadPresente.Text);
                    i1 = Convert.ToDouble(txtTasaInteresPresente.Text);
                    p1 = Convert.ToInt32(txtPeriodoPresente.Text);
                    p2 = Convert.ToInt32(txtPeriodo2.Text);

                    if (cmbInteresPresente.SelectedItem != null || cmbPeriodoPresente.SelectedItem != null)
                    {
                        if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 / 12;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 / 2;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 / 4;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        //Fin de interes anual
                        else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 * 12;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 * 6;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 * 3;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        //Fin de Interes Mensual
                        else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 * 2;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 / 6;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 / 2;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        // Fin de Tasa Interes Semestral
                        else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 * 4;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 / 3;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 * 2;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                        {

                            Interes = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        //Fin Tasa Interes Trimestral
                    }

                }
                catch (FormatException x)
                {
                    MessageBox.Show("Rellene los campos necesarios" + x);
                }
            }
            else if(rdbSip.Checked == true)
            {
                var metodos2 = new Metodos();
                string InteresPresente = cmbInteresPresente.SelectedItem.ToString();
                string PeriodoPresente = cmbPeriodoPresente.SelectedItem.ToString();
                double TasaInteresPresente = Convert.ToDouble(txtTasaInteresPresente.Text);
                double ValorAnualidadPresente = Convert.ToDouble(txtValorAnualidadPresente.Text);
                int Periodo1Futuro = Convert.ToInt32(txtPeriodoPresente.Text);
                int Periodo2Futuro = Convert.ToInt32(txtPeriodo2.Text);

                // metodos2.CalcularPresente(InteresPresente, PeriodoPresente, TasaInteresPresente, ValorAnualidadPresente, Periodo1Futuro, Periodo2Futuro);
                metodos2.CalcularPresente(InteresPresente, PeriodoPresente, TasaInteresPresente, ValorAnualidadPresente, Periodo1Futuro, Periodo2Futuro, ResultadosPresente, dgvResultadosPresente);
            }
        }// Calcular Presente

        private void txtValorAnualidadFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTasaInteresFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodo1Futuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodo2Futuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiarFuturo_Click(object sender, EventArgs e)
        {
            txtValorAnualidadFuturo.Text = "";
            txtTasaInteresFuturo.Text = "";
            txtPeriodo1Futuro.Text = "";
            txtPeriodo2Futuro.Text = "";
        }

         List<object> ResultadosFuturo = new List<object>();
        private void btnCalcularFuturo_Click(object sender, EventArgs e)
        {
            
         int p1, p2, Periodo1, Periodo2;
         double TasaInteres, i1, AnualidadFuturo = 0;
            if (rdbNo.Checked == true)
            {
                try
                {
                    AnualidadFuturo = Convert.ToDouble(txtValorAnualidadFuturo.Text);
                    i1 = Convert.ToDouble(txtTasaInteresFuturo.Text);
                    p1 = Convert.ToInt32(txtPeriodo1Futuro.Text);
                    p2 = Convert.ToInt32(txtPeriodo2Futuro.Text);

                    if (cmbInteresFuturo.SelectedItem != null || cmbPeriodoFuturo.SelectedItem != null)
                    {
                        if (cmbInteresFuturo.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 / 12;
                            Periodo2 = p2 / 12;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 / 2;
                            Periodo2 = p2 / 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 / 4;
                            Periodo2 = p2 / 4;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        //Fin de tasa Interes Anual

                        else if (cmbInteresFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 * 12;
                            Periodo2 = p2 * 12;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 * 6;
                            Periodo2 = p2 * 6;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 * 3;
                            Periodo2 = p2 * 3;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        //Fin de Tasa Interes Mensual
                        else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 * 2;
                            Periodo2 = p2 * 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 / 6;
                            Periodo2 = p2 / 6;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 / 2;
                            Periodo2 = p2 / 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        // Fin de Tasa Interes Semestral

                        else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 * 4;
                            Periodo2 = p2 * 4;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }

                        else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 / 3;
                            Periodo2 = p2 / 3;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 * 2;
                            Periodo2 = p2 * 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {

                            TasaInteres = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        //Fin de Tasa interes Trimestral
                    }
                }
                catch (FormatException x)
                {
                    MessageBox.Show("Rellene los campos necesarios"+x);
                }
            }else if (rdbSi.Checked == true)
            {
                var metodos = new Metodos();
                string interesFuturo = cmbInteresFuturo.SelectedItem.ToString();
                string periodoFuturo = cmbPeriodoFuturo.SelectedItem.ToString();
                double tasaInteresFuturo = Convert.ToDouble(txtTasaInteresFuturo.Text);
                double valorAnualidadFuturo = Convert.ToDouble(txtValorAnualidadFuturo.Text);
                int periodo1Futuro = Convert.ToInt32(txtPeriodo1Futuro.Text);
                int periodo2Futuro = Convert.ToInt32(txtPeriodo2Futuro.Text);

                metodos.CalcularFuturo(interesFuturo, periodoFuturo, tasaInteresFuturo, valorAnualidadFuturo, periodo1Futuro, periodo2Futuro, ResultadosFuturo, dgvResultadosFuturo);
               
            }
        }//De evento calcular

        private void txtValorPresenteAnualidadVencida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInteresAnualidadVencida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoAnualidadVencida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

       

        private void txtValorFuturoAnualidadFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInteresAnualidadFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoAnualidadFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        
        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            //Ignorar
        }

        private void dgvResultadosAnualidadFuturo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
