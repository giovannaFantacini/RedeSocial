namespace RedeSocial.App
{
    partial class InputDialogPost
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
            postText = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnPost = new ReaLTaiizor.Controls.MaterialButton();
            btnCancel = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // postText
            // 
            postText.AnimateReadOnly = false;
            postText.AutoCompleteMode = AutoCompleteMode.None;
            postText.AutoCompleteSource = AutoCompleteSource.None;
            postText.BackgroundImageLayout = ImageLayout.None;
            postText.CharacterCasing = CharacterCasing.Normal;
            postText.Depth = 0;
            postText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            postText.HideSelection = true;
            postText.Hint = "What's happening?";
            postText.LeadingIcon = null;
            postText.Location = new Point(19, 77);
            postText.Margin = new Padding(3, 2, 3, 2);
            postText.MaxLength = 32767;
            postText.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            postText.Name = "postText";
            postText.PasswordChar = '\0';
            postText.PrefixSuffixText = null;
            postText.ReadOnly = false;
            postText.RightToLeft = RightToLeft.No;
            postText.SelectedText = "";
            postText.SelectionLength = 0;
            postText.SelectionStart = 0;
            postText.ShortcutsEnabled = true;
            postText.Size = new Size(315, 48);
            postText.TabIndex = 0;
            postText.TabStop = false;
            postText.TextAlign = HorizontalAlignment.Left;
            postText.TrailingIcon = null;
            postText.UseSystemPasswordChar = false;
            // 
            // btnPost
            // 
            btnPost.AutoSize = false;
            btnPost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPost.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btnPost.Cursor = Cursors.Hand;
            btnPost.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPost.Depth = 0;
            btnPost.HighEmphasis = true;
            btnPost.Icon = null;
            btnPost.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnPost.Location = new Point(255, 166);
            btnPost.Margin = new Padding(4, 6, 4, 6);
            btnPost.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnPost.Name = "btnPost";
            btnPost.NoAccentTextColor = Color.Empty;
            btnPost.Size = new Size(80, 28);
            btnPost.TabIndex = 20;
            btnPost.Text = "Post";
            btnPost.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPost.UseAccentColor = true;
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancel.Location = new Point(152, 166);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // InputDialogPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(368, 224);
            Controls.Add(btnCancel);
            Controls.Add(btnPost);
            Controls.Add(postText);
            ForeColor = Color.WhiteSmoke;
            Margin = new Padding(3, 2, 3, 2);
            Name = "InputDialogPost";
            Padding = new Padding(3, 48, 3, 2);
            Text = "New Post";
            TransparencyKey = Color.FromArgb(64, 64, 64);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit postText;
        private ReaLTaiizor.Controls.MaterialButton btnPost;
        private ReaLTaiizor.Controls.MaterialButton btnCancel;
    }
}