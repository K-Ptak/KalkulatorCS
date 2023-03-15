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
            this.tb_Screen = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // tb_Screen
            // 
            this.tb_Screen.Location = new System.Drawing.Point(13, 13);
            this.tb_Screen.Name = "tb_Screen";
            this.tb_Screen.ReadOnly = true;
            this.tb_Screen.Size = new System.Drawing.Size(419, 26);
            this.tb_Screen.TabIndex = 0;
            this.tb_Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(29, 124);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 23);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(29, 153);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 23);
            this.btn_4.TabIndex = 2;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(29, 192);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 3;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(125, 124);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 23);
            this.btn_8.TabIndex = 4;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(125, 153);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 23);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(125, 192);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 23);
            this.btn_2.TabIndex = 6;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(225, 124);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 23);
            this.btn_9.TabIndex = 7;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(225, 153);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 23);
            this.btn_6.TabIndex = 8;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(225, 192);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 23);
            this.btn_3.TabIndex = 9;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            // 
            // btn_plusminus
            // 
            this.btn_plusminus.Location = new System.Drawing.Point(29, 246);
            this.btn_plusminus.Name = "btn_plusminus";
            this.btn_plusminus.Size = new System.Drawing.Size(75, 23);
            this.btn_plusminus.TabIndex = 10;
            this.btn_plusminus.Text = "+/-";
            this.btn_plusminus.UseVisualStyleBackColor = true;
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(125, 246);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 41);
            this.btn_0.TabIndex = 11;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            // 
            // btn_separator
            // 
            this.btn_separator.Location = new System.Drawing.Point(225, 246);
            this.btn_separator.Name = "btn_separator";
            this.btn_separator.Size = new System.Drawing.Size(75, 41);
            this.btn_separator.TabIndex = 12;
            this.btn_separator.Text = ",";
            this.btn_separator.UseVisualStyleBackColor = true;
            // 
            // button_multiplication
            // 
            this.button_multiplication.Location = new System.Drawing.Point(337, 124);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(75, 23);
            this.button_multiplication.TabIndex = 13;
            this.button_multiplication.Text = "x";
            this.button_multiplication.UseVisualStyleBackColor = true;
            // 
            // btn_subtraction
            // 
            this.btn_subtraction.Location = new System.Drawing.Point(337, 153);
            this.btn_subtraction.Name = "btn_subtraction";
            this.btn_subtraction.Size = new System.Drawing.Size(75, 23);
            this.btn_subtraction.TabIndex = 14;
            this.btn_subtraction.Text = "-";
            this.btn_subtraction.UseVisualStyleBackColor = true;
            // 
            // btn_addition
            // 
            this.btn_addition.Location = new System.Drawing.Point(337, 192);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(75, 23);
            this.btn_addition.TabIndex = 15;
            this.btn_addition.Text = "+";
            this.btn_addition.UseVisualStyleBackColor = true;
            // 
            // btn_equals
            // 
            this.btn_equals.Location = new System.Drawing.Point(337, 246);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(75, 23);
            this.btn_equals.TabIndex = 16;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(337, 85);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(75, 23);
            this.btn_division.TabIndex = 17;
            this.btn_division.Text = "÷";
            this.btn_division.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(125, 85);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "C";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_backspace
            // 
            this.btn_backspace.Location = new System.Drawing.Point(225, 85);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(75, 23);
            this.btn_backspace.TabIndex = 19;
            this.btn_backspace.Text = "⌫";
            this.btn_backspace.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 375);
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
            this.Controls.Add(this.tb_Screen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Screen;
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
    }
}

