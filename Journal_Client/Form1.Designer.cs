namespace Journal_Client
{
    partial class DatabaseConnection
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Engineer_connect_online = new System.Windows.Forms.Button();
            this.Engineer_login_online = new System.Windows.Forms.TextBox();
            this.Engineer_password_online = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Operator_connect_online = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Operator_login_online = new System.Windows.Forms.TextBox();
            this.Operator_password_online = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Engineer_connect_offline = new System.Windows.Forms.Button();
            this.Engineer_login_offline = new System.Windows.Forms.TextBox();
            this.Engineer_password_offline = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Operator_connect_offline = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Operator_login_offline = new System.Windows.Forms.TextBox();
            this.Operator_password_offline = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(445, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключение к базе онлайн";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.Engineer_connect_online);
            this.groupBox4.Controls.Add(this.Engineer_login_online);
            this.groupBox4.Controls.Add(this.Engineer_password_online);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(11, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 240);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Инженер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Логин";
            // 
            // Engineer_connect_online
            // 
            this.Engineer_connect_online.Location = new System.Drawing.Point(6, 197);
            this.Engineer_connect_online.Name = "Engineer_connect_online";
            this.Engineer_connect_online.Size = new System.Drawing.Size(415, 37);
            this.Engineer_connect_online.TabIndex = 0;
            this.Engineer_connect_online.Text = "Подключиться";
            this.Engineer_connect_online.UseVisualStyleBackColor = true;
            // 
            // Engineer_login_online
            // 
            this.Engineer_login_online.Location = new System.Drawing.Point(10, 52);
            this.Engineer_login_online.MaxLength = 50;
            this.Engineer_login_online.Name = "Engineer_login_online";
            this.Engineer_login_online.Size = new System.Drawing.Size(411, 27);
            this.Engineer_login_online.TabIndex = 10;
            // 
            // Engineer_password_online
            // 
            this.Engineer_password_online.Location = new System.Drawing.Point(10, 105);
            this.Engineer_password_online.MaxLength = 50;
            this.Engineer_password_online.Name = "Engineer_password_online";
            this.Engineer_password_online.PasswordChar = '*';
            this.Engineer_password_online.Size = new System.Drawing.Size(411, 27);
            this.Engineer_password_online.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пароль";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Operator_connect_online);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Operator_login_online);
            this.groupBox3.Controls.Add(this.Operator_password_online);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 210);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оператор";
            // 
            // Operator_connect_online
            // 
            this.Operator_connect_online.Location = new System.Drawing.Point(10, 167);
            this.Operator_connect_online.Name = "Operator_connect_online";
            this.Operator_connect_online.Size = new System.Drawing.Size(411, 37);
            this.Operator_connect_online.TabIndex = 9;
            this.Operator_connect_online.Text = "Подключиться";
            this.Operator_connect_online.UseVisualStyleBackColor = true;
            this.Operator_connect_online.Click += new System.EventHandler(this.Operator_connect_online_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Логин";
            // 
            // Operator_login_online
            // 
            this.Operator_login_online.Location = new System.Drawing.Point(10, 52);
            this.Operator_login_online.MaxLength = 50;
            this.Operator_login_online.Name = "Operator_login_online";
            this.Operator_login_online.Size = new System.Drawing.Size(411, 27);
            this.Operator_login_online.TabIndex = 5;
            // 
            // Operator_password_online
            // 
            this.Operator_password_online.Location = new System.Drawing.Point(10, 105);
            this.Operator_password_online.MaxLength = 50;
            this.Operator_password_online.Name = "Operator_password_online";
            this.Operator_password_online.PasswordChar = '*';
            this.Operator_password_online.Size = new System.Drawing.Size(411, 27);
            this.Operator_password_online.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Пароль";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(469, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(445, 490);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подключение к базе офлайн";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.Engineer_connect_offline);
            this.groupBox5.Controls.Add(this.Engineer_login_offline);
            this.groupBox5.Controls.Add(this.Engineer_password_offline);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(7, 243);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(427, 240);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Инженер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Логин";
            // 
            // Engineer_connect_offline
            // 
            this.Engineer_connect_offline.Location = new System.Drawing.Point(6, 197);
            this.Engineer_connect_offline.Name = "Engineer_connect_offline";
            this.Engineer_connect_offline.Size = new System.Drawing.Size(415, 37);
            this.Engineer_connect_offline.TabIndex = 0;
            this.Engineer_connect_offline.Text = "Подключиться";
            this.Engineer_connect_offline.UseVisualStyleBackColor = true;
            // 
            // Engineer_login_offline
            // 
            this.Engineer_login_offline.Location = new System.Drawing.Point(10, 52);
            this.Engineer_login_offline.MaxLength = 50;
            this.Engineer_login_offline.Name = "Engineer_login_offline";
            this.Engineer_login_offline.Size = new System.Drawing.Size(411, 27);
            this.Engineer_login_offline.TabIndex = 10;
            // 
            // Engineer_password_offline
            // 
            this.Engineer_password_offline.Location = new System.Drawing.Point(10, 105);
            this.Engineer_password_offline.MaxLength = 50;
            this.Engineer_password_offline.Name = "Engineer_password_offline";
            this.Engineer_password_offline.PasswordChar = '*';
            this.Engineer_password_offline.Size = new System.Drawing.Size(411, 27);
            this.Engineer_password_offline.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Пароль";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Operator_connect_offline);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.Operator_login_offline);
            this.groupBox6.Controls.Add(this.Operator_password_offline);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(7, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(427, 210);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Оператор";
            // 
            // Operator_connect_offline
            // 
            this.Operator_connect_offline.Location = new System.Drawing.Point(10, 167);
            this.Operator_connect_offline.Name = "Operator_connect_offline";
            this.Operator_connect_offline.Size = new System.Drawing.Size(411, 37);
            this.Operator_connect_offline.TabIndex = 9;
            this.Operator_connect_offline.Text = "Подключиться";
            this.Operator_connect_offline.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Логин";
            // 
            // Operator_login_offline
            // 
            this.Operator_login_offline.Location = new System.Drawing.Point(10, 52);
            this.Operator_login_offline.MaxLength = 50;
            this.Operator_login_offline.Name = "Operator_login_offline";
            this.Operator_login_offline.Size = new System.Drawing.Size(411, 27);
            this.Operator_login_offline.TabIndex = 5;
            // 
            // Operator_password_offline
            // 
            this.Operator_password_offline.Location = new System.Drawing.Point(10, 105);
            this.Operator_password_offline.MaxLength = 50;
            this.Operator_password_offline.Name = "Operator_password_offline";
            this.Operator_password_offline.PasswordChar = '*';
            this.Operator_password_offline.Size = new System.Drawing.Size(411, 27);
            this.Operator_password_offline.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Пароль";
            // 
            // DatabaseConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(926, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatabaseConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение к регистрационному журналу";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Engineer_connect_online;
        private System.Windows.Forms.TextBox Engineer_login_online;
        private System.Windows.Forms.TextBox Engineer_password_online;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Operator_connect_online;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Operator_login_online;
        private System.Windows.Forms.TextBox Operator_password_online;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Engineer_connect_offline;
        private System.Windows.Forms.TextBox Engineer_login_offline;
        private System.Windows.Forms.TextBox Engineer_password_offline;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Operator_connect_offline;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Operator_login_offline;
        private System.Windows.Forms.TextBox Operator_password_offline;
        private System.Windows.Forms.Label label10;
    }
}

