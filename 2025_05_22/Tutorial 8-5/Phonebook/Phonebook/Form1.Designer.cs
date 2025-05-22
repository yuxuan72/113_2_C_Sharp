namespace Phonebook
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放受控資源，則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDelete = new System.Windows.Forms.Button();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.labelAddName = new System.Windows.Forms.Label();
            this.labelAddPhone = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(71, 178);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "關閉";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 12;
            this.nameListBox.Location = new System.Drawing.Point(43, 70);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(120, 88);
            this.nameListBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "請選擇姓名";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.labelAddName);
            this.groupBoxAdd.Controls.Add(this.labelAddPhone);
            this.groupBoxAdd.Controls.Add(this.nameTextBox);
            this.groupBoxAdd.Controls.Add(this.phoneTextBox);
            this.groupBoxAdd.Location = new System.Drawing.Point(245, 70);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(185, 110);
            this.groupBoxAdd.TabIndex = 13;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "新增通訊錄";
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(30, 48);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(29, 12);
            this.labelAddName.TabIndex = 0;
            this.labelAddName.Text = "姓名";
            // 
            // labelAddPhone
            // 
            this.labelAddPhone.AutoSize = true;
            this.labelAddPhone.Location = new System.Drawing.Point(17, 76);
            this.labelAddPhone.Name = "labelAddPhone";
            this.labelAddPhone.Size = new System.Drawing.Size(53, 12);
            this.labelAddPhone.TabIndex = 1;
            this.labelAddPhone.Text = "電話號碼";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(76, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(94, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(76, 66);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(94, 22);
            this.phoneTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 241);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.buttonDelete);
            this.Name = "Form1";
            this.Text = "電話簿";
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFile;
        // 新增 GroupBox 與其內部元件
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Label labelAddName;
        private System.Windows.Forms.Label labelAddPhone;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
    }
}
