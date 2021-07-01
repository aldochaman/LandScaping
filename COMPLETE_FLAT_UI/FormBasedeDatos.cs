using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
     public partial class FormBasedeDatos : Form
     {
          public FormBasedeDatos()
          {
               InitializeComponent();
          }
          
          private void FormBasedeDatos_Load(object sender, EventArgs e)
          {
               
          }

          private void btnguardar_Click(object sender, EventArgs e)
          {
               if (txtDatabases.Text.Length == 0)
               {
                    MessageBox.Show("ERROR - A valid server is required");
                    return;
               }

               if (txtPassword.Text.Length == 0)
               {
                    MessageBox.Show("ERROR - A valid DB username is required");
                    return;
               }
               if (txtPassword.Text.Length == 0)
               {
                    MessageBox.Show("ERROR - A valid Password is required");
                    return;
               }
               SaveConection();
          }

          private void SaveConection()
          {
               if (txtServer.Text.Length == 0)
               {
                    MessageBox.Show("ERROR - A valid server is required");
                    return;
               }

               if (txtUserName.Text.Length == 0)
               {
                    MessageBox.Show("ERROR - A valid DB username is required");
                    return;
               }

               Cursor.Current = Cursors.WaitCursor;
               string connectionString = string.Format("Server={0}; Database={1}; User Id={2}; Password={3};", txtServer.Text, txtDatabases.Text, txtUserName.Text, txtPassword.Text);
               try

               {
                    ValidarConexion helper = new ValidarConexion(connectionString);
                    if (helper.Isconnection)
                    {
                         AppSetting setting = new AppSetting();
                         setting.SaveConnectionString("connection", connectionString);
                         MessageBox.Show("Your connection string has been succesfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
               }
          }

          private void btnConexion_Click(object sender, EventArgs e)
          {
               Cursor.Current = Cursors.WaitCursor;
               ValidarConexion();
          }

          private void ValidarConexion()
          {
               string connectionString = string.Format("Server={0}; Database={1}; User Id={2}; Password={3};", txtServer.Text, txtDatabases.Text, txtUserName.Text, txtPassword.Text);
               ValidarConexion connection = new ValidarConexion(connectionString);
               try
               {
                    if (connection.Isconnection == true)
                    {
                         MessageBox.Show("Connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                          MessageBox.Show("ERROR - failed connection, valid credentials are required");
                          return;
                    }

               }
               catch (Exception ex)
               {
                    MessageBox.Show("ERROR - failed connection, valid credentials are required", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }


          }
     }
}
