
namespace Presentacion
{
    partial class frm_contenedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_contenedor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOPRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARPRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARPRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTADODEPRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pboxLogin = new System.Windows.Forms.PictureBox();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_contraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblFoot = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.iNVENTARIOToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOPRODUCTOToolStripMenuItem,
            this.eDITARPRODUCTOToolStripMenuItem,
            this.eLIMINARPRODUCTOToolStripMenuItem,
            this.lISTADODEPRODUCTOSToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(222, 25);
            this.mENUToolStripMenuItem.Text = "Administración de Inventario";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.mENUToolStripMenuItem_Click);
            // 
            // nUEVOPRODUCTOToolStripMenuItem
            // 
            this.nUEVOPRODUCTOToolStripMenuItem.Name = "nUEVOPRODUCTOToolStripMenuItem";
            this.nUEVOPRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.nUEVOPRODUCTOToolStripMenuItem.Text = "Ingresar Nuevo Producto";
            this.nUEVOPRODUCTOToolStripMenuItem.Click += new System.EventHandler(this.nUEVOPRODUCTOToolStripMenuItem_Click);
            // 
            // eDITARPRODUCTOToolStripMenuItem
            // 
            this.eDITARPRODUCTOToolStripMenuItem.Name = "eDITARPRODUCTOToolStripMenuItem";
            this.eDITARPRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.eDITARPRODUCTOToolStripMenuItem.Text = "Editar Producto";
            this.eDITARPRODUCTOToolStripMenuItem.Click += new System.EventHandler(this.eDITARPRODUCTOToolStripMenuItem_Click);
            // 
            // eLIMINARPRODUCTOToolStripMenuItem
            // 
            this.eLIMINARPRODUCTOToolStripMenuItem.Name = "eLIMINARPRODUCTOToolStripMenuItem";
            this.eLIMINARPRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.eLIMINARPRODUCTOToolStripMenuItem.Text = "Eliminar Producto";
            this.eLIMINARPRODUCTOToolStripMenuItem.Click += new System.EventHandler(this.eLIMINARPRODUCTOToolStripMenuItem_Click);
            // 
            // lISTADODEPRODUCTOSToolStripMenuItem
            // 
            this.lISTADODEPRODUCTOSToolStripMenuItem.Name = "lISTADODEPRODUCTOSToolStripMenuItem";
            this.lISTADODEPRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.lISTADODEPRODUCTOSToolStripMenuItem.Text = "Listado de Productos del Inventario";
            this.lISTADODEPRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.lISTADODEPRODUCTOSToolStripMenuItem_Click);
            // 
            // iNVENTARIOToolStripMenuItem
            // 
            this.iNVENTARIOToolStripMenuItem.Name = "iNVENTARIOToolStripMenuItem";
            this.iNVENTARIOToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.iNVENTARIOToolStripMenuItem.Text = "Venta";
            this.iNVENTARIOToolStripMenuItem.Click += new System.EventHandler(this.iNVENTARIOToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.sALIRToolStripMenuItem.Text = "Salir";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_login);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.pboxLogin);
            this.panel1.Controls.Add(this.txb_usuario);
            this.panel1.Controls.Add(this.txb_contraseña);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(129, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 364);
            this.panel1.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(233, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(67, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "ACCESO DE USUARIOS";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.Red;
            this.lbl_login.Location = new System.Drawing.Point(52, 200);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(0, 20);
            this.lbl_login.TabIndex = 14;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(97, 304);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 30);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pboxLogin
            // 
            this.pboxLogin.BackgroundImage = global::Presentacion.Properties.Resources.icons8_user_80;
            this.pboxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxLogin.InitialImage = ((System.Drawing.Image)(resources.GetObject("pboxLogin.InitialImage")));
            this.pboxLogin.Location = new System.Drawing.Point(157, 55);
            this.pboxLogin.Name = "pboxLogin";
            this.pboxLogin.Size = new System.Drawing.Size(123, 127);
            this.pboxLogin.TabIndex = 12;
            this.pboxLogin.TabStop = false;
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(211, 233);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(143, 20);
            this.txb_usuario.TabIndex = 1;
            this.txb_usuario.TextChanged += new System.EventHandler(this.txb_usuario_TextChanged);
            // 
            // txb_contraseña
            // 
            this.txb_contraseña.Location = new System.Drawing.Point(211, 268);
            this.txb_contraseña.Name = "txb_contraseña";
            this.txb_contraseña.PasswordChar = '*';
            this.txb_contraseña.Size = new System.Drawing.Size(143, 20);
            this.txb_contraseña.TabIndex = 2;
            this.txb_contraseña.TextChanged += new System.EventHandler(this.txb_contraseña_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(68, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(68, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "USUARIO";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlRight.Controls.Add(this.lblFoot);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRight.Location = new System.Drawing.Point(0, 414);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(800, 36);
            this.pnlRight.TabIndex = 16;
            // 
            // lblFoot
            // 
            this.lblFoot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFoot.AutoSize = true;
            this.lblFoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoot.Location = new System.Drawing.Point(273, 10);
            this.lblFoot.Name = "lblFoot";
            this.lblFoot.Size = new System.Drawing.Size(255, 17);
            this.lblFoot.TabIndex = 0;
            this.lblFoot.Text = "Gestión de Proyectos de Software";
            this.lblFoot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TechSolutions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_contenedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOPRODUCTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARPRODUCTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARPRODUCTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pboxLogin;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_contraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblFoot;
        private System.Windows.Forms.ToolStripMenuItem lISTADODEPRODUCTOSToolStripMenuItem;
    }
}