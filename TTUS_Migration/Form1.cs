﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TTUS_Migration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ASG.TTUS_API.ShutDown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ASG.TTUS_API.CreateExchangeTrader();
            ASG.TTUS_API.AttachExchangeTrader();
        }
    }
}