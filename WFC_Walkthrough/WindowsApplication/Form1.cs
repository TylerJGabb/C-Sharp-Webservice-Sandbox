﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///Create a new 
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();


            ServiceReference1.CompositeType ct = new ServiceReference1.CompositeType();
            ct.StringValue = "hello";
            ct.BoolValue = true;

            client.MutateCompositeType(ref ct);
            label1.Text = ct.StringValue;

            string returnString;
            returnString = client.GetData(textBox1.Text);
            label1.Text += returnString;


        }
    }
}
