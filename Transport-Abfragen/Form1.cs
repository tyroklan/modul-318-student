﻿using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport_Abfragen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonhello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sali");

            Transport transport = new Transport();

            MessageBox.Show(transport.ToString());
        }
    }
}
