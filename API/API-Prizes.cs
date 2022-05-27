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
    public partial class API_Prizes : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-48L2081;initial Catalog=Tournaments;Integrated Security=True;");
        int id = 0;
        public API_Prizes()
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
                param.Add("@PlaceNumber", placeNumbertextBox.Text.Trim());
                param.Add("@PlaceName", placeNametextBox.Text.Trim());
                param.Add("@PrizeAmount", prizeAmounttextBox.Text.Trim());
                param.Add("@PrizePercentage", pricePercentagetextBox.Text.Trim());

                sqlCon.Execute("apiPrizeAddOrEdit", param, commandType: CommandType.StoredProcedure);
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

            List<PrizeModel> list = sqlCon.Query<PrizeModel>("apiPrizeViewAllOrSearch", param, commandType:
                CommandType.StoredProcedure).ToList();

            dgvPrice.DataSource = list;
            dgvPrice.Columns[0].Visible = false;
        }

        void Clear()
        {
            placeNumbertextBox.Text = placeNametextBox.Text = prizeAmounttextBox.Text = pricePercentagetextBox.Text = "";
            id = 0;
            savebutton.Text = "Save";
            deletebutton.Enabled = false;
        }

        private void API_Prizes_Load(object sender, EventArgs e)
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

        private void searchbutton_Click(object sender, EventArgs e)
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

        private void dgvPrice_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dgvPrice.CurrentRow.Cells[0].Value.ToString());
                placeNumbertextBox.Text = dgvPrice.CurrentRow.Cells[1].Value.ToString();
                placeNametextBox.Text = dgvPrice.CurrentRow.Cells[2].Value.ToString();
                prizeAmounttextBox.Text = dgvPrice.CurrentRow.Cells[3].Value.ToString();
                pricePercentagetextBox.Text = dgvPrice.CurrentRow.Cells[3].Value.ToString();
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
                sqlCon.Execute("apiPrizeDeleteByID", param, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Deleted Succesfully");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
