﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizProgram
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private int theValue;
        public int TheValue
        {
            get { return this.theValue; }
            set { this.theValue = value; }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Text == "" || radioButton2.Text == "" || radioButton3.Text == "" || radioButton4.Text == "")
                MessageBox.Show("Please enter an answer!!");
            else
            {
                this.Close();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TheValue = 20;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();
            }
        }
    }
}
