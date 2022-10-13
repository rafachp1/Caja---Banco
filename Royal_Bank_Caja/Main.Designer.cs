
namespace Royal_Bank_Caja
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMain = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCreateAcc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWithdraw = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnServices = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.iniciarJornadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarJornadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripButton();
            this.pagoDePrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMain,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.btnLogout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMain
            // 
            this.btnMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(40, 22);
            this.btnMain.Text = "Inicio";
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateAcc,
            this.btnCheckStatus});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton1.Text = "Cuentas";
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(180, 22);
            this.btnCreateAcc.Text = "Crear cuenta";
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(180, 22);
            this.btnCheckStatus.Text = "Consultar estado";
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeposit,
            this.btnWithdraw,
            this.btnTransfer,
            this.btnServices,
            this.pagoDePrestamosToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(93, 22);
            this.toolStripDropDownButton2.Text = "Transacciones";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(180, 22);
            this.btnDeposit.Text = "Depositos";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(180, 22);
            this.btnWithdraw.Text = "Retiros";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(180, 22);
            this.btnTransfer.Text = "Transferencias";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnServices
            // 
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(180, 22);
            this.btnServices.Text = "Pago de servicios";
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarJornadaToolStripMenuItem,
            this.terminarJornadaToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton3.Text = "Gerencia";
            // 
            // iniciarJornadaToolStripMenuItem
            // 
            this.iniciarJornadaToolStripMenuItem.Name = "iniciarJornadaToolStripMenuItem";
            this.iniciarJornadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarJornadaToolStripMenuItem.Text = "Iniciar jornada";
            // 
            // terminarJornadaToolStripMenuItem
            // 
            this.terminarJornadaToolStripMenuItem.Name = "terminarJornadaToolStripMenuItem";
            this.terminarJornadaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.terminarJornadaToolStripMenuItem.Text = "Terminar jornada";
            // 
            // btnLogout
            // 
            this.btnLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(79, 22);
            this.btnLogout.Text = "Cerrar sesión";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pagoDePrestamosToolStripMenuItem
            // 
            this.pagoDePrestamosToolStripMenuItem.Name = "pagoDePrestamosToolStripMenuItem";
            this.pagoDePrestamosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pagoDePrestamosToolStripMenuItem.Text = "Pago de prestamos";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Royal Bank";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnCreateAcc;
        private System.Windows.Forms.ToolStripMenuItem btnCheckStatus;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem btnDeposit;
        private System.Windows.Forms.ToolStripMenuItem btnWithdraw;
        private System.Windows.Forms.ToolStripMenuItem btnTransfer;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem iniciarJornadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarJornadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.ToolStripMenuItem btnServices;
        private System.Windows.Forms.ToolStripButton btnMain;
        private System.Windows.Forms.ToolStripMenuItem pagoDePrestamosToolStripMenuItem;
    }
}