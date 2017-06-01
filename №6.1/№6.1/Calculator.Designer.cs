namespace _6._1
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clean = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equally = new System.Windows.Forms.Button();
            this.CalculatorTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.22695F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.77305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Controls.Add(this.clean, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.delete, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sign, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addition, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.subtraction, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.three, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.two, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.one, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.four, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.five, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.six, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.multiplication, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.division, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.nine, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.eight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.seven, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.point, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.zero, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.equally, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 246);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clean.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clean.Location = new System.Drawing.Point(3, 3);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(72, 46);
            this.clean.TabIndex = 0;
            this.clean.Text = "C";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(81, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(77, 46);
            this.delete.TabIndex = 1;
            this.delete.Text = "Del";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sign.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign.Location = new System.Drawing.Point(164, 3);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(82, 46);
            this.sign.TabIndex = 2;
            this.sign.Text = "±";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addition.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addition.Location = new System.Drawing.Point(252, 3);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(77, 46);
            this.addition.TabIndex = 3;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.operator_Click);
            // 
            // subtraction
            // 
            this.subtraction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subtraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtraction.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtraction.Location = new System.Drawing.Point(252, 55);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(77, 42);
            this.subtraction.TabIndex = 4;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.operator_Click);
            // 
            // three
            // 
            this.three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.three.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.Location = new System.Drawing.Point(164, 55);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(82, 42);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.two.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(81, 55);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(77, 42);
            this.two.TabIndex = 6;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // one
            // 
            this.one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.one.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(3, 55);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(72, 42);
            this.one.TabIndex = 7;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.four.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(3, 103);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(72, 41);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.five.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.Location = new System.Drawing.Point(81, 103);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(77, 41);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // six
            // 
            this.six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.six.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.Location = new System.Drawing.Point(164, 103);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(82, 41);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplication.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplication.Location = new System.Drawing.Point(252, 103);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(77, 41);
            this.multiplication.TabIndex = 11;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.operator_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.division.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(252, 150);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(77, 41);
            this.division.TabIndex = 12;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.operator_Click);
            // 
            // nine
            // 
            this.nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nine.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine.Location = new System.Drawing.Point(164, 150);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(82, 41);
            this.nine.TabIndex = 13;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eight.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight.Location = new System.Drawing.Point(81, 150);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(77, 41);
            this.eight.TabIndex = 14;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // seven
            // 
            this.seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seven.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.Location = new System.Drawing.Point(3, 150);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(72, 41);
            this.seven.TabIndex = 15;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.point.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point.Location = new System.Drawing.Point(3, 197);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(72, 46);
            this.point.TabIndex = 16;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // zero
            // 
            this.zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zero.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.Location = new System.Drawing.Point(81, 197);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(77, 46);
            this.zero.TabIndex = 17;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // equally
            // 
            this.equally.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.SetColumnSpan(this.equally, 2);
            this.equally.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equally.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equally.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.equally.Location = new System.Drawing.Point(164, 197);
            this.equally.Name = "equally";
            this.equally.Size = new System.Drawing.Size(165, 46);
            this.equally.TabIndex = 18;
            this.equally.Text = "=";
            this.equally.UseVisualStyleBackColor = false;
            this.equally.Click += new System.EventHandler(this.result_Click);
            // 
            // CalculatorTextBox
            // 
            this.CalculatorTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalculatorTextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculatorTextBox.Location = new System.Drawing.Point(0, 0);
            this.CalculatorTextBox.Multiline = true;
            this.CalculatorTextBox.Name = "CalculatorTextBox";
            this.CalculatorTextBox.Size = new System.Drawing.Size(331, 78);
            this.CalculatorTextBox.TabIndex = 1;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 332);
            this.Controls.Add(this.CalculatorTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button equally;
        private System.Windows.Forms.TextBox CalculatorTextBox;
    }
}

