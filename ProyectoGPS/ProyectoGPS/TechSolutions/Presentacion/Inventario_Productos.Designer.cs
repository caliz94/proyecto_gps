
namespace Presentacion
{
    partial class Inventario_Productos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_producto = new System.Windows.Forms.TextBox();
            this.txb_precio = new System.Windows.Forms.TextBox();
            this.txb_marca = new System.Windows.Forms.TextBox();
            this.txb_cantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "CANTIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRECIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "MARCA";
            // 
            // txb_producto
            // 
            this.txb_producto.Location = new System.Drawing.Point(357, 173);
            this.txb_producto.Name = "txb_producto";
            this.txb_producto.Size = new System.Drawing.Size(207, 20);
            this.txb_producto.TabIndex = 4;
            // 
            // txb_precio
            // 
            this.txb_precio.Location = new System.Drawing.Point(357, 244);
            this.txb_precio.Name = "txb_precio";
            this.txb_precio.Size = new System.Drawing.Size(207, 20);
            this.txb_precio.TabIndex = 5;
            // 
            // txb_marca
            // 
            this.txb_marca.Location = new System.Drawing.Point(357, 282);
            this.txb_marca.Name = "txb_marca";
            this.txb_marca.Size = new System.Drawing.Size(207, 20);
            this.txb_marca.TabIndex = 6;
            // 
            // txb_cantidad
            // 
            this.txb_cantidad.Location = new System.Drawing.Point(357, 209);
            this.txb_cantidad.Name = "txb_cantidad";
            this.txb_cantidad.Size = new System.Drawing.Size(207, 20);
            this.txb_cantidad.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 23F);
            this.label5.Location = new System.Drawing.Point(154, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(492, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "INGRESAR NUEVO PRODUCTO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inventario_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_cantidad);
            this.Controls.Add(this.txb_marca);
            this.Controls.Add(this.txb_precio);
            this.Controls.Add(this.txb_producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inventario_Productos";
            this.Text = "Inventario_Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_producto;
        private System.Windows.Forms.TextBox txb_precio;
        private System.Windows.Forms.TextBox txb_marca;
        private System.Windows.Forms.TextBox txb_cantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}