namespace Journal_Client
{
    partial class DatabaseChangeMeter
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
            this.combobox_old_meter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_personal_account = new System.Windows.Forms.Label();
            this.numeric_new_meter = new System.Windows.Forms.NumericUpDown();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_new_meter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Старые показания";
            // 
            // combobox_old_meter
            // 
            this.combobox_old_meter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combobox_old_meter.FormattingEnabled = true;
            this.combobox_old_meter.Location = new System.Drawing.Point(178, 38);
            this.combobox_old_meter.Name = "combobox_old_meter";
            this.combobox_old_meter.Size = new System.Drawing.Size(181, 29);
            this.combobox_old_meter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Новые показания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "На лицевом счёту:";
            // 
            // label_personal_account
            // 
            this.label_personal_account.AutoSize = true;
            this.label_personal_account.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_personal_account.Location = new System.Drawing.Point(173, 9);
            this.label_personal_account.Name = "label_personal_account";
            this.label_personal_account.Size = new System.Drawing.Size(25, 21);
            this.label_personal_account.TabIndex = 5;
            this.label_personal_account.Text = "---";
            // 
            // numeric_new_meter
            // 
            this.numeric_new_meter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric_new_meter.Location = new System.Drawing.Point(178, 73);
            this.numeric_new_meter.Name = "numeric_new_meter";
            this.numeric_new_meter.Size = new System.Drawing.Size(181, 27);
            this.numeric_new_meter.TabIndex = 6;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(12, 112);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(172, 39);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Отменить";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // button_apply
            // 
            this.button_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_apply.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_apply.Location = new System.Drawing.Point(190, 112);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(168, 39);
            this.button_apply.TabIndex = 8;
            this.button_apply.Text = "Применить";
            this.button_apply.UseVisualStyleBackColor = false;
            // 
            // DatabaseChangeMeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 163);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.numeric_new_meter);
            this.Controls.Add(this.label_personal_account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combobox_old_meter);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatabaseChangeMeter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить показания";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_new_meter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_old_meter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_personal_account;
        private System.Windows.Forms.NumericUpDown numeric_new_meter;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_apply;
    }
}