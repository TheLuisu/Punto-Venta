using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cbobusqueda.Items.Add(new opcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;
        }

        private void btnbuscarreporte_Click(object sender, EventArgs e)
        {
            List<ReporteVentas> lista = new List<ReporteVentas>();

            lista = new CNReporteVentas().Venta(txtfechainicio.Value.ToString(), txtfechafin.Value.ToString());

            dgvdata.Rows.Clear();

            foreach (ReporteVentas rv in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    rv.fechaRegistro,
                    rv.tipoDocumento,
                    rv.numDocumento,
                    rv.montoTotal,
                    rv.nombreCompleto,
                    rv.documentoCliente,
                    rv.nombreCliente,
                    rv.codigo,
                    rv.nombre,
                    rv.descripcion,
                    rv.precioVenta,
                    rv.cantidad,
                    rv.subTotal
                });
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((opcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
