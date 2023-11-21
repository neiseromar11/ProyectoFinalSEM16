namespace ProyectoFinalSEM16
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.Barra_Titulo = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_agregar_extraer_productos = new System.Windows.Forms.Button();
            this.btn_gestionar_almacenes = new System.Windows.Forms.Button();
            this.btn_gestionar_productos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Barra_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_Titulo
            // 
            this.Barra_Titulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.Barra_Titulo.Controls.Add(this.btn_Salir);
            this.Barra_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barra_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Barra_Titulo.Name = "Barra_Titulo";
            this.Barra_Titulo.Size = new System.Drawing.Size(642, 38);
            this.Barra_Titulo.TabIndex = 0;
            this.Barra_Titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.Barra_Titulo_Paint);
            this.Barra_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_Titulo_MouseDown);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(609, 5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(30, 30);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Inventario";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_agregar_extraer_productos);
            this.panel1.Controls.Add(this.btn_gestionar_almacenes);
            this.panel1.Controls.Add(this.btn_gestionar_productos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 400);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_agregar_extraer_productos
            // 
            this.btn_agregar_extraer_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_agregar_extraer_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_agregar_extraer_productos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_agregar_extraer_productos.FlatAppearance.BorderSize = 0;
            this.btn_agregar_extraer_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar_extraer_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_extraer_productos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_extraer_productos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agregar_extraer_productos.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar_extraer_productos.Image")));
            this.btn_agregar_extraer_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar_extraer_productos.Location = new System.Drawing.Point(0, 200);
            this.btn_agregar_extraer_productos.Name = "btn_agregar_extraer_productos";
            this.btn_agregar_extraer_productos.Size = new System.Drawing.Size(300, 56);
            this.btn_agregar_extraer_productos.TabIndex = 4;
            this.btn_agregar_extraer_productos.Text = "Agregar y Extraer Productos               ";
            this.btn_agregar_extraer_productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar_extraer_productos.UseVisualStyleBackColor = false;
            // 
            // btn_gestionar_almacenes
            // 
            this.btn_gestionar_almacenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_gestionar_almacenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_gestionar_almacenes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_gestionar_almacenes.FlatAppearance.BorderSize = 0;
            this.btn_gestionar_almacenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_gestionar_almacenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gestionar_almacenes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gestionar_almacenes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_gestionar_almacenes.Image = ((System.Drawing.Image)(resources.GetObject("btn_gestionar_almacenes.Image")));
            this.btn_gestionar_almacenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gestionar_almacenes.Location = new System.Drawing.Point(0, 138);
            this.btn_gestionar_almacenes.Name = "btn_gestionar_almacenes";
            this.btn_gestionar_almacenes.Size = new System.Drawing.Size(300, 56);
            this.btn_gestionar_almacenes.TabIndex = 3;
            this.btn_gestionar_almacenes.Text = "Gestionar Almacenes                       ";
            this.btn_gestionar_almacenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gestionar_almacenes.UseVisualStyleBackColor = false;
            // 
            // btn_gestionar_productos
            // 
            this.btn_gestionar_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_gestionar_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_gestionar_productos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_gestionar_productos.FlatAppearance.BorderSize = 0;
            this.btn_gestionar_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_gestionar_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gestionar_productos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gestionar_productos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_gestionar_productos.Image = ((System.Drawing.Image)(resources.GetObject("btn_gestionar_productos.Image")));
            this.btn_gestionar_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gestionar_productos.Location = new System.Drawing.Point(0, 76);
            this.btn_gestionar_productos.Name = "btn_gestionar_productos";
            this.btn_gestionar_productos.Size = new System.Drawing.Size(300, 56);
            this.btn_gestionar_productos.TabIndex = 2;
            this.btn_gestionar_productos.Text = "Gestionar Productos                       ";
            this.btn_gestionar_productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gestionar_productos.UseVisualStyleBackColor = false;
            this.btn_gestionar_productos.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(37, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"Mi Tiendita\"   ";
            this.label2.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Principal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(642, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Barra_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Principal";
            this.Text = "Form_Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Barra_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_Salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_gestionar_productos;
        private System.Windows.Forms.Button btn_agregar_extraer_productos;
        private System.Windows.Forms.Button btn_gestionar_almacenes;
    }
}

