namespace Oefening5
{
    partial class CelciusToFahrenheit
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
            this.Celsius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fahrenheit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CtoF = new System.Windows.Forms.Button();
            this.FtoC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Celsius
            // 
            this.Celsius.Location = new System.Drawing.Point(56, 112);
            this.Celsius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(110, 23);
            this.Celsius.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Celsius";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.Location = new System.Drawing.Point(249, 112);
            this.Fahrenheit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(110, 23);
            this.Fahrenheit.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fahrenheit";
            // 
            // CtoF
            // 
            this.CtoF.Location = new System.Drawing.Point(67, 150);
            this.CtoF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CtoF.Name = "CtoF";
            this.CtoF.Size = new System.Drawing.Size(82, 22);
            this.CtoF.TabIndex = 4;
            this.CtoF.Text = "C to F";
            this.CtoF.UseVisualStyleBackColor = true;
            this.CtoF.Click += new System.EventHandler(this.CtoF_Click);
            // 
            // FtoC
            // 
            this.FtoC.Location = new System.Drawing.Point(267, 150);
            this.FtoC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FtoC.Name = "FtoC";
            this.FtoC.Size = new System.Drawing.Size(82, 22);
            this.FtoC.TabIndex = 5;
            this.FtoC.Text = "F to C";
            this.FtoC.UseVisualStyleBackColor = true;
            this.FtoC.Click += new System.EventHandler(this.FtoC_Click);
            // 
            // CelciusToFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.FtoC);
            this.Controls.Add(this.CtoF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Celsius);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CelciusToFahrenheit";
            this.Text = "CelciusToFahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Celsius;
        private Label label1;
        private TextBox Fahrenheit;
        private Label label2;
        private Button CtoF;
        private Button FtoC;
    }
}