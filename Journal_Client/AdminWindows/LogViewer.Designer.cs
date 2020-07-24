namespace Journal_Client.AdminWindows
{
    partial class LogViewer
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
            this.datagridview_log_file = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_log_file)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview_log_file
            // 
            this.datagridview_log_file.AllowUserToAddRows = false;
            this.datagridview_log_file.AllowUserToDeleteRows = false;
            this.datagridview_log_file.AllowUserToResizeRows = false;
            this.datagridview_log_file.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_log_file.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview_log_file.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridview_log_file.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_log_file.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.datagridview_log_file.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.datagridview_log_file.Location = new System.Drawing.Point(14, 13);
            this.datagridview_log_file.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagridview_log_file.Name = "datagridview_log_file";
            this.datagridview_log_file.ReadOnly = true;
            this.datagridview_log_file.RowHeadersVisible = false;
            this.datagridview_log_file.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_log_file.Size = new System.Drawing.Size(750, 434);
            this.datagridview_log_file.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Время события";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 106;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Логин сотрудника";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 123;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Выполненное действие";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 148;
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_refresh.Location = new System.Drawing.Point(14, 455);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(750, 37);
            this.button_refresh.TabIndex = 1;
            this.button_refresh.Text = "Обновить лог";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // LogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(776, 505);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.datagridview_log_file);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LogViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Файл логирования";
            this.Load += new System.EventHandler(this.LogViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_log_file)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview_log_file;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}