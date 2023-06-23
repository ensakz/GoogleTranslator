namespace Translator
{
    partial class Form1
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enUkRadioButton = new System.Windows.Forms.RadioButton();
            this.ukEnRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.inputTextBox.Location = new System.Drawing.Point(18, 18);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(598, 152);
            this.inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.outputTextBox.Location = new System.Drawing.Point(18, 306);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(598, 152);
            this.outputTextBox.TabIndex = 1;
            // 
            // translateButton
            // 
            this.translateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.translateButton.Location = new System.Drawing.Point(18, 209);
            this.translateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(232, 60);
            this.translateButton.TabIndex = 2;
            this.translateButton.Text = "TRANSLATE";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enUkRadioButton);
            this.groupBox1.Controls.Add(this.ukEnRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(646, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(278, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose languages";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // enUkRadioButton
            // 
            this.enUkRadioButton.AutoSize = true;
            this.enUkRadioButton.Location = new System.Drawing.Point(50, 105);
            this.enUkRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enUkRadioButton.Name = "enUkRadioButton";
            this.enUkRadioButton.Size = new System.Drawing.Size(117, 30);
            this.enUkRadioButton.TabIndex = 1;
            this.enUkRadioButton.Text = "Eng-Ukr";
            this.enUkRadioButton.UseVisualStyleBackColor = true;
            // 
            // ukEnRadioButton
            // 
            this.ukEnRadioButton.AutoSize = true;
            this.ukEnRadioButton.Checked = true;
            this.ukEnRadioButton.Location = new System.Drawing.Point(50, 52);
            this.ukEnRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ukEnRadioButton.Name = "ukEnRadioButton";
            this.ukEnRadioButton.Size = new System.Drawing.Size(117, 30);
            this.ukEnRadioButton.TabIndex = 0;
            this.ukEnRadioButton.TabStop = true;
            this.ukEnRadioButton.Text = "Ukr-Eng";
            this.ukEnRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton enUkRadioButton;
        private System.Windows.Forms.RadioButton ukEnRadioButton;
    }
}

