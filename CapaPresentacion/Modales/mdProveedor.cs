﻿using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdProveedor : Form
    {
        public Proveedor _Proveedor { get; set; }

        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new opcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<Proveedor> lista = new CNProveedor().Listar();

            foreach (Proveedor item in lista)
            {
                dgvdata.Rows.Add(new object[] { item.idProveedor, item.documento, item.razonSocial });
            }
        }

        private void dgvdata_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
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

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                _Proveedor = new Proveedor()
                {
                    idProveedor = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Id"].Value.ToString()),
                    documento = dgvdata.Rows[iRow].Cells["Documento"].Value.ToString(),
                    razonSocial = dgvdata.Rows[iRow].Cells["RazonSocial"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
