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
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.calculation_result = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number7
            // 
            this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number7.Location = new System.Drawing.Point(29, 90);
            this.number7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(60, 55);
            this.number7.TabIndex = 0;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.button_click);
            // 
            // number8
            // 
            this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number8.Location = new System.Drawing.Point(97, 90);
            this.number8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(60, 55);
            this.number8.TabIndex = 1;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.button_click);
            // 
            // number9
            // 
            this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number9.Location = new System.Drawing.Point(165, 90);
            this.number9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(60, 55);
            this.number9.TabIndex = 2;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.button_click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(233, 90);
            this.divide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(60, 55);
            this.divide.TabIndex = 3;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(301, 90);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(71, 55);
            this.buttonCE.TabIndex = 4;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.ButtonCE);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(301, 153);
            this.buttonC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(71, 55);
            this.buttonC.TabIndex = 9;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.ButtonC);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(233, 153);
            this.multiply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(60, 55);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operator_click);
            // 
            // number6
            // 
            this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number6.Location = new System.Drawing.Point(165, 153);
            this.number6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(60, 55);
            this.number6.TabIndex = 7;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.button_click);
            // 
            // number5
            // 
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number5.Location = new System.Drawing.Point(97, 153);
            this.number5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(60, 55);
            this.number5.TabIndex = 6;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.button_click);
            // 
            // number4
            // 
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number4.Location = new System.Drawing.Point(29, 153);
            this.number4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(60, 55);
            this.number4.TabIndex = 5;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.button_click);
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(233, 215);
            this.subtract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(60, 55);
            this.subtract.TabIndex = 13;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.operator_click);
            // 
            // number3
            // 
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3.Location = new System.Drawing.Point(165, 215);
            this.number3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(60, 55);
            this.number3.TabIndex = 12;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.button_click);
            // 
            // number2
            // 
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2.Location = new System.Drawing.Point(97, 215);
            this.number2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(60, 55);
            this.number2.TabIndex = 11;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.button_click);
            // 
            // number1
            // 
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1.Location = new System.Drawing.Point(29, 215);
            this.number1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(60, 55);
            this.number1.TabIndex = 10;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.button_click);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(301, 215);
            this.equals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(71, 118);
            this.equals.TabIndex = 19;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.Calculation);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(233, 278);
            this.add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(60, 55);
            this.add.TabIndex = 18;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operator_click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(165, 278);
            this.button17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(60, 55);
            this.button17.TabIndex = 17;
            this.button17.Text = ".";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button_click);
            // 
            // number0
            // 
            this.number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number0.Location = new System.Drawing.Point(29, 278);
            this.number0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(128, 55);
            this.number0.TabIndex = 15;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.button_click);
            // 
            // calculation_result
            // 
            this.calculation_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculation_result.Location = new System.Drawing.Point(29, 49);
            this.calculation_result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculation_result.Name = "calculation_result";
            this.calculation_result.Size = new System.Drawing.Size(341, 34);
            this.calculation_result.TabIndex = 20;
            this.calculation_result.Text = "0";
            this.calculation_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.Window;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCurrentOperation.Location = new System.Drawing.Point(24, 16);
            this.labelCurrentOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 29);
            this.labelCurrentOperation.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 358);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.calculation_result);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.TextBox calculation_result;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}

