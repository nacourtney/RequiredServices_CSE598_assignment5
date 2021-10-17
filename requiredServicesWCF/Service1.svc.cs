using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;

namespace requiredServicesWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string WordFilter(string userInput)
        {
            var words_to_remove = new HashSet<string> { "the", "of", "and", "in", "to", "a", "is", "that", "by", "as", "an", "on", "are" };
            // traverse over the string and remove all stop words
            string output = string.Join(" ",
                   userInput
                    .Split(new[] { ' ', '\t', '\n', '\r' })
                    .Where(word => !words_to_remove.Contains(word))
            );


            // return the string without the stop words
            return output;
        }

        // Works up to here
        public string getStarted(string url)
        {
            // Get string from webpage
            string webPageAsString = getStringFromURL(url);
            string removeHTMLelements = stripHTML(webPageAsString);
            Dictionary<string, int> toDictionary = webPageToDictionary(removeHTMLelements);

            // Add English Dictionary 
            Dictionary<string, int> englishDictionary = addWordsToDictionary();
            // Remove words that don't match in the English dictionary
            Dictionary<string, int> difference = differenceInDictionary(toDictionary, englishDictionary);
            // Take top 10 sorted words
            string topTen = orderAndTakeTopTen(difference);
            return topTen;
        }

        public string orderAndTakeTopTen(Dictionary<string, int> difference)
        {
            string results = "";
            // Return top ten in decending order
            foreach (var item in difference.OrderByDescending(r => r.Value).Skip(1).Take(10).ToArray())
            {
                results += string.Concat(item.Key, ":", item.Value, "\n ");
                // Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }


            return results;
        }

        public Dictionary<string, int> addWordsToDictionary()
        {
            Dictionary<string, int> englishDictionary = new Dictionary<string, int>();
            using (StreamReader sr =
                new StreamReader(@"C:\Users\Nikki Courtney\Downloads\RequiredServices_CSE598_assignment5\RequiredServices_CSE598_assignment5\requiredServicesWCF\DictionaryFile\enDictionary.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] arr = line.Split(' ');
                    englishDictionary.Add(arr[0], 1);
                }
            }

            return englishDictionary;
        }

        public Dictionary<string, int> differenceInDictionary(Dictionary<string, int> toDictionary, Dictionary<string, int> englishDictionary)
        {
            Dictionary<string, int> ResultDictionary = new Dictionary<string, int>();

            foreach (var key in toDictionary)
            {
                if (!englishDictionary.ContainsKey(key.ToString()))
                {
                    toDictionary.Remove(key.ToString());
                }
            }

            return toDictionary;
        }

        public Dictionary<string, int> webPageToDictionary(string removeHTMLelements)
        {
            var contents = removeHTMLelements.ToLower().Split(' ');

            Dictionary<string, int> RepeatWordCount = new Dictionary<string, int>();

            // Add a word to the dictionary
            // If the word already exists, increment the value by 1
            for (int i = 0; i < contents.Length; i++)
            {
                if (RepeatWordCount.ContainsKey(contents[i]))
                {
                    int wordCount = RepeatWordCount[contents[i]];
                    RepeatWordCount[contents[i]] = wordCount + 1;
                }
                else
                {
                    RepeatWordCount.Add(contents[i], 1);

                }
            }

            return RepeatWordCount;


        }

        public string stripHTML(string webPageAsString)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(webPageAsString);

            var strippedHTML = string.Join(" ", doc.DocumentNode.SelectNodes("//*[text()]").Select(node => node.InnerText));

            Regex reg = new Regex("[^a-zA-Z' ]");

            string almost = reg.Replace(strippedHTML, string.Empty);

            almost = Regex.Replace(almost, @"[^\u0009\u000A\u000D\u0020-\u007E]", "");
            almost = Regex.Replace(almost, "px", "");
            return almost;


        }

        public string getStringFromURL(string url)
        {
            WebClient downloadedString = new WebClient();
            string webPageAsString = downloadedString.DownloadString(url);

            return webPageAsString;

        }
    }
}
