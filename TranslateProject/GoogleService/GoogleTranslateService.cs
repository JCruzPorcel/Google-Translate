namespace TranslateProject.GoogleService
{
    public class GoogleTranslateService
    {
        private const string GoogleTranslateBaseUrl = "https://translate.googleapis.com/translate_a/single";

        public async Task<string> TranslateText(string text, string sourceLanguage, string targetLanguage)
        {
            // Construir la URL de la API con los parámetros proporcionados
            string apiUrl = $"{GoogleTranslateBaseUrl}?client=gtx&sl={sourceLanguage}&tl={targetLanguage}&dt=t&q={Uri.EscapeDataString(text)}";

            // Crear una instancia de HttpClient para realizar la solicitud HTTP
            using (HttpClient client = new HttpClient())
            {
                // Realizar la solicitud GET a la URL de la API
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    // Analizar la respuesta JSON para extraer el texto traducido
                    string translatedText = ParseTranslatedText(jsonResponse);
                    return translatedText;
                }
                else
                {
                    return $"Error: {response.StatusCode}";
                }
            }
        }

        private string ParseTranslatedText(string jsonResponse)
        {
            try
            {
                var jsonArray = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsonResponse);

                string translatedText = jsonArray![0][0][0];
                return translatedText;
            }
            catch (Exception ex)
            {
                return $"Error al analizar JSON: {ex.Message}";
            }
        }
    }
}
