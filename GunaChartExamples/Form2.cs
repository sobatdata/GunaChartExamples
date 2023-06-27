using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GunaChartExamples
{
    public partial class Form2 : Form
    {
        string setupName = string.Empty;
        public Form2()
        {
            InitializeComponent();

            string[] names = { "Test", "Setup" };
            for (int i = names.Length - 1; i >= 0; i--)
            {
                var button = new Button()
                {
                    BackColor = Color.Empty,
                    Text = names[i],
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Top,
                    Height = 25,
                    FlatStyle = FlatStyle.Flat,
                    Padding = new Padding(10, 0, 0, 0),
                    FlatAppearance =
                    {
                         BorderSize = 0,
                         MouseOverBackColor = Color.DodgerBlue
                    }
                };
                button.Click += (s, evnt) =>
                {
                    ReadCode(button.Text);
                    panel2.Size = new Size(5, button.Height);
                    panel2.Location = new Point(panel1.Width - 5, button.Top);
                    panel2.BringToFront();
                };
                panel1.Controls.Add(button);
            }

        }

        private void ReadCode(string name)
        {
            if (setupName == string.Empty)
            {
                richTextBox1.Text = string.Empty;
            }
            else
            {
                if (name == "Setup")
                {
                    richTextBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\BasicExamples\" + setupName + ".cs");
                    SyntaxHighlighter(richTextBox1);
                }
                else
                {
                    richTextBox1.Text = "\npublic void Test\n{\n    BasicExamples." + setupName + ".Example(this.gunaChart1);\n}";
                    SyntaxHighlighter(richTextBox1);

                }
            }
        }

        public void Show(string name)
        {
            Text = name;
            setupName = name;
            Show();
            if (panel1.Controls[1] is Button button)
            {
                button.PerformClick();
            }
        }

        private void ProcessRegex(RichTextBox richTextBox, MatchCollection matches, Color color)
        {
            foreach (Match m in matches)
            {
                richTextBox.SelectionStart = m.Index;
                richTextBox.SelectionLength = m.Length;
                richTextBox.SelectionColor = color;
            }
        }

        public void SyntaxHighlighter(RichTextBox richTextBox)
        {
            MatchCollection keywordMatches = Regex.Matches(richTextBox.Text, @"\b(for|this|public|private|partial|static|namespace|class|using|void|foreach|in|new|int|float|double|string|bool|var|object|false|true)\b");
            MatchCollection commentMatches = Regex.Matches(richTextBox.Text, "//.*$", RegexOptions.Multiline);
            MatchCollection stringMaches = Regex.Matches(richTextBox.Text, "\".+?\"");
            MatchCollection numberMaches = Regex.Matches(richTextBox.Text, "\\b(?:[0-9]*\\.)?[0-9]+\\b");
            MatchCollection gunaMaches = Regex.Matches(richTextBox.Text, @"\b(GunaChart|GunaAreaDataset|GunaBarDataset|GunaBubbleDataset|GunaDoughnutDataset|GunaHorizontalBarDataset|GunaLineDataset|GunaPieDataset|GunaPolarAreaDataset|GunaRadarDataset|GunaRoundedBarDataset|GunaScatterDataset|GunaSplineDataset|GunaSplineAreaDataset|GunaStackedBarDataset|GunaStackedHorizontalBarDataset|GunaSteppedAreaDataset|GunaSteppedLine)\b");

            int tmpIndex = richTextBox.SelectionStart;
            int tmplLength = richTextBox.SelectionLength;

            richTextBox.SelectionStart = 0;
            richTextBox.SelectionLength = richTextBox.Text.Length;
            richTextBox.SelectionColor = Color.LightGray;
            ProcessRegex(richTextBox, keywordMatches, Color.DodgerBlue);
            ProcessRegex(richTextBox, numberMaches, Color.FromArgb(197, 230, 147));
            ProcessRegex(richTextBox, commentMatches, Color.FromArgb(63, 131, 61));
            ProcessRegex(richTextBox, stringMaches, Color.FromArgb(255, 177, 146));
            ProcessRegex(richTextBox, gunaMaches, Color.FromArgb(92, 194, 154));
            richTextBox.SelectionStart = tmpIndex;
            richTextBox.SelectionLength = tmplLength;
            richTextBox.SelectionColor = Color.LightGray;
        }
    }
}
