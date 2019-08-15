namespace Journal_Client
{
    partial class DatabaseSealsDirectory
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
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_number_seal = new System.Windows.Forms.TextBox();
            this.button_add_seal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combobox_sealer_list = new System.Windows.Forms.ComboBox();
            this.button_delete_seal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер пломбиратора";
            // 
            // textbox_number_seal
            // 
            this.textbox_number_seal.Location = new System.Drawing.Point(6, 43);
            this.textbox_number_seal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_number_seal.Name = "textbox_number_seal";
            this.textbox_number_seal.Size = new System.Drawing.Size(348, 24);
            this.textbox_number_seal.TabIndex = 0;
            // 
            // button_add_seal
            // 
            this.button_add_seal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_add_seal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_seal.Location = new System.Drawing.Point(6, 81);
            this.button_add_seal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_add_seal.Name = "button_add_seal";
            this.button_add_seal.Size = new System.Drawing.Size(348, 50);
            this.button_add_seal.TabIndex = 4;
            this.button_add_seal.Text = "Добавить";
            this.button_add_seal.UseVisualStyleBackColor = false;
            this.button_add_seal.Click += new System.EventHandler(this.Button_add_seal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textbox_number_seal);
            this.groupBox2.Controls.Add(this.button_add_seal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 138);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление пломбиратора";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combobox_sealer_list);
            this.groupBox1.Controls.Add(this.button_delete_seal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 138);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Удаление пломбиратора";
            // 
            // combobox_sealer_list
            // 
            this.combobox_sealer_list.FormattingEnabled = true;
            this.combobox_sealer_list.Location = new System.Drawing.Point(6, 49);
            this.combobox_sealer_list.Name = "combobox_sealer_list";
            this.combobox_sealer_list.Size = new System.Drawing.Size(348, 25);
            this.combobox_sealer_list.TabIndex = 5;
            // 
            // button_delete_seal
            // 
            this.button_delete_seal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_delete_seal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete_seal.Location = new System.Drawing.Point(6, 81);
            this.button_delete_seal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_delete_seal.Name = "button_delete_seal";
            this.button_delete_seal.Size = new System.Drawing.Size(348, 50);
            this.button_delete_seal.TabIndex = 4;
            this.button_delete_seal.Text = "Удалить";
            this.button_delete_seal.UseVisualStyleBackColor = false;
            this.button_delete_seal.Click += new System.EventHandler(this.Button_delete_seal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер пломбиратора";
            // 
            // DatabaseSealsDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 306);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatabaseSealsDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление пломбираторами";
            this.Load += new System.EventHandler(this.DatabaseSealsDirectory_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_number_seal;
        private System.Windows.Forms.Button button_add_seal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combobox_sealer_list;
        private System.Windows.Forms.Button button_delete_seal;
        private System.Windows.Forms.Label label2;
    }
}