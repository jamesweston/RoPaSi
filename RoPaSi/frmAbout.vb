Public Class frmAbout

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtGID.Text = "Game ID: " & frmMain.GameID
        txtVersion.Text = ("Version " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision)
    End Sub

    Private Sub btnFeedback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeedback.Click
        frmFeedback.Show()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        frmUpdate.ShowDialog()
    End Sub

    Private Sub btnNetCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNetCheck.Click
        frmNetCheck.ShowDialog()
    End Sub

    Private Sub btnCredits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredits.Click
        frmAbout_Credits.ShowDialog()
    End Sub

    Private Sub btnHelpCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelpCenter.Click
        frmHelp.Show()
    End Sub
End Class