namespace TranslateProject
{
    partial class MainForm
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
            comboBoxLanguagesInput_0 = new ComboBox();
            textBoxInput = new TextBox();
            translateButton = new Button();
            comboBoxLanguagesOutput_0 = new ComboBox();
            textBoxOutput_0 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            SimultaneousFormButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxLanguagesInput_0
            // 
            comboBoxLanguagesInput_0.Dock = DockStyle.Fill;
            comboBoxLanguagesInput_0.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLanguagesInput_0.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            comboBoxLanguagesInput_0.FormattingEnabled = true;
            comboBoxLanguagesInput_0.Location = new Point(103, 48);
            comboBoxLanguagesInput_0.Name = "comboBoxLanguagesInput_0";
            comboBoxLanguagesInput_0.Size = new Size(194, 28);
            comboBoxLanguagesInput_0.TabIndex = 1;
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
            // comboBoxLanguagesOutput_0
            // 
            comboBoxLanguagesOutput_0.Dock = DockStyle.Fill;
            comboBoxLanguagesOutput_0.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLanguagesOutput_0.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            comboBoxLanguagesOutput_0.FormattingEnabled = true;
            comboBoxLanguagesOutput_0.Location = new Point(503, 48);
            comboBoxLanguagesOutput_0.Name = "comboBoxLanguagesOutput_0";
            comboBoxLanguagesOutput_0.Size = new Size(194, 28);
            comboBoxLanguagesOutput_0.TabIndex = 4;
            // 
            // textBoxOutput_0
            // 
            textBoxOutput_0.Dock = DockStyle.Fill;
            textBoxOutput_0.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBoxOutput_0.Location = new Point(503, 93);
            textBoxOutput_0.Multiline = true;
            textBoxOutput_0.Name = "textBoxOutput_0";
            textBoxOutput_0.ReadOnly = true;
            textBoxOutput_0.Size = new Size(194, 219);
            textBoxOutput_0.TabIndex = 5;
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
            tableLayoutPanel1.Controls.Add(textBoxOutput_0, 3, 2);
            tableLayoutPanel1.Controls.Add(textBoxInput, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBoxLanguagesInput_0, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBoxLanguagesOutput_0, 3, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 2);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 4);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(SimultaneousFormButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(503, 363);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(194, 39);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // SimultaneousFormButton
            // 
            SimultaneousFormButton.AutoSize = true;
            SimultaneousFormButton.Dock = DockStyle.Fill;
            SimultaneousFormButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SimultaneousFormButton.Location = new Point(80, 3);
            SimultaneousFormButton.Name = "SimultaneousFormButton";
            SimultaneousFormButton.Size = new Size(111, 33);
            SimultaneousFormButton.TabIndex = 13;
            SimultaneousFormButton.Text = "More";
            SimultaneousFormButton.UseVisualStyleBackColor = true;
            SimultaneousFormButton.Click += OnClickSimultaneousForm;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Google Translate";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxLanguagesInput_0;
        private TextBox textBoxInput;
        private Button translateButton;
        private ComboBox comboBoxLanguagesOutput_0;
        private TextBox textBoxOutput_0;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Button SimultaneousFormButton;
    }
}
