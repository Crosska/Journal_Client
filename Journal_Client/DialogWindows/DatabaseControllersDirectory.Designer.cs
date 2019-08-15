namespace Journal_Client
{
    partial class DatabaseControllersDirectory
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
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_fio_controller = new System.Windows.Forms.TextBox();
            this.button_add_controller = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listbox_controllers = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textbox_fio_controller);
            this.groupBox1.Location = new System.Drawing.Point(12, 308);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(342, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить контроллера";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // textbox_fio_controller
            // 
            this.textbox_fio_controller.Location = new System.Drawing.Point(6, 44);
            this.textbox_fio_controller.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_fio_controller.Name = "textbox_fio_controller";
            this.textbox_fio_controller.Size = new System.Drawing.Size(330, 24);
            this.textbox_fio_controller.TabIndex = 0;
            // 
            // button_add_controller
            // 
            this.button_add_controller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_add_controller.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_controller.Location = new System.Drawing.Point(12, 397);
            this.button_add_controller.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_add_controller.Name = "button_add_controller";
            this.button_add_controller.Size = new System.Drawing.Size(342, 50);
            this.button_add_controller.TabIndex = 3;
            this.button_add_controller.Text = "Добавить";
            this.button_add_controller.UseVisualStyleBackColor = false;
            this.button_add_controller.Click += new System.EventHandler(this.Button_add_controller_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listbox_controllers);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 293);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ФИО контроллеров";
            // 
            // listbox_controllers
            // 
            this.listbox_controllers.FormattingEnabled = true;
            this.listbox_controllers.ItemHeight = 17;
            this.listbox_controllers.Location = new System.Drawing.Point(10, 23);
            this.listbox_controllers.Name = "listbox_controllers";
            this.listbox_controllers.Size = new System.Drawing.Size(326, 259);
            this.listbox_controllers.TabIndex = 0;
            // 
            // DatabaseControllersDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_add_controller);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatabaseControllersDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление контроллерами";
            this.Load += new System.EventHandler(this.DatabaseControllersDirectory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_fio_controller;
        private System.Windows.Forms.Button button_add_controller;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listbox_controllers;
    }
}