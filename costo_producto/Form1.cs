using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace costo_producto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_monto.Text, out double montoTotal))
            {
                double descuento = 0;
                double itbis = montoTotal * 0.18;
                txt_itbis.Text = itbis.ToString();

                if (montoTotal >= 5001 && montoTotal <= 10000)
                {
                    descuento = montoTotal * 0.03;
                }
                else if (montoTotal > 10000 && montoTotal <= 15000)
                {
                    descuento = montoTotal * 0.05;
                }
                else if (montoTotal > 15000 && montoTotal <= 20000)
                {
                    descuento = montoTotal * 0.08;
                }
                else if (montoTotal > 20000)
                {
                    descuento = montoTotal * 0.1;
                }
                else
                {
                    txt_descuento.Text = "no aplica";
                }

                double montoNeto = montoTotal - descuento + itbis;

                txt_monto_neto.Text = montoNeto.ToString();
                txt_monto.Text = montoTotal.ToString();
                txt_descuento.Text = descuento.ToString();
                txt_itbis.Text = itbis.ToString();

            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_monto.Clear();
            txt_descuento.Clear();
            txt_itbis.Clear();
            txt_monto_neto.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
