namespace testing
{
    partial class AddStudentForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFullName = new TextBox();
            txtAge = new TextBox();
            txtCourse = new TextBox();
            txtYearLevel = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 26);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 0;
            label1.Text = "AddStudent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 77);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Full Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 103);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 135);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Course:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 162);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 4;
            label5.Text = "Year Level:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(141, 69);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(169, 23);
            txtFullName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(141, 100);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(169, 23);
            txtAge.TabIndex = 6;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(141, 127);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(169, 23);
            txtCourse.TabIndex = 7;
            // 
            // txtYearLevel
            // 
            txtYearLevel.Location = new Point(141, 159);
            txtYearLevel.Name = "txtYearLevel";
            txtYearLevel.Size = new Size(169, 23);
            txtYearLevel.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(60, 188);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(185, 188);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 217);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 266);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtYearLevel);
            Controls.Add(txtCourse);
            Controls.Add(txtAge);
            Controls.Add(txtFullName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFullName;
        private TextBox txtAge;
        private TextBox txtCourse;
        private TextBox txtYearLevel;
        private Button btnSave;
        private Button btnCancel;
        private PictureBox pictureBox1;
    }
}