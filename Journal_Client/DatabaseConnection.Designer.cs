namespace Journal_Client
{
    partial class DatabaseConnection
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.label_connect = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.timer_fake_progress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(36, 77);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(425, 27);
            this.progress_bar.TabIndex = 0;
            // 
            // label_connect
            // 
            this.label_connect.AutoSize = true;
            this.label_connect.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connect.Location = new System.Drawing.Point(74, 16);
            this.label_connect.Name = "label_connect";
            this.label_connect.Size = new System.Drawing.Size(353, 22);
            this.label_connect.TabIndex = 1;
            this.label_connect.Text = "Подключение к онлайн базе данных";
            this.label_connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ok
            // 
            this.button_ok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.Location = new System.Drawing.Point(393, 123);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(100, 31);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // DatabaseConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(498, 159);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_connect);
            this.Controls.Add(this.progress_bar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DatabaseConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение к журналу";
            this.Load += new System.EventHandler(this.DatabaseConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress_bar;
        private System.Windows.Forms.Label label_connect;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Timer timer_fake_progress;
    }
}

