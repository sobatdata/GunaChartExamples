using System;
using System.Drawing;
using System.Windows.Forms;

namespace GunaChartExamples
{
    public partial class Form1 : Form
    {
        private string selected = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] names = { "Area", "Bar", "Bubble", "Doughnut", "HorizontalBar", "Line", "Pie", "PolarArea", "Radar", "RoundedBar", "Scatter", "Spline", "SplineArea", "StackedBar", "StackedHorizontalBar", "SteppedArea", "SteppedLine", "MixedBarAndArea", "MixedBarAndLine", "MixedBarAndSpline", "MixedBarAndSplineArea", "MixedBarAndSteppedArea", "MixedBarAndSteppedLine" };
            panel1.BackColor = Color.FromArgb(20, 0, 0, 0);


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
                    selected = button.Text;
                    SelectBasicExamples(selected);
                    panel2.Size = new Size(5, button.Height);
                    panel2.Location = new Point(panel1.Width - 5, button.Top);
                    panel2.BringToFront();
                };
                panel1.Controls.Add(button);
            }

            button1.Click += (s, evnt) =>
            {
                new Form2().Show(selected);
            };
            radioButton1.CheckedChanged += (s, evnt) =>
            {
                if (radioButton1.Checked)
                {
                    SelectBasicExamples(selected);
                    BackColor = Color.FromArgb(38, 41, 59);
                    ForeColor = Color.LightSteelBlue;
                }
            };
            radioButton2.CheckedChanged += (s, evnt) =>
            {
                if (radioButton2.Checked)
                {
                    SelectBasicExamples(selected);
                    BackColor = Color.White;
                    ForeColor = Color.Black;
                }
            };
            radioButton1.Checked = true;


        }

        private void ApplyConfig()
        {
            if (radioButton1.Checked)
                gunaChart1.ApplyConfig(ConfigExamples.Dark.Config(), Color.FromArgb(38, 41, 59));
            else
                gunaChart1.ApplyConfig(ConfigExamples.Light.Config(), Color.White);
        }

        private void SelectBasicExamples(string name)
        {
            gunaChart1.Datasets.Clear();
            ApplyConfig();

            if (name == "Area")
                BasicExamples.Area.Example(gunaChart1);
            else if (name == "Bar")
                BasicExamples.Bar.Example(gunaChart1);
            else if (name == "RoundedBar")
                BasicExamples.RoundedBar.Example(gunaChart1);
            else if (name == "Bubble")
                BasicExamples.Bubble.Example(gunaChart1);
            else if (name == "Doughnut")
                BasicExamples.Doughnut.Example(gunaChart1);
            else if (name == "HorizontalBar")
                BasicExamples.HorizontalBar.Example(gunaChart1);
            else if (name == "Line")
                BasicExamples.Line.Example(gunaChart1);
            else if (name == "Pie")
                BasicExamples.Pie.Example(gunaChart1);
            else if (name == "PolarArea")
                BasicExamples.PolarArea.Example(gunaChart1);
            else if (name == "Radar")
                BasicExamples.Radar.Example(gunaChart1);
            else if (name == "Scatter")
                BasicExamples.Scatter.Example(gunaChart1);
            else if (name == "Spline")
                BasicExamples.Spline.Example(gunaChart1);
            else if (name == "SplineArea")
                BasicExamples.SplineArea.Example(gunaChart1);
            else if (name == "StackedBar")
                BasicExamples.StackedBar.Example(gunaChart1);
            else if (name == "StackedHorizontalBar")
                BasicExamples.StackedHorizontalBar.Example(gunaChart1);
            else if (name == "SteppedArea")
                BasicExamples.SteppedArea.Example(gunaChart1);
            else if (name == "SteppedLine")
                BasicExamples.SteppedLine.Example(gunaChart1);
            else if (name == "MixedBarAndArea")
                BasicExamples.MixedBarAndArea.Example(gunaChart1);
            else if (name == "MixedBarAndSpline")
                BasicExamples.MixedBarAndSpline.Example(gunaChart1);
            else if (name == "MixedBarAndSplineArea")
                BasicExamples.MixedBarAndSplineArea.Example(gunaChart1);
            else if (name == "MixedBarAndSteppedArea")
                BasicExamples.MixedBarAndSteppedArea.Example(gunaChart1);
            else if (name == "MixedBarAndSteppedLine")
                BasicExamples.MixedBarAndSteppedLine.Example(gunaChart1);
            else if (name == "MixedBarAndLine")
                BasicExamples.MixedBarAndLine.Example(gunaChart1);

        }
    }
}
