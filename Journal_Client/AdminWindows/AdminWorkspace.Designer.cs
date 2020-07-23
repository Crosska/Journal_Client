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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textbox_new_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_new_password = new System.Windows.Forms.TextBox();
            this.radiobutton_user = new System.Windows.Forms.RadioButton();
            this.radiobutton_admin = new System.Windows.Forms.RadioButton();
            this.button_create_new = new System.Windows.Forms.Button();
            this.richtextbox_fio = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.datagridview.Size = new System.Drawing.Size(552, 516);
            this.datagridview.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.radiobutton_users);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(228, 63);
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
            this.groupBox2.Location = new System.Drawing.Point(13, 409);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(228, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работа с логами";
            // 
            // button_clear_log
            // 
            this.button_clear_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_clear_log.Location = new System.Drawing.Point(16, 68);
            this.button_clear_log.Name = "button_clear_log";
            this.button_clear_log.Size = new System.Drawing.Size(195, 40);
            this.button_clear_log.TabIndex = 3;
            this.button_clear_log.Text = "Очистить лог-файл";
            this.button_clear_log.UseVisualStyleBackColor = false;
            this.button_clear_log.Click += new System.EventHandler(this.button_clear_log_Click);
            // 
            // button_open_prg_log
            // 
            this.button_open_prg_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_open_prg_log.Location = new System.Drawing.Point(16, 24);
            this.button_open_prg_log.Name = "button_open_prg_log";
            this.button_open_prg_log.Size = new System.Drawing.Size(195, 38);
            this.button_open_prg_log.TabIndex = 2;
            this.button_open_prg_log.Text = "Открыть лог-файл";
            this.button_open_prg_log.UseVisualStyleBackColor = true;
            this.button_open_prg_log.Click += new System.EventHandler(this.button_open_prg_log_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.richtextbox_fio);
            this.groupBox3.Controls.Add(this.button_create_new);
            this.groupBox3.Controls.Add(this.radiobutton_admin);
            this.groupBox3.Controls.Add(this.radiobutton_user);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textbox_new_password);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textbox_new_login);
            this.groupBox3.Location = new System.Drawing.Point(13, 87);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(228, 312);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Создание пользователя";
            // 
            // textbox_new_login
            // 
            this.textbox_new_login.Location = new System.Drawing.Point(16, 167);
            this.textbox_new_login.Name = "textbox_new_login";
            this.textbox_new_login.Size = new System.Drawing.Size(195, 26);
            this.textbox_new_login.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // textbox_new_password
            // 
            this.textbox_new_password.Location = new System.Drawing.Point(16, 218);
            this.textbox_new_password.Name = "textbox_new_password";
            this.textbox_new_password.Size = new System.Drawing.Size(195, 26);
            this.textbox_new_password.TabIndex = 2;
            // 
            // radiobutton_user
            // 
            this.radiobutton_user.AutoSize = true;
            this.radiobutton_user.Checked = true;
            this.radiobutton_user.Location = new System.Drawing.Point(16, 250);
            this.radiobutton_user.Name = "radiobutton_user";
            this.radiobutton_user.Size = new System.Drawing.Size(59, 24);
            this.radiobutton_user.TabIndex = 4;
            this.radiobutton_user.TabStop = true;
            this.radiobutton_user.Text = "User";
            this.radiobutton_user.UseVisualStyleBackColor = true;
            this.radiobutton_user.CheckedChanged += new System.EventHandler(this.radiobutton_user_CheckedChanged);
            // 
            // radiobutton_admin
            // 
            this.radiobutton_admin.AutoSize = true;
            this.radiobutton_admin.Location = new System.Drawing.Point(16, 280);
            this.radiobutton_admin.Name = "radiobutton_admin";
            this.radiobutton_admin.Size = new System.Drawing.Size(73, 24);
            this.radiobutton_admin.TabIndex = 5;
            this.radiobutton_admin.Text = "Admin";
            this.radiobutton_admin.UseVisualStyleBackColor = true;
            this.radiobutton_admin.CheckedChanged += new System.EventHandler(this.radiobutton_admin_CheckedChanged);
            // 
            // button_create_new
            // 
            this.button_create_new.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create_new.Location = new System.Drawing.Point(95, 250);
            this.button_create_new.Name = "button_create_new";
            this.button_create_new.Size = new System.Drawing.Size(116, 54);
            this.button_create_new.TabIndex = 6;
            this.button_create_new.Text = "Создать";
            this.button_create_new.UseVisualStyleBackColor = true;
            this.button_create_new.Click += new System.EventHandler(this.button_create_new_Click);
            // 
            // richtextbox_fio
            // 
            this.richtextbox_fio.Location = new System.Drawing.Point(16, 47);
            this.richtextbox_fio.Name = "richtextbox_fio";
            this.richtextbox_fio.Size = new System.Drawing.Size(195, 94);
            this.richtextbox_fio.TabIndex = 7;
            this.richtextbox_fio.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ФИО";
            // 
            // AdminWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 545);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagridview);
            this.DoubleBuffered = true;
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobutton_users;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_clear_log;
        private System.Windows.Forms.Button button_open_prg_log;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_create_new;
        private System.Windows.Forms.RadioButton radiobutton_admin;
        private System.Windows.Forms.RadioButton radiobutton_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_new_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_new_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richtextbox_fio;
    }
}