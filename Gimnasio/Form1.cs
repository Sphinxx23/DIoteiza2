﻿using Gimnasio.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bInicioSesion_Click(object sender, EventArgs e)
        {
            Views.Login login = new Views.Login();
            login.ShowDialog();
            
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            Views.Register register= new Views.Register();
            register.ShowDialog();
            
        }

		
	}
}