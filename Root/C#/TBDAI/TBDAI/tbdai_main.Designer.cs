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
            this.components = new System.ComponentModel.Container();
            this.inputTxtBox = new System.Windows.Forms.RichTextBox();
            this.outputTxtBox = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.thinkLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTxtBox
            // 
            this.inputTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.inputTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTxtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.inputTxtBox.Location = new System.Drawing.Point(23, 22);
            this.inputTxtBox.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.inputTxtBox.MaxLength = 255;
            this.inputTxtBox.Name = "inputTxtBox";
            this.inputTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.inputTxtBox.Size = new System.Drawing.Size(373, 63);
            this.inputTxtBox.TabIndex = 0;
            this.inputTxtBox.Text = "";
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.outputTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTxtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.outputTxtBox.Location = new System.Drawing.Point(23, 135);
            this.outputTxtBox.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.ReadOnly = true;
            this.outputTxtBox.Size = new System.Drawing.Size(373, 167);
            this.outputTxtBox.TabIndex = 20;
            this.outputTxtBox.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.sendBtn.Location = new System.Drawing.Point(415, 22);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(69, 63);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // thinkLbl
            // 
            this.thinkLbl.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thinkLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thinkLbl.Location = new System.Drawing.Point(20, 111);
            this.thinkLbl.Name = "thinkLbl";
            this.thinkLbl.Size = new System.Drawing.Size(92, 16);
            this.thinkLbl.TabIndex = 21;
            this.thinkLbl.Text = "Thinking..";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(321, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "255 / 255";
            // 
            // tbdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(652, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thinkLbl);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.outputTxtBox);
            this.Controls.Add(this.inputTxtBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "tbdForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTxtBox;
        private System.Windows.Forms.RichTextBox outputTxtBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label thinkLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

