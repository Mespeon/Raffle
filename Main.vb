Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Maya.connect()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        btnDraw.Enabled = False
        Maya.generateRandomRow()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        pbxDigit01.Image = My.Resources._0
        pbxDigit02.Image = My.Resources._0
        pbxDigit03.Image = My.Resources._0
        pbxDigit04.Image = My.Resources._0
        pbxDigit05.Image = My.Resources._0
        pbxYearString.Image = My.Resources._0000
        pbxSlotMachine.Image = My.Resources.slot_machine
        pbxSlotMachine.Visible = False
        pbxCongrats.Visible = False
        rouletteTimer.Enabled = False
        lblTimerDisplay.Text = 0
        btnDraw.Enabled = True
        btnReset.Enabled = False
    End Sub

    Private Sub rouletteTimer_Tick(sender As Object, e As EventArgs) Handles rouletteTimer.Tick
        lblTimerDisplay.Text += 1
        Maya.effectors()
    End Sub
End Class
