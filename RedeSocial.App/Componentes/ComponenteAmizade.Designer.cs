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
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(30, 21);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(76, 32);
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
            btnAddFriend.Location = new Point(435, 17);
            btnAddFriend.Margin = new Padding(4, 6, 4, 6);
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
            // ComponenteAmizade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddFriend);
            Controls.Add(lblUserName);
            Name = "ComponenteAmizade";
            Size = new Size(531, 74);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblUserName;
        public ReaLTaiizor.Controls.MaterialButton btnAddFriend;
    }
}
