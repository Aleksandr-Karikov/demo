namespace DemoExamen.Forms
{
    partial class Captcha
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
            this.label1 = new System.Windows.Forms.Label();
            this.captchaBox = new System.Windows.Forms.TextBox();
            this.captchaAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // captchaBox
            // 
            this.captchaBox.Location = new System.Drawing.Point(55, 98);
            this.captchaBox.Name = "captchaBox";
            this.captchaBox.Size = new System.Drawing.Size(100, 20);
            this.captchaBox.TabIndex = 1;
            // 
            // captchaAccept
            // 
            this.captchaAccept.Location = new System.Drawing.Point(12, 152);
            this.captchaAccept.Name = "captchaAccept";
            this.captchaAccept.Size = new System.Drawing.Size(190, 23);
            this.captchaAccept.TabIndex = 2;
            this.captchaAccept.Text = "Подтвердить что вы не робот";
            this.captchaAccept.UseVisualStyleBackColor = true;
            this.captchaAccept.Click += new System.EventHandler(this.captchaAccept_Click);
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 187);
            this.Controls.Add(this.captchaAccept);
            this.Controls.Add(this.captchaBox);
            this.Controls.Add(this.label1);
            this.Name = "Captcha";
            this.Text = "Captcha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox captchaBox;
        private System.Windows.Forms.Button captchaAccept;
    }
}