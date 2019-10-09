using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace InvetAuto
{
    public partial class EditCatalog : Form
    {

        public EditCatalog()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Btn_invadd_Click(object sender, EventArgs e)
        {
            using (new WaitingManager())
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Inventory (Inv_Name, InvGroup_Name, Inv_Cost) VALUES ('" + txt_name.Text + "','" + cb_category.Text + "'," + txt_cost.Text + ")";
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();

                    this.inventoryTableAdapter.Fill(this.inventAutoDataSet1.Inventory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryGroupTableAdapter.Update(this.inventAutoDataSet1.InventoryGroup);
                this.inventoryGroupTableAdapter.Fill(this.inventAutoDataSet1.InventoryGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }


        private void Btn_invedit_Click(object sender, EventArgs e)
        {
            try {
                using (new WaitingManager())
                {
                    this.inventoryTableAdapter.Update(this.inventAutoDataSet1.Inventory);
                    this.inventoryTableAdapter.Fill(this.inventAutoDataSet1.Inventory);
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ЗагрузитьДанныеИзБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (new WaitingManager())
            {
                this.inventoryGroupTableAdapter.Fill(this.inventAutoDataSet1.InventoryGroup);
                this.unitTableAdapter.Fill(this.inventAutoDataSet1.Unit);
                this.inventoryTableAdapter.Fill(this.inventAutoDataSet1.Inventory);
            }
        }

        internal delegate void SetDataSourceDelegate(DataGridView dataGridView1);


        private void Cb_category_Click(object sender, EventArgs e)
        {

            if (inventoryGroupBindingSource.Count == 0)
            {
                using (new WaitingManager()) { this.inventoryGroupTableAdapter.Fill(this.inventAutoDataSet1.InventoryGroup); }
            }                                  
        }


        private void Btn_invdelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                    dataGridView1.Rows.RemoveAt(item.Index);
                this.inventoryTableAdapter.Update(this.inventAutoDataSet1.Inventory);
                this.inventoryTableAdapter.Fill(this.inventAutoDataSet1.Inventory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.unitTableAdapter.Update(this.inventAutoDataSet1.Unit);
            this.unitTableAdapter.Fill(this.inventAutoDataSet1.Unit);         
        }

        private void EditCatalog_Load(object sender, EventArgs e)
        {
            using (new WaitingManager())
            {
                this.inventoryGroupTableAdapter.Fill(this.inventAutoDataSet1.InventoryGroup);
                this.unitTableAdapter.Fill(this.inventAutoDataSet1.Unit);
                this.inventoryTableAdapter.Fill(this.inventAutoDataSet1.Inventory);
            }
        }
    }
}
