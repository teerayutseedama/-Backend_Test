using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEx1.Text.Length < 1)
                {
                    MessageBox.Show("PleaseInputText", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool isEnglishOnly = Regex.IsMatch(textEx1.Text, @"^[a-zA-Z]+$");
                if (!isEnglishOnly)
                {
                    MessageBox.Show("PleaseInputEnglishTextOnly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                MessageBox.Show($"Vowels In TextInput ={CountVowelGroups(textEx1.Text)}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int CountVowelGroups(string text)
        {
            string vowels = "aeiou";
            bool inVowelGroup = false;
            int groupCount = 0;
           
            foreach (char c in text.ToLower())
            {
                if (vowels.Contains(c))
                {
                    if (!inVowelGroup)
                    {
                        groupCount++;
                        inVowelGroup = true;
                    }
                }
                else
                {
                    inVowelGroup = false;
                }
            }

            return groupCount;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textEx2.Text.Length < 1)
            {
                MessageBox.Show("PleaseInputText", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isEnglishOnly = Regex.IsMatch(textEx2.Text, @"^[a-zA-Z]+$");
            if (!isEnglishOnly)
            {
                MessageBox.Show("PleaseInputEnglishTextOnly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            textEx2_result.Clear();
            List<string> results = new List<string>();
            GeneratePermutations("", textEx2.Text, results);
            label3.Text = $"Result = {results.Count}";
            textEx2_result.Lines = results.ToArray();
        }


        private void GeneratePermutations(string prefix, string remaining, List<string> results)
        {
            if (remaining.Length == 0)
            {
                results.Add($"{results.Count+1}: "+prefix);
            }
            else
            {
                for (int i = 0; i < remaining.Length; i++)
                {
                    string newPrefix = prefix + remaining[i];
                    string newRemaining = remaining.Substring(0, i) + remaining.Substring(i + 1);
                    GeneratePermutations(newPrefix, newRemaining, results);
                }
            }
        }
    }
}
