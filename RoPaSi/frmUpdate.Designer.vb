<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdate))
        Me.pnMain = New System.Windows.Forms.Panel
        Me.gbUpdate = New System.Windows.Forms.GroupBox
        Me.txtVersion = New System.Windows.Forms.Label
        Me.txtDownload = New System.Windows.Forms.LinkLabel
        Me.wbUpd = New System.Windows.Forms.WebBrowser
        Me.gbServerVersion = New System.Windows.Forms.GroupBox
        Me.tbServerVersion = New System.Windows.Forms.TextBox
        Me.gbSoftwareVersion = New System.Windows.Forms.GroupBox
        Me.tbVersion = New System.Windows.Forms.TextBox
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.txtTitle = New System.Windows.Forms.Label
        Me.gbOptions = New System.Windows.Forms.GroupBox
        Me.cbAutoUpdate = New System.Windows.Forms.CheckBox
        Me.txtStatus = New System.Windows.Forms.Label
        Me.pnMain.SuspendLayout()
        Me.gbUpdate.SuspendLayout()
        Me.gbServerVersion.SuspendLayout()
        Me.gbSoftwareVersion.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnMain
        '
        Me.pnMain.BackgroundImage = Global.RoPaSi.My.Resources.Resources.resDarkBkg
        Me.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnMain.Controls.Add(Me.gbOptions)
        Me.pnMain.Controls.Add(Me.gbUpdate)
        Me.pnMain.Controls.Add(Me.wbUpd)
        Me.pnMain.Controls.Add(Me.gbServerVersion)
        Me.pnMain.Controls.Add(Me.gbSoftwareVersion)
        Me.pnMain.Controls.Add(Me.imgLogo)
        Me.pnMain.Controls.Add(Me.txtTitle)
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(0, 0)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(284, 247)
        Me.pnMain.TabIndex = 2
        '
        'gbUpdate
        '
        Me.gbUpdate.Controls.Add(Me.txtVersion)
        Me.gbUpdate.Controls.Add(Me.txtDownload)
        Me.gbUpdate.Location = New System.Drawing.Point(12, 143)
        Me.gbUpdate.Name = "gbUpdate"
        Me.gbUpdate.Size = New System.Drawing.Size(260, 48)
        Me.gbUpdate.TabIndex = 5
        Me.gbUpdate.TabStop = False
        Me.gbUpdate.Text = "Update"
        '
        'txtVersion
        '
        Me.txtVersion.AutoSize = True
        Me.txtVersion.Location = New System.Drawing.Point(6, 21)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(53, 13)
        Me.txtVersion.TabIndex = 0
        Me.txtVersion.Text = "Unknown"
        '
        'txtDownload
        '
        Me.txtDownload.AutoSize = True
        Me.txtDownload.Location = New System.Drawing.Point(6, 21)
        Me.txtDownload.Name = "txtDownload"
        Me.txtDownload.Size = New System.Drawing.Size(55, 13)
        Me.txtDownload.TabIndex = 6
        Me.txtDownload.TabStop = True
        Me.txtDownload.Text = "Download"
        '
        'wbUpd
        '
        Me.wbUpd.AllowWebBrowserDrop = False
        Me.wbUpd.IsWebBrowserContextMenuEnabled = False
        Me.wbUpd.Location = New System.Drawing.Point(12, 245)
        Me.wbUpd.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbUpd.Name = "wbUpd"
        Me.wbUpd.ScrollBarsEnabled = False
        Me.wbUpd.Size = New System.Drawing.Size(259, 20)
        Me.wbUpd.TabIndex = 5
        Me.wbUpd.TabStop = False
        Me.wbUpd.Visible = False
        '
        'gbServerVersion
        '
        Me.gbServerVersion.Controls.Add(Me.tbServerVersion)
        Me.gbServerVersion.Location = New System.Drawing.Point(12, 89)
        Me.gbServerVersion.Name = "gbServerVersion"
        Me.gbServerVersion.Size = New System.Drawing.Size(260, 48)
        Me.gbServerVersion.TabIndex = 4
        Me.gbServerVersion.TabStop = False
        Me.gbServerVersion.Text = "Server Version"
        '
        'tbServerVersion
        '
        Me.tbServerVersion.Location = New System.Drawing.Point(6, 19)
        Me.tbServerVersion.Name = "tbServerVersion"
        Me.tbServerVersion.ReadOnly = True
        Me.tbServerVersion.Size = New System.Drawing.Size(247, 20)
        Me.tbServerVersion.TabIndex = 1
        Me.tbServerVersion.TabStop = False
        '
        'gbSoftwareVersion
        '
        Me.gbSoftwareVersion.Controls.Add(Me.tbVersion)
        Me.gbSoftwareVersion.Location = New System.Drawing.Point(12, 35)
        Me.gbSoftwareVersion.Name = "gbSoftwareVersion"
        Me.gbSoftwareVersion.Size = New System.Drawing.Size(260, 48)
        Me.gbSoftwareVersion.TabIndex = 3
        Me.gbSoftwareVersion.TabStop = False
        Me.gbSoftwareVersion.Text = "Software Version"
        '
        'tbVersion
        '
        Me.tbVersion.Location = New System.Drawing.Point(7, 19)
        Me.tbVersion.Name = "tbVersion"
        Me.tbVersion.ReadOnly = True
        Me.tbVersion.Size = New System.Drawing.Size(247, 20)
        Me.tbVersion.TabIndex = 0
        Me.tbVersion.TabStop = False
        '
        'imgLogo
        '
        Me.imgLogo.BackColor = System.Drawing.Color.Transparent
        Me.imgLogo.Image = Global.RoPaSi.My.Resources.Resources.resApps
        Me.imgLogo.Location = New System.Drawing.Point(3, -3)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(32, 32)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgLogo.TabIndex = 2
        Me.imgLogo.TabStop = False
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.BackColor = System.Drawing.Color.Transparent
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(35, 7)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(83, 13)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = "MeaUpdate Lite"
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.txtStatus)
        Me.gbOptions.Controls.Add(Me.cbAutoUpdate)
        Me.gbOptions.Location = New System.Drawing.Point(12, 198)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(260, 41)
        Me.gbOptions.TabIndex = 6
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'cbAutoUpdate
        '
        Me.cbAutoUpdate.AutoSize = True
        Me.cbAutoUpdate.Location = New System.Drawing.Point(7, 17)
        Me.cbAutoUpdate.Name = "cbAutoUpdate"
        Me.cbAutoUpdate.Size = New System.Drawing.Size(84, 17)
        Me.cbAutoUpdate.TabIndex = 0
        Me.cbAutoUpdate.Text = "Auto update"
        Me.cbAutoUpdate.UseVisualStyleBackColor = True
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(159, 13)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(100, 23)
        Me.txtStatus.TabIndex = 1
        Me.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 247)
        Me.Controls.Add(Me.pnMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MeaUpdate Lite"
        Me.pnMain.ResumeLayout(False)
        Me.pnMain.PerformLayout()
        Me.gbUpdate.ResumeLayout(False)
        Me.gbUpdate.PerformLayout()
        Me.gbServerVersion.ResumeLayout(False)
        Me.gbServerVersion.PerformLayout()
        Me.gbSoftwareVersion.ResumeLayout(False)
        Me.gbSoftwareVersion.PerformLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents pnMain As System.Windows.Forms.Panel
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents gbServerVersion As System.Windows.Forms.GroupBox
    Friend WithEvents gbSoftwareVersion As System.Windows.Forms.GroupBox
    Friend WithEvents tbVersion As System.Windows.Forms.TextBox
    Friend WithEvents tbServerVersion As System.Windows.Forms.TextBox
    Friend WithEvents wbUpd As System.Windows.Forms.WebBrowser
    Friend WithEvents gbUpdate As System.Windows.Forms.GroupBox
    Friend WithEvents txtVersion As System.Windows.Forms.Label
    Friend WithEvents txtDownload As System.Windows.Forms.LinkLabel
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents cbAutoUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents txtStatus As System.Windows.Forms.Label
End Class
