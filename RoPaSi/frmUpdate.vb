Public Class frmUpdate
    Private CheckConn As New CheckInternetConnection()
    'Random Declerations to inizi the Class
    Dim RandomClass As New Random()

    Private Sub frmUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Activated
        tbVersion.Text = (My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision)
        If CStr(CheckConn.IsConnected()) = False Then
            tbServerVersion.Text = "Unable to contact server"
        ElseIf CStr(CheckConn.IsConnected()) = True Then
            wbUpd.Navigate("http://mywn.co.uk/gaming/ropasi/update/?id=" & RandomClass.Next(1000000, 999999999))
        End If
        If My.Settings.AutoUpdate = False Then
            cbAutoUpdate.Checked = False
            txtStatus.Text = "Disabled"
            txtStatus.ForeColor = Color.Red
        ElseIf My.Settings.AutoUpdate = True Then
            cbAutoUpdate.Checked = True
            txtStatus.Text = "Enabled"
            txtStatus.ForeColor = Color.Green
        End If
    End Sub

    Private Sub wbUpd_Navigated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles wbUpd.Navigated
        tbServerVersion.Text = wbUpd.DocumentText
        If tbVersion.Text = tbServerVersion.Text Then
            txtVersion.Text = "You have the latest version"
        ElseIf tbVersion.Text < tbServerVersion.Text Then
            txtVersion.Visible = False
            txtDownload.Text = "Download " & wbUpd.DocumentText
        ElseIf tbVersion.Text > tbServerVersion.Text Then
            txtVersion.Text = "You have a BETA version"
        End If
    End Sub

    Private Sub wbUpd_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles wbUpd.Navigating
        tbServerVersion.Text = "Checking server..."
    End Sub

    Private Sub lblDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDownload.Click
        wbUpd.Navigate("http://mywn.co.uk/gaming/ropasi/update/download.zip")
    End Sub

    Private Sub cbAutoUpdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAutoUpdate.CheckedChanged
        If cbAutoUpdate.Checked = False Then
            My.Settings.Reload()
            My.Settings.AutoUpdate = False
            txtStatus.Text = "Disabled"
            txtStatus.ForeColor = Color.Red
            My.Settings.Save()
        ElseIf cbAutoUpdate.Checked = True Then
            My.Settings.Reload()
            My.Settings.AutoUpdate = True
            txtStatus.Text = "Enabled"
            txtStatus.ForeColor = Color.Green
            My.Settings.Save()
        End If
    End Sub
End Class