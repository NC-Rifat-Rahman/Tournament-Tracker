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
    public partial class API_People : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-48L2081;initial Catalog=Tournaments;Integrated Security=True;");
        int id = 0;
        public API_People()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", id);
                param.Add("@FirstName", firstNametextBox.Text.Trim());
                param.Add("@LastName", LastNametextBox.Text.Trim());
                param.Add("@EmailAddress", emailAddresstextBox.Text.Trim());
                param.Add("@CellphoneNumber", cellphoneNumbertextBox.Text.Trim());

                sqlCon.Execute("apiPeopleAddOrEdit", param, commandType: CommandType.StoredProcedure);
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

            List<PersonModel> list = sqlCon.Query<PersonModel>("apiPeopleViewAllOrSearch", param, commandType:
                CommandType.StoredProcedure).ToList();

            dgvContact.DataSource = list;
            dgvContact.Columns[0].Visible = false;
        }
        void Clear()
        {
            firstNametextBox.Text = LastNametextBox.Text = emailAddresstextBox.Text = cellphoneNumbertextBox.Text = "";
            id = 0;
            savebutton.Text = "Save";
            deletebutton.Enabled = false;
        }

        private void API_People_Load(object sender, EventArgs e)
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

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvContact_DoubleClick_1(object sender, EventArgs e)
        {

            try
            {
                id = Convert.ToInt32(dgvContact.CurrentRow.Cells[0].Value.ToString());
                firstNametextBox.Text = dgvContact.CurrentRow.Cells[1].Value.ToString();
                LastNametextBox.Text = dgvContact.CurrentRow.Cells[2].Value.ToString();
                emailAddresstextBox.Text = dgvContact.CurrentRow.Cells[3].Value.ToString();
                cellphoneNumbertextBox.Text = dgvContact.CurrentRow.Cells[3].Value.ToString();
                deletebutton.Enabled = true;
                savebutton.Text = "Edit";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", id);
                sqlCon.Execute("apiPeopleDeleteByID", param, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Deleted Succesfully");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

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
