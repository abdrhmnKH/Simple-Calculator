namespace WindowsFormsApp2
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
            this.lblSCalc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSCalc
            // 
            this.lblSCalc.AutoSize = true;
            this.lblSCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblSCalc.Location = new System.Drawing.Point(249, 9);
            this.lblSCalc.Name = "lblSCalc";
            this.lblSCalc.Size = new System.Drawing.Size(268, 37);
            this.lblSCalc.TabIndex = 0;
            this.lblSCalc.Text = "Simple Calculator";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(239, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 26);
            this.textBox1.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnadd.Location = new System.Drawing.Point(239, 86);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(54, 50);
            this.btnadd.TabIndex = 2;
            this.btnadd.Tag = "+";
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnsub.Location = new System.Drawing.Point(308, 86);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(54, 50);
            this.btnsub.TabIndex = 3;
            this.btnsub.Tag = "-";
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDel.Location = new System.Drawing.Point(377, 86);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(54, 50);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnMod.Location = new System.Drawing.Point(446, 90);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(69, 45);
            this.btnMod.TabIndex = 5;
            this.btnMod.Tag = "%";
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btndivide
            // 
            this.btndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btndivide.Location = new System.Drawing.Point(446, 152);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(69, 45);
            this.btndivide.TabIndex = 6;
            this.btndivide.Tag = "/";
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            // 
            // btnmul
            // 
            this.btnmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnmul.Location = new System.Drawing.Point(448, 214);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(69, 45);
            this.btnmul.TabIndex = 7;
            this.btnmul.Tag = "*";
            this.btnmul.Text = "x";
            this.btnmul.UseVisualStyleBackColor = true;
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.Navy;
            this.btnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnequal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnequal.Location = new System.Drawing.Point(448, 276);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(69, 112);
            this.btnequal.TabIndex = 8;
            this.btnequal.Tag = "=";
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = false;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn1.Location = new System.Drawing.Point(240, 154);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 45);
            this.btn1.TabIndex = 9;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn2.Location = new System.Drawing.Point(308, 154);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 45);
            this.btn2.TabIndex = 10;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn3.Location = new System.Drawing.Point(377, 154);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 45);
            this.btn3.TabIndex = 11;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn4.Location = new System.Drawing.Point(239, 217);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 45);
            this.btn4.TabIndex = 12;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn5.Location = new System.Drawing.Point(308, 217);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 45);
            this.btn5.TabIndex = 13;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn6.Location = new System.Drawing.Point(378, 217);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 45);
            this.btn6.TabIndex = 14;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn7.Location = new System.Drawing.Point(240, 280);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 45);
            this.btn7.TabIndex = 15;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn8.Location = new System.Drawing.Point(309, 280);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 45);
            this.btn8.TabIndex = 16;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn9.Location = new System.Drawing.Point(377, 280);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 45);
            this.btn9.TabIndex = 17;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btndot
            // 
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btndot.Location = new System.Drawing.Point(378, 343);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(53, 45);
            this.btndot.TabIndex = 18;
            this.btndot.Tag = ".";
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btn0.Location = new System.Drawing.Point(308, 343);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(53, 45);
            this.btn0.TabIndex = 19;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(239, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 45);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSCalc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClear;
    }
}

