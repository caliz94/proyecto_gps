
namespace Presentacion
{
    partial class frmEditar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditar));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txb_cantidad = new System.Windows.Forms.TextBox();
            this.txb_marca = new System.Windows.Forms.TextBox();
            this.txb_precio = new System.Windows.Forms.TextBox();
            this.txb_producto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txb_CodProducto = new System.Windows.Forms.TextBox();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.txb_IdProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 23F);
            this.lblTitulo.Location = new System.Drawing.Point(246, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(321, 38);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "EDITAR PRODUCTO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(579, 407);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txb_cantidad
            // 
            this.txb_cantidad.Location = new System.Drawing.Point(579, 267);
            this.txb_cantidad.Name = "txb_cantidad";
            this.txb_cantidad.ReadOnly = true;
            this.txb_cantidad.Size = new System.Drawing.Size(207, 20);
            this.txb_cantidad.TabIndex = 17;
            this.txb_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_cantidad_KeyPress);
            // 
            // txb_marca
            // 
            this.txb_marca.Location = new System.Drawing.Point(579, 340);
            this.txb_marca.Name = "txb_marca";
            this.txb_marca.ReadOnly = true;
            this.txb_marca.Size = new System.Drawing.Size(207, 20);
            this.txb_marca.TabIndex = 16;
            // 
            // txb_precio
            // 
            this.txb_precio.Location = new System.Drawing.Point(579, 302);
            this.txb_precio.Name = "txb_precio";
            this.txb_precio.ReadOnly = true;
            this.txb_precio.Size = new System.Drawing.Size(207, 20);
            this.txb_precio.TabIndex = 15;
            this.txb_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_precio_KeyPress);
            // 
            // txb_producto
            // 
            this.txb_producto.Location = new System.Drawing.Point(579, 231);
            this.txb_producto.Name = "txb_producto";
            this.txb_producto.ReadOnly = true;
            this.txb_producto.Size = new System.Drawing.Size(207, 20);
            this.txb_producto.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "MARCA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "PRECIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "CANTIDAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "PRODUCTO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "PRODUCTO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(310, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "RESULTADOS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(425, 251);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txb_CodProducto
            // 
            this.txb_CodProducto.Location = new System.Drawing.Point(638, 198);
            this.txb_CodProducto.Name = "txb_CodProducto";
            this.txb_CodProducto.ReadOnly = true;
            this.txb_CodProducto.Size = new System.Drawing.Size(148, 20);
            this.txb_CodProducto.TabIndex = 27;
            this.txb_CodProducto.Visible = false;
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProducto.Location = new System.Drawing.Point(458, 198);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(174, 18);
            this.lblCodProducto.TabIndex = 26;
            this.lblCodProducto.Text = "CÓDIGO PRODUCTO";
            this.lblCodProducto.Visible = false;
            // 
            // txb_IdProducto
            // 
            this.txb_IdProducto.Location = new System.Drawing.Point(485, 63);
            this.txb_IdProducto.Name = "txb_IdProducto";
            this.txb_IdProducto.ReadOnly = true;
            this.txb_IdProducto.Size = new System.Drawing.Size(100, 20);
            this.txb_IdProducto.TabIndex = 28;
            this.txb_IdProducto.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 87);
            this.label7.TabIndex = 29;
            this.label7.Text = "MODIFICAR DATOS \r\nDEL \r\nPRODUCTO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_IdProducto);
            this.Controls.Add(this.txb_CodProducto);
            this.Controls.Add(this.lblCodProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txb_cantidad);
            this.Controls.Add(this.txb_marca);
            this.Controls.Add(this.txb_precio);
            this.Controls.Add(this.txb_producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITAR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditar_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txb_cantidad;
        private System.Windows.Forms.TextBox txb_marca;
        private System.Windows.Forms.TextBox txb_precio;
        private System.Windows.Forms.TextBox txb_producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txb_CodProducto;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.TextBox txb_IdProducto;
        private System.Windows.Forms.Label label7;
    }
}