namespace Journal_Client
{
    partial class DatabaseControlPanel
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
            this.button_registry_area = new System.Windows.Forms.Button();
            this.button_registry_request = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_server = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_seales_directory = new System.Windows.Forms.Button();
            this.button_controllers_directory = new System.Windows.Forms.Button();
            this.button_sealers_controllers_links = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_registry_area
            // 
            this.button_registry_area.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_registry_area.Location = new System.Drawing.Point(7, 23);
            this.button_registry_area.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_registry_area.Name = "button_registry_area";
            this.button_registry_area.Size = new System.Drawing.Size(248, 65);
            this.button_registry_area.TabIndex = 0;
            this.button_registry_area.Text = "Регистрация участков";
            this.button_registry_area.UseVisualStyleBackColor = true;
            this.button_registry_area.Click += new System.EventHandler(this.Button_registry_area_Click);
            // 
            // button_registry_request
            // 
            this.button_registry_request.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_registry_request.Location = new System.Drawing.Point(7, 96);
            this.button_registry_request.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_registry_request.Name = "button_registry_request";
            this.button_registry_request.Size = new System.Drawing.Size(248, 65);
            this.button_registry_request.TabIndex = 1;
            this.button_registry_request.Text = "Журнал регистрации заявок";
            this.button_registry_request.UseVisualStyleBackColor = true;
            this.button_registry_request.Click += new System.EventHandler(this.Button_registry_request_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_registry_area);
            this.groupBox1.Controls.Add(this.button_registry_request);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(261, 264);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(279, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(266, 264);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отчеты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Текущий сервер:";
            // 
            // label_server
            // 
            this.label_server.AutoSize = true;
            this.label_server.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_server.Location = new System.Drawing.Point(184, 9);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(28, 22);
            this.label_server.TabIndex = 7;
            this.label_server.Text = "---";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_seales_directory);
            this.groupBox3.Controls.Add(this.button_controllers_directory);
            this.groupBox3.Controls.Add(this.button_sealers_controllers_links);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 307);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(533, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Справочники";
            // 
            // button_seales_directory
            // 
            this.button_seales_directory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_seales_directory.Location = new System.Drawing.Point(355, 25);
            this.button_seales_directory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_seales_directory.Name = "button_seales_directory";
            this.button_seales_directory.Size = new System.Drawing.Size(168, 65);
            this.button_seales_directory.TabIndex = 5;
            this.button_seales_directory.Text = "Управление пломбираторами";
            this.button_seales_directory.UseVisualStyleBackColor = true;
            this.button_seales_directory.Click += new System.EventHandler(this.Button_seales_directory_Click);
            // 
            // button_controllers_directory
            // 
            this.button_controllers_directory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_controllers_directory.Location = new System.Drawing.Point(181, 25);
            this.button_controllers_directory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_controllers_directory.Name = "button_controllers_directory";
            this.button_controllers_directory.Size = new System.Drawing.Size(168, 65);
            this.button_controllers_directory.TabIndex = 4;
            this.button_controllers_directory.Text = "Управление контроллерами";
            this.button_controllers_directory.UseVisualStyleBackColor = true;
            this.button_controllers_directory.Click += new System.EventHandler(this.Button_controllers_directory_Click);
            // 
            // button_sealers_controllers_links
            // 
            this.button_sealers_controllers_links.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sealers_controllers_links.Location = new System.Drawing.Point(7, 25);
            this.button_sealers_controllers_links.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_sealers_controllers_links.Name = "button_sealers_controllers_links";
            this.button_sealers_controllers_links.Size = new System.Drawing.Size(168, 65);
            this.button_sealers_controllers_links.TabIndex = 3;
            this.button_sealers_controllers_links.Text = "Контроллер <-> пломбиратор";
            this.button_sealers_controllers_links.UseVisualStyleBackColor = true;
            this.button_sealers_controllers_links.Click += new System.EventHandler(this.Button_sealers_directory_Click);
            // 
            // DatabaseControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 420);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label_server);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatabaseControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная панель";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_closed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_registry_area;
        private System.Windows.Forms.Button button_registry_request;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_server;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_sealers_controllers_links;
        private System.Windows.Forms.Button button_controllers_directory;
        private System.Windows.Forms.Button button_seales_directory;
    }
}