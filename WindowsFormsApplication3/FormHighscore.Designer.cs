namespace PirateWars
{
    partial class Highscore
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblTop1 = new System.Windows.Forms.Label();
            this.lblTop2 = new System.Windows.Forms.Label();
            this.lblTop3 = new System.Windows.Forms.Label();
            this.lblTop4 = new System.Windows.Forms.Label();
            this.lblTop5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(12, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(162, 33);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Highscore top 5";
            // 
            // lblTop1
            // 
            this.lblTop1.AutoSize = true;
            this.lblTop1.Location = new System.Drawing.Point(15, 64);
            this.lblTop1.Name = "lblTop1";
            this.lblTop1.Size = new System.Drawing.Size(13, 13);
            this.lblTop1.TabIndex = 1;
            this.lblTop1.Text = "1";
            // 
            // lblTop2
            // 
            this.lblTop2.AutoSize = true;
            this.lblTop2.Location = new System.Drawing.Point(15, 97);
            this.lblTop2.Name = "lblTop2";
            this.lblTop2.Size = new System.Drawing.Size(13, 13);
            this.lblTop2.TabIndex = 2;
            this.lblTop2.Text = "2";
            // 
            // lblTop3
            // 
            this.lblTop3.AutoSize = true;
            this.lblTop3.Location = new System.Drawing.Point(15, 132);
            this.lblTop3.Name = "lblTop3";
            this.lblTop3.Size = new System.Drawing.Size(13, 13);
            this.lblTop3.TabIndex = 3;
            this.lblTop3.Text = "3";
            // 
            // lblTop4
            // 
            this.lblTop4.AutoSize = true;
            this.lblTop4.Location = new System.Drawing.Point(15, 169);
            this.lblTop4.Name = "lblTop4";
            this.lblTop4.Size = new System.Drawing.Size(13, 13);
            this.lblTop4.TabIndex = 4;
            this.lblTop4.Text = "4";
            // 
            // lblTop5
            // 
            this.lblTop5.AutoSize = true;
            this.lblTop5.Location = new System.Drawing.Point(15, 211);
            this.lblTop5.Name = "lblTop5";
            this.lblTop5.Size = new System.Drawing.Size(13, 13);
            this.lblTop5.TabIndex = 5;
            this.lblTop5.Text = "5";
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 430);
            this.Controls.Add(this.lblTop5);
            this.Controls.Add(this.lblTop4);
            this.Controls.Add(this.lblTop3);
            this.Controls.Add(this.lblTop2);
            this.Controls.Add(this.lblTop1);
            this.Controls.Add(this.lblHeading);
            this.Name = "Highscore";
            this.Text = "Highscore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblTop1;
        private System.Windows.Forms.Label lblTop2;
        private System.Windows.Forms.Label lblTop3;
        private System.Windows.Forms.Label lblTop4;
        private System.Windows.Forms.Label lblTop5;
    }
}