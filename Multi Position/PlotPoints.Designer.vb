<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PLotPoints
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BTNGenPlots = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.NumCoteA = New System.Windows.Forms.NumericUpDown()
        Me.NumCoteB = New System.Windows.Forms.NumericUpDown()
        Me.LblCoteA = New System.Windows.Forms.Label()
        Me.LblCoteB = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCoteA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCoteB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNGenPlots
        '
        Me.BTNGenPlots.Location = New System.Drawing.Point(493, 617)
        Me.BTNGenPlots.Name = "BTNGenPlots"
        Me.BTNGenPlots.Size = New System.Drawing.Size(206, 23)
        Me.BTNGenPlots.TabIndex = 0
        Me.BTNGenPlots.Text = "Generate plots"
        Me.BTNGenPlots.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea5.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend5)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Size = New System.Drawing.Size(841, 570)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'NumCoteA
        '
        Me.NumCoteA.Location = New System.Drawing.Point(103, 620)
        Me.NumCoteA.Name = "NumCoteA"
        Me.NumCoteA.Size = New System.Drawing.Size(120, 20)
        Me.NumCoteA.TabIndex = 2
        '
        'NumCoteB
        '
        Me.NumCoteB.Location = New System.Drawing.Point(297, 620)
        Me.NumCoteB.Name = "NumCoteB"
        Me.NumCoteB.Size = New System.Drawing.Size(120, 20)
        Me.NumCoteB.TabIndex = 2
        '
        'LblCoteA
        '
        Me.LblCoteA.AutoSize = True
        Me.LblCoteA.Location = New System.Drawing.Point(100, 595)
        Me.LblCoteA.Name = "LblCoteA"
        Me.LblCoteA.Size = New System.Drawing.Size(95, 13)
        Me.LblCoteA.TabIndex = 3
        Me.LblCoteA.Text = "Largeur de la zone"
        '
        'LblCoteB
        '
        Me.LblCoteB.AutoSize = True
        Me.LblCoteB.Location = New System.Drawing.Point(294, 595)
        Me.LblCoteB.Name = "LblCoteB"
        Me.LblCoteB.Size = New System.Drawing.Size(104, 13)
        Me.LblCoteB.TabIndex = 3
        Me.LblCoteB.Text = "Longueur de la zone"
        '
        'PLotPoints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 669)
        Me.Controls.Add(Me.LblCoteB)
        Me.Controls.Add(Me.LblCoteA)
        Me.Controls.Add(Me.NumCoteB)
        Me.Controls.Add(Me.NumCoteA)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.BTNGenPlots)
        Me.Name = "PLotPoints"
        Me.Text = "Plot Point"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCoteA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCoteB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNGenPlots As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents NumCoteA As NumericUpDown
    Friend WithEvents NumCoteB As NumericUpDown
    Friend WithEvents LblCoteA As Label
    Friend WithEvents LblCoteB As Label
End Class
