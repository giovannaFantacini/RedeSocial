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
            SuspendLayout();
            // 
            // lbl_userName
            // 
            lbl_userName.AutoSize = true;
            lbl_userName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_userName.Location = new Point(21, 12);
            lbl_userName.Name = "lbl_userName";
            lbl_userName.Size = new Size(104, 41);
            lbl_userName.TabIndex = 0;
            lbl_userName.Text = "label1";
            // 
            // lbl_postagem
            // 
            lbl_postagem.AutoSize = true;
            lbl_postagem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_postagem.Location = new Point(48, 75);
            lbl_postagem.Name = "lbl_postagem";
            lbl_postagem.Size = new Size(76, 31);
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
            btn_curtir.Location = new Point(281, 109);
            btn_curtir.Margin = new Padding(5, 8, 5, 8);
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
            btn_comentar.Location = new Point(387, 109);
            btn_comentar.Margin = new Padding(5, 8, 5, 8);
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
            btnExcluir.Location = new Point(467, 12);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(42, 29);
            btnExcluir.TabIndex = 6;
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // ComponentePostagem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExcluir);
            Controls.Add(btn_comentar);
            Controls.Add(btn_curtir);
            Controls.Add(lbl_postagem);
            Controls.Add(lbl_userName);
            MinimumSize = new Size(526, 188);
            Name = "ComponentePostagem";
            Size = new Size(526, 188);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lbl_userName;
        public Label lbl_postagem;
        public ReaLTaiizor.Controls.MaterialButton btn_curtir;
        public ReaLTaiizor.Controls.MaterialButton btn_comentar;
        public Button btnExcluir;
    }
}
