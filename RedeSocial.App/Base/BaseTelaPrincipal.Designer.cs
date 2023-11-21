using ReaLTaiizor.Controls;
using RedeSocial.App.Login;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RedeSocial.App
{
    partial class BaseTelaPrincipal
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseTelaPrincipal));
            panel1 = new System.Windows.Forms.Panel();
            materialTabControl1 = new MaterialTabControl();
            profile = new System.Windows.Forms.TabPage();
            btnAddPost = new MaterialButton();
            home = new System.Windows.Forms.TabPage();
            imageList1 = new ImageList(components);
            tabPage1 = new System.Windows.Forms.TabPage();
            panel1.SuspendLayout();
            materialTabControl1.SuspendLayout();
            profile.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(materialTabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 64);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 607);
            panel1.TabIndex = 0;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(profile);
            materialTabControl1.Controls.Add(home);
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(0, 0);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(950, 607);
            materialTabControl1.SizeMode = TabSizeMode.FillToRight;
            materialTabControl1.TabIndex = 0;
            // 
            // profile
            // 
            profile.AllowDrop = true;
            profile.Controls.Add(btnAddPost);
            profile.Location = new Point(4, 29);
            profile.Name = "profile";
            profile.Padding = new Padding(3);
            profile.Size = new Size(942, 574);
            profile.TabIndex = 0;
            profile.Text = "Profile";
            profile.UseVisualStyleBackColor = true;
            // 
            // btnAddPost
            // 
            btnAddPost.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddPost.AutoSize = false;
            btnAddPost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddPost.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            btnAddPost.Cursor = Cursors.Hand;
            btnAddPost.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddPost.Depth = 0;
            btnAddPost.HighEmphasis = true;
            btnAddPost.Icon = null;
            btnAddPost.IconType = MaterialButton.MaterialIconType.Rebase;
            btnAddPost.Location = new Point(673, 45);
            btnAddPost.Margin = new Padding(5, 8, 5, 8);
            btnAddPost.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddPost.Name = "btnAddPost";
            btnAddPost.NoAccentTextColor = Color.Empty;
            btnAddPost.Size = new Size(181, 48);
            btnAddPost.TabIndex = 20;
            btnAddPost.Text = "New Post";
            btnAddPost.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddPost.UseAccentColor = true;
            btnAddPost.UseVisualStyleBackColor = true;
            btnAddPost.Click += btnAddPost_Click_1;
            // 
            // home
            // 
            home.AllowDrop = true;
            home.ImeMode = ImeMode.Off;
            home.Location = new Point(4, 29);
            home.Name = "home";
            home.Padding = new Padding(3);
            home.Size = new Size(942, 574);
            home.TabIndex = 1;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home.png");
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(942, 574);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BaseTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(956, 674);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "BaseTelaPrincipal";
            Text = "Rede Social";
            TransparencyKey = Color.White;
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            materialTabControl1.ResumeLayout(false);
            profile.ResumeLayout(false);
            ResumeLayout(false);
        }

        private HopeTextBox email;
        private HopeTextBox password;
        private System.Windows.Forms.Panel panel1;
        private ImageList imageList1;
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage profile;
        private System.Windows.Forms.TabPage home;
        private MaterialButton btnAddPost;
        private System.Windows.Forms.TabPage tabPage1;
    }
}