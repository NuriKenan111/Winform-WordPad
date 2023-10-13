using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            string[] fontArr = new string[] { "Arial", "Times New Roman", "Calibri", "Verdana", "Tahoma", "Symbol" };
            string[] sizeArr = new string[] { "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" };
            sizeBox.Items.AddRange(sizeArr);
            fontBox.Items.AddRange(fontArr);
        }

        private void fontBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontName = fontBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedFontName) && int.TryParse(sizeBox.SelectedItem?.ToString(), out int selectedFontSize)) // Null ve boşluk kontrolü ekledik
            {
                Font selectedFont = new Font(selectedFontName, selectedFontSize);

                richTextBox1.Font = selectedFont;
            }
            else
            {
                Font selectedFont = new Font(selectedFontName, 12);
                richTextBox1.Font = selectedFont;
            }
        }

        private void sizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontName = fontBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedFontName) && int.TryParse(sizeBox.SelectedItem?.ToString(), out int selectedFontSize)) // Null ve boşluk kontrolü ekledik
            {
                Font selectedFont = new Font(selectedFontName, selectedFontSize);

                richTextBox1.Font = selectedFont;
            }
            else
            {
                Font selectedFont = new Font(selectedFontName, 12);
                richTextBox1.Font = selectedFont;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.Font;
            Font newFont = new Font(currentFont, currentFont.Style | FontStyle.Bold);

            richTextBox1.Font = newFont;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.Font;
            Font newFont = new Font(currentFont, currentFont.Style | FontStyle.Italic);

            richTextBox1.Font = newFont;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.Font;
            Font newFont = new Font(currentFont, currentFont.Style | FontStyle.Regular);

            richTextBox1.Font = newFont;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void colorBox_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorBox.Items.Add(colorDialog1.Color.Name);
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
    }
}