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
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;



namespace InvetAuto
{
    public partial class CreateNew : Form
    {       
        public CreateNew()
        {
            InitializeComponent();        
            button3.Visible = false;
        }

        private void createQR()
        {
            try
            {
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };

                encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                barcodeWriter.Renderer = new BitmapRenderer();
                barcodeWriter.Options = encodingOptions;
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                Bitmap bitmap = barcodeWriter.Write(txt_ID.Text);
                Bitmap logo = new Bitmap($"{Application.StartupPath}/logo.png");
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
                pb_QR.Image = bitmap;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при генерации QR-кода. Допольнительная информация: " + ex.Message);
            }          
        }
        private void saveQR()
        {
            try
            {
                pb_QR.Image.Save(@"\\lipgipromez\SOFTWARE\inventauto\qr\QR(" + txt_ID.Text + ").jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + @"\\lipgipromez\SOFTWARE\inventauto\qr\QR(" + txt_ID.Text + ").jpeg");
            }
        }

        private void check_employees()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(Emp_ID) FROM Employees WHERE Emp_ID = '" + txt_ID.Text + "'";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            //cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd.GetInt32(0) == 0)
                {
                    emp.status = 0;
                }
                else
                {                   
                    button3.Visible = true;
                    label8.Visible = false;
                    label9.Visible = false;
                    MessageBox.Show("Предупреждение! \n Данное рабочее место уже заведено!");
                    emp.status = 3;
                    this.TopMost = false;
                    Emp_desicion ed = new Emp_desicion();
                    ed.ShowDialog();
                }
            }
            rd.Close();
            sqlConnection.Close();
        }
        private void Txt_createQR_Click(object sender, EventArgs e)
        {
            createQR();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(new Bitmap(pb_QR.Image));
            if (result != null)
                txt_check_id.Text = result.Text;
            if (result.Text == txt_ID.Text)
                checkBox_QR.Checked = true;
        }

        private void list_load(string categoryname)
        {
            using (new WaitingManager())
            {
                try
                {
                    list_allinven.Items.Clear();
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT I.Inv_Name FROM Inventory as I WHERE I.InvGroup_Name = '"+ categoryname +"'";
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    //cmd.ExecuteNonQuery();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        list_allinven.Items.Add(rd.GetString(0));
                    }                    
                    list_allinven.Update();
                    rd.Close();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CreateNew_Load(object sender, EventArgs e)
        {
            using (new WaitingManager())
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "inventAutoDataSet1.Unit". При необходимости она может быть перемещена или удалена.
                this.unitTableAdapter.Fill(this.inventAutoDataSet1.Unit);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "inventAutoDataSet1.Employees". При необходимости она может быть перемещена или удалена.
                this.employeesTableAdapter.Fill(this.inventAutoDataSet1.Employees);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "inventAutoDataSet1.InventoryGroup". При необходимости она может быть перемещена или удалена.
                this.inventoryGroupTableAdapter.Fill(this.inventAutoDataSet1.InventoryGroup);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "inventAutoDataSet1.Inventory". При необходимости она может быть перемещена или удалена.
                this.inventoryTableAdapter.Fill(this.inventAutoDataSet1.Inventory);               
            }
            Activate();
        }

        private void Cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_load(cb_category.Text);
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (new WaitingManager())
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Unit_Office FROM Unit WHERE Unit_Name = '"+ comboBox2.Text +"'";
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    //cmd.ExecuteNonQuery();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while(rd.Read())
                    txt_cab.Text = rd.GetString(0);
                    rd.Close();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (list_allinven.SelectedItems.Count != 0)
                list_userinven.Items.Add(list_allinven.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void List_allinven_DoubleClick(object sender, EventArgs e)
        {
            if (list_allinven.SelectedItems.Count != 0)
                list_userinven.Items.Add(list_allinven.SelectedItem.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(list_userinven.SelectedItems.Count != 0)
               list_userinven.Items.RemoveAt(list_userinven.SelectedIndex);
        }

        private void List_userinven_DoubleClick(object sender, EventArgs e)
        {
            if (list_userinven.SelectedItems.Count != 0)
                list_userinven.Items.RemoveAt(list_userinven.SelectedIndex);
        }

       

        private void Btn_createData_Click(object sender, EventArgs e)
        {
            if (emp.status == 0)
            {
                try
                {
                    //если = 0
                    string qr_path = @"\\lipgipromez\SOFTWARE\inventauto\qr\QR(" + txt_ID.Text + ").jpeg";
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    cmd.CommandText = "INSERT INTO Employees (Emp_ID, Unit_Name, Emp_Surname, Emp_Name, Emp_MN, Emp_Comment, Emp_QR) VALUES ('" + txt_ID.Text + "','" + comboBox2.Text + "','" + txt_surname.Text + "','" + txt_name.Text + "','" + txt_mn.Text + "','" + txt_comment.Text + "','" + qr_path + "')";
                    cmd.ExecuteNonQuery();
                    foreach (var item in list_userinven.Items)
                    {
                        cmd.CommandText = "INSERT INTO Got (Inv_Name, Emp_ID) VALUES ('" + item.ToString() + "','" + txt_ID.Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    saveQR();
                    MessageBox.Show("Запись успешо создана.");
                }
            }
            else
            {
                if(emp.status == 1)
                {
                    MessageBox.Show("В разработке...");
                }
                else
                {
                    if(emp.status == 2)
                    {
                        MessageBox.Show("В разработке...");
                    }
                    else
                    {
                        if (emp.status == 3)
                        {
                            try
                            {
                                SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True");
                                SqlCommand cmd = new SqlCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "UPDATE Employees SET Unit_Name = '" + comboBox2.Text + "', Emp_Surname = '" + txt_surname.Text + "', Emp_Name = '" + txt_name.Text + "', Emp_MN = '" + txt_mn.Text + "' WHERE Emp_ID = '" + txt_ID.Text + "'";
                                cmd.Connection = sqlConnection;
                                sqlConnection.Open();
                                cmd.ExecuteNonQuery();
                                sqlConnection.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                MessageBox.Show("Status: 3. \n Данные успешно обновлены!");
                            }
                        }
                    }

                }
            }
        }

        private void Txt_ID_Leave(object sender, EventArgs e)
        {
            button3.Visible = false;
            label8.Visible = true;
            label9.Visible = true;
           
            try
            {
                createQR();
                ///-- Проверка записей в БД --/// 
                check_employees();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            Emp_desicion ed = new Emp_desicion();
            ed.ShowDialog();
        }
    }
}
