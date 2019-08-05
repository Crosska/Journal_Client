namespace Journal_Client
{
    partial class DatabaseEnterData
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
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textbox_personal_account = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listbox_FIO_adress = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagridtable_meter = new System.Windows.Forms.DataGridView();
            this.button_change = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridtable_meter)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(5, 345);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(127, 39);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(276, 345);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(127, 39);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // textbox_personal_account
            // 
            this.textbox_personal_account.Location = new System.Drawing.Point(115, 20);
            this.textbox_personal_account.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_personal_account.Name = "textbox_personal_account";
            this.textbox_personal_account.Size = new System.Drawing.Size(346, 24);
            this.textbox_personal_account.TabIndex = 2;
            this.textbox_personal_account.TextChanged += new System.EventHandler(this.personal_account_changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Лицевой счёт";
            // 
            // listbox_FIO_adress
            // 
            this.listbox_FIO_adress.FormattingEnabled = true;
            this.listbox_FIO_adress.ItemHeight = 17;
            this.listbox_FIO_adress.Location = new System.Drawing.Point(10, 70);
            this.listbox_FIO_adress.Name = "listbox_FIO_adress";
            this.listbox_FIO_adress.Size = new System.Drawing.Size(451, 310);
            this.listbox_FIO_adress.TabIndex = 4;
            this.listbox_FIO_adress.SelectedValueChanged += new System.EventHandler(this.personal_account_selected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textbox_personal_account);
            this.groupBox1.Controls.Add(this.listbox_FIO_adress);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 393);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск лицевого счета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выбор лицевого счёта";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagridtable_meter);
            this.groupBox2.Controls.Add(this.button_change);
            this.groupBox2.Controls.Add(this.button_delete);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Location = new System.Drawing.Point(485, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 393);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Показания по лицевому счёту";
            // 
            // datagridtable_meter
            // 
            this.datagridtable_meter.AllowUserToAddRows = false;
            this.datagridtable_meter.AllowUserToDeleteRows = false;
            this.datagridtable_meter.AllowUserToResizeColumns = false;
            this.datagridtable_meter.AllowUserToResizeRows = false;
            this.datagridtable_meter.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.datagridtable_meter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridtable_meter.GridColor = System.Drawing.SystemColors.HighlightText;
            this.datagridtable_meter.Location = new System.Drawing.Point(6, 23);
            this.datagridtable_meter.MultiSelect = false;
            this.datagridtable_meter.Name = "datagridtable_meter";
            this.datagridtable_meter.ReadOnly = true;
            this.datagridtable_meter.RowHeadersVisible = false;
            this.datagridtable_meter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.datagridtable_meter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.datagridtable_meter.Size = new System.Drawing.Size(397, 315);
            this.datagridtable_meter.TabIndex = 7;
            // 
            // button_change
            // 
            this.button_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_change.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_change.Location = new System.Drawing.Point(138, 345);
            this.button_change.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(132, 39);
            this.button_change.TabIndex = 6;
            this.button_change.Text = "Изменить";
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.Button_change_Click);
            // 
            // DatabaseEnterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatabaseEnterData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Внесение показаний";
            this.Load += new System.EventHandler(this.DatabaseEnterData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridtable_meter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textbox_personal_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listbox_FIO_adress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.DataGridView datagridtable_meter;
    }
}