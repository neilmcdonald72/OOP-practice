
namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plusminus = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.decima = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.ClearEntry = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(14, 132);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(43, 44);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(63, 132);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(43, 44);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(112, 132);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(43, 44);
            this.nine.TabIndex = 3;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(161, 133);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(43, 44);
            this.multiply.TabIndex = 4;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(14, 182);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(43, 44);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(63, 182);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(43, 44);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button6_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(112, 182);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(43, 44);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(161, 83);
            this.divide.Name = "divide";
            this.divide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.divide.Size = new System.Drawing.Size(43, 44);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(14, 232);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(43, 44);
            this.one.TabIndex = 9;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(63, 232);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(43, 44);
            this.two.TabIndex = 10;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(112, 232);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(43, 44);
            this.three.TabIndex = 11;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(161, 183);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(43, 44);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plusminus
            // 
            this.plusminus.Location = new System.Drawing.Point(14, 282);
            this.plusminus.Name = "plusminus";
            this.plusminus.Size = new System.Drawing.Size(43, 44);
            this.plusminus.TabIndex = 13;
            this.plusminus.Text = "+/-";
            this.plusminus.UseVisualStyleBackColor = true;
            this.plusminus.Click += new System.EventHandler(this.plusminus_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(63, 282);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(43, 44);
            this.zero.TabIndex = 14;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // decima
            // 
            this.decima.Location = new System.Drawing.Point(112, 282);
            this.decima.Name = "decima";
            this.decima.Size = new System.Drawing.Size(43, 44);
            this.decima.TabIndex = 15;
            this.decima.Text = ".";
            this.decima.UseVisualStyleBackColor = true;
            this.decima.Click += new System.EventHandler(this.decima_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(161, 233);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(43, 44);
            this.plus.TabIndex = 16;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(161, 282);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(43, 44);
            this.equal.TabIndex = 17;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(63, 83);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(43, 44);
            this.clear.TabIndex = 18;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(112, 82);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(43, 44);
            this.backspace.TabIndex = 19;
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // ClearEntry
            // 
            this.ClearEntry.Location = new System.Drawing.Point(14, 83);
            this.ClearEntry.Name = "ClearEntry";
            this.ClearEntry.Size = new System.Drawing.Size(43, 44);
            this.ClearEntry.TabIndex = 20;
            this.ClearEntry.Text = "CE";
            this.ClearEntry.UseVisualStyleBackColor = true;
            this.ClearEntry.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Nine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClearEntry);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.decima);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.plusminus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plusminus;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button decima;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button ClearEntry;
        private System.Windows.Forms.Button button1;
    }
}

