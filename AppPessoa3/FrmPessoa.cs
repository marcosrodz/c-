using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPessoa3
{
    public partial class FrmPessoa : Form
    {
        public FrmPessoa()
        {
            InitializeComponent();
        }

        private void FrmPessoa_Load(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            List<Pessoa> pessoas = pessoa.listapessoas();
            dgvPessoa.DataSource = pessoas;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja realmente sair?", "Sair da Aplicação", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "" && txtCidade.Text == "" && txtEndereco.Text == "")
                {
                    MessageBox.Show("Por favor, preencha o formulário para inserir!");
                    this.txtNome.Focus();
                }
                else
                {
                    Pessoa pessoa = new Pessoa();
                    if (pessoa.RegistroRepetido(txtNome.Text, txtCelular.Text, txtEmail.Text) != false)
                    {
                        MessageBox.Show("Este cliente já está em nossa base de dados!");
                        this.txtNome.Focus();
                    }
                    else
                    {
                        pessoa.Inserir(txtNome.Text, txtCidade.Text, txtEndereco.Text, txtDataNascimento.Text, txtCelular.Text, txtEmail.Text);
                        MessageBox.Show("Cliente cadastrado com sucesso!");
                        List<Pessoa> pessoas = pessoa.listapessoas();
                        dgvPessoa.DataSource = pessoas;
                        txtNome.Text = "";
                        label2.Text = "";
                        txtEndereco.Text = "";
                        txtDataNascimento.Text = "";
                        txtCelular.Text = "";
                        txtEmail.Text = "";
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Por favor digitar um ID!");
                this.txtId.Focus();
            }
            else
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Pessoa pessoa = new Pessoa();
                pessoa.Localizar(Id);
                txtNome.Text = pessoa.nome;
                txtCidade.Text = pessoa.cidade;
                txtEndereco.Text = pessoa.endereco;
                txtDataNascimento.Text = pessoa.data_nascimento;
                txtCelular.Text = pessoa.celular;
                txtEmail.Text = pessoa.email;
                btnAtualizar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}
