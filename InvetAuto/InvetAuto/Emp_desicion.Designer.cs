namespace InvetAuto
{
    partial class Emp_desicion
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
            this.btn_transfer = new System.Windows.Forms.Button();
            this.btn_relocation = new System.Windows.Forms.Button();
            this.btn_fired = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_transfer
            // 
            this.btn_transfer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_transfer.Location = new System.Drawing.Point(32, 115);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(161, 65);
            this.btn_transfer.TabIndex = 0;
            this.btn_transfer.Text = "Обмен рабочими местами.";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.Btn_transfer_Click);
            // 
            // btn_relocation
            // 
            this.btn_relocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_relocation.Location = new System.Drawing.Point(224, 115);
            this.btn_relocation.Name = "btn_relocation";
            this.btn_relocation.Size = new System.Drawing.Size(161, 65);
            this.btn_relocation.TabIndex = 0;
            this.btn_relocation.Text = "Переезд на другое рабочее место.";
            this.btn_relocation.UseVisualStyleBackColor = true;
            this.btn_relocation.Click += new System.EventHandler(this.Btn_relocation_Click);
            // 
            // btn_fired
            // 
            this.btn_fired.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fired.Location = new System.Drawing.Point(415, 115);
            this.btn_fired.Name = "btn_fired";
            this.btn_fired.Size = new System.Drawing.Size(161, 65);
            this.btn_fired.TabIndex = 0;
            this.btn_fired.Text = "Прошлый владелец рабочего места больше здесь не работает.";
            this.btn_fired.UseVisualStyleBackColor = true;
            this.btn_fired.Click += new System.EventHandler(this.Btn_fired_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Запись о данном рабочем месте уже существует. Выберите подходящую ситуацию.\r\n";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1. Сотрудники обменялись рабочими местами в рамках одного рабочего места.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2. Сотрудники обменялись рабочими местами в рамках разных кабинетов.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(544, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "3. Старая запись неактуальна. Сотрудник больше здесь не работает. У рабочего мест" +
    "а новый владелец.";
            // 
            // Emp_desicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 204);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fired);
            this.Controls.Add(this.btn_relocation);
            this.Controls.Add(this.btn_transfer);
            this.Name = "Emp_desicion";
            this.Text = "Решаем вопрос  [В разработке]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.Button btn_relocation;
        private System.Windows.Forms.Button btn_fired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}