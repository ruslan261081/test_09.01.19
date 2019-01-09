using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelekQ
{
    public partial class Form1 : Form
    {
        int[] RandomNumbers = new int[5];
        Random r = new Random();
       
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Startbtn_Click(object sender, EventArgs e)
        {
           

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

        }

        private void Finishbtn_Click(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
