namespace Ejercicio9_Descuento_Articulos
{
    partial class Form1
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.txt_montoNeto = new System.Windows.Forms.TextBox();
            this.lbl_montoNeto = new System.Windows.Forms.Label();
            this.txt_itbis = new System.Windows.Forms.TextBox();
            this.lbl_itbis = new System.Windows.Forms.Label();
            this.txt_descuentoAplicar = new System.Windows.Forms.TextBox();
            this.lbl_descuentoAplicar = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_cerrar.Location = new System.Drawing.Point(336, 114);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 29;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Yellow;
            this.btn_limpiar.Location = new System.Drawing.Point(336, 77);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 28;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // txt_montoNeto
            // 
            this.txt_montoNeto.Location = new System.Drawing.Point(177, 154);
            this.txt_montoNeto.Name = "txt_montoNeto";
            this.txt_montoNeto.Size = new System.Drawing.Size(99, 20);
            this.txt_montoNeto.TabIndex = 27;
            // 
            // lbl_montoNeto
            // 
            this.lbl_montoNeto.AutoSize = true;
            this.lbl_montoNeto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montoNeto.Location = new System.Drawing.Point(87, 155);
            this.lbl_montoNeto.Name = "lbl_montoNeto";
            this.lbl_montoNeto.Size = new System.Drawing.Size(87, 19);
            this.lbl_montoNeto.TabIndex = 26;
            this.lbl_montoNeto.Text = "Monto neto";
            // 
            // txt_itbis
            // 
            this.txt_itbis.Location = new System.Drawing.Point(177, 128);
            this.txt_itbis.Name = "txt_itbis";
            this.txt_itbis.Size = new System.Drawing.Size(99, 20);
            this.txt_itbis.TabIndex = 25;
            // 
            // lbl_itbis
            // 
            this.lbl_itbis.AutoSize = true;
            this.lbl_itbis.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itbis.Location = new System.Drawing.Point(121, 129);
            this.lbl_itbis.Name = "lbl_itbis";
            this.lbl_itbis.Size = new System.Drawing.Size(37, 19);
            this.lbl_itbis.TabIndex = 24;
            this.lbl_itbis.Text = "Itbis";
            // 
            // txt_descuentoAplicar
            // 
            this.txt_descuentoAplicar.Location = new System.Drawing.Point(177, 102);
            this.txt_descuentoAplicar.Name = "txt_descuentoAplicar";
            this.txt_descuentoAplicar.Size = new System.Drawing.Size(99, 20);
            this.txt_descuentoAplicar.TabIndex = 23;
            // 
            // lbl_descuentoAplicar
            // 
            this.lbl_descuentoAplicar.AutoSize = true;
            this.lbl_descuentoAplicar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descuentoAplicar.Location = new System.Drawing.Point(34, 103);
            this.lbl_descuentoAplicar.Name = "lbl_descuentoAplicar";
            this.lbl_descuentoAplicar.Size = new System.Drawing.Size(140, 19);
            this.lbl_descuentoAplicar.TabIndex = 22;
            this.lbl_descuentoAplicar.Text = "Descuento a aplicar";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(177, 76);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(99, 20);
            this.txt_monto.TabIndex = 21;
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto.Location = new System.Drawing.Point(121, 77);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(53, 19);
            this.lbl_monto.TabIndex = 20;
            this.lbl_monto.Text = "Monto";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(177, 50);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(99, 20);
            this.txt_descuento.TabIndex = 19;
            // 
            // lbl_descuento
            // 
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descuento.Location = new System.Drawing.Point(93, 51);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(78, 19);
            this.lbl_descuento.TabIndex = 18;
            this.lbl_descuento.Text = "Descuento";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(177, 24);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(99, 20);
            this.txt_precio.TabIndex = 17;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.Lime;
            this.btn_calcular.Location = new System.Drawing.Point(336, 38);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 16;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(121, 23);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(52, 19);
            this.lbl_precio.TabIndex = 15;
            this.lbl_precio.Text = "Precio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(515, 208);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.txt_montoNeto);
            this.Controls.Add(this.lbl_montoNeto);
            this.Controls.Add(this.txt_itbis);
            this.Controls.Add(this.lbl_itbis);
            this.Controls.Add(this.txt_descuentoAplicar);
            this.Controls.Add(this.lbl_descuentoAplicar);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.lbl_descuento);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_precio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.TextBox txt_montoNeto;
        private System.Windows.Forms.Label lbl_montoNeto;
        private System.Windows.Forms.TextBox txt_itbis;
        private System.Windows.Forms.Label lbl_itbis;
        private System.Windows.Forms.TextBox txt_descuentoAplicar;
        private System.Windows.Forms.Label lbl_descuentoAplicar;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.Label lbl_descuento;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_precio;
    }
}

