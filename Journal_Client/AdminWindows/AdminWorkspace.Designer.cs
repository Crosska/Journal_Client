namespace Journal_Client.AdminWindows
{
    partial class AdminWorkspace
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobutton_users = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_clear_log = new System.Windows.Forms.Button();
            this.button_open_prg_log = new System.Windows.Forms.Button();
            this.button_open_log = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToDeleteRows = false;
            this.datagridview.AllowUserToResizeRows = false;
            this.datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.datagridview.Location = new System.Drawing.Point(249, 15);
            this.datagridview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview.Size = new System.Drawing.Size(552, 438);
            this.datagridview.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobutton_users);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(228, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные программы";
            // 
            // radiobutton_users
            // 
            this.radiobutton_users.AutoSize = true;
            this.radiobutton_users.Checked = true;
            this.radiobutton_users.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radiobutton_users.Location = new System.Drawing.Point(16, 27);
            this.radiobutton_users.Name = "radiobutton_users";
            this.radiobutton_users.Size = new System.Drawing.Size(199, 21);
            this.radiobutton_users.TabIndex = 0;
            this.radiobutton_users.TabStop = true;
            this.radiobutton_users.Text = "Пользователи программы";
            this.radiobutton_users.UseVisualStyleBackColor = true;
            this.radiobutton_users.CheckedChanged += new System.EventHandler(this.radiobutton_users_checked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_clear_log);
            this.groupBox2.Controls.Add(this.button_open_prg_log);
            this.groupBox2.Controls.Add(this.button_open_log);
            this.groupBox2.Location = new System.Drawing.Point(13, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(228, 213);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работа с логами";
            // 
            // button_clear_log
            // 
            this.button_clear_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_clear_log.Location = new System.Drawing.Point(16, 151);
            this.button_clear_log.Name = "button_clear_log";
            this.button_clear_log.Size = new System.Drawing.Size(195, 51);
            this.button_clear_log.TabIndex = 3;
            this.button_clear_log.Text = "Очистить лог-файл";
            this.button_clear_log.UseVisualStyleBackColor = false;
            this.button_clear_log.Click += new System.EventHandler(this.button_clear_log_Click);
            // 
            // button_open_prg_log
            // 
            this.button_open_prg_log.Location = new System.Drawing.Point(16, 81);
            this.button_open_prg_log.Name = "button_open_prg_log";
            this.button_open_prg_log.Size = new System.Drawing.Size(195, 64);
            this.button_open_prg_log.TabIndex = 2;
            this.button_open_prg_log.Text = "Открыть лог в программе";
            this.button_open_prg_log.UseVisualStyleBackColor = true;
            this.button_open_prg_log.Click += new System.EventHandler(this.button_open_prg_log_Click);
            // 
            // button_open_log
            // 
            this.button_open_log.Location = new System.Drawing.Point(16, 24);
            this.button_open_log.Name = "button_open_log";
            this.button_open_log.Size = new System.Drawing.Size(195, 51);
            this.button_open_log.TabIndex = 1;
            this.button_open_log.Text = "Открыть лог-файл";
            this.button_open_log.UseVisualStyleBackColor = true;
            this.button_open_log.Click += new System.EventHandler(this.button_open_log_Click);
            // 
            // AdminWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(814, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagridview);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminWorkspace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_closed);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobutton_users;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_clear_log;
        private System.Windows.Forms.Button button_open_prg_log;
        private System.Windows.Forms.Button button_open_log;
    }
}