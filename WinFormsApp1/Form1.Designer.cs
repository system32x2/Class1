namespace WinFormsApp1
{
    partial class Form1
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
            Num1 = new TextBox();
            Num2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboSelect = new ComboBox();
            Calculate = new Button();
            NumR = new TextBox();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.BorderStyle = BorderStyle.FixedSingle;
            Num1.Location = new Point(64, 53);
            Num1.Name = "Num1";
            Num1.Size = new Size(100, 23);
            Num1.TabIndex = 0;
            // 
            // Num2
            // 
            Num2.BorderStyle = BorderStyle.FixedSingle;
            Num2.Location = new Point(64, 99);
            Num2.Name = "Num2";
            Num2.Size = new Size(100, 23);
            Num2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 35);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Número 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 81);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Número 2";
            // 
            // comboSelect
            // 
            comboSelect.FormattingEnabled = true;
            comboSelect.Items.AddRange(new object[] { "Adicionar", "Subtrair", "Dividir", "Multiplicar" });
            comboSelect.Location = new Point(103, 132);
            comboSelect.Name = "comboSelect";
            comboSelect.Size = new Size(121, 23);
            comboSelect.TabIndex = 4;
            // 
            // Calculate
            // 
            Calculate.Location = new Point(22, 132);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(75, 23);
            Calculate.TabIndex = 5;
            Calculate.Text = "Calcular";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += button1_Click;
            // 
            // NumR
            // 
            NumR.BorderStyle = BorderStyle.FixedSingle;
            NumR.Location = new Point(75, 174);
            NumR.Name = "NumR";
            NumR.Size = new Size(100, 23);
            NumR.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 220);
            Controls.Add(NumR);
            Controls.Add(Calculate);
            Controls.Add(comboSelect);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Num1;
        private TextBox Num2;
        private Label label1;
        private Label label2;
        private ComboBox comboSelect;
        private Button Calculate;
        private TextBox NumR;
    }
}
