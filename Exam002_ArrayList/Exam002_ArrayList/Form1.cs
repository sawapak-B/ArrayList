using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Exam002_ArrayList
{
    public partial class Form1 : Form
    {

        ArrayList Lists = new ArrayList(); 

        public Form1()
        {
            InitializeComponent();
            Lists = new ArrayList();
        }

      
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtInput.Text == "")
                {
                    MessageBox.Show("กรุณากรอกข้อมูล");
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                Lists.Add(txtInput.Text);
                txtInput.Text = "";
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Lists.Remove(txtInput.Text);
            txtInput.Text = "";
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < Lists.Count; i++)
            {
                MessageBox.Show(Lists[i].ToString());
            }

        }
    }
}
