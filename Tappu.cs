using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class TappuWindow : Form
    {
        public TappuWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Strings and other stuff
            string settingslocation = @"C:\Tappu\tappudata\settings\";



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



            //Initialize Skin
            try
            {
                if (!File.Exists(settingslocation + "selectedskin" + ".txt"))
                {
                    File.Move(settingslocation + "selectedskin.tappusetting", settingslocation + "selectedskin.txt");
                }
            }
            catch
            {
                MessageBox.Show("Settings are Broken, Re-install Tappu");
            }
            //see what skin is selected in settings
            string SelectedSkin = File.ReadAllText(settingslocation + "selectedskin" + ".txt");
            //Set background photo
            BackgroundImage = Image.FromFile(@"C:/Tappu/tappuskins/" + SelectedSkin + "/textures/mainmenu/menuback.jpg");


            //End of settings loading

            //Plays startup sound in skin folder
            SoundPlayer simpleSound = new SoundPlayer("C:/Tappu/tappuskins/" + SelectedSkin + "/sounds/startupsound.wav");
            simpleSound.Play();
        }
    }
}
