<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtTag = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnHelpCenter = New System.Windows.Forms.Button
        Me.btnFeedback = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnCredits = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnNetCheck = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.pnSpacer3 = New System.Windows.Forms.Panel
        Me.txtGID = New System.Windows.Forms.Label
        Me.pnSpacer1 = New System.Windows.Forms.Panel
        Me.txtVersion = New System.Windows.Forms.Label
        Me.txtCopyright = New System.Windows.Forms.Label
        Me.pnSpacer2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.RoPaSi.My.Resources.Resources.resDarkBkg
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.txtTag)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnHelpCenter)
        Me.Panel1.Controls.Add(Me.btnFeedback)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btnCredits)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnNetCheck)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.imgLogo)
        Me.Panel1.Controls.Add(Me.pnSpacer3)
        Me.Panel1.Controls.Add(Me.txtGID)
        Me.Panel1.Controls.Add(Me.pnSpacer1)
        Me.Panel1.Controls.Add(Me.txtVersion)
        Me.Panel1.Controls.Add(Me.txtCopyright)
        Me.Panel1.Controls.Add(Me.pnSpacer2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(282, 221)
        Me.Panel1.TabIndex = 205
        '
        'txtTag
        '
        Me.txtTag.AutoSize = True
        Me.txtTag.BackColor = System.Drawing.Color.Transparent
        Me.txtTag.ForeColor = System.Drawing.Color.Black
        Me.txtTag.Location = New System.Drawing.Point(67, 31)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(165, 13)
        Me.txtTag.TabIndex = 3
        Me.txtTag.Text = "The Game of Gods and Alex Kidd"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.RoPaSi.My.Resources.Resources.Background_Off_White
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Location = New System.Drawing.Point(-1, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(64, 193)
        Me.Panel2.TabIndex = 10
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.RoPaSi.My.Resources.Resources.resInfo
        Me.PictureBox4.Location = New System.Drawing.Point(0, -27)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(62, 67)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdate.Location = New System.Drawing.Point(71, 160)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(99, 23)
        Me.btnUpdate.TabIndex = 201
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnHelpCenter
        '
        Me.btnHelpCenter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelpCenter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnHelpCenter.Location = New System.Drawing.Point(174, 133)
        Me.btnHelpCenter.Name = "btnHelpCenter"
        Me.btnHelpCenter.Size = New System.Drawing.Size(97, 23)
        Me.btnHelpCenter.TabIndex = 204
        Me.btnHelpCenter.Text = "Help Center"
        Me.btnHelpCenter.UseVisualStyleBackColor = True
        '
        'btnFeedback
        '
        Me.btnFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFeedback.BackColor = System.Drawing.Color.Transparent
        Me.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFeedback.ForeColor = System.Drawing.Color.Black
        Me.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedback.Location = New System.Drawing.Point(71, 189)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(99, 23)
        Me.btnFeedback.TabIndex = 200
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFeedback.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(174, 189)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 23)
        Me.btnClose.TabIndex = 199
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.RoPaSi.My.Resources.Resources.resHelp2
        Me.PictureBox2.Location = New System.Drawing.Point(374, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'btnCredits
        '
        Me.btnCredits.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCredits.ForeColor = System.Drawing.Color.Black
        Me.btnCredits.Location = New System.Drawing.Point(71, 133)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(99, 23)
        Me.btnCredits.TabIndex = 203
        Me.btnCredits.Text = "Credits"
        Me.btnCredits.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "RoPaSi About"
        '
        'btnNetCheck
        '
        Me.btnNetCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNetCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNetCheck.Location = New System.Drawing.Point(174, 162)
        Me.btnNetCheck.Name = "btnNetCheck"
        Me.btnNetCheck.Size = New System.Drawing.Size(97, 23)
        Me.btnNetCheck.TabIndex = 202
        Me.btnNetCheck.Text = "Internet Check"
        Me.btnNetCheck.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.RoPaSi.My.Resources.Resources.resInfo
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'imgLogo
        '
        Me.imgLogo.BackColor = System.Drawing.Color.Transparent
        Me.imgLogo.Image = Global.RoPaSi.My.Resources.Resources.resCut
        Me.imgLogo.Location = New System.Drawing.Point(239, 31)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(32, 32)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgLogo.TabIndex = 1
        Me.imgLogo.TabStop = False
        '
        'pnSpacer3
        '
        Me.pnSpacer3.BackColor = System.Drawing.Color.Black
        Me.pnSpacer3.ForeColor = System.Drawing.Color.Black
        Me.pnSpacer3.Location = New System.Drawing.Point(70, 124)
        Me.pnSpacer3.Name = "pnSpacer3"
        Me.pnSpacer3.Size = New System.Drawing.Size(200, 1)
        Me.pnSpacer3.TabIndex = 7
        '
        'txtGID
        '
        Me.txtGID.AutoSize = True
        Me.txtGID.BackColor = System.Drawing.Color.Transparent
        Me.txtGID.ForeColor = System.Drawing.Color.Black
        Me.txtGID.Location = New System.Drawing.Point(69, 108)
        Me.txtGID.Name = "txtGID"
        Me.txtGID.Size = New System.Drawing.Size(52, 13)
        Me.txtGID.TabIndex = 7
        Me.txtGID.Text = "Game ID:"
        '
        'pnSpacer1
        '
        Me.pnSpacer1.BackColor = System.Drawing.Color.Black
        Me.pnSpacer1.Location = New System.Drawing.Point(70, 71)
        Me.pnSpacer1.Name = "pnSpacer1"
        Me.pnSpacer1.Size = New System.Drawing.Size(200, 1)
        Me.pnSpacer1.TabIndex = 4
        '
        'txtVersion
        '
        Me.txtVersion.AutoSize = True
        Me.txtVersion.BackColor = System.Drawing.Color.Transparent
        Me.txtVersion.ForeColor = System.Drawing.Color.Black
        Me.txtVersion.Location = New System.Drawing.Point(69, 95)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(78, 13)
        Me.txtVersion.TabIndex = 6
        Me.txtVersion.Text = "Version 2.0.0.0"
        '
        'txtCopyright
        '
        Me.txtCopyright.AutoSize = True
        Me.txtCopyright.BackColor = System.Drawing.Color.Transparent
        Me.txtCopyright.ForeColor = System.Drawing.Color.Black
        Me.txtCopyright.Location = New System.Drawing.Point(69, 75)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.Size = New System.Drawing.Size(177, 13)
        Me.txtCopyright.TabIndex = 5
        Me.txtCopyright.Text = "Copyright 2009 The MeaMod Group"
        '
        'pnSpacer2
        '
        Me.pnSpacer2.BackColor = System.Drawing.Color.Black
        Me.pnSpacer2.Location = New System.Drawing.Point(70, 91)
        Me.pnSpacer2.Name = "pnSpacer2"
        Me.pnSpacer2.Size = New System.Drawing.Size(200, 1)
        Me.pnSpacer2.TabIndex = 5
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(282, 221)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RoPaSi - About"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents txtTag As System.Windows.Forms.Label
    Friend WithEvents pnSpacer1 As System.Windows.Forms.Panel
    Friend WithEvents txtCopyright As System.Windows.Forms.Label
    Friend WithEvents pnSpacer2 As System.Windows.Forms.Panel
    Friend WithEvents txtVersion As System.Windows.Forms.Label
    Friend WithEvents txtGID As System.Windows.Forms.Label
    Friend WithEvents pnSpacer3 As System.Windows.Forms.Panel
    Friend WithEvents btnFeedback As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnNetCheck As System.Windows.Forms.Button
    Friend WithEvents btnCredits As System.Windows.Forms.Button
    Friend WithEvents btnHelpCenter As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
