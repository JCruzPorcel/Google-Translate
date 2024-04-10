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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxLanguagesInput
            // 
            comboBoxLanguagesInput.Dock = DockStyle.Fill;
            comboBoxLanguagesInput.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            comboBoxLanguagesInput.FormattingEnabled = true;
            comboBoxLanguagesInput.Location = new Point(103, 48);
            comboBoxLanguagesInput.Name = "comboBoxLanguagesInput";
            comboBoxLanguagesInput.Size = new Size(194, 28);
            comboBoxLanguagesInput.TabIndex = 1;
            // 
            // textBoxInput
            // 
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxInput.Location = new Point(103, 93);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(194, 219);
            textBoxInput.TabIndex = 2;
            // 
            // translateButton
            // 
            translateButton.Dock = DockStyle.Fill;
            translateButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            translateButton.Location = new Point(303, 363);
            translateButton.Name = "translateButton";
            translateButton.Size = new Size(194, 39);
            translateButton.TabIndex = 3;
            translateButton.Text = "Translate";
            translateButton.UseVisualStyleBackColor = true;
            translateButton.Click += OnClickTranslateButton;
            // 
            // comboBoxLanguagesOutput
            // 
            comboBoxLanguagesOutput.Dock = DockStyle.Fill;
            comboBoxLanguagesOutput.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            comboBoxLanguagesOutput.FormattingEnabled = true;
            comboBoxLanguagesOutput.Location = new Point(503, 48);
            comboBoxLanguagesOutput.Name = "comboBoxLanguagesOutput";
            comboBoxLanguagesOutput.Size = new Size(194, 28);
            comboBoxLanguagesOutput.TabIndex = 4;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Dock = DockStyle.Fill;
            textBoxOutput.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxOutput.Location = new Point(503, 93);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(194, 219);
            textBoxOutput.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(translateButton, 2, 4);
            tableLayoutPanel1.Controls.Add(textBoxOutput, 3, 2);
            tableLayoutPanel1.Controls.Add(textBoxInput, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBoxLanguagesInput, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBoxLanguagesOutput, 3, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(303, 90);
            label2.Name = "label2";
            label2.Size = new Size(194, 225);
            label2.TabIndex = 7;
            label2.Text = "=>";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(303, 45);
            label4.Name = "label4";
            label4.Size = new Size(194, 45);
            label4.TabIndex = 9;
            label4.Text = "To";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxLanguagesInput;
        private TextBox textBoxInput;
        private Button translateButton;
        private ComboBox comboBoxLanguagesOutput;
        private TextBox textBoxOutput;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label4;
    }
}
