using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Translator
{
    class GoogleTranslator
    {
        public string Translate(string s, string sourceLanguage, string targetLanguage)
        {
            if (s.Length > 0)
            {
                string apiKey = "input your api key here";
                string baseUrl = "https://translation.googleapis.com/language/translate/v2";

                string url = $"{baseUrl}?key={apiKey}&q={s}&source={sourceLanguage}&target={targetLanguage}";

                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();

                using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                {
                    string jsonResponse = streamReader.ReadToEnd();

                    TranslationResponse translationResponse = JsonConvert.DeserializeObject<TranslationResponse>(jsonResponse);

                    if (translationResponse != null && translationResponse.Data != null && translationResponse.Data.Translations != null)
                    {
                        List<Translation> translations = translationResponse.Data.Translations;

                        if (translations.Count > 0)
                        {
                            string translatedText = translations[0].TranslatedText;
                            return translatedText;
                        }
                    }
                }
            }

            return "";
        }
    }

    class TranslationResponse
    {
        public TranslationData Data { get; set; }
    }

    class TranslationData
    {
        public List<Translation> Translations { get; set; }
    }

    class Translation
    {
        public string TranslatedText { get; set; }
    }
}
