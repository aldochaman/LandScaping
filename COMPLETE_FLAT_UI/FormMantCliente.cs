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
     public partial class FormMantCliente : Form
     {
          public FormMantCliente()
          {
               InitializeComponent();
          }
          [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
          private extern static void ReleaseCapture();
          [DllImport("user32.DLL", EntryPoint = "SendMessage")]
          private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
          //public List<SqlCommand> comando;
          CONEXION con = new CONEXION();
          //  SqlConnection conexion = new SqlConnection("Server=ALDO\\SQL2019; Database=FVMLandScaping; User Id=sa; Password=chaman");

          private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
          {
               ReleaseCapture();
               SendMessage(this.Handle, 0x112, 0xf012, 0);
          }


          private void BtnCerrar_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void btnCancelar_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void FormMantCliente_Load(object sender, EventArgs e)
          {
               con.Conectar();
          }

          private void txtid_TextChanged(object sender, EventArgs e)
          {

          }

          private void txtdireccion_TextChanged(object sender, EventArgs e)
          {

          }

          private void BarraTitulo_Paint(object sender, PaintEventArgs e)
          {

          }
          
          private void btnguardar_Click(object sender, EventArgs e)
          {
               //-------Inserta a la Tabla Clientes--------------
               if (txtid.Text == string.Empty)
               {
                    string query = "insert into clientes (nombre,direccion,correo,dia) values(@nombre,@direccion,@correo,@dia)";
                    //-------Guarda Parametros en una Lista
                    List<SqlParameter> Parametros = new List<SqlParameter>();
                    Parametros.Add(new SqlParameter("@nombre", txtnombre.Text));
                    Parametros.Add(new SqlParameter("@direccion", txtdireccion.Text));
                    Parametros.Add(new SqlParameter("@correo", txtcorreo.Text));
                    Parametros.Add(new SqlParameter("@dia", txtdia.Text));

                    if (con.Insertar(query, Parametros))
                    {
                         MessageBox.Show("Cliente Agregado");
                         this.Close();
                         //FormListaClientes fm = new FormListaClientes();
                    }
                    else
                    {
                         MessageBox.Show("Error al agregar");
                    }
               }
               //------------Edita Registro tabla Clientes
               else
               {
                    string query = "update clientes set Nombre=@nombre, direccion=@direccion, correo=@correo , dia=@dia where id_Cliente=@id_Cliente ";
                    //-------Guarda Parametros en una Lista
                    List<SqlParameter> Parametros = new List<SqlParameter>();
                    Parametros.Add(new SqlParameter("@nombre", txtnombre.Text));
                    Parametros.Add(new SqlParameter("@direccion", txtdireccion.Text));
                    Parametros.Add(new SqlParameter("@correo", txtcorreo.Text));
                    Parametros.Add(new SqlParameter("@dia", txtdia.Text));
                    Parametros.Add(new SqlParameter("@id_Cliente", txtid.Text));

                    if (con.Actualizar(query, Parametros))
                    {
                         MessageBox.Show("Cliente Modificado");
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
