namespace Journal_Client
{
    partial class DatabaseInOutJournal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobutton_all = new System.Windows.Forms.RadioButton();
            this.radiobutton_select_for_controller = new System.Windows.Forms.RadioButton();
            this.radiobutton_select_for_date = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobutton_select_out = new System.Windows.Forms.RadioButton();
            this.radiobutton_select_in = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox_controller = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datetime_show = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.button_export = new System.Windows.Forms.Button();
            this.button_do_select = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobutton_all);
            this.groupBox1.Controls.Add(this.radiobutton_select_for_controller);
            this.groupBox1.Controls.Add(this.radiobutton_select_for_date);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(192, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выборка по:";
            // 
            // radiobutton_all
            // 
            this.radiobutton_all.AutoSize = true;
            this.radiobutton_all.Location = new System.Drawing.Point(8, 66);
            this.radiobutton_all.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radiobutton_all.Name = "radiobutton_all";
            this.radiobutton_all.Size = new System.Drawing.Size(80, 23);
            this.radiobutton_all.TabIndex = 2;
            this.radiobutton_all.Text = "Общее";
            this.radiobutton_all.UseVisualStyleBackColor = true;
            this.radiobutton_all.CheckedChanged += new System.EventHandler(this.radiobutton_all_checked);
            // 
            // radiobutton_select_for_controller
            // 
            this.radiobutton_select_for_controller.AutoSize = true;
            this.radiobutton_select_for_controller.Location = new System.Drawing.Point(8, 45);
            this.radiobutton_select_for_controller.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radiobutton_select_for_controller.Name = "radiobutton_select_for_controller";
            this.radiobutton_select_for_controller.Size = new System.Drawing.Size(111, 23);
            this.radiobutton_select_for_controller.TabIndex = 1;
            this.radiobutton_select_for_controller.Text = "Контроллер";
            this.radiobutton_select_for_controller.UseVisualStyleBackColor = true;
            this.radiobutton_select_for_controller.CheckedChanged += new System.EventHandler(this.radiobutton_only_controller_checked);
            // 
            // radiobutton_select_for_date
            // 
            this.radiobutton_select_for_date.AutoSize = true;
            this.radiobutton_select_for_date.Checked = true;
            this.radiobutton_select_for_date.Location = new System.Drawing.Point(8, 24);
            this.radiobutton_select_for_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radiobutton_select_for_date.Name = "radiobutton_select_for_date";
            this.radiobutton_select_for_date.Size = new System.Drawing.Size(62, 23);
            this.radiobutton_select_for_date.TabIndex = 0;
            this.radiobutton_select_for_date.TabStop = true;
            this.radiobutton_select_for_date.Text = "Дата";
            this.radiobutton_select_for_date.UseVisualStyleBackColor = true;
            this.radiobutton_select_for_date.CheckedChanged += new System.EventHandler(this.radiobutton_only_date_checked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobutton_select_out);
            this.groupBox2.Controls.Add(this.radiobutton_select_in);
            this.groupBox2.Location = new System.Drawing.Point(16, 117);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(192, 71);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбрать:";
            // 
            // radiobutton_select_out
            // 
            this.radiobutton_select_out.AutoSize = true;
            this.radiobutton_select_out.Location = new System.Drawing.Point(8, 43);
            this.radiobutton_select_out.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radiobutton_select_out.Name = "radiobutton_select_out";
            this.radiobutton_select_out.Size = new System.Drawing.Size(78, 23);
            this.radiobutton_select_out.TabIndex = 1;
            this.radiobutton_select_out.Text = "Вывода";
            this.radiobutton_select_out.UseVisualStyleBackColor = true;
            this.radiobutton_select_out.CheckedChanged += new System.EventHandler(this.radiobutton_out_checked);
            // 
            // radiobutton_select_in
            // 
            this.radiobutton_select_in.AutoSize = true;
            this.radiobutton_select_in.Checked = true;
            this.radiobutton_select_in.Location = new System.Drawing.Point(8, 22);
            this.radiobutton_select_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radiobutton_select_in.Name = "radiobutton_select_in";
            this.radiobutton_select_in.Size = new System.Drawing.Size(69, 23);
            this.radiobutton_select_in.TabIndex = 0;
            this.radiobutton_select_in.TabStop = true;
            this.radiobutton_select_in.Text = "Ввода";
            this.radiobutton_select_in.UseVisualStyleBackColor = true;
            this.radiobutton_select_in.CheckedChanged += new System.EventHandler(this.radiobutton_in_checked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.combobox_controller);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.datetime_show);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.calendar);
            this.groupBox3.Location = new System.Drawing.Point(16, 196);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(192, 322);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные для выборки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Контроллер:";
            // 
            // combobox_controller
            // 
            this.combobox_controller.FormattingEnabled = true;
            this.combobox_controller.Location = new System.Drawing.Point(14, 279);
            this.combobox_controller.Name = "combobox_controller";
            this.combobox_controller.Size = new System.Drawing.Size(164, 25);
            this.combobox_controller.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбранная дата:";
            // 
            // datetime_show
            // 
            this.datetime_show.Enabled = false;
            this.datetime_show.Location = new System.Drawing.Point(14, 230);
            this.datetime_show.Name = "datetime_show";
            this.datetime_show.Size = new System.Drawing.Size(164, 24);
            this.datetime_show.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата:";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(14, 43);
            this.calendar.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.calendar.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.MinDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.ShowToday = false;
            this.calendar.ShowTodayCircle = false;
            this.calendar.TabIndex = 0;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.date_changed);
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToDeleteRows = false;
            this.datagridview.AllowUserToResizeRows = false;
            this.datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridview.Location = new System.Drawing.Point(214, 16);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridview.Size = new System.Drawing.Size(756, 456);
            this.datagridview.TabIndex = 5;
            // 
            // button_export
            // 
            this.button_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_export.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_export.Location = new System.Drawing.Point(742, 478);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(228, 40);
            this.button_export.TabIndex = 6;
            this.button_export.Text = "Экспорт в excel файл";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.Button_export_Click);
            // 
            // button_do_select
            // 
            this.button_do_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_do_select.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_do_select.Location = new System.Drawing.Point(214, 478);
            this.button_do_select.Name = "button_do_select";
            this.button_do_select.Size = new System.Drawing.Size(191, 40);
            this.button_do_select.TabIndex = 7;
            this.button_do_select.Text = "Выполнить запрос";
            this.button_do_select.UseVisualStyleBackColor = true;
            this.button_do_select.Click += new System.EventHandler(this.Button_do_select_Click);
            // 
            // DatabaseInOutJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 532);
            this.Controls.Add(this.button_do_select);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatabaseInOutJournal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал регистрации вводов и выводов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobutton_all;
        private System.Windows.Forms.RadioButton radiobutton_select_for_controller;
        private System.Windows.Forms.RadioButton radiobutton_select_for_date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiobutton_select_out;
        private System.Windows.Forms.RadioButton radiobutton_select_in;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox_controller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetime_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_do_select;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}