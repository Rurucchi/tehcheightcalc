using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace heightcalc
{
    public partial class baseForm : Form
    {
        public baseForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = userInput.Text;
            int height;
            bool isNumber = int.TryParse(input, out height);

            if (isNumber)
            {
                subForm myNewSubForm = new subForm();
                myNewSubForm.textBox1.Text = "Your height is " + input + "cm" ;
                myNewSubForm.Show();

                this.textBox3.Visible = false;
            }
            else
            {
                this.textBox3.Visible = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void baseForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }


}


