
namespace COMPLETE_FLAT_UI
{
     partial class FormListaServicios
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.BtnCerrar = new System.Windows.Forms.Button();
               this.dgvServicios = new System.Windows.Forms.DataGridView();
               this.btnNuevo = new System.Windows.Forms.Button();
               this.btneliminar = new System.Windows.Forms.Button();
               this.btnEditar = new System.Windows.Forms.Button();
               this.btnBuscar = new System.Windows.Forms.Button();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
               this.SuspendLayout();
               // 
               // groupBox1
               // 
               this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.groupBox1.Controls.Add(this.BtnCerrar);
               this.groupBox1.Controls.Add(this.dgvServicios);
               this.groupBox1.Controls.Add(this.btnNuevo);
               this.groupBox1.Controls.Add(this.btneliminar);
               this.groupBox1.Controls.Add(this.btnEditar);
               this.groupBox1.Controls.Add(this.btnBuscar);
               this.groupBox1.ForeColor = System.Drawing.Color.White;
               this.groupBox1.Location = new System.Drawing.Point(12, 12);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(846, 433);
               this.groupBox1.TabIndex = 23;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "SERVICIO";
               // 
               // BtnCerrar
               // 
               this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
               this.BtnCerrar.FlatAppearance.BorderSize = 0;
               this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.BtnCerrar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
               this.BtnCerrar.Location = new System.Drawing.Point(792, 16);
               this.BtnCerrar.Name = "BtnCerrar";
               this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
               this.BtnCerrar.TabIndex = 26;
               this.BtnCerrar.UseVisualStyleBackColor = true;
               this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
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
               dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
               dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dgvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
               this.dgvServicios.ColumnHeadersHeight = 30;
               dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
               dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
               dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
               this.dgvServicios.DefaultCellStyle = dataGridViewCellStyle14;
               this.dgvServicios.EnableHeadersVisualStyles = false;
               this.dgvServicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.dgvServicios.Location = new System.Drawing.Point(15, 19);
               this.dgvServicios.Name = "dgvServicios";
               this.dgvServicios.ReadOnly = true;
               this.dgvServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
               dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle15.ForeColor = System.Drawing.Color.PaleVioletRed;
               dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dgvServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
               this.dgvServicios.Size = new System.Drawing.Size(714, 377);
               this.dgvServicios.TabIndex = 25;
               // 
               // btnNuevo
               // 
               this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default;
               this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
               this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnNuevo.ForeColor = System.Drawing.Color.Silver;
               this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnNuevo.Location = new System.Drawing.Point(735, 65);
               this.btnNuevo.Name = "btnNuevo";
               this.btnNuevo.Size = new System.Drawing.Size(100, 30);
               this.btnNuevo.TabIndex = 24;
               this.btnNuevo.Text = "Nuevo";
               this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnNuevo.UseVisualStyleBackColor = false;
               this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
               // 
               // btneliminar
               // 
               this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.btneliminar.Cursor = System.Windows.Forms.Cursors.Default;
               this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
               this.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btneliminar.ForeColor = System.Drawing.Color.Silver;
               this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btneliminar.Location = new System.Drawing.Point(735, 137);
               this.btneliminar.Name = "btneliminar";
               this.btneliminar.Size = new System.Drawing.Size(100, 30);
               this.btneliminar.TabIndex = 23;
               this.btneliminar.Text = "Eliminar";
               this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btneliminar.UseVisualStyleBackColor = false;
               this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
               // 
               // btnEditar
               // 
               this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.btnEditar.Cursor = System.Windows.Forms.Cursors.Default;
               this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
               this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnEditar.ForeColor = System.Drawing.Color.Silver;
               this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnEditar.Location = new System.Drawing.Point(735, 101);
               this.btnEditar.Name = "btnEditar";
               this.btnEditar.Size = new System.Drawing.Size(100, 30);
               this.btnEditar.TabIndex = 22;
               this.btnEditar.Text = "Editar";
               this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnEditar.UseVisualStyleBackColor = false;
               this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
               // 
               // btnBuscar
               // 
               this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
               this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
               this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
               this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnBuscar.ForeColor = System.Drawing.Color.Silver;
               this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.btnBuscar.Location = new System.Drawing.Point(735, 173);
               this.btnBuscar.Name = "btnBuscar";
               this.btnBuscar.Size = new System.Drawing.Size(100, 30);
               this.btnBuscar.TabIndex = 21;
               this.btnBuscar.Text = "Buscar";
               this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
               this.btnBuscar.UseVisualStyleBackColor = false;
               // 
               // FormListaServicios
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
               this.ClientSize = new System.Drawing.Size(870, 457);
               this.Controls.Add(this.groupBox1);
               this.Name = "FormListaServicios";
               this.Text = "FormListaServicios";
               this.Load += new System.EventHandler(this.FormListaServicios_Load);
               this.groupBox1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.Button BtnCerrar;
          private System.Windows.Forms.DataGridView dgvServicios;
          private System.Windows.Forms.Button btnNuevo;
          private System.Windows.Forms.Button btneliminar;
          private System.Windows.Forms.Button btnEditar;
          private System.Windows.Forms.Button btnBuscar;
     }
}