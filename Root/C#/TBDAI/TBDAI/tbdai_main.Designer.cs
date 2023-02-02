namespace TBDAI
{
    partial class tbdForm
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
            this.inputTxtBox = new System.Windows.Forms.RichTextBox();
            this.outputTxtBox = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTxtBox
            // 
            this.inputTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.inputTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTxtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.inputTxtBox.Location = new System.Drawing.Point(34, 34);
            this.inputTxtBox.Margin = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.inputTxtBox.MaxLength = 244;
            this.inputTxtBox.Name = "inputTxtBox";
            this.inputTxtBox.Size = new System.Drawing.Size(560, 97);
            this.inputTxtBox.TabIndex = 0;
            this.inputTxtBox.Text = "";
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.outputTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTxtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.outputTxtBox.Location = new System.Drawing.Point(34, 208);
            this.outputTxtBox.Margin = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.ReadOnly = true;
            this.outputTxtBox.Size = new System.Drawing.Size(560, 257);
            this.outputTxtBox.TabIndex = 20;
            this.outputTxtBox.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.sendBtn.Location = new System.Drawing.Point(623, 34);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(104, 97);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // tbdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(978, 498);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.outputTxtBox);
            this.Controls.Add(this.inputTxtBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tbdForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTxtBox;
        private System.Windows.Forms.RichTextBox outputTxtBox;
        private System.Windows.Forms.Button sendBtn;
    }
}

