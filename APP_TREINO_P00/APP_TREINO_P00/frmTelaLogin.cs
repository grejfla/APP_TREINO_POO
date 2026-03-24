namespace APP_TREINO_P00
{
    public partial class frmTelaLogin : Form
    {
        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string NomeUsuario = txtnomeUsuario.Text;
            string MatriculaUsuario = txtMatriculaUsuario.Text;
            string SenhaUsuario = txtSenhaUsuario.Text;

            DadosdoUsuario ddu = new DadosdoUsuario(NomeUsuario, MatriculaUsuario, SenhaUsuario);

            if (ddu.VerificarDados())
            {
                frmTelaPrincipal ftp = new frmTelaPrincipal();
                ftp.Show();
                this.Visible = false;
            }
            else {
                MessageBox.Show("Credenciais incorrentas tente novamente");
            
            }
            
            
        }
    }
}
