using System.ComponentModel;

namespace WindowsFormsProjeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaNome(txtNome.Text))
                MessageBox.Show("Nome inv�lido");
            //Remove os pontos e tra�os da m�scara,
            //para ler somente o valor que o usu�rio digitou
            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            
            if (!ValidaCpf(txtCPF.Text))
                MessageBox.Show("CPF Inv�lido");
           
        }

        private bool ValidaNome(string nome)
        {
            if (nome == null || nome.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidaCpf(string cpf) 
        {
            if(cpf == null || cpf.Trim() == "" || !cpf.All(char.IsDigit) || cpf.Length!= 11)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void txtPa�s_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Apertou o Enter");
            }
        }
    }
}
