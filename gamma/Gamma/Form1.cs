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
        private string path;
        private string extension;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            var text = DecodedText.Text.ToLower();
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
            key.Text = GenerateGamma(alphabet, text.Length);       
        }
        private string Encode(string encodedText, string language, string gamma)
        {
            if(gamma.Length<1)
            {
                MessageBox.Show("Gamma must contain at least one character");
            }
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
                var key = alphabet.IndexOf(Char.ToLower(gamma[i % gamma.Length]));
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

        private string Decode(string encodedText, string language, string gamma)
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
                var key = alphabet.IndexOf(Char.ToLower(gamma[i % gamma.Length]));
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

                EncodedText.Text = Encode(DecodedText.Text, "English", key.Text);
            }
            else if (Ukrainian.Checked)
            {
                EncodedText.Text = Encode(DecodedText.Text, "Ukrainian", key.Text);
            }
            else if (Picture.Checked)
            {
                EncodedText.Text = Encode(DecodedText.Text, "Picture", key.Text);
            }

        }

        private string GenerateGamma(List<char> alphabet,int length)
        {
            length += 1;
            var size = alphabet.Count;
            Random r = new Random();
            var gamma = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                gamma.Append(alphabet[r.Next(0, size - 1)]);
            }
            return gamma.ToString();
        }
        private void DecodeBtn_Click(object sender, EventArgs e)
        {
            if (English.Checked)
            {
                DecodedText.Text = Decode(EncodedText.Text, "English", key.Text);
            }
            else if (Ukrainian.Checked)
            {
                DecodedText.Text = Decode(EncodedText.Text, "Ukrainian", key.Text);
            }
            else if (Picture.Checked)
            {
                DecodedText.Text = Decode(EncodedText.Text, "Picture", key.Text);
            }
        }

        private void HackBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var path = saveFileDialog1.FileName;
            File.WriteAllText(path, key.Text);
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

        private void openNotepad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var path = openFileDialog1.FileName;
            key.Text = File.ReadAllText(path);
        }

        private void key_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
