using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Royal_Bank_Caja
{
    public partial class Main : Form
    {

        private void WipeForms()
        {
           foreach (var control in this.Controls.OfType<Form>())
           {
               control.Close();
           }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        public Main()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            WipeForms();
            Cuentas_Crear fmCrear = new Cuentas_Crear();
            fmCrear.TopLevel = false;
            fmCrear.Dock = DockStyle.Fill;
            this.Controls.Add(fmCrear);
            fmCrear.Show();
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            WipeForms();
            Cuentas_Estado fmEstado = new Cuentas_Estado();
            fmEstado.TopLevel = false;
            fmEstado.Dock = DockStyle.Fill;
            this.Controls.Add(fmEstado);
            fmEstado.Show();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            WipeForms();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            WipeForms();
            Tran_Deposito fmDeposito = new Tran_Deposito();
            fmDeposito.TopLevel = false;
            fmDeposito.Dock = DockStyle.Fill;
            this.Controls.Add(fmDeposito);
            fmDeposito.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WipeForms();
            Tran_Retiro fmRetiro = new Tran_Retiro();
            fmRetiro.TopLevel = false;
            fmRetiro.Dock = DockStyle.Fill;
            this.Controls.Add(fmRetiro);
            fmRetiro.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            WipeForms();
            Tran_Transferencia fmTransferencia = new Tran_Transferencia();
            fmTransferencia.TopLevel = false;
            fmTransferencia.Dock = DockStyle.Fill;
            this.Controls.Add(fmTransferencia);
            fmTransferencia.Show();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            WipeForms();
            Tran_Servicio fmServicio = new Tran_Servicio();
            fmServicio.TopLevel = false;
            fmServicio.Dock = DockStyle.Fill;
            this.Controls.Add(fmServicio);
            fmServicio.Show();
        }
    }
}
