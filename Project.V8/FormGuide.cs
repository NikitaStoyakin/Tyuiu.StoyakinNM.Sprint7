﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V8
{
    public partial class FormGuide : Form
    {
        public FormGuide()
        {
            InitializeComponent();
        }
        private void buttonClose_SNM_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
