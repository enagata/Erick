using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;


namespace Erick
{
    public partial class Form1 : Form
    {

        private static SQLiteConnection conn;

        public Form1()
        {
            InitializeComponent();
            if (System.IO.File.Exists(@"C:\sqlite3\acme.sqlite"))
            {
                conn = new SQLiteConnection("Data Source=C:\\sqlite3\\acme.sqlite; Version=3");
                conn.Open();
            }
            else
            {
                SQLiteConnection.CreateFile(@"C:\sqlite3\acme.sqlite");
                conn = new SQLiteConnection("Data Source=C:\\sqlite3\\acme.sqlite; Version=3");
                conn.Open();
                try
                {
                    using (var cmd = conn.CreateCommand())
                    {
                    
                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS TB_VOO(ID_VOO INT PRIMARY KEY, DATA_VOO DATETIME NOT NULL, CUSTO NUMERIC(10,2), DISTANCIA INT, CAPTURA CHAR(1), NIVEL_DOR INT)";
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            Carregalist(conn);
            conn.Close();
        }

        private void Carregalist(SQLiteConnection conn)
        {
            lstDados.Items.Clear();
            lstDados.Columns.Clear();
            
            this.lstDados.Columns.Add("Data", -2);
            this.lstDados.Columns.Add("Captura", -2);
            this.lstDados.Columns.Add("Nivel de dor", -2);
            this.lstDados.Columns.Add("ID", -2);
            this.lstDados.Columns[3].Width = 0;
            this.lstDados.Columns[0].Width = 120;
            SQLiteDataReader dr = null;
            try
            {
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "Select ID_VOO, strftime('%d/%m/%Y',DATA_VOO), CAPTURA, NIVEL_DOR from TB_VOO";
                    dr = cmd.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        ListViewItem ls = new ListViewItem(dr[1].ToString());
                        ls.SubItems.Add(dr[2].ToString());
                        ls.SubItems.Add(dr[3].ToString());
                        ls.SubItems.Add(dr[0].ToString());
                        lstDados.Items.Add(ls);
                        
                    }
                    dr.Close();
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            SQLiteDataReader dr = null;
            conn = new SQLiteConnection("Data Source=C:\\sqlite3\\acme.sqlite; Version=3");
            conn.Open();
            int id = 0;
            ListView.SelectedListViewItemCollection seleDado = this.lstDados.SelectedItems;
            foreach (ListViewItem item in seleDado)
            {
                id = int.Parse(item.SubItems[3].Text);
            }
            try
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Select ID_VOO, strftime('%d/%m/%Y',DATA_VOO), CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR from TB_VOO WHERE ID_VOO =" + id;
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        txtdata.Text = dr[1].ToString();
                        txtcusto.Text = dr[2].ToString().Replace('.',',');
                        txtdist.Text = dr[3].ToString();
                        if (dr[4].ToString() == "n")
                        {
                            rbNao.Checked = true;
                        }
                        if (dr[4].ToString() == "s")
                        {
                            rbSim.Checked = true;
                        }
                        cbDor.SelectedIndex = cbDor.FindStringExact(dr[5].ToString());
                        lblId.Text = dr[0].ToString();
                    }
                    dr.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtdata.Text = "";
            txtcusto.Text = "";
            txtdist.Text = "";
            rbNao.Checked = false;
            rbSim.Checked = false;
            cbDor.SelectedItem = "";
            lblId.Text = "";
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            conn = new SQLiteConnection("Data Source=C:\\sqlite3\\acme.sqlite; Version=3");
            conn.Open();
            Carregalist(conn);
            conn.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            txtdata.Text = "";
            txtcusto.Text = "";
            txtdist.Text = "";
            lblId.Text = "";
            rbNao.Checked = false;
            rbSim.Checked = false;
            cbDor.Text = "";
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=C:\\sqlite3\\acme.sqlite; Version=3");
            conn.Open();
            if (lblId.Text != "")
            {
                int Id = int.Parse(lblId.Text);
            
                
                try
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM TB_VOO Where ID_VOO=@Id";
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Excluído com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nenhum Voô Selecionado. Tente novamente");
            }
            txtdata.Text = "";
            txtcusto.Text = "";
            txtdist.Text = "";
            rbNao.Checked = false;
            rbSim.Checked = false;
            cbDor.Text = "";
            lblId.Text = "";
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            Carregalist(conn);
            conn.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=C:\\sqlite3\\acme.sqlite; Version=3");
            conn.Open();
            string data = txtdata.Text;
            DateTime dataat = Convert.ToDateTime(data);
            String dataat2 = dataat.Year.ToString() + "-" + dataat.Month.ToString() + "-" + dataat.Day.ToString() + " 00:00:00";
            string custo = txtcusto.Text.Replace(',','.').Replace("R$","");
            string dist = txtdist.Text;
            char captura = ' ';
            if (rbNao.Checked == true)
            {
                captura = 'n';
            }
            if (rbSim.Checked == true)
            {
                captura = 's';
            }
            string dor = cbDor.SelectedItem.ToString();
            
            if (lblId.Text == "")
            {
                try
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO TB_VOO(ID_VOO, DATA_VOO, CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR) values ((SELECT CASE WHEN (SELECT MAX(ID_VOO)+1 FROM TB_VOO) IS NULL THEN 1 ELSE (SELECT MAX(ID_VOO)+1 FROM TB_VOO) END AS ID_VOO), @data, @custo, @dist, @captura, @dor)";
                        cmd.Parameters.AddWithValue("@data", dataat2);
                        cmd.Parameters.AddWithValue("@custo", custo);
                        cmd.Parameters.AddWithValue("@dist", dist);
                        cmd.Parameters.AddWithValue("@captura", captura.ToString());
                        cmd.Parameters.AddWithValue("@dor", dor);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Incluído com sucesso");
                    txtdata.Text = "";
                    txtcusto.Text = "";
                    txtdist.Text = "";
                    rbNao.Checked = false;
                    rbSim.Checked = false;
                    cbDor.SelectedItem = "";
                    lblId.Text = "";
                    btnExcluir.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    int id = int.Parse(lblId.Text);
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE TB_VOO SET DATA_VOO=@data, CUSTO=@custo, DISTANCIA=@dist, CAPTURA=@captura, NIVEL_DOR=@dor WHERE ID_VOO=@Id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@data", dataat2);
                        cmd.Parameters.AddWithValue("@custo", custo);
                        cmd.Parameters.AddWithValue("@dist", dist);
                        cmd.Parameters.AddWithValue("@captura", captura.ToString());
                        cmd.Parameters.AddWithValue("@dor", dor);
                        cmd.ExecuteNonQuery();
                    };
                    MessageBox.Show("Atualizado com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Carregalist(conn);
            conn.Close();
        }
    }
}
