Public Class frmFeedback
    Private CheckConn As New CheckInternetConnection()

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        wbMain.Refresh()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        wbMain.GoBack()
    End Sub

    Private Sub frmFeedback_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CStr(CheckConn.IsConnected()) = False Then
            MessageBox.Show("Unable to detect an internet connection the score uploader will not work as expected", "Internet Error - RoPaSI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            wbMain.Navigate("http://" & frmMain.mywnAccess & ":" & frmMain.mywnPass & "@mywn.co.uk/gaming/ropasi/bugreport/")
        End If
    End Sub

    Private Sub btnBack_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.MouseEnter
        If My.Computer.Info.OSVersion < "6" Then
            If frmMain.CurrentTheme() = "WindowsClassic" Then
                btnBack.ForeColor = Color.White
            Else
                btnBack.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub btnBack_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.MouseLeave
        If My.Computer.Info.OSVersion < "6" Then
            btnBack.ForeColor = Color.White
        End If
    End Sub

    Private Sub btnRefresh_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.MouseEnter
        If My.Computer.Info.OSVersion < "6" Then
            If frmMain.CurrentTheme() = "WindowsClassic" Then
                btnRefresh.ForeColor = Color.White
            Else
                btnRefresh.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub btnRefresh_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.MouseLeave
        If My.Computer.Info.OSVersion < "6" Then
            btnRefresh.ForeColor = Color.White
        End If
    End Sub
End Class