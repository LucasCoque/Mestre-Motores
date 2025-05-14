using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MestreMotores
{
    public partial class FrmListar : Form
    {
        public FrmListar()
        {
            InitializeComponent();
        }

        private void ListarCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = ("SELECT * FROM tbl_cliente ORDER BY nome_cliente");
                MySqlCommand cmd = new MySqlCommand(selecionar,banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Nome";
                dtgListar.Columns[2].HeaderText = "Código";
                dtgListar.Columns[3].HeaderText = "Código";
                dtgListar.Columns[4].HeaderText = "Código";
                dtgListar.Columns[5].HeaderText = "Código";
                dtgListar.Columns[6].Visible = false;
                dtgListar.Columns[7].HeaderText = "Código";
                dtgListar.Columns[8].HeaderText = "Código";
                dtgListar.Columns[9].HeaderText = "Código";
                dtgListar.Columns[10].HeaderText = "Código";
                dtgListar.Columns[11].HeaderText = "Código"; 
                dtgListar.Columns[12].HeaderText = "Código";

                dtgListar.ClearSelection();
                banco.Desonectar();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os clientes"+erro);
            }
        }

        private void ListarEspecialidade()
        {
            try
            {
                banco.Conectar();
                string selecionar = ("SELECT * FROM tbl_cliente ORDER BY nome_cliente");
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;


                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Nome";

                dtgListar.ClearSelection();
                banco.Desonectar();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar as Especialidades" + erro);
            }
        }
        private void ListarFuncionario()
        {
            try
            {
                banco.Conectar();
                string selecionar = ("SELECT * FROM tbl_cliente ORDER BY nome_cliente");
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Nome";
                dtgListar.Columns[2].HeaderText = "tipo";
                dtgListar.Columns[3].HeaderText = "cpf_cnpj";
                dtgListar.Columns[4].HeaderText = "data";
                dtgListar.Columns[5].HeaderText = "email";
                dtgListar.Columns[6].Visible = false;
                dtgListar.Columns[7].HeaderText = "telefone";
                dtgListar.Columns[8].HeaderText = "endereco";
                dtgListar.Columns[9].HeaderText = "bairro";
                dtgListar.Columns[10].HeaderText = "cidade";
                dtgListar.Columns[11].HeaderText = "salario";
                dtgListar.Columns[12].HeaderText = "Código";
                dtgListar.Columns[12].HeaderText = "Código";
                dtgListar.Columns[12].HeaderText = "Código";

                dtgListar.ClearSelection();
                banco.Desonectar();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os clientes" + erro);
            }
        }
        private void ListarMarca()
        {
            try
            {
                banco.Conectar();
                string selecionar = ("SELECT * FROM tbl_cliente ORDER BY nome_cliente");
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Nome";
                dtgListar.Columns[2].HeaderText = "descricao";
                dtgListar.Columns[3].HeaderText = "valor";
                dtgListar.Columns[4].HeaderText = "quantidade";
                dtgListar.Columns[5].HeaderText = "foto";
                dtgListar.Columns[6].Visible = false;
                dtgListar.Columns[7].HeaderText = "Código";

                dtgListar.ClearSelection();
                banco.Desonectar();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os clientes" + erro);
            }
        }
        private void ListarModelo()
        {
            try
            {
                banco.Conectar();
                string selecionar = ("SELECT * FROM tbl_cliente ORDER BY nome_cliente");
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Nome";
                dtgListar.Columns[2].HeaderText = "Código";
                dtgListar.Columns[3].HeaderText = "Código";
                dtgListar.Columns[4].HeaderText = "Código";
                dtgListar.Columns[5].HeaderText = "Código";
                dtgListar.Columns[6].Visible = false;
                dtgListar.Columns[7].HeaderText = "Código";
                dtgListar.Columns[8].HeaderText = "Código";
                dtgListar.Columns[9].HeaderText = "Código";
                dtgListar.Columns[10].HeaderText = "Código";
                dtgListar.Columns[11].HeaderText = "Código";
                dtgListar.Columns[12].HeaderText = "Código";

                dtgListar.ClearSelection();
                banco.Desonectar();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os clientes" + erro);
            }
        }
        private void ListarVeiculo()
        {
            try
            {
                banco.Conectar();
                string selecionar = ("SELECT * FROM tbl_cliente ORDER BY nome_cliente");
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Nome";
                dtgListar.Columns[2].HeaderText = "Código";
                dtgListar.Columns[3].HeaderText = "Código";
                dtgListar.Columns[4].HeaderText = "Código";
                dtgListar.Columns[5].HeaderText = "Código";
                dtgListar.Columns[6].Visible = false;
                dtgListar.Columns[7].HeaderText = "Código";
                dtgListar.Columns[8].HeaderText = "Código";
                dtgListar.Columns[9].HeaderText = "Código";
                dtgListar.Columns[10].HeaderText = "Código";
                dtgListar.Columns[11].HeaderText = "Código";
                dtgListar.Columns[12].HeaderText = "Código";

                dtgListar.ClearSelection();
                banco.Desonectar();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os clientes" + erro);
            }
        }
        private void ListarPeca()
        {
            try
            {
                banco.Conectar();
                string selecionar = ("SELECT * FROM tbl_cliente ORDER BY nome_cliente");
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Nome";
                dtgListar.Columns[2].HeaderText = "Código";
                dtgListar.Columns[3].HeaderText = "Código";
                dtgListar.Columns[4].HeaderText = "Código";
                dtgListar.Columns[5].HeaderText = "Código";
                dtgListar.Columns[6].Visible = false;
                dtgListar.Columns[7].HeaderText = "Código";
                dtgListar.Columns[8].HeaderText = "Código";
                dtgListar.Columns[9].HeaderText = "Código";
                dtgListar.Columns[10].HeaderText = "Código";
                dtgListar.Columns[11].HeaderText = "Código";
                dtgListar.Columns[12].HeaderText = "Código";

                dtgListar.ClearSelection();
                banco.Desonectar();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os clientes" + erro);
            }
        }
        private void ListarServico()
        {
            try
            {
                banco.Conectar();
                string selecionar = ("SELECT * FROM tbl_cliente ORDER BY nome_cliente");
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Nome";
                dtgListar.Columns[2].HeaderText = "Código";
                dtgListar.Columns[3].HeaderText = "Código";
                dtgListar.Columns[4].HeaderText = "Código";
                dtgListar.Columns[5].HeaderText = "Código";
                dtgListar.Columns[6].Visible = false;
                dtgListar.Columns[7].HeaderText = "Código";
                dtgListar.Columns[8].HeaderText = "Código";
                dtgListar.Columns[9].HeaderText = "Código";
                dtgListar.Columns[10].HeaderText = "Código";
                dtgListar.Columns[11].HeaderText = "Código";
                dtgListar.Columns[12].HeaderText = "Código";

                dtgListar.ClearSelection();
                banco.Desonectar();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os clientes" + erro);
            }
        }
        private void ListarFornecedor()
        {
            try
            {
                banco.Conectar();
                string selecionar = ("SELECT * FROM tbl_cliente ORDER BY nome_cliente");
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Nome";
                dtgListar.Columns[2].HeaderText = "Código";
                dtgListar.Columns[3].HeaderText = "Código";
                dtgListar.Columns[4].HeaderText = "Código";
                dtgListar.Columns[5].HeaderText = "Código";
                dtgListar.Columns[6].Visible = false;
                dtgListar.Columns[7].HeaderText = "Código";
                dtgListar.Columns[8].HeaderText = "Código";
                dtgListar.Columns[9].HeaderText = "Código";
                dtgListar.Columns[10].HeaderText = "Código";
                dtgListar.Columns[11].HeaderText = "Código";
                dtgListar.Columns[12].HeaderText = "Código";

                dtgListar.ClearSelection();
                banco.Desonectar();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os clientes" + erro);
            }
        }

        private void FrmListar_Load(object sender, EventArgs e)
        {
            if (variaveis.tabela == "CLIENTE")
            {
                lblTabela.Text = "CLIENTE";
            }
            else if (variaveis.tabela == "ESPECIALIDADE")
            {
                lblTabela.Text = "ESPECIALIDADE";
            }

            else if (variaveis.tabela == "FUNCIONÁRIO")
            {
                lblTabela.Text = "FUNCIONÁRIO";
            }

            else if (variaveis.tabela == "MARCA")
            {
                lblTabela.Text = "MARCA";
            }
            else if (variaveis.tabela == "MODELO")
            {
                lblTabela.Text = "MODELO";
            }

            else if (variaveis.tabela == "VEICULO")
            {
                lblTabela.Text = "VEICULO";
            }

            else if (variaveis.tabela == "PEÇA")
            {
                lblTabela.Text = "PEÇA";
            }

            else if (variaveis.tabela == "SERVIÇO")
            {
                lblTabela.Text = "SERVIÇO";
            }

            else if (variaveis.tabela == "FORNECEDOR")
            {
                lblTabela.Text = "FORNECEDOR";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Encerrar?", "ENCERRAR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resposta == DialogResult.No)
            {
                new FrmLogin().Show();
                Close();
            }
        }
    }
}
