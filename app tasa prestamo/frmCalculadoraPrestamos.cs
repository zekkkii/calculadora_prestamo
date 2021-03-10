using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_tasa_prestamo.comboBoxItems;
using LogicLayer;

namespace app_tasa_prestamo
{
    public partial class frmCalculadoraPrestamos : Form
    {
        public frmCalculadoraPrestamos()
        {
            InitializeComponent();
        }

        private void frmCalculadoraPrestamos_Load(object sender, EventArgs e)
        {
            cargarComboBox();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cbxCuotasMensuales.Text != "" && cbxTipoPrestamo.Text != "" && txbMonto.Text != "")
            {
                double monto = double.Parse(txbMonto.Text);
                ComboBoxitem tipoPrestamoPorciento =cbxTipoPrestamo.SelectedItem as ComboBoxitem;
                ComboBoxitem cuotas = cbxCuotasMensuales.SelectedItem as ComboBoxitem;

                int porciento= (int)tipoPrestamoPorciento.Value;
                int cuotaMeses = (int)cuotas.Value;

               Calcular iniciarCalculo = new Calcular();
               double resultado = iniciarCalculo.calcularMontoPagar(monto, cuotaMeses, porciento);
               txbCuotaMensual.Text = Math.Round(resultado).ToString();
               txbTasa.Text = "Tasa: %" + porciento.ToString();

            }
            else
            {
                MessageBox.Show("Debes introducir valores...");
            }
        }
        private void cargarComboBox()
        { 
            #region mesesPrestamo
         

            ComboBoxitem _12_Meses = new ComboBoxitem
            {
                Text = "12 Meses",
                Value = 12
            };

            ComboBoxitem _24_Meses = new ComboBoxitem
            {
                Text = "24 Meses",
                Value = 24
            };

            ComboBoxitem _36_Meses = new ComboBoxitem
            {
                Text = "36 Meses",
                Value = 24
            };

            ComboBoxitem _48_Meses = new ComboBoxitem
            {
                Text = "48 Meses",
                Value = 48
            };

            ComboBoxitem _60_Meses = new ComboBoxitem
            {
                Text = "60 Meses",
                Value = 60
            };

            ComboBoxitem _72_Meses = new ComboBoxitem
            {
                Text = "72 Meses",
                Value = 72
            };

            ComboBoxitem _84_Meses = new ComboBoxitem
            {
                Text = "84 Meses",
                Value = 84
            };

            ComboBoxitem _96_Meses = new ComboBoxitem
            {
                Text = "96 Meses",
                Value = 96
            };

            ComboBoxitem _108_Meses = new ComboBoxitem
            {
                Text = "108 Meses",
                Value = 108
            };

            ComboBoxitem _120_Meses = new ComboBoxitem
            {
                Text = "120 Meses",
                Value = 120
            };



            
            cbxCuotasMensuales.Items.Add(_12_Meses);
            cbxCuotasMensuales.Items.Add(_24_Meses);
            cbxCuotasMensuales.Items.Add(_36_Meses);
            cbxCuotasMensuales.Items.Add(_48_Meses);
            cbxCuotasMensuales.Items.Add(_60_Meses);
            cbxCuotasMensuales.Items.Add(_72_Meses);
            cbxCuotasMensuales.Items.Add(_84_Meses);
            cbxCuotasMensuales.Items.Add(_96_Meses);
            cbxCuotasMensuales.Items.Add(_108_Meses);
            cbxCuotasMensuales.Items.Add(_120_Meses);
            #endregion

            #region tipo Prestamo

            ComboBoxitem personal  = new ComboBoxitem
            {
                Text = "Personal",
                Value = 22
            };

            ComboBoxitem vehiculo = new ComboBoxitem
            {
                Text = "Automóvil",
                Value = 12
            };

            ComboBoxitem hipoteca = new ComboBoxitem
            {
                Text = "Hipotecario",
                Value = 8
            };

            cbxTipoPrestamo.Items.Add(personal);
            cbxTipoPrestamo.Items.Add(vehiculo);
            cbxTipoPrestamo.Items.Add(hipoteca);
            #endregion
        }


    }
}
