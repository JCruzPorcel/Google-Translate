using TranslateProject.GoogleService;
using TranslateProject.Models;

namespace TranslateProject
{
    public class TranslationHelper
    {
        private readonly GoogleTranslateService googleTranslateService = new GoogleTranslateService();
        private readonly Dictionary<string, string> languageNamesToCodes = new Dictionary<string, string>();

        public async Task LoadLanguages(ComboBox comboBoxLanguagesInput, ComboBox[] comboBoxLanguagesOutputs)
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
                    foreach (var comboBoxLanguagesOutput in comboBoxLanguagesOutputs)
                    {
                        comboBoxLanguagesOutput.Items.Add(kvp.Value);
                    }

                    languageNamesToCodes.Add(kvp.Value, kvp.Key);
                }

                foreach (var comboBoxLanguagesOutput in comboBoxLanguagesOutputs)
                {
                    comboBoxLanguagesOutput.SelectedIndex = 0;
                }

                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los idiomas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task Translate(ComboBox comboBoxLanguagesInput, ComboBox[] comboBoxLanguagesOutputs, TextBox textBoxInput, TextBox[] textBoxOutputs)
        {
            if (comboBoxLanguagesOutputs.Any(comboBox => comboBox.SelectedItem != null))
            {
                string textToTranslate = textBoxInput.Text;

                // Detectar automáticamente el idioma de entrada del texto
                string sourceLanguageCode = "auto";
                if (comboBoxLanguagesInput.SelectedItem != null && comboBoxLanguagesInput.SelectedItem.ToString() != "Auto")
                {
                    string sourceLanguageName = comboBoxLanguagesInput.SelectedItem.ToString()!;
                    sourceLanguageCode = languageNamesToCodes[sourceLanguageName];
                }

                foreach (var comboBoxLanguagesOutput in comboBoxLanguagesOutputs)
                {
                    if (comboBoxLanguagesOutput.SelectedItem != null)
                    {
                        string targetLanguageName = comboBoxLanguagesOutput.SelectedItem.ToString()!;
                        string targetLanguageCode = languageNamesToCodes[targetLanguageName];

                        string translatedText = await googleTranslateService.TranslateText(textToTranslate, sourceLanguageCode, targetLanguageCode);

                        // Asignar la traducción al TextBox de salida correspondiente
                        int index = Array.IndexOf(comboBoxLanguagesOutputs, comboBoxLanguagesOutput);
                        if (index >= 0 && index < textBoxOutputs.Length)
                        {
                            textBoxOutputs[index].Text = translatedText;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un idioma de salida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione al menos un idioma de salida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
