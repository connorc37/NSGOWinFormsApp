using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSGOWinFormsApp
{
    public class Logic
    {
        /// <summary>
        /// Displays a dialog box that prompts the user to select an XML file. The file is then read and its contents returned as a string.
        /// </summary>
        /* TODO: Filter acceptable files sooner.
         * The file we want has no extension, and while 'openFileDialog1.Filter' is capable of setting the file name
         * filter string, setting it to "", null, or String.Empty essentially says "no filter" rather than "no extension".
         * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=windowsdesktop-6.0 */
        public static string GetFileContent()
        {
            string result = string.Empty;

            // Display a dialog box that prompts the user to open a file.
            using OpenFileDialog openFileDialog1 = new();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Ensure the extension is appropriate and restart if it isn't.
                string path = Path.GetExtension(openFileDialog1.FileName);
                if (path != "" && path != ".txt")
                {
                    MessageBox.Show("Invalid file type.", "Error");
                    Application.Restart();
                    Environment.Exit(1);
                }
                // Open the file and implement a TextReader to read it.
                var fileStream = openFileDialog1.OpenFile();
                using StreamReader reader = new(fileStream);
                result = reader.ReadToEnd();
            }
            return result;
        }

        /// <summary>
        /// Accepts the string from GetFileContent() and checks it to see if an equal number of tag symbols (<, >) exist.
        /// </summary>
        public static bool ContentIsValid(string content)
        {
            Stack<char> openerTags = new();

            // Visit each character.
            for (int i = 0; i < content.Length; i++)
            {
                // If the char is a tag opener, push it to the stack.
                if (content[i] == '<')
                {
                    openerTags.Push(content[i]);
                }
                // If the char is a tag closer, pop its opener.
                if (content[i] == '>')
                {
                    if (openerTags.Count == 0)
                    {
                        return false;
                    }
                    openerTags.Pop();
                }
            }
            return openerTags.Count == 0;
        }

        /// <summary>
        /// Accepts the string from GetFileContent() and returns its subtitles as strings in a list.
        /// </summary>
        // TODO: Consider bundling IsValid() and GetSubtitleList() in GetFileContent().

        public static List<string> GetSubtitleList(string content)
        {
            string result = string.Empty;
            List<string> resultsList = new();

            // Visit each character, beginning with the 4th (avoids IndexOutOfRangeExceptions)
            for (int i = 4; i < content.Length; i++)
            {
                // If we're in an opening span tag...
                int neg4 = i - 4, neg3 = i - 3, neg2 = i - 2, neg1 = i - 1;
                if (content[i] == ' ' && content[neg4] == 's' && content[neg3] == 'p' && content[neg2] == 'a' && content[neg1] == 'n')
                {
                    // Advance through it to the subtitles.
                    while (content[i] != '>')
                    {
                        i++;
                    }
                    i++;
                    // Add the subtitles to the result string.
                    while (content[i] != '<')
                    {
                        result += content[i];
                        i++;
                    }
                    resultsList.Add(result);
                    result = string.Empty;
                }
            }
            return resultsList;
        }

        /// <summary>
        /// Accepts the ListBox's items and selected items, adds them to a queue, and returns it.
        /// </summary>
        internal static Queue<string> GetSubtitleQueue(ListBox.SelectedObjectCollection selectedItems, ListBox.ObjectCollection items)
        {
            Queue<string> subtitleQueue = new Queue<string>();

            // Add all selected items to a queue.
            subtitleQueue.Enqueue("Selected subtitles:\n");
            foreach (string item in selectedItems)
            {
                subtitleQueue.Enqueue(item);
            }
            // Add all items to a queue.
            subtitleQueue.Enqueue("\nAll subtitles:\n");
            foreach (string item in items)
            {
                subtitleQueue.Enqueue(item);
            }
            return subtitleQueue;
        }

        /// <summary>
        /// Accepts the comboBox, the subtitle list from GetSubtitleList(), and returns a sorted version of it based on the comboBox's selected index.
        /// </summary>
        internal static List<string> GetSortedSubtitleList(ComboBox comboBox, List<string> subtitleList)
        {
            List<string> sortedList = new(subtitleList); ;

            // If "Random" is selected, generate a randomly ordered list.
            if (comboBox.Text == "Random")
            {
                Random random = new();
                return sortedList.OrderBy(x => random.Next()).ToList();
            }
            // If "Alphabetical" is selected, generate an alphabetized list.
            else if (comboBox.Text == "Alphabetical")
            {
                return Alphabetize(sortedList);
            }
            // Else, generate a list in chronological order.
            else
            {
                return sortedList;
            }
        }

        /// <summary>
        /// Accepts an unsorted list, alphabetizes it using insertion sort, and returns it.
        /// </summary>
        public static List<string> Alphabetize(List<string> unsortedList)
        {
            List<string> sortedList = new(unsortedList);

            for (int i = 0; i < sortedList.Count; i++)
            {
                string curr = sortedList[i];
                int j = i - 1;
                while (j >= 0 && curr.CompareTo(sortedList[j]) < 0)
                {
                    sortedList[j + 1] = sortedList[j];
                    sortedList[j] = curr;
                    j--;
                }
            }
            return sortedList;
        }
    }
}
