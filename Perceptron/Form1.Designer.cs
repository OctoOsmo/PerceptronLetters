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
            this.PersBtn = new System.Windows.Forms.RadioButton();
            this.Hopf = new System.Windows.Forms.RadioButton();
            this.trackBarBrushSize = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrushSize)).BeginInit();
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
            this.openImages.Location = new System.Drawing.Point(263, 61);
            this.openImages.Name = "openImages";
            this.openImages.Size = new System.Drawing.Size(90, 23);
            this.openImages.TabIndex = 1;
            this.openImages.Text = "Open images";
            this.openImages.UseVisualStyleBackColor = true;
            this.openImages.Click += new System.EventHandler(this.openImages_Click);
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Location = new System.Drawing.Point(405, 49);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxOutput.TabIndex = 2;
            this.pictureBoxOutput.TabStop = false;
            // 
            // TrainNetw
            // 
            this.TrainNetw.Location = new System.Drawing.Point(263, 107);
            this.TrainNetw.Name = "TrainNetw";
            this.TrainNetw.Size = new System.Drawing.Size(90, 23);
            this.TrainNetw.TabIndex = 3;
            this.TrainNetw.Text = "train";
            this.TrainNetw.UseVisualStyleBackColor = true;
            this.TrainNetw.Click += new System.EventHandler(this.TrainNetw_Click);
            // 
            // Recognize
            // 
            this.Recognize.Location = new System.Drawing.Point(263, 160);
            this.Recognize.Name = "Recognize";
            this.Recognize.Size = new System.Drawing.Size(90, 23);
            this.Recognize.TabIndex = 4;
            this.Recognize.Text = "Recognize";
            this.Recognize.UseVisualStyleBackColor = true;
            this.Recognize.Click += new System.EventHandler(this.Recognize_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(263, 215);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(90, 23);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // PersBtn
            // 
            this.PersBtn.AutoSize = true;
            this.PersBtn.Location = new System.Drawing.Point(233, 25);
            this.PersBtn.Name = "PersBtn";
            this.PersBtn.Size = new System.Drawing.Size(77, 17);
            this.PersBtn.TabIndex = 6;
            this.PersBtn.TabStop = true;
            this.PersBtn.Text = "Perceptron";
            this.PersBtn.UseVisualStyleBackColor = true;
            // 
            // Hopf
            // 
            this.Hopf.AutoSize = true;
            this.Hopf.Location = new System.Drawing.Point(324, 26);
            this.Hopf.Name = "Hopf";
            this.Hopf.Size = new System.Drawing.Size(64, 17);
            this.Hopf.TabIndex = 7;
            this.Hopf.TabStop = true;
            this.Hopf.Text = "Hopfield";
            this.Hopf.UseVisualStyleBackColor = true;
            // 
            // trackBarBrushSize
            // 
            this.trackBarBrushSize.Location = new System.Drawing.Point(12, 255);
            this.trackBarBrushSize.Name = "trackBarBrushSize";
            this.trackBarBrushSize.Size = new System.Drawing.Size(593, 45);
            this.trackBarBrushSize.TabIndex = 8;
            this.trackBarBrushSize.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 303);
            this.Controls.Add(this.trackBarBrushSize);
            this.Controls.Add(this.Hopf);
            this.Controls.Add(this.PersBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrushSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.Button openImages;
        private System.Windows.Forms.PictureBox pictureBoxOutput;
        private System.Windows.Forms.Button TrainNetw;
        private System.Windows.Forms.Button Recognize;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.RadioButton PersBtn;
        private System.Windows.Forms.RadioButton Hopf;
        private System.Windows.Forms.TrackBar trackBarBrushSize;
    }
}

