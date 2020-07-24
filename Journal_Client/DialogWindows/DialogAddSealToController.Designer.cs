namespace Journal_Client
{
    partial class DialogAddSealToController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAddSealToController));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combobox_seal_number = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add_link = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combobox_seal_number);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(321, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить пломбиратор к контроллеру";
            // 
            // combobox_seal_number
            // 
            this.combobox_seal_number.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combobox_seal_number.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_seal_number.FormattingEnabled = true;
            this.combobox_seal_number.Location = new System.Drawing.Point(6, 43);
            this.combobox_seal_number.Name = "combobox_seal_number";
            this.combobox_seal_number.Size = new System.Drawing.Size(309, 25);
            this.combobox_seal_number.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер пломбиратора";
            // 
            // button_add_link
            // 
            this.button_add_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add_link.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_link.Location = new System.Drawing.Point(12, 89);
            this.button_add_link.Name = "button_add_link";
            this.button_add_link.Size = new System.Drawing.Size(321, 43);
            this.button_add_link.TabIndex = 1;
            this.button_add_link.Text = "Добавить";
            this.button_add_link.UseVisualStyleBackColor = true;
            this.button_add_link.Click += new System.EventHandler(this.Button_add_link_Click);
            // 
            // DialogAddSealToController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(347, 145);
            this.Controls.Add(this.button_add_link);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DialogAddSealToController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор пломбиратора";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combobox_seal_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add_link;
    }
}