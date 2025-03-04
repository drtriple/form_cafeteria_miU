using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libOpeCafeteria;

namespace mainCafeteriaMiU
{
    public partial class frmCafeteriaMiU: Form
    {
        public frmCafeteriaMiU()
        {
            InitializeComponent();
        }

        private void Mensaje(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {
                MessageBox.Show(texto, "Cafetería Mi U", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LlenarComboDias()
        {
            cmbDia.Items.Add("Seleccione un día");
            cmbDia.Items.Add("Lunes");
            cmbDia.Items.Add("Martes");
            cmbDia.Items.Add("Miércoles");
            cmbDia.Items.Add("Jueves");
            cmbDia.Items.Add("Viernes");
            cmbDia.Items.Add("Sábado");
            cmbDia.SelectedIndex = 0;
        }

        private void frmCafeteriaMiU_Load(object sender, EventArgs e)
        {
            LlenarComboDias();
            grpResultados.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbDia.SelectedIndex = 0;
            foreach (int index in chkValor.CheckedIndices)
            {
                chkValor.SetItemChecked(index, false);
            }
            lblValorUnitario.Text = "0";
            lblCantidadNormal.Text = "0";
            lblCantidadAdicional.Text = "0";
            lblCantidadTotal.Text = "0";
            lblValorTotal.Text = "0";
            grpResultados.Visible = false;
            cmbDia.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDia.SelectedIndex == 0)
                {
                    Mensaje("Debe seleccionar un día de la semana");
                    cmbDia.Focus();
                    return;
                }

                string strDia = cmbDia.SelectedItem.ToString();
                bool blnQuincena = chkValor.CheckedItems.Contains("Quincena");
                bool blnFestivo = chkValor.CheckedItems.Contains("Festivo");

                // Crear objeto de operaciones
                clsOpeCafeteria ope = new clsOpeCafeteria();

                // Enviar datos
                ope.Dia = strDia;
                ope.EsQuincena = blnQuincena;
                ope.EsFestivo = blnFestivo;

                // Invocar método y tratar error
                if (!ope.CalcularPedido())
                {
                    Mensaje(ope.Error);
                    ope = null;
                    return;
                }

                // Mostrar resultados
                lblValorUnitario.Text = ope.ValorUnitarioLibra.ToString("N2");
                lblCantidadNormal.Text = ope.CantidadLibrasNormal.ToString("N2");
                lblCantidadAdicional.Text = ope.CantidadLibrasAdicional.ToString("N2");
                lblCantidadTotal.Text = ope.CantidadLibrasTotal.ToString("N2");
                lblValorTotal.Text = ope.ValorTotalPagar.ToString("N2");

                // Hacer visible el grupo de resultados
                grpResultados.Visible = true;

                ope = null;
            }
            catch (Exception ex)
            {
                Mensaje("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
