namespace NSGOWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> subtitleList = new();

        /// <summary>
        /// Prompts the user to select a file and displays its subtitles in the listBox.
        /// </summary>
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            // Clear the listBox and richTextBox.
            listBox1.Items.Clear();
            richTextBox1.Clear();

            // Prompt the user to select a file, assign its contents to a string, and ensure its XML tags are complete.
            string fileContent = Logic.GetFileContent();
            bool isValid = Logic.ContentIsValid(fileContent);
            if (!isValid)
            {
                MessageBox.Show("This file contains an uneven number of opening and closing tags.\n"
                              + "As a result, its contents may not display appropriately.", "Warning");
            }
            // Assign the string's subtitles to a list and display them in the listBox.
            subtitleList = Logic.GetSubtitleList(fileContent);
            foreach (string s in subtitleList)
            {
                listBox1.Items.Add(s);
            }
        }

        /// <summary>
        ///  Clears the listBox selections.
        /// </summary>
        private void btnClearLB1_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
        }

        /// <summary>
        /// Displays the subtitles in chronological, random, or alphabetized order.
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the the listBox.
            listBox1.Items.Clear();

            // Sort and display the list.
            List<string> sortedList = Logic.GetSortedSubtitleList(comboBox1, subtitleList);
            foreach (string s in sortedList)
            {
                listBox1.Items.Add(s);
            }
        }

        /// <summary>
        /// Adds subtitles from the listBox to a queue and displays them in the richTextBox.
        /// </summary>
        private void btnGetSubtitles_Click(object sender, EventArgs e)
        {
            // Add items to the queue and display them in the richTextBox.
            // PriorityQueue<string, int> subtitleQueue = Logic.AddToQueue(listBox.SelectedItems, listBox.Items);
            Queue<string> subtitleQueue = Logic.GetSubtitleQueue(listBox1.SelectedItems, listBox1.Items);
            richTextBox1.Clear();
            while (subtitleQueue.Count > 0)
            {
                richTextBox1.AppendText(subtitleQueue.Dequeue() + "\n");
            }
        }

        /// <summary>
        /// Clears the richTextBox.
        /// </summary>
        private void btnClearRTB1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        /// <summary>
        /// Takes the user to a video showing how to retrieve the file containing subtitles.
        /// </summary>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // OG Video & GIF links: https://www.screencast.com/t/ZVJummTb2ZV0, https://www.screencast.com/t/ytJoXR3k
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://youtu.be/ZxjZbvVSSG4") { UseShellExecute = true });
        }
    }
}
