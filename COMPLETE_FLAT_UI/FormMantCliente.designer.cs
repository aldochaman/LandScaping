namespace COMPLETE_FLAT_UI
{
    partial class FormMantCliente
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
               this.txtnombre = new System.Windows.Forms.TextBox();
               this.txtdireccion = new System.Windows.Forms.TextBox();
               this.txtcorreo = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.btnguardar = new System.Windows.Forms.Button();
               this.btnCancelar = new System.Windows.Forms.Button();
               this.label5 = new System.Windows.Forms.Label();
               this.txtid = new System.Windows.Forms.TextBox();
               this.lbldia = new System.Windows.Forms.Label();
               this.txtdia = new System.Windows.Forms.TextBox();
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
               this.BarraTitulo.TabIndex = 2;
               this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
               this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.ForeColor = System.Drawing.Color.White;
               this.label6.Location = new System.Drawing.Point(236, 13);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(96, 17);
               this.label6.TabIndex = 15;
               this.label6.Text = "Nuevo Cliente";
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
               // txtnombre
               // 
               this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtnombre.Location = new System.Drawing.Point(117, 98);
               this.txtnombre.Name = "txtnombre";
               this.txtnombre.Size = new System.Drawing.Size(409, 23);
               this.txtnombre.TabIndex = 3;
               // 
               // txtdireccion
               // 
               this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtdireccion.Location = new System.Drawing.Point(117, 127);
               this.txtdireccion.Name = "txtdireccion";
               this.txtdireccion.Size = new System.Drawing.Size(409, 23);
               this.txtdireccion.TabIndex = 5;
               this.txtdireccion.TextChanged += new System.EventHandler(this.txtdireccion_TextChanged);
               // 
               // txtcorreo
               // 
               this.txtcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtcorreo.Location = new System.Drawing.Point(117, 156);
               this.txtcorreo.Name = "txtcorreo";
               this.txtcorreo.Size = new System.Drawing.Size(409, 23);
               this.txtcorreo.TabIndex = 6;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label2.Location = new System.Drawing.Point(25, 101);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(62, 17);
               this.label2.TabIndex = 7;
               this.label2.Text = "Nombre:";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label3.Location = new System.Drawing.Point(24, 131);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(71, 17);
               this.label3.TabIndex = 9;
               this.label3.Text = "Direccion:";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label4.Location = new System.Drawing.Point(25, 156);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(55, 17);
               this.label4.TabIndex = 10;
               this.label4.Text = "Correo:";
               // 
               // btnguardar
               // 
               this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.btnguardar.FlatAppearance.BorderSize = 0;
               this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnguardar.ForeColor = System.Drawing.Color.White;
               this.btnguardar.Location = new System.Drawing.Point(185, 234);
               this.btnguardar.Name = "btnguardar";
               this.btnguardar.Size = new System.Drawing.Size(100, 35);
               this.btnguardar.TabIndex = 11;
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
               this.btnCancelar.Location = new System.Drawing.Point(313, 234);
               this.btnCancelar.Name = "btnCancelar";
               this.btnCancelar.Size = new System.Drawing.Size(100, 35);
               this.btnCancelar.TabIndex = 12;
               this.btnCancelar.Text = "Cancelar";
               this.btnCancelar.UseVisualStyleBackColor = false;
               this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.label5.Location = new System.Drawing.Point(25, 74);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(21, 17);
               this.label5.TabIndex = 14;
               this.label5.Text = "ID";
               // 
               // txtid
               // 
               this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtid.Location = new System.Drawing.Point(117, 71);
               this.txtid.Name = "txtid";
               this.txtid.ReadOnly = true;
               this.txtid.Size = new System.Drawing.Size(259, 23);
               this.txtid.TabIndex = 13;
               this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
               // 
               // lbldia
               // 
               this.lbldia.AutoSize = true;
               this.lbldia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lbldia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               this.lbldia.Location = new System.Drawing.Point(25, 184);
               this.lbldia.Name = "lbldia";
               this.lbldia.Size = new System.Drawing.Size(33, 17);
               this.lbldia.TabIndex = 15;
               this.lbldia.Text = "Dia:";
               // 
               // txtdia
               // 
               this.txtdia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtdia.Location = new System.Drawing.Point(117, 185);
               this.txtdia.Name = "txtdia";
               this.txtdia.Size = new System.Drawing.Size(409, 23);
               this.txtdia.TabIndex = 16;
               // 
               // FormMantCliente
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(577, 294);
               this.Controls.Add(this.txtdia);
               this.Controls.Add(this.lbldia);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.txtid);
               this.Controls.Add(this.btnCancelar);
               this.Controls.Add(this.btnguardar);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.txtcorreo);
               this.Controls.Add(this.txtdireccion);
               this.Controls.Add(this.txtnombre);
               this.Controls.Add(this.BarraTitulo);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "FormMantCliente";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
               this.Text = "FormMantCliente";
               this.Load += new System.EventHandler(this.FormMantCliente_Load);
               this.BarraTitulo.ResumeLayout(false);
               this.BarraTitulo.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txtdireccion;
        public System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label lbldia;
          public System.Windows.Forms.TextBox txtdia;
     }
}