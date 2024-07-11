using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace ProyectoIng_Economica
{
    public partial class FrmVPN : Form
    {
        public FrmVPN()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double inversionInicial = ObtenerValorNumerico(txtInversionInicial.Text, "Inversión Inicial");
                double tasaDescuento = ObtenerValorNumerico(txtTasaDescuento.Text, "Tasa de Descuento") / 100;

                double vpn = -inversionInicial;
                List<object> resultados = new List<object>
        {
            new { Año = 0, FNE = -inversionInicial, VPN = -inversionInicial }
        };

                foreach (DataGridViewRow row in dgvFlujosNetos.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        int año = ObtenerValorEntero(row.Cells[0].Value.ToString(), row.Index + 1, "Año");
                        double flujoNetoEfectivo = ObtenerValorNumerico(row.Cells[1].Value.ToString(), row.Index + 1, "Flujo Neto Efectivo");

                        double valorPresenteNeto = flujoNetoEfectivo / Math.Pow(1 + tasaDescuento, año);
                        vpn += valorPresenteNeto;

                        resultados.Add(new { Año = año, FNE = flujoNetoEfectivo, VPN = valorPresenteNeto });
                    }
                }

                resultados.Add(new { Año = "Total", FNE = (double?)null, VPN = vpn });

                dgvResultados.Rows.Clear(); // Limpiar el DataGridView antes de llenarlo

                foreach (var resultado in resultados)
                {
                    dgvResultados.Rows.Add(resultado.GetType().GetProperty("Año").GetValue(resultado),
                                           resultado.GetType().GetProperty("FNE").GetValue(resultado),
                                           resultado.GetType().GetProperty("VPN").GetValue(resultado));
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("ERROR: Número demasiado grande. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }



        }







        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInversionInicial.Clear();
            txtTasaDescuento.Clear();
            txtAnios.Clear();
            dgvFlujosNetos.Rows.Clear();
            dgvResultados.Rows.Clear();
        }




        private void txtAnios_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtAnios.Text, out int años))
            {
                dgvFlujosNetos.Rows.Clear(); // Limpiar el DataGridView antes de llenarlo

                for (int año = 1; año <= años; año++)
                {
                    dgvFlujosNetos.Rows.Add(año, ""); // Agregar fila con el año, FNE inicialmente vacío
                }
            }
            else
            {
                dgvFlujosNetos.Rows.Clear(); // Limpiar el DataGridView si hay un error
            }
        }

       
        private void tbgCalculo_Click(object sender, EventArgs e)
        {



        }

        private double ObtenerValorNumerico(string valor, string nombreCampo)
        {
            if (!double.TryParse(valor, out double resultado))
            {
                throw new FormatException($"ERROR: Formato inválido en el campo '{nombreCampo}'. Por favor, asegúrese de que el valor es numérico.");
            }
            return resultado;
        }

        private double ObtenerValorNumerico(string valor, int fila, string nombreCampo)
        {
            if (!double.TryParse(valor, out double resultado))
            {
                throw new FormatException($"ERROR: Formato inválido en la columna '{nombreCampo}' en la fila {fila}. Valor: {valor}. Por favor, asegúrese de que el valor es numérico.");
            }
            return resultado;
        }

        private int ObtenerValorEntero(string valor, int fila, string nombreCampo)
        {
            if (!int.TryParse(valor, out int resultado))
            {
                throw new FormatException($"ERROR: Formato inválido en la columna '{nombreCampo}' en la fila {fila}. Valor: {valor}. Por favor, asegúrese de que el valor es numérico.");
            }
            return resultado;
        }


    }
}
