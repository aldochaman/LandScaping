
namespace COMPLETE_FLAT_UI
{
     partial class FormMantServicios
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
               this.BarraTitulo = new System.Windows.Forms.Panel();
               this.label6 = new System.Windows.Forms.Label();
               this.BtnCerrar = new System.Windows.Forms.Button();
               this.btnguardar = new System.Windows.Forms.Button();
               this.btnCancelar = new System.Windows.Forms.Button();
               this.label5 = new System.Windows.Forms.Label();
               this.txtid = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.txtservicio = new System.Windows.Forms.TextBox();
               this.BarraTitulo.SuspendLayout();
               this.SuspendLayout();
               // 
               // BarraTitulo
               // 
               this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.BarraTitulo.Controls.Add(this.label6);
               this.BarraTitulo.Controls.Add(this.BtnCerrar);
               this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
               this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
               this.BarraTitulo.Name = "BarraTitulo";
               this.BarraTitulo.Size = new System.Drawing.Size(577, 38);
               this.BarraTitulo.TabIndex = 3;
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.ForeColor = System.Drawing.Color.White;
               this.label6.Location = new System.Drawing.Point(236, 13);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(103, 17);
               this.label6.TabIndex = 15;
               this.label6.Text = "Nuevo Servicio";
               // 
               // BtnCerrar
               // 
               this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
               this.BtnCerrar.FlatAppearance.BorderSize = 0;
               this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.BtnCerrar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
               this.BtnCerrar.Location = new System.Drawing.Point(539, 0);
               this.BtnCerrar.Name = "BtnCerrar";
               this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
               this.BtnCerrar.TabIndex = 4;
               this.BtnCerrar.UseVisualStyleBackColor = true;
               this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
               // 
               // btnguardar
               // 
               this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.btnguardar.FlatAppearance.BorderSize = 0;
               this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnguardar.ForeColor = System.Drawing.Color.White;
               this.btnguardar.Location = new System.Drawing.Point(181, 210);
               this.btnguardar.Name = "btnguardar";
               this.btnguardar.Size = new System.Drawing.Size(100, 35);
               this.btnguardar.TabIndex = 16;
               this.btnguardar.Text = "Guardar";
               this.btnguardar.UseVisualStyleBackColor = false;
               this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
               // 
               // btnCancelar
               // 
               this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.btnCancelar.FlatAppearance.BorderSize = 0;
               this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnCancelar.ForeColor = System.Drawing.Color.White;
               this.btnCancelar.Location = new System.Drawing.Point(301, 210);
               this.btnCancelar.Name = "btnCancelar";
               this.btnCancelar.Size = new System.Drawing.Size(100, 35);
               this.btnCancelar.TabIndex = 17;
               this.btnCancelar.Text = "Cancelar";
               this.btnCancelar.UseVisualStyleBackColor = false;
               this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label5.Location = new System.Drawing.Point(18, 97);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(21, 17);
               this.label5.TabIndex = 18;
               this.label5.Text = "ID";
               // 
               // txtid
               // 
               this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtid.Location = new System.Drawing.Point(91, 95);
               this.txtid.Name = "txtid";
               this.txtid.ReadOnly = true;
               this.txtid.Size = new System.Drawing.Size(259, 23);
               this.txtid.TabIndex = 19;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label2.Location = new System.Drawing.Point(12, 153);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(62, 17);
               this.label2.TabIndex = 20;
               this.label2.Text = "Servicio:";
               // 
               // txtservicio
               // 
               this.txtservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtservicio.Location = new System.Drawing.Point(91, 149);
               this.txtservicio.Name = "txtservicio";
               this.txtservicio.Size = new System.Drawing.Size(409, 23);
               this.txtservicio.TabIndex = 21;
               // 
               // FormMantServicios
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(577, 294);
               this.Controls.Add(this.txtservicio);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.txtid);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.btnCancelar);
               this.Controls.Add(this.btnguardar);
               this.Controls.Add(this.BarraTitulo);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "FormMantServicios";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
               this.Text = "FormMantServicios";
               this.BarraTitulo.ResumeLayout(false);
               this.BarraTitulo.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Panel BarraTitulo;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Button BtnCerrar;
          private System.Windows.Forms.Button btnguardar;
          private System.Windows.Forms.Button btnCancelar;
          private System.Windows.Forms.Label label5;
          public System.Windows.Forms.TextBox txtid;
          private System.Windows.Forms.Label label2;
          public System.Windows.Forms.TextBox txtservicio;
     }
}