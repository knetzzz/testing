namespace testing
{
    partial class EditStudentForm
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
            lblFullName = new TextBox();
            lblAge = new TextBox();
            lblCourse = new TextBox();
            lblYearLevel = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 176);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 12;
            label1.Text = "Full Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 205);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 13;
            label2.Text = " Age: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 238);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 14;
            label3.Text = "Course:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 273);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 15;
            label4.Text = "Year Level:";
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(444, 168);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(193, 23);
            lblFullName.TabIndex = 16;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(444, 197);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(193, 23);
            lblAge.TabIndex = 17;
            // 
            // lblCourse
            // 
            lblCourse.Location = new Point(444, 230);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(193, 23);
            lblCourse.TabIndex = 18;
            // 
            // lblYearLevel
            // 
            lblYearLevel.Location = new Point(444, 265);
            lblYearLevel.Name = "lblYearLevel";
            lblYearLevel.Size = new Size(193, 23);
            lblYearLevel.TabIndex = 19;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(325, 300);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(355, 24);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = " Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(325, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(355, 23);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(325, 359);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(355, 23);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(419, 129);
            label5.Name = "label5";
            label5.Size = new Size(160, 32);
            label5.TabIndex = 23;
            label5.Text = " Edit Student";
            // 
            // EditStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 627);
            Controls.Add(label5);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblYearLevel);
            Controls.Add(lblCourse);
            Controls.Add(lblAge);
            Controls.Add(lblFullName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditStudentForm";
            Text = "EditStudentForm";
            Load += EditStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox lblFullName;
        private TextBox lblAge;
        private TextBox lblCourse;
        private TextBox lblYearLevel;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCancel;
        private Label label5;
    }
}