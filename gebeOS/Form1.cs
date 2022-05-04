//-----------------------------------------------------------------------
// <copyright file="Form1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Threading;

namespace gebeOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 1;           
            if (progressBar1.Value == 100)
            {
                MessageBox.Show("he he just testing");
                label1.Visible = false;
                progressBar1.Visible = false;
            }
        }
    }
}