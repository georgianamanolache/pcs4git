namespace pcs4_demo_week5_linked_lists
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPlayWith = new System.Windows.Forms.Button();
            this.btnShowHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 225);
            this.listBox1.TabIndex = 1;
            // 
            // btnPlayWith
            // 
            this.btnPlayWith.Location = new System.Drawing.Point(321, 18);
            this.btnPlayWith.Name = "btnPlayWith";
            this.btnPlayWith.Size = new System.Drawing.Size(100, 23);
            this.btnPlayWith.TabIndex = 2;
            this.btnPlayWith.Text = "Play With";
            this.btnPlayWith.UseVisualStyleBackColor = true;
            this.btnPlayWith.Click += new System.EventHandler(this.btnPlayWith_Click);
            // 
            // btnShowHistory
            // 
            this.btnShowHistory.Location = new System.Drawing.Point(322, 48);
            this.btnShowHistory.Name = "btnShowHistory";
            this.btnShowHistory.Size = new System.Drawing.Size(99, 23);
            this.btnShowHistory.TabIndex = 3;
            this.btnShowHistory.Text = "Show History";
            this.btnShowHistory.UseVisualStyleBackColor = true;
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 261);
            this.Controls.Add(this.btnShowHistory);
            this.Controls.Add(this.btnPlayWith);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPlayWith;
        private System.Windows.Forms.Button btnShowHistory;
    }
}

