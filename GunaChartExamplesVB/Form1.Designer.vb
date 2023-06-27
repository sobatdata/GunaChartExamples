<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartFont9 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim ChartFont10 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim ChartFont11 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim ChartFont12 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Grid4 As Guna.Charts.WinForms.Grid = New Guna.Charts.WinForms.Grid()
        Dim Tick4 As Guna.Charts.WinForms.Tick = New Guna.Charts.WinForms.Tick()
        Dim ChartFont13 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Grid5 As Guna.Charts.WinForms.Grid = New Guna.Charts.WinForms.Grid()
        Dim Tick5 As Guna.Charts.WinForms.Tick = New Guna.Charts.WinForms.Tick()
        Dim ChartFont14 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Grid6 As Guna.Charts.WinForms.Grid = New Guna.Charts.WinForms.Grid()
        Dim PointLabel2 As Guna.Charts.WinForms.PointLabel = New Guna.Charts.WinForms.PointLabel()
        Dim ChartFont15 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Tick6 As Guna.Charts.WinForms.Tick = New Guna.Charts.WinForms.Tick()
        Dim ChartFont16 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.gunaChart1 = New Guna.Charts.WinForms.GunaChart()
        Me.button1 = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.AutoScroll = True
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.panel1.Size = New System.Drawing.Size(183, 647)
        Me.panel1.TabIndex = 8
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.panel2.Location = New System.Drawing.Point(-10, 3)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(5, 5)
        Me.panel2.TabIndex = 0
        '
        'radioButton2
        '
        Me.radioButton2.AutoSize = True
        Me.radioButton2.Location = New System.Drawing.Point(317, 19)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(48, 17)
        Me.radioButton2.TabIndex = 7
        Me.radioButton2.Text = "Light"
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Location = New System.Drawing.Point(263, 19)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(48, 17)
        Me.radioButton1.TabIndex = 6
        Me.radioButton1.Text = "Dark"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'gunaChart1
        '
        Me.gunaChart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gunaChart1.BackColor = System.Drawing.Color.White
        ChartFont9.FontName = "Arial"
        Me.gunaChart1.Legend.LabelFont = ChartFont9
        Me.gunaChart1.Location = New System.Drawing.Point(206, 54)
        Me.gunaChart1.Name = "gunaChart1"
        Me.gunaChart1.Size = New System.Drawing.Size(795, 581)
        Me.gunaChart1.TabIndex = 5
        ChartFont10.FontName = "Arial"
        ChartFont10.Size = 12
        ChartFont10.Style = Guna.Charts.WinForms.ChartFontStyle.Bold
        Me.gunaChart1.Title.Font = ChartFont10
        ChartFont11.FontName = "Arial"
        Me.gunaChart1.Tooltips.BodyFont = ChartFont11
        ChartFont12.FontName = "Arial"
        ChartFont12.Size = 9
        ChartFont12.Style = Guna.Charts.WinForms.ChartFontStyle.Bold
        Me.gunaChart1.Tooltips.TitleFont = ChartFont12
        Me.gunaChart1.XAxes.GridLines = Grid4
        ChartFont13.FontName = "Arial"
        Tick4.Font = ChartFont13
        Me.gunaChart1.XAxes.Ticks = Tick4
        Me.gunaChart1.YAxes.GridLines = Grid5
        ChartFont14.FontName = "Arial"
        Tick5.Font = ChartFont14
        Me.gunaChart1.YAxes.Ticks = Tick5
        Me.gunaChart1.ZAxes.GridLines = Grid6
        ChartFont15.FontName = "Arial"
        PointLabel2.Font = ChartFont15
        Me.gunaChart1.ZAxes.PointLabels = PointLabel2
        ChartFont16.FontName = "Arial"
        Tick6.Font = ChartFont16
        Me.gunaChart1.ZAxes.Ticks = Tick6
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Location = New System.Drawing.Point(206, 15)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(35, 25)
        Me.button1.TabIndex = 9
        Me.button1.Text = "{  }"
        Me.button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1007, 647)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.radioButton2)
        Me.Controls.Add(Me.radioButton1)
        Me.Controls.Add(Me.gunaChart1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents panel2 As Panel
    Private WithEvents radioButton2 As RadioButton
    Private WithEvents radioButton1 As RadioButton
    Private WithEvents gunaChart1 As Guna.Charts.WinForms.GunaChart
    Private WithEvents button1 As Button
End Class
