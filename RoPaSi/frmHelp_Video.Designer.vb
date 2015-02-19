<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp_Video
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp_Video))
        Me.HelpPlay = New AxWMPLib.AxWindowsMediaPlayer
        CType(Me.HelpPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HelpPlay
        '
        Me.HelpPlay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpPlay.Enabled = True
        Me.HelpPlay.Location = New System.Drawing.Point(0, 0)
        Me.HelpPlay.Name = "HelpPlay"
        Me.HelpPlay.OcxState = CType(resources.GetObject("HelpPlay.OcxState"), System.Windows.Forms.AxHost.State)
        Me.HelpPlay.Size = New System.Drawing.Size(433, 463)
        Me.HelpPlay.TabIndex = 0
        '
        'frmHelp_Video
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 463)
        Me.Controls.Add(Me.HelpPlay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(20, 20)
        Me.Name = "frmHelp_Video"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Set by Step Guide - RoPaSi"
        CType(Me.HelpPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HelpPlay As AxWMPLib.AxWindowsMediaPlayer
End Class
