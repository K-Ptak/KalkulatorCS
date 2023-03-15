namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Top = new System.Windows.Forms.TextBox();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_plusminus = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_separator = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.btn_subtraction = new System.Windows.Forms.Button();
            this.btn_addition = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_backspace = new System.Windows.Forms.Button();
            this.tb_Bottom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Top
            // 
            this.tb_Top.Location = new System.Drawing.Point(13, 12);
            this.tb_Top.Name = "tb_Top";
            this.tb_Top.ReadOnly = true;
            this.tb_Top.Size = new System.Drawing.Size(419, 26);
            this.tb_Top.TabIndex = 0;
            this.tb_Top.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Top.TextChanged += new System.EventHandler(this.tb_Screen_TextChanged);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(29, 160);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 41);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(29, 207);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 41);
            this.btn_4.TabIndex = 2;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(29, 254);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 41);
            this.btn_1.TabIndex = 3;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(125, 160);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 41);
            this.btn_8.TabIndex = 4;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(125, 207);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 41);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(125, 254);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 41);
            this.btn_2.TabIndex = 6;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(225, 160);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 41);
            this.btn_9.TabIndex = 7;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(225, 207);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 41);
            this.btn_6.TabIndex = 8;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(225, 254);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 41);
            this.btn_3.TabIndex = 9;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_plusminus
            // 
            this.btn_plusminus.Location = new System.Drawing.Point(29, 301);
            this.btn_plusminus.Name = "btn_plusminus";
            this.btn_plusminus.Size = new System.Drawing.Size(75, 41);
            this.btn_plusminus.TabIndex = 10;
            this.btn_plusminus.Text = "+/-";
            this.btn_plusminus.UseVisualStyleBackColor = true;
            this.btn_plusminus.Click += new System.EventHandler(this.btn_changeSign_click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(125, 301);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 41);
            this.btn_0.TabIndex = 11;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_separator
            // 
            this.btn_separator.Location = new System.Drawing.Point(225, 301);
            this.btn_separator.Name = "btn_separator";
            this.btn_separator.Size = new System.Drawing.Size(75, 41);
            this.btn_separator.TabIndex = 12;
            this.btn_separator.Text = ",";
            this.btn_separator.UseVisualStyleBackColor = true;
            this.btn_separator.Click += new System.EventHandler(this.btn_number_click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Location = new System.Drawing.Point(326, 113);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(75, 41);
            this.button_multiplication.TabIndex = 13;
            this.button_multiplication.Text = "x";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_subtraction
            // 
            this.btn_subtraction.Location = new System.Drawing.Point(326, 207);
            this.btn_subtraction.Name = "btn_subtraction";
            this.btn_subtraction.Size = new System.Drawing.Size(75, 41);
            this.btn_subtraction.TabIndex = 14;
            this.btn_subtraction.Text = "-";
            this.btn_subtraction.UseVisualStyleBackColor = true;
            this.btn_subtraction.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_addition
            // 
            this.btn_addition.Location = new System.Drawing.Point(326, 254);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(75, 41);
            this.btn_addition.TabIndex = 15;
            this.btn_addition.Text = "+";
            this.btn_addition.UseVisualStyleBackColor = true;
            this.btn_addition.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_equals
            // 
            this.btn_equals.Location = new System.Drawing.Point(326, 301);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(75, 41);
            this.btn_equals.TabIndex = 16;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(326, 160);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(75, 41);
            this.btn_division.TabIndex = 17;
            this.btn_division.Text = "÷";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(29, 113);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 41);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "C";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_number_click);
            // 
            // btn_backspace
            // 
            this.btn_backspace.Location = new System.Drawing.Point(125, 113);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(175, 41);
            this.btn_backspace.TabIndex = 19;
            this.btn_backspace.Text = "⌫";
            this.btn_backspace.UseVisualStyleBackColor = true;
            this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click_1);
            // 
            // tb_Bottom
            // 
            this.tb_Bottom.Location = new System.Drawing.Point(13, 58);
            this.tb_Bottom.Name = "tb_Bottom";
            this.tb_Bottom.ReadOnly = true;
            this.tb_Bottom.Size = new System.Drawing.Size(419, 26);
            this.tb_Bottom.TabIndex = 20;
            this.tb_Bottom.Text = "0 ";
            this.tb_Bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 375);
            this.Controls.Add(this.tb_Bottom);
            this.Controls.Add(this.btn_backspace);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_addition);
            this.Controls.Add(this.btn_subtraction);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.btn_separator);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_plusminus);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.tb_Top);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Top;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_plusminus;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_separator;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button btn_subtraction;
        private System.Windows.Forms.Button btn_addition;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_backspace;
        private System.Windows.Forms.TextBox tb_Bottom;
    }
}

