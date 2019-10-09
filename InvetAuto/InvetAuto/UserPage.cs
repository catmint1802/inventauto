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

namespace InvetAuto
{
    public partial class UserPage : Form
    {
        int surname_change = 0;
        int name_change = 0;
        int mn_change = 0;
        int unit_change = 0;
        int comment_change = 0;

        public UserPage()
        {
            InitializeComponent();
            this.unitTableAdapter.Fill(this.inventAutoDataSet.Unit);
            this.inventoryGroupTableAdapter.Fill(this.inventAutoDataSet.InventoryGroup);
            qr_invalidate();
            txt_Surname.Text = SQL_Select(@"SELECT RTrim(Emp_Surname) From Employees WHERE Emp_ID = '"+ emp.emp_id + "'");
            txt_Name.Text = SQL_Select(@"SELECT RTrim(Emp_Name) From Employees WHERE Emp_ID = '" + emp.emp_id + "'");
            txt_MN.Text = SQL_Select(@"SELECT RTrim(Emp_MN) From Employees WHERE Emp_ID = '" + emp.emp_id + "'");
            comboBox1.SelectedValue = SQL_Select(@"SELECT RTrim(Unit_Name) From Employees WHERE Emp_ID = '" + emp.emp_id + "'");
            txt_cab.Text = SQL_Select(@"SELECT Unit_Office From Unit WHERE Unit_Name = '" + comboBox1.SelectedValue + "'");
            txt_comment.Text = SQL_Select(@"SELECT RTrim(Emp_Comment) From Employees WHERE Emp_ID = '" + emp.emp_id + "'");
            list_load(@"SELECT Inv_Name FROM Inventory", 0);
            list_load(@"SELECT Inv_Name FROM Got WHERE Emp_ID = '" + emp.emp_id + "'", 1);
        }

        private void sql_IUD(string sql_query)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql_query;
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void list_load(string sql_query, int num_list)
        {
            try
            {
                
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql_query;
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                if(num_list == 0)
                {
                    list_allinven.Items.Clear();
                    while (rd.Read())                  
                        list_allinven.Items.Add(rd.GetString(0));
                    list_allinven.Update();
                }
                else
                {
                    while (rd.Read())
                        list_userinv.Items.Add(rd.GetString(0));
                }
                rd.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void qr_invalidate()
        {
            try
            {
                Bitmap img;
                img = new Bitmap(@"\\lipgipromez\SOFTWARE\inventauto\qr\QR(" + emp.emp_id + ").jpeg");
                this.pictureBox1.Size = img.Size;
                pictureBox1.Image = img;
                pictureBox1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public string SQL_Select(string cmd_text)
        {
            try
            {
                string tmp = "ERR";
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmd_text;
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                    tmp = rd.GetString(0);
                rd.Close();
                sqlConnection.Close();
                return tmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ex.StackTrace;
            }      
        }


        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_load(@"SELECT Inv_Name FROM Inventory WHERE InvGroup_Name = '" + comboBox2.Text + "'",0);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Unit_Office FROM Unit WHERE Unit_Name = '" + comboBox1.Text + "'";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                    txt_cab.Text = rd.GetString(0);
                rd.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void List_allinven_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list_allinven.SelectedItems.Count != 0)
                list_userinv.Items.Add(list_allinven.SelectedItem.ToString());
        }

        private void List_userinv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list_userinv.SelectedItems.Count != 0)
                list_userinv.Items.RemoveAt(list_userinv.SelectedIndex);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (surname_change == 1 || mn_change == 1 || name_change == 1 || unit_change == 1 || comment_change == 1)
                    sql_IUD(@"UPDATE Employees SET Unit_Name = '"+comboBox1.Text+"', Emp_Surname = '"+txt_Surname.Text+"', Emp_Name = '"+txt_Name.Text+"', Emp_MN = '"+txt_MN.Text+"', Emp_Comment = '"+txt_comment.Text+"' WHERE Emp_ID = '"+emp.emp_id+"'");
  
                sql_IUD(@"DELETE FROM Got Where Got.Emp_ID = '" + emp.emp_id + "'");

                foreach (var item in list_userinv.Items)
                {
                    sql_IUD(@"INSERT INTO Got(Inv_Name, Emp_ID) VALUES('" + item.ToString() + "', '" + emp.emp_id + "')");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Произошла ошибка при работе с базой данных. Дополнительная информация: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Данные успешно изменены");
            }
        }

        private void Txt_Surname_TextChanged(object sender, EventArgs e)
        {
            surname_change = 1;
        }

        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
            name_change = 1;
        }

        private void Txt_MN_TextChanged(object sender, EventArgs e)
        {
            mn_change = 1;
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            unit_change = 1;
        }

        private void Txt_comment_TextChanged(object sender, EventArgs e)
        {
            comment_change = 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
