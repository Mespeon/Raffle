<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.lblDBConnMarker = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.pbxYearString = New System.Windows.Forms.PictureBox()
        Me.pbxDigit01 = New System.Windows.Forms.PictureBox()
        Me.pbxDigit02 = New System.Windows.Forms.PictureBox()
        Me.pbxDigit03 = New System.Windows.Forms.PictureBox()
        Me.pbxDigit04 = New System.Windows.Forms.PictureBox()
        Me.pbxDigit05 = New System.Windows.Forms.PictureBox()
        Me.pnlStudentNumbers = New System.Windows.Forms.Panel()
        Me.rouletteTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlControls.SuspendLayout()
        CType(Me.pbxYearString, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDigit01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDigit02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDigit03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDigit04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDigit05, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStudentNumbers.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlControls
        '
        Me.pnlControls.BackgroundImage = Global.Randomizer.My.Resources.Resources.raffles_background_rightbar_rev2
        Me.pnlControls.Controls.Add(Me.lblDBConnMarker)
        Me.pnlControls.Controls.Add(Me.btnExit)
        Me.pnlControls.Controls.Add(Me.btnDraw)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlControls.Location = New System.Drawing.Point(850, 0)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(150, 700)
        Me.pnlControls.TabIndex = 0
        '
        'lblDBConnMarker
        '
        Me.lblDBConnMarker.BackColor = System.Drawing.Color.Transparent
        Me.lblDBConnMarker.ForeColor = System.Drawing.Color.Gray
        Me.lblDBConnMarker.Location = New System.Drawing.Point(13, 478)
        Me.lblDBConnMarker.Name = "lblDBConnMarker"
        Me.lblDBConnMarker.Size = New System.Drawing.Size(125, 31)
        Me.lblDBConnMarker.TabIndex = 9
        Me.lblDBConnMarker.Text = "Status"
        Me.lblDBConnMarker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(17, 640)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 48)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDraw
        '
        Me.btnDraw.BackColor = System.Drawing.Color.Transparent
        Me.btnDraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDraw.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen
        Me.btnDraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDraw.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDraw.ForeColor = System.Drawing.Color.White
        Me.btnDraw.Location = New System.Drawing.Point(17, 512)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(121, 48)
        Me.btnDraw.TabIndex = 1
        Me.btnDraw.Text = "Draw"
        Me.btnDraw.UseVisualStyleBackColor = False
        '
        'pbxYearString
        '
        Me.pbxYearString.BackColor = System.Drawing.Color.Transparent
        Me.pbxYearString.InitialImage = Global.Randomizer.My.Resources.Resources._0000
        Me.pbxYearString.Location = New System.Drawing.Point(0, 30)
        Me.pbxYearString.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxYearString.Name = "pbxYearString"
        Me.pbxYearString.Size = New System.Drawing.Size(200, 50)
        Me.pbxYearString.TabIndex = 2
        Me.pbxYearString.TabStop = False
        '
        'pbxDigit01
        '
        Me.pbxDigit01.BackColor = System.Drawing.Color.Transparent
        Me.pbxDigit01.InitialImage = Nothing
        Me.pbxDigit01.Location = New System.Drawing.Point(200, 30)
        Me.pbxDigit01.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxDigit01.Name = "pbxDigit01"
        Me.pbxDigit01.Size = New System.Drawing.Size(50, 50)
        Me.pbxDigit01.TabIndex = 3
        Me.pbxDigit01.TabStop = False
        '
        'pbxDigit02
        '
        Me.pbxDigit02.BackColor = System.Drawing.Color.Transparent
        Me.pbxDigit02.InitialImage = Nothing
        Me.pbxDigit02.Location = New System.Drawing.Point(250, 30)
        Me.pbxDigit02.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxDigit02.Name = "pbxDigit02"
        Me.pbxDigit02.Size = New System.Drawing.Size(50, 50)
        Me.pbxDigit02.TabIndex = 4
        Me.pbxDigit02.TabStop = False
        '
        'pbxDigit03
        '
        Me.pbxDigit03.BackColor = System.Drawing.Color.Transparent
        Me.pbxDigit03.InitialImage = Nothing
        Me.pbxDigit03.Location = New System.Drawing.Point(300, 30)
        Me.pbxDigit03.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxDigit03.Name = "pbxDigit03"
        Me.pbxDigit03.Size = New System.Drawing.Size(50, 50)
        Me.pbxDigit03.TabIndex = 5
        Me.pbxDigit03.TabStop = False
        '
        'pbxDigit04
        '
        Me.pbxDigit04.BackColor = System.Drawing.Color.Transparent
        Me.pbxDigit04.InitialImage = Nothing
        Me.pbxDigit04.Location = New System.Drawing.Point(350, 30)
        Me.pbxDigit04.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxDigit04.Name = "pbxDigit04"
        Me.pbxDigit04.Size = New System.Drawing.Size(50, 50)
        Me.pbxDigit04.TabIndex = 6
        Me.pbxDigit04.TabStop = False
        '
        'pbxDigit05
        '
        Me.pbxDigit05.BackColor = System.Drawing.Color.Transparent
        Me.pbxDigit05.InitialImage = Nothing
        Me.pbxDigit05.Location = New System.Drawing.Point(400, 30)
        Me.pbxDigit05.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxDigit05.Name = "pbxDigit05"
        Me.pbxDigit05.Size = New System.Drawing.Size(50, 50)
        Me.pbxDigit05.TabIndex = 7
        Me.pbxDigit05.TabStop = False
        '
        'pnlStudentNumbers
        '
        Me.pnlStudentNumbers.BackColor = System.Drawing.Color.Transparent
        Me.pnlStudentNumbers.Controls.Add(Me.pbxYearString)
        Me.pnlStudentNumbers.Controls.Add(Me.pbxDigit05)
        Me.pnlStudentNumbers.Controls.Add(Me.pbxDigit01)
        Me.pnlStudentNumbers.Controls.Add(Me.pbxDigit04)
        Me.pnlStudentNumbers.Controls.Add(Me.pbxDigit02)
        Me.pnlStudentNumbers.Controls.Add(Me.pbxDigit03)
        Me.pnlStudentNumbers.Location = New System.Drawing.Point(246, 265)
        Me.pnlStudentNumbers.Name = "pnlStudentNumbers"
        Me.pnlStudentNumbers.Size = New System.Drawing.Size(450, 108)
        Me.pnlStudentNumbers.TabIndex = 8
        '
        'rouletteTimer
        '
        Me.rouletteTimer.Interval = 1000
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Randomizer.My.Resources.Resources.raffles_background_rev2
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.pnlStudentNumbers)
        Me.Controls.Add(Me.pnlControls)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Raffles"
        Me.pnlControls.ResumeLayout(False)
        CType(Me.pbxYearString, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDigit01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDigit02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDigit03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDigit04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDigit05, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStudentNumbers.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlControls As Panel
    Friend WithEvents btnDraw As Button
    Friend WithEvents pbxYearString As PictureBox
    Friend WithEvents pbxDigit01 As PictureBox
    Friend WithEvents pbxDigit02 As PictureBox
    Friend WithEvents pbxDigit03 As PictureBox
    Friend WithEvents pbxDigit04 As PictureBox
    Friend WithEvents pbxDigit05 As PictureBox
    Friend WithEvents pnlStudentNumbers As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDBConnMarker As Label
    Friend WithEvents rouletteTimer As Timer
End Class
