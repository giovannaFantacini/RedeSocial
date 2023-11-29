namespace RedeSocial.App.Componentes
{
    partial class InputComent
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
            flowLayoutPanel = new FlowLayoutPanel();
            comentText = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnPost = new ReaLTaiizor.Controls.MaterialButton();
            btnCancel = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Top;
            flowLayoutPanel.Location = new Point(3, 64);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(675, 241);
            flowLayoutPanel.TabIndex = 0;
            // 
            // comentText
            // 
            comentText.AnimateReadOnly = false;
            comentText.AutoCompleteMode = AutoCompleteMode.None;
            comentText.AutoCompleteSource = AutoCompleteSource.None;
            comentText.BackgroundImageLayout = ImageLayout.None;
            comentText.CharacterCasing = CharacterCasing.Normal;
            comentText.Depth = 0;
            comentText.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            comentText.HideSelection = true;
            comentText.Hint = "Comment";
            comentText.LeadingIcon = null;
            comentText.Location = new Point(20, 341);
            comentText.Margin = new Padding(3, 2, 3, 2);
            comentText.MaxLength = 32767;
            comentText.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comentText.Name = "comentText";
            comentText.PasswordChar = '\0';
            comentText.PrefixSuffixText = null;
            comentText.ReadOnly = false;
            comentText.RightToLeft = RightToLeft.No;
            comentText.SelectedText = "";
            comentText.SelectionLength = 0;
            comentText.SelectionStart = 0;
            comentText.ShortcutsEnabled = true;
            comentText.Size = new Size(436, 48);
            comentText.TabIndex = 1;
            comentText.TabStop = false;
            comentText.TextAlign = HorizontalAlignment.Left;
            comentText.TrailingIcon = null;
            comentText.UseSystemPasswordChar = false;
            // 
            // btnPost
            // 
            btnPost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPost.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPost.Depth = 0;
            btnPost.HighEmphasis = true;
            btnPost.Icon = null;
            btnPost.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnPost.Location = new Point(482, 353);
            btnPost.Margin = new Padding(4, 6, 4, 6);
            btnPost.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnPost.Name = "btnPost";
            btnPost.NoAccentTextColor = Color.Empty;
            btnPost.Size = new Size(64, 36);
            btnPost.TabIndex = 2;
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
            btnCancel.Location = new Point(573, 353);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // InputComent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 431);
            Controls.Add(btnCancel);
            Controls.Add(btnPost);
            Controls.Add(comentText);
            Controls.Add(flowLayoutPanel);
            Name = "InputComent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Comments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit comentText;
        private ReaLTaiizor.Controls.MaterialButton btnPost;
        private ReaLTaiizor.Controls.MaterialButton btnCancel;
    }
}