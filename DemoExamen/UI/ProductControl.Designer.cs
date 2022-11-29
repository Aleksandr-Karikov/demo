namespace DemoExamen.UI
{
    partial class ProductControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.productName = new System.Windows.Forms.Label();
            this.productDescription = new System.Windows.Forms.Label();
            this.productManufacture = new System.Windows.Forms.Label();
            this.productCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(265, 20);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(36, 13);
            this.productName.TabIndex = 1;
            this.productName.Text = "dasda";
            // 
            // productDescription
            // 
            this.productDescription.AutoSize = true;
            this.productDescription.Location = new System.Drawing.Point(266, 42);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(35, 13);
            this.productDescription.TabIndex = 2;
            this.productDescription.Text = "label1";
            // 
            // productManufacture
            // 
            this.productManufacture.AutoSize = true;
            this.productManufacture.Location = new System.Drawing.Point(265, 70);
            this.productManufacture.Name = "productManufacture";
            this.productManufacture.Size = new System.Drawing.Size(35, 13);
            this.productManufacture.TabIndex = 3;
            this.productManufacture.Text = "label1";
            // 
            // productCost
            // 
            this.productCost.AutoSize = true;
            this.productCost.Location = new System.Drawing.Point(265, 105);
            this.productCost.Name = "productCost";
            this.productCost.Size = new System.Drawing.Size(35, 13);
            this.productCost.TabIndex = 4;
            this.productCost.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Производитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена";
            // 
            // productCount
            // 
            this.productCount.AutoSize = true;
            this.productCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCount.Location = new System.Drawing.Point(781, 70);
            this.productCount.Name = "productCount";
            this.productCount.Size = new System.Drawing.Size(36, 39);
            this.productCount.TabIndex = 9;
            this.productCount.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(770, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "На складе";
            // 
            // productPhoto
            // 
            this.productPhoto.Image = global::DemoExamen.Resource.picture;
            this.productPhoto.Location = new System.Drawing.Point(26, 20);
            this.productPhoto.Name = "productPhoto";
            this.productPhoto.Size = new System.Drawing.Size(104, 102);
            this.productPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPhoto.TabIndex = 0;
            this.productPhoto.TabStop = false;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productCost);
            this.Controls.Add(this.productManufacture);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productPhoto);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(887, 150);
            ((System.ComponentModel.ISupportInitialize)(this.productPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productPhoto;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productDescription;
        private System.Windows.Forms.Label productManufacture;
        private System.Windows.Forms.Label productCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label productCount;
        private System.Windows.Forms.Label label5;
    }
}
