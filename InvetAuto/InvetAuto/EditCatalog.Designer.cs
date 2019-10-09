namespace InvetAuto
{
    partial class EditCatalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.загрузитьДанныеИзБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invGroupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventAutoDataSet1 = new InvetAuto.InventAutoDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.inventoryGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_invedit = new System.Windows.Forms.Button();
            this.btn_invdelete = new System.Windows.Forms.Button();
            this.btn_invadd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.unitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitOfficeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitChiefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.invGroupNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryTableAdapter = new InvetAuto.InventAutoDataSet1TableAdapters.InventoryTableAdapter();
            this.unitTableAdapter = new InvetAuto.InventAutoDataSet1TableAdapters.UnitTableAdapter();
            this.inventoryGroupTableAdapter = new InvetAuto.InventAutoDataSet1TableAdapters.InventoryGroupTableAdapter();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventAutoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGroupBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(878, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьДанныеИзБДToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(290, 26);
            // 
            // загрузитьДанныеИзБДToolStripMenuItem
            // 
            this.загрузитьДанныеИзБДToolStripMenuItem.Name = "загрузитьДанныеИзБДToolStripMenuItem";
            this.загрузитьДанныеИзБДToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.загрузитьДанныеИзБДToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.загрузитьДанныеИзБДToolStripMenuItem.Text = "Загрузить данные из БД / Обновить";
            this.загрузитьДанныеИзБДToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьДанныеИзБДToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.btn_invedit);
            this.tabPage1.Controls.Add(this.btn_invdelete);
            this.tabPage1.Controls.Add(this.btn_invadd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(870, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Инвентарь";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txt_cost);
            this.splitContainer1.Panel2.Controls.Add(this.txt_name);
            this.splitContainer1.Panel2.Controls.Add(this.cb_category);
            this.splitContainer1.Size = new System.Drawing.Size(778, 487);
            this.splitContainer1.SplitterDistance = 434;
            this.splitContainer1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invNameDataGridViewTextBoxColumn,
            this.invGroupNameDataGridViewTextBoxColumn,
            this.invCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // invNameDataGridViewTextBoxColumn
            // 
            this.invNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.invNameDataGridViewTextBoxColumn.DataPropertyName = "Inv_Name";
            this.invNameDataGridViewTextBoxColumn.HeaderText = "Наименование инвентаря";
            this.invNameDataGridViewTextBoxColumn.Name = "invNameDataGridViewTextBoxColumn";
            // 
            // invGroupNameDataGridViewTextBoxColumn
            // 
            this.invGroupNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.invGroupNameDataGridViewTextBoxColumn.DataPropertyName = "InvGroup_Name";
            this.invGroupNameDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.invGroupNameDataGridViewTextBoxColumn.Name = "invGroupNameDataGridViewTextBoxColumn";
            // 
            // invCostDataGridViewTextBoxColumn
            // 
            this.invCostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.invCostDataGridViewTextBoxColumn.DataPropertyName = "Inv_Cost";
            this.invCostDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.invCostDataGridViewTextBoxColumn.Name = "invCostDataGridViewTextBoxColumn";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.inventAutoDataSet1;
            // 
            // inventAutoDataSet1
            // 
            this.inventAutoDataSet1.DataSetName = "InventAutoDataSet1";
            this.inventAutoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Стоимость в рублях";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Категория";
            // 
            // txt_cost
            // 
            this.txt_cost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_cost.Location = new System.Drawing.Point(30, 173);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(281, 24);
            this.txt_cost.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_name.Location = new System.Drawing.Point(30, 108);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(281, 24);
            this.txt_name.TabIndex = 1;
            // 
            // cb_category
            // 
            this.cb_category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_category.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cb_category.DataSource = this.inventoryGroupBindingSource;
            this.cb_category.DisplayMember = "InvGroup_Name";
            this.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cb_category.Location = new System.Drawing.Point(30, 44);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(281, 26);
            this.cb_category.TabIndex = 0;
            this.cb_category.ValueMember = "InvGroup_Name";
            this.cb_category.Click += new System.EventHandler(this.Cb_category_Click);
            // 
            // inventoryGroupBindingSource
            // 
            this.inventoryGroupBindingSource.DataMember = "InventoryGroup";
            this.inventoryGroupBindingSource.DataSource = this.inventAutoDataSet1;
            // 
            // btn_invedit
            // 
            this.btn_invedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_invedit.Location = new System.Drawing.Point(787, 44);
            this.btn_invedit.Name = "btn_invedit";
            this.btn_invedit.Size = new System.Drawing.Size(75, 23);
            this.btn_invedit.TabIndex = 5;
            this.btn_invedit.Text = "Изменить";
            this.btn_invedit.UseVisualStyleBackColor = true;
            this.btn_invedit.Click += new System.EventHandler(this.Btn_invedit_Click);
            // 
            // btn_invdelete
            // 
            this.btn_invdelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_invdelete.BackColor = System.Drawing.Color.LightCoral;
            this.btn_invdelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_invdelete.Location = new System.Drawing.Point(787, 110);
            this.btn_invdelete.Name = "btn_invdelete";
            this.btn_invdelete.Size = new System.Drawing.Size(75, 23);
            this.btn_invdelete.TabIndex = 7;
            this.btn_invdelete.Text = "Удалить";
            this.btn_invdelete.UseVisualStyleBackColor = false;
            this.btn_invdelete.Click += new System.EventHandler(this.Btn_invdelete_Click);
            // 
            // btn_invadd
            // 
            this.btn_invadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_invadd.Location = new System.Drawing.Point(787, 15);
            this.btn_invadd.Name = "btn_invadd";
            this.btn_invadd.Size = new System.Drawing.Size(75, 23);
            this.btn_invadd.TabIndex = 4;
            this.btn_invadd.Text = "Добавить";
            this.btn_invadd.UseVisualStyleBackColor = true;
            this.btn_invadd.Click += new System.EventHandler(this.Btn_invadd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(870, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отделы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(784, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Применить  изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitNameDataGridViewTextBoxColumn,
            this.unitOfficeDataGridViewTextBoxColumn,
            this.unitChiefDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.unitBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(780, 488);
            this.dataGridView2.TabIndex = 0;
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            this.unitNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitNameDataGridViewTextBoxColumn.DataPropertyName = "Unit_Name";
            this.unitNameDataGridViewTextBoxColumn.HeaderText = "Наименование отдела/группы";
            this.unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            // 
            // unitOfficeDataGridViewTextBoxColumn
            // 
            this.unitOfficeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitOfficeDataGridViewTextBoxColumn.DataPropertyName = "Unit_Office";
            this.unitOfficeDataGridViewTextBoxColumn.HeaderText = "Кабинет";
            this.unitOfficeDataGridViewTextBoxColumn.Name = "unitOfficeDataGridViewTextBoxColumn";
            // 
            // unitChiefDataGridViewTextBoxColumn
            // 
            this.unitChiefDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitChiefDataGridViewTextBoxColumn.DataPropertyName = "Unit_Chief";
            this.unitChiefDataGridViewTextBoxColumn.HeaderText = "Руководитель";
            this.unitChiefDataGridViewTextBoxColumn.Name = "unitChiefDataGridViewTextBoxColumn";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.inventAutoDataSet1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(870, 489);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Категории";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(784, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 50);
            this.button4.TabIndex = 1;
            this.button4.Text = "Применить  изменения";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invGroupNameDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.inventoryGroupBindingSource;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView3.Location = new System.Drawing.Point(1, 1);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(780, 488);
            this.dataGridView3.TabIndex = 0;
            // 
            // invGroupNameDataGridViewTextBoxColumn1
            // 
            this.invGroupNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.invGroupNameDataGridViewTextBoxColumn1.DataPropertyName = "InvGroup_Name";
            this.invGroupNameDataGridViewTextBoxColumn1.HeaderText = "Название категории";
            this.invGroupNameDataGridViewTextBoxColumn1.Name = "invGroupNameDataGridViewTextBoxColumn1";
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryGroupTableAdapter
            // 
            this.inventoryGroupTableAdapter.ClearBeforeFill = true;
            // 
            // EditCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "EditCatalog";
            this.Text = "Справочники";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditCatalog_Load);
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventAutoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGroupBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_invedit;
        private System.Windows.Forms.Button btn_invdelete;
        private System.Windows.Forms.Button btn_invadd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.DataGridView dataGridView1;
        private InventAutoDataSet1 inventAutoDataSet1;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private InventAutoDataSet1TableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private InventAutoDataSet1TableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.BindingSource inventoryGroupBindingSource;
        private InventAutoDataSet1TableAdapters.InventoryGroupTableAdapter inventoryGroupTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invGroupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitOfficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitChiefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invGroupNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеИзБДToolStripMenuItem;
    }
}