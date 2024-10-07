namespace StudentInfoApplication
{
    partial class Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_studentID = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.lb_studentID = new System.Windows.Forms.ListBox();
            this.lb_firstName = new System.Windows.Forms.ListBox();
            this.lb_lastName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student ID List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name List";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(491, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_studentID
            // 
            this.tb_studentID.Location = new System.Drawing.Point(12, 59);
            this.tb_studentID.Name = "tb_studentID";
            this.tb_studentID.Size = new System.Drawing.Size(178, 20);
            this.tb_studentID.TabIndex = 7;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(199, 59);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(178, 20);
            this.tb_lastName.TabIndex = 8;
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(383, 59);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(178, 20);
            this.tb_firstName.TabIndex = 9;
            // 
            // lb_studentID
            // 
            this.lb_studentID.FormattingEnabled = true;
            this.lb_studentID.Location = new System.Drawing.Point(37, 147);
            this.lb_studentID.Name = "lb_studentID";
            this.lb_studentID.Size = new System.Drawing.Size(134, 134);
            this.lb_studentID.TabIndex = 10;
            // 
            // lb_firstName
            // 
            this.lb_firstName.FormattingEnabled = true;
            this.lb_firstName.Location = new System.Drawing.Point(199, 147);
            this.lb_firstName.Name = "lb_firstName";
            this.lb_firstName.Size = new System.Drawing.Size(134, 134);
            this.lb_firstName.TabIndex = 11;
            // 
            // lb_lastName
            // 
            this.lb_lastName.FormattingEnabled = true;
            this.lb_lastName.Location = new System.Drawing.Point(370, 147);
            this.lb_lastName.Name = "lb_lastName";
            this.lb_lastName.Size = new System.Drawing.Size(134, 134);
            this.lb_lastName.TabIndex = 12;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentInfoApplication.Properties.Resources.backgroundstudentinfo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 305);
            this.Controls.Add(this.lb_lastName);
            this.Controls.Add(this.lb_firstName);
            this.Controls.Add(this.lb_studentID);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.tb_studentID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form";
            this.Text = "StudentInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_studentID;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.ListBox lb_studentID;
        private System.Windows.Forms.ListBox lb_firstName;
        private System.Windows.Forms.ListBox lb_lastName;
    }
}

