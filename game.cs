using System;
using System.IO;
using System.Windows.Forms;
using DiscordRPC;

namespace Tappu
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }

        public DiscordRpcClient client;



        private void game_Load(object sender, EventArgs e)
        {

            //Strings and other stuff
            string settingslocation = Application.StartupPath + "settings/";
            string playingsong = "";
            //Discord Rich Presence
            client = new DiscordRpcClient("815220394201841685");
            client.SetPresence(new RichPresence()
            {
                Details = "",
                State = "Playing" + playingsong,
                Assets = new Assets()
                {
                    LargeImageKey = "tappuicon",
                    LargeImageText = "",
                    SmallImageKey = ""
                }
            });

            client.Initialize();
            //Initialize Screen Mode
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
        
         private void textBox1_KeyDown(object sender, KeyEventArgs e)
         {
            if (e.KeyCode == Keys.S)
            {
                while (e.KeyCode == Keys.S)
                {

                }
            }

            if (e.KeyCode == Keys.D)
            {
                while (e.KeyCode == Keys.D)
                {

                }
            }
        }

        //Key Handler/Game Key Handler


    }
}
