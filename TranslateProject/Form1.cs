namespace TranslateProject
{
    public partial class Form1 : Form
    {
        private readonly GoogleTranslateService googleTranslateService = new GoogleTranslateService();
        private Dictionary<string, string> languageNamesToCodes = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            LoadLanguages();
        }

        private void LoadLanguages()
        {
            try
            {
                Dictionary<string, string> languageCodesAndNames = LanguageCodesHelper.GetAllLanguageCodesAndNames();

                foreach (var kvp in languageCodesAndNames)
                {
                    comboBoxLanguagesInput.Items.Add(kvp.Value);
                    comboBoxLanguagesOutput.Items.Add(kvp.Value);

                    languageNamesToCodes.Add(kvp.Value, kvp.Key);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los idiomas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void OnClickTranslateButton(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxLanguagesInput.SelectedItem != null && comboBoxLanguagesOutput.SelectedItem != null)
                {
                    string sourceLanguageName = comboBoxLanguagesInput.SelectedItem.ToString()!;
                    string targetLanguageName = comboBoxLanguagesOutput.SelectedItem.ToString()!;

                    // Obtener los códigos de los idiomas seleccionados usando el diccionario auxiliar
                    string sourceLanguageCode = languageNamesToCodes[sourceLanguageName];
                    string targetLanguageCode = languageNamesToCodes[targetLanguageName];

                    string textToTranslate = textBoxInput.Text;
                    string translatedText = await googleTranslateService.TranslateText(textToTranslate, sourceLanguageCode, targetLanguageCode);
                    textBoxOutput.Text = translatedText;
                }
                else
                {
                    MessageBox.Show("Seleccione un idioma de entrada y un idioma de salida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traducir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
