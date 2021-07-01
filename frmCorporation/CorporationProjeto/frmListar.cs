using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CorporationProjeto
{
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }

        private void frmListar_Load(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_corporation;";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();

                string sqlSelecionar = "SELECT * FROM tb_usuarios";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridListagem.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Conexão falhou. Erro: " + erro.Message);
            }

        }

        private void gridListagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmCadastro formulario = new frmCadastro();
            formulario.ShowDialog();
        }

        private void btnAlterarExcluir_Click(object sender, EventArgs e)
        {
            frmAlterarExcluir formulario = new frmAlterarExcluir();
            formulario.ShowDialog();
        }
    }
}
