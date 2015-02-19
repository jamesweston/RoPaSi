<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.btnHelpTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSystemCheck = New System.Windows.Forms.Button
        Me.btnOnlineHelp = New System.Windows.Forms.Button
        Me.btnInternet = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.btnBugReporter = New System.Windows.Forms.Button
        Me.btnStepbystep = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHelpTip
        '
        Me.btnHelpTip.AutomaticDelay = 400
        Me.btnHelpTip.IsBalloon = True
        Me.btnHelpTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.btnHelpTip.ToolTipTitle = "About Help"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.RoPaSi.My.Resources.Resources.resDarkBkg
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.btnSystemCheck)
        Me.Panel1.Controls.Add(Me.btnOnlineHelp)
        Me.Panel1.Controls.Add(Me.btnInternet)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnBugReporter)
        Me.Panel1.Controls.Add(Me.btnStepbystep)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 412)
        Me.Panel1.TabIndex = 2
        '
        'btnSystemCheck
        '
        Me.btnSystemCheck.Enabled = False
        Me.btnSystemCheck.Image = Global.RoPaSi.My.Resources.Resources.resError
        Me.btnSystemCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSystemCheck.Location = New System.Drawing.Point(74, 360)
        Me.btnSystemCheck.Name = "btnSystemCheck"
        Me.btnSystemCheck.Size = New System.Drawing.Size(155, 43)
        Me.btnSystemCheck.TabIndex = 14
        Me.btnSystemCheck.Text = "System Check"
        Me.btnSystemCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSystemCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSystemCheck.UseVisualStyleBackColor = True
        '
        'btnOnlineHelp
        '
        Me.btnOnlineHelp.Enabled = False
        Me.btnOnlineHelp.Image = Global.RoPaSi.My.Resources.Resources.resOnline
        Me.btnOnlineHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOnlineHelp.Location = New System.Drawing.Point(233, 360)
        Me.btnOnlineHelp.Name = "btnOnlineHelp"
        Me.btnOnlineHelp.Size = New System.Drawing.Size(155, 43)
        Me.btnOnlineHelp.TabIndex = 13
        Me.btnOnlineHelp.Text = "Online Help"
        Me.btnOnlineHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOnlineHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOnlineHelp.UseVisualStyleBackColor = True
        '
        'btnInternet
        '
        Me.btnInternet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInternet.Image = Global.RoPaSi.My.Resources.Resources.resNetwork
        Me.btnInternet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInternet.Location = New System.Drawing.Point(74, 280)
        Me.btnInternet.Name = "btnInternet"
        Me.btnInternet.Size = New System.Drawing.Size(314, 74)
        Me.btnInternet.TabIndex = 12
        Me.btnInternet.Text = "&Internet Connection Check"
        Me.btnInternet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInternet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInternet.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = Global.RoPaSi.My.Resources.Resources.resUpdate
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(74, 200)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(314, 74)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "&Check for Updates"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.RoPaSi.My.Resources.Resources.Background_Off_White
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Location = New System.Drawing.Point(-1, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(64, 388)
        Me.Panel2.TabIndex = 10
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.RoPaSi.My.Resources.Resources.helpboxm
        Me.PictureBox4.Location = New System.Drawing.Point(0, -27)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(62, 67)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'btnBugReporter
        '
        Me.btnBugReporter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBugReporter.Image = Global.RoPaSi.My.Resources.Resources.resBug
        Me.btnBugReporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBugReporter.Location = New System.Drawing.Point(74, 120)
        Me.btnBugReporter.Name = "btnBugReporter"
        Me.btnBugReporter.Size = New System.Drawing.Size(314, 74)
        Me.btnBugReporter.TabIndex = 7
        Me.btnBugReporter.Text = "&Bug Reporter"
        Me.btnBugReporter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBugReporter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBugReporter.UseVisualStyleBackColor = True
        '
        'btnStepbystep
        '
        Me.btnStepbystep.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStepbystep.Image = Global.RoPaSi.My.Resources.Resources.resTutorial
        Me.btnStepbystep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStepbystep.Location = New System.Drawing.Point(74, 40)
        Me.btnStepbystep.Name = "btnStepbystep"
        Me.btnStepbystep.Size = New System.Drawing.Size(314, 74)
        Me.btnStepbystep.TabIndex = 6
        Me.btnStepbystep.Text = "&Step by Step Guide"
        Me.btnStepbystep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStepbystep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStepbystep.UseVisualStyleBackColor = True
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
        Me.btnHelpTip.SetToolTip(Me.PictureBox2, "Clicking this icon on any part of the application " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will open the relevent help i" & _
                "nformation.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "RoPaSi Help Center"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.RoPaSi.My.Resources.Resources.helpboxm
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 412)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(20, 20)
        Me.MaximizeBox = False
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "RoPaSi - Help"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBugReporter As System.Windows.Forms.Button
    Friend WithEvents btnStepbystep As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInternet As System.Windows.Forms.Button
    Friend WithEvents btnHelpTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnOnlineHelp As System.Windows.Forms.Button
    Friend WithEvents btnSystemCheck As System.Windows.Forms.Button
End Class
