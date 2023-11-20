using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personnel_Department_of_the_Institute;
using Personnel_Department_of_the_Institute.Model;

namespace Personnel_Department_of_the_Institute
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionString conn = new ConnectionString();
            ConnectionString.login = LoginTextBox.Text;
            ConnectionString.password = PasswordTextBox.Text;
            try
            {
                var sql = new System.Data.SqlClient.SqlConnection(conn.ConnectionStr);
                sql.Open();

            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
