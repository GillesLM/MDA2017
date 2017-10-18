<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlotPositions
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ChrPosInWell = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LblWell_ID = New System.Windows.Forms.Label()
        CType(Me.ChrPosInWell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChrPosInWell
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChrPosInWell.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChrPosInWell.Legends.Add(Legend1)
        Me.ChrPosInWell.Location = New System.Drawing.Point(30, 34)
        Me.ChrPosInWell.Name = "ChrPosInWell"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Legend = "Legend1"
        Series1.Name = "Positions"
        Series1.YValuesPerPoint = 2
        Me.ChrPosInWell.Series.Add(Series1)
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
End Class
