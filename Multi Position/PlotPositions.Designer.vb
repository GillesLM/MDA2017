<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlotPositions
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ChrPosInWell = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LblWell_ID = New System.Windows.Forms.Label()
        Me.TimerShowPosition = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ChrPosInWell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChrPosInWell
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChrPosInWell.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChrPosInWell.Legends.Add(Legend2)
        Me.ChrPosInWell.Location = New System.Drawing.Point(30, 34)
        Me.ChrPosInWell.Name = "ChrPosInWell"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Legend = "Legend1"
        Series2.Name = "Positions"
        Series2.YValuesPerPoint = 2
        Me.ChrPosInWell.Series.Add(Series2)
        Me.ChrPosInWell.Size = New System.Drawing.Size(764, 591)
        Me.ChrPosInWell.TabIndex = 0
        Me.ChrPosInWell.Text = "ChtPos"
        '
        'LblWell_ID
        '
        Me.LblWell_ID.AutoSize = True
        Me.LblWell_ID.Location = New System.Drawing.Point(355, 15)
        Me.LblWell_ID.Name = "LblWell_ID"
        Me.LblWell_ID.Size = New System.Drawing.Size(42, 13)
        Me.LblWell_ID.TabIndex = 1
        Me.LblWell_ID.Text = "Well ID"
        '
        'TimerShowPosition
        '
        Me.TimerShowPosition.Interval = 500
        '
        'PlotPositions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 637)
        Me.Controls.Add(Me.LblWell_ID)
        Me.Controls.Add(Me.ChrPosInWell)
        Me.Name = "PlotPositions"
        Me.Text = "Plot Position in the Well"
        CType(Me.ChrPosInWell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChrPosInWell As DataVisualization.Charting.Chart
    Friend WithEvents LblWell_ID As Label
    Friend WithEvents TimerShowPosition As Timer
End Class
