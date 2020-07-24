namespace Journal_Client.StartWindows
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.textbox_login = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_enter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combobox_district = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_login
            // 
            this.textbox_login.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_login.Location = new System.Drawing.Point(11, 54);
            this.textbox_login.MaxLength = 40;
            this.textbox_login.Name = "textbox_login";
            this.textbox_login.Size = new System.Drawing.Size(256, 31);
            this.textbox_login.TabIndex = 0;
            // 
            // textbox_password
            // 
            this.textbox_password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_password.Location = new System.Drawing.Point(11, 112);
            this.textbox_password.MaxLength = 30;
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(256, 31);
            this.textbox_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // button_enter
            // 
            this.button_enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_enter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_enter.Location = new System.Drawing.Point(12, 229);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(275, 49);
            this.button_enter.TabIndex = 4;
            this.button_enter.Text = "Войти";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textbox_login);
            this.groupBox1.Controls.Add(this.textbox_password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 155);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные пользователя";
            // 
            // combobox_district
            // 
            this.combobox_district.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_district.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_district.FormattingEnabled = true;
            this.combobox_district.Items.AddRange(new object[] {
            "Гвардейский",
            "Горняцкий",
            "Кировский",
            "Советский",
            "Центрально-городской"});
            this.combobox_district.Location = new System.Drawing.Point(12, 194);
            this.combobox_district.Name = "combobox_district";
            this.combobox_district.Size = new System.Drawing.Size(275, 29);
            this.combobox_district.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Район";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(299, 289);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combobox_district);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_enter);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в программу";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.VisibleChanged += new System.EventHandler(this.clear);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_login;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combobox_district;
        private System.Windows.Forms.Label label3;
    }
}