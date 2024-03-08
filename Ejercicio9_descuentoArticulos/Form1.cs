using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9_Descuento_Articulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_monto.Enabled = false;
            txt_itbis.Enabled = false;
            txt_montoNeto.Enabled = false;
            txt_itbis.Enabled = false;
            txt_descuentoAplicar.Enabled = false;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

            txt_descuento.Clear();
            txt_descuentoAplicar.Clear();
            txt_itbis.Clear();
            txt_monto.Clear();
            txt_montoNeto.Clear();
            txt_precio.Clear();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            {
                double Precio, Descuento1, Descuento2, Descuento3, Descuento4, Itbis, MontoNeto;

                Precio = double.Parse(txt_precio.Text);
                Descuento1 = Precio * 0.03;
                Descuento2 = Precio * 0.05;
                Descuento3 = Precio * 0.08;
                Descuento4 = Precio * 0.10;
                Itbis = Precio * 0.18;


                if (Precio <= 5000)

                {

                    txt_descuento.Text = "No Aplica";
                    txt_descuento.ForeColor = Color.Red;
                    txt_monto.Text = String.Empty;
                    txt_descuentoAplicar.Text = String.Empty;
                    txt_itbis.Text = String.Empty;
                    txt_montoNeto.Text = String.Empty;
                    txt_monto.Enabled = false;
                    txt_itbis.Enabled = false;
                    txt_montoNeto.Enabled = false;
                    txt_itbis.Enabled = false;
                    txt_descuentoAplicar.Enabled = false;


                }


                else if (Precio <= 10000)
                {
                    MontoNeto = (Precio - Descuento1 + Itbis);
                    txt_descuento.Text = "Aplica";
                    txt_descuento.ForeColor = Color.Green;
                    txt_monto.Text = Precio.ToString();
                    txt_descuentoAplicar.Text = Descuento1.ToString();
                    txt_itbis.Text = Itbis.ToString();
                    txt_montoNeto.Text = MontoNeto.ToString();


                }

                else if (Precio <= 15000)
                {
                    MontoNeto = (Precio - Descuento2 + Itbis);
                    txt_descuento.Text = "Aplica";
                    txt_descuento.ForeColor = Color.Green;
                    txt_monto.Text = Precio.ToString();
                    txt_descuentoAplicar.Text = Descuento2.ToString();
                    txt_itbis.Text = Itbis.ToString();
                    txt_montoNeto.Text = MontoNeto.ToString();


                }

                else if (Precio <= 20000)
                {
                    MontoNeto = (Precio - Descuento3 + Itbis);
                    txt_descuento.Text = "Aplica";
                    txt_descuento.ForeColor = Color.Green;
                    txt_monto.Text = Precio.ToString();
                    txt_descuentoAplicar.Text = Descuento3.ToString();
                    txt_itbis.Text = Itbis.ToString();
                    txt_montoNeto.Text = MontoNeto.ToString();



                }

                else if (Precio > 20000)
                {
                    MontoNeto = (Precio - Descuento4 + Itbis);
                    txt_descuento.Text = "Aplica";
                    txt_descuento.ForeColor = Color.Green;
                    txt_monto.Text = Precio.ToString();
                    txt_descuentoAplicar.Text = Descuento4.ToString();
                    txt_itbis.Text = Itbis.ToString();
                    txt_montoNeto.Text = MontoNeto.ToString();

                }
            }


        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

