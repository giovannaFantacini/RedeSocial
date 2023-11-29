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
            imageList1 = new ImageList(components);
            btnAddPost = new MaterialButton();
            panel1 = new System.Windows.Forms.Panel();
            Pages = new TabControl();
            profile = new System.Windows.Forms.TabPage();
            pictureBoxUser = new PictureBox();
            flowLayoutPanelProfile = new FlowLayoutPanel();
            label_name = new CrownLabel();
            home = new System.Windows.Forms.TabPage();
            flowLayoutPanel = new FlowLayoutPanel();
            friends = new System.Windows.Forms.TabPage();
            flowLayoutPanelFriends = new FlowLayoutPanel();
            bigLabel1 = new BigLabel();
            myfriendspage = new System.Windows.Forms.TabPage();
            bigLabel2 = new BigLabel();
            PanelMyFriends = new FlowLayoutPanel();
            panel1.SuspendLayout();
            Pages.SuspendLayout();
            profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            home.SuspendLayout();
            friends.SuspendLayout();
            myfriendspage.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home.png");
            imageList1.Images.SetKeyName(1, "home_24.png");
            imageList1.Images.SetKeyName(2, "user (5).png");
            imageList1.Images.SetKeyName(3, "amigos.png");
            imageList1.Images.SetKeyName(4, "add-friend.png");
            // 
            // btnAddPost
            // 
            btnAddPost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPost.AutoSize = false;
            btnAddPost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddPost.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            btnAddPost.Cursor = Cursors.Hand;
            btnAddPost.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddPost.Depth = 0;
            btnAddPost.HighEmphasis = true;
            btnAddPost.Icon = null;
            btnAddPost.IconType = MaterialButton.MaterialIconType.Rebase;
            btnAddPost.Location = new Point(595, 18);
            btnAddPost.Margin = new Padding(4, 6, 4, 6);
            btnAddPost.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddPost.Name = "btnAddPost";
            btnAddPost.NoAccentTextColor = Color.Empty;
            btnAddPost.Size = new Size(145, 38);
            btnAddPost.TabIndex = 20;
            btnAddPost.Text = "New Post";
            btnAddPost.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddPost.UseAccentColor = true;
            btnAddPost.UseVisualStyleBackColor = true;
            btnAddPost.Click += btnAddPost_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(Pages);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 486);
            panel1.TabIndex = 0;
            // 
            // Pages
            // 
            Pages.Controls.Add(profile);
            Pages.Controls.Add(home);
            Pages.Controls.Add(friends);
            Pages.Controls.Add(myfriendspage);
            Pages.Dock = DockStyle.Fill;
            Pages.ImageList = imageList1;
            Pages.Location = new Point(0, 0);
            Pages.Margin = new Padding(2);
            Pages.Name = "Pages";
            Pages.SelectedIndex = 0;
            Pages.Size = new Size(761, 486);
            Pages.TabIndex = 25;
            // 
            // profile
            // 
            profile.Controls.Add(pictureBoxUser);
            profile.Controls.Add(flowLayoutPanelProfile);
            profile.Controls.Add(label_name);
            profile.Controls.Add(btnAddPost);
            profile.ImageKey = "user (5).png";
            profile.Location = new Point(4, 24);
            profile.Margin = new Padding(2);
            profile.Name = "profile";
            profile.Padding = new Padding(2);
            profile.Size = new Size(753, 458);
            profile.TabIndex = 0;
            profile.Text = "Profile";
            profile.UseVisualStyleBackColor = true;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Location = new Point(19, 10);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(67, 58);
            pictureBoxUser.TabIndex = 24;
            pictureBoxUser.TabStop = false;
            // 
            // flowLayoutPanelProfile
            // 
            flowLayoutPanelProfile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelProfile.AutoScroll = true;
            flowLayoutPanelProfile.Location = new Point(2, 93);
            flowLayoutPanelProfile.Name = "flowLayoutPanelProfile";
            flowLayoutPanelProfile.Size = new Size(749, 363);
            flowLayoutPanelProfile.TabIndex = 23;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_name.ForeColor = Color.Black;
            label_name.Location = new Point(108, 18);
            label_name.Margin = new Padding(2, 0, 2, 0);
            label_name.Name = "label_name";
            label_name.Size = new Size(104, 41);
            label_name.TabIndex = 22;
            label_name.Text = "Label1";
            // 
            // home
            // 
            home.Controls.Add(flowLayoutPanel);
            home.ImageKey = "home_24.png";
            home.Location = new Point(4, 24);
            home.Margin = new Padding(2);
            home.Name = "home";
            home.Padding = new Padding(2);
            home.Size = new Size(753, 458);
            home.TabIndex = 1;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(2, 2);
            flowLayoutPanel.Margin = new Padding(2);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(749, 454);
            flowLayoutPanel.TabIndex = 0;
            // 
            // friends
            // 
            friends.Controls.Add(flowLayoutPanelFriends);
            friends.Controls.Add(bigLabel1);
            friends.ImageKey = "add-friend.png";
            friends.Location = new Point(4, 24);
            friends.Margin = new Padding(2);
            friends.Name = "friends";
            friends.Size = new Size(753, 458);
            friends.TabIndex = 2;
            friends.Text = "New Friends";
            friends.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelFriends
            // 
            flowLayoutPanelFriends.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelFriends.AutoScroll = true;
            flowLayoutPanelFriends.Location = new Point(0, 56);
            flowLayoutPanelFriends.Name = "flowLayoutPanelFriends";
            flowLayoutPanelFriends.Size = new Size(753, 402);
            flowLayoutPanelFriends.TabIndex = 2;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(14, 7);
            bigLabel1.Margin = new Padding(2, 0, 2, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(278, 46);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "Find New Friends";
            // 
            // myfriendspage
            // 
            myfriendspage.Controls.Add(bigLabel2);
            myfriendspage.Controls.Add(PanelMyFriends);
            myfriendspage.ImageKey = "amigos.png";
            myfriendspage.Location = new Point(4, 24);
            myfriendspage.Margin = new Padding(2);
            myfriendspage.Name = "myfriendspage";
            myfriendspage.Size = new Size(753, 458);
            myfriendspage.TabIndex = 3;
            myfriendspage.Text = "My Friends";
            myfriendspage.UseVisualStyleBackColor = true;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel2.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel2.Location = new Point(26, 8);
            bigLabel2.Margin = new Padding(2, 0, 2, 0);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(184, 46);
            bigLabel2.TabIndex = 1;
            bigLabel2.Text = "My Friends";
            // 
            // PanelMyFriends
            // 
            PanelMyFriends.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelMyFriends.AutoScroll = true;
            PanelMyFriends.Location = new Point(2, 65);
            PanelMyFriends.Margin = new Padding(2);
            PanelMyFriends.Name = "PanelMyFriends";
            PanelMyFriends.Size = new Size(750, 393);
            PanelMyFriends.TabIndex = 0;
            // 
            // BaseTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(765, 539);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "BaseTelaPrincipal";
            Padding = new Padding(2, 51, 2, 2);
            Text = "Rede Social";
            TransparencyKey = Color.White;
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            Pages.ResumeLayout(false);
            profile.ResumeLayout(false);
            profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            home.ResumeLayout(false);
            friends.ResumeLayout(false);
            friends.PerformLayout();
            myfriendspage.ResumeLayout(false);
            myfriendspage.PerformLayout();
            ResumeLayout(false);
        }

        private HopeTextBox email;
        private HopeTextBox password;
        private ImageList imageList1;
        private MaterialButton btnAddPost;
        private System.Windows.Forms.Panel panel1;
        private TabControl Pages;
        private System.Windows.Forms.TabPage profile;
        private CrownLabel label_name;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage friends;
        private BigLabel bigLabel1;
        private FlowLayoutPanel flowLayoutPanel;
        private FlowLayoutPanel flowLayoutPanelProfile;
        private FlowLayoutPanel flowLayoutPanelFriends;
        private System.Windows.Forms.TabPage myfriendspage;
        private FlowLayoutPanel PanelMyFriends;
        private BigLabel bigLabel2;
        private PictureBox pictureBoxUser;
    }
}