using Google.Apis.Translate.v2.Data;

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

                // Agregar opción "Auto" al ComboBox y seleccionarla
                comboBoxLanguagesInput.Items.Add("Auto");
                comboBoxLanguagesInput.SelectedIndex = 0;

                foreach (var kvp in languageCodesAndNames)
                {
                    comboBoxLanguagesInput.Items.Add(kvp.Value);
                    comboBoxLanguagesOutput.Items.Add(kvp.Value);

                    languageNamesToCodes.Add(kvp.Value, kvp.Key);
                }
                comboBoxLanguagesOutput.SelectedIndex = 0;
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
                if (comboBoxLanguagesOutput.SelectedItem != null)
                {
                    string targetLanguageName = comboBoxLanguagesOutput.SelectedItem.ToString()!;
                    string targetLanguageCode = languageNamesToCodes[targetLanguageName];

                    string textToTranslate = textBoxInput.Text;

                    // Detectar automáticamente el idioma de entrada del texto
                    string sourceLanguageCode = "auto";
                    if (comboBoxLanguagesInput.SelectedItem != null && comboBoxLanguagesInput.SelectedItem.ToString() != "Auto")
                    {
                        string sourceLanguageName = comboBoxLanguagesInput.SelectedItem.ToString()!;
                        sourceLanguageCode = languageNamesToCodes[sourceLanguageName];
                    }

                    string translatedText = await googleTranslateService.TranslateText(textToTranslate, sourceLanguageCode, targetLanguageCode);
                    textBoxOutput.Text = translatedText;
                }
                else
                {
                    MessageBox.Show("Seleccione un idioma de salida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traducir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
