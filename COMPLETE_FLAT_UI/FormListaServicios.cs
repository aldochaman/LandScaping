using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
     public partial class FormListaServicios : Form
     {
          public FormListaServicios()
          {
               InitializeComponent();
          }
          [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
          private extern static void ReleaseCapture();
          [DllImport("user32.DLL", EntryPoint = "SendMessage")]
          private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
          CONEXION con = new CONEXION();
          private void FormListaServicios_Load(object sender, EventArgs e)
          {
               //Agrega encabezados al grid servicios
               mostrarservicios();
          }           
          private void btnNuevo_Click(object sender, EventArgs e)
          {
               //Abre el form Mantenimiento Servicios y actualiza el grid
               FormMantServicios frm = new FormMantServicios();
               frm.ShowDialog();
               mostrarservicios();
          }
          
          private void BtnCerrar_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void btnEditar_Click_1(object sender, EventArgs e)
          {
               // Abre el form mantenimiento Servicios e inserta el servicio de la fila seleccionada del grid
               FormMantServicios frm = new FormMantServicios();
               if (dgvServicios.SelectedRows.Count > 0)
               {
                    frm.txtid.Text = dgvServicios.CurrentRow.Cells[0].Value.ToString();
                    frm.txtservicio.Text = dgvServicios.CurrentRow.Cells[1].Value.ToString();
                    frm.ShowDialog();
                    mostrarservicios();
               }
               else
               {
                    MessageBox.Show("seleccione un cliente por favor");
               }
          }

          private void btneliminar_Click(object sender, EventArgs e)
          {
               DialogResult opcion = MessageBox.Show("¿Realmente desea eliminar el servicio seleccionado?", "Servicios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               // Elimina el servicio de la fila seleccionada del grid 
               if (opcion == DialogResult.Yes)
               {

                    string query = "delete from Servicios where id_Servicio=@id_Servicio";
                    List<SqlParameter> Parametros = new List<SqlParameter>();
                    Parametros.Add(new SqlParameter("@id_Servicio", Convert.ToInt32(dgvServicios.CurrentRow.Cells["id_Servicio"].Value)));

                    if (con.Eliminar(query, Parametros))
                    {
                         MessageBox.Show("Cliente eliminado");
                         mostrarservicios();
                    }
                    else
                    {

                         MessageBox.Show("Error al eliminar");
                    }
               }
          }
          //Llena dataset para el grid
          private void mostrarservicios()
          {
               con.Consulta("select * from Servicios", "Servicios");
               dgvServicios.DataSource = con.ds.Tables["Servicios"];
          }
     }
}
