
namespace COMPLETE_FLAT_UI
{
     partial class FormBasedeDatos
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.btnguardar = new System.Windows.Forms.Button();
               this.txtDatabases = new System.Windows.Forms.TextBox();
               this.txtPassword = new System.Windows.Forms.TextBox();
               this.txtUserName = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.btnConexion = new System.Windows.Forms.Button();
               this.txtServer = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.groupBox1.SuspendLayout();
               this.SuspendLayout();
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.label4);
               this.groupBox1.Controls.Add(this.txtServer);
               this.groupBox1.Controls.Add(this.btnConexion);
               this.groupBox1.Controls.Add(this.btnguardar);
               this.groupBox1.Controls.Add(this.txtDatabases);
               this.groupBox1.Controls.Add(this.txtPassword);
               this.groupBox1.Controls.Add(this.txtUserName);
               this.groupBox1.Controls.Add(this.label3);
               this.groupBox1.Controls.Add(this.label1);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.ForeColor = System.Drawing.Color.White;
               this.groupBox1.Location = new System.Drawing.Point(12, 12);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(414, 138);
               this.groupBox1.TabIndex = 22;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "CONEXION";
               // 
               // btnguardar
               // 
               this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.btnguardar.FlatAppearance.BorderSize = 0;
               this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnguardar.ForeColor = System.Drawing.Color.White;
               this.btnguardar.Location = new System.Drawing.Point(296, 74);
               this.btnguardar.Name = "btnguardar";
               this.btnguardar.Size = new System.Drawing.Size(100, 35);
               this.btnguardar.TabIndex = 29;
               this.btnguardar.Text = "Guardar";
               this.btnguardar.UseVisualStyleBackColor = false;
               this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
               // 
               // txtDatabases
               // 
               this.txtDatabases.Location = new System.Drawing.Point(98, 49);
               this.txtDatabases.Name = "txtDatabases";
               this.txtDatabases.Size = new System.Drawing.Size(192, 20);
               this.txtDatabases.TabIndex = 28;
               // 
               // txtPassword
               // 
               this.txtPassword.Location = new System.Drawing.Point(98, 105);
               this.txtPassword.Name = "txtPassword";
               this.txtPassword.Size = new System.Drawing.Size(192, 20);
               this.txtPassword.TabIndex = 27;
               // 
               // txtUserName
               // 
               this.txtUserName.Location = new System.Drawing.Point(98, 77);
               this.txtUserName.Name = "txtUserName";
               this.txtUserName.Size = new System.Drawing.Size(192, 20);
               this.txtUserName.TabIndex = 26;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.ForeColor = System.Drawing.Color.LightGray;
               this.label3.Location = new System.Drawing.Point(22, 105);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(73, 17);
               this.label3.TabIndex = 23;
               this.label3.Text = "Password:";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.LightGray;
               this.label1.Location = new System.Drawing.Point(13, 76);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(83, 17);
               this.label1.TabIndex = 18;
               this.label1.Text = "User Name:";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.Color.LightGray;
               this.label2.Location = new System.Drawing.Point(22, 50);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(74, 17);
               this.label2.TabIndex = 17;
               this.label2.Text = "DataBase:";
               // 
               // btnConexion
               // 
               this.btnConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.btnConexion.FlatAppearance.BorderSize = 0;
               this.btnConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnConexion.ForeColor = System.Drawing.Color.White;
               this.btnConexion.Location = new System.Drawing.Point(296, 32);
               this.btnConexion.Name = "btnConexion";
               this.btnConexion.Size = new System.Drawing.Size(100, 35);
               this.btnConexion.TabIndex = 30;
               this.btnConexion.Text = "Conexión";
               this.btnConexion.UseVisualStyleBackColor = false;
               this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
               // 
               // txtServer
               // 
               this.txtServer.Location = new System.Drawing.Point(98, 21);
               this.txtServer.Name = "txtServer";
               this.txtServer.Size = new System.Drawing.Size(192, 20);
               this.txtServer.TabIndex = 31;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.Color.LightGray;
               this.label4.Location = new System.Drawing.Point(42, 22);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(54, 17);
               this.label4.TabIndex = 32;
               this.label4.Text = "Server:";
               // 
               // FormBasedeDatos
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.ClientSize = new System.Drawing.Size(438, 166);
               this.Controls.Add(this.groupBox1);
               this.Location = new System.Drawing.Point(100, 100);
               this.Name = "FormBasedeDatos";
               this.Text = "ConexionBasedeDatos";
               this.Load += new System.EventHandler(this.FormBasedeDatos_Load);
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.TextBox txtDatabases;
          private System.Windows.Forms.TextBox txtPassword;
          private System.Windows.Forms.TextBox txtUserName;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Button btnguardar;
          private System.Windows.Forms.Button btnConexion;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.TextBox txtServer;
     }
}