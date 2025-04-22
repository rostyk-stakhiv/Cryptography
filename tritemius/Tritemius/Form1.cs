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
            comboBox1.Items.AddRange(new string[] { "Linear", "Non-Linear", "Word" });
            Word.Hide();
            C.Hide();
            comboBox1.SelectedIndex = 0;
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
            var valid = true;
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
            if(comboBox1.SelectedIndex==0)
            {
                if(!alphabet.Contains(Char.ToLower(text[0]))|| !alphabet.Contains(Char.ToLower(text[1])))
                {
                    MessageBox.Show("First two symbols of a text must be letters");
                    valid = false;         
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (!alphabet.Contains(Char.ToLower(text[0])) || !alphabet.Contains(Char.ToLower(text[1]))
                    || !alphabet.Contains(Char.ToLower(text[2])))
                {
                    MessageBox.Show("First three symbols of a text must be letters");
                    valid = false;
                }
            }
            else
            {
                foreach (char c in Word.Text.ToLower())
                {
                    if (!alphabet.Contains(c))
                    {
                        MessageBox.Show("Word must contain only letters");
                        valid = false;
                        break;
                    }
                }
            }
            if (valid)
            {
                bool isUpper = false;
                var newText = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    var letter = text[i];
                    isUpper = Char.IsUpper(letter);
                    letter = Char.ToLower(letter);
                    if (comboBox1.SelectedIndex == 0)
                    {
                        key = Convert.ToInt32(B.Value) * i + Convert.ToInt32(C.Value);
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        key = Convert.ToInt32(A.Value) * i * i +
                            Convert.ToInt32(B.Value) * i + Convert.ToInt32(C.Value);
                    }
                    else
                    {
                        key = alphabet.IndexOf(Char.ToLower(Word.Text[i % Word.Text.Length]));
                    }
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
            else
            {
                return "";
            }
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
                if (comboBox1.SelectedIndex == 0)
                {
                    key = Convert.ToInt32(B.Value) * i + Convert.ToInt32(C.Value);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    key = Convert.ToInt32(A.Value) * i * i +
                        Convert.ToInt32(B.Value) * i + Convert.ToInt32(C.Value);
                }
                else
                {
                    key = alphabet.IndexOf(Char.ToLower(Word.Text[i % Word.Text.Length]));
                }
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
                EncodedText.Text = Encode(DecodedText.Text, "English", Convert.ToInt32(C.Value));
            }
            else if (Ukrainian.Checked)
            {
                EncodedText.Text = Encode(DecodedText.Text, "Ukrainian", Convert.ToInt32(C.Value));
            }
            else
            {
                EncodedText.Text = Encode(DecodedText.Text, "Picture", Convert.ToInt32(C.Value));
            }

        }

        private void DecodeBtn_Click(object sender, EventArgs e)
        {
            if (English.Checked)
            {
                DecodedText.Text = Decode(EncodedText.Text, "English", Convert.ToInt32(C.Value));
            }
            else if (Ukrainian.Checked)
            {
                DecodedText.Text = Decode(EncodedText.Text, "Ukrainian", Convert.ToInt32(C.Value));
            }
            else
            {
                EncodedText.Text = Encode(DecodedText.Text, "Picture", Convert.ToInt32(C.Value));
            }
        }

        private void HackBtn_Click(object sender, EventArgs e)
        {
            
            var decoded = false;
            var alphabet = new List<char>();
            var language = "";
            if (English.Checked)
            {
                alphabet = EnglishAlphabet;
                language = "English";
            }
            else if (Ukrainian.Checked)
            {
                alphabet = UkrainianAlphabet;
                language = "Ukrainian";
            }
            else
            {
                alphabet = PictureAlphabet;
                language = "Picture";
            }
            var outtext = EncodedText.Text.ToLower();
            var intext = DecodedText.Text.ToLower();
            if(intext.Length>outtext.Length)
            {
                intext = intext.Substring(0, outtext.Length);
            }
            else if(intext.Length < outtext.Length)
            {
                outtext = outtext.Substring(0, intext.Length);
            }
            if (outtext.Length > 3 && intext.Length > 3)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    var c = alphabet.IndexOf(outtext[0]) - alphabet.IndexOf(intext[0]);
                    if (c < 0)
                    {
                        c += alphabet.Count;
                    }
                    C.Value = c;
                    var b = alphabet.IndexOf(outtext[1]) - alphabet.IndexOf(intext[1]) - c;
                    if (b < 0)
                    {
                        b += alphabet.Count;
                    }
                    B.Value = b;
                    MessageBox.Show($"Decoded. B={b}, C={c}");
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    var c = alphabet.IndexOf(outtext[0]) - alphabet.IndexOf(intext[0]);
                    C.Value = c;
                    var k1 = alphabet.IndexOf(outtext[1]) - alphabet.IndexOf(intext[1]);
                    var k2 = alphabet.IndexOf(outtext[2]) - alphabet.IndexOf(intext[2]);
                    var a2 = k2 - c - 2 * (k1 - c);
                    if (a2 < 0)
                    {
                        a2 %= alphabet.Count;
                        a2 += alphabet.Count;
                    }

                    var b2 = k2 - c - (2 * a2) % alphabet.Count;
                    if (b2 < 0)
                    {
                        b2 %= alphabet.Count;
                        b2 += alphabet.Count;
                    }
                    B.Value = b2 / 2;
                    A.Value = a2 / 2;
                    var Text = Decode(outtext, language, 0);
                    if (Text == intext)
                    {
                        MessageBox.Show($"Decoded. A={A.Value}, B={B.Value}, C={C.Value}");
                        decoded = true;
                    }
                    if (A.Value < (decimal)Math.Round(alphabet.Count / 2.0) && !decoded)
                    {
                        A.Value += (decimal)Math.Round(alphabet.Count / 2.0);
                        Text = Decode(outtext, language, 0);
                        if (Text == intext)
                        {
                            MessageBox.Show($"Decoded. A={A.Value}, B={B.Value}, C={C.Value}");
                            decoded = true;
                        }
                        else
                        {

                            B.Value += (decimal)Math.Round(alphabet.Count / 2.0);
                            Text = Decode(outtext, language, 0);
                            if (Text == intext)
                            {
                                MessageBox.Show($"Decoded. A={A.Value}, B={B.Value}, C={C.Value}");
                                decoded = true;
                            }
                        }
                        if (!decoded)
                        {
                            A.Value -= (decimal)Math.Round(alphabet.Count / 2.0);
                        }
                    }
                    if (B.Value < (decimal)Math.Round(alphabet.Count / 2.0) && !decoded)
                    {
                        B.Value += (decimal)Math.Round(alphabet.Count / 2.0);
                        Text = Decode(outtext, language, 0);
                        if (Text == intext)
                        {
                            MessageBox.Show($"Decoded. A={A.Value}, B={B.Value}, C={C.Value}");
                            decoded = true;
                        }
                        else
                        {
                            A.Value += (decimal)Math.Round(alphabet.Count / 2.0);
                            Text = Decode(outtext, language, 0);
                            if (Text == intext)
                            {
                                MessageBox.Show($"Decoded. A={A.Value}, B={B.Value}, C={C.Value}");
                                decoded = true;
                            }
                        }
                    }
                    if (!decoded)
                    {
                        MessageBox.Show("Text can not be decoded");
                    }
                }
                else
                {
                    var key = new StringBuilder();
                    for (int i = 0; i < intext.Length; i++)
                    {
                        var k = alphabet.IndexOf(outtext[i]) - alphabet.IndexOf(intext[i]);
                        if (k < 0)
                        {
                            k += alphabet.Count();
                        }
                        key.Append(alphabet[k]);
                    }
                    var res = key.ToString();
                    if (res.Length > 50)
                    {
                        res = res.Substring(0, 50);
                    }
                    Word.Text = res;
                    MessageBox.Show($"Decoded. Word is \"{Word.Text}\"");
                }
            }
            else
            {
                MessageBox.Show("text must contain at least 3 symbols");
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
            if (Encoded.Checked)
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Word.Hide();
                A.Hide();
                B.Show();
                C.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Word.Hide();
                C.Show();
                A.Show();
                B.Show();
            }
            else
            {
                Word.Show();
                C.Hide();
                A.Hide();
                B.Hide();
            }
        }
    }
}
