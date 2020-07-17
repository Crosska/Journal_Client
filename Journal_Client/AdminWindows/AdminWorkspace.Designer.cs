namespace Journal_Client.AdminWindows
{
    partial class AdminWorkspace
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
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobutton_users = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToDeleteRows = false;
            this.datagridview.AllowUserToResizeRows = false;
            this.datagridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.datagridview.Location = new System.Drawing.Point(282, 14);
            this.datagridview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridview.Name = "datagridview";
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview.Size = new System.Drawing.Size(386, 438);
            this.datagridview.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobutton_users);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(261, 438);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // radiobutton_users
            // 
            this.radiobutton_users.AutoSize = true;
            this.radiobutton_users.Checked = true;
            this.radiobutton_users.Location = new System.Drawing.Point(16, 27);
            this.radiobutton_users.Name = "radiobutton_users";
            this.radiobutton_users.Size = new System.Drawing.Size(222, 24);
            this.radiobutton_users.TabIndex = 0;
            this.radiobutton_users.TabStop = true;
            this.radiobutton_users.Text = "Пользователи программы";
            this.radiobutton_users.UseVisualStyleBackColor = true;
            this.radiobutton_users.CheckedChanged += new System.EventHandler(this.radiobutton_users_checked);
            // 
            // AdminWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagridview);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminWorkspace";
            this.Text = "Панель управления";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobutton_users;
    }
}