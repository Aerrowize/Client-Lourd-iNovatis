﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Lourd_Inovatis
{
    public partial class Promotion : Form
    {
        public Promotion()
        {
            InitializeComponent();
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Show();
            this.Hide();
        }
    }
}
