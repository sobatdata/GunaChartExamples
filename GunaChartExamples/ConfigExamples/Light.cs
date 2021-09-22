using System;
using System.Drawing;
using Guna.Charts.WinForms;


namespace ConfigExamples
{
    class Light
    {
        public static ChartConfig Config()
        {
            Color gridColor = Color.FromArgb(214, 219, 224);
            Color foreColor = Color.FromArgb(105, 121, 139);
            Color[] colors = new Color[] { Color.FromArgb(255, 48, 162), Color.FromArgb(255, 196, 18), Color.FromArgb(12, 217, 207) };

            var font = new Guna.Charts.WinForms.ChartFont()
            {
                FontName = "Segoe UI",
                Size = 10,
                Style = Guna.Charts.WinForms.ChartFontStyle.Normal
            };

            ChartConfig config = new ChartConfig()
            {
                Title =
                {
                    ForeColor = foreColor
                },
                Legend =
                {
                    LabelFont = font,
                    LabelForeColor = foreColor
                },
                XAxes =
                {
                    GridLines =
                    {
                        Color = gridColor,
                        ZeroLineColor = gridColor
                    },
                    Ticks =
                    {
                        Font = font,
                        ForeColor = foreColor
                    }
                },
                YAxes =
                {
                    GridLines =
                    {
                        Color = gridColor,
                        ZeroLineColor = gridColor
                    },
                    Ticks =
                    {
                        Font = font,
                        ForeColor = foreColor
                    }
                },
                ZAxes =
                {
                    GridLines =
                    {
                        Color = gridColor,
                        ZeroLineColor = gridColor
                    },
                    Ticks =
                    {
                        Font = font,
                        ForeColor = foreColor
                    },
                    PointLabels =
                    {
                        Font = font,
                        ForeColor = foreColor
                    }
                },
                PaletteCustomColors =
                {
                    FillColors = new ColorCollection(colors),
                    BorderColors = new ColorCollection(colors),
                    PointFillColors = new ColorCollection(colors),
                    PointBorderColors = new ColorCollection(colors)
                }
            };
            return config;
        }
    }
}
