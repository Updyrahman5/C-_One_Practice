namespace wee5
{
    partial class lblSemester
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
            lblName = new Label();
            lblstudentID = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtStudentId = new TextBox();
            txtSemester = new TextBox();
            btnCalculate = new Button();
            btnreset = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(128, 72);
            lblName.Name = "lblName";
            lblName.Size = new Size(37, 15);
            lblName.TabIndex = 0;
            lblName.Text = "name";
            // 
            // lblstudentID
            // 
            lblstudentID.AutoSize = true;
            lblstudentID.Location = new Point(128, 122);
            lblstudentID.Name = "lblstudentID";
            lblstudentID.Size = new Size(60, 15);
            lblstudentID.TabIndex = 1;
            lblstudentID.Text = "student id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 173);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // txtName
            // 
            txtName.Location = new Point(235, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(235, 114);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(100, 23);
            txtStudentId.TabIndex = 4;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(235, 173);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(100, 23);
            txtSemester.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Red;
            btnCalculate.Location = new Point(115, 220);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(89, 71);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnreset
            // 
            btnreset.BackColor = Color.Yellow;
            btnreset.Location = new Point(235, 215);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(100, 76);
            btnreset.TabIndex = 7;
            btnreset.Text = "reset";
            btnreset.UseVisualStyleBackColor = false;
            // 
            // lblSemester
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnreset);
            Controls.Add(btnCalculate);
            Controls.Add(txtSemester);
            Controls.Add(txtStudentId);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(lblstudentID);
            Controls.Add(lblName);
            Name = "lblSemester";
            Text = "semester";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblstudentID;
        private Label label3;
        private TextBox txtName;
        private TextBox txtStudentId;
        private TextBox txtSemester;
        private Button btnCalculate;
        private Button btnreset;
    }
}
