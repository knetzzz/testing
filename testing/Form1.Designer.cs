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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnStudentRecords = new Button();
            btnEnrollment = new Button();
            btnReports = new Button();
            btnAddStudent = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 33);
            label1.Name = "label1";
            label1.Size = new Size(539, 55);
            label1.TabIndex = 0;
            label1.Text = "Student Manager System";
            label1.Click += label1_Click;
            // 
            // btnStudentRecords
            // 
            btnStudentRecords.BackColor = Color.Silver;
            btnStudentRecords.Location = new Point(22, 59);
            btnStudentRecords.Name = "btnStudentRecords";
            btnStudentRecords.Size = new Size(130, 23);
            btnStudentRecords.TabIndex = 1;
            btnStudentRecords.Text = "Student Records";
            btnStudentRecords.UseVisualStyleBackColor = false;
            // 
            // btnEnrollment
            // 
            btnEnrollment.BackColor = Color.Silver;
            btnEnrollment.Location = new Point(18, 59);
            btnEnrollment.Name = "btnEnrollment";
            btnEnrollment.Size = new Size(130, 23);
            btnEnrollment.TabIndex = 2;
            btnEnrollment.Text = "Enrollment";
            btnEnrollment.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Silver;
            btnReports.Location = new Point(18, 59);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(130, 23);
            btnReports.TabIndex = 4;
            btnReports.Text = "Print Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.Silver;
            btnAddStudent.Location = new Point(22, 59);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(130, 23);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnAddStudent);
            panel1.Location = new Point(106, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 85);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.download__18_;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.download__18_;
            pictureBox2.Location = new Point(63, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(btnEnrollment);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(293, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 85);
            panel2.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.download__19_;
            pictureBox3.ErrorImage = Properties.Resources.download__19_;
            pictureBox3.Image = Properties.Resources.download__19_;
            pictureBox3.InitialImage = Properties.Resources.download__19_;
            pictureBox3.Location = new Point(32, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 79);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(btnStudentRecords);
            panel3.Location = new Point(106, 242);
            panel3.Name = "panel3";
            panel3.Size = new Size(168, 85);
            panel3.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.ErrorImage = (Image)resources.GetObject("pictureBox4.ErrorImage");
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(41, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(87, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(btnReports);
            panel4.Location = new Point(293, 242);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 85);
            panel4.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Location = new Point(1, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(560, 393);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(578, 409);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStudentRecords;
        private Button btnEnrollment;
        private Button btnReports;
        private Button btnAddStudent;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
