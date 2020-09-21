namespace CalculatorDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeft1 = new System.Windows.Forms.TextBox();
            this.txtRight1 = new System.Windows.Forms.TextBox();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.lblEquation = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculate2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLookup1 = new System.Windows.Forms.TextBox();
            this.btnLookup1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLookupResult1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLookup2 = new System.Windows.Forms.Button();
            this.txtLookup2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLookupResult2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Method 1";
            // 
            // txtLeft1
            // 
            this.txtLeft1.Location = new System.Drawing.Point(20, 50);
            this.txtLeft1.Name = "txtLeft1";
            this.txtLeft1.Size = new System.Drawing.Size(100, 20);
            this.txtLeft1.TabIndex = 1;
            // 
            // txtRight1
            // 
            this.txtRight1.Location = new System.Drawing.Point(215, 50);
            this.txtRight1.Name = "txtRight1";
            this.txtRight1.Size = new System.Drawing.Size(100, 20);
            this.txtRight1.TabIndex = 3;
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(145, 50);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(45, 20);
            this.txtOperand1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLookupResult1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnLookup1);
            this.panel1.Controls.Add(this.txtLookup1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblResult1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCalculate1);
            this.panel1.Controls.Add(this.txtLeft1);
            this.panel1.Controls.Add(this.txtRight1);
            this.panel1.Controls.Add(this.txtOperand1);
            this.panel1.Location = new System.Drawing.Point(126, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 207);
            this.panel1.TabIndex = 4;
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(58, 93);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(0, 13);
            this.lblResult1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Result:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Right";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Left";
            // 
            // btnCalculate1
            // 
            this.btnCalculate1.Location = new System.Drawing.Point(338, 50);
            this.btnCalculate1.Name = "btnCalculate1";
            this.btnCalculate1.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate1.TabIndex = 4;
            this.btnCalculate1.Text = "Calculate";
            this.btnCalculate1.UseVisualStyleBackColor = true;
            this.btnCalculate1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLookupResult2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnLookup2);
            this.panel2.Controls.Add(this.txtLookup2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblResult2);
            this.panel2.Controls.Add(this.txtEquation);
            this.panel2.Controls.Add(this.lblEquation);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnCalculate2);
            this.panel2.Location = new System.Drawing.Point(126, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 223);
            this.panel2.TabIndex = 5;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(63, 99);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(0, 13);
            this.lblResult2.TabIndex = 12;
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(20, 52);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(295, 20);
            this.txtEquation.TabIndex = 11;
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Location = new System.Drawing.Point(17, 36);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(49, 13);
            this.lblEquation.TabIndex = 10;
            this.lblEquation.Text = "Equation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Result:";
            // 
            // btnCalculate2
            // 
            this.btnCalculate2.Location = new System.Drawing.Point(338, 50);
            this.btnCalculate2.Name = "btnCalculate2";
            this.btnCalculate2.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate2.TabIndex = 4;
            this.btnCalculate2.Text = "Calculate";
            this.btnCalculate2.UseVisualStyleBackColor = true;
            this.btnCalculate2.Click += new System.EventHandler(this.btnCalculate2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Method 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Previous Result:";
            // 
            // txtLookup1
            // 
            this.txtLookup1.Location = new System.Drawing.Point(107, 135);
            this.txtLookup1.Name = "txtLookup1";
            this.txtLookup1.Size = new System.Drawing.Size(100, 20);
            this.txtLookup1.TabIndex = 11;
            // 
            // btnLookup1
            // 
            this.btnLookup1.Location = new System.Drawing.Point(240, 133);
            this.btnLookup1.Name = "btnLookup1";
            this.btnLookup1.Size = new System.Drawing.Size(75, 23);
            this.btnLookup1.TabIndex = 12;
            this.btnLookup1.Text = "Lookup";
            this.btnLookup1.UseVisualStyleBackColor = true;
            this.btnLookup1.Click += new System.EventHandler(this.btnLookup1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Lookup Result:";
            // 
            // lblLookupResult1
            // 
            this.lblLookupResult1.AutoSize = true;
            this.lblLookupResult1.Location = new System.Drawing.Point(104, 183);
            this.lblLookupResult1.Name = "lblLookupResult1";
            this.lblLookupResult1.Size = new System.Drawing.Size(0, 13);
            this.lblLookupResult1.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Lookup Result:";
            // 
            // btnLookup2
            // 
            this.btnLookup2.Location = new System.Drawing.Point(240, 137);
            this.btnLookup2.Name = "btnLookup2";
            this.btnLookup2.Size = new System.Drawing.Size(75, 23);
            this.btnLookup2.TabIndex = 16;
            this.btnLookup2.Text = "Lookup";
            this.btnLookup2.UseVisualStyleBackColor = true;
            this.btnLookup2.Click += new System.EventHandler(this.btnLookup2_Click);
            // 
            // txtLookup2
            // 
            this.txtLookup2.Location = new System.Drawing.Point(107, 139);
            this.txtLookup2.Name = "txtLookup2";
            this.txtLookup2.Size = new System.Drawing.Size(100, 20);
            this.txtLookup2.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Previous Result:";
            // 
            // lblLookupResult2
            // 
            this.lblLookupResult2.AutoSize = true;
            this.lblLookupResult2.Location = new System.Drawing.Point(104, 187);
            this.lblLookupResult2.Name = "lblLookupResult2";
            this.lblLookupResult2.Size = new System.Drawing.Size(0, 13);
            this.lblLookupResult2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 555);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeft1;
        private System.Windows.Forms.TextBox txtRight1;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate1;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate2;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLookup1;
        private System.Windows.Forms.TextBox txtLookup1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLookupResult1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLookup2;
        private System.Windows.Forms.TextBox txtLookup2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLookupResult2;
    }
}

