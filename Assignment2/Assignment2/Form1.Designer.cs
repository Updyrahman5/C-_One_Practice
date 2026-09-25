namespace Assignment2
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
            this.components = new System.ComponentModel.Container();
            this.textname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textID = new System.Windows.Forms.TextBox();
            this.textsemester = new System.Windows.Forms.TextBox();
            this.textdept = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lbldept = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(243, 66);
            this.textname.Multiline = true;
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(325, 28);
            this.textname.TabIndex = 0;
            this.textname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(243, 100);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(325, 28);
            this.textID.TabIndex = 2;
            // 
            // textsemester
            // 
            this.textsemester.Location = new System.Drawing.Point(243, 168);
            this.textsemester.Multiline = true;
            this.textsemester.Name = "textsemester";
            this.textsemester.Size = new System.Drawing.Size(325, 28);
            this.textsemester.TabIndex = 3;
            // 
            // textdept
            // 
            this.textdept.Location = new System.Drawing.Point(243, 134);
            this.textdept.Multiline = true;
            this.textdept.Name = "textdept";
            this.textdept.Size = new System.Drawing.Size(325, 28);
            this.textdept.TabIndex = 4;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(111, 76);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(121, 13);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Enter the student name";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(111, 107);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(106, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Enter the student ID";
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(111, 142);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(111, 13);
            this.lbldept.TabIndex = 7;
            this.lbldept.Text = "Enter the department";
            this.lbldept.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Location = new System.Drawing.Point(111, 176);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(99, 13);
            this.lblsemester.TabIndex = 8;
            this.lblsemester.Text = "Enter the semester";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(114, 224);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(454, 37);
            this.lbloutput.TabIndex = 9;
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnshowinfo.Location = new System.Drawing.Point(114, 278);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(138, 23);
            this.btnshowinfo.TabIndex = 10;
            this.btnshowinfo.Text = "Show information";
            this.btnshowinfo.UseVisualStyleBackColor = false;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(292, 278);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(115, 23);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(443, 278);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(125, 23);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.textdept);
            this.Controls.Add(this.textsemester);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textsemester;
        private System.Windows.Forms.TextBox textdept;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

