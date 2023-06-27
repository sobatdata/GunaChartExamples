<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'richTextBox1
        '
        Me.richTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(740, 632)
        Me.richTextBox1.TabIndex = 7
        Me.richTextBox1.Text = ""
        '
        'splitContainer1
        '
        Me.splitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.panel1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.richTextBox1)
        Me.splitContainer1.Size = New System.Drawing.Size(892, 632)
        Me.splitContainer1.SplitterDistance = 148
        Me.splitContainer1.TabIndex = 1
        '
        'panel1
        '
        Me.panel1.AutoScroll = True
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.panel1.Size = New System.Drawing.Size(148, 632)
        Me.panel1.TabIndex = 7
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.panel2.Location = New System.Drawing.Point(-10, 3)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(5, 5)
        Me.panel2.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(892, 632)
        Me.Controls.Add(Me.splitContainer1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents richTextBox1 As RichTextBox
    Private WithEvents splitContainer1 As SplitContainer
    Private WithEvents panel1 As Panel
    Private WithEvents panel2 As Panel
End Class
