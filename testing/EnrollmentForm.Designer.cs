namespace testing
{
    partial class EnrollmentForm
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
            label1 = new Label();
            comboStudent = new ComboBox();
            comboCourse = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnEnroll = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 58);
            label1.Name = "label1";
            label1.Size = new Size(121, 30);
            label1.TabIndex = 0;
            label1.Text = "Enrollment";
            // 
            // comboStudent
            // 
            comboStudent.FormattingEnabled = true;
            comboStudent.Location = new Point(115, 100);
            comboStudent.Name = "comboStudent";
            comboStudent.Size = new Size(157, 23);
            comboStudent.TabIndex = 1;
            // 
            // comboCourse
            // 
            comboCourse.FormattingEnabled = true;
            comboCourse.Location = new Point(115, 135);
            comboCourse.Name = "comboCourse";
            comboCourse.Size = new Size(157, 23);
            comboCourse.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 108);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Student:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 143);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Course:";
            // 
            // btnEnroll
            // 
            btnEnroll.Location = new Point(42, 175);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(230, 23);
            btnEnroll.TabIndex = 5;
            btnEnroll.Text = "Enroll";
            btnEnroll.UseVisualStyleBackColor = true;
            // 
            // EnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 258);
            Controls.Add(btnEnroll);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboCourse);
            Controls.Add(comboStudent);
            Controls.Add(label1);
            Name = "EnrollmentForm";
            Text = "EnrollmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboStudent;
        private ComboBox comboCourse;
        private Label label2;
        private Label label3;
        private Button btnEnroll;
    }
}