namespace Journal_Client
{
    partial class DatabaseJournalAllReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseJournalAllReg));
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobutton_date_obhoda = new System.Windows.Forms.RadioButton();
            this.radiobutton_all = new System.Windows.Forms.RadioButton();
            this.radiobutton_fio = new System.Windows.Forms.RadioButton();
            this.radiobutton_personal_account = new System.Windows.Forms.RadioButton();
            this.radiobutton_date = new System.Windows.Forms.RadioButton();
            this.button_do_select = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.combobox_fio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combobox_personal_account = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_сalendar = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.datetime_show = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            this.datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.datagridview.Location = new System.Drawing.Point(245, 16);
            this.datagridview.Margin = new System.Windows.Forms.Padding(4);
            this.datagridview.Name = "datagridview";
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.Size = new System.Drawing.Size(740, 514);
            this.datagridview.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobutton_date_obhoda);
            this.groupBox1.Controls.Add(this.radiobutton_all);
            this.groupBox1.Controls.Add(this.radiobutton_fio);
            this.groupBox1.Controls.Add(this.radiobutton_personal_account);
            this.groupBox1.Controls.Add(this.radiobutton_date);
            this.groupBox1.Location = new System.Drawing.Point(24, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(197, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выборка по";
            // 
            // radiobutton_date_obhoda
            // 
            this.radiobutton_date_obhoda.AutoSize = true;
            this.radiobutton_date_obhoda.Location = new System.Drawing.Point(8, 53);
            this.radiobutton_date_obhoda.Margin = new System.Windows.Forms.Padding(4);
            this.radiobutton_date_obhoda.Name = "radiobutton_date_obhoda";
            this.radiobutton_date_obhoda.Size = new System.Drawing.Size(113, 21);
            this.radiobutton_date_obhoda.TabIndex = 4;
            this.radiobutton_date_obhoda.Text = "Дата обхода";
            this.radiobutton_date_obhoda.UseVisualStyleBackColor = true;
            this.radiobutton_date_obhoda.CheckedChanged += new System.EventHandler(this.Radiobutton_date_obhoda_CheckedChanged);
            // 
            // radiobutton_all
            // 
            this.radiobutton_all.AutoSize = true;
            this.radiobutton_all.Location = new System.Drawing.Point(9, 140);
            this.radiobutton_all.Margin = new System.Windows.Forms.Padding(4);
            this.radiobutton_all.Name = "radiobutton_all";
            this.radiobutton_all.Size = new System.Drawing.Size(75, 21);
            this.radiobutton_all.TabIndex = 3;
            this.radiobutton_all.Text = "Общее";
            this.radiobutton_all.UseVisualStyleBackColor = true;
            this.radiobutton_all.CheckedChanged += new System.EventHandler(this.Radiobutton_all_CheckedChanged);
            // 
            // radiobutton_fio
            // 
            this.radiobutton_fio.AutoSize = true;
            this.radiobutton_fio.Location = new System.Drawing.Point(9, 111);
            this.radiobutton_fio.Margin = new System.Windows.Forms.Padding(4);
            this.radiobutton_fio.Name = "radiobutton_fio";
            this.radiobutton_fio.Size = new System.Drawing.Size(58, 21);
            this.radiobutton_fio.TabIndex = 2;
            this.radiobutton_fio.Text = "ФИО";
            this.radiobutton_fio.UseVisualStyleBackColor = true;
            this.radiobutton_fio.CheckedChanged += new System.EventHandler(this.Radiobutton_fio_CheckedChanged);
            // 
            // radiobutton_personal_account
            // 
            this.radiobutton_personal_account.AutoSize = true;
            this.radiobutton_personal_account.Location = new System.Drawing.Point(8, 82);
            this.radiobutton_personal_account.Margin = new System.Windows.Forms.Padding(4);
            this.radiobutton_personal_account.Name = "radiobutton_personal_account";
            this.radiobutton_personal_account.Size = new System.Drawing.Size(113, 21);
            this.radiobutton_personal_account.TabIndex = 1;
            this.radiobutton_personal_account.Text = "Лицевой счет";
            this.radiobutton_personal_account.UseVisualStyleBackColor = true;
            this.radiobutton_personal_account.CheckedChanged += new System.EventHandler(this.Radiobutton_personal_account_CheckedChanged);
            // 
            // radiobutton_date
            // 
            this.radiobutton_date.AutoSize = true;
            this.radiobutton_date.Checked = true;
            this.radiobutton_date.Location = new System.Drawing.Point(8, 24);
            this.radiobutton_date.Margin = new System.Windows.Forms.Padding(4);
            this.radiobutton_date.Name = "radiobutton_date";
            this.radiobutton_date.Size = new System.Drawing.Size(157, 21);
            this.radiobutton_date.TabIndex = 0;
            this.radiobutton_date.TabStop = true;
            this.radiobutton_date.Text = "Дата подачи заявки";
            this.radiobutton_date.UseVisualStyleBackColor = true;
            this.radiobutton_date.CheckedChanged += new System.EventHandler(this.Radiobutton_date_CheckedChanged);
            // 
            // button_do_select
            // 
            this.button_do_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_do_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_do_select.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_do_select.Location = new System.Drawing.Point(245, 540);
            this.button_do_select.Margin = new System.Windows.Forms.Padding(4);
            this.button_do_select.Name = "button_do_select";
            this.button_do_select.Size = new System.Drawing.Size(180, 30);
            this.button_do_select.TabIndex = 4;
            this.button_do_select.Text = "Выполнить запрос";
            this.button_do_select.UseVisualStyleBackColor = true;
            this.button_do_select.Click += new System.EventHandler(this.Button_do_select_Click);
            // 
            // button_export
            // 
            this.button_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_export.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_export.Location = new System.Drawing.Point(810, 540);
            this.button_export.Margin = new System.Windows.Forms.Padding(4);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(175, 30);
            this.button_export.TabIndex = 5;
            this.button_export.Text = "Экспорт в Exсel";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.Button_export_Click);
            // 
            // combobox_fio
            // 
            this.combobox_fio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_fio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_fio.FormattingEnabled = true;
            this.combobox_fio.Location = new System.Drawing.Point(9, 47);
            this.combobox_fio.Margin = new System.Windows.Forms.Padding(4);
            this.combobox_fio.Name = "combobox_fio";
            this.combobox_fio.Size = new System.Drawing.Size(164, 25);
            this.combobox_fio.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО потребителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата подачи заявки";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combobox_personal_account);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.date_сalendar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.datetime_show);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.combobox_fio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(24, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 371);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные для выборки";
            // 
            // combobox_personal_account
            // 
            this.combobox_personal_account.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_personal_account.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_personal_account.FormattingEnabled = true;
            this.combobox_personal_account.Location = new System.Drawing.Point(9, 97);
            this.combobox_personal_account.Margin = new System.Windows.Forms.Padding(4);
            this.combobox_personal_account.Name = "combobox_personal_account";
            this.combobox_personal_account.Size = new System.Drawing.Size(164, 25);
            this.combobox_personal_account.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Лицевой счет";
            // 
            // date_сalendar
            // 
            this.date_сalendar.Location = new System.Drawing.Point(8, 144);
            this.date_сalendar.Margin = new System.Windows.Forms.Padding(12);
            this.date_сalendar.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.date_сalendar.MaxSelectionCount = 1;
            this.date_сalendar.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.date_сalendar.Name = "date_сalendar";
            this.date_сalendar.ShowToday = false;
            this.date_сalendar.ShowTodayCircle = false;
            this.date_сalendar.TabIndex = 3;
            this.date_сalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.date_select);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выбранная дата";
            // 
            // datetime_show
            // 
            this.datetime_show.Enabled = false;
            this.datetime_show.Location = new System.Drawing.Point(8, 335);
            this.datetime_show.Margin = new System.Windows.Forms.Padding(4);
            this.datetime_show.Name = "datetime_show";
            this.datetime_show.Size = new System.Drawing.Size(164, 23);
            this.datetime_show.TabIndex = 2;
            // 
            // DatabaseJournalAllReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(999, 585);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_do_select);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagridview);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatabaseJournalAllReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал регистрации";
            this.Load += new System.EventHandler(this.DatabaseJournalAllReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobutton_all;
        private System.Windows.Forms.RadioButton radiobutton_fio;
        private System.Windows.Forms.RadioButton radiobutton_personal_account;
        private System.Windows.Forms.RadioButton radiobutton_date;
        private System.Windows.Forms.Button button_do_select;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.ComboBox combobox_fio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combobox_personal_account;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar date_сalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetime_show;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton radiobutton_date_obhoda;
    }
}