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
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.TrainNetw = new System.Windows.Forms.Button();
            this.Recognize = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Location = new System.Drawing.Point(12, 49);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxInput.TabIndex = 0;
            this.pictureBoxInput.TabStop = false;
            this.pictureBoxInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxInput_MouseDown);
            this.pictureBoxInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxInput_MouseMove);
            this.pictureBoxInput.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxInput_MouseUp);
            // 
            // openImages
            // 
            this.openImages.Location = new System.Drawing.Point(263, 49);
            this.openImages.Name = "openImages";
            this.openImages.Size = new System.Drawing.Size(90, 23);
            this.openImages.TabIndex = 1;
            this.openImages.Text = "Open images";
            this.openImages.UseVisualStyleBackColor = true;
            this.openImages.Click += new System.EventHandler(this.openImages_Click);
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Location = new System.Drawing.Point(430, 49);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxOutput.TabIndex = 2;
            this.pictureBoxOutput.TabStop = false;
            // 
            // TrainNetw
            // 
            this.TrainNetw.Location = new System.Drawing.Point(263, 95);
            this.TrainNetw.Name = "TrainNetw";
            this.TrainNetw.Size = new System.Drawing.Size(90, 23);
            this.TrainNetw.TabIndex = 3;
            this.TrainNetw.Text = "train";
            this.TrainNetw.UseVisualStyleBackColor = true;
            this.TrainNetw.Click += new System.EventHandler(this.TrainNetw_Click);
            // 
            // Recognize
            // 
            this.Recognize.Location = new System.Drawing.Point(263, 148);
            this.Recognize.Name = "Recognize";
            this.Recognize.Size = new System.Drawing.Size(90, 23);
            this.Recognize.TabIndex = 4;
            this.Recognize.Text = "Recognize";
            this.Recognize.UseVisualStyleBackColor = true;
            this.Recognize.Click += new System.EventHandler(this.Recognize_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(263, 203);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(90, 23);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 263);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Recognize);
            this.Controls.Add(this.TrainNetw);
            this.Controls.Add(this.pictureBoxOutput);
            this.Controls.Add(this.openImages);
            this.Controls.Add(this.pictureBoxInput);
            this.Name = "MainForm";
            this.Text = "Perceptron";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.Button openImages;
        private System.Windows.Forms.PictureBox pictureBoxOutput;
        private System.Windows.Forms.Button TrainNetw;
        private System.Windows.Forms.Button Recognize;
        private System.Windows.Forms.Button Clear;
    }
}

