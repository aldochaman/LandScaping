
namespace COMPLETE_FLAT_UI
{
     partial class FormFactura
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.btnEmilinar = new System.Windows.Forms.Button();
               this.btnBuscar = new System.Windows.Forms.Button();
               this.txt_idservicio = new System.Windows.Forms.TextBox();
               this.txt_idcliente = new System.Windows.Forms.TextBox();
               this.txtMensajes = new System.Windows.Forms.TextBox();
               this.cboxFacturaPagada = new System.Windows.Forms.CheckBox();
               this.label11 = new System.Windows.Forms.Label();
               this.dtpFechadePago = new System.Windows.Forms.DateTimePicker();
               this.label7 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.txtSubtotal = new System.Windows.Forms.TextBox();
               this.txtTotal = new System.Windows.Forms.TextBox();
               this.cboxEditarFactura = new System.Windows.Forms.CheckBox();
               this.label10 = new System.Windows.Forms.Label();
               this.txtPrecio = new System.Windows.Forms.TextBox();
               this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
               this.dtpFecha = new System.Windows.Forms.DateTimePicker();
               this.btnQuitar = new System.Windows.Forms.Button();
               this.btnAgregar = new System.Windows.Forms.Button();
               this.btnReporte = new System.Windows.Forms.Button();
               this.btnEnviarCorreo = new System.Windows.Forms.Button();
               this.btnguardar = new System.Windows.Forms.Button();
               this.cmbServicios = new System.Windows.Forms.ComboBox();
               this.dgvServicios = new System.Windows.Forms.DataGridView();
               this.label9 = new System.Windows.Forms.Label();
               this.label8 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.txtDireccion = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.cmbCliente = new System.Windows.Forms.ComboBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.txtFactura = new System.Windows.Forms.TextBox();
               this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
               this.SuspendLayout();
               // 
               // groupBox1
               // 
               this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.groupBox1.Controls.Add(this.btnEmilinar);
               this.groupBox1.Controls.Add(this.btnBuscar);
               this.groupBox1.Controls.Add(this.txt_idservicio);
               this.groupBox1.Controls.Add(this.txt_idcliente);
               this.groupBox1.Controls.Add(this.txtMensajes);
               this.groupBox1.Controls.Add(this.cboxFacturaPagada);
               this.groupBox1.Controls.Add(this.label11);
               this.groupBox1.Controls.Add(this.dtpFechadePago);
               this.groupBox1.Controls.Add(this.label7);
               this.groupBox1.Controls.Add(this.label6);
               this.groupBox1.Controls.Add(this.txtSubtotal);
               this.groupBox1.Controls.Add(this.txtTotal);
               this.groupBox1.Controls.Add(this.cboxEditarFactura);
               this.groupBox1.Controls.Add(this.label10);
               this.groupBox1.Controls.Add(this.txtPrecio);
               this.groupBox1.Controls.Add(this.dateTimePicker1);
               this.groupBox1.Controls.Add(this.dtpFecha);
               this.groupBox1.Controls.Add(this.btnQuitar);
               this.groupBox1.Controls.Add(this.btnAgregar);
               this.groupBox1.Controls.Add(this.btnReporte);
               this.groupBox1.Controls.Add(this.btnEnviarCorreo);
               this.groupBox1.Controls.Add(this.btnguardar);
               this.groupBox1.Controls.Add(this.cmbServicios);
               this.groupBox1.Controls.Add(this.dgvServicios);
               this.groupBox1.Controls.Add(this.label9);
               this.groupBox1.Controls.Add(this.label8);
               this.groupBox1.Controls.Add(this.label5);
               this.groupBox1.Controls.Add(this.txtDireccion);
               this.groupBox1.Controls.Add(this.label4);
               this.groupBox1.Controls.Add(this.label3);
               this.groupBox1.Controls.Add(this.cmbCliente);
               this.groupBox1.Controls.Add(this.label1);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Controls.Add(this.txtFactura);
               this.groupBox1.ForeColor = System.Drawing.Color.White;
               this.groupBox1.Location = new System.Drawing.Point(12, 5);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(786, 442);
               this.groupBox1.TabIndex = 63;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "FACTURA";
               this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
               // 
               // btnEmilinar
               // 
               this.btnEmilinar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnEmilinar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.btnEmilinar.FlatAppearance.BorderSize = 0;
               this.btnEmilinar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnEmilinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnEmilinar.ForeColor = System.Drawing.Color.White;
               this.btnEmilinar.Location = new System.Drawing.Point(674, 186);
               this.btnEmilinar.Name = "btnEmilinar";
               this.btnEmilinar.Size = new System.Drawing.Size(100, 35);
               this.btnEmilinar.TabIndex = 93;
               this.btnEmilinar.Text = "Eliminar";
               this.btnEmilinar.UseVisualStyleBackColor = false;
               this.btnEmilinar.Click += new System.EventHandler(this.btnEmilinar_Click);
               // 
               // btnBuscar
               // 
               this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.btnBuscar.FlatAppearance.BorderSize = 0;
               this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnBuscar.ForeColor = System.Drawing.Color.White;
               this.btnBuscar.Location = new System.Drawing.Point(674, 32);
               this.btnBuscar.Name = "btnBuscar";
               this.btnBuscar.Size = new System.Drawing.Size(100, 35);
               this.btnBuscar.TabIndex = 92;
               this.btnBuscar.Text = "Buscar";
               this.btnBuscar.UseVisualStyleBackColor = false;
               this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
               // 
               // txt_idservicio
               // 
               this.txt_idservicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.txt_idservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_idservicio.Location = new System.Drawing.Point(304, 75);
               this.txt_idservicio.Name = "txt_idservicio";
               this.txt_idservicio.Size = new System.Drawing.Size(35, 23);
               this.txt_idservicio.TabIndex = 91;
               // 
               // txt_idcliente
               // 
               this.txt_idcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.txt_idcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txt_idcliente.Location = new System.Drawing.Point(317, 18);
               this.txt_idcliente.Name = "txt_idcliente";
               this.txt_idcliente.Size = new System.Drawing.Size(35, 23);
               this.txt_idcliente.TabIndex = 90;
               // 
               // txtMensajes
               // 
               this.txtMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMensajes.Location = new System.Drawing.Point(17, 379);
               this.txtMensajes.Name = "txtMensajes";
               this.txtMensajes.Size = new System.Drawing.Size(421, 23);
               this.txtMensajes.TabIndex = 89;
               // 
               // cboxFacturaPagada
               // 
               this.cboxFacturaPagada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.cboxFacturaPagada.AutoSize = true;
               this.cboxFacturaPagada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.cboxFacturaPagada.Location = new System.Drawing.Point(674, 379);
               this.cboxFacturaPagada.Name = "cboxFacturaPagada";
               this.cboxFacturaPagada.Size = new System.Drawing.Size(102, 17);
               this.cboxFacturaPagada.TabIndex = 88;
               this.cboxFacturaPagada.Text = "Factura Pagada";
               this.cboxFacturaPagada.UseVisualStyleBackColor = true;
               this.cboxFacturaPagada.CheckedChanged += new System.EventHandler(this.cboxFacturaPagada_CheckedChanged);
               // 
               // label11
               // 
               this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.label11.AutoSize = true;
               this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label11.ForeColor = System.Drawing.Color.White;
               this.label11.Location = new System.Drawing.Point(601, 414);
               this.label11.Name = "label11";
               this.label11.Size = new System.Drawing.Size(88, 17);
               this.label11.TabIndex = 87;
               this.label11.Text = "Fecha Pago:";
               // 
               // dtpFechadePago
               // 
               this.dtpFechadePago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.dtpFechadePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
               this.dtpFechadePago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dtpFechadePago.Location = new System.Drawing.Point(689, 409);
               this.dtpFechadePago.Name = "dtpFechadePago";
               this.dtpFechadePago.Size = new System.Drawing.Size(87, 23);
               this.dtpFechadePago.TabIndex = 86;
               // 
               // label7
               // 
               this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.ForeColor = System.Drawing.Color.White;
               this.label7.Location = new System.Drawing.Point(444, 382);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(73, 17);
               this.label7.TabIndex = 85;
               this.label7.Text = "Sub Total:";
               // 
               // label6
               // 
               this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.ForeColor = System.Drawing.Color.White;
               this.label6.Location = new System.Drawing.Point(473, 414);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(44, 17);
               this.label6.TabIndex = 84;
               this.label6.Text = "Total:";
               // 
               // txtSubtotal
               // 
               this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtSubtotal.Location = new System.Drawing.Point(516, 379);
               this.txtSubtotal.Name = "txtSubtotal";
               this.txtSubtotal.Size = new System.Drawing.Size(74, 23);
               this.txtSubtotal.TabIndex = 83;
               // 
               // txtTotal
               // 
               this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtTotal.Location = new System.Drawing.Point(516, 411);
               this.txtTotal.Name = "txtTotal";
               this.txtTotal.Size = new System.Drawing.Size(75, 23);
               this.txtTotal.TabIndex = 82;
               // 
               // cboxEditarFactura
               // 
               this.cboxEditarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.cboxEditarFactura.AutoSize = true;
               this.cboxEditarFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.cboxEditarFactura.Location = new System.Drawing.Point(674, 102);
               this.cboxEditarFactura.Name = "cboxEditarFactura";
               this.cboxEditarFactura.Size = new System.Drawing.Size(92, 17);
               this.cboxEditarFactura.TabIndex = 81;
               this.cboxEditarFactura.Text = "Editar Factura";
               this.cboxEditarFactura.UseVisualStyleBackColor = true;
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label10.ForeColor = System.Drawing.Color.White;
               this.label10.Location = new System.Drawing.Point(407, 107);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(52, 17);
               this.label10.TabIndex = 79;
               this.label10.Text = "Precio:";
               // 
               // txtPrecio
               // 
               this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtPrecio.Location = new System.Drawing.Point(473, 104);
               this.txtPrecio.Name = "txtPrecio";
               this.txtPrecio.Size = new System.Drawing.Size(87, 23);
               this.txtPrecio.TabIndex = 78;
               // 
               // dateTimePicker1
               // 
               this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
               this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dateTimePicker1.Location = new System.Drawing.Point(71, 104);
               this.dateTimePicker1.Name = "dateTimePicker1";
               this.dateTimePicker1.Size = new System.Drawing.Size(87, 23);
               this.dateTimePicker1.TabIndex = 77;
               // 
               // dtpFecha
               // 
               this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
               this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dtpFecha.Location = new System.Drawing.Point(564, 18);
               this.dtpFecha.Name = "dtpFecha";
               this.dtpFecha.Size = new System.Drawing.Size(87, 23);
               this.dtpFecha.TabIndex = 76;
               // 
               // btnQuitar
               // 
               this.btnQuitar.BackColor = System.Drawing.Color.Red;
               this.btnQuitar.Font = new System.Drawing.Font("Webdings", 8F);
               this.btnQuitar.Location = new System.Drawing.Point(595, 102);
               this.btnQuitar.Name = "btnQuitar";
               this.btnQuitar.Size = new System.Drawing.Size(28, 25);
               this.btnQuitar.TabIndex = 75;
               this.btnQuitar.Text = "r";
               this.btnQuitar.UseVisualStyleBackColor = false;
               this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
               // 
               // btnAgregar
               // 
               this.btnAgregar.BackColor = System.Drawing.Color.Lime;
               this.btnAgregar.Font = new System.Drawing.Font("Webdings", 10F);
               this.btnAgregar.Location = new System.Drawing.Point(566, 102);
               this.btnAgregar.Name = "btnAgregar";
               this.btnAgregar.Size = new System.Drawing.Size(28, 25);
               this.btnAgregar.TabIndex = 74;
               this.btnAgregar.Text = "a";
               this.btnAgregar.UseVisualStyleBackColor = false;
               this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
               // 
               // btnReporte
               // 
               this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.btnReporte.FlatAppearance.BorderSize = 0;
               this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnReporte.ForeColor = System.Drawing.Color.White;
               this.btnReporte.Location = new System.Drawing.Point(674, 279);
               this.btnReporte.Name = "btnReporte";
               this.btnReporte.Size = new System.Drawing.Size(100, 35);
               this.btnReporte.TabIndex = 73;
               this.btnReporte.Text = "Reporte";
               this.btnReporte.UseVisualStyleBackColor = false;
               this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
               // 
               // btnEnviarCorreo
               // 
               this.btnEnviarCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnEnviarCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.btnEnviarCorreo.FlatAppearance.BorderSize = 0;
               this.btnEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnEnviarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnEnviarCorreo.ForeColor = System.Drawing.Color.White;
               this.btnEnviarCorreo.Location = new System.Drawing.Point(674, 233);
               this.btnEnviarCorreo.Name = "btnEnviarCorreo";
               this.btnEnviarCorreo.Size = new System.Drawing.Size(100, 35);
               this.btnEnviarCorreo.TabIndex = 72;
               this.btnEnviarCorreo.Text = "Enviar Correo";
               this.btnEnviarCorreo.UseVisualStyleBackColor = false;
               this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
               // 
               // btnguardar
               // 
               this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
               this.btnguardar.FlatAppearance.BorderSize = 0;
               this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnguardar.ForeColor = System.Drawing.Color.White;
               this.btnguardar.Location = new System.Drawing.Point(674, 140);
               this.btnguardar.Name = "btnguardar";
               this.btnguardar.Size = new System.Drawing.Size(100, 35);
               this.btnguardar.TabIndex = 71;
               this.btnguardar.Text = "Guardar";
               this.btnguardar.UseVisualStyleBackColor = false;
               this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
               // 
               // cmbServicios
               // 
               this.cmbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
               this.cmbServicios.FormattingEnabled = true;
               this.cmbServicios.Location = new System.Drawing.Point(239, 103);
               this.cmbServicios.Name = "cmbServicios";
               this.cmbServicios.Size = new System.Drawing.Size(162, 24);
               this.cmbServicios.TabIndex = 70;
               this.cmbServicios.SelectedIndexChanged += new System.EventHandler(this.cmbServicios_SelectedIndexChanged);
               // 
               // dgvServicios
               // 
               this.dgvServicios.AllowUserToAddRows = false;
               this.dgvServicios.AllowUserToDeleteRows = false;
               this.dgvServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
               this.dgvServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
               this.dgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.dgvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
               this.dgvServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
               dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dgvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
               this.dgvServicios.ColumnHeadersHeight = 30;
               this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Servicio,
            this.Fecha,
            this.Precio});
               dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
               dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
               dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dgvServicios.DefaultCellStyle = dataGridViewCellStyle2;
               this.dgvServicios.EnableHeadersVisualStyles = false;
               this.dgvServicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.dgvServicios.Location = new System.Drawing.Point(17, 130);
               this.dgvServicios.Name = "dgvServicios";
               this.dgvServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
               dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
               dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dgvServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
               this.dgvServicios.Size = new System.Drawing.Size(606, 243);
               this.dgvServicios.TabIndex = 69;
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.ForeColor = System.Drawing.Color.White;
               this.label9.Location = new System.Drawing.Point(171, 105);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(62, 17);
               this.label9.TabIndex = 68;
               this.label9.Text = "Servicio:";
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label8.ForeColor = System.Drawing.Color.White;
               this.label8.Location = new System.Drawing.Point(14, 107);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(51, 17);
               this.label8.TabIndex = 67;
               this.label8.Text = "Fecha:";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.Color.White;
               this.label5.Location = new System.Drawing.Point(181, 75);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(117, 17);
               this.label5.TabIndex = 66;
               this.label5.Text = "Agregar Servicio:";
               // 
               // txtDireccion
               // 
               this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtDireccion.Location = new System.Drawing.Point(89, 49);
               this.txtDireccion.Name = "txtDireccion";
               this.txtDireccion.Size = new System.Drawing.Size(352, 23);
               this.txtDireccion.TabIndex = 65;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.Color.White;
               this.label4.Location = new System.Drawing.Point(14, 52);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(71, 17);
               this.label4.TabIndex = 64;
               this.label4.Text = "Dirección:";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.ForeColor = System.Drawing.Color.White;
               this.label3.Location = new System.Drawing.Point(29, 20);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(55, 17);
               this.label3.TabIndex = 63;
               this.label3.Text = "Cliente:";
               // 
               // cmbCliente
               // 
               this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
               this.cmbCliente.FormattingEnabled = true;
               this.cmbCliente.Location = new System.Drawing.Point(88, 19);
               this.cmbCliente.Name = "cmbCliente";
               this.cmbCliente.Size = new System.Drawing.Size(223, 24);
               this.cmbCliente.TabIndex = 62;
               this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
               // 
               // label1
               // 
               this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.White;
               this.label1.Location = new System.Drawing.Point(472, 48);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(86, 17);
               this.label1.TabIndex = 61;
               this.label1.Text = "No. Factura:";
               // 
               // label2
               // 
               this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.ForeColor = System.Drawing.Color.White;
               this.label2.Location = new System.Drawing.Point(488, 21);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(51, 17);
               this.label2.TabIndex = 60;
               this.label2.Text = "Fecha:";
               // 
               // txtFactura
               // 
               this.txtFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.txtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtFactura.Location = new System.Drawing.Point(564, 44);
               this.txtFactura.Name = "txtFactura";
               this.txtFactura.Size = new System.Drawing.Size(87, 23);
               this.txtFactura.TabIndex = 59;
               // 
               // id
               // 
               this.id.DataPropertyName = "id_Servicio";
               this.id.HeaderText = "id_Servicio";
               this.id.Name = "id";
               this.id.Width = 91;
               // 
               // Servicio
               // 
               this.Servicio.DataPropertyName = "Descripcion";
               this.Servicio.HeaderText = "Descripcion";
               this.Servicio.Name = "Servicio";
               this.Servicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
               this.Servicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
               this.Servicio.Width = 77;
               // 
               // Fecha
               // 
               this.Fecha.DataPropertyName = "Fecha_servicio";
               this.Fecha.HeaderText = "Fecha_servicio";
               this.Fecha.MinimumWidth = 60;
               this.Fecha.Name = "Fecha";
               this.Fecha.Width = 113;
               // 
               // Precio
               // 
               this.Precio.DataPropertyName = "Precio";
               this.Precio.HeaderText = "Precio";
               this.Precio.Name = "Precio";
               this.Precio.Width = 66;
               // 
               // FormFactura
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.groupBox1);
               this.Name = "FormFactura";
               this.Text = "FormFactura";
               this.Load += new System.EventHandler(this.FormFactura_Load);
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.CheckBox cboxFacturaPagada;
          private System.Windows.Forms.Label label11;
          private System.Windows.Forms.DateTimePicker dtpFechadePago;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.Label label6;
          public System.Windows.Forms.TextBox txtSubtotal;
          public System.Windows.Forms.TextBox txtTotal;
          private System.Windows.Forms.CheckBox cboxEditarFactura;
          private System.Windows.Forms.Label label10;
          public System.Windows.Forms.TextBox txtPrecio;
          private System.Windows.Forms.DateTimePicker dateTimePicker1;
          private System.Windows.Forms.DateTimePicker dtpFecha;
          private System.Windows.Forms.Button btnQuitar;
          private System.Windows.Forms.Button btnAgregar;
          private System.Windows.Forms.Button btnReporte;
          private System.Windows.Forms.Button btnEnviarCorreo;
          private System.Windows.Forms.Button btnguardar;
          private System.Windows.Forms.ComboBox cmbServicios;
          private System.Windows.Forms.DataGridView dgvServicios;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.Label label5;
          public System.Windows.Forms.TextBox txtDireccion;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.ComboBox cmbCliente;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          public System.Windows.Forms.TextBox txtFactura;
          public System.Windows.Forms.TextBox txtMensajes;
          public System.Windows.Forms.TextBox txt_idcliente;
          public System.Windows.Forms.TextBox txt_idservicio;
          private System.Windows.Forms.Button btnBuscar;
          private System.Windows.Forms.Button btnEmilinar;
          private System.Windows.Forms.DataGridViewTextBoxColumn id;
          private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
          private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
          private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
     }
}