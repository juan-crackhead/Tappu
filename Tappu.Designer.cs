
namespace Game
{
    partial class TappuWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openAnimation = new System.Windows.Forms.Timer(this.components);
            this.UIButtons = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // openAnimation
            // 
            this.openAnimation.Interval = 16;
            // 
            // UIButtons
            // 
            this.UIButtons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UIButtons.BackColor = System.Drawing.Color.Black;
            this.UIButtons.Location = new System.Drawing.Point(332, 12);
            this.UIButtons.Name = "UIButtons";
            this.UIButtons.Size = new System.Drawing.Size(596, 633);
            this.UIButtons.TabIndex = 0;
            // 
            // TappuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.UIButtons);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "TappuWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tappu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer openAnimation;
        private System.Windows.Forms.Panel UIButtons;
    }
}