using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMPLETE_FLAT_UI.Reportes;
using Framework.CrystalReports;
using System.IO;

namespace COMPLETE_FLAT_UI
{
     public partial class FormFactura : Form
     {
          public FormFactura()
          {
               InitializeComponent();
          }
          private DataTable dtServicios;
          CONEXION con = new CONEXION();
          rptFactura rep = new rptFactura();
          Utilerias uti = new Utilerias();
          public SqlCommand comando;
          private byte[] buffer;

          private void FormFactura_Load(object sender, EventArgs e)
          {
               dtpFechadePago.Visible = true;
               //con.LlenarComboGrid(dgvServicios, "Servicios");
               con.Seleccionar(cmbCliente, "clientes");
               // Cargo los datos que tendra el combobox

               //cmbCliente.DataSource = con.Datos("clientes","id,nombre");
               //cmbCliente.DisplayMember = "nombre";
               //cmbCliente.ValueMember = "id";

               // cargo la lista de items para el autocomplete dle combobox
               cmbCliente.AutoCompleteCustomSource = con.Autocomplete("clientes", "id_Cliente,nombre", true);
               cmbCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
               cmbCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;


               con.Seleccionar(cmbServicios, "servicios");
               //Cargo los datos que tendra el combobox

               //cmbServicios.DataSource = con.Datos("Servicios","id,servicio");
               //cmbServicios.DisplayMember = "servicio";
               //cmbServicios.ValueMember = "id";

               // cargo la lista de items para el autocomplete del combobox
               cmbServicios.AutoCompleteCustomSource = con.Autocomplete("Servicios", "id_Servicio,servicio", false);
               cmbServicios.AutoCompleteMode = AutoCompleteMode.Suggest;
               cmbServicios.AutoCompleteSource = AutoCompleteSource.CustomSource;
               //Crea los Encabezado del grid 
               CrearTablaServicio();
               BuscaUltimoFactura();

          }
          private void CalculoTotal()
          {
               if (txtPrecio.Text != string.Empty)
               {
                    double total = 0;
                    foreach (DataGridViewRow row in dgvServicios.Rows)
                    {
                         total += Convert.ToDouble(row.Cells["Precio"].Value);
                    }
                    total = total + (total * 6.625 / 100);

                    txtTotal.Text = Convert.ToString(total);
               }

          }
          private void CalculoSubTotal()
          {
               if (txtPrecio.Text != string.Empty)
               {
                    double subtotal = 0;
                    foreach (DataGridViewRow row in dgvServicios.Rows)
                    {
                         subtotal += Convert.ToDouble(row.Cells["Precio"].Value);
                    }
                    txtSubtotal.Text = Convert.ToString(subtotal);
               }
          }
          //Muestra los campos en el  grid antes de insertarlos.
          private void CrearTablaServicio()
          {
               dtServicios = new DataTable("Detalle_Factura");
               dtServicios.Columns.Add("id_Servicio");
               dtServicios.Columns.Add("Descripcion");
               dtServicios.Columns.Add("Fecha_servicio");
               dtServicios.Columns.Add("Precio");
               dgvServicios.DataSource = dtServicios;
          }
          private void BuscaUltimoFactura()
          {
               txtFactura.Text = con.consultabd("SELECT TOP 1 * FROM Facturas ORDER BY id_Factura DESC");
          }

          private void ProponeFactura()
          {
                txtFactura.Text = (Convert.ToInt32(txtFactura.Text) + 1).ToString();
          }




