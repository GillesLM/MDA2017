<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DraftPlotPoints
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.NumCoteA = New System.Windows.Forms.NumericUpDown()
        Me.NumCoteB = New System.Windows.Forms.NumericUpDown()
        Me.LblCoteA = New System.Windows.Forms.Label()
        Me.LblCoteB = New System.Windows.Forms.Label()
        Me.LblNbrOfPosToFind = New System.Windows.Forms.Label()
        Me.NumPosToFind = New System.Windows.Forms.NumericUpDown()
        Me.BtnGenPLot = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumDistMin = New System.Windows.Forms.NumericUpDown()
        Me.LblDistMin = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Lbliteration = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCoteA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCoteB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPosToFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDistMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(841, 570)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'NumCoteA
        '
        Me.NumCoteA.Location = New System.Drawing.Point(225, 615)
        Me.NumCoteA.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumCoteA.Name = "NumCoteA"
        Me.NumCoteA.Size = New System.Drawing.Size(120, 20)
        Me.NumCoteA.TabIndex = 2
        Me.NumCoteA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumCoteA.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'NumCoteB
        '
        Me.NumCoteB.Location = New System.Drawing.Point(225, 656)
        Me.NumCoteB.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumCoteB.Name = "NumCoteB"
        Me.NumCoteB.Size = New System.Drawing.Size(120, 20)
        Me.NumCoteB.TabIndex = 2
        Me.NumCoteB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumCoteB.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'LblCoteA
        '
        Me.LblCoteA.AutoSize = True
        Me.LblCoteA.Location = New System.Drawing.Point(222, 599)
        Me.LblCoteA.Name = "LblCoteA"
        Me.LblCoteA.Size = New System.Drawing.Size(95, 13)
        Me.LblCoteA.TabIndex = 3
        Me.LblCoteA.Text = "Largeur de la zone"
        '
        'LblCoteB
        '
        Me.LblCoteB.AutoSize = True
        Me.LblCoteB.Location = New System.Drawing.Point(222, 640)
        Me.LblCoteB.Name = "LblCoteB"
        Me.LblCoteB.Size = New System.Drawing.Size(104, 13)
        Me.LblCoteB.TabIndex = 3
        Me.LblCoteB.Text = "Longueur de la zone"
        '
        'LblNbrOfPosToFind
        '
        Me.LblNbrOfPosToFind.AutoSize = True
        Me.LblNbrOfPosToFind.Location = New System.Drawing.Point(426, 599)
        Me.LblNbrOfPosToFind.Name = "LblNbrOfPosToFind"
        Me.LblNbrOfPosToFind.Size = New System.Drawing.Size(139, 13)
        Me.LblNbrOfPosToFind.TabIndex = 3
        Me.LblNbrOfPosToFind.Text = "Nombre de points à Trouver"
        '
        'NumPosToFind
        '
        Me.NumPosToFind.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumPosToFind.Location = New System.Drawing.Point(429, 615)
        Me.NumPosToFind.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumPosToFind.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumPosToFind.Name = "NumPosToFind"
        Me.NumPosToFind.Size = New System.Drawing.Size(120, 20)
        Me.NumPosToFind.TabIndex = 4
        Me.NumPosToFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumPosToFind.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'BtnGenPLot
        '
        Me.BtnGenPLot.Location = New System.Drawing.Point(429, 682)
        Me.BtnGenPLot.Name = "BtnGenPLot"
        Me.BtnGenPLot.Size = New System.Drawing.Size(120, 23)
        Me.BtnGenPLot.TabIndex = 5
        Me.BtnGenPLot.Text = "Find Points"
        Me.BtnGenPLot.UseVisualStyleBackColor = True
        '
        'NumDistMin
        '
        Me.NumDistMin.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumDistMin.Location = New System.Drawing.Point(429, 656)
        Me.NumDistMin.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumDistMin.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.NumDistMin.Name = "NumDistMin"
        Me.NumDistMin.Size = New System.Drawing.Size(120, 20)
        Me.NumDistMin.TabIndex = 6
        Me.NumDistMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumDistMin.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'LblDistMin
        '
        Me.LblDistMin.AutoSize = True
        Me.LblDistMin.Location = New System.Drawing.Point(426, 640)
        Me.LblDistMin.Name = "LblDistMin"
        Me.LblDistMin.Size = New System.Drawing.Size(166, 13)
        Me.LblDistMin.TabIndex = 7
        Me.LblDistMin.Text = "Distance minimum entre les points"
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(612, 615)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 9
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Lbliteration
        '
        Me.Lbliteration.AutoSize = True
        Me.Lbliteration.Location = New System.Drawing.Point(714, 617)
        Me.Lbliteration.Name = "Lbliteration"
        Me.Lbliteration.Size = New System.Drawing.Size(39, 13)
        Me.Lbliteration.TabIndex = 10
        Me.Lbliteration.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'DraftPlotPoints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 727)
        Me.Controls.Add(Me.Lbliteration)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LblDistMin)
        Me.Controls.Add(Me.NumDistMin)
        Me.Controls.Add(Me.BtnGenPLot)
        Me.Controls.Add(Me.NumPosToFind)
        Me.Controls.Add(Me.LblNbrOfPosToFind)
        Me.Controls.Add(Me.LblCoteB)
        Me.Controls.Add(Me.LblCoteA)
        Me.Controls.Add(Me.NumCoteB)
        Me.Controls.Add(Me.NumCoteA)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "DraftPlotPoints"
        Me.Text = "Plot Point"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCoteA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCoteB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPosToFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDistMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents NumCoteA As NumericUpDown
    Friend WithEvents NumCoteB As NumericUpDown
    Friend WithEvents LblCoteA As Label
    Friend WithEvents LblCoteB As Label
    Friend WithEvents LblNbrOfPosToFind As Label
    Friend WithEvents NumPosToFind As NumericUpDown
    Friend WithEvents BtnGenPLot As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents NumDistMin As NumericUpDown
    Friend WithEvents LblDistMin As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents Lbliteration As Label
    Friend WithEvents Timer1 As Timer
End Class
