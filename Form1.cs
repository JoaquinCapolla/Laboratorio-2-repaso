using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2_repaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_marca1_Click(object sender, EventArgs e)
        {

        }

        private void btn_alquilar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 frm = new Form2();

            frm.Show();
        }
    }
}
