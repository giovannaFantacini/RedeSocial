using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Metadata;
using System.Resources;
using System.Windows.Forms;

namespace RedeSocial.App.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            parrotFormEllipse1 = new ReaLTaiizor.Controls.ParrotFormEllipse();
            parrotFormHandle1 = new ReaLTaiizor.Controls.ParrotFormHandle();
            parrotFormHandle2 = new ReaLTaiizor.Controls.ParrotFormHandle();
            panel2 = new Panel();
            btnsignUp = new ReaLTaiizor.Controls.MaterialButton();
            btnsignIn = new ReaLTaiizor.Controls.MaterialButton();
            dungeonLinkLabel1 = new ReaLTaiizor.Controls.DungeonLinkLabel();
            password = new ReaLTaiizor.Controls.HopeTextBox();
            email = new ReaLTaiizor.Controls.HopeTextBox();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(350, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 775);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.Cursor = Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = false;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(604, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 6;
            // 
            // parrotFormEllipse1
            // 
            parrotFormEllipse1.CornerRadius = 10;
            parrotFormEllipse1.EffectedForm = this;
            // 
            // parrotFormHandle1
            // 
            parrotFormHandle1.DockAtTop = true;
            parrotFormHandle1.HandleControl = panel1;
            // 
            // parrotFormHandle2
            // 
            parrotFormHandle2.DockAtTop = true;
            parrotFormHandle2.HandleControl = panel2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 12, 45);
            panel2.Controls.Add(btnsignUp);
            panel2.Controls.Add(btnsignIn);
            panel2.Controls.Add(dungeonLinkLabel1);
            panel2.Controls.Add(password);
            panel2.Controls.Add(email);
            panel2.Controls.Add(hopePictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 775);
            panel2.TabIndex = 1;
            // 
            // btnsignUp
            // 
            btnsignUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnsignUp.AutoSize = false;
            btnsignUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnsignUp.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnsignUp.Cursor = Cursors.Hand;
            btnsignUp.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnsignUp.Depth = 0;
            btnsignUp.HighEmphasis = true;
            btnsignUp.Icon = null;
            btnsignUp.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnsignUp.Location = new Point(32, 686);
            btnsignUp.Margin = new Padding(5, 8, 5, 8);
            btnsignUp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnsignUp.Name = "btnsignUp";
            btnsignUp.NoAccentTextColor = Color.Empty;
            btnsignUp.Size = new Size(279, 45);
            btnsignUp.TabIndex = 21;
            btnsignUp.Text = "Sign Up";
            btnsignUp.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnsignUp.UseAccentColor = false;
            btnsignUp.UseVisualStyleBackColor = true;
            btnsignUp.Click += btnsignUp_Click;
            // 
            // btnsignIn
            // 
            btnsignIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnsignIn.AutoSize = false;
            btnsignIn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnsignIn.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnsignIn.Cursor = Cursors.Hand;
            btnsignIn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnsignIn.Depth = 0;
            btnsignIn.HighEmphasis = true;
            btnsignIn.Icon = null;
            btnsignIn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnsignIn.Location = new Point(32, 553);
            btnsignIn.Margin = new Padding(5, 8, 5, 8);
            btnsignIn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnsignIn.Name = "btnsignIn";
            btnsignIn.NoAccentTextColor = Color.Empty;
            btnsignIn.Size = new Size(279, 45);
            btnsignIn.TabIndex = 20;
            btnsignIn.Text = "Sign In";
            btnsignIn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnsignIn.UseAccentColor = true;
            btnsignIn.UseVisualStyleBackColor = true;
            btnsignIn.Click += btnsignIn_Click;
            // 
            // dungeonLinkLabel1
            // 
            dungeonLinkLabel1.ActiveLinkColor = Color.FromArgb(221, 72, 20);
            dungeonLinkLabel1.Anchor = AnchorStyles.Right;
            dungeonLinkLabel1.AutoSize = true;
            dungeonLinkLabel1.BackColor = Color.Transparent;
            dungeonLinkLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonLinkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            dungeonLinkLabel1.LinkColor = Color.Silver;
            dungeonLinkLabel1.Location = new Point(196, 432);
            dungeonLinkLabel1.Margin = new Padding(4, 0, 4, 0);
            dungeonLinkLabel1.Name = "dungeonLinkLabel1";
            dungeonLinkLabel1.Size = new Size(151, 25);
            dungeonLinkLabel1.TabIndex = 18;
            dungeonLinkLabel1.TabStop = true;
            dungeonLinkLabel1.Text = "Forgot Password";
            dungeonLinkLabel1.VisitedLinkColor = Color.FromArgb(240, 119, 70);
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password.BackColor = Color.FromArgb(4, 12, 45);
            password.BaseColor = Color.Transparent;
            password.BorderColorA = Color.DodgerBlue;
            password.BorderColorB = Color.DarkGray;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Gainsboro;
            password.Hint = "Password";
            password.Location = new Point(12, 360);
            password.Margin = new Padding(4);
            password.MaxLength = 128;
            password.Multiline = false;
            password.Name = "password";
            password.PasswordChar = '*';
            password.ScrollBars = ScrollBars.None;
            password.SelectedText = "";
            password.SelectionLength = 0;
            password.SelectionStart = 0;
            password.Size = new Size(325, 43);
            password.TabIndex = 8;
            password.TabStop = false;
            password.UseSystemPasswordChar = false;
            // 
            // email
            // 
            email.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            email.BackColor = Color.FromArgb(4, 12, 45);
            email.BaseColor = Color.Transparent;
            email.BorderColorA = Color.DodgerBlue;
            email.BorderColorB = Color.DarkGray;
            email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.ForeColor = Color.Gainsboro;
            email.Hint = "Email";
            email.Location = new Point(12, 293);
            email.Margin = new Padding(4);
            email.MaxLength = 128;
            email.Multiline = false;
            email.Name = "email";
            email.PasswordChar = '\0';
            email.ScrollBars = ScrollBars.None;
            email.SelectedText = "";
            email.SelectionLength = 0;
            email.SelectionStart = 0;
            email.Size = new Size(325, 43);
            email.TabIndex = 7;
            email.TabStop = false;
            email.UseSystemPasswordChar = false;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.Anchor = AnchorStyles.Top;
            hopePictureBox1.BackColor = Color.Transparent;
            hopePictureBox1.Enabled = false;
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.Location = new Point(112, 52);
            hopePictureBox1.Margin = new Padding(4);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(120, 120);
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 0;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1093, 775);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "Login";
            Text = "Here You Can Login";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.ParrotFormEllipse parrotFormEllipse1;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle1;
        private Panel panel2;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.HopeTextBox email;
        private ReaLTaiizor.Controls.HopeTextBox password;
        private ReaLTaiizor.Controls.DungeonLinkLabel dungeonLinkLabel1;
        private ReaLTaiizor.Controls.MaterialButton btnsignUp;
        private ReaLTaiizor.Controls.MaterialButton btnsignIn;
    }
}