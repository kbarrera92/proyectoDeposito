using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Deposito
{
    public partial class FormDetallePedido : Form
    {
        private readonly long idPedido;
        public FormDetallePedido(long idPedido)
        {
            InitializeComponent();
            this.idPedido = idPedido;
            this.dgvDetalle.CellFormatting += dgvDetalle_CellFormatting;
        }

        

        private void CargarCabecera()
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var cabecera = (from p in db.PEDIDO
                                join c in db.CLIENTE on p.CLIENTE equals c.ID into cli
                                from cliente in cli.DefaultIfEmpty()
                                join rep in db.REPARTIDOR on p.REPCOBRO equals rep.ID into repc
                                from repartidor in repc.DefaultIfEmpty()
                                where p.ID == idPedido
                                select new
                                {
                                    p.ID,
                                    p.FECHA,
                                    CLIENTE = cliente.NOMBRE,
                                    p.TOTAL,
                                    REPARTIDOR = repartidor.NOMBRE
                                }).FirstOrDefault();

                if (cabecera == null) return;

                lblValId.Text = cabecera.ID.ToString();
                lblValFecha.Text = cabecera.FECHA.HasValue ? cabecera.FECHA.Value.ToString("dd/MM/yyyy") : "-";
                lblValCliente.Text = cabecera.CLIENTE ?? "-";
                lblValRepartidor.Text = cabecera.REPARTIDOR ?? "-";

                string totalFormateado = string.Format("Q {0:N2}", cabecera.TOTAL ?? 0);
                lblValTotal.Text = totalFormateado;
                lblValTotalGeneral.Text = totalFormateado;
            }
        }

        private void CargarDetalle()
        {
            using (Entidad.DEPOSITOEntities1 db = new Entidad.DEPOSITOEntities1())
            {
                var detalle = from d in db.PEDIDODETA
                              join prod in db.PRODUCTO on d.IDPRODUCTO equals prod.ID into pr
                              from producto in pr.DefaultIfEmpty()
                              where d.IDPEDIDO == idPedido
                              select new
                              {
                                  PRODUCTO = producto.DESCRIPCION,
                                  d.CANTIDAD,
                                  d.PRECIO,
                                  d.SUBTOTAL,
                                  OBSERVACIONES = d.DETALLESAB
                              };

                dgvDetalle.DataSource = detalle.ToList();
            }
        }

        private void dgvDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDetalle.Columns[e.ColumnIndex].Name != "colObservaciones") return;
            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                e.Value = "—";
                e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
                e.FormattingApplied = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetallePedido_Load(object sender, EventArgs e)
        {
            CargarCabecera();
            CargarDetalle();
        }
    }
}
