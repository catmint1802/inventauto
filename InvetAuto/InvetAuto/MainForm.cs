using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InvetAuto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            using (new WaitingManager())
            {
                var root = new TreeNode() { Text = "Отделы и группы", Tag = "Отделы и группы" };
                tree_unit.Nodes.Add(root);
                Build(root, 0);
                root.Expand();
            }
            this.Activate();
            tree_unit.Sort();
            string select = "SELECT * FROM GOT";
            info_build(select);          
        }

        private void Build(TreeNode parent, int marker) //0 - построение, 1 - дети
        {
            var path = parent.Tag as string;
            parent.Nodes.Clear(); //перестроение дерева с нуля         
            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                if (marker == 0) cmd.CommandText = "SELECT RTrim(Unit_Name) FROM Unit";
                else cmd.CommandText = "SELECT CONCAT(RTrim(Emp_Surname),' ',RTrim(Emp_Name),' ',RTrim(Emp_MN)) FROM Employees WHERE  Unit_Name = '" + path + "'";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (marker == 0)
                {
                    while (rd.Read())
                        parent.Nodes.Add(new TreeNode(rd.GetString(0), new[] { new TreeNode("...") }) { Tag = rd.GetString(0) });
                }
                else
                {
                    while (rd.Read())
                        parent.Nodes.Add(new TreeNode(rd.GetString(0), 1, 1) { Tag = rd.GetString(0) });
                }
                sqlConnection.Close();
            }
            catch
            {
                //oops, no access...               
            }
        }

        private void СоздатьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Minimized;
            CreateNew f1 = new CreateNew();
            f1.ShowDialog();
            f1.Activate();
        }

        private void ПросмотрИРедакцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            EditCatalog e1 = new EditCatalog();
            e1.ShowDialog();

        }

        private void Tree_unit_AfterExpand_1(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Отделы и группы")
                Build(e.Node, 0);
            else
                Build(e.Node, 1);
        }

        private void ОбновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree_unit.Nodes.Clear();
            var root = new TreeNode() { Text = "Отделы и группы", Tag = "Отделы и группы" };
            tree_unit.Nodes.Add(root);
            Build(root, 0);
            root.Expand();
        }

        private void Tree_unit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tree_unit.SelectedNode.Level == 2)
            {
                string FIO = tree_unit.SelectedNode.Tag.ToString();
                select_sql(@"SELECT Emp_ID FROM Employees WHERE  CONCAT(RTrim(Emp_Surname),' ',RTrim(Emp_Name),' ',RTrim(Emp_MN)) = '" + FIO + "'");
                UserPage up = new UserPage();
                up.ShowDialog();
            }
        }

        private void info_build(string select)
        {
            try
            {
                var c = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True"); // 
                var dataAdapter = new SqlDataAdapter(select, c);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void select_sql(string cmd_st)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIPGIPROMEZ\PROJECTMANAGER;Initial Catalog=InventAuto;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmd_st;
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                    emp.emp_id = rd.GetString(0);
                rd.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void РедактироватьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FIO = tree_unit.SelectedNode.Tag.ToString();
            select_sql(@"SELECT Emp_ID FROM Employees WHERE  CONCAT(RTrim(Emp_Surname),' ',RTrim(Emp_Name),' ',RTrim(Emp_MN)) = '" + FIO + "'");
            UserPage up = new UserPage();
            up.ShowDialog();
        }

        private void Tree_unit_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tree_unit.SelectedNode.Level == 2)
            {
                var select = @"SELECT * FROM GOT WHERE (SELECT Emp_ID From Employees Where CONCAT(RTrim(Emp_Surname),' ',RTrim(Emp_Name),' ',RTrim(Emp_MN)) = '" + tree_unit.SelectedNode.Text + "') = Got.Emp_ID";
                info_build(select);
            }
            else
            {
                if (tree_unit.SelectedNode.Level == 1)
                {
                    string select = @"SELECT E.Emp_ID as 'ID', G.Inv_Name as 'Наименование', G.InventoruNumber as 'Инвентаризационный номер', CONCAT(RTrim(Emp_Surname),' ',RTrim(Emp_Name),' ',RTrim(Emp_MN)) as 'ФИО' FROM Employees as E INNER JOIN Got as G ON E.Emp_ID = G.Emp_ID WHERE E.Unit_Name = '" + tree_unit.SelectedNode.Text + "'";
                    info_build(select);
                }
                else
                {
                    string select = "SELECT * FROM GOT";
                    info_build(select);
                }
            }
        }

        private void ОтчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForms r = new ReportForms();
            r.ShowDialog();
        }
    }
}
