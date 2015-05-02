using System.Text.RegularExpressions;
using System;
using System.IO;

namespace StringFormatLibrary
{
    /// <summary>
    ///  Class StringFormatter contains function to do transformations with string
    /// </summary>
    public class StringFormatter
    {
        public static string Pattern = @"^\d{1,}\.\d{1,}\,\d{1,}\.\d{1,}$";
        /// <summary>
        /// The method checks the contents of the string and formats satisfy the condition.
        /// </summary>
        /// <param name="line">Line with coordinates</param>
        /// <param name="coordinats">Converted string</param>
        /// <returns>Returns a boolean value</returns>
        public static bool TryToFormatString(string line, out string coordinats)
        {
            if (line != null)
            {
                Regex regex = new Regex(Pattern);
                coordinats = "";
                string[] splitedLine = line.Split(',');

                if (regex.IsMatch(line))
                {
                    coordinats = string.Format("X: {0} Y: {1}\n", splitedLine[0].Replace('.', ','), splitedLine[1].Replace('.', ','));// просто так более читаемо, как по мне я просто не знала как им пользоваться(, ну вот, теперь знаешь, как и обычным writeline
                    return true;
                }
            }

            coordinats = null;
            return false;
        }
        /// <summary>
        /// The method checks the all text and formats satisfy the condition.
        /// </summary>
        /// <param name="textForSplit">Text for formatting in coordinates form</param>
        /// <param name="textError">If string isn't coordinates write here error text</param>
        /// <returns>Returns all coordinates</returns>
        public static string FormatAllText(string textForSplit, string textError)
        {
            string coordinats;
            string allCoordinates = "";
            foreach (string line in textForSplit.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                if (TryToFormatString(line, out coordinats))
                {
                    allCoordinates += coordinats;
                }
                else
                {
                    allCoordinates += textError + "\n";
                }
            }
            return allCoordinates; 
        }
        /// <summary>
        /// The method checks the all text from file and formats satisfy the condition.
        /// </summary>
        /// <param name="pathToFile">Link to a file</param>
        /// <param name="textError">Error Message "Wrong format"</param>
        /// <returns>return text after formatting</returns>
        public static string FormatAllTextFromFile(string pathToFile, string textError)
        {
            // проверки
            if (!File.Exists(pathToFile) || !pathToFile.EndsWith(".txt"))
                throw new Exception();

            //OpenFileDialog
            return FormatAllText(File.ReadAllText(pathToFile), textError);
        }
    }
}
