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
            this.combocox_rayon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combocox_rayon
            // 
            this.combocox_rayon.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combocox_rayon.FormattingEnabled = true;
            this.combocox_rayon.Location = new System.Drawing.Point(17, 57);
            this.combocox_rayon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combocox_rayon.Name = "combocox_rayon";
            this.combocox_rayon.Size = new System.Drawing.Size(250, 25);
            this.combocox_rayon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите район города";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ok
            // 
            this.button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ok.Location = new System.Drawing.Point(17, 105);
            this.button_ok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(250, 37);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // DatabaseChooseRayon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 155);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combocox_rayon);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatabaseChooseRayon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор района";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseAll);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combocox_rayon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ok;
    }
}