Public Class frmHelp

    Private Sub clBugReporter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBugReporter.Click
        frmFeedback.Show()
    End Sub

    Private Sub btnStepbystep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStepbystep.Click
        frmHelp_Video.Show()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        frmUpdate.ShowDialog()
    End Sub

    Private Sub btnInternet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInternet.Click
        frmNetCheck.ShowDialog()
    End Sub
End Class