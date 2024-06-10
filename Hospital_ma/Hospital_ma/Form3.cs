using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hospital_ma
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name, reg, fac, blood, mobi, addres,dob;

            name = txtName.Text;
            reg = txtReg.Text;
            fac = txtFac.Text;
            dob = txtDob.Text;
            blood = txtBlood.Text;
            mobi = txtMobile.Text;
            addres = txtAddress.Text;

            if (name == "" || reg == "" || fac == "" || dob == "" || blood == "" || mobi == "" || addres == "")
            {
                MessageBox.Show("Please enter patient crenditails", "Patient details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                MessageBox.Show("Name               :" + name + "\n" +
                                "Register No     :" + reg + "\n" +
                                "Faculty             :" + fac + "\n" +
                                "DOB                 :" + dob + "\n" +
                                "Blood Group  :" + blood + "\n" +
                                "Address           :" + addres + "\n" + ""
                                , "Patient details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            txtName.Clear();
            txtReg.Clear();
            txtFac.Clear();
            txtDob.Clear();
            txtBlood.Clear();
            txtMobile.Clear();
            txtAddress.Clear();
        }
    }
}
