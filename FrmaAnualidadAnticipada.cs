using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIng_Economica
{
    public partial class FrmaAnualidadAnticipada : Form
    {
        public FrmaAnualidadAnticipada()
        {
            InitializeComponent();
        }

        private void tbgDefinicion_Click(object sender, EventArgs e)
        {
            //Ignorar
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

        private void txtInteresPresente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            txtValorAnualidadPresente.Text = "";
            txtInteresPresente.Text = "";
            txtPeriodoPresente.Text = "";
        }
        List<object> ResultadosPresente = new List<object>();
        private void button4_Click(object sender, EventArgs e)
        {
          if (rdbNo.Checked == true) { 
            try
            {
                double ValorAnualidadPresente, Interes, i1, AnualidadPresente;
                int periodo1, p1;

                ValorAnualidadPresente = Convert.ToDouble(txtValorAnualidadPresente.Text);
                i1 = Convert.ToDouble(txtInteresPresente.Text);
                p1 = Convert.ToInt32(txtPeriodoPresente.Text);
                if (cmbInteresPresente.SelectedItem != null || cmbPeriodoPresente.SelectedItem != null)
                {
                    if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {
                        Interes = i1 / 100;
                        periodo1 = p1;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();


                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 / 12;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 / 2;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 / 4;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 * 12;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 * 6;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 * 3;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 * 2;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 / 6;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 / 2;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 * 4;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 / 3;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1 * 2;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                    else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                    {

                        Interes = i1 / 100;
                        periodo1 = p1;
                        AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                        ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                        dgvResultadosPresente.DataSource = null;
                        dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                    }
                }
            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios " + x);
            }
          } 
          else if (rdbSi.Checked == true)
          {
                var metodo3 = new Metodos();
                string interesPresente = cmbInteresPresente.SelectedItem.ToString();
                string periodoPresente = cmbPeriodoPresente.SelectedItem.ToString();
                double TasaperiodoPresente = Convert.ToDouble(txtInteresPresente.Text);
                double valorAnualidadPresente = Convert.ToDouble(txtValorAnualidadPresente.Text);
                int periodo1Presente = Convert.ToInt32(txtPeriodoPresente.Text);
                metodo3.CalcularPresenteAnticipado(interesPresente, periodoPresente, TasaperiodoPresente, valorAnualidadPresente, periodo1Presente,ResultadosPresente, dgvResultadosPresente);
            }
        }
        //Fin presente
        List<object> ResultadosFuturo = new List<object>();
        private void btnCalcularFuturo_Click(object sender, EventArgs e)
        {
            double AnualidadFuturo,TasaInteresFuturo,i1;
            int Periodo, p1;
            if (rdbNoFuturo.Checked == true)
            {
                try
                {
                    AnualidadFuturo = Convert.ToDouble(txtValorAnualidadFuturo.Text);
                    i1 = Convert.ToDouble(txtTasaInteresFuturo.Text);
                    p1 = Convert.ToInt32(txtPeriodoFuturo.Text);
                    if (cmbInteresAnualidadF.SelectedItem != null && cmbPeriodoFuturo.SelectedItem != null)
                    {
                        if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 12;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();

                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 4;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();

                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 12;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 6;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 3;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 6;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 4;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 3;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                    }
                }
                catch (FormatException x)
                {
                    MessageBox.Show("Rellene los campos necesarios" + x);
                }
            }else if (rdbSiFuturo.Checked == true)
            {
                var metodos4 = new Metodos();
                string InteresFuturo = cmbInteresAnualidadF.SelectedItem.ToString();
                string PeriodoFuturo = cmbPeriodoFuturo.SelectedItem.ToString();
                double TasaInteres = Convert.ToDouble(txtTasaInteresFuturo.Text);
                double valorAnualidadFuturo = Convert.ToDouble(txtValorAnualidadFuturo.Text);
                int Periodo1 = Convert.ToInt32(txtPeriodoFuturo.Text);

                metodos4.CalcularFuturoAnticipado(InteresFuturo,PeriodoFuturo,TasaInteres,valorAnualidadFuturo,Periodo1,ResultadosFuturo,dgvResultadosFuturo);
            }
        }// boton futuro

        private void txtValorAnualidadFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
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

        private void txtPeriodoFuturo_KeyPress(object sender, KeyPressEventArgs e)
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
            txtPeriodoFuturo.Text = "";
        }
        //Fin Futuro

        private void txtValorPresenteAnualidadAnticipada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtInteresAnualidadAnticipada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeriodoAnualidadAnticipada_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
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

        

        private void cmbInteresAf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtInteresAnualidadFuturo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            //ignorar
        }
    }
}
