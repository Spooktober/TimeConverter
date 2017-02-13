namespace TimeConverter
{
    partial class TimeConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeConverter));
            this.TimeAddBtn = new System.Windows.Forms.Button();
            this.TimeSubstractBtn = new System.Windows.Forms.Button();
            this.TimeDiffLabel = new System.Windows.Forms.Label();
            this.TimeDifference = new System.Windows.Forms.TextBox();
            this.TimeResult = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeInBox = new System.Windows.Forms.TextBox();
            this.PasteTimeBtn = new System.Windows.Forms.Button();
            this.CopyTimeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeAddBtn
            // 
            this.TimeAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TimeAddBtn.Location = new System.Drawing.Point(13, 13);
            this.TimeAddBtn.Name = "TimeAddBtn";
            this.TimeAddBtn.Size = new System.Drawing.Size(110, 69);
            this.TimeAddBtn.TabIndex = 0;
            this.TimeAddBtn.Text = "+";
            this.TimeAddBtn.UseVisualStyleBackColor = true;
            this.TimeAddBtn.Click += new System.EventHandler(this.TimeAddBtn_Click);
            // 
            // TimeSubstractBtn
            // 
            this.TimeSubstractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TimeSubstractBtn.Location = new System.Drawing.Point(248, 13);
            this.TimeSubstractBtn.Name = "TimeSubstractBtn";
            this.TimeSubstractBtn.Size = new System.Drawing.Size(110, 69);
            this.TimeSubstractBtn.TabIndex = 0;
            this.TimeSubstractBtn.Text = "-";
            this.TimeSubstractBtn.UseVisualStyleBackColor = true;
            this.TimeSubstractBtn.Click += new System.EventHandler(this.TimeSubstractBtn_Click);
            // 
            // TimeDiffLabel
            // 
            this.TimeDiffLabel.AutoSize = true;
            this.TimeDiffLabel.Location = new System.Drawing.Point(130, 13);
            this.TimeDiffLabel.Name = "TimeDiffLabel";
            this.TimeDiffLabel.Size = new System.Drawing.Size(82, 13);
            this.TimeDiffLabel.TabIndex = 1;
            this.TimeDiffLabel.Text = "Time Difference";
            // 
            // TimeDifference
            // 
            this.TimeDifference.Location = new System.Drawing.Point(133, 30);
            this.TimeDifference.Name = "TimeDifference";
            this.TimeDifference.Size = new System.Drawing.Size(109, 20);
            this.TimeDifference.TabIndex = 2;
            // 
            // TimeResult
            // 
            this.TimeResult.Location = new System.Drawing.Point(133, 109);
            this.TimeResult.Name = "TimeResult";
            this.TimeResult.Size = new System.Drawing.Size(109, 20);
            this.TimeResult.TabIndex = 3;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(130, 93);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 13);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time To Convert";
            // 
            // TimeInBox
            // 
            this.TimeInBox.Location = new System.Drawing.Point(133, 70);
            this.TimeInBox.Name = "TimeInBox";
            this.TimeInBox.Size = new System.Drawing.Size(109, 20);
            this.TimeInBox.TabIndex = 6;
            // 
            // PasteTimeBtn
            // 
            this.PasteTimeBtn.Location = new System.Drawing.Point(13, 89);
            this.PasteTimeBtn.Name = "PasteTimeBtn";
            this.PasteTimeBtn.Size = new System.Drawing.Size(110, 40);
            this.PasteTimeBtn.TabIndex = 7;
            this.PasteTimeBtn.Text = "Paste";
            this.PasteTimeBtn.UseVisualStyleBackColor = true;
            this.PasteTimeBtn.Click += new System.EventHandler(this.PasteTimeBtn_Click);
            // 
            // CopyTimeBtn
            // 
            this.CopyTimeBtn.Location = new System.Drawing.Point(249, 89);
            this.CopyTimeBtn.Name = "CopyTimeBtn";
            this.CopyTimeBtn.Size = new System.Drawing.Size(109, 40);
            this.CopyTimeBtn.TabIndex = 8;
            this.CopyTimeBtn.Text = "Copy";
            this.CopyTimeBtn.UseVisualStyleBackColor = true;
            this.CopyTimeBtn.Click += new System.EventHandler(this.CopyTimeBtn_Click);
            // 
            // TimeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 139);
            this.Controls.Add(this.CopyTimeBtn);
            this.Controls.Add(this.PasteTimeBtn);
            this.Controls.Add(this.TimeInBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.TimeResult);
            this.Controls.Add(this.TimeDifference);
            this.Controls.Add(this.TimeDiffLabel);
            this.Controls.Add(this.TimeSubstractBtn);
            this.Controls.Add(this.TimeAddBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeConverter";
            this.Text = "TimeConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TimeAddBtn;
        private System.Windows.Forms.Button TimeSubstractBtn;
        private System.Windows.Forms.Label TimeDiffLabel;
        private System.Windows.Forms.TextBox TimeDifference;
        private System.Windows.Forms.TextBox TimeResult;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimeInBox;
        private System.Windows.Forms.Button PasteTimeBtn;
        private System.Windows.Forms.Button CopyTimeBtn;
    }
}

