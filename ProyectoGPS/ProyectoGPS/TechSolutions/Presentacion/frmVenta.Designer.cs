
namespace Presentacion
{
    partial class frmVenta
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
            this.pn_Bottom = new System.Windows.Forms.Panel();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txb_TotCompra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_TotDescuento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_TotIVA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_Subtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txb_Sucursal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_NoFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txb_Descuento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_Cantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_IVA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.panel1Grid = new System.Windows.Forms.Panel();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pn_Bottom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.panel1Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Bottom
            // 
            this.pn_Bottom.Controls.Add(this.lblMensaje);
            this.pn_Bottom.Controls.Add(this.btnPagar);
            this.pn_Bottom.Controls.Add(this.txb_TotCompra);
            this.pn_Bottom.Controls.Add(this.label12);
            this.pn_Bottom.Controls.Add(this.txb_TotDescuento);
            this.pn_Bottom.Controls.Add(this.label11);
            this.pn_Bottom.Controls.Add(this.txb_TotIVA);
            this.pn_Bottom.Controls.Add(this.label10);
            this.pn_Bottom.Controls.Add(this.txb_Subtotal);
            this.pn_Bottom.Controls.Add(this.label7);
            this.pn_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_Bottom.Location = new System.Drawing.Point(0, 446);
            this.pn_Bottom.Name = "pn_Bottom";
            this.pn_Bottom.Size = new System.Drawing.Size(1239, 59);
            this.pn_Bottom.TabIndex = 0;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(635, 0);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(153, 56);
            this.btnPagar.TabIndex = 15;
            this.btnPagar.Text = "APLICAR\r\nCOMPRA";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txb_TotCompra
            // 
            this.txb_TotCompra.Location = new System.Drawing.Point(540, 22);
            this.txb_TotCompra.Name = "txb_TotCompra";
            this.txb_TotCompra.Size = new System.Drawing.Size(76, 20);
            this.txb_TotCompra.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(499, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Total";
            // 
            // txb_TotDescuento
            // 
            this.txb_TotDescuento.Location = new System.Drawing.Point(293, 22);
            this.txb_TotDescuento.Name = "txb_TotDescuento";
            this.txb_TotDescuento.Size = new System.Drawing.Size(76, 20);
            this.txb_TotDescuento.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(220, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Descuento";
            // 
            // txb_TotIVA
            // 
            this.txb_TotIVA.Location = new System.Drawing.Point(418, 22);
            this.txb_TotIVA.Name = "txb_TotIVA";
            this.txb_TotIVA.Size = new System.Drawing.Size(76, 20);
            this.txb_TotIVA.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(374, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "I.V.A.";
            // 
            // txb_Subtotal
            // 
            this.txb_Subtotal.Location = new System.Drawing.Point(139, 22);
            this.txb_Subtotal.Name = "txb_Subtotal";
            this.txb_Subtotal.Size = new System.Drawing.Size(76, 20);
            this.txb_Subtotal.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "SubTotal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txb_Sucursal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txb_NoFactura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_Cliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE LA VENTA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(458, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // txb_Sucursal
            // 
            this.txb_Sucursal.Location = new System.Drawing.Point(111, 22);
            this.txb_Sucursal.Name = "txb_Sucursal";
            this.txb_Sucursal.ReadOnly = true;
            this.txb_Sucursal.Size = new System.Drawing.Size(260, 20);
            this.txb_Sucursal.TabIndex = 7;
            this.txb_Sucursal.Text = "Universidad de Managua (UdeM)";
            this.txb_Sucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sucursal";
            // 
            // txb_NoFactura
            // 
            this.txb_NoFactura.Location = new System.Drawing.Point(458, 48);
            this.txb_NoFactura.Name = "txb_NoFactura";
            this.txb_NoFactura.ReadOnly = true;
            this.txb_NoFactura.Size = new System.Drawing.Size(122, 20);
            this.txb_NoFactura.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // txb_Cliente
            // 
            this.txb_Cliente.Location = new System.Drawing.Point(111, 48);
            this.txb_Cliente.Name = "txb_Cliente";
            this.txb_Cliente.Size = new System.Drawing.Size(260, 20);
            this.txb_Cliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.txb_Descuento);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txb_Cantidad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txb_IVA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 82);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CARGA DE PRODUCTOS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // txb_Descuento
            // 
            this.txb_Descuento.Location = new System.Drawing.Point(110, 51);
            this.txb_Descuento.Name = "txb_Descuento";
            this.txb_Descuento.ReadOnly = true;
            this.txb_Descuento.Size = new System.Drawing.Size(52, 20);
            this.txb_Descuento.TabIndex = 12;
            this.txb_Descuento.Text = "0";
            this.txb_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Descuento";
            // 
            // txb_Cantidad
            // 
            this.txb_Cantidad.Location = new System.Drawing.Point(451, 22);
            this.txb_Cantidad.Name = "txb_Cantidad";
            this.txb_Cantidad.Size = new System.Drawing.Size(122, 20);
            this.txb_Cantidad.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Producto";
            // 
            // txb_IVA
            // 
            this.txb_IVA.Location = new System.Drawing.Point(451, 51);
            this.txb_IVA.Name = "txb_IVA";
            this.txb_IVA.ReadOnly = true;
            this.txb_IVA.Size = new System.Drawing.Size(122, 20);
            this.txb_IVA.TabIndex = 5;
            this.txb_IVA.Text = "0.15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "I.V.A.";
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.Location = new System.Drawing.Point(1091, 110);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(136, 82);
            this.btnDescargar.TabIndex = 14;
            this.btnDescargar.Text = "Cancelar \r\nCompra";
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(1091, 22);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(136, 82);
            this.btnCargar.TabIndex = 13;
            this.btnCargar.Text = "Cargar \r\nal \r\nCarrito";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dgvCarrito);
            this.panelGrid.Location = new System.Drawing.Point(614, 22);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(471, 170);
            this.panelGrid.TabIndex = 9;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrito.Location = new System.Drawing.Point(0, 0);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(471, 170);
            this.dgvCarrito.TabIndex = 0;
            // 
            // panel1Grid
            // 
            this.panel1Grid.Controls.Add(this.dgvCompra);
            this.panel1Grid.Location = new System.Drawing.Point(12, 198);
            this.panel1Grid.Name = "panel1Grid";
            this.panel1Grid.Size = new System.Drawing.Size(1215, 242);
            this.panel1Grid.TabIndex = 15;
            // 
            // dgvCompra
            // 
            this.dgvCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompra.Location = new System.Drawing.Point(0, 0);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(1215, 242);
            this.dgvCompra.TabIndex = 0;
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMensaje.Location = new System.Drawing.Point(815, 22);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(282, 20);
            this.lblMensaje.TabIndex = 22;
            this.lblMensaje.Text = "Compra Realizada Satisfactoriamente.";
            this.lblMensaje.Visible = false;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 505);
            this.Controls.Add(this.panel1Grid);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pn_Bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMULARIO DE VENTAS";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.pn_Bottom.ResumeLayout(false);
            this.pn_Bottom.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.panel1Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Bottom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_Sucursal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_NoFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_IVA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txb_Descuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txb_TotCompra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_TotDescuento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_TotIVA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_Subtotal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txb_Cantidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1Grid;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.Label lblMensaje;
    }
}