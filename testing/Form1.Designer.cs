namespace testing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnStudentRecords = new Button();
            btnEnrollment = new Button();
            btnReports = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnAddStudent = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(611, 259);
            label1.Name = "label1";
            label1.Size = new Size(258, 30);
            label1.TabIndex = 0;
            label1.Text = "Student Manager System";
            label1.Click += label1_Click;
            // 
            // btnStudentRecords
            // 
            btnStudentRecords.Location = new Point(608, 347);
            btnStudentRecords.Name = "btnStudentRecords";
            btnStudentRecords.Size = new Size(130, 23);
            btnStudentRecords.TabIndex = 1;
            btnStudentRecords.Text = "Student Records";
            btnStudentRecords.UseVisualStyleBackColor = true;
            // 
            // btnEnrollment
            // 
            btnEnrollment.Location = new Point(744, 306);
            btnEnrollment.Name = "btnEnrollment";
            btnEnrollment.Size = new Size(130, 23);
            btnEnrollment.TabIndex = 2;
            btnEnrollment.Text = "Enrollment";
            btnEnrollment.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(744, 347);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(130, 23);
            btnReports.TabIndex = 4;
            btnReports.Text = "Print Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Location = new Point(592, 246);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 142);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Navy;
            pictureBox2.Location = new Point(569, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(347, 179);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(608, 306);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(130, 23);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(289, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 100);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 645);
            Controls.Add(btnAddStudent);
            Controls.Add(panel1);
            Controls.Add(btnReports);
            Controls.Add(btnEnrollment);
            Controls.Add(btnStudentRecords);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStudentRecords;
        private Button btnEnrollment;
        private Button btnReports;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnAddStudent;
        private Panel panel1;
    }
}
