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
            btnLogOut = new System.Windows.Forms.Button();
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
            btnAddPost.Location = new Point(569, 36);
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
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(Pages);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 64);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 608);
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
            Pages.Size = new Size(952, 608);
            Pages.TabIndex = 25;
            // 
            // profile
            // 
            profile.Controls.Add(btnLogOut);
            profile.Controls.Add(pictureBoxUser);
            profile.Controls.Add(flowLayoutPanelProfile);
            profile.Controls.Add(label_name);
            profile.Controls.Add(btnAddPost);
            profile.ImageKey = "user (5).png";
            profile.Location = new Point(4, 29);
            profile.Margin = new Padding(2);
            profile.Name = "profile";
            profile.Padding = new Padding(2);
            profile.Size = new Size(944, 575);
            profile.TabIndex = 0;
            profile.Text = "Profile";
            profile.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(806, 31);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(42, 53);
            btnLogOut.TabIndex = 25;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Location = new Point(24, 12);
            pictureBoxUser.Margin = new Padding(4);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(84, 72);
            pictureBoxUser.TabIndex = 24;
            pictureBoxUser.TabStop = false;
            // 
            // flowLayoutPanelProfile
            // 
            flowLayoutPanelProfile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelProfile.AutoScroll = true;
            flowLayoutPanelProfile.Location = new Point(2, 116);
            flowLayoutPanelProfile.Margin = new Padding(4);
            flowLayoutPanelProfile.Name = "flowLayoutPanelProfile";
            flowLayoutPanelProfile.Size = new Size(937, 454);
            flowLayoutPanelProfile.TabIndex = 23;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_name.ForeColor = Color.Black;
            label_name.Location = new Point(135, 22);
            label_name.Margin = new Padding(2, 0, 2, 0);
            label_name.Name = "label_name";
            label_name.Size = new Size(128, 50);
            label_name.TabIndex = 22;
            label_name.Text = "Label1";
            // 
            // home
            // 
            home.Controls.Add(flowLayoutPanel);
            home.ImageKey = "home_24.png";
            home.Location = new Point(4, 29);
            home.Margin = new Padding(2);
            home.Name = "home";
            home.Padding = new Padding(2);
            home.Size = new Size(944, 575);
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
            flowLayoutPanel.Size = new Size(936, 568);
            flowLayoutPanel.TabIndex = 0;
            // 
            // friends
            // 
            friends.Controls.Add(flowLayoutPanelFriends);
            friends.Controls.Add(bigLabel1);
            friends.ImageKey = "add-friend.png";
            friends.Location = new Point(4, 29);
            friends.Margin = new Padding(2);
            friends.Name = "friends";
            friends.Size = new Size(944, 575);
            friends.TabIndex = 2;
            friends.Text = "New Friends";
            friends.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelFriends
            // 
            flowLayoutPanelFriends.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelFriends.AutoScroll = true;
            flowLayoutPanelFriends.Location = new Point(0, 70);
            flowLayoutPanelFriends.Margin = new Padding(4);
            flowLayoutPanelFriends.Name = "flowLayoutPanelFriends";
            flowLayoutPanelFriends.Size = new Size(942, 502);
            flowLayoutPanelFriends.TabIndex = 2;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(18, 9);
            bigLabel1.Margin = new Padding(2, 0, 2, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(347, 57);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "Find New Friends";
            // 
            // myfriendspage
            // 
            myfriendspage.Controls.Add(bigLabel2);
            myfriendspage.Controls.Add(PanelMyFriends);
            myfriendspage.ImageKey = "amigos.png";
            myfriendspage.Location = new Point(4, 29);
            myfriendspage.Margin = new Padding(2);
            myfriendspage.Name = "myfriendspage";
            myfriendspage.Size = new Size(944, 575);
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
            bigLabel2.Location = new Point(32, 10);
            bigLabel2.Margin = new Padding(2, 0, 2, 0);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(230, 57);
            bigLabel2.TabIndex = 1;
            bigLabel2.Text = "My Friends";
            // 
            // PanelMyFriends
            // 
            PanelMyFriends.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelMyFriends.AutoScroll = true;
            PanelMyFriends.Location = new Point(2, 81);
            PanelMyFriends.Margin = new Padding(2);
            PanelMyFriends.Name = "PanelMyFriends";
            PanelMyFriends.Size = new Size(939, 491);
            PanelMyFriends.TabIndex = 0;
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
            Padding = new Padding(2, 64, 2, 2);
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
        private System.Windows.Forms.Button btnLogOut;
    }
}