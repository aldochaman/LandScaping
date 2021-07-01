using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace COMPLETE_FLAT_UI
{
     public partial class FormMantServicios : Form
     {
          public FormMantServicios()
          {
               InitializeComponent();
          }
          [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
          private extern static void ReleaseCapture();
          [DllImport("user32.DLL", EntryPoint = "SendMessage")]
          private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

          CONEXION con = new CONEXION();
          public SqlCommand comando;
          private void BtnCerrar_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void btnCancelar_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void btnguardar_Click(object sender, EventArgs e)
          {
               if (txtid.Text == string.Empty)
               {
                    string query = "insert into servicios (servicio) values(@Servicio)";

                    List<SqlParameter> Parametros = new List<SqlParameter>();
                    Parametros.Add(new SqlParameter("@Servicio", txtservicio.Text));

                    if (con.Insertar(query,Parametros))
                    {
                         MessageBox.Show("Servicio Agregado");
                         this.Close();
                    }
                    else
                    {
                         MessageBox.Show("Error al agregar");
                    }
               }
               else
               {
                    string query = "update servicios set Servicio=@Servicio where id_Servicio=@id";

                    List<SqlParameter> Parametros = new List<SqlParameter>();
                    Parametros.Add(new SqlParameter("@Servicio", txtservicio.Text));
                    Parametros.Add(new SqlParameter("@id", txtid.Text));

                    if (con.Actualizar(query,Parametros))
                    {
                         MessageBox.Show("Servicio Modificado");
                         this.Close();
                    }
                    else
                    {
                         MessageBox.Show("Error");
                    }
               }
          }
     }
}
