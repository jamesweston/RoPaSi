Imports System.Runtime.InteropServices
Imports SpeechLib

Public Class frmMain
    'Random Declarations to inizi the Class
    Dim RandomClass As New Random()

    'Integer Stores Random Number
    Dim RandomNumber As Integer

    'Integer Stores Random Number for Player Random
    Dim RandomPlayer As Integer

    'Integer Holds Player Score
    Public ScorePlayer As Integer

    'Integer Holds Computer Score
    Public ScoreComputer As Integer

    'Integer Holds Draw Scores
    Public ScoreDraw As Integer

    'Integer to check if player is in Random mode
    Dim RandCheck As Boolean

    ''' <summary>
    ''' Holds Paper For AI system
    ''' </summary>
    ''' Part of the AI engine
    Dim AiPaper As Integer

    'Define SAPI Interface
    Dim voice = New SpVoice

    'Pleural detector for speech
    Dim ScorePPL As String
    Dim ScoreCPL As String
    Dim ScoreDPL As String

    'Score Winner
    Dim ScoreWin As String

    'Define Public Game ID Code
    Public GameID As String

    'Used to detect Windows Theme
    Dim Themekey As Microsoft.Win32.RegistryKey

    Dim SystemTD As Long = (My.Computer.Clock.LocalTime.Year & My.Computer.Clock.LocalTime.Month)

    Dim aUpdate As String = (My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision)

    Private CheckConn As New CheckInternetConnection()


    'MyWn Score Access
    Public mywnAccess As String = "9Eo0Hq8TZ2lDYEd5LazsEx7UPQxJBk9helntzwYawkZjxTnu30DN8d3mla2P0bp"
    Public mywnPass As String = "NuPcclnfhX4f0xZY6NZPjAIUB6mB3Ls7aChITzBjEfggG24hloGW5mLxZx6rvzQ"

    'This code it to control the possession of the form
    Public Const GWL_STYLE = (-16)
    Public Const WS_DLGFRAME = &H400000
    Public Const HTCAPTION = 2
    Public Const WM_NCLBUTTONDOWN = &HA1
    Public Const SW_HIDE = 0
    Public Const SW_MAXIMIZE = 3
    Public Const SW_MINIMIZE = 6
    Public Const SW_RESTORE = 9

    <DllImport("User32.dll")> Public Shared Function ShowWindow(ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Integer
    End Function
    <DllImport("User32.dll")> Public Shared Function ReleaseCapture() As Integer
    End Function
    <DllImport("User32.dll")> Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If a new version is deployed, upgrade the settings.
        If My.Settings.CallSettingsUpgrade = True Then
            My.Settings.Upgrade()
            My.Settings.CallSettingsUpgrade = False
            My.Settings.LastUpdate = SystemTD
            My.Settings.Save()
        End If
        My.Settings.Reload()
        If My.Settings.GameID = 0 Then
            My.Settings.GameID = RandomClass.Next(1000000, 999999999)
            My.Settings.Save()
            My.Settings.Reload()
            GameID = My.Settings.GameID
        Else
            GameID = My.Settings.GameID
        End If
        If My.Settings.FirstRun = True Then
            Dim dlgRes As DialogResult
            dlgRes = MessageBox.Show("Would you like to View the How to Play Guide", "Welcome...", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If dlgRes = Windows.Forms.DialogResult.Yes Then
                frmHelp_Video.Show()
            End If
            My.Settings.FirstRun = False
            My.Settings.LastUpdate = SystemTD
            My.Settings.Save()
        End If
        Dim AUfix As Long
        My.Settings.Reload()
        AUfix = My.Settings.LastUpdate + My.Settings.UpdateInterval
        If My.Settings.AutoUpdate = True Then
            If AUfix <= SystemTD Then
                If CStr(CheckConn.IsConnected()) = True Then
                    wbAutoUpdate.Navigate("http://mywn.co.uk/gaming/ropasi/update/?id=" & RandomClass.Next(1000000, 999999999))
                End If
            End If
        End If
    End Sub

    Public Function CurrentTheme() As String
        'Function to get the current Windows XP theme.
        If My.Computer.Info.OSVersion < "6" Then
            Themekey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\ThemeManager")
            If Themekey IsNot Nothing Then
                If Themekey.GetValue("ThemeActive") = "1" Then
                    Dim s As String
                    s = Themekey.GetValue("ColorName")
                    If s <> Nothing Then
                        If String.Compare(s, "NormalColor", True) = 0 Then CurrentTheme = "XPBlue" : Exit Function
                        If String.Compare(s, "HomeStead", True) = 0 Then CurrentTheme = "XPGreen" : Exit Function
                        If String.Compare(s, "Metallic", True) = 0 Then CurrentTheme = "XPSilver" : Exit Function
                    End If
                End If
            End If
            CurrentTheme = "WindowsClassic"
        Else
            CurrentTheme = "NotWindowsXP"
        End If
    End Function

    'Begin Fix for Windows XP themes
    Private Sub btnSaveGame_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveGame.MouseEnter
        If My.Computer.Info.OSVersion < "6" Then
            If CurrentTheme() = "WindowsClassic" Then
                btnSaveGame.ForeColor = Color.White
            Else
                btnSaveGame.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub btnSaveGame_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveGame.MouseLeave
        If My.Computer.Info.OSVersion < "6" Then
            btnSaveGame.ForeColor = Color.White
        End If
    End Sub

    Private Sub btnLoadgame_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadgame.MouseEnter
        If My.Computer.Info.OSVersion < "6" Then
            If CurrentTheme() = "WindowsClassic" Then
                btnLoadgame.ForeColor = Color.White
            Else
                btnLoadgame.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub btnLoadgame_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadgame.MouseLeave
        If My.Computer.Info.OSVersion < "6" Then
            btnLoadgame.ForeColor = Color.White
        End If
    End Sub

    Private Sub btnAbout_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.MouseEnter
        If My.Computer.Info.OSVersion < "6" Then
            If CurrentTheme() = "WindowsClassic" Then
                btnAbout.ForeColor = Color.White
            Else
                btnAbout.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub btnAbout_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.MouseLeave
        If My.Computer.Info.OSVersion < "6" Then
            btnAbout.ForeColor = Color.White
        End If
    End Sub

    Private Sub lblScore_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScore.MouseEnter
        If My.Computer.Info.OSVersion < "6" Then
            If CurrentTheme() = "WindowsClassic" Then
                txtScore.ForeColor = Color.White
            Else
                txtScore.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub lblScore_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScore.MouseLeave
        If My.Computer.Info.OSVersion < "6" Then
            txtScore.ForeColor = Color.White
        End If
    End Sub

    Private Sub btnSpeak_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeak.MouseEnter
        If My.Computer.Info.OSVersion < "6" Then
            If CurrentTheme() = "WindowsClassic" Then
                btnSpeak.ForeColor = Color.White
            Else
                btnSpeak.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub btnSpeak_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeak.MouseLeave
        If My.Computer.Info.OSVersion < "6" Then
            btnSpeak.ForeColor = Color.White
        End If
    End Sub

    Private Sub btnClear_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.MouseEnter
        If My.Computer.Info.OSVersion < "6" Then
            If CurrentTheme() = "WindowsClassic" Then
                btnClear.ForeColor = Color.White
            Else
                btnClear.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub btnClear_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.MouseLeave
        If My.Computer.Info.OSVersion < "6" Then
            btnClear.ForeColor = Color.White
        End If
    End Sub
    'End Fix for Windows XP themes

    Private Sub tsMain_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tsMain.MouseDown
        'This code activates the Form poisson Code
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Cursor = Cursors.SizeAll
            Call ReleaseCapture()
            Call SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        'Check to see if player has checked an option
        If ckPaper.Checked = False And ckRandom.Checked = False And ckRock.Checked = False And ckScissors.Checked = False Then
            'Shows error message
            MessageBox.Show("Please select a option", "RoPaSi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Hides the Gold Medals
            imgComputerWin.Visible = False
            imgPlayerWin.Visible = False

            'Show the pips
            imgPip1.Visible = True

            'Generate the Random Number for Computer
            RandomNumber = RandomClass.Next(1, 4)

            'Check and runs Player random mode
            If ckRandom.Checked Then
                RandomPlayer = RandomClass.Next(1, 4)
                RandCheck = True
                If RandomPlayer = 1 Then
                    ckRock.Checked = True
                ElseIf RandomPlayer = 2 Then
                    ckPaper.Checked = True
                ElseIf RandomPlayer = 3 Then
                    ckScissors.Checked = True
                End If
            End If

            'Shows Hand for RPS Player
            If ckRock.Checked Then
                imgPlayer.Image = My.Resources.resRock
            ElseIf ckPaper.Checked Then
                imgPlayer.Image = My.Resources.resPaper
            ElseIf ckScissors.Checked Then
                imgPlayer.Image = My.Resources.resSiss
            End If

            'Shows Hand for RPS Computer
            If RandomNumber = 1 Then
                imgComputer.Image = My.Resources.resRock
            ElseIf RandomNumber = 2 Then
                imgComputer.Image = My.Resources.resPaper
            ElseIf RandomNumber = 3 Then
                imgComputer.Image = My.Resources.resSiss
            End If

            'Computer AI allows the computer to easily defeat the opponent
            'If ckPaper.Checked Then
            'AiPaper = AiPaper + 1
            'If AiPaper >= 5 Then
            'RandomNumber = 3
            'imgComputer.Image = My.Resources.resSiss
            'AiPaper = 0
            'End If
            'End If

            'Finds the winner
            If ckRock.Checked And RandomNumber = 1 Then
                txtWinner.Text = "It's a Draw"
                ScoreDraw = ScoreDraw + 1
            ElseIf ckRock.Checked And RandomNumber = 2 Then
                txtWinner.Text = "Computer Wins"
                imgComputerWin.Visible = True
                ScoreComputer = ScoreComputer + 1
            ElseIf ckRock.Checked And RandomNumber = 3 Then
                txtWinner.Text = "Player 1 Wins"
                imgPlayerWin.Visible = True
                ScorePlayer = ScorePlayer + 1
            ElseIf ckPaper.Checked And RandomNumber = 1 Then
                txtWinner.Text = "Player 1 Wins"
                imgPlayerWin.Visible = True
                ScorePlayer = ScorePlayer + 1
            ElseIf ckPaper.Checked And RandomNumber = 2 Then
                txtWinner.Text = "It's a Draw"
                ScoreDraw = ScoreDraw + 1
            ElseIf ckPaper.Checked And RandomNumber = 3 Then
                txtWinner.Text = "Computer Wins"
                imgComputerWin.Visible = True
                ScoreComputer = ScoreComputer + 1
            ElseIf ckScissors.Checked And RandomNumber = 1 Then
                txtWinner.Text = "Computer Wins"
                imgComputerWin.Visible = True
                ScoreComputer = ScoreComputer + 1
            ElseIf ckScissors.Checked And RandomNumber = 2 Then
                txtWinner.Text = "Player 1 Wins"
                imgPlayerWin.Visible = True
                ScorePlayer = ScorePlayer + 1
            ElseIf ckScissors.Checked And RandomNumber = 3 Then
                txtWinner.Text = "It's a Draw"
                ScoreDraw = ScoreDraw + 1
            End If

            'Reset Player Random Mode
            If RandCheck = True Then
                ckRandom.Checked = True
                RandCheck = False
            End If
        End If
    End Sub

    Private Sub ScoreTick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScoreTick.Tick
        'Update the score for Status Bar
        txtScore.Text = ("Player: " & ScorePlayer & " | Computer: " & ScoreComputer & " | Draws: " & ScoreDraw)

        'Update the PIP bar
        If ScorePlayer >= 60 Then
            imgPip1.Visible = True
            imgPip2.Visible = True
            imgPip3.Visible = True
            imgPip4.Visible = True
            imgPipmaster.Visible = True
        ElseIf ScorePlayer >= 30 Then
            imgPip1.Visible = True
            imgPip2.Visible = True
            imgPip3.Visible = True
            imgPip4.Visible = True
        ElseIf ScorePlayer >= 20 Then
            imgPip1.Visible = True
            imgPip2.Visible = True
            imgPip3.Visible = True
        ElseIf ScorePlayer >= 10 Then
            imgPip1.Visible = True
            imgPip2.Visible = True
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Resets the Game to all default settings
        ScorePlayer = 0
        ScoreComputer = 0
        ScoreDraw = 0
        imgPlayer.Image = My.Resources.resWaiting
        imgComputer.Image = My.Resources.resWaiting
        txtWinner.Text = ""
        imgComputerWin.Visible = False
        imgPlayerWin.Visible = False
        AiPaper = 0
        If ScorePlayer <= 0 Then
            imgPip1.Visible = False
        End If
        If ScorePlayer <= 10 Then
            imgPip2.Visible = False
        End If
        If ScorePlayer <= 20 Then
            imgPip3.Visible = False
        End If
        If ScorePlayer <= 30 Then
            imgPip4.Visible = False
        End If
        If ScorePlayer <= 60 Then
            imgPipmaster.Visible = False
        End If
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        'Open the About Box
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveGame.Click
        'Declare Variable for Dialog Box results
        Dim dlgRes As DialogResult

        'Shows the MessageBox
        dlgRes = MessageBox.Show("Are you sure you want to save?", "Save Game - RoPaSi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        'Receives the results of the MessageBox and Saves the game data
        If dlgRes = Windows.Forms.DialogResult.Yes Then
            Try
                My.Settings.ScoreComputer = ScoreComputer
                My.Settings.ScoreDraw = ScoreDraw
                My.Settings.ScorePlayer = ScorePlayer
                My.Settings.Save()
                MessageBox.Show("Your game has been successfully saved.", "Save Game - RoPaSi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("There was a problem saving your game.", "Save Game - RoPaSi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadgame.Click
        'Loads the settings
        My.Settings.Reload()
        ScoreComputer = My.Settings.ScoreComputer
        ScoreDraw = My.Settings.ScoreDraw
        ScorePlayer = My.Settings.ScorePlayer
    End Sub

    Private Sub txtScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScore.Click
        'Open Score Upload Dialog
        frmScoreupload.ShowDialog()
    End Sub

    Private Sub btnSpeak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeak.Click
        'Check if the SAPI text needs to be plural
        If ScorePlayer = 1 Then
            ScorePPL = "win"
        Else
            ScorePPL = "wins"
        End If
        If ScoreComputer = 1 Then
            ScoreCPL = "win"
        Else
            ScoreCPL = "wins"
        End If
        If ScoreDraw = 1 Then
            ScoreDPL = "draw"
        Else
            ScoreDPL = "draws"
        End If

        If ScorePlayer > ScoreComputer Then
            ScoreWin = "The Player is currently winning"
        ElseIf ScoreComputer > ScorePlayer Then
            ScoreWin = "The Computer is currently winning"
        ElseIf ScoreComputer = ScorePlayer And ScoreComputer > 0 And ScorePlayer > 0 Then
            ScoreWin = "You are currently at a draw"
        Else
            ScoreWin = "No One is currently winning"
        End If

        'Speak the score
        voice.Speak(ScoreWin & ". And the scores are as following. Player, " & ScorePlayer & ", " & ScorePPL & ". Computer, " & ScoreComputer & ", " & ScoreCPL & ". And " & ScoreDraw & ", " & ScoreDPL & ".", SpeechVoiceSpeakFlags.SVSFlagsAsync)
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        frmHelp.Show()
    End Sub

    Private Sub wbAutoUpdate_Navigated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles wbAutoUpdate.Navigated
        If aUpdate < wbAutoUpdate.DocumentText Then
            My.Settings.LastUpdate = SystemTD
            My.Settings.Save()
            frmUpdate.ShowDialog()
        End If
    End Sub
End Class
