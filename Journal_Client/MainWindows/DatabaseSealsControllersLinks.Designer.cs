namespace Journal_Client
{
    partial class DatabaseSealsControllersLinks
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
            this.combobox_controller = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listbox_sealers = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // combobox_controller
            // 
            this.combobox_controller.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_controller.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_controller.FormattingEnabled = true;
            this.combobox_controller.Location = new System.Drawing.Point(6, 23);
            this.combobox_controller.Name = "combobox_controller";
            this.combobox_controller.Size = new System.Drawing.Size(313, 25);
            this.combobox_controller.TabIndex = 0;
            this.combobox_controller.SelectedIndexChanged += new System.EventHandler(this.chosen_controller_changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combobox_controller);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор контролёра";
            // 
            // listbox_sealers
            // 
            this.listbox_sealers.FormattingEnabled = true;
            this.listbox_sealers.ItemHeight = 17;
            this.listbox_sealers.Location = new System.Drawing.Point(6, 23);
            this.listbox_sealers.Name = "listbox_sealers";
            this.listbox_sealers.Size = new System.Drawing.Size(312, 140);
            this.listbox_sealers.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listbox_sealers);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 173);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пломбираторы контроллера";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(12, 260);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(324, 43);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Добавить пломбиратор";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(13, 309);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(324, 43);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Удалить пломбиратор";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // DatabaseSealsControllersLinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(348, 366);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatabaseSealsControllersLinks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление пломбираторами";
            this.Activated += new System.EventHandler(this.update_form);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_controller;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listbox_sealers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
    }
}