using DiscordRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tappu
{
    public partial class Song_Selector : Form
    {
        public Song_Selector()
        {
            InitializeComponent();
        }

        public DiscordRpcClient client;

        private void Song_Selector_Load(object sender, EventArgs e)
        {
            client = new DiscordRpcClient("815220394201841685");
            client.SetPresence(new RichPresence()
            {
                Details = "",
                State = "Selecting Song",
                Assets = new Assets()
                {
                    LargeImageKey = "tappuicon",
                    LargeImageText = "",
                    SmallImageKey = ""
                }
            });

            client.Initialize();
        }
    }
}
