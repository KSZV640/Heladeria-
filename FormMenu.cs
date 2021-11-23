using BL.Heladeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heladeria
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();

        }

        private void login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            toolStripStatusLabel1.Text = "Usuario:" + Utilidades.NombreUsuario;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();
        }

       

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void accesoRapidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVentas = new FormVentas();
            formVentas.MdiParent = this;
            formVentas.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void heladeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
                formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void reportedeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProductos = new FormReporteProductos();
            formReporteProductos.MdiParent = this;
            formReporteProductos.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void reportedeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFactura = new FormReporteFacturas();
            formReporteFactura.MdiParent = this;
            formReporteFactura.Show();
        }
    }
}
