namespace Journal_Client
{
    partial class WorkerWorkspace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resourceshould be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerWorkspace));
            this.button_in_out_journal = new System.Windows.Forms.Button();
            this.button_inventory_journal = new System.Windows.Forms.Button();
            this.label_server = new System.Windows.Forms.Label();
            this.button_seales_directory = new System.Windows.Forms.Button();
            this.button_controllers_directory = new System.Windows.Forms.Button();
            this.button_sealers_controllers_links = new System.Windows.Forms.Button();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.Forms = new System.Windows.Forms.TabPage();
            this.button_enter_data = new System.Windows.Forms.Button();
            this.button_registry_request = new System.Windows.Forms.Button();
            this.button_registry_area = new System.Windows.Forms.Button();
            this.Directories = new System.Windows.Forms.TabPage();
            this.Reports = new System.Windows.Forms.TabPage();
            this.button_jurnal_reg = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tab_control.SuspendLayout();
            this.Forms.SuspendLayout();
            this.Directories.SuspendLayout();
            this.Reports.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_in_out_journal
            // 
            this.button_in_out_journal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_in_out_journal.Location = new System.Drawing.Point(6, 7);
            this.button_in_out_journal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_in_out_journal.Name = "button_in_out_journal";
            this.button_in_out_journal.Size = new System.Drawing.Size(367, 87);
            this.button_in_out_journal.TabIndex = 3;
            this.button_in_out_journal.Text = "Ввод и вывод";
            this.button_in_out_journal.UseVisualStyleBackColor = true;
            this.button_in_out_journal.Click += new System.EventHandler(this.Button_in_out_journal_Click);
            // 
            // button_inventory_journal
            // 
            this.button_inventory_journal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_inventory_journal.Location = new System.Drawing.Point(6, 102);
            this.button_inventory_journal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_inventory_journal.Name = "button_inventory_journal";
            this.button_inventory_journal.Size = new System.Drawing.Size(367, 87);
            this.button_inventory_journal.TabIndex = 4;
            this.button_inventory_journal.Text = "Инвентаризация";
            this.button_inventory_journal.UseVisualStyleBackColor = true;
            this.button_inventory_journal.Click += new System.EventHandler(this.Button_inventory_journal_Click);
            // 
            // label_server
            // 
            this.label_server.AutoSize = true;
            this.label_server.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_server.Location = new System.Drawing.Point(6, 28);
            this.label_server.Name = "label_server";
            this.label_server.Size = new System.Drawing.Size(34, 23);
            this.label_server.TabIndex = 7;
            this.label_server.Text = "---";
            // 
            // button_seales_directory
            // 
            this.button_seales_directory.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_seales_directory.Location = new System.Drawing.Point(6, 102);
            this.button_seales_directory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_seales_directory.Name = "button_seales_directory";
            this.button_seales_directory.Size = new System.Drawing.Size(367, 87);
            this.button_seales_directory.TabIndex = 5;
            this.button_seales_directory.Text = "Список пломбираторов";
            this.button_seales_directory.UseVisualStyleBackColor = true;
            this.button_seales_directory.Click += new System.EventHandler(this.Button_seales_directory_Click);
            // 
            // button_controllers_directory
            // 
            this.button_controllers_directory.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_controllers_directory.Location = new System.Drawing.Point(6, 197);
            this.button_controllers_directory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_controllers_directory.Name = "button_controllers_directory";
            this.button_controllers_directory.Size = new System.Drawing.Size(367, 87);
            this.button_controllers_directory.TabIndex = 4;
            this.button_controllers_directory.Text = "Список контролеров";
            this.button_controllers_directory.UseVisualStyleBackColor = true;
            this.button_controllers_directory.Click += new System.EventHandler(this.Button_controllers_directory_Click);
            // 
            // button_sealers_controllers_links
            // 
            this.button_sealers_controllers_links.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sealers_controllers_links.Location = new System.Drawing.Point(6, 7);
            this.button_sealers_controllers_links.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_sealers_controllers_links.Name = "button_sealers_controllers_links";
            this.button_sealers_controllers_links.Size = new System.Drawing.Size(367, 87);
            this.button_sealers_controllers_links.TabIndex = 3;
            this.button_sealers_controllers_links.Text = "Связи пломбираторов и контролеров";
            this.button_sealers_controllers_links.UseVisualStyleBackColor = true;
            this.button_sealers_controllers_links.Click += new System.EventHandler(this.Button_sealers_directory_Click);
            // 
            // tab_control
            // 
            this.tab_control.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tab_control.Controls.Add(this.Forms);
            this.tab_control.Controls.Add(this.Directories);
            this.tab_control.Controls.Add(this.Reports);
            this.tab_control.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_control.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_control.Location = new System.Drawing.Point(12, 81);
            this.tab_control.Multiline = true;
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(387, 377);
            this.tab_control.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tab_control.TabIndex = 8;
            // 
            // Forms
            // 
            this.Forms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Forms.Controls.Add(this.button_enter_data);
            this.Forms.Controls.Add(this.button_registry_request);
            this.Forms.Controls.Add(this.button_registry_area);
            this.Forms.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Forms.Location = new System.Drawing.Point(4, 36);
            this.Forms.Name = "Forms";
            this.Forms.Padding = new System.Windows.Forms.Padding(3);
            this.Forms.Size = new System.Drawing.Size(379, 337);
            this.Forms.TabIndex = 0;
            this.Forms.Text = "Формы";
            // 
            // button_enter_data
            // 
            this.button_enter_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_enter_data.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.button_enter_data.Location = new System.Drawing.Point(6, 196);
            this.button_enter_data.Name = "button_enter_data";
            this.button_enter_data.Size = new System.Drawing.Size(367, 87);
            this.button_enter_data.TabIndex = 2;
            this.button_enter_data.Text = "Занесение показаний";
            this.button_enter_data.UseVisualStyleBackColor = true;
            this.button_enter_data.Click += new System.EventHandler(this.Button_enter_data_Click);
            // 
            // button_registry_request
            // 
            this.button_registry_request.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_registry_request.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_registry_request.Location = new System.Drawing.Point(6, 102);
            this.button_registry_request.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_registry_request.Name = "button_registry_request";
            this.button_registry_request.Size = new System.Drawing.Size(367, 87);
            this.button_registry_request.TabIndex = 1;
            this.button_registry_request.Text = "Регистрации заявок";
            this.button_registry_request.UseVisualStyleBackColor = true;
            this.button_registry_request.Click += new System.EventHandler(this.Button_registry_request_Click);
            // 
            // button_registry_area
            // 
            this.button_registry_area.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_registry_area.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_registry_area.Location = new System.Drawing.Point(6, 7);
            this.button_registry_area.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_registry_area.Name = "button_registry_area";
            this.button_registry_area.Size = new System.Drawing.Size(367, 87);
            this.button_registry_area.TabIndex = 0;
            this.button_registry_area.Text = "Регистрация участков";
            this.button_registry_area.UseVisualStyleBackColor = true;
            this.button_registry_area.Click += new System.EventHandler(this.Button_registry_area_Click);
            // 
            // Directories
            // 
            this.Directories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Directories.Controls.Add(this.button_seales_directory);
            this.Directories.Controls.Add(this.button_sealers_controllers_links);
            this.Directories.Controls.Add(this.button_controllers_directory);
            this.Directories.Location = new System.Drawing.Point(4, 36);
            this.Directories.Name = "Directories";
            this.Directories.Padding = new System.Windows.Forms.Padding(3);
            this.Directories.Size = new System.Drawing.Size(379, 337);
            this.Directories.TabIndex = 1;
            this.Directories.Text = "Справочники";
            // 
            // Reports
            // 
            this.Reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Reports.Controls.Add(this.button_jurnal_reg);
            this.Reports.Controls.Add(this.button_inventory_journal);
            this.Reports.Controls.Add(this.button_in_out_journal);
            this.Reports.Location = new System.Drawing.Point(4, 36);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(3);
            this.Reports.Size = new System.Drawing.Size(379, 337);
            this.Reports.TabIndex = 2;
            this.Reports.Text = "Отчеты";
            // 
            // button_jurnal_reg
            // 
            this.button_jurnal_reg.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_jurnal_reg.Location = new System.Drawing.Point(6, 197);
            this.button_jurnal_reg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_jurnal_reg.Name = "button_jurnal_reg";
            this.button_jurnal_reg.Size = new System.Drawing.Size(367, 87);
            this.button_jurnal_reg.TabIndex = 5;
            this.button_jurnal_reg.Text = "Регистрации заявок";
            this.button_jurnal_reg.UseVisualStyleBackColor = true;
            this.button_jurnal_reg.Click += new System.EventHandler(this.Button_jurnal_reg_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_server);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 63);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Текущий район";
            // 
            // WorkerWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(411, 470);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tab_control);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WorkerWorkspace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная панель";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_closed);
            this.Load += new System.EventHandler(this.WorkerWorkspace_Load);
            this.tab_control.ResumeLayout(false);
            this.Forms.ResumeLayout(false);
            this.Directories.ResumeLayout(false);
            this.Reports.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_in_out_journal;
        private System.Windows.Forms.Label label_server;
        private System.Windows.Forms.Button button_sealers_controllers_links;
        private System.Windows.Forms.Button button_controllers_directory;
        private System.Windows.Forms.Button button_seales_directory;
        private System.Windows.Forms.Button button_inventory_journal;
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage Directories;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage Forms;
        private System.Windows.Forms.Button button_enter_data;
        private System.Windows.Forms.Button button_registry_request;
        private System.Windows.Forms.Button button_registry_area;
        private System.Windows.Forms.Button button_jurnal_reg;
    }
}