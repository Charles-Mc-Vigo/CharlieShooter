using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form4 : Form
    {
        public Form4(int Pscore)
        {
            InitializeComponent();
            lbScore.Text="Score : "+ Pscore.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            //return to from1 if exit button is clicked
            Form2 form2= new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //return to from2 is restart button clicked
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
