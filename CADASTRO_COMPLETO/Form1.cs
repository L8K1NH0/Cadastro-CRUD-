using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CADASTRO_COMPLETO
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQl;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-LPO4E2O\SQLEXPRESS;Initial Catalog=CadastroPessoa;Integrated Security=True");

                strSQl = "INSERT INTO Cadastro (nome, telefone) VALUES (@nome, @telefone)";

                comando = new SqlCommand(strSQl, conexao);

                comando.Parameters.AddWithValue("@nome", TxtNome.Text);
                comando.Parameters.AddWithValue("@telefone", TxtTelefone.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }   
            finally 
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-LPO4E2O\SQLEXPRESS;Initial Catalog=CadastroPessoa;Integrated Security=True");

                strSQl = "SELECT * FROM Cadastro";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQl,conexao);

                conexao.Open();

                da.Fill(ds);

                DgvDados.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-LPO4E2O\SQLEXPRESS;Initial Catalog=CadastroPessoa;Integrated Security=True");

                strSQl = "SELECT * FROM Cadastro WHERE ID = @ID";

                comando = new SqlCommand(strSQl, conexao);

                comando.Parameters.AddWithValue("@ID", TxtID.Text);

                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read()) 
                {
                    TxtNome.Text = (string)dr["nome"];
                    TxtTelefone.Text = Convert.ToString(dr["telefone"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-LPO4E2O\SQLEXPRESS;Initial Catalog=CadastroPessoa;Integrated Security=True");

                strSQl = "UPDATE Cadastro SET nome= @nome, telefone= @telefone WHERE ID= @ID";

                comando = new SqlCommand(strSQl, conexao);

                comando.Parameters.AddWithValue("@ID", TxtID.Text);
                comando.Parameters.AddWithValue("@nome", TxtNome.Text);
                comando.Parameters.AddWithValue("@telefone", TxtTelefone.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=DESKTOP-LPO4E2O\SQLEXPRESS;Initial Catalog=CadastroPessoa;Integrated Security=True");

                strSQl = "DELETE Cadastro WHERE ID = @ID ";

                comando = new SqlCommand(strSQl, conexao);

                comando.Parameters.AddWithValue("@ID", TxtID.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
