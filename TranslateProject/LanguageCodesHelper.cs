using Google.Cloud.Translation.V2;
using System.Reflection;

namespace TranslateProject
{
    public static class LanguageCodesHelper
    {
        public static Dictionary<string, string> GetAllLanguageCodesAndNames()
        {
            Dictionary<string, string> languageCodesAndNames = new Dictionary<string, string>();

            // Obtener el tipo de la clase LanguageCodes
            Type languageCodesType = typeof(LanguageCodes);

            // Obtener todas las constantes de cadena definidas en la clase LanguageCodes
            FieldInfo[] fields = languageCodesType.GetFields(BindingFlags.Public | BindingFlags.Static);
            foreach (FieldInfo field in fields)
            {
                // Verificar si el campo es una cadena (language code)
                if (field.FieldType == typeof(string))
                {
                    // Obtener el valor (language code)
                    string languageCode = (string)field.GetValue(null)!; // El segundo argumento es null porque son campos estáticos

                    // Obtener el nombre del campo (language name)
                    string languageName = field.Name.Replace("_", " "); // Reemplazar guiones bajos con espacios

                    // Agregar el par (language code, language name) al diccionario
                    languageCodesAndNames.Add(languageCode!, languageName);
                }
            }

            return languageCodesAndNames;
        }
    }
}
