using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Deposito
{
    public partial class frmConfigClaves : Form
    {
        private static readonly Color ColorTexto = Color.FromArgb(31, 41, 55);
        private static readonly Color ColorPrimario = Color.FromArgb(15, 111, 98);
        private static readonly Color ColorSuave = Color.FromArgb(248, 250, 252);
        private static readonly Color ColorBorde = Color.FromArgb(229, 231, 235);
        private static readonly Color ColorError = Color.FromArgb(185, 28, 28);
        private static readonly Color ColorCorrecto = Color.FromArgb(15, 118, 110);
        private static readonly Color ColorAdvertencia = Color.FromArgb(180, 83, 9);

        private List<ClaveUsuario> admins = new List<ClaveUsuario>();
        private bool cargando;

        public frmConfigClaves()
        {
            InitializeComponent();
        }

        private void frmConfigClaves_Load(object sender, EventArgs e)
        {
            aplicarEstiloGrid(dgvAdmins);
            aplicarEstiloGrid(dgvPantallas);
            dgvAdmins.AutoGenerateColumns = false;

            colTipoClave.DataSource = new[]
            {
                new { Valor = (short)1, Texto = "Clave 1" },
                new { Valor = (short)2, Texto = "Clave 2" }
            };
            colTipoClave.ValueMember = "Valor";
            colTipoClave.DisplayMember = "Texto";

            cargarPantallas();
            cargarAdmins(null);
        }

        private void aplicarEstiloGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeight = 32;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = ColorBorde;
            grid.RowTemplate.Height = 30;
            grid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = ColorSuave,
                ForeColor = Color.FromArgb(107, 114, 128),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                SelectionBackColor = ColorSuave,
                SelectionForeColor = Color.FromArgb(107, 114, 128)
            };
            grid.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = ColorTexto,
                Font = new Font("Segoe UI", 9.5F),
                SelectionBackColor = ColorPrimario,
                SelectionForeColor = Color.White
            };
        }

        private void cargarAdmins(int? idSeleccionar)
        {
            admins = Bs_ClaveAcceso.obtenerAdmins();

            cargando = true;
            dgvAdmins.DataSource = null;
            dgvAdmins.DataSource = admins;
            cargando = false;

            int indice = idSeleccionar.HasValue ? admins.FindIndex(a => a.Id == idSeleccionar.Value) : 0;
            if (indice < 0)
            {
                indice = 0;
            }
            if (dgvAdmins.Rows.Count > 0)
            {
                dgvAdmins.ClearSelection();
                dgvAdmins.Rows[indice].Selected = true;
                dgvAdmins.CurrentCell = dgvAdmins.Rows[indice].Cells[colNombre.Index];
            }

            mostrarAdmin();
            actualizarAviso();
        }

        private void cargarPantallas()
        {
            cargando = true;
            dgvPantallas.Rows.Clear();
            foreach (var pantalla in Bs_ClaveAcceso.obtenerPantallas())
            {
                dgvPantallas.Rows.Add(pantalla.PANTALLA, pantalla.DESCRIPCION, pantalla.TIPOCLAVE);
            }
            dgvPantallas.ClearSelection();
            cargando = false;
        }

        private ClaveUsuario adminSeleccionado()
        {
            if (dgvAdmins.CurrentRow == null || dgvAdmins.CurrentRow.Index < 0 || dgvAdmins.CurrentRow.Index >= admins.Count)
            {
                return null;
            }
            return admins[dgvAdmins.CurrentRow.Index];
        }

        private void mostrarAdmin()
        {
            var admin = adminSeleccionado();
            pnlEdicion.Enabled = admin != null;
            lbledicion.Text = admin != null ? "Claves de " + admin.Nombre : "No hay administradores";
            limpiarCampos();
            ocultarMensaje();
        }

        private void limpiarCampos()
        {
            txtclave1.Clear();
            txtconfirmar1.Clear();
            txtclave2.Clear();
            txtconfirmar2.Clear();
        }

        private void dgvAdmins_SelectionChanged(object sender, EventArgs e)
        {
            if (!cargando)
            {
                mostrarAdmin();
            }
        }

        private void dgvAdmins_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Nunca se muestra la clave: solo si está definida o no
            if (e.RowIndex < 0 || (e.ColumnIndex != colClave1.Index && e.ColumnIndex != colClave2.Index))
            {
                return;
            }

            bool definida = e.Value is bool && (bool)e.Value;
            e.Value = definida ? "✔ Definida" : "Sin definir";
            e.CellStyle.ForeColor = definida ? ColorCorrecto : ColorAdvertencia;
            e.CellStyle.SelectionForeColor = Color.White;
            e.FormattingApplied = true;
        }

        private void chkmostrar_CheckedChanged(object sender, EventArgs e)
        {
            bool ocultar = !chkmostrar.Checked;
            txtclave1.UseSystemPasswordChar = ocultar;
            txtconfirmar1.UseSystemPasswordChar = ocultar;
            txtclave2.UseSystemPasswordChar = ocultar;
            txtconfirmar2.UseSystemPasswordChar = ocultar;
        }

        private void campoClave_TextChanged(object sender, EventArgs e)
        {
            ocultarMensaje();
        }

        private void ocultarMensaje()
        {
            lblmensaje.Visible = false;
        }

        private void mostrarMensaje(string texto, bool error)
        {
            lblmensaje.Text = texto;
            lblmensaje.ForeColor = error ? ColorError : ColorCorrecto;
            lblmensaje.Visible = true;
        }

        private void btnGuardarClaves_Click(object sender, EventArgs e)
        {
            var admin = adminSeleccionado();
            if (admin == null)
            {
                return;
            }

            if (txtclave1.Text.Length == 0 && txtclave2.Text.Length == 0)
            {
                mostrarMensaje("Escriba una clave nueva para guardar", true);
                return;
            }
            if (txtclave1.Text != txtconfirmar1.Text)
            {
                mostrarMensaje("La confirmación de la Clave 1 no coincide", true);
                txtconfirmar1.Focus();
                return;
            }
            if (txtclave2.Text != txtconfirmar2.Text)
            {
                mostrarMensaje("La confirmación de la Clave 2 no coincide", true);
                txtconfirmar2.Focus();
                return;
            }

            try
            {
                string error = Bs_ClaveAcceso.guardarClavesAdmin(admin.Id, txtclave1.Text, txtclave2.Text);
                if (error != null)
                {
                    mostrarMensaje(error, true);
                    return;
                }

                cargarAdmins(admin.Id);
                mostrarMensaje("✔ Claves de " + admin.Nombre + " actualizadas", false);
            }
            catch (Exception)
            {
                mostrarMensaje("Hubo un error al guardar las claves", true);
            }
        }

        private void dgvPantallas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPantallas.IsCurrentCellDirty)
            {
                dgvPantallas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvPantallas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!cargando)
            {
                actualizarAviso();
            }
        }

        /// <summary>
        /// Avisa cuando una pantalla usa la Clave 2 y hay administradores que no la tienen.
        /// </summary>
        private string calcularAviso()
        {
            var sinClave2 = admins.Where(a => !a.TieneClave2).Select(a => a.Nombre).ToList();
            var pantallas = dgvPantallas.Rows.Cast<DataGridViewRow>()
                .Where(r => Convert.ToInt16(r.Cells[colTipoClave.Index].Value) == 2)
                .Select(r => Convert.ToString(r.Cells[colDescripcion.Index].Value))
                .ToList();

            if (sinClave2.Count == 0 || pantallas.Count == 0)
            {
                return null;
            }
            return "Sin Clave 2: " + string.Join(", ", sinClave2) + ". No podrán abrir: " + string.Join(", ", pantallas) + ".";
        }

        private void actualizarAviso()
        {
            string aviso = calcularAviso();
            lblaviso.Visible = aviso != null;
            lblaviso.Text = aviso ?? string.Empty;
        }

        private void btnGuardarAsignacion_Click(object sender, EventArgs e)
        {
            dgvPantallas.EndEdit();

            string aviso = calcularAviso();
            if (aviso != null)
            {
                if (MessageBox.Show(this, aviso + "\n\n¿Desea guardar de todas formas?", "Claves incompletas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    return;
                }
            }
            else if (MessageBox.Show(this, "¿Desea realizar este cambio?", "Cambiando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            var asignaciones = new Dictionary<string, short>();
            foreach (DataGridViewRow row in dgvPantallas.Rows)
            {
                asignaciones[Convert.ToString(row.Cells[colPantalla.Index].Value)] = Convert.ToInt16(row.Cells[colTipoClave.Index].Value);
            }

            try
            {
                Bs_ClaveAcceso.guardarAsignaciones(asignaciones);
                MessageBox.Show(this, "Se guardó correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Hubo un error al guardar la asignación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
