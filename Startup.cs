﻿using Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tappu
{
    public partial class StartupWindow : Form
    {
        public StartupWindow()
        {
            InitializeComponent();
        }

        private void StartupWindow_Load(object sender, EventArgs e)
        {
            
        }

        //Checkbox Selection Stuff
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = true;
            }

             if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }

           if (checkBox3.Checked)
            {
                checkBox3.Checked = false;
            }

            if (checkBox4.Checked)
            {
                checkBox4.Checked = false;
            }

            if (checkBox5.Checked)
            {
                checkBox5.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }

            if (checkBox2.Checked)
            {
                checkBox2.Checked = true;
            }

            if (checkBox3.Checked)
            {
                checkBox3.Checked = false;
            }

            if (checkBox4.Checked)
            {
                checkBox4.Checked = false;
            }

            if (checkBox5.Checked)
            {
                checkBox5.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }

            if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }

            if (checkBox3.Checked)
            {
                checkBox3.Checked = true;
            }

            if (checkBox4.Checked)
            {
                checkBox4.Checked = false;
            }

            if (checkBox5.Checked)
            {
                checkBox5.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }

            if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }

            if (checkBox3.Checked)
            {
                checkBox3.Checked = false;
            }

            if (checkBox4.Checked)
            {
                checkBox4.Checked = true;
            }

            if (checkBox5.Checked)
            {
                checkBox5.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }

            if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }

            if (checkBox3.Checked)
            {
                checkBox3.Checked = false;
            }

            if (checkBox4.Checked)
            {
                checkBox4.Checked = false;
            }

            if (checkBox5.Checked)
            {
                checkBox5.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TappuWindow f2 = new TappuWindow();
            LoadMenu poo = new LoadMenu();
            Random rng = new Random();
            int random = rng.Next(500, 1500);
            Thread.Sleep(random);
            f2.ShowDialog();
            this.Close();
        }
    }
}
