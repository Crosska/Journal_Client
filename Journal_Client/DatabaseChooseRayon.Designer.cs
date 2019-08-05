namespace Journal_Client
{
    partial class DatabaseChooseRayon
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
            this.combobox_district = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combobox_district
            // 
            this.combobox_district.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combobox_district.FormattingEnabled = true;
            this.combobox_district.Items.AddRange(new object[] {
            "Гвардейский",
            "Горняцкий",
            "Кировский",
            "Советский",
            "Центральный"});
            this.combobox_district.Location = new System.Drawing.Point(12, 69);
            this.combobox_district.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combobox_district.Name = "combobox_district";
            this.combobox_district.Size = new System.Drawing.Size(372, 28);
            this.combobox_district.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите необходимый сервер";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ok
            // 
            this.button_ok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ok.Location = new System.Drawing.Point(390, 69);
            this.button_ok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(102, 28);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.Button_ok_Click);
            // 
            // DatabaseChooseRayon
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(504, 110);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox_district);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatabaseChooseRayon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор сервера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_district;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ok;
    }
}