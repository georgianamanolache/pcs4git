namespace pcs4_demo_week6_binary_tree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPreorder = new System.Windows.Forms.Button();
            this.btnInorder = new System.Windows.Forms.Button();
            this.btnPostorder = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPreorder
            // 
            this.btnPreorder.Location = new System.Drawing.Point(12, 160);
            this.btnPreorder.Name = "btnPreorder";
            this.btnPreorder.Size = new System.Drawing.Size(75, 23);
            this.btnPreorder.TabIndex = 0;
            this.btnPreorder.Text = "Preorder";
            this.btnPreorder.UseVisualStyleBackColor = true;
            this.btnPreorder.Click += new System.EventHandler(this.btnPreorder_Click);
            // 
            // btnInorder
            // 
            this.btnInorder.Location = new System.Drawing.Point(113, 160);
            this.btnInorder.Name = "btnInorder";
            this.btnInorder.Size = new System.Drawing.Size(75, 23);
            this.btnInorder.TabIndex = 1;
            this.btnInorder.Text = "Inorder";
            this.btnInorder.UseVisualStyleBackColor = true;
            this.btnInorder.Click += new System.EventHandler(this.btnInorder_Click);
            // 
            // btnPostorder
            // 
            this.btnPostorder.Location = new System.Drawing.Point(215, 160);
            this.btnPostorder.Name = "btnPostorder";
            this.btnPostorder.Size = new System.Drawing.Size(75, 23);
            this.btnPostorder.TabIndex = 2;
            this.btnPostorder.Text = "Postorder";
            this.btnPostorder.UseVisualStyleBackColor = true;
            this.btnPostorder.Click += new System.EventHandler(this.btnPostorder_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(55, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(188, 105);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(55, 124);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(36, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Order:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 195);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnPostorder);
            this.Controls.Add(this.btnInorder);
            this.Controls.Add(this.btnPreorder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreorder;
        private System.Windows.Forms.Button btnInorder;
        private System.Windows.Forms.Button btnPostorder;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblResult;
    }
}

