namespace TranslateProject.Forms
{
    public partial class SimultaneousForm : Form
    {
        private readonly TranslationHelper translationHelper = new TranslationHelper();

        public SimultaneousForm()
        {
            InitializeComponent();
            LoadLanguages();
        }

        private async void LoadLanguages()
        {
            ComboBox[] comboBoxOutputs = { comboBox_Output_0, comboBox_Output_1, comboBox_Output_2, comboBox_Output_3, comboBox_Output_4 };
            await translationHelper.LoadLanguages(comboBox_Input, comboBoxOutputs);
        }

        private async void OnClickTranslateButton(object sender, EventArgs e)
        {
            try
            {
                ComboBox[] comboBoxOutputs = { comboBox_Output_0, comboBox_Output_1, comboBox_Output_2, comboBox_Output_3, comboBox_Output_4 };
                TextBox[] textBoxOutputs = { textBox_Output_0, textBox_Output_1, textBox_Output_2, textBox_Output_3, textBox_Output_4 };

                await translationHelper.Translate(comboBox_Input, comboBoxOutputs, textBox_Input, textBoxOutputs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traducir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
