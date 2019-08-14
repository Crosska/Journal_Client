namespace Journal_Client
{
    partial class DatabaseInventoryJournal
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
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.button_do_select = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobutton_all = new System.Windows.Forms.RadioButton();
            this.radiobutton_personal_account = new System.Windows.Forms.RadioButton();
            this.radiobutton_date = new System.Windows.Forms.RadioButton();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.datetime_show = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combobox_personal_account = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            this.datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.datagridview.Location = new System.Drawing.Point(234, 13);
            this.datagridview.Margin = new System.Windows.Forms.Padding(4);
            this.datagridview.Name = "datagridview";
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.Size = new System.Drawing.Size(825, 390);
            this.datagridview.TabIndex = 0;
            // 
            // button_do_select
            // 
            this.button_do_select.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_do_select.Location = new System.Drawing.Point(234, 414);
            this.button_do_select.Margin = new System.Windows.Forms.Padding(4);
            this.button_do_select.Name = "button_do_select";
            this.button_do_select.Size = new System.Drawing.Size(197, 30);
            this.button_do_select.TabIndex = 1;
            this.button_do_select.Text = "Выполнить запрос";
            this.button_do_select.UseVisualStyleBackColor = true;
            this.button_do_select.Click += new System.EventHandler(this.Button_do_select_Click);
            // 
            // button_export
            // 
            this.button_export.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_export.Location = new System.Drawing.Point(880, 414);
            this.button_export.Margin = new System.Windows.Forms.Padding(4);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(179, 30);
            this.button_export.TabIndex = 2;
            this.button_export.Text = "Экспорт в Excel";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.Button_export_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobutton_all);
            this.groupBox1.Controls.Add(this.radiobutton_personal_account);
            this.groupBox1.Controls.Add(this.radiobutton_date);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выборка по";
            // 
            // radiobutton_all
            // 
            this.radiobutton_all.AutoSize = true;
            this.radiobutton_all.Location = new System.Drawing.Point(12, 76);
            this.radiobutton_all.Name = "radiobutton_all";
            this.radiobutton_all.Size = new System.Drawing.Size(75, 21);
            this.radiobutton_all.TabIndex = 2;
            this.radiobutton_all.Text = "Общее";
            this.radiobutton_all.UseVisualStyleBackColor = true;
            this.radiobutton_all.CheckedChanged += new System.EventHandler(this.Radiobutton_all_CheckedChanged);
            // 
            // radiobutton_personal_account
            // 
            this.radiobutton_personal_account.AutoSize = true;
            this.radiobutton_personal_account.Location = new System.Drawing.Point(12, 49);
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
            this.radiobutton_date.Location = new System.Drawing.Point(12, 22);
            this.radiobutton_date.Name = "radiobutton_date";
            this.radiobutton_date.Size = new System.Drawing.Size(59, 21);
            this.radiobutton_date.TabIndex = 0;
            this.radiobutton_date.TabStop = true;
            this.radiobutton_date.Text = "Дата";
            this.radiobutton_date.UseVisualStyleBackColor = true;
            this.radiobutton_date.CheckedChanged += new System.EventHandler(this.Radiobutton_date_CheckedChanged);
            // 
            // calendar
            // 
            this.calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendar.Location = new System.Drawing.Point(12, 90);
            this.calendar.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.ShowToday = false;
            this.calendar.ShowTodayCircle = false;
            this.calendar.TabIndex = 4;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.date_select);
            // 
            // datetime_show
            // 
            this.datetime_show.Enabled = false;
            this.datetime_show.Location = new System.Drawing.Point(12, 278);
            this.datetime_show.Name = "datetime_show";
            this.datetime_show.Size = new System.Drawing.Size(164, 23);
            this.datetime_show.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.combobox_personal_account);
            this.groupBox2.Controls.Add(this.calendar);
            this.groupBox2.Controls.Add(this.datetime_show);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 319);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные для выборки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выбранная дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Лицевой счет";
            // 
            // combobox_personal_account
            // 
            this.combobox_personal_account.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_personal_account.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_personal_account.FormattingEnabled = true;
            this.combobox_personal_account.Location = new System.Drawing.Point(12, 44);
            this.combobox_personal_account.Name = "combobox_personal_account";
            this.combobox_personal_account.Size = new System.Drawing.Size(164, 25);
            this.combobox_personal_account.TabIndex = 6;
            // 
            // DatabaseInventoryJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1072, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_do_select);
            this.Controls.Add(this.datagridview);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatabaseInventoryJournal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал инвентаризации";
            this.Load += new System.EventHandler(this.DatabaseInventoryJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Button button_do_select;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobutton_all;
        private System.Windows.Forms.RadioButton radiobutton_personal_account;
        private System.Windows.Forms.RadioButton radiobutton_date;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.DateTimePicker datetime_show;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_personal_account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}