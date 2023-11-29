namespace RedeSocial.App
{
    partial class Cadastro
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            parrotFormEllipse1 = new ReaLTaiizor.Controls.ParrotFormEllipse();
            parrotFormHandle1 = new ReaLTaiizor.Controls.ParrotFormHandle();
            panel1 = new Panel();
            parrotFormHandle2 = new ReaLTaiizor.Controls.ParrotFormHandle();
            panel2 = new Panel();
            btnCancel = new ReaLTaiizor.Controls.MaterialButton();
            pictureBox = new PictureBox();
            btnProfilePicture = new ReaLTaiizor.Controls.MaterialButton();
            lastName = new ReaLTaiizor.Controls.HopeTextBox();
            userName = new ReaLTaiizor.Controls.HopeTextBox();
            email = new ReaLTaiizor.Controls.HopeTextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            password = new ReaLTaiizor.Controls.HopeTextBox();
            firstName = new ReaLTaiizor.Controls.HopeTextBox();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(770, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 539);
            panel1.TabIndex = 0;
            // 
            // parrotFormHandle2
            // 
            parrotFormHandle2.DockAtTop = true;
            parrotFormHandle2.HandleControl = panel2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 12, 45);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(pictureBox);
            panel2.Controls.Add(btnProfilePicture);
            panel2.Controls.Add(lastName);
            panel2.Controls.Add(userName);
            panel2.Controls.Add(email);
            panel2.Controls.Add(bigLabel1);
            panel2.Controls.Add(nightControlBox1);
            panel2.Controls.Add(btnSalvar);
            panel2.Controls.Add(password);
            panel2.Controls.Add(firstName);
            panel2.Controls.Add(hopePictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 539);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.AutoSize = false;
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancel.Location = new Point(406, 476);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(151, 36);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(83, 363);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(107, 95);
            pictureBox.TabIndex = 27;
            pictureBox.TabStop = false;
            // 
            // btnProfilePicture
            // 
            btnProfilePicture.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProfilePicture.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProfilePicture.Depth = 0;
            btnProfilePicture.HighEmphasis = true;
            btnProfilePicture.Icon = null;
            btnProfilePicture.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnProfilePicture.Location = new Point(45, 476);
            btnProfilePicture.Margin = new Padding(4, 6, 4, 6);
            btnProfilePicture.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnProfilePicture.Name = "btnProfilePicture";
            btnProfilePicture.NoAccentTextColor = Color.Empty;
            btnProfilePicture.Size = new Size(182, 36);
            btnProfilePicture.TabIndex = 26;
            btnProfilePicture.Text = "Upload Your Picture";
            btnProfilePicture.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProfilePicture.UseAccentColor = true;
            btnProfilePicture.UseVisualStyleBackColor = true;
            btnProfilePicture.Click += btnProfilePicture_Click;
            // 
            // lastName
            // 
            lastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lastName.BackColor = Color.FromArgb(4, 12, 45);
            lastName.BaseColor = Color.Transparent;
            lastName.BorderColorA = Color.DodgerBlue;
            lastName.BorderColorB = Color.DarkGray;
            lastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastName.ForeColor = Color.White;
            lastName.Hint = "Last Name";
            lastName.Location = new Point(375, 159);
            lastName.MaxLength = 128;
            lastName.Multiline = false;
            lastName.Name = "lastName";
            lastName.PasswordChar = '\0';
            lastName.ScrollBars = ScrollBars.None;
            lastName.SelectedText = "";
            lastName.SelectionLength = 0;
            lastName.SelectionStart = 0;
            lastName.Size = new Size(341, 38);
            lastName.TabIndex = 25;
            lastName.TabStop = false;
            lastName.UseSystemPasswordChar = false;
            // 
            // userName
            // 
            userName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            userName.BackColor = Color.FromArgb(4, 12, 45);
            userName.BaseColor = Color.Transparent;
            userName.BorderColorA = Color.DodgerBlue;
            userName.BorderColorB = Color.DarkGray;
            userName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userName.ForeColor = Color.Gainsboro;
            userName.Hint = "User Name";
            userName.Location = new Point(34, 306);
            userName.MaxLength = 128;
            userName.Multiline = false;
            userName.Name = "userName";
            userName.PasswordChar = '\0';
            userName.ScrollBars = ScrollBars.None;
            userName.SelectedText = "";
            userName.SelectionLength = 0;
            userName.SelectionStart = 0;
            userName.Size = new Size(426, 38);
            userName.TabIndex = 24;
            userName.TabStop = false;
            userName.UseSystemPasswordChar = false;
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
            email.Location = new Point(34, 233);
            email.MaxLength = 128;
            email.Multiline = false;
            email.Name = "email";
            email.PasswordChar = '\0';
            email.ScrollBars = ScrollBars.None;
            email.SelectedText = "";
            email.SelectionLength = 0;
            email.SelectionStart = 0;
            email.Size = new Size(682, 38);
            email.TabIndex = 23;
            email.TabStop = false;
            email.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(332, 50);
            bigLabel1.Margin = new Padding(2, 0, 2, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(146, 46);
            bigLabel1.TabIndex = 22;
            bigLabel1.Text = "Sign Up";
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
            nightControlBox1.Location = new Point(631, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.AutoSize = false;
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(565, 476);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(151, 36);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Sign Up";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = true;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
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
            password.Location = new Point(487, 306);
            password.MaxLength = 128;
            password.Multiline = false;
            password.Name = "password";
            password.PasswordChar = '*';
            password.ScrollBars = ScrollBars.None;
            password.SelectedText = "";
            password.SelectionLength = 0;
            password.SelectionStart = 0;
            password.Size = new Size(229, 38);
            password.TabIndex = 8;
            password.TabStop = false;
            password.UseSystemPasswordChar = false;
            // 
            // firstName
            // 
            firstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            firstName.BackColor = Color.FromArgb(4, 12, 45);
            firstName.BaseColor = Color.Transparent;
            firstName.BorderColorA = Color.DodgerBlue;
            firstName.BorderColorB = Color.DarkGray;
            firstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstName.ForeColor = Color.White;
            firstName.Hint = "First Name";
            firstName.Location = new Point(34, 159);
            firstName.MaxLength = 128;
            firstName.Multiline = false;
            firstName.Name = "firstName";
            firstName.PasswordChar = '\0';
            firstName.ScrollBars = ScrollBars.None;
            firstName.SelectedText = "";
            firstName.SelectionLength = 0;
            firstName.SelectionStart = 0;
            firstName.Size = new Size(315, 38);
            firstName.TabIndex = 7;
            firstName.TabStop = false;
            firstName.UseSystemPasswordChar = false;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.Anchor = AnchorStyles.Top;
            hopePictureBox1.BackColor = Color.Transparent;
            hopePictureBox1.Enabled = false;
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.Location = new Point(218, 23);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(79, 72);
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 0;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(773, 539);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cadastro";
            Text = "Here You Can Login";
            TransparencyKey = Color.Fuchsia;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.ParrotFormEllipse parrotFormEllipse1;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle1;
        private Panel panel2;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle2;
        private ReaLTaiizor.Controls.HopeTextBox firstName;
        private ReaLTaiizor.Controls.HopeTextBox password;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.HopeTextBox userName;
        private ReaLTaiizor.Controls.HopeTextBox email;
        private ReaLTaiizor.Controls.HopeTextBox lastName;
        private ReaLTaiizor.Controls.MaterialButton btnProfilePicture;
        private PictureBox pictureBox;
        private ReaLTaiizor.Controls.MaterialButton btnCancel;
    }
}