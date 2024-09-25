using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practice_6_Dedok
{
    class UkrainianGermanDictionary
    {
        private Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
        public void AddWord(string ukrainianWord, List<string> germanTranslations)
        {
            if (!dictionary.ContainsKey(ukrainianWord))
            {
                dictionary[ukrainianWord] = germanTranslations;
                Console.WriteLine($"Слово '{ukrainianWord}' успішно додано.");
            }
            else
            {
                Console.WriteLine($"Слово '{ukrainianWord}' вже існує.");
            }
        }
        public void RemoveWord(string ukrainianWord)
        {
            if (dictionary.Remove(ukrainianWord))
            {
                Console.WriteLine($"Слово '{ukrainianWord}' видалено.");
            }
            else
            {
                Console.WriteLine($"Слово '{ukrainianWord}' не знайдено.");
            }
        }
        public void RemoveTranslations(string ukrainianWord, List<string> translationsToRemove)
        {
            if (dictionary.ContainsKey(ukrainianWord))
            {
                dictionary[ukrainianWord].RemoveAll(t => translationsToRemove.Contains(t));
                Console.WriteLine($"Переклади для '{ukrainianWord}' успішно видалені.");
            }
            else
            {
                Console.WriteLine($"Слово '{ukrainianWord}' не знайдено.");
            }
        }
        public void UpdateWord(string oldUkrainianWord, string newUkrainianWord)
        {
            if (dictionary.ContainsKey(oldUkrainianWord))
            {
                var translations = dictionary[oldUkrainianWord];
                dictionary.Remove(oldUkrainianWord);
                dictionary[newUkrainianWord] = translations;
                Console.WriteLine($"Слово '{oldUkrainianWord}' змінено на '{newUkrainianWord}'.");
            }
            else
            {
                Console.WriteLine($"Слово '{oldUkrainianWord}' не знайдено.");
            }
        }
        public void UpdateTranslation(string ukrainianWord, string oldTranslation, string newTranslation)
        {
            if (dictionary.ContainsKey(ukrainianWord))
            {
                var translations = dictionary[ukrainianWord];
                int index = translations.IndexOf(oldTranslation);
                if (index != -1)
                {
                    translations[index] = newTranslation;
                    Console.WriteLine($"Переклад '{oldTranslation}' змінено на '{newTranslation}' для слова '{ukrainianWord}'.");
                }
                else
                {
                    Console.WriteLine($"Переклад '{oldTranslation}' не знайдено.");
                }
            }
            else
            {
                Console.WriteLine($"Слово '{ukrainianWord}' не знайдено.");
            }
        }
        public void SearchWord(string ukrainianWord)
        {
            if (dictionary.ContainsKey(ukrainianWord))
            {
                Console.WriteLine($"Переклади для слова '{ukrainianWord}': {string.Join(", ", dictionary[ukrainianWord])}");
            }
            else
            {
                Console.WriteLine($"Слово '{ukrainianWord}' не знайдено.");
            }
        }
    }
}
