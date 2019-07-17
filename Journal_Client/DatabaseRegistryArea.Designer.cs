namespace Journal_Client
{
    partial class DatabaseRegistryArea
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
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagridtable_streets = new System.Windows.Forms.DataGridView();
            this.datetime_show = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridtable_streets)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Calendar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Календарь";
            // 
            // Calendar
            // 
            this.Calendar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calendar.Location = new System.Drawing.Point(12, 29);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 2;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.date_changed);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagridtable_streets);
            this.groupBox2.Controls.Add(this.datetime_show);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(205, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Участки";
            // 
            // datagridtable_streets
            // 
            this.datagridtable_streets.AllowUserToAddRows = false;
            this.datagridtable_streets.AllowUserToDeleteRows = false;
            this.datagridtable_streets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridtable_streets.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridtable_streets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridtable_streets.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.datagridtable_streets.Location = new System.Drawing.Point(10, 59);
            this.datagridtable_streets.Name = "datagridtable_streets";
            this.datagridtable_streets.ReadOnly = true;
            this.datagridtable_streets.Size = new System.Drawing.Size(351, 187);
            this.datagridtable_streets.TabIndex = 2;
            // 
            // datetime_show
            // 
            this.datetime_show.Enabled = false;
            this.datetime_show.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_show.Location = new System.Drawing.Point(145, 29);
            this.datetime_show.Name = "datetime_show";
            this.datetime_show.Size = new System.Drawing.Size(216, 24);
            this.datetime_show.TabIndex = 1;
            this.datetime_show.Value = new System.DateTime(2019, 7, 17, 10, 40, 25, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата обхода";
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(12, 221);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(187, 43);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Добавить запись";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // DatabaseRegistryArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 276);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatabaseRegistryArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал регистрации участков";
            this.Activated += new System.EventHandler(this.RefreshTable);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridtable_streets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker datetime_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView datagridtable_streets;
    }
}