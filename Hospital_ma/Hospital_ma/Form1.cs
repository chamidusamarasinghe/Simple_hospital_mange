using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_ma
{
    public partial class Form1 : Form
    {
        string username;
        string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtName.Text;
            password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter the crenditails", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (username != "Admin" || password != "123")
            {
                MessageBox.Show("Invalid Username or Password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Form2 home = new Form2();
                home.Show();

            }
            txtName.Clear();
            txtPassword.Clear();
        }
    }
}
