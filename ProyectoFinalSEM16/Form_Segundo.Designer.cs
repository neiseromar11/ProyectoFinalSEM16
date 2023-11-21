namespace ProyectoFinalSEM16
{
    partial class Form_Segundo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Segundo));
            this.Barra_Titulo = new System.Windows.Forms.Panel();
            this.btn_Salir1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_modificar_producto = new System.Windows.Forms.Button();
            this.btn_eliminar_producto = new System.Windows.Forms.Button();
            this.btn_mostrar_inventario = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Barra_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_Titulo
            // 
            this.Barra_Titulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.Barra_Titulo.Controls.Add(this.btn_Salir1);
            this.Barra_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barra_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Barra_Titulo.Name = "Barra_Titulo";
            this.Barra_Titulo.Size = new System.Drawing.Size(647, 38);
            this.Barra_Titulo.TabIndex = 5;
            this.Barra_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_Titulo_MouseDown);
            // 
            // btn_Salir1
            // 
            this.btn_Salir1.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir1.Image")));
            this.btn_Salir1.Location = new System.Drawing.Point(609, 5);
            this.btn_Salir1.Name = "btn_Salir1";
            this.btn_Salir1.Size = new System.Drawing.Size(30, 30);
            this.btn_Salir1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir1.TabIndex = 3;
            this.btn_Salir1.TabStop = false;
            this.btn_Salir1.Click += new System.EventHandler(this.btn_Salir1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btn_mostrar_inventario);
            this.panel1.Controls.Add(this.btn_eliminar_producto);
            this.panel1.Controls.Add(this.btn_modificar_producto);
            this.panel1.Controls.Add(this.btn_agregar_producto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 473);
            this.panel1.TabIndex = 6;
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_agregar_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_agregar_producto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_agregar_producto.FlatAppearance.BorderSize = 0;
            this.btn_agregar_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_producto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_producto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agregar_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar_producto.Image")));
            this.btn_agregar_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar_producto.Location = new System.Drawing.Point(0, 76);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(300, 56);
            this.btn_agregar_producto.TabIndex = 2;
            this.btn_agregar_producto.Text = "Agregar Producto                          ";
            this.btn_agregar_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar_producto.UseVisualStyleBackColor = false;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
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
            this.label1.Text = "Gestionar Productos ";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(295, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 473);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btn_modificar_producto
            // 
            this.btn_modificar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_modificar_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_modificar_producto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_modificar_producto.FlatAppearance.BorderSize = 0;
            this.btn_modificar_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_modificar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar_producto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar_producto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_modificar_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar_producto.Image")));
            this.btn_modificar_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar_producto.Location = new System.Drawing.Point(0, 200);
            this.btn_modificar_producto.Name = "btn_modificar_producto";
            this.btn_modificar_producto.Size = new System.Drawing.Size(300, 56);
            this.btn_modificar_producto.TabIndex = 3;
            this.btn_modificar_producto.Text = "Modificar Producto                        ";
            this.btn_modificar_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_modificar_producto.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar_producto
            // 
            this.btn_eliminar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_eliminar_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_eliminar_producto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_eliminar_producto.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_eliminar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_producto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_producto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eliminar_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar_producto.Image")));
            this.btn_eliminar_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar_producto.Location = new System.Drawing.Point(0, 138);
            this.btn_eliminar_producto.Name = "btn_eliminar_producto";
            this.btn_eliminar_producto.Size = new System.Drawing.Size(300, 56);
            this.btn_eliminar_producto.TabIndex = 4;
            this.btn_eliminar_producto.Text = "Eliminar Producto                         ";
            this.btn_eliminar_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar_producto.UseVisualStyleBackColor = false;
            // 
            // btn_mostrar_inventario
            // 
            this.btn_mostrar_inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_mostrar_inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_mostrar_inventario.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_mostrar_inventario.FlatAppearance.BorderSize = 0;
            this.btn_mostrar_inventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_mostrar_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrar_inventario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar_inventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mostrar_inventario.Image = ((System.Drawing.Image)(resources.GetObject("btn_mostrar_inventario.Image")));
            this.btn_mostrar_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mostrar_inventario.Location = new System.Drawing.Point(0, 262);
            this.btn_mostrar_inventario.Name = "btn_mostrar_inventario";
            this.btn_mostrar_inventario.Size = new System.Drawing.Size(300, 56);
            this.btn_mostrar_inventario.TabIndex = 5;
            this.btn_mostrar_inventario.Text = "Mostrar Inventario ";
            this.btn_mostrar_inventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_mostrar_inventario.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 56);
            this.button4.TabIndex = 6;
            this.button4.Text = "Volver al Menú Principal";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Form_Segundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(647, 511);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Barra_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Segundo";
            this.Text = "Form_Segundo";
            this.Barra_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Titulo;
        private System.Windows.Forms.PictureBox btn_Salir1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_agregar_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_mostrar_inventario;
        private System.Windows.Forms.Button btn_eliminar_producto;
        private System.Windows.Forms.Button btn_modificar_producto;
    }
}