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
            this.SuspendLayout();
            // 
            // combocox_rayon
            // 
            this.combocox_rayon.FormattingEnabled = true;
            this.combocox_rayon.Location = new System.Drawing.Point(264, 116);
            this.combocox_rayon.Name = "combocox_rayon";
            this.combocox_rayon.Size = new System.Drawing.Size(121, 21);
            this.combocox_rayon.TabIndex = 0;
            // 
            // DatabaseChooseRayon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combocox_rayon);
            this.Name = "DatabaseChooseRayon";
            this.Text = "Выбор района";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseAll);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combocox_rayon;
    }
}