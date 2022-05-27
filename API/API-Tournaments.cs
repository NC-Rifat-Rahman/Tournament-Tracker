using Dapper;
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
using TournamentTracker;

namespace API
{
    public partial class API_Tournaments : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-48L2081;initial Catalog=Tournaments;Integrated Security=True;");
        int id = 0;
        public API_Tournaments()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", id);
                param.Add("@TournamentName", tournamentNametextBox.Text.Trim());
                param.Add("@EntryFee", entryFeetextBox.Text.Trim());

                sqlCon.Execute("apiTournamentAddOrEdit", param, commandType: CommandType.StoredProcedure);
                if (id == 0)
                    MessageBox.Show("Saved Successfully");
                else
                    MessageBox.Show("Updated Successfully");
                FillDataGridView();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        void FillDataGridView()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SearchText", searchtextBox.Text.Trim());

            List<TournamentModel> list = sqlCon.Query<TournamentModel>("apiTournamnetViewAllOrSearch", param, commandType:
                CommandType.StoredProcedure).ToList();

            dgvTournamnet.DataSource = list;
            dgvTournamnet.Columns[0].Visible = false;
        }
        void Clear()
        {
            tournamentNametextBox.Text = entryFeetextBox.Text = "";
            id = 0;
            savebutton.Text = "Save";
            deletebutton.Enabled = false;
        }

        private void API_Tournaments_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTournamnet_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvTournamnet.CurrentRow.Cells[0].Value.ToString());
                tournamentNametextBox.Text = dgvTournamnet.CurrentRow.Cells[1].Value.ToString();
                entryFeetextBox.Text = dgvTournamnet.CurrentRow.Cells[2].Value.ToString();
                deletebutton.Enabled = true;
                savebutton.Text = "Edit";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", id);
                sqlCon.Execute("apiTournamnetDeleteByID", param, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Deleted Succesfully");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
