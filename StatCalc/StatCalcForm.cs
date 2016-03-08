﻿using Epi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace StatCalc
{
    public partial class StatCalcForm : Form
    {
        private ElementHost host;
        public StatCalcForm()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Configuration.GetNewInstance().Settings.Language);
            InitializeComponent();
            //this.MaximumSize = new System.Drawing.Size(680, 500);
            //this.MinimumSize = new System.Drawing.Size(680, 500);
            //this.Width++;
            //this.Width--;
            //this.Height++;
            //this.Height--;
            if (this.Width == 526 && Height == 409)
            {
                this.Size = new Size(550,405);
            }

            //this.MaximumSize = new System.Drawing.Size(680, 500);
            //this.MinimumSize = new System.Drawing.Size(680, 500);
            host = new ElementHost();
            host.Dock = DockStyle.Fill;
            host.AutoSize = true;
            host.Width = this.Width;
            host.Height = this.Height;
            StatCalcMenu form = new StatCalcMenu();
            host.Child = form;
            this.Controls.Add(host);
        }

       

       

      

        

       

        
        
        
        

        
    }
}
