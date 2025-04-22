using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CesarCipher
{
    public partial class Form1 : Form
    {
        private List<char> EnglishAlphabet;
        private List<char> UkrainianAlphabet;
        private List<char> PictureAlphabet;
        private List<string> DictionaryUkr;
        private List<string> DictionaryEn;
        private string path;
        private string extension;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DictionaryUkr = File.ReadAllLines("DictionaryUkr.txt").ToList();
            DictionaryEn = File.ReadAllLines("Dictionary.txt").ToList();
            openFileDialog1.Filter = "Image files (*.jpg)|*.jpg|Text files (*.txt)|*.txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            English.Checked = true;
            Encoded.Checked = true;
            EnglishAlphabet = new List<char>();
            UkrainianAlphabet = new List<char>();
            for (int i = 97; i < 123; i++)
            {
                EnglishAlphabet.Add((char)i);
            }
            PictureAlphabet = new List<char>(EnglishAlphabet);
            EnglishAlphabet.Add((char)32);

            for (int i = 1072; i < 1104; i++)
            {
                UkrainianAlphabet.Add((char)i);
            }
            UkrainianAlphabet.RemoveRange(26, 2);
            UkrainianAlphabet.RemoveAt(27);
            UkrainianAlphabet.Insert(4, 'ґ');
            UkrainianAlphabet.Insert(7, 'є');
            UkrainianAlphabet.Insert(11, 'і');
            UkrainianAlphabet.Insert(12, 'ї');
            UkrainianAlphabet.Add((char)32);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TableBtn_Click(object sender, EventArgs e)
        {
            var text = EncodedText.Text.ToLower();
            var alphabet = new List<char>();
            if (English.Checked)
            {
                alphabet = EnglishAlphabet;
            }
            else if (Ukrainian.Checked)
            {
                alphabet = UkrainianAlphabet;
            }
            else
            {
                alphabet = PictureAlphabet;
            }
            var pairs = new Dictionary<char, int>();
            foreach (char c in alphabet)
            {
                pairs.Add(c, text.Count(x => x == c));
            }
            var table = new Table(pairs);
            table.Activate();
            table.Show();
        }
        private string Encode(string encodedText, string language, int key)
        {
            var alphabet = new List<char>();
            if (language == "English")
            {
                alphabet = EnglishAlphabet;
            }
            else if (language == "Ukrainian")
            {
                alphabet = UkrainianAlphabet;
            }
            else
            {
                alphabet = PictureAlphabet;
            }
            var text = encodedText;
            bool isUpper = false;
            var newText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                var letter = text[i];
                isUpper = Char.IsUpper(letter);
                letter = Char.ToLower(letter);
                key = key % alphabet.Count;
                if (key < 0)
                {
                    key += alphabet.Count;
                }
                var index = alphabet.IndexOf(letter);
                if (index != -1)
                {
                    var tempkey = (index + key) % alphabet.Count;
                    if (tempkey < 0)
                    {
                        tempkey += alphabet.Count;
                    }
                    letter = alphabet[tempkey];
                    if (isUpper)
                    {
                        letter = Char.ToUpper(letter);
                    }
                    newText.Append(letter);
                }
                else
                {
                    if (isUpper)
                    {
                        letter = Char.ToUpper(letter);
                    }
                    newText.Append(letter);
                }

            }
            return newText.ToString();
        }

        private string Decode(string encodedText, string language, int key)
        {
            var alphabet = new List<char>();
            if (language == "English")
            {
                alphabet = EnglishAlphabet;
            }
            else if (language == "Ukrainian")
            {
                alphabet = UkrainianAlphabet;
            }
            else
            {
                alphabet = PictureAlphabet;
            }
            var text = encodedText;
            bool isUpper = false;
            var newText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                var letter = text[i];
                isUpper = Char.IsUpper(letter);
                letter = Char.ToLower(letter);
                key = key % alphabet.Count;
                if (key < 0)
                {
                    key += alphabet.Count;
                }
                var index = alphabet.IndexOf(letter);
                if (index != -1)
                {
                    var tempkey = (index - key) % alphabet.Count;
                    if (tempkey < 0)
                    {
                        tempkey += alphabet.Count;
                    }
                    letter = alphabet[tempkey];
                    if (isUpper)
                    {
                        letter = Char.ToUpper(letter);
                    }
                    newText.Append(letter);
                }
                else
                {
                    if (isUpper)
                    {
                        letter = Char.ToUpper(letter);
                    }
                    newText.Append(letter);
                }
            }

            return newText.ToString();
        }
        private void EncodeBtn_Click(object sender, EventArgs e)
        {
            if (English.Checked)
            {
                EncodedText.Text = Encode(DecodedText.Text, "English", Convert.ToInt32(Key.Value));
            }
            else if (Ukrainian.Checked)
            {
                EncodedText.Text = Encode(DecodedText.Text, "Ukrainian", Convert.ToInt32(Key.Value));
            }
            else if (Picture.Checked)
            {
                EncodedText.Text = Encode(DecodedText.Text, "Picture", Convert.ToInt32(Key.Value));
            }

        }

        private void DecodeBtn_Click(object sender, EventArgs e)
        {
            if (English.Checked)
            {
                DecodedText.Text = Decode(EncodedText.Text, "English", Convert.ToInt32(Key.Value));
            }
            else if (Ukrainian.Checked)
            {
                DecodedText.Text = Decode(EncodedText.Text, "Ukrainian", Convert.ToInt32(Key.Value));
            }
            else if (Picture.Checked)
            {
                DecodedText.Text = Decode(EncodedText.Text, "Picture", Convert.ToInt32(Key.Value));
            }
        }

        private void HackBtn_Click(object sender, EventArgs e)
        {
            var decoded = false;
            if (English.Checked)
            {
                for (int i = 1; i < 28; i++)
                {
                    var text = Decode(EncodedText.Text, "English", i);
                    var temptext = text.ToLower();
                    temptext = temptext.Replace(",", "");
                    temptext = temptext.Replace(".", "");
                    temptext = temptext.Replace("-", "");
                    temptext = temptext.Replace("!", "");
                    temptext = temptext.Replace("?", "");
                    temptext = temptext.Replace("\"", "");
                    var words = temptext.Split(' ');
                    var counter = words.Length/10;
                    foreach (var word in words)
                    {
                        if(!DictionaryEn.Contains(word))
                        {
                            counter--;
                        }
                        if(counter == 0)
                        {
                            break;
                        }
                    }
                    if(counter > 0)
                    {
                        Key.Value = i;
                        DecodedText.Text = text;
                        MessageBox.Show($"Decoded, Key is{i}");
                        decoded = true;
                        break;
                    }
                }

            }
            else if (Ukrainian.Checked)
            {
                for (int i = 1; i < 35; i++)
                {
                    var text = Decode(EncodedText.Text, "Ukrainian", i);
                    var temptext = text.ToLower();
                    temptext = temptext.Replace(",", "");
                    temptext = temptext.Replace(".", "");
                    temptext = temptext.Replace("-", "");
                    temptext = temptext.Replace("!", "");
                    temptext = temptext.Replace("?", "");
                    temptext = temptext.Replace("\"", "");
                    var words = temptext.Split(' ');
                    var counter = words.Length / 10;
                    foreach (var word in words)
                    {
                        if (!DictionaryUkr.Contains(word))
                        {
                            counter--;
                        }
                        if (counter == 0)
                        {
                            break;
                        }
                    }
                    if (counter > 0)
                    {
                        Key.Value = i;
                        DecodedText.Text = text;
                        MessageBox.Show($"Decoded, Key is{i}");
                        decoded = true;
                        break;
                    }
                }
            }
            if(!decoded)
            {
                MessageBox.Show("Text can not be decoded");
            }
        }

        private void English_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Ukrainian_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodedText.Text = "";
            DecodedText.Text = "";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            extension = path.Split('.').Last();
            if (File.Exists(path))
            {
                if (extension == "txt")
                {
                    DecodedText.Text = File.ReadAllText(path);
                }
                if (extension == "jpg")
                {
                    MemoryStream mStream = new MemoryStream();

                    var img = Image.FromFile(path);
                    img.Save(mStream, img.RawFormat);
                    var bytes = mStream.ToArray();
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                    string coded = Encoding.UTF8.GetString(bytes);
                    DecodedText.Text = base64String;
                }
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var text = "";
            if(Encoded.Checked)
            {
                text = EncodedText.Text;
            }
            else
            {
                text = DecodedText.Text;
            }
            if (extension == "txt")
            {
                File.WriteAllText(path, text);
            }
            else if (extension == "jpg")
            {
                text = text.Replace(" ", "+");
                var bytes = Convert.FromBase64String(text);
                System.IO.File.WriteAllBytes(path, bytes);
            }
            MessageBox.Show("Saved :)");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            path = saveFileDialog1.FileName;
            extension = path.Split('.').Last();
        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Андрушко Ярина, ПМО-31");
        }
    }
}
