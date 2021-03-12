using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using Newtonsoft.Json;
using Tappu;

namespace Tappu
{
    public partial class LoadMenu : Form
    {
        public LoadMenu()
        {
            InitializeComponent();
        }

        public DiscordRpcClient client;

        private void LoadMenu_Load(object sender, EventArgs e)
        {
            //Strings and other stuff
            string settingslocation = Application.StartupPath + "settings/";
            //Initialize the Screen Mode
            BackgroundImageLayout = ImageLayout.Zoom;
            try
            {
                if (!File.Exists(settingslocation + "screenmode" + ".txt"))
                {
                    System.IO.File.Move(settingslocation + "screenmode.tappusetting", settingslocation + "screenmode.txt");
                }
            }
            catch
            {
                MessageBox.Show("Settings are Broken, Re-install Tappu");
            }

            string text = File.ReadAllText(settingslocation + "screenmode" + ".txt");

            if (text.Equals("Maximized"))
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.FixedSingle;
            }

        }
    }
}
