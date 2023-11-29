namespace RedeSocial.App.Componentes
{
    partial class ComponentePostagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentePostagem));
            lbl_userName = new Label();
            lbl_postagem = new Label();
            btn_curtir = new ReaLTaiizor.Controls.MaterialButton();
            btn_comentar = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new Button();
            pictureBox = new PictureBox();
            lbldataEHora = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lbl_userName
            // 
            lbl_userName.AutoSize = true;
            lbl_userName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_userName.Location = new Point(108, 37);
            lbl_userName.Name = "lbl_userName";
            lbl_userName.Size = new Size(83, 32);
            lbl_userName.TabIndex = 0;
            lbl_userName.Text = "label1";
            // 
            // lbl_postagem
            // 
            lbl_postagem.AutoSize = true;
            lbl_postagem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_postagem.Location = new Point(108, 90);
            lbl_postagem.Name = "lbl_postagem";
            lbl_postagem.Size = new Size(63, 25);
            lbl_postagem.TabIndex = 1;
            lbl_postagem.Text = "label1";
            // 
            // btn_curtir
            // 
            btn_curtir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_curtir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_curtir.Depth = 0;
            btn_curtir.HighEmphasis = true;
            btn_curtir.Icon = null;
            btn_curtir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_curtir.Location = new Point(286, 115);
            btn_curtir.Margin = new Padding(4, 6, 4, 6);
            btn_curtir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_curtir.Name = "btn_curtir";
            btn_curtir.NoAccentTextColor = Color.Empty;
            btn_curtir.Size = new Size(72, 36);
            btn_curtir.TabIndex = 4;
            btn_curtir.Text = "Curtir";
            btn_curtir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_curtir.UseAccentColor = false;
            btn_curtir.UseVisualStyleBackColor = true;
            // 
            // btn_comentar
            // 
            btn_comentar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_comentar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_comentar.Depth = 0;
            btn_comentar.HighEmphasis = true;
            btn_comentar.Icon = null;
            btn_comentar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_comentar.Location = new Point(388, 115);
            btn_comentar.Margin = new Padding(4, 6, 4, 6);
            btn_comentar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_comentar.Name = "btn_comentar";
            btn_comentar.NoAccentTextColor = Color.Empty;
            btn_comentar.Size = new Size(101, 36);
            btn_comentar.TabIndex = 5;
            btn_comentar.Text = "Comentar";
            btn_comentar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_comentar.UseAccentColor = true;
            btn_comentar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(450, 9);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(39, 32);
            btnExcluir.TabIndex = 6;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.InitialImage = null;
            pictureBox.Location = new Point(12, 14);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(73, 60);
            pictureBox.TabIndex = 7;
            pictureBox.TabStop = false;
            // 
            // lbldataEHora
            // 
            lbldataEHora.AutoSize = true;
            lbldataEHora.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbldataEHora.Location = new Point(269, 14);
            lbldataEHora.Name = "lbldataEHora";
            lbldataEHora.Size = new Size(50, 20);
            lbldataEHora.TabIndex = 8;
            lbldataEHora.Text = "label1";
            // 
            // ComponentePostagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbldataEHora);
            Controls.Add(pictureBox);
            Controls.Add(btnExcluir);
            Controls.Add(btn_comentar);
            Controls.Add(btn_curtir);
            Controls.Add(lbl_postagem);
            Controls.Add(lbl_userName);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(460, 141);
            Name = "ComponentePostagem";
            Size = new Size(506, 167);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lbl_userName;
        public Label lbl_postagem;
        public ReaLTaiizor.Controls.MaterialButton btn_curtir;
        public ReaLTaiizor.Controls.MaterialButton btn_comentar;
        public Button btnExcluir;
        public PictureBox pictureBox;
        public Label lbldataEHora;
    }
}
