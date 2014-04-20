namespace Perceptron
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.openImages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(290, 188);
            this.pictureBoxInput.TabIndex = 0;
            this.pictureBoxInput.TabStop = false;
            // 
            // openImages
            // 
            this.openImages.Location = new System.Drawing.Point(329, 21);
            this.openImages.Name = "openImages";
            this.openImages.Size = new System.Drawing.Size(90, 23);
            this.openImages.TabIndex = 1;
            this.openImages.Text = "Open images";
            this.openImages.UseVisualStyleBackColor = true;
            this.openImages.Click += new System.EventHandler(this.openImages_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 261);
            this.Controls.Add(this.openImages);
            this.Controls.Add(this.pictureBoxInput);
            this.Name = "MainForm";
            this.Text = "Perceptron";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.Button openImages;
    }
}

