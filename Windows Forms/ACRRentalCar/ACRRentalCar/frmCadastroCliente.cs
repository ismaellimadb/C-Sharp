using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }
        //sub-rotina habilitadora
        private void habilitar()
        { 
            //txtCodigo desabilitado
            txtCodigo.Enabled = false;
            //esses aqui habilitados
            txtNome.Enabled = true;
            mskCPF.Enabled = true;
            mskDtNasc.Enabled = true;
        }
        //sub-rotina desabilitadora
        private void desabilitar()
        {
            //Desabilitando tudo
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            mskCPF.Enabled = false;
            mskDtNasc.Enabled = false;
        }
        //sub-rotina faxineira
        private void limparControles()
        {
            //txtCodigo desabilitado
            txtCodigo.Enabled = false;
            //faxina e focus
            txtNome.Clear();
            txtCodigo.Clear();
            mskCPF.Clear();
            mskDtNasc.Clear();
            //focus pro cpf
            mskCPF.Focus();
        }
        //função de validação que retorna true ou false
        private bool validaDados()
        { 
            //verificando se mskCPF esta ou não preenchido
            if (string.IsNullOrEmpty(mskCPF.Text)) 
            {
                //mensagem pro erro
                MessageBox.Show("Preenchimento Obrigatorio","ACR Rental Car",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //limpa o mskCPF
                mskCPF.Clear();
                //focus pro mskCPF
                mskCPF.Focus();
                //retorna falso??????????ava..
                return false;
            }
            //verificando se data de nascimento é data mesmo..
            DateTime auxData; //var aux pra dt
            //ver se data digitada é valida ou caso não tenha nada digitado
            if (!(DateTime.TryParse(mskDtNasc.Text, out auxData)))
            {
                MessageBox.Show("Preenchimento Obrigatorio", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpa mskDtNasc
                mskDtNasc.Clear();
                //foca mskDtNasc
                mskDtNasc.Focus();
                //retorna falso
                return false;
            }
            //verifica se o txtNome está preenchido, Se for nulo ou vazio retorna falso
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                //mensagem ao usuário
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //limpa o txtNome
                txtNome.Clear();

                //coloca o cursor no txtNome
                txtNome.Focus();

                //retorna falso
                return false;
            }
            //Se de resto da ok, retorna verdadeiro
            return true;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            //chamando habilitar
            habilitar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            { 
                // se o codigo não esta vazio, ja foi consultado um cliente então na instrução é capturado se clicado yes como resposta da perguntado
                if (MessageBox.Show("Você está editando um codigo existente. Deseja incluir um registro novo?", "ACR Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                limparControles();
                return; // encerra sub-rotina
            }
            //antes de incluir é preciso validar os dados de preenchimento obrigatório
            //chama o método para validar a entrada de dados
            //se retornou falso, interrompe o processamento para incluir no banco de dados
            if (validaDados() == false)
            {
                return; //interrompe a subrotina
            }
            //declarando var que terá informações sql
            string sqlQuery;
            //criando conexão chamando getConection da classe conexao
            SqlConnection conCliente = Conexao.getConnection();
            //criando-se instrução sql parametizada
            sqlQuery = "INSERT INTO cliente(nome,data_nasc,cpf) VALUES(@nome,@data_nasc,@cpf)";
            //tratamento de excessões (erros)
            try
            {
                //abrindo conexão com o banco
                conCliente.Open();
                //cria um objeto do tipo SqlCommand com a instrução SQL e a conexão
                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);
                //define, adiciona os parametros
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", Convert.ToDateTime(mskDtNasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskCPF.Text));

                //executando com ExecuteNonQuery que envia para o banco os dados da var cmd
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente inserido com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpando campos para nova entrada de dados
                limparControles();
            }
            catch (Exception ex) //caso tenha dado alguma mudança no bloco try
            {
                MessageBox.Show("Problema ao incluir cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //se conexao for nula fecha conexao
                if (conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //os campos para serem alterados são preenchidos por meio da consulta no grid do form Consulta de Cliente
            //verifica se tem o código do cliente no txtCodigo. Se o campo estiver vazio, interrompe a sub-rotina
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o cliente que deseja alterar clicando no botão consultar", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;   //interrompe a sub-rotina
            }

            // antes de alterar o registro é preciso validar os dados de preenchimento obrigatório
            //chama o método para validar a entrada de dados
            //se retornou falso, interrompe o processamento
            if (validaDados() == false)
            {
                return;
            }

            //declaração da variável para guardar as instruções SQL
            string sqlQuery;

            //cria conexão chamando o método getConnection da classe Conexao
            SqlConnection conCliente = Conexao.getConnection();

            //cria a instrução sql, parametrizada
            sqlQuery = "UPDATE cliente set nome=@nome,data_nasc=@data_nasc,cpf=@cpf WHERE id_cliente=@id_cliente";

            //Tratamento de exceções 
            //códigos semelhantes ao botão inserir com diferença na instrução SQL
            try
            {
                conCliente.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);
                //define, adiciona os parametros
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", Convert.ToDateTime(mskDtNasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", mskCPF.Text));
                cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                //executa o comando
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpa os campos para nova entrada de dados
                limparControles();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao alterar cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //veririfica se tem o código do cliente no txtCodigo
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o cliente que deseja excluir clicando no botão consultar", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //solicita confirmação de exclusão de registro
            if (MessageBox.Show("Deseja excluir permanentemente o registro?", "ACR Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //declaração da variável para guardar as instruções SQL
                string sqlQuery;

                //cria conexão chamando o método getConnection da classe Conexao
                SqlConnection conCliente = Conexao.getConnection();

                //cria a instrução sql, parametrizada
                sqlQuery = "DELETE FROM cliente WHERE id_cliente=@id_cliente";

                //Tratamento de exceções
                try
                {
                    conCliente.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                    //define, adiciona os parametros
                    cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                    //executa o commando
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente excluído com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpa os campos para nova entrada de dados
                    limparControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao incluir cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (conCliente != null)
                    {
                        conCliente.Close();
                    }
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //criando um novo formulario de frmConsultaCliente, passando como parâmetro uma referência desse form
            Form frm = new frmConsultaCliente(this);
            //define o pai da janela
            frm.MdiParent = this.MdiParent;
            //exibe o formulário
            frm.Show();
        }
    }
}
