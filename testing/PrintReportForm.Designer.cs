namespace testing
{
    partial class PrintReportForm
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
            printPreviewControl1 = new PrintPreviewControl();
            btnPrint = new Button();
            btnClose = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 54);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 0;
            label1.Text = "Print Reports";
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Location = new Point(62, 89);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(226, 100);
            printPreviewControl1.TabIndex = 1;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(62, 195);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(108, 23);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(176, 195);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // PrintReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 271);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(printPreviewControl1);
            Controls.Add(label1);
            Name = "PrintReportForm";
            Text = "PrintReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PrintPreviewControl printPreviewControl1;
        private Button btnPrint;
        private Button btnClose;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}