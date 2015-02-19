<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFeedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFeedback))
        Me.tlsMenu = New System.Windows.Forms.ToolStrip
        Me.btnBack = New System.Windows.Forms.ToolStripButton
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ssMain = New System.Windows.Forms.StatusStrip
        Me.wbMain = New System.Windows.Forms.WebBrowser
        Me.tlsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlsMenu
        '
        Me.tlsMenu.BackgroundImage = Global.RoPaSi.My.Resources.Resources.resDarkBkg
        Me.tlsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tlsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnRefresh})
        Me.tlsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlsMenu.Name = "tlsMenu"
        Me.tlsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tlsMenu.Size = New System.Drawing.Size(650, 25)
        Me.tlsMenu.TabIndex = 0
        Me.tlsMenu.Text = "tlsMenu"
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(36, 22)
        Me.btnBack.Text = "Back"
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(50, 22)
        Me.btnRefresh.Text = "Refresh"
        '
        'ssMain
        '
        Me.ssMain.BackgroundImage = Global.RoPaSi.My.Resources.Resources.resDarkBkg
        Me.ssMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ssMain.Location = New System.Drawing.Point(0, 535)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(650, 22)
        Me.ssMain.TabIndex = 1
        '
        'wbMain
        '
        Me.wbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbMain.Location = New System.Drawing.Point(0, 25)
        Me.wbMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbMain.Name = "wbMain"
        Me.wbMain.Size = New System.Drawing.Size(650, 510)
        Me.wbMain.TabIndex = 2
        Me.wbMain.Url = New System.Uri("", System.UriKind.Relative)
        '
        'frmFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 557)
        Me.Controls.Add(Me.wbMain)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.tlsMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFeedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Feedback and Bug Reporter"
        Me.tlsMenu.ResumeLayout(False)
        Me.tlsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents ssMain As System.Windows.Forms.StatusStrip
    Friend WithEvents wbMain As System.Windows.Forms.WebBrowser
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBack As System.Windows.Forms.ToolStripButton
End Class
