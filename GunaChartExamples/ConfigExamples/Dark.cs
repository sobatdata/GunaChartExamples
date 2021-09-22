using System;
using System.Drawing;
using Guna.Charts.WinForms;

namespace ConfigExamples
{
    class Dark
    {
        public static ChartConfig Config()
        {
            ChartConfig config = new ChartConfig();
            Color gridColor = Color.FromArgb(49, 52, 82);
            Color foreColor = Color.FromArgb(177, 182, 205);
            Color[] colors = new Color[] { Color.FromArgb(140, 81, 165), Color.FromArgb(203, 94, 152), Color.FromArgb(244, 123, 138), Color.FromArgb(255, 163, 127), Color.FromArgb(255, 210, 133) };

            var chartFont = new Guna.Charts.WinForms.ChartFont()
            {
                FontName = "Segoe UI",
                Size = 10,
                Style = Guna.Charts.WinForms.ChartFontStyle.Normal
            };

            config.Title.ForeColor = foreColor;

            config.Legend.LabelFont = chartFont;
            config.Legend.LabelForeColor = foreColor;

            config.XAxes.GridLines.Color = gridColor;
            config.XAxes.GridLines.ZeroLineColor = gridColor;
            config.XAxes.Ticks.Font = chartFont;
            config.XAxes.Ticks.ForeColor = foreColor;

            config.YAxes.GridLines.Color = gridColor;
            config.YAxes.GridLines.ZeroLineColor = gridColor;
            config.YAxes.Ticks.Font = chartFont;
            config.YAxes.Ticks.ForeColor = foreColor;

            config.ZAxes.GridLines.Color = gridColor;
            config.ZAxes.GridLines.ZeroLineColor = gridColor;
            config.ZAxes.Ticks.Font = chartFont;
            config.ZAxes.Ticks.ForeColor = foreColor;
            config.ZAxes.PointLabels.Font = chartFont;
            config.ZAxes.PointLabels.ForeColor = foreColor;

            config.PaletteCustomColors.FillColors.AddRange(colors);
            config.PaletteCustomColors.BorderColors.AddRange(colors);
            config.PaletteCustomColors.PointFillColors.AddRange(colors);
            config.PaletteCustomColors.PointBorderColors.AddRange(colors);

            return config;
        }

    }
}
