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

using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //SqlConnection sqlconnection = new SqlConnection("Data Source=localhost;Initial Catalog=db_adonet;User ID=aluno;Password=etesp");
        SqlConnection sqlconnection = new SqlConnection("Data Source=localhost;Initial Catalog=db_adonet; Trusted_Connection= Yes");

        private void btnsCreateSelectUpdateDelete_Click(object sender, EventArgs e)
        {
            string textButton = (sender as Button).Text;

            if(textButton == btnCadastrar.Text)//"Cadastrar"
                Cadastrar();
            else if(textButton == btnAlterar.Text)//"Alterar"
                Alterar();
            else if(textButton == btnExcluir.Text)//"Excluir"
                Excluir();
            else if(textButton == btnPesquisar.Text)//"Pesquisar por ID"
                Pesquisar(int.Parse(txtId.Text));

            //removento a seleção da linha
            if(dataGridView1.SelectedRows.Count > 0)
                dataGridView1.ClearSelection();

            if(listView1.FullRowSelect || listView1.SelectedItems.Count != 0 || listView1.FocusedItem != null)
                listView1.FocusedItem.Focused = false;
        }

        private void btnsDoGridView1_Click(object sender, EventArgs e)
        {
            //limpar o grid 
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;

            //definindo as propriedades
            dataGridView1.DefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; //linhas, cor sim cor nao
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.MidnightBlue;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;    //nao permitir adicionar diretamente no grid
            dataGridView1.AllowUserToDeleteRows = false; //nao permitir deletar diretamente do grid
            dataGridView1.ReadOnly = true;               //nao permitir alterar valores das celulas
            dataGridView1.AllowUserToResizeRows = false; //nao permitir ajustes de linhas

            string tagButton = (sender as Button).Tag.ToString();

            switch(tagButton)
            {
                case "DataAdapter":
                    ExibirNoGridComDataAdapter();
                    break;
                case "DataSet":
                    ExibirNoGridComDataSet();
                    break;
                case "DataReader":
                    ExibirNoGridComDataReader();
                    break;
                case "DataReaderEDataTable":
                    ExibirNoGridComDataReaderEDataTable();
                    break;
            }

            //definindo titulos e tamanho das colunas apos prenchidas
            dataGridView1.Columns["Id"].HeaderText = "Cod.";
            dataGridView1.Columns["Id"].Width = 35;

            dataGridView1.Columns["Sexo"].HeaderText = "SEXO";
            dataGridView1.Columns["Sexo"].Width = 40;
        }

        private void btnDataAdapterGrid2_Click(object sender, EventArgs e)
        {
            //edit coluns > dataproperty name> colocar nome do campo do bd
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_Cliente", sqlconnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void btnsCarregarComboEListBox_Click(object sender, EventArgs e)
        {
            string textButton = (sender as Button).Text;

            if(textButton == btnDRcbo.Text)
                CarregarComboOuListBoxDR();
            else if(textButton == btnDTcbo.Text)
                CarregarComboOuListDataDReDT();
        }

        private void btnExibirListView_Click(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            //definindo propriedades
            listView1.MultiSelect = false;
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            //adicionando colunas e tamanhos
            listView1.Columns.Add("id", "ID", 30);
            listView1.Columns.Add("nome", "NOME", 70);
            listView1.Columns.Add("sexo", "SEXO", -2); //-2 para completar a largura

            ExibirNoListViewComDataReader();

            //mudando cores das linhas
            for(int i = 0; i < listView1.Items.Count; i=i+2)
                listView1.Items[i].BackColor = Color.Lavender;
        }

        private void Cadastrar()
        {
            //definição do sqlcommand sql
            string query = "INSERT INTO tbl_Cliente (Nome, Sexo, DataNascimento) VALUES (@nome, @sexo, @dtNasc)";//@parametros

            //Cria-se uma objeto passando como parametro a query e a sqlconnection
            SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);

            //SqlCommand sqlcommand = new SqlCommand("spInserirCliente", sqlconnection);
            //instrucoes.CommandType = CommandType.StoredProcedure;

            //Adiciona os valores dos componentes nos parametros do sqlcommand
            sqlcommand.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;          //1º forma
            sqlcommand.Parameters.AddWithValue("@sexo", rdoMasculino.Checked ? 'M' : 'F');       //2º forma
            sqlcommand.Parameters.Add(new SqlParameter("@dtNasc", dtpDataNascimento.Value));     //3º forma 

            //caso houver parametro com valor vazio, define para null
            foreach(SqlParameter p in sqlcommand.Parameters)
                if(string.IsNullOrWhiteSpace(p.Value.ToString()))
                    p.Value = DBNull.Value;

            try
            {
                //Abre a conexao
                sqlconnection.Open();
                //Executar a instrucao e nao retorna valores
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: "+ex.Message);
            }
            finally
            {
                //fecha a conexão;
                sqlconnection.Close();
            }
        }

        private void Alterar()
        {
            string query = "UPDATE tbl_Cliente SET Nome = @nome, Sexo = @sexo, DataNascimento = @dtnasc WHERE Id = @id";
            SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
            sqlcommand.Parameters.Add("@id", SqlDbType.SmallInt).Value = txtId.Text;
            sqlcommand.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            sqlcommand.Parameters.Add("@sexo", SqlDbType.Char).Value = rdoMasculino.Checked ? 'M' : 'F';
            sqlcommand.Parameters.Add("@dtnasc", SqlDbType.Date).Value = dtpDataNascimento.Value;

            try
            {
                sqlconnection.Open();
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("Alterado com Sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        private void Excluir()
        {
            string query = "DELETE from tbl_Cliente WHERE Id = @id";
            SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
            sqlcommand.Parameters.Add("@id", SqlDbType.SmallInt).Value = txtId.Text;

            try
            {
                sqlconnection.Open();
                bool isDeleted = Convert.ToBoolean(sqlcommand.ExecuteNonQuery());
                if(isDeleted)
                    MessageBox.Show("Usuario deletado");
                else
                    MessageBox.Show("Usuario não existe");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        private void Pesquisar(int Id)
        {
            try
            {
                SqlCommand sqlcommand = new SqlCommand("SELECT * FROM tbl_Cliente WHERE Id = @id", sqlconnection);
                sqlcommand.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                //Abrir sqlconnection
                sqlconnection.Open();
                //Executa o comando retornando os dados
                SqlDataReader dr = sqlcommand.ExecuteReader();

                //se nao tiver linhas
                if(!dr.HasRows)
                {
                    MessageBox.Show("Nenhum registro encontrado");
                    return;
                }
                //Colocando os dados nos componentes
                if(dr.Read())
                {
                    txtId.Text = dr.GetValue(0).ToString();
                    txtNome.Text = dr[1].ToString();
                    string sexo = dr["Sexo"].ToString();

                    if(sexo == "M")
                        rdoMasculino.Checked = true;
                    else
                        rdoFeminino.Checked = true;

                    dtpDataNascimento.Value = dr.GetDateTime(3);
                    MessageBox.Show("Pesquisa Realizada");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        #region Populando Componentes
        //DATATABLE e DATAADAPTER ++++
        private void ExibirNoGridComDataAdapter()
        {
            string query = "SELECT TOP 20 Id, Nome, Sexo, DataNascimento AS 'Data Nasc' FROM tbl_Cliente";
            SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
            //passa o objeto de sqlcommand para o data adapter 
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            //Preenche o DataTable com os dados do DataAdapter
            da.Fill(dt);
            //o grid recebe os dados do DataTable            
            dataGridView1.DataSource = dt;
            //                  ou
            //DataTable table = new DataTable("lide");
            //using(SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=db_adonet; Trusted_Connection= Yes"))
            //{
            //    string query = @"SELECT * FRom tbl_Cliente";
            //    using( SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            //        adapter.Fill(table);
            //}
            //dataGridView1.DataSource = table;
        }

        //DATASET e DATAADAPDER ++
        private void ExibirNoGridComDataSet()
        {
            string query = "SELECT TOP 20 Id, Nome, Sexo, DataNascimento AS 'Data Nasc' FROM tbl_Cliente";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlconnection);
            DataSet ds = new DataSet("nameMyTable");
            sqlconnection.Open();
            adapter.Fill(ds, "nameMyTable");
            sqlconnection.Close();
            dataGridView1.DataSource = ds.Tables["nameMyTable"];
        }

        //DATAREADER + (util quando retornará apenas 1 linha)
        private void ExibirNoGridComDataReader()
        {
            string query = "SELECT TOP 20 Id, Nome, Sexo, DataNascimento AS 'Data Nasc' FROM tbl_Cliente";
            SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
            sqlconnection.Open();
            SqlDataReader dr = sqlcommand.ExecuteReader();

            int nColunas = dr.FieldCount;
            //percorre as colunas obtendo o seu nome e incluindo no DataGridView
            for(int i = 0; i < nColunas; i++)
            {
                dataGridView1.Columns.Add(dr.GetName(i).ToString(), dr.GetName(i).ToString());
            }

            //define um array de strings com nCOlunas
            string[] linhaDados = new string[nColunas];
            //percorre o DataRead
            while(dr.Read())
            {
                //percorre cada uma das colunas
                for(int a = 0; a < nColunas; a++)
                {
                    //verifica o tipo de dados da coluna
                    if(dr.GetFieldType(a).ToString() == "System.Int32")
                    {
                        linhaDados[a] = dr.GetInt32(a).ToString();
                    }
                    else if(dr.GetFieldType(a).ToString() == "System.String")
                    {
                        linhaDados[a] = dr.GetValue(a).ToString();
                    }
                    else if(dr.GetFieldType(a).ToString() == "System.DateTime")
                    {
                        linhaDados[a] = dr.GetDateTime(a).ToString();
                    }

                }
                //adiciona a linha ao datagridview
                dataGridView1.Rows.Add(linhaDados);
            }
            sqlconnection.Close();
        }

        //DATAREADER e DATATABLE +++
        private void ExibirNoGridComDataReaderEDataTable()
        {
            try
            {
                string query = "SELECT TOP 20 Id, Nome, Sexo, DataNascimento AS 'Data Nasc' FROM tbl_Cliente";
                SqlCommand sqlcommand = new SqlCommand(query, sqlconnection);
                sqlconnection.Open();
                SqlDataReader dr = sqlcommand.ExecuteReader();
                if(dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dt.Columns[1].SetOrdinal(2);  //teste mudando a posiçao               
                    dataGridView1.DataSource = dt;
                }
                else
                    MessageBox.Show("Não Contem registros");
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        //listView DATAREADER
        private void ExibirNoListViewComDataReader()
        {
            listView1.Items.Clear();
            SqlCommand sqlcommand = new SqlCommand("SELECT * from tbl_Cliente", sqlconnection);
            sqlconnection.Open();
            SqlDataReader dr = sqlcommand.ExecuteReader();

            short i = 0;
            while(dr.Read())
            {
                listView1.Items.Add(dr["Id"].ToString());
                listView1.Items[i].SubItems.Add(dr["Nome"].ToString());
                listView1.Items[i].SubItems.Add(dr["Sexo"].ToString());
                i++;
            }
            sqlconnection.Close();
            //Populando a partir de dataTable
            //foreach(DataRow linha in dataTable.Rows)
            //{
            //	ListViewItem listItem = new ListViewItem(linha["Id_D"].ToString());
            //listItem.SubItems.Add(linha["Nome"].ToString());
            //	listItem.SubItems.Add(linha["Sexo"].ToString());
            //	listView1.Items.Add(listItem);
            //}

            //Populando por uma lista de classe
            //List<Pessoa> pessoas = new List<Pessoa>();
            //for (int i = 0; i<departamentos.Count; i++)
            //{
            //	listView1.Items.Add(pessoas[i].Id_D.ToString());
            //	listView1.Items[i].SubItems.Add(pessoas[i].Nome);
            //	listView1.Items[i].SubItems.Add(pessoas[i].Sexo);
            //}
        }

        //populando comboBox e ListBox
        private void CarregarComboOuListBoxDR()
        {
            listBox1.Items.Clear();
            cboNomesClientes.Items.Clear();

            SqlCommand comando = new SqlCommand("SELECT * FROM tbl_Cliente", sqlconnection);
            sqlconnection.Open();
            SqlDataReader dr = comando.ExecuteReader();

            while(dr.Read())
            {
                cboNomesClientes.Items.Add(dr["Nome"]);
                listBox1.Items.Add(dr["Nome"]+" "+dr["DataNascimento"]);
            }
            sqlconnection.Close();

            dr.Dispose();
            comando.Dispose();
        }

        private void CarregarComboOuListDataDReDT()
        {
            listBox1.Items.Clear();
            cboNomesClientes.Items.Clear();

            SqlCommand comando = new SqlCommand("SELECT * FROM tbl_Cliente", sqlconnection);
            sqlconnection.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if(dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                cboNomesClientes.Items.Add("");
                foreach(DataRow linha in dt.Rows)
                {
                    cboNomesClientes.Items.Add(linha["DataNascimento"].ToString());
                    listBox1.Items.Add(linha["Nome"]+" "+linha["Sexo"]);
                }
            }
            else
                MessageBox.Show("Não Contem registros");
            sqlconnection.Close();
        }
        #endregion

        #region Buscando dados
        //Realizando busca pela lista e bd
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtNome.Text = listView1.SelectedItems[0].SubItems[1].Text;
            char sexo = char.Parse(listView1.SelectedItems[0].SubItems[2].Text);
            rdoFeminino.Checked = !(rdoMasculino.Checked = (sexo == 'M'));

            //como a data Nasc n exibe, realiza a busca somente dela no banco
            SqlCommand sqlcommand = new SqlCommand("SELECT DataNascimento FROM tbl_Cliente WHERE Id = "+txtId.Text, sqlconnection);
            sqlconnection.Open();
            DateTime data = (DateTime)sqlcommand.ExecuteScalar();
            dtpDataNascimento.Value = data;
            sqlconnection.Close();
        }

        //Capturando informaçoes da grid (sem bd)
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Util quando datagrid carrega todos campos que pretende buscar.
            txtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            char sexo = Convert.ToChar(dataGridView1.CurrentRow.Cells["Sexo"].Value);
            if(sexo == 'M')
                rdoMasculino.Checked = true;
            else
                rdoFeminino.Checked = true;

            dtpDataNascimento.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Data Nasc"].Value);
        }

        //busca pelo bd
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idLinha = (int)dataGridView2.CurrentRow.Cells["colId"].Value;
            Pesquisar(idLinha);
        }
        #endregion
    }
}

//CREATE DATABASE db_adonet
//GO
//USE db_adonet
//GO
//CREATE TABLE tbl_Cliente(
//    Id int IDENTITY(1,1) PRIMARY KEY,
//    Nome VARCHAR(50),
//    Sexo CHAR(1),
//    DataNascimento DATE 
//)
