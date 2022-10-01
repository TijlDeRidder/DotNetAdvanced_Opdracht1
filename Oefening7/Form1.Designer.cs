namespace Oefening7
{
    partial class Sum
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
            this.nummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.solution = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nummer
            // 
            this.nummer.Location = new System.Drawing.Point(323, 128);
            this.nummer.Name = "nummer";
            this.nummer.Size = new System.Drawing.Size(100, 23);
            this.nummer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number:";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(334, 166);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // solution
            // 
            this.solution.Location = new System.Drawing.Point(263, 207);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(205, 23);
            this.solution.TabIndex = 3;
            // 
            // Sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nummer);
            this.Name = "Sum";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nummer;
        private Label label1;
        private Button calculate;
        private TextBox solution;
    }
}