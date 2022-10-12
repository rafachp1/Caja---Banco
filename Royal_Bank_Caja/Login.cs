using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Royal_Bank_Caja
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RafaelCheco\source\repos\Royal_Bank_Caja\Royal_Bank_Caja\Royal_db.mdf;Integrated Security=True";
            connection.Open();
   


   

        }
        

    }
}
