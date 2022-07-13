
namespace EnhancedPainter
{
    partial class Form1
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
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.canvasPanel.SuspendLayout();
            this.colorGroupBox.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvasPanel
            // 
            this.canvasPanel.Controls.Add(this.sizeGroupBox);
            this.canvasPanel.Controls.Add(this.colorGroupBox);
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(973, 579);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseDown);
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseMove);
            this.canvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseUp);
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colorGroupBox.Controls.Add(this.blackRadioButton);
            this.colorGroupBox.Controls.Add(this.greenRadioButton);
            this.colorGroupBox.Controls.Add(this.blueRadioButton);
            this.colorGroupBox.Controls.Add(this.redRadioButton);
            this.colorGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorGroupBox.Location = new System.Drawing.Point(13, 13);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(115, 191);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.ForeColor = System.Drawing.Color.Red;
            this.redRadioButton.Location = new System.Drawing.Point(7, 23);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(56, 27);
            this.redRadioButton.TabIndex = 0;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.ForeColor = System.Drawing.Color.Blue;
            this.blueRadioButton.Location = new System.Drawing.Point(7, 67);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(59, 27);
            this.blueRadioButton.TabIndex = 1;
            this.blueRadioButton.TabStop = true;
            this.blueRadioButton.Text = "Blue";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            this.blueRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.ForeColor = System.Drawing.Color.Lime;
            this.greenRadioButton.Location = new System.Drawing.Point(7, 113);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(73, 27);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(7, 158);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(68, 27);
            this.blackRadioButton.TabIndex = 3;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sizeGroupBox.Controls.Add(this.radioButton3);
            this.sizeGroupBox.Controls.Add(this.radioButton2);
            this.sizeGroupBox.Controls.Add(this.smallRadioButton);
            this.sizeGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeGroupBox.Location = new System.Drawing.Point(13, 211);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(115, 146);
            this.sizeGroupBox.TabIndex = 1;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallRadioButton.Location = new System.Drawing.Point(7, 30);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(55, 20);
            this.smallRadioButton.TabIndex = 0;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            this.smallRadioButton.CheckedChanged += new System.EventHandler(this.smallRadioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.smallRadioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(7, 96);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 39);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Large";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.smallRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 579);
            this.Controls.Add(this.canvasPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.canvasPanel.ResumeLayout(false);
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.RadioButton blueRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton smallRadioButton;
    }
}

