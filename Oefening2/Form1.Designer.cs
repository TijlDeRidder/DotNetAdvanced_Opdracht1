namespace Oefening2
{
    partial class IsItBigger
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
            this.maal1 = new System.Windows.Forms.Label();
            this.maal2 = new System.Windows.Forms.Label();
            this.groterdan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maal1
            // 
            this.maal1.AutoSize = true;
            this.maal1.Location = new System.Drawing.Point(338, 106);
            this.maal1.Name = "maal1";
            this.maal1.Size = new System.Drawing.Size(38, 15);
            this.maal1.TabIndex = 0;
            this.maal1.Text = "label1";
            this.maal1.Click += new System.EventHandler(this.maal1_Click);
            // 
            // maal2
            // 
            this.maal2.AutoSize = true;
            this.maal2.Location = new System.Drawing.Point(338, 133);
            this.maal2.Name = "maal2";
            this.maal2.Size = new System.Drawing.Size(38, 15);
            this.maal2.TabIndex = 1;
            this.maal2.Text = "label1";
            // 
            // groterdan
            // 
            this.groterdan.AutoSize = true;
            this.groterdan.Location = new System.Drawing.Point(338, 160);
            this.groterdan.Name = "groterdan";
            this.groterdan.Size = new System.Drawing.Size(38, 15);
            this.groterdan.TabIndex = 2;
            this.groterdan.Text = "label1";
            // 
            // IsItBigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groterdan);
            this.Controls.Add(this.maal2);
            this.Controls.Add(this.maal1);
            this.Name = "IsItBigger";
            this.Text = "IsItBigger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label maal1;
        private Label maal2;
        private Label groterdan;
    }
}