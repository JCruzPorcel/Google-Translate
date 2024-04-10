namespace TranslateProject
{
    partial class Form1
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
            comboBoxLanguagesInput = new ComboBox();
            textBoxInput = new TextBox();
            translateButton = new Button();
            comboBoxLanguagesOutput = new ComboBox();
            textBoxOutput = new TextBox();
            SuspendLayout();
            // 
            // comboBoxLanguagesInput
            // 
            comboBoxLanguagesInput.FormattingEnabled = true;
            comboBoxLanguagesInput.Location = new Point(83, 39);
            comboBoxLanguagesInput.Name = "comboBoxLanguagesInput";
            comboBoxLanguagesInput.Size = new Size(121, 23);
            comboBoxLanguagesInput.TabIndex = 1;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(21, 71);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(245, 284);
            textBoxInput.TabIndex = 2;
            // 
            // translateButton
            // 
            translateButton.Location = new Point(345, 332);
            translateButton.Name = "translateButton";
            translateButton.Size = new Size(75, 23);
            translateButton.TabIndex = 3;
            translateButton.Text = "Translate";
            translateButton.UseVisualStyleBackColor = true;
            translateButton.Click += OnClickTranslateButton;
            // 
            // comboBoxLanguagesOutput
            // 
            comboBoxLanguagesOutput.FormattingEnabled = true;
            comboBoxLanguagesOutput.Location = new Point(592, 39);
            comboBoxLanguagesOutput.Name = "comboBoxLanguagesOutput";
            comboBoxLanguagesOutput.Size = new Size(121, 23);
            comboBoxLanguagesOutput.TabIndex = 4;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(515, 71);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(245, 284);
            textBoxOutput.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxOutput);
            Controls.Add(comboBoxLanguagesOutput);
            Controls.Add(translateButton);
            Controls.Add(textBoxInput);
            Controls.Add(comboBoxLanguagesInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxLanguagesInput;
        private TextBox textBoxInput;
        private Button translateButton;
        private ComboBox comboBoxLanguagesOutput;
        private TextBox textBoxOutput;
    }
}
