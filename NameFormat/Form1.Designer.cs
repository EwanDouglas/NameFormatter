namespace NameFormat
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
            lblFirst = new Label();
            lblMiddle = new Label();
            lblLast = new Label();
            lblTitle = new Label();
            lstOutput = new ListBox();
            txtFirst = new TextBox();
            txtMiddle = new TextBox();
            txtLast = new TextBox();
            txtTitle = new TextBox();
            btnShow = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirst.Location = new Point(90, 64);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(89, 21);
            lblFirst.TabIndex = 0;
            lblFirst.Text = "First Name:";
            // 
            // lblMiddle
            // 
            lblMiddle.AutoSize = true;
            lblMiddle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMiddle.Location = new Point(90, 126);
            lblMiddle.Name = "lblMiddle";
            lblMiddle.Size = new Size(107, 21);
            lblMiddle.TabIndex = 1;
            lblMiddle.Text = "Middle Name:";
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLast.Location = new Point(90, 197);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(87, 21);
            lblLast.TabIndex = 2;
            lblLast.Text = "Last Name:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(90, 259);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title:";
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 15;
            lstOutput.Location = new Point(90, 322);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(330, 199);
            lstOutput.TabIndex = 4;
            // 
            // txtFirst
            // 
            txtFirst.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirst.Location = new Point(217, 61);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(203, 29);
            txtFirst.TabIndex = 5;
            // 
            // txtMiddle
            // 
            txtMiddle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMiddle.Location = new Point(217, 123);
            txtMiddle.Name = "txtMiddle";
            txtMiddle.Size = new Size(203, 29);
            txtMiddle.TabIndex = 6;
            // 
            // txtLast
            // 
            txtLast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLast.Location = new Point(217, 189);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(203, 29);
            txtLast.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(217, 256);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(203, 29);
            txtTitle.TabIndex = 8;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.FromArgb(192, 255, 192);
            btnShow.Location = new Point(675, 301);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(153, 47);
            btnShow.TabIndex = 9;
            btnShow.Text = "Show Name:";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(675, 370);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(153, 47);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 192);
            btnExit.Location = new Point(675, 444);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(153, 47);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 545);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnShow);
            Controls.Add(txtTitle);
            Controls.Add(txtLast);
            Controls.Add(txtMiddle);
            Controls.Add(txtFirst);
            Controls.Add(lstOutput);
            Controls.Add(lblTitle);
            Controls.Add(lblLast);
            Controls.Add(lblMiddle);
            Controls.Add(lblFirst);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirst;
        private Label lblMiddle;
        private Label lblLast;
        private Label lblTitle;
        private ListBox lstOutput;
        private TextBox txtFirst;
        private TextBox txtMiddle;
        private TextBox txtLast;
        private TextBox txtTitle;
        private Button btnShow;
        private Button btnClear;
        private Button btnExit;
    }
}