          private void btnguardar_Click(object sender, EventArgs e)
          {
               // Si el check no es seleccionado inserta a la tabla Facturas
               if (cboxEditarFactura.Checked == false)
               {
                    if (string.IsNullOrWhiteSpace(txtFactura.Text))
                    {
                         MessageBox.Show("El numero de Factura no puede ir vacio");
                    }
                    else
                    {
                         string consultar = con.consultabd("select * from Facturas where id_Factura=" + txtFactura.Text + "");
                         if (consultar == txtFactura.Text)
                         {
                              MessageBox.Show("El numero de Factura ya existe");
                         }
                         else
                         {
                              string query = "insert into facturas (id_Factura,id_Cliente,Nombre,Fecha,Subtotal,Total,Cheque,Pago,FechadePago,Mensaje) values(@id_Factura,@idCliente,@Nombre,@Fecha,@Subtotal,@Total,@Cheque,@FacturaPagada,@Fechadepago ,@Mensajes)";

                              List<SqlParameter> Parametros = new List<SqlParameter>();
                              Parametros.Add(new SqlParameter("@id_Factura", txtFactura.Text));
                              Parametros.Add(new SqlParameter("@idCliente", txt_idcliente.Text));
                              Parametros.Add(new SqlParameter("@Nombre", cmbCliente.Text));
                              Parametros.Add(new SqlParameter("@Fecha", Convert.ToDateTime(dtpFechadePago.Text)));
                              Parametros.Add(new SqlParameter("@Subtotal", txtSubtotal.Text));
                              Parametros.Add(new SqlParameter("@Total", txtTotal.Text));
                              Parametros.Add(new SqlParameter("@Cheque", ""));
                              Parametros.Add(new SqlParameter("@FacturaPagada", Convert.ToInt32(bool.Parse(cboxFacturaPagada.Checked.ToString()))));
                              Parametros.Add(new SqlParameter("@Fechadepago", Convert.ToDateTime(dtpFechadePago.Text)));
                              Parametros.Add(new SqlParameter("@Mensajes", txtMensajes.Text));


                              if (con.Insertar(query, Parametros))
                              {
                                   //MessageBox.Show("Factura Guardada");

                                   //Inserta a la tabla DetallesFactura

                                   string querydetalle = "INSERT INTO Detalle_Factura(id_Factura, id_Servicio, Descripcion, Fecha_servicio, Precio)VALUES(@id_Factura, @id_Servicio,@Descripcion, @Fecha_servicio, @Precio)";

                                   if (dgvServicios.Rows.Count > 0)
                                   {
                                        foreach (DataGridViewRow row in dgvServicios.Rows)
                                        {
                                             List<SqlParameter> ParametrosDetalle = new List<SqlParameter>();
                                             ParametrosDetalle.Add(new SqlParameter("@id_Factura", txtFactura.Text));
                                             ParametrosDetalle.Add(new SqlParameter("@id_Servicio", (row.Cells["id"].Value.ToString())));
                                             ParametrosDetalle.Add(new SqlParameter("@Descripcion", (row.Cells["Servicio"].Value.ToString())));
                                             ParametrosDetalle.Add(new SqlParameter("@Fecha_servicio", Convert.ToDateTime((row.Cells["Fecha"].Value.ToString()))));
                                             ParametrosDetalle.Add(new SqlParameter("@Precio", (row.Cells["Precio"].Value.ToString())));
                                             if (con.Insertar(querydetalle, ParametrosDetalle))
                                             {
                                                  //MessageBox.Show("Detalle Guardado");
                                             }

                                        }
                                   }
                                   MessageBox.Show("Factura Guardada");
                                   
                              }
                              else
                              {
                                   MessageBox.Show("Error al agregar");
                              }
                              ProponeFactura();
                         }
                        
                    }
               }
               // Si el check esta seleccionado actualiza la tabla Facturas
               else
               {
                    string query = "update facturas set id_Factura = @Factura, id_Cliente=@idCliente, Nombre=@Nombre, Fecha=@Fecha, Subtotal=@Subtotal, Total=@Total, Cheque='', Pago=@Pago, FechadePago=@FechadePago , Mensaje= @Mensaje where id_Factura=@id_Factura";
                    List<SqlParameter> Parametros = new List<SqlParameter>();
                    Parametros.Add(new SqlParameter("@Factura", txtFactura.Text));
                    Parametros.Add(new SqlParameter("@idCliente", txt_idcliente.Text));
                    Parametros.Add(new SqlParameter("@Nombre", cmbCliente.Text));
                    Parametros.Add(new SqlParameter("@Fecha", Convert.ToDateTime(dtpFecha.Text)));
                    Parametros.Add(new SqlParameter("@Subtotal", txtSubtotal.Text));
                    Parametros.Add(new SqlParameter("@Total", txtTotal.Text));
                    Parametros.Add(new SqlParameter("@Pago", Convert.ToInt32(bool.Parse(cboxFacturaPagada.Checked.ToString()))));
                    Parametros.Add(new SqlParameter("@FechadePago", Convert.ToDateTime(dtpFechadePago.Text)));
                    Parametros.Add(new SqlParameter("@Mensaje", txtMensajes.Text));
                    Parametros.Add(new SqlParameter("@id_Factura", txtFactura.Text));
                    //si actualiza la facturas actualiza el detalle
                    if (con.Actualizar(query, Parametros))
                    {
                         //essageBox.Show("Factura Modificada");
                         //this.Close();
                         string querydetalle = "update Detalle_Factura set id_Servicio=@id_Servicio, Descripcion=@Descripcion, Fecha_servicio=@Fecha_servicio, Precio=@Precio where id_Factura=@id_Factura";

                         if (dgvServicios.Rows.Count > 0)
                         {
                              foreach (DataGridViewRow row in dgvServicios.Rows)
                              {
                                   List<SqlParameter> ParametrosDetalle = new List<SqlParameter>();
                                   ParametrosDetalle.Add(new SqlParameter("@id_Factura", txtFactura.Text));
                                   ParametrosDetalle.Add(new SqlParameter("@id_Servicio", (row.Cells["id"].Value.ToString())));
                                   ParametrosDetalle.Add(new SqlParameter("@Descripcion", (row.Cells["Servicio"].Value.ToString())));
                                   ParametrosDetalle.Add(new SqlParameter("@Fecha_servicio", Convert.ToDateTime((row.Cells["Fecha"].Value.ToString()))));
                                   ParametrosDetalle.Add(new SqlParameter("@Precio", (row.Cells["Precio"].Value.ToString())));
                                   if (con.Insertar(querydetalle, ParametrosDetalle))
                                   {
                                        //MessageBox.Show("Detalle Guardado");
                                   }

                              }
                         }
                         MessageBox.Show("Detalle Guardada");
                    }
                    else
                    {
                         MessageBox.Show("Error");
                    }
               }

          }

