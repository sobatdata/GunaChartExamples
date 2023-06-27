Imports System
Imports System.Drawing
Imports Guna.Charts.WinForms


Namespace ConfigExamples
    Friend Class Light
        Public Shared Function Config() As ChartConfig
            Dim cfg As New ChartConfig()
            Dim gridColor As Color = Color.FromArgb(214, 219, 224)
            Dim foreColor As Color = Color.FromArgb(105, 121, 139)
            Dim colors As Color() = {Color.FromArgb(255, 48, 162), Color.FromArgb(255, 196, 18), Color.FromArgb(12, 217, 207)}

            Dim chartFont = New Guna.Charts.WinForms.ChartFont() With {
                .FontName = "Segoe UI",
                .Size = 10,
                .Style = Guna.Charts.WinForms.ChartFontStyle.Normal
            }


            cfg.Title.ForeColor = foreColor

            cfg.Legend.LabelFont = chartFont
            cfg.Legend.LabelForeColor = foreColor

            cfg.XAxes.GridLines.Color = gridColor
            cfg.XAxes.GridLines.ZeroLineColor = gridColor
            cfg.XAxes.Ticks.Font = chartFont
            cfg.XAxes.Ticks.ForeColor = foreColor

            cfg.YAxes.GridLines.Color = gridColor
            cfg.YAxes.GridLines.ZeroLineColor = gridColor
            cfg.YAxes.Ticks.Font = chartFont
            cfg.YAxes.Ticks.ForeColor = foreColor

            cfg.ZAxes.GridLines.Color = gridColor
            cfg.ZAxes.GridLines.ZeroLineColor = gridColor
            cfg.ZAxes.Ticks.Font = chartFont
            cfg.ZAxes.Ticks.ForeColor = foreColor
            cfg.ZAxes.PointLabels.Font = chartFont
            cfg.ZAxes.PointLabels.ForeColor = foreColor

            cfg.PaletteCustomColors.FillColors.AddRange(colors)
            cfg.PaletteCustomColors.BorderColors.AddRange(colors)
            cfg.PaletteCustomColors.PointFillColors.AddRange(colors)
            cfg.PaletteCustomColors.PointBorderColors.AddRange(colors)
            Return cfg
        End Function
    End Class
End Namespace
