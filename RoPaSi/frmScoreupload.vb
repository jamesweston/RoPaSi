Public Class frmScoreupload
    Private CheckConn As New CheckInternetConnection()
    Dim sComputer As Integer
    Dim sPlayer As Integer
    Dim sDraw As Integer
    Dim pName As String
    Dim GID As String

    Private Sub scoreupload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CStr(CheckConn.IsConnected()) = False Then
            MessageBox.Show("Unable to detect an internet connection the score uploader will not work as expected", "Internet Error - RoPaSI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        tbPlayer.Text = frmMain.ScorePlayer
        tbComputer.Text = frmMain.ScoreComputer
        tbDraw.Text = frmMain.ScoreDraw
        pnLoad.Visible = False
        imgGaming.Visible = False
        imgLoad.Visible = False
        txtLoad.Visible = False
        My.Settings.Reload()
        tbName.Text = My.Settings.PlayerName
    End Sub

    Private Sub btnScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScore.Click
        If tbName.Text > "" Then
            pName = tbName.Text
            sDraw = frmMain.ScoreDraw
            sPlayer = frmMain.ScorePlayer
            sComputer = frmMain.ScoreComputer
            GID = frmMain.GameID
            My.Settings.PlayerName = tbName.Text
            My.Settings.Save()
            If sPlayer > 0 Or sComputer > 0 Or sDraw > 0 Then
                wbSubmit.Navigate("http://" & frmMain.mywnAccess & ":" & frmMain.mywnPass & "@mywn.co.uk/gaming/ropasi/score?name=" & pName & "&pscore=" & sPlayer & "&cscore=" & sComputer & "&draw=" & sDraw & "&gameid=" & GID)
            Else
                MessageBox.Show("Your must have played to upload a score", "Error - RoPaSi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter you name", "Error - RoPaSi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub wbSubmit_Navigated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles wbSubmit.Navigated
        pnLoad.Visible = False
        imgGaming.Visible = False
        imgLoad.Visible = False
        txtLoad.Visible = False
        If wbSubmit.DocumentText = "Complete" Then
            Dim dlgRes As DialogResult
            'Shows the MessageBox
            dlgRes = MessageBox.Show("You score has been Uploaded", "RoPaSi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            wbSubmit.Navigate("about:blank")
            'Recives the results of the MessageBox and Saves the game data
            If dlgRes = Windows.Forms.DialogResult.OK Then
                Me.Close()
            End If
        ElseIf wbSubmit.DocumentText = "Error" Then
            MessageBox.Show("An error happen trying to upload you score please try again", "RoPaSi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            wbSubmit.Navigate("about:blank")
        End If
    End Sub

    Private Sub wbSubmit_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles wbSubmit.Navigating
        imgLoad.Visible = True
        imgGaming.Visible = True
        pnLoad.Visible = True
        txtLoad.Visible = True
    End Sub

    Private Sub btnViewScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewScores.Click
        System.Diagnostics.Process.Start("http://mywn.co.uk/gaming/ropasi/")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class