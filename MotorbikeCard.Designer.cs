namespace anash_prakt1
{
    partial class MotorbikeCard
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
            this.pictureBoxMotorbike = new System.Windows.Forms.PictureBox();
            this.labelIDData = new System.Windows.Forms.Label();
            this.labelModelData = new System.Windows.Forms.Label();
            this.labelBrandData = new System.Windows.Forms.Label();
            this.labelPriceData = new System.Windows.Forms.Label();
            this.labelHorsepowerData = new System.Windows.Forms.Label();
            this.labelMileageData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorbike)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMotorbike
            // 
            this.pictureBoxMotorbike.Location = new System.Drawing.Point(50, 16);
            this.pictureBoxMotorbike.Name = "pictureBoxMotorbike";
            this.pictureBoxMotorbike.Size = new System.Drawing.Size(179, 126);
            this.pictureBoxMotorbike.TabIndex = 0;
            this.pictureBoxMotorbike.TabStop = false;
            // 
            // labelIDData
            // 
            this.labelIDData.AutoSize = true;
            this.labelIDData.Location = new System.Drawing.Point(125, 149);
            this.labelIDData.Name = "labelIDData";
            this.labelIDData.Size = new System.Drawing.Size(63, 13);
            this.labelIDData.TabIndex = 1;
            this.labelIDData.Text = "labelIDData";
            this.labelIDData.Click += new System.EventHandler(this.l_Click);
            // 
            // labelModelData
            // 
            this.labelModelData.AutoSize = true;
            this.labelModelData.Location = new System.Drawing.Point(125, 174);
            this.labelModelData.Name = "labelModelData";
            this.labelModelData.Size = new System.Drawing.Size(81, 13);
            this.labelModelData.TabIndex = 2;
            this.labelModelData.Text = "labelModelData";
            // 
            // labelBrandData
            // 
            this.labelBrandData.AutoSize = true;
            this.labelBrandData.Location = new System.Drawing.Point(125, 196);
            this.labelBrandData.Name = "labelBrandData";
            this.labelBrandData.Size = new System.Drawing.Size(80, 13);
            this.labelBrandData.TabIndex = 3;
            this.labelBrandData.Text = "labelBrandData";
            // 
            // labelPriceData
            // 
            this.labelPriceData.AutoSize = true;
            this.labelPriceData.Location = new System.Drawing.Point(125, 221);
            this.labelPriceData.Name = "labelPriceData";
            this.labelPriceData.Size = new System.Drawing.Size(76, 13);
            this.labelPriceData.TabIndex = 4;
            this.labelPriceData.Text = "labelPriceData";
            // 
            // labelHorsepowerData
            // 
            this.labelHorsepowerData.AutoSize = true;
            this.labelHorsepowerData.Location = new System.Drawing.Point(125, 243);
            this.labelHorsepowerData.Name = "labelHorsepowerData";
            this.labelHorsepowerData.Size = new System.Drawing.Size(109, 13);
            this.labelHorsepowerData.TabIndex = 5;
            this.labelHorsepowerData.Text = "labelHorsepowerData";
            // 
            // labelMileageData
            // 
            this.labelMileageData.AutoSize = true;
            this.labelMileageData.Location = new System.Drawing.Point(125, 266);
            this.labelMileageData.Name = "labelMileageData";
            this.labelMileageData.Size = new System.Drawing.Size(89, 13);
            this.labelMileageData.TabIndex = 6;
            this.labelMileageData.Text = "labelMileageData";
            // 
            // MotorbikeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMileageData);
            this.Controls.Add(this.labelHorsepowerData);
            this.Controls.Add(this.labelPriceData);
            this.Controls.Add(this.labelBrandData);
            this.Controls.Add(this.labelModelData);
            this.Controls.Add(this.labelIDData);
            this.Controls.Add(this.pictureBoxMotorbike);
            this.Name = "MotorbikeCard";
            this.Size = new System.Drawing.Size(300, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorbike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMotorbike;
        private System.Windows.Forms.Label labelIDData;
        private System.Windows.Forms.Label labelModelData;
        private System.Windows.Forms.Label labelBrandData;
        private System.Windows.Forms.Label labelPriceData;
        private System.Windows.Forms.Label labelHorsepowerData;
        private System.Windows.Forms.Label labelMileageData;
    }
}
