namespace Assignment3
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
            this.textfood1 = new System.Windows.Forms.TextBox();
            this.textprice1 = new System.Windows.Forms.TextBox();
            this.textfood2 = new System.Windows.Forms.TextBox();
            this.textprice2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textfood1
            // 
            this.textfood1.Location = new System.Drawing.Point(219, 89);
            this.textfood1.Name = "textfood1";
            this.textfood1.Size = new System.Drawing.Size(231, 20);
            this.textfood1.TabIndex = 0;
            // 
            // textprice1
            // 
            this.textprice1.Location = new System.Drawing.Point(219, 115);
            this.textprice1.Name = "textprice1";
            this.textprice1.Size = new System.Drawing.Size(231, 20);
            this.textprice1.TabIndex = 1;
            // 
            // textfood2
            // 
            this.textfood2.Location = new System.Drawing.Point(219, 141);
            this.textfood2.Name = "textfood2";
            this.textfood2.Size = new System.Drawing.Size(231, 20);
            this.textfood2.TabIndex = 2;
            // 
            // textprice2
            // 
            this.textprice2.Location = new System.Drawing.Point(219, 167);
            this.textprice2.Name = "textprice2";
            this.textprice2.Size = new System.Drawing.Size(231, 20);
            this.textprice2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter food1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter price1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter food2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter price2";
            // 
            // display
            // 
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Location = new System.Drawing.Point(205, 219);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(272, 23);
            this.display.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "display all info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "calculate the price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.display);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textprice2);
            this.Controls.Add(this.textfood2);
            this.Controls.Add(this.textprice1);
            this.Controls.Add(this.textfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textfood1;
        private System.Windows.Forms.TextBox textprice1;
        private System.Windows.Forms.TextBox textfood2;
        private System.Windows.Forms.TextBox textprice2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

