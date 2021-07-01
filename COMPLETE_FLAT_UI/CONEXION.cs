using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Configuration;

namespace COMPLETE_FLAT_UI
{
     class CONEXION
     {
          
          SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());        
          private SqlCommandBuilder cmb;
          public DataSet ds = new DataSet();
          public DataTable dt = new DataTable();
          public SqlDataAdapter da;
          public SqlCommand comando;

          public DataTable SelectDataTable(string query)
          {
               dt = new DataTable();
               try
               {
                    con.Open();
                    da = new SqlDataAdapter(query, con);
                    da.Fill(dt);
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               finally
               {
                    con.Close();
               }
               return dt;
          }

          public DataSet SelectDataSet(string query, string table)
          {
               ds = new DataSet();
               try
               {
                    con.Open();
                    da = new SqlDataAdapter(query, con);
                    da.Fill(ds, table);
               }
               catch
               {
               }
               finally
               {
                    con.Close();
               }
               return ds;
          }
          public string consultabd(string query)
          {
               try
               {
                    con.Open();
                    comando = new SqlCommand(query, con);
                    string valor = Convert.ToString(comando.ExecuteScalar());
                    return valor;

               }
               catch 
               {
                    return "";
               }
               finally 
               {
                    con.Close();
               }

               
              
          }
          public void Conectar()
          {
               try
               {
                    con.Open();
                   // MessageBox.Show("conectado");

               }
               catch
               {
                    MessageBox.Show("Error al conectar");
               }
               finally
               {
                    con.Close();
               }
          }

          public void Consulta (string sql,string tabla)
               {
               ds.Tables.Clear();
               da = new SqlDataAdapter(sql, con);
               cmb = new SqlCommandBuilder(da);
               da.Fill(ds, tabla);
               }
          public bool Insertar(string query, List<SqlParameter> Parametros)
          {
               con.Open();
               comando = new SqlCommand(query, con);
               foreach (SqlParameter parametro in Parametros)
               {
                    comando.Parameters.Add(parametro);
               }
               int i = comando.ExecuteNonQuery();
               con.Close();
               if (i > 0)
               {
                    return true;
               }
               else
               {
                    return false;
               }
          }
          public bool Eliminar(string query, List<SqlParameter> Parametros)
          {
               con.Open();
               comando = new SqlCommand(query, con);
               foreach (SqlParameter parametro in Parametros)
               {
                    comando.Parameters.Add(parametro);
               }
               int ejecutaquery = comando.ExecuteNonQuery();
               con.Close();
               if (ejecutaquery > 0)
               {
                    return true;
               }
               else
               {
                    return false;
               }
          }
          public bool Actualizar (string query, List<SqlParameter> Parametros)
          {
               con.Open();
               comando = new SqlCommand(query, con);
               foreach (SqlParameter parametro in Parametros)
               {
                    comando.Parameters.Add(parametro);
               }
               int ejecutaquery = comando.ExecuteNonQuery();
               con.Close();
               if (ejecutaquery > 0)
               {
                    return true;
               }
               else
               {
                    return false;
               }
          }
          public void Seleccionar(ComboBox cb, string tabla)
          {
               cb.Items.Clear();
               con.Open();
               string query = "select * from " + tabla ;
               SqlCommand cmd = new SqlCommand(query, con);
               SqlDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
               {
                    cb.Items.Add(dr[1].ToString());
               }
               con.Close();
               cb.Items.Insert(0, "--- Seleccione ---");
               cb.SelectedIndex = 0;
          }
          public void LlenarComboGrid( DataGridView dtvServicios, string tabla)
          {
               
               //DataTable dt = new DataTable();
               //Añadir combobox column
               DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
               //combo.HeaderText = "Servicio";
               combo.DataPropertyName = "Servicio";
               combo.Name = "Servicio";
               ArrayList row = new ArrayList();

               //Añadir items al Arraylist de una datable
               con.Open();
               string query = "select * from " + tabla;
               SqlCommand cmd = new SqlCommand(query, con);
               SqlDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
               {
                    combo.Items.Add(dr[1].ToString());
               }
               con.Close();
               //combo.Items.Insert(0, "--- Seleccione ---");
               //combo.SelectedIndex = 0;

               //Añadir al combo

               combo.Items.AddRange(row.ToArray());

               //Añadir el combo column

               dtvServicios.Columns.Add(combo);
               

          }
          //Extrae informacion de la base de datos ingresando la tabla y el campo a filtrar 
          // y retorna un string[] 
          public string[] Captar_info(string condicion,string tabla,string campo)
          {
               con.Open();
               string query = "select * from " + tabla + " where "+ campo + " = '" + condicion + "'";
               SqlCommand cmd = new SqlCommand(query, con);
               SqlDataReader dr = cmd.ExecuteReader();
               string[] resultado = null;
               while (dr.Read())
               {
                    string[] valores =
                    {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString()
                    };
                    resultado = valores;
               }
               con.Close();
               return resultado;
          }
          public string[] BuscarFactura(string condicion, string tabla, string campo)
          {
               con.Open();
               string query = "select * from " + tabla + " where " + campo + " = '" + condicion + "'";
               SqlCommand cmd = new SqlCommand(query, con);
               SqlDataReader dr = cmd.ExecuteReader();
               string[] resultado = null;
               while (dr.Read())
               {
                    string[] valores =
                    {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    dr[6].ToString(),
                    dr[7].ToString(),
                    dr[8].ToString(),
                    dr[9].ToString()
                    };
                    resultado = valores;
               }
               con.Close();
               return resultado;
          }
          public  DataTable Datos(string tabla,string campos)
          {
               string query = "select " + campos + " from " + tabla;
               SqlCommand cmd = new SqlCommand(query, con);
               SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
               DataTable dt = new DataTable();
               adaptador.Fill(dt);
              
               return dt;

          }

          public  AutoCompleteStringCollection Autocomplete(string tabla, string campos, bool condicion)
          {
               DataTable dt = Datos(tabla, campos);

               AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
               //recorrer y cargar los items para el autocompletado

               if  (condicion)
               {
                    foreach (DataRow row in dt.Rows)
                    {
                    coleccion.Add(Convert.ToString(row["nombre"]));
                    }
                     return coleccion;
               }
               else
               {
                    foreach (DataRow row in dt.Rows)
                    {
                         coleccion.Add(Convert.ToString(row["servicio"]));
                    }
                    return coleccion;
               }
          }
     }
     }




