using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;


namespace COMPLETE_FLAT_UI
{
     public partial class FormListaClientes : Form

     {
          public FormListaClientes()
          {
               InitializeComponent();
          }
          CONEXION con = new CONEXION();

          private void btnCerrar_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void FormListaClientes_Load(object sender, EventArgs e)
          {
               con.Conectar();
               mostrarclientes();
          }


          private void BtnCerrar_Click_1(object sender, EventArgs e)
          {
               this.Close();
          }

          private void btnEditar_Click(object sender, EventArgs e)
          {
               FormMantCliente frm = new FormMantCliente();
               if (dgvClientes.SelectedRows.Count > 0)
               {
                    frm.txtid.Text= dgvClientes.CurrentRow.Cells[0].Value.ToString();
                    frm.txtnombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                    frm.txtdireccion.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                    frm.txtcorreo.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                    frm.txtdia.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                    frm.ShowDialog();
                    mostrarclientes();
               }
               else
               {
                    MessageBox.Show("seleccione un cliente por favor");
               }
          }

          private void btnNuevo_Click(object sender, EventArgs e)
          {
               FormMantCliente frm = new FormMantCliente();
               frm.ShowDialog();
               mostrarclientes();
          }         
          private void btneliminar_Click(object sender, EventArgs e)
          {
               DialogResult opcion = MessageBox.Show("¿Realmente desea eliminar el cliente seleccionado?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (opcion == DialogResult.Yes)
               {

                    string query = "delete from clientes where id_Cliente=@id_Cliente";
                    List<SqlParameter> Parametros = new List<SqlParameter>();
                    Parametros.Add(new SqlParameter("@id_Cliente", Convert.ToInt32(dgvClientes.CurrentRow.Cells["id_Cliente"].Value)));

                    if (con.Eliminar(query, Parametros))
                    {
                         MessageBox.Show("Cliente eliminado");
                         mostrarclientes();
                    }
                    else
                    {

                         MessageBox.Show("Error al eliminar");
                    }
               }
          }
          //Llena dataset para el grid
          private void mostrarclientes()
          {
               string query = "select * from clientes";
               con.Consulta(query, "Clientes");
               dgvClientes.DataSource = con.ds.Tables["Clientes"];
          }
     }
}
