namespace pcs4_demo_week3_all_types_sorting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSortByStudentNumber = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStortByFirstName = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSortByLastName = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSortByGrade = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 225);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSortByStudentNumber);
            this.groupBox1.Location = new System.Drawing.Point(338, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student number";
            // 
            // btnSortByStudentNumber
            // 
            this.btnSortByStudentNumber.Location = new System.Drawing.Point(6, 19);
            this.btnSortByStudentNumber.Name = "btnSortByStudentNumber";
            this.btnSortByStudentNumber.Size = new System.Drawing.Size(172, 23);
            this.btnSortByStudentNumber.TabIndex = 6;
            this.btnSortByStudentNumber.Text = "Sort (IComparable)";
            this.btnSortByStudentNumber.UseVisualStyleBackColor = true;
            this.btnSortByStudentNumber.Click += new System.EventHandler(this.btnSortByStudentNumber_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStortByFirstName);
            this.groupBox2.Location = new System.Drawing.Point(338, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 53);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "First name";
            // 
            // btnStortByFirstName
            // 
            this.btnStortByFirstName.Location = new System.Drawing.Point(6, 19);
            this.btnStortByFirstName.Name = "btnStortByFirstName";
            this.btnStortByFirstName.Size = new System.Drawing.Size(172, 23);
            this.btnStortByFirstName.TabIndex = 6;
            this.btnStortByFirstName.Text = "Sort (selection sort algo)";
            this.btnStortByFirstName.UseVisualStyleBackColor = true;
            this.btnStortByFirstName.Click += new System.EventHandler(this.btnStortByFirstName_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSortByLastName);
            this.groupBox3.Location = new System.Drawing.Point(338, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 53);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Last name";
            // 
            // btnSortByLastName
            // 
            this.btnSortByLastName.Location = new System.Drawing.Point(6, 19);
            this.btnSortByLastName.Name = "btnSortByLastName";
            this.btnSortByLastName.Size = new System.Drawing.Size(172, 23);
            this.btnSortByLastName.TabIndex = 6;
            this.btnSortByLastName.Text = "Sort (delegate)";
            this.btnSortByLastName.UseVisualStyleBackColor = true;
            this.btnSortByLastName.Click += new System.EventHandler(this.btnSortByLastName_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSortByGrade);
            this.groupBox4.Location = new System.Drawing.Point(338, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 53);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grade";
            // 
            // btnSortByGrade
            // 
            this.btnSortByGrade.Location = new System.Drawing.Point(6, 19);
            this.btnSortByGrade.Name = "btnSortByGrade";
            this.btnSortByGrade.Size = new System.Drawing.Size(172, 23);
            this.btnSortByGrade.TabIndex = 6;
            this.btnSortByGrade.Text = "Sort (delegate)";
            this.btnSortByGrade.UseVisualStyleBackColor = true;
            this.btnSortByGrade.Click += new System.EventHandler(this.btnSortByGrade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 251);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "PCS4 class overview";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSortByStudentNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStortByFirstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSortByLastName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSortByGrade;
    }
}

