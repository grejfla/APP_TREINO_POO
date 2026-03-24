namespace APP_TREINO_P00
{
    partial class frmTelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtnomeUsuario = new TextBox();
            txtMatriculaUsuario = new TextBox();
            txtSenhaUsuario = new TextBox();
            lblTitulo = new Label();
            lblNomeUsuario = new Label();
            lblMatriculaUsuario = new Label();
            lblSenhaUsuario = new Label();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // txtnomeUsuario
            // 
            txtnomeUsuario.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnomeUsuario.Location = new Point(467, 152);
            txtnomeUsuario.Margin = new Padding(4);
            txtnomeUsuario.Name = "txtnomeUsuario";
            txtnomeUsuario.Size = new Size(198, 27);
            txtnomeUsuario.TabIndex = 0;
            // 
            // txtMatriculaUsuario
            // 
            txtMatriculaUsuario.Location = new Point(467, 241);
            txtMatriculaUsuario.Margin = new Padding(4);
            txtMatriculaUsuario.Name = "txtMatriculaUsuario";
            txtMatriculaUsuario.Size = new Size(215, 27);
            txtMatriculaUsuario.TabIndex = 1;
            // 
            // txtSenhaUsuario
            // 
            txtSenhaUsuario.Location = new Point(467, 328);
            txtSenhaUsuario.Margin = new Padding(4);
            txtSenhaUsuario.Name = "txtSenhaUsuario";
            txtSenhaUsuario.Size = new Size(215, 27);
            txtSenhaUsuario.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblTitulo.Location = new Point(491, 51);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(109, 23);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Tela Login";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeUsuario.Location = new Point(471, 108);
            lblNomeUsuario.Margin = new Padding(4, 0, 4, 0);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(123, 19);
            lblNomeUsuario.TabIndex = 4;
            lblNomeUsuario.Text = "Nome Usuário";
            // 
            // lblMatriculaUsuario
            // 
            lblMatriculaUsuario.AutoSize = true;
            lblMatriculaUsuario.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatriculaUsuario.Location = new Point(467, 201);
            lblMatriculaUsuario.Margin = new Padding(4, 0, 4, 0);
            lblMatriculaUsuario.Name = "lblMatriculaUsuario";
            lblMatriculaUsuario.Size = new Size(152, 19);
            lblMatriculaUsuario.TabIndex = 5;
            lblMatriculaUsuario.Text = "Matrícula Usuário";
            // 
            // lblSenhaUsuario
            // 
            lblSenhaUsuario.AutoSize = true;
            lblSenhaUsuario.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenhaUsuario.Location = new Point(467, 288);
            lblSenhaUsuario.Margin = new Padding(4, 0, 4, 0);
            lblSenhaUsuario.Name = "lblSenhaUsuario";
            lblSenhaUsuario.Size = new Size(126, 19);
            lblSenhaUsuario.TabIndex = 6;
            lblSenhaUsuario.Text = "Senha Usuário";
            // 
            // btnEntrar
            // 
            btnEntrar.ForeColor = SystemColors.ActiveCaptionText;
            btnEntrar.Location = new Point(521, 397);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // frmTelaLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1143, 570);
            Controls.Add(btnEntrar);
            Controls.Add(lblSenhaUsuario);
            Controls.Add(lblMatriculaUsuario);
            Controls.Add(lblNomeUsuario);
            Controls.Add(lblTitulo);
            Controls.Add(txtSenhaUsuario);
            Controls.Add(txtMatriculaUsuario);
            Controls.Add(txtnomeUsuario);
            Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "frmTelaLogin";
            Text = "frmTelaLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnomeUsuario;
        private TextBox txtMatriculaUsuario;
        private TextBox txtSenhaUsuario;
        private Label lblTitulo;
        private Label lblNomeUsuario;
        private Label lblMatriculaUsuario;
        private Label lblSenhaUsuario;
        private Button btnEntrar;
    }
}