          private void btnEnviarCorreo_Click(object sender, EventArgs e)
          {

          }

          private void btnAgregar_Click(object sender, EventArgs e)
          {
               if (txtPrecio.Text != string.Empty)
               {
                    // Ingresa Fecha,Servicio y precio al grid
                    
                    var fila = dtServicios.NewRow();
                    fila["id_Servicio"] = txt_idservicio.Text;
                    fila["Descripcion"] = cmbServicios.Text;
                    fila["Fecha_servicio"] = dateTimePicker1.Text;
                    fila["Precio"] = txtPrecio.Text;
                    dtServicios.Rows.Add(fila);
                    CalculoSubTotal();
                    CalculoTotal();
               }
               else
               {
                    MessageBox.Show("Ingresa un Precio");
               }
          }


          private void cboxFacturaPagada_CheckedChanged(object sender, EventArgs e)
          {
               dtpFechadePago.Visible = true;
          }

          private void btnReporte_Click(object sender, EventArgs e)
          {

               string query = ("select f.id_Factura, f.Fecha,f.Subtotal,Total,c.Nombre,c.Direccion,s.Servicio,df.Descripcion,df.Fecha_servicio,df.Precio from facturas f inner join detalle_factura df on f.id_Factura = df.id_Factura inner join Clientes c on c.id_Cliente = f.id_Cliente inner join Servicios s on s.id_Servicio = df.id_Servicio where f.id_Factura = " + txtFactura.Text + "");

               DataTable dtFactura = con.SelectDataTable(query);
               Framework.CrystalReports.Report reportCR = new Framework.CrystalReports.Report("ALDO\\SQL2014", "FVMLandScaping", "sa", "chaman", "C:\\Users\\aldo0\\Desktop\\Proyecto\\COMPLETE_FLAT_UI\\Reportes\\", "rptFactura.rpt");
               reportCR.AddFormula("id_factura", txtFactura.Text);
               reportCR.AddTable("Temporal", dtFactura);
               reportCR.FormatType = FormatType.PDF;
               buffer = reportCR.Start();
               string Ruta = "C:\\Facturas\\";
               string ReporteNombreArchivoSalida = "Factura_" + txtFactura.Text + "_" + DateTime.Now.ToString("yyyyMMddmmss") + ".pdf";
               File.WriteAllBytes(Ruta + ReporteNombreArchivoSalida, buffer);
          }

