namespace Journal_Client
{
    partial class DialogAddMeter
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
            this.label2 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label_personal_account = new System.Windows.Forms.Label();
            this.numeric_meter = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox_date = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_seal_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numeric_saldo = new System.Windows.Forms.NumericUpDown();
            this.combobox_controller = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_meter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_saldo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "На лицевой счет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Показания";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(11, 226);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(140, 40);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Отменить";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(158, 226);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(133, 40);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // label_personal_account
            // 
            this.label_personal_account.AutoSize = true;
            this.label_personal_account.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_personal_account.Location = new System.Drawing.Point(150, 9);
            this.label_personal_account.Name = "label_personal_account";
            this.label_personal_account.Size = new System.Drawing.Size(25, 21);
            this.label_personal_account.TabIndex = 6;
            this.label_personal_account.Text = "---";
            // 
            // numeric_meter
            // 
            this.numeric_meter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric_meter.Location = new System.Drawing.Point(127, 40);
            this.numeric_meter.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numeric_meter.Name = "numeric_meter";
            this.numeric_meter.Size = new System.Drawing.Size(164, 27);
            this.numeric_meter.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата обхода";
            // 
            // combobox_date
            // 
            this.combobox_date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combobox_date.FormattingEnabled = true;
            this.combobox_date.Location = new System.Drawing.Point(127, 74);
            this.combobox_date.Name = "combobox_date";
            this.combobox_date.Size = new System.Drawing.Size(164, 29);
            this.combobox_date.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "№ пломбы";
            // 
            // textbox_seal_number
            // 
            this.textbox_seal_number.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_seal_number.Location = new System.Drawing.Point(127, 110);
            this.textbox_seal_number.Name = "textbox_seal_number";
            this.textbox_seal_number.Size = new System.Drawing.Size(164, 27);
            this.textbox_seal_number.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Сальдо";
            // 
            // numeric_saldo
            // 
            this.numeric_saldo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.numeric_saldo.Location = new System.Drawing.Point(127, 146);
            this.numeric_saldo.Name = "numeric_saldo";
            this.numeric_saldo.Size = new System.Drawing.Size(164, 27);
            this.numeric_saldo.TabIndex = 14;
            // 
            // combobox_controller
            // 
            this.combobox_controller.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combobox_controller.FormattingEnabled = true;
            this.combobox_controller.Location = new System.Drawing.Point(127, 179);
            this.combobox_controller.Name = "combobox_controller";
            this.combobox_controller.Size = new System.Drawing.Size(164, 29);
            this.combobox_controller.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Контролер";
            // 
            // DialogAddMeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 278);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combobox_controller);
            this.Controls.Add(this.numeric_saldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textbox_seal_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combobox_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numeric_meter);
            this.Controls.Add(this.label_personal_account);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "DialogAddMeter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить показания";
            this.Load += new System.EventHandler(this.DialogAddMeter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_meter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_saldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_personal_account;
        private System.Windows.Forms.NumericUpDown numeric_meter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_seal_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numeric_saldo;
        private System.Windows.Forms.ComboBox combobox_controller;
        private System.Windows.Forms.Label label6;
    }
}