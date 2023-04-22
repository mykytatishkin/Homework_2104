using static System.Net.Mime.MediaTypeNames;

namespace HW2104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "This is a sample text! It contains three sentences. Can you count them?";
            stopButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Task<int> attentionCountTask = Task.Run(() => SymbolSentences(text, '!'));
            Task<int> questionCountTask = Task.Run(() => SymbolSentences(text, '?'));
            Task<Tuple<int, int, int>> countingTask = Task.Run(() => CountCharsWordsSentences(text));
            Tuple<int, int, int> counts = countingTask.Result;
            
            if (checkBoxAttent.Checked == true)
                listBox1.Items.Add($"The text contains {attentionCountTask.Result} attention sentences.");

            if (checkBoxQuest.Checked == true)
                listBox1.Items.Add($"The text contains {questionCountTask.Result} question sentences.");
            if (checkBoxChar.Checked == true)
                listBox1.Items.Add($"The text contains {counts.Item1} characters.");
            if(checkBoxWords.Checked == true)
                listBox1.Items.Add($"The text contains {counts.Item2} sentences");
            if (checkBoxSent.Checked == true)
                listBox1.Items.Add($"The text contains {counts.Item3} sentences");
            
            startButton.Text = "Restart";
            startButton.Enabled = false;
            stopButton.Enabled = true;
        }
        static int SymbolSentences(string text, char symbol)
        {
            int symbolCount = 0;
            foreach (char c in text)
            {
                if (c == symbol)
                    symbolCount++;
            }
            return symbolCount;
        }
        static Tuple<int, int, int> CountCharsWordsSentences(string text)
        {
            int charCount = 0;
            int wordCount = 0;
            int sentenceCount = 0;
            bool inWord = false;
            foreach (char c in text)
            {
                if (c == '.' || c == '!' || c == '?')
                {
                    sentenceCount++;
                    inWord = false;
                }
                else if (c == ' ' || c == '\t' || c == '\n')
                {
                    inWord = false;
                }
                else
                {
                    charCount++;
                    if (!inWord)
                    {
                        wordCount++;
                        inWord = true;
                    }
                }
            }
            return Tuple.Create(charCount, wordCount, sentenceCount);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            listBox1.Items.Clear();
            stopButton.Enabled = false;
        }
    }
}