//Using References
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using DiscordRPC;
using Tappu;

namespace Game
{
    public partial class TappuWindow : Form
    {
        public TappuWindow()
        {
            InitializeComponent();
        }

        public DiscordRpcClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Strings and other stuff
            string tappudatalocation = Application.StartupPath;
            string settingslocation = Application.StartupPath + "settings/";
            //Discord Rich Presence
            client = new DiscordRpcClient("815220394201841685");
            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                Details = "",
                State = "In Menu",
                Assets = new Assets()
                {
                    LargeImageKey = "tappuicon",
                    LargeImageText = "",
                    SmallImageKey = ""
                }
            });

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
            //See what skin is selected in settings
            string SelectedSkin = File.ReadAllText(settingslocation + "selectedskin" + ".txt");
            //Set background photo
            Random rng = new Random();
            int fileCount = Directory.GetFiles(tappudatalocation + "tappuskins/" + SelectedSkin + "/textures/mainmenu/backgrounds/", "*.*", SearchOption.AllDirectories).Length; // Will Retrieve count of all files in directry and sub directries
            int random = rng.Next(1, fileCount);
            BackgroundImage = Image.FromFile(tappudatalocation + "tappuskins/" + SelectedSkin + "/textures/mainmenu/backgrounds/" + random + ".jpg");
            //FPS Cap Initialization
            try
            {
                if (!File.Exists(settingslocation + "fpscap" + ".txt"))
                {
                    System.IO.File.Move(settingslocation + "fpscap.tappusetting", settingslocation + "fpscap.txt");
                }
            }
            catch
            {
                MessageBox.Show("Settings are broken, Re-Install Tappu");
            }

            string fpscap = File.ReadAllText(settingslocation + "fpscap" + ".txt");

            if (fpscap.Equals("60"))
            {
                openAnimation.Interval = 16;
            }
            else
            {
                if (fpscap.Equals("120"))
                {
                    openAnimation.Interval = 8;
                }
                else
                {
                    if (fpscap.Equals("144"))
                    {
                        openAnimation.Interval = 6;
                    }
                    else
                    {
                        if (fpscap.Equals("240"))
                        {
                            openAnimation.Interval = 4;
                        }
                        else
                        {
                            
                        }
                    }
                }
            }
            //UI
            pictureBox1.Image = Image.FromFile(tappudatalocation + "tappuskins/" + SelectedSkin + "/textures/tappuicon.png");

            //Play Startup Sound
            SoundPlayer simpleSound = new SoundPlayer(tappudatalocation + "tappuskins/" + SelectedSkin + "/sounds/startupsound.wav");
            simpleSound.Play();
            //Menu Music Starting
            SoundPlayer MenuMusic = new SoundPlayer(tappudatalocation + "tappuskins/" + SelectedSkin + "/sounds/menumusic.wav");
            MenuMusic.Play();
            //Open Background Loading Thing
            string poopy = File.ReadAllText(settingslocation + "screenmode" + ".txt");

            if (poopy.Equals("Maximized"))
            {
                LoadMenu asfkdj = new LoadMenu();
                asfkdj.Show();
            }
        }

        //<  Button Events >

        //Exit Button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Settings Button
        private void button2_Click(object sender, EventArgs e)
        {
            SettingsWindow f2 = new SettingsWindow();
            f2.ShowDialog();
        }

        //Play Button
        private void button1_Click(object sender, EventArgs e)
        {
            Song_Selector f2 = new Song_Selector();
            f2.ShowDialog();
        }
    }
}