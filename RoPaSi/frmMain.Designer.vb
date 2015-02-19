<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.gbSelection = New System.Windows.Forms.GroupBox
        Me.ckRandom = New System.Windows.Forms.RadioButton
        Me.ckScissors = New System.Windows.Forms.RadioButton
        Me.ckPaper = New System.Windows.Forms.RadioButton
        Me.btnGo = New System.Windows.Forms.Button
        Me.ckRock = New System.Windows.Forms.RadioButton
        Me.gbArena = New System.Windows.Forms.GroupBox
        Me.imgComputerWin = New System.Windows.Forms.PictureBox
        Me.imgPlayerWin = New System.Windows.Forms.PictureBox
        Me.imgComputer = New System.Windows.Forms.PictureBox
        Me.imgPlayer = New System.Windows.Forms.PictureBox
        Me.txtWinner = New System.Windows.Forms.Label
        Me.ScoreTick = New System.Windows.Forms.Timer(Me.components)
        Me.imgPip1 = New System.Windows.Forms.PictureBox
        Me.imgPip2 = New System.Windows.Forms.PictureBox
        Me.imgPip3 = New System.Windows.Forms.PictureBox
        Me.imgPip4 = New System.Windows.Forms.PictureBox
        Me.imgPipmaster = New System.Windows.Forms.PictureBox
        Me.tsMain = New System.Windows.Forms.ToolStrip
        Me.btnSaveGame = New System.Windows.Forms.ToolStripButton
        Me.btnLoadgame = New System.Windows.Forms.ToolStripButton
        Me.btnAbout = New System.Windows.Forms.ToolStripButton
        Me.btnHelp = New System.Windows.Forms.ToolStripButton
        Me.tsBottom = New System.Windows.Forms.ToolStrip
        Me.txtScore = New System.Windows.Forms.ToolStripButton
        Me.btnSpeak = New System.Windows.Forms.ToolStripButton
        Me.btnClear = New System.Windows.Forms.ToolStripButton
        Me.wbAutoUpdate = New System.Windows.Forms.WebBrowser
        Me.gbSelection.SuspendLayout()
        Me.gbArena.SuspendLayout()
        CType(Me.imgComputerWin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPlayerWin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPip2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPip3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPip4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPipmaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMain.SuspendLayout()
        Me.tsBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSelection
        '
        Me.gbSelection.BackColor = System.Drawing.Color.Transparent
        Me.gbSelection.Controls.Add(Me.ckRandom)
        Me.gbSelection.Controls.Add(Me.ckScissors)
        Me.gbSelection.Controls.Add(Me.ckPaper)
        Me.gbSelection.Controls.Add(Me.btnGo)
        Me.gbSelection.Controls.Add(Me.ckRock)
        Me.gbSelection.Location = New System.Drawing.Point(8, 30)
        Me.gbSelection.Name = "gbSelection"
        Me.gbSelection.Size = New System.Drawing.Size(152, 107)
        Me.gbSelection.TabIndex = 2
        Me.gbSelection.TabStop = False
        Me.gbSelection.Text = "Selection"
        '
        'ckRandom
        '
        Me.ckRandom.AutoSize = True
        Me.ckRandom.Location = New System.Drawing.Point(75, 82)
        Me.ckRandom.Name = "ckRandom"
        Me.ckRandom.Size = New System.Drawing.Size(65, 17)
        Me.ckRandom.TabIndex = 9
        Me.ckRandom.TabStop = True
        Me.ckRandom.Text = "Random"
        Me.ckRandom.UseVisualStyleBackColor = True
        '
        'ckScissors
        '
        Me.ckScissors.AutoSize = True
        Me.ckScissors.Location = New System.Drawing.Point(75, 60)
        Me.ckScissors.Name = "ckScissors"
        Me.ckScissors.Size = New System.Drawing.Size(64, 17)
        Me.ckScissors.TabIndex = 8
        Me.ckScissors.TabStop = True
        Me.ckScissors.Text = "Scissors"
        Me.ckScissors.UseVisualStyleBackColor = True
        '
        'ckPaper
        '
        Me.ckPaper.AutoSize = True
        Me.ckPaper.Location = New System.Drawing.Point(75, 37)
        Me.ckPaper.Name = "ckPaper"
        Me.ckPaper.Size = New System.Drawing.Size(53, 17)
        Me.ckPaper.TabIndex = 7
        Me.ckPaper.TabStop = True
        Me.ckPaper.Text = "Paper"
        Me.ckPaper.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGo.Location = New System.Drawing.Point(10, 15)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(54, 85)
        Me.btnGo.TabIndex = 4
        Me.btnGo.Text = "&Go Play!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'ckRock
        '
        Me.ckRock.AutoSize = True
        Me.ckRock.Location = New System.Drawing.Point(75, 14)
        Me.ckRock.Name = "ckRock"
        Me.ckRock.Size = New System.Drawing.Size(51, 17)
        Me.ckRock.TabIndex = 6
        Me.ckRock.TabStop = True
        Me.ckRock.Text = "Rock"
        Me.ckRock.UseVisualStyleBackColor = True
        '
        'gbArena
        '
        Me.gbArena.BackColor = System.Drawing.Color.Transparent
        Me.gbArena.Controls.Add(Me.imgComputerWin)
        Me.gbArena.Controls.Add(Me.imgPlayerWin)
        Me.gbArena.Controls.Add(Me.imgComputer)
        Me.gbArena.Controls.Add(Me.imgPlayer)
        Me.gbArena.Location = New System.Drawing.Point(7, 143)
        Me.gbArena.Name = "gbArena"
        Me.gbArena.Size = New System.Drawing.Size(350, 104)
        Me.gbArena.TabIndex = 3
        Me.gbArena.TabStop = False
        Me.gbArena.Text = "Arena"
        '
        'imgComputerWin
        '
        Me.imgComputerWin.Image = Global.RoPaSi.My.Resources.Resources.resWin
        Me.imgComputerWin.Location = New System.Drawing.Point(204, 80)
        Me.imgComputerWin.Name = "imgComputerWin"
        Me.imgComputerWin.Size = New System.Drawing.Size(16, 16)
        Me.imgComputerWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgComputerWin.TabIndex = 7
        Me.imgComputerWin.TabStop = False
        Me.imgComputerWin.Visible = False
        '
        'imgPlayerWin
        '
        Me.imgPlayerWin.Image = Global.RoPaSi.My.Resources.Resources.resWin
        Me.imgPlayerWin.Location = New System.Drawing.Point(73, 80)
        Me.imgPlayerWin.Name = "imgPlayerWin"
        Me.imgPlayerWin.Size = New System.Drawing.Size(16, 16)
        Me.imgPlayerWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgPlayerWin.TabIndex = 6
        Me.imgPlayerWin.TabStop = False
        Me.imgPlayerWin.Visible = False
        '
        'imgComputer
        '
        Me.imgComputer.BackColor = System.Drawing.Color.Transparent
        Me.imgComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgComputer.Image = Global.RoPaSi.My.Resources.Resources.resWaiting
        Me.imgComputer.Location = New System.Drawing.Point(211, 19)
        Me.imgComputer.Name = "imgComputer"
        Me.imgComputer.Size = New System.Drawing.Size(70, 70)
        Me.imgComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgComputer.TabIndex = 5
        Me.imgComputer.TabStop = False
        '
        'imgPlayer
        '
        Me.imgPlayer.BackColor = System.Drawing.Color.Transparent
        Me.imgPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgPlayer.Image = Global.RoPaSi.My.Resources.Resources.resWaiting
        Me.imgPlayer.Location = New System.Drawing.Point(80, 20)
        Me.imgPlayer.Name = "imgPlayer"
        Me.imgPlayer.Size = New System.Drawing.Size(70, 70)
        Me.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgPlayer.TabIndex = 4
        Me.imgPlayer.TabStop = False
        '
        'txtWinner
        '
        Me.txtWinner.AutoSize = True
        Me.txtWinner.BackColor = System.Drawing.Color.Transparent
        Me.txtWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWinner.Location = New System.Drawing.Point(166, 88)
        Me.txtWinner.Name = "txtWinner"
        Me.txtWinner.Size = New System.Drawing.Size(0, 24)
        Me.txtWinner.TabIndex = 5
        '
        'ScoreTick
        '
        Me.ScoreTick.Enabled = True
        Me.ScoreTick.Interval = 1
        '
        'imgPip1
        '
        Me.imgPip1.BackColor = System.Drawing.Color.Transparent
        Me.imgPip1.Image = Global.RoPaSi.My.Resources.Resources.resPip
        Me.imgPip1.Location = New System.Drawing.Point(175, 40)
        Me.imgPip1.Name = "imgPip1"
        Me.imgPip1.Size = New System.Drawing.Size(25, 26)
        Me.imgPip1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgPip1.TabIndex = 7
        Me.imgPip1.TabStop = False
        Me.imgPip1.Visible = False
        '
        'imgPip2
        '
        Me.imgPip2.BackColor = System.Drawing.Color.Transparent
        Me.imgPip2.Image = Global.RoPaSi.My.Resources.Resources.resPip
        Me.imgPip2.Location = New System.Drawing.Point(206, 40)
        Me.imgPip2.Name = "imgPip2"
        Me.imgPip2.Size = New System.Drawing.Size(25, 26)
        Me.imgPip2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgPip2.TabIndex = 8
        Me.imgPip2.TabStop = False
        Me.imgPip2.Visible = False
        '
        'imgPip3
        '
        Me.imgPip3.BackColor = System.Drawing.Color.Transparent
        Me.imgPip3.Image = Global.RoPaSi.My.Resources.Resources.resPip
        Me.imgPip3.Location = New System.Drawing.Point(235, 40)
        Me.imgPip3.Name = "imgPip3"
        Me.imgPip3.Size = New System.Drawing.Size(25, 26)
        Me.imgPip3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgPip3.TabIndex = 9
        Me.imgPip3.TabStop = False
        Me.imgPip3.Visible = False
        '
        'imgPip4
        '
        Me.imgPip4.BackColor = System.Drawing.Color.Transparent
        Me.imgPip4.Image = Global.RoPaSi.My.Resources.Resources.resPip
        Me.imgPip4.Location = New System.Drawing.Point(264, 40)
        Me.imgPip4.Name = "imgPip4"
        Me.imgPip4.Size = New System.Drawing.Size(25, 26)
        Me.imgPip4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgPip4.TabIndex = 10
        Me.imgPip4.TabStop = False
        Me.imgPip4.Visible = False
        '
        'imgPipmaster
        '
        Me.imgPipmaster.BackColor = System.Drawing.Color.Transparent
        Me.imgPipmaster.Image = CType(resources.GetObject("imgPipmaster.Image"), System.Drawing.Image)
        Me.imgPipmaster.Location = New System.Drawing.Point(166, 34)
        Me.imgPipmaster.Name = "imgPipmaster"
        Me.imgPipmaster.Size = New System.Drawing.Size(130, 41)
        Me.imgPipmaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgPipmaster.TabIndex = 11
        Me.imgPipmaster.TabStop = False
        Me.imgPipmaster.Visible = False
        '
        'tsMain
        '
        Me.tsMain.BackColor = System.Drawing.Color.Black
        Me.tsMain.BackgroundImage = Global.RoPaSi.My.Resources.Resources.resDarkBkg
        Me.tsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSaveGame, Me.btnLoadgame, Me.btnAbout, Me.btnHelp})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.tsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsMain.Size = New System.Drawing.Size(363, 25)
        Me.tsMain.TabIndex = 12
        '
        'btnSaveGame
        '
        Me.btnSaveGame.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSaveGame.ForeColor = System.Drawing.Color.White
        Me.btnSaveGame.Name = "btnSaveGame"
        Me.btnSaveGame.Size = New System.Drawing.Size(65, 21)
        Me.btnSaveGame.Text = "&Save Game"
        '
        'btnLoadgame
        '
        Me.btnLoadgame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnLoadgame.ForeColor = System.Drawing.Color.White
        Me.btnLoadgame.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLoadgame.Name = "btnLoadgame"
        Me.btnLoadgame.Size = New System.Drawing.Size(64, 21)
        Me.btnLoadgame.Text = "&Load Game"
        '
        'btnAbout
        '
        Me.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(40, 21)
        Me.btnAbout.Text = "&About"
        Me.btnAbout.ToolTipText = "Shows About Box"
        '
        'btnHelp
        '
        Me.btnHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHelp.Image = Global.RoPaSi.My.Resources.Resources.resHelp2
        Me.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(23, 21)
        Me.btnHelp.Text = "&Help"
        '
        'tsBottom
        '
        Me.tsBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tsBottom.AutoSize = False
        Me.tsBottom.BackColor = System.Drawing.Color.Black
        Me.tsBottom.BackgroundImage = Global.RoPaSi.My.Resources.Resources.resDarkBkg
        Me.tsBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsBottom.Dock = System.Windows.Forms.DockStyle.None
        Me.tsBottom.GripMargin = New System.Windows.Forms.Padding(0)
        Me.tsBottom.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsBottom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtScore, Me.btnSpeak, Me.btnClear})
        Me.tsBottom.Location = New System.Drawing.Point(0, 252)
        Me.tsBottom.Name = "tsBottom"
        Me.tsBottom.Padding = New System.Windows.Forms.Padding(0)
        Me.tsBottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsBottom.Size = New System.Drawing.Size(363, 26)
        Me.tsBottom.TabIndex = 13
        '
        'txtScore
        '
        Me.txtScore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.txtScore.ForeColor = System.Drawing.Color.White
        Me.txtScore.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(23, 23)
        Me.txtScore.ToolTipText = "Click to submit score"
        '
        'btnSpeak
        '
        Me.btnSpeak.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSpeak.Image = Global.RoPaSi.My.Resources.Resources.resBulb
        Me.btnSpeak.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSpeak.Name = "btnSpeak"
        Me.btnSpeak.Size = New System.Drawing.Size(23, 23)
        Me.btnSpeak.ToolTipText = "Speaks the score"
        '
        'btnClear
        '
        Me.btnClear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(36, 23)
        Me.btnClear.Text = "&Clear"
        Me.btnClear.ToolTipText = "Clear the score"
        '
        'wbAutoUpdate
        '
        Me.wbAutoUpdate.AllowNavigation = False
        Me.wbAutoUpdate.AllowWebBrowserDrop = False
        Me.wbAutoUpdate.IsWebBrowserContextMenuEnabled = False
        Me.wbAutoUpdate.Location = New System.Drawing.Point(337, 28)
        Me.wbAutoUpdate.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbAutoUpdate.Name = "wbAutoUpdate"
        Me.wbAutoUpdate.ScriptErrorsSuppressed = True
        Me.wbAutoUpdate.ScrollBarsEnabled = False
        Me.wbAutoUpdate.Size = New System.Drawing.Size(20, 20)
        Me.wbAutoUpdate.TabIndex = 14
        Me.wbAutoUpdate.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RoPaSi.My.Resources.Resources.resLightBkg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(363, 276)
        Me.Controls.Add(Me.wbAutoUpdate)
        Me.Controls.Add(Me.tsBottom)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.imgPipmaster)
        Me.Controls.Add(Me.txtWinner)
        Me.Controls.Add(Me.gbArena)
        Me.Controls.Add(Me.gbSelection)
        Me.Controls.Add(Me.imgPip4)
        Me.Controls.Add(Me.imgPip3)
        Me.Controls.Add(Me.imgPip2)
        Me.Controls.Add(Me.imgPip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RoPaSi - The Game of Gods and Alex Kidd"
        Me.gbSelection.ResumeLayout(False)
        Me.gbSelection.PerformLayout()
        Me.gbArena.ResumeLayout(False)
        Me.gbArena.PerformLayout()
        CType(Me.imgComputerWin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPlayerWin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPip2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPip3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPip4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPipmaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.tsBottom.ResumeLayout(False)
        Me.tsBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbSelection As System.Windows.Forms.GroupBox
    Friend WithEvents gbArena As System.Windows.Forms.GroupBox
    Friend WithEvents imgComputer As System.Windows.Forms.PictureBox
    Friend WithEvents imgPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents ckRock As System.Windows.Forms.RadioButton
    Friend WithEvents ckScissors As System.Windows.Forms.RadioButton
    Friend WithEvents ckPaper As System.Windows.Forms.RadioButton
    Friend WithEvents txtWinner As System.Windows.Forms.Label
    Friend WithEvents imgComputerWin As System.Windows.Forms.PictureBox
    Friend WithEvents imgPlayerWin As System.Windows.Forms.PictureBox
    Friend WithEvents ScoreTick As System.Windows.Forms.Timer
    Friend WithEvents ckRandom As System.Windows.Forms.RadioButton
    Friend WithEvents imgPip1 As System.Windows.Forms.PictureBox
    Friend WithEvents imgPip2 As System.Windows.Forms.PictureBox
    Friend WithEvents imgPip3 As System.Windows.Forms.PictureBox
    Friend WithEvents imgPip4 As System.Windows.Forms.PictureBox
    Friend WithEvents imgPipmaster As System.Windows.Forms.PictureBox
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSaveGame As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLoadgame As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBottom As System.Windows.Forms.ToolStrip
    Friend WithEvents txtScore As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSpeak As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents wbAutoUpdate As System.Windows.Forms.WebBrowser

End Class