          private void btnQuitar_Click(object sender, EventArgs e)
          {
               try
               {
                    //Selecciona el indice de la fila del grid servicios
                    int indiceFila = dgvServicios.CurrentCell.RowIndex;
                    DataRow fila = dtServicios.Rows[indiceFila];
                    //Remover fila
                    dtServicios.Rows.Remove(fila);
                    //Disminuir Total Pagado
                    CalculoSubTotal();
                    CalculoTotal();
               }
               catch (Exception)
               {
                    MessageBox.Show("No hay fila para remover");
               }
          }

          private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
          {
               //Ingresa la direccion del combo cliente al texbox
               if (cmbCliente.SelectedIndex > 0)
               {
                    string[] valores = con.Captar_info(cmbCliente.Text, "clientes", "nombre");
                    txtDireccion.Text = valores[2];
                    txt_idcliente.Text = valores[0];
               }
          }

          private void groupBox1_Enter(object sender, EventArgs e)
          {

          }

          private void cmbServicios_SelectedIndexChanged(object sender, EventArgs e)
          {
               if (cmbServicios.SelectedIndex > 0)
               {
                    string[] valores = con.Captar_info(cmbServicios.Text, "servicios", "servicio");
                    txt_idservicio.Text = valores[0];
               }
          }

          private void btnBuscar_Click(object sender, EventArgs e)
          {
               string[] valores = con.BuscarFactura(txtFactura.Text, "Facturas", "id_Factura");

               txt_idcliente.Text = valores[1];
               cmbCliente.Text = valores[2];
               dtpFecha.Text = valores[3];
               txtSubtotal.Text = valores[4];
               txtTotal.Text = valores[5];
               cboxFacturaPagada.Text = valores[7];
               dtpFechadePago.Text = valores[8];
               txtMensajes.Text = valores[9];

               string query = ("select * from detalle_Factura where id_factura=" + txtFactura.Text + "");

               DataTable dtFactura = con.SelectDataTable(query);
               dtFactura.Columns.Remove("id_Detalle_Factura");
               dtFactura.Columns.Remove("id_Factura");

               dgvServicios.DataSource = dtFactura;

          }

          private void btnEmilinar_Click(object sender, EventArgs e)
          {
               DialogResult opcion = MessageBox.Show("¿Realmente desea eliminar La Factura?", "Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (opcion == DialogResult.Yes)
               {

                    string querydetalle = "delete from Detalle_Factura where id_Factura=@id_Factura";
                    List<SqlParameter> ParametrosDetalle = new List<SqlParameter>();
                    ParametrosDetalle.Add(new SqlParameter("@id_Factura", txtFactura.Text));

                    if (con.Eliminar(querydetalle, ParametrosDetalle))
                    {
                         MessageBox.Show("Detalle eliminado");

                         string query = "delete from Facturas where id_Factura=@id_Factura";
                         List<SqlParameter> Parametros = new List<SqlParameter>();
                         Parametros.Add(new SqlParameter("@id_Factura", txtFactura.Text));
                         if (con.Eliminar(query, Parametros))
                         {
                              MessageBox.Show("Factura eliminado");
                         }
                         else
                         {
                              MessageBox.Show("Error al eliminar");
                         }

                    }
                    else
                    {
                         MessageBox.Show("Error al eliminar");
                    }
               }
          }
     }
}

