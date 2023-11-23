namespace RedeSocial.App.Componentes
{
    partial class ComponenteComentario
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
            lblTextoComent = new Label();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(15, 10);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(76, 32);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "label1";
            // 
            // lblTextoComent
            // 
            lblTextoComent.AutoSize = true;
            lblTextoComent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTextoComent.Location = new Point(28, 60);
            lblTextoComent.Name = "lblTextoComent";
            lblTextoComent.Size = new Size(63, 25);
            lblTextoComent.TabIndex = 1;
            lblTextoComent.Text = "label1";
            // 
            // ComponenteComentario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTextoComent);
            Controls.Add(lblUserName);
            MaximumSize = new Size(429, 116);
            MinimumSize = new Size(429, 116);
            Name = "ComponenteComentario";
            Size = new Size(429, 116);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblUserName;
        public Label lblTextoComent;
    }
}
