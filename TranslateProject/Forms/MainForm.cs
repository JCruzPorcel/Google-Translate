using TranslateProject.Forms;

namespace TranslateProject
{
    public partial class MainForm : Form
    {
        private readonly TranslationHelper translationHelper = new TranslationHelper();

        public MainForm()
        {
            InitializeComponent();
            LoadLanguages();
        }

        private async void LoadLanguages()
        {
            await translationHelper.LoadLanguages(comboBoxLanguagesInput_0, [comboBoxLanguagesOutput_0]);
        }

        private async void OnClickTranslateButton(object sender, EventArgs e)
        {
            try
            {
                await translationHelper.Translate(comboBoxLanguagesInput_0, [comboBoxLanguagesOutput_0], textBoxInput, [textBoxOutput_0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traducir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnClickSimultaneousForm(object sender, EventArgs e)
        {
            SimultaneousForm simultaneousForm = new SimultaneousForm();
            simultaneousForm.Show();
        }
    }
}
