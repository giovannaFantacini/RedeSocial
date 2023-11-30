namespace RedeSocial.App.Componentes
{
    partial class ComponenteAmizade
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblUserName = new Label();
            btnAddFriend = new ReaLTaiizor.Controls.MaterialButton();
            btnRemove = new ReaLTaiizor.Controls.MaterialButton();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(115, 33);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(96, 41);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "label1";
            // 
            // btnAddFriend
            // 
            btnAddFriend.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddFriend.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddFriend.Depth = 0;
            btnAddFriend.HighEmphasis = true;
            btnAddFriend.Icon = null;
            btnAddFriend.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAddFriend.Location = new Point(499, 28);
            btnAddFriend.Margin = new Padding(5, 8, 5, 8);
            btnAddFriend.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddFriend.Name = "btnAddFriend";
            btnAddFriend.NoAccentTextColor = Color.Empty;
            btnAddFriend.Size = new Size(64, 36);
            btnAddFriend.TabIndex = 1;
            btnAddFriend.Text = "Add";
            btnAddFriend.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddFriend.UseAccentColor = true;
            btnAddFriend.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemove.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRemove.Depth = 0;
            btnRemove.HighEmphasis = true;
            btnRemove.Icon = null;
            btnRemove.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRemove.Location = new Point(499, 28);
            btnRemove.Margin = new Padding(5, 8, 5, 8);
            btnRemove.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRemove.Name = "btnRemove";
            btnRemove.NoAccentTextColor = Color.Empty;
            btnRemove.Size = new Size(80, 36);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRemove.UseAccentColor = false;
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(23, 24);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(61, 67);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // ComponenteAmizade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox);
            Controls.Add(btnRemove);
            Controls.Add(btnAddFriend);
            Controls.Add(lblUserName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ComponenteAmizade";
            Size = new Size(607, 109);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblUserName;
        public ReaLTaiizor.Controls.MaterialButton btnAddFriend;
        public ReaLTaiizor.Controls.MaterialButton btnRemove;
        public PictureBox pictureBox;
    }
}
