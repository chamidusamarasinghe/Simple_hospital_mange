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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Medical Center," + "\n" +
                            "University of Vavuniya," + "\n" +
                            "Pampaimadu," + "\n" + "Vavuniya," + "\n" + "Sri Lanka."
                            , "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 patient = new Form3();
            patient.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
