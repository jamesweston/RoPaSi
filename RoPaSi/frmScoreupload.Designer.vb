<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScoreupload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScoreupload))
        Me.tbPlayer = New System.Windows.Forms.TextBox
        Me.tbComputer = New System.Windows.Forms.TextBox
        Me.tbDraw = New System.Windows.Forms.TextBox
        Me.txtPlayer = New System.Windows.Forms.Label
        Me.txtComputer = New System.Windows.Forms.Label
        Me.txtDraw = New System.Windows.Forms.Label
        Me.tbName = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.Label
        Me.btnScore = New System.Windows.Forms.Button
        Me.wbSubmit = New System.Windows.Forms.WebBrowser
        Me.pnLoad = New System.Windows.Forms.Panel
        Me.imgGaming = New System.Windows.Forms.PictureBox
        Me.imgLoad = New System.Windows.Forms.PictureBox
        Me.txtLoad = New System.Windows.Forms.Label
        Me.btnViewScores = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.pnLoad.SuspendLayout()
        CType(Me.imgGaming, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbPlayer
        '
        Me.tbPlayer.Location = New System.Drawing.Point(67, 42)
        Me.tbPlayer.Name = "tbPlayer"
        Me.tbPlayer.ReadOnly = True
        Me.tbPlayer.Size = New System.Drawing.Size(220, 20)
        Me.tbPlayer.TabIndex = 0
        Me.tbPlayer.TabStop = False
        '
        'tbComputer
        '
        Me.tbComputer.Location = New System.Drawing.Point(67, 69)
        Me.tbComputer.Name = "tbComputer"
        Me.tbComputer.ReadOnly = True
        Me.tbComputer.Size = New System.Drawing.Size(220, 20)
        Me.tbComputer.TabIndex = 1
        Me.tbComputer.TabStop = False
        '
        'tbDraw
        '
        Me.tbDraw.Location = New System.Drawing.Point(67, 96)
        Me.tbDraw.Name = "tbDraw"
        Me.tbDraw.ReadOnly = True
        Me.tbDraw.Size = New System.Drawing.Size(220, 20)
        Me.tbDraw.TabIndex = 2
        Me.tbDraw.TabStop = False
        '
        'txtPlayer
        '
        Me.txtPlayer.AutoSize = True
        Me.txtPlayer.BackColor = System.Drawing.Color.Transparent
        Me.txtPlayer.ForeColor = System.Drawing.Color.White
        Me.txtPlayer.Location = New System.Drawing.Point(28, 45)
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.Size = New System.Drawing.Size(36, 13)
        Me.txtPlayer.TabIndex = 3
        Me.txtPlayer.Text = "Player"
        '
        'txtComputer
        '
        Me.txtComputer.AutoSize = True
        Me.txtComputer.BackColor = System.Drawing.Color.Transparent
        Me.txtComputer.ForeColor = System.Drawing.Color.White
        Me.txtComputer.Location = New System.Drawing.Point(12, 72)
        Me.txtComputer.Name = "txtComputer"
        Me.txtComputer.Size = New System.Drawing.Size(52, 13)
        Me.txtComputer.TabIndex = 4
        Me.txtComputer.Text = "Computer"
        '
        'txtDraw
        '
        Me.txtDraw.AutoSize = True
        Me.txtDraw.BackColor = System.Drawing.Color.Transparent
        Me.txtDraw.ForeColor = System.Drawing.Color.White
        Me.txtDraw.Location = New System.Drawing.Point(28, 99)
        Me.txtDraw.Name = "txtDraw"
        Me.txtDraw.Size = New System.Drawing.Size(32, 13)
        Me.txtDraw.TabIndex = 5
        Me.txtDraw.Text = "Draw"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(67, 16)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(220, 20)
        Me.tbName.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.BackColor = System.Drawing.Color.Transparent
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(29, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(35, 13)
        Me.txtName.TabIndex = 7
        Me.txtName.Text = "Name"
        '
        'btnScore
        '
        Me.btnScore.Location = New System.Drawing.Point(122, 124)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(109, 23)
        Me.btnScore.TabIndex = 2
        Me.btnScore.Text = "Submit Score"
        Me.btnScore.UseVisualStyleBackColor = True
        '
        'wbSubmit
        '
        Me.wbSubmit.AllowWebBrowserDrop = False
        Me.wbSubmit.IsWebBrowserContextMenuEnabled = False
        Me.wbSubmit.Location = New System.Drawing.Point(15, 153)
        Me.wbSubmit.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbSubmit.Name = "wbSubmit"
        Me.wbSubmit.ScrollBarsEnabled = False
        Me.wbSubmit.Size = New System.Drawing.Size(42, 20)
        Me.wbSubmit.TabIndex = 9
        Me.wbSubmit.TabStop = False
        Me.wbSubmit.Visible = False
        Me.wbSubmit.WebBrowserShortcutsEnabled = False
        '
        'pnLoad
        '
        Me.pnLoad.BackColor = System.Drawing.Color.Gainsboro
        Me.pnLoad.BackgroundImage = Global.RoPaSi.My.Resources.Resources.resLightBkg
        Me.pnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnLoad.Controls.Add(Me.imgGaming)
        Me.pnLoad.Controls.Add(Me.imgLoad)
        Me.pnLoad.Controls.Add(Me.txtLoad)
        Me.pnLoad.Location = New System.Drawing.Point(8, 5)
        Me.pnLoad.Name = "pnLoad"
        Me.pnLoad.Size = New System.Drawing.Size(281, 142)
        Me.pnLoad.TabIndex = 10
        Me.pnLoad.Visible = False
        '
        'imgGaming
        '
        Me.imgGaming.BackColor = System.Drawing.Color.Transparent
        Me.imgGaming.Image = Global.RoPaSi.My.Resources.Resources.resMywnGaming
        Me.imgGaming.Location = New System.Drawing.Point(77, 3)
        Me.imgGaming.Name = "imgGaming"
        Me.imgGaming.Size = New System.Drawing.Size(130, 41)
        Me.imgGaming.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgGaming.TabIndex = 2
        Me.imgGaming.TabStop = False
        '
        'imgLoad
        '
        Me.imgLoad.BackColor = System.Drawing.Color.Transparent
        Me.imgLoad.Image = Global.RoPaSi.My.Resources.Resources.resLoader
        Me.imgLoad.Location = New System.Drawing.Point(32, 60)
        Me.imgLoad.Name = "imgLoad"
        Me.imgLoad.Size = New System.Drawing.Size(220, 19)
        Me.imgLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgLoad.TabIndex = 0
        Me.imgLoad.TabStop = False
        Me.imgLoad.Visible = False
        '
        'txtLoad
        '
        Me.txtLoad.AutoSize = True
        Me.txtLoad.BackColor = System.Drawing.Color.Transparent
        Me.txtLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLoad.Location = New System.Drawing.Point(57, 86)
        Me.txtLoad.Name = "txtLoad"
        Me.txtLoad.Size = New System.Drawing.Size(173, 31)
        Me.txtLoad.TabIndex = 1
        Me.txtLoad.Text = "Processing..."
        Me.txtLoad.Visible = False
        '
        'btnViewScores
        '
        Me.btnViewScores.Location = New System.Drawing.Point(15, 124)
        Me.btnViewScores.Name = "btnViewScores"
        Me.btnViewScores.Size = New System.Drawing.Size(101, 23)
        Me.btnViewScores.TabIndex = 11
        Me.btnViewScores.Text = "View Scores"
        Me.btnViewScores.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(237, 124)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(52, 23)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmScoreupload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RoPaSi.My.Resources.Resources.resDarkBkg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(298, 152)
        Me.Controls.Add(Me.pnLoad)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.wbSubmit)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.txtDraw)
        Me.Controls.Add(Me.txtComputer)
        Me.Controls.Add(Me.txtPlayer)
        Me.Controls.Add(Me.tbDraw)
        Me.Controls.Add(Me.tbComputer)
        Me.Controls.Add(Me.tbPlayer)
        Me.Controls.Add(Me.btnViewScores)
        Me.Controls.Add(Me.btnClose)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScoreupload"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Score Uploader - RoPaSi"
        Me.pnLoad.ResumeLayout(False)
        Me.pnLoad.PerformLayout()
        CType(Me.imgGaming, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbPlayer As System.Windows.Forms.TextBox
    Friend WithEvents tbComputer As System.Windows.Forms.TextBox
    Friend WithEvents tbDraw As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer As System.Windows.Forms.Label
    Friend WithEvents txtComputer As System.Windows.Forms.Label
    Friend WithEvents txtDraw As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents btnScore As System.Windows.Forms.Button
    Friend WithEvents wbSubmit As System.Windows.Forms.WebBrowser
    Friend WithEvents pnLoad As System.Windows.Forms.Panel
    Friend WithEvents imgLoad As System.Windows.Forms.PictureBox
    Friend WithEvents txtLoad As System.Windows.Forms.Label
    Friend WithEvents imgGaming As System.Windows.Forms.PictureBox
    Friend WithEvents btnViewScores As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
