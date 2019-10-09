using System;
using System.Windows.Forms;
using System.IO;

namespace InvetAuto
{
    public partial class ReportForms : Form
    {
        public ReportForms()
        {
            InitializeComponent();
        }

        private void ReportForms_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventAutoDataSet.Inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.inventAutoDataSet.Inventory);
        }

        private void DGV_To_Excel(DataGridView dataGridView1, string r_name, string tr_name)
        {
            char[] charsToTrim = {' '};    

            try
            {                      
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {

                    string temp_filename = $"{Application.StartupPath}"+tr_name;
                    string dest_filename; //= $"{Application.StartupPath}/report_present.xlsx";   
            
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        dest_filename = fbd.SelectedPath + r_name + DateTime.Now.ToShortDateString() + ".xlsx";                      
                    }
                    else
                    {
                        return;
                    }

                    FileInfo f1 = new FileInfo(temp_filename);
                    FileInfo f2 = new FileInfo(dest_filename);

                    try
                    {                      
                        if (File.Exists(dest_filename))
                        {
                            f2.Delete();
                        }
                        f1.CopyTo(dest_filename, true);
                    }
                    catch (IOException ioex)
                    {
                        MessageBox.Show(ioex.Message);
                    }

                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(dest_filename);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    //app.Visible = true;

                    worksheet = workbook.Sheets["Лист1"];
                    worksheet = workbook.ActiveSheet;

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                      {
                       for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                         if (dataGridView1.Rows[i].Cells[j].Value != null)
                          {
                           worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString().TrimEnd(charsToTrim);
                          }
                           else
                          {
                           worksheet.Cells[i + 2, j + 1] = "";
                          }
                         }
                       }
                    workbook.SaveAs(dest_filename);
                    app.Workbooks.Close();

                    DialogResult result = MessageBox.Show("Открыть отчет в EXCEL?", "Просмотр сформированного отчета", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            FileInfo fi = new FileInfo(dest_filename);
                            if (fi.Exists)
                            {
                               System.Diagnostics.Process.Start(dest_filename);
                            }
                            else
                            {
                                //file doesn't exist
                            }
                        }
                }             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Dispose();
        }

        private void ВыгрузитьВEXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == inventory_blank)
                DGV_To_Excel(dataGridView4, "\\Отчет. Инвентарь_", "/template_report_inventory.xlsx");
            else
                if (tabControl1.SelectedTab == present_page)
                DGV_To_Excel(dataGridView1, "\\Отчет. Присутствует_", "/template_report_present.xlsx");
            else
                if (tabControl1.SelectedTab == missing_page)
                DGV_To_Excel(dataGridView2, "\\Отчет. Отсутствует_", "/template_report_missing.xlsx");
            else
                DGV_To_Excel(dataGridView3, "\\Отчет. Сотрудники_", "/template_report_employees.xlsx");
        }

    }
}
