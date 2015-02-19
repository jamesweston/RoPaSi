'OgO Open Player
'Developed by The MeaMod Group
'Copyright 2008 The MeaMod Group
'http://meamod.com
'by James Weston
'--------------------------------
Public Class frmNetCheck
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txbDesc As System.Windows.Forms.TextBox
    Public WithEvents txbRAS As System.Windows.Forms.TextBox
    Public WithEvents txbInternet As System.Windows.Forms.TextBox
    Public WithEvents txbProxy As System.Windows.Forms.TextBox
    Public WithEvents txbModem As System.Windows.Forms.TextBox
    Public WithEvents txbLan As System.Windows.Forms.TextBox
    Public WithEvents txtProgress As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents LanConnection As System.Windows.Forms.Label
    Friend WithEvents btnRetest As System.Windows.Forms.Button
    Public WithEvents txbMeaMod As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents pbStatus As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNetCheck))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txbDesc = New System.Windows.Forms.TextBox
        Me.txbRAS = New System.Windows.Forms.TextBox
        Me.txbInternet = New System.Windows.Forms.TextBox
        Me.txbProxy = New System.Windows.Forms.TextBox
        Me.txbModem = New System.Windows.Forms.TextBox
        Me.txbLan = New System.Windows.Forms.TextBox
        Me.txtProgress = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LanConnection = New System.Windows.Forms.Label
        Me.pbStatus = New System.Windows.Forms.ProgressBar
        Me.btnRetest = New System.Windows.Forms.Button
        Me.txbMeaMod = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txbDesc
        '
        Me.txbDesc.AcceptsReturn = True
        Me.txbDesc.BackColor = System.Drawing.SystemColors.Window
        Me.txbDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbDesc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDesc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txbDesc.Location = New System.Drawing.Point(8, 203)
        Me.txbDesc.MaxLength = 0
        Me.txbDesc.Multiline = True
        Me.txbDesc.Name = "txbDesc"
        Me.txbDesc.ReadOnly = True
        Me.txbDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txbDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbDesc.Size = New System.Drawing.Size(301, 59)
        Me.txbDesc.TabIndex = 7
        Me.txbDesc.Text = "Connection type is?"
        '
        'txbRAS
        '
        Me.txbRAS.AcceptsReturn = True
        Me.txbRAS.BackColor = System.Drawing.SystemColors.Window
        Me.txbRAS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbRAS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbRAS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txbRAS.Location = New System.Drawing.Point(242, 144)
        Me.txbRAS.MaxLength = 0
        Me.txbRAS.Name = "txbRAS"
        Me.txbRAS.ReadOnly = True
        Me.txbRAS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txbRAS.Size = New System.Drawing.Size(67, 20)
        Me.txbRAS.TabIndex = 6
        Me.txbRAS.Text = "?"
        '
        'txbInternet
        '
        Me.txbInternet.AcceptsReturn = True
        Me.txbInternet.BackColor = System.Drawing.SystemColors.Window
        Me.txbInternet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbInternet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbInternet.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txbInternet.Location = New System.Drawing.Point(242, 112)
        Me.txbInternet.MaxLength = 0
        Me.txbInternet.Name = "txbInternet"
        Me.txbInternet.ReadOnly = True
        Me.txbInternet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txbInternet.Size = New System.Drawing.Size(67, 20)
        Me.txbInternet.TabIndex = 5
        Me.txbInternet.Text = "?"
        '
        'txbProxy
        '
        Me.txbProxy.AcceptsReturn = True
        Me.txbProxy.BackColor = System.Drawing.SystemColors.Window
        Me.txbProxy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbProxy.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbProxy.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txbProxy.Location = New System.Drawing.Point(242, 80)
        Me.txbProxy.MaxLength = 0
        Me.txbProxy.Name = "txbProxy"
        Me.txbProxy.ReadOnly = True
        Me.txbProxy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txbProxy.Size = New System.Drawing.Size(67, 20)
        Me.txbProxy.TabIndex = 4
        Me.txbProxy.Text = "?"
        '
        'txbModem
        '
        Me.txbModem.AcceptsReturn = True
        Me.txbModem.BackColor = System.Drawing.SystemColors.Window
        Me.txbModem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbModem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbModem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txbModem.Location = New System.Drawing.Point(242, 48)
        Me.txbModem.MaxLength = 0
        Me.txbModem.Name = "txbModem"
        Me.txbModem.ReadOnly = True
        Me.txbModem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txbModem.Size = New System.Drawing.Size(67, 20)
        Me.txbModem.TabIndex = 3
        Me.txbModem.Text = "?"
        '
        'txbLan
        '
        Me.txbLan.AcceptsReturn = True
        Me.txbLan.BackColor = System.Drawing.SystemColors.Window
        Me.txbLan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbLan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbLan.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txbLan.Location = New System.Drawing.Point(242, 16)
        Me.txbLan.MaxLength = 0
        Me.txbLan.Name = "txbLan"
        Me.txbLan.ReadOnly = True
        Me.txbLan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txbLan.Size = New System.Drawing.Size(67, 20)
        Me.txbLan.TabIndex = 2
        Me.txbLan.Text = "?"
        '
        'txtProgress
        '
        Me.txtProgress.BackColor = System.Drawing.SystemColors.Control
        Me.txtProgress.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtProgress.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtProgress.Location = New System.Drawing.Point(8, 271)
        Me.txtProgress.Name = "txtProgress"
        Me.txtProgress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProgress.Size = New System.Drawing.Size(301, 17)
        Me.txtProgress.TabIndex = 14
        Me.txtProgress.Text = "Progress"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(190, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Check For RAS Installed"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(190, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Check if Connected to the Internet"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(190, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Check For connection by Proxy"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(190, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Check For Modem Connection"
        '
        'LanConnection
        '
        Me.LanConnection.BackColor = System.Drawing.SystemColors.Control
        Me.LanConnection.Cursor = System.Windows.Forms.Cursors.Default
        Me.LanConnection.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LanConnection.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LanConnection.Location = New System.Drawing.Point(8, 19)
        Me.LanConnection.Name = "LanConnection"
        Me.LanConnection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LanConnection.Size = New System.Drawing.Size(190, 18)
        Me.LanConnection.TabIndex = 8
        Me.LanConnection.Text = "Check For Lan Connection"
        '
        'pbStatus
        '
        Me.pbStatus.Location = New System.Drawing.Point(8, 291)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(301, 16)
        Me.pbStatus.TabIndex = 15
        '
        'btnRetest
        '
        Me.btnRetest.Location = New System.Drawing.Point(8, 313)
        Me.btnRetest.Name = "btnRetest"
        Me.btnRetest.Size = New System.Drawing.Size(127, 23)
        Me.btnRetest.TabIndex = 16
        Me.btnRetest.Text = "Check Connection"
        Me.btnRetest.UseVisualStyleBackColor = True
        '
        'txbMeaMod
        '
        Me.txbMeaMod.AcceptsReturn = True
        Me.txbMeaMod.BackColor = System.Drawing.SystemColors.Window
        Me.txbMeaMod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txbMeaMod.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbMeaMod.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txbMeaMod.Location = New System.Drawing.Point(242, 175)
        Me.txbMeaMod.MaxLength = 0
        Me.txbMeaMod.Name = "txbMeaMod"
        Me.txbMeaMod.ReadOnly = True
        Me.txbMeaMod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txbMeaMod.Size = New System.Drawing.Size(67, 20)
        Me.txbMeaMod.TabIndex = 17
        Me.txbMeaMod.Text = "?"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(190, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Check if Connected to MeaMod"
        '
        'frmNetCheck
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(314, 342)
        Me.Controls.Add(Me.txbMeaMod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRetest)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.txbDesc)
        Me.Controls.Add(Me.txbRAS)
        Me.Controls.Add(Me.txbInternet)
        Me.Controls.Add(Me.txbProxy)
        Me.Controls.Add(Me.txbModem)
        Me.Controls.Add(Me.txbLan)
        Me.Controls.Add(Me.txtProgress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LanConnection)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNetCheck"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Internet Connection Check"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    'START FORM CODE

    Private CheckConn As New CheckInternetConnection()

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txbDesc.Text = "No Results"
        txtProgress.Text = "Waiting...."
        pbStatus.Value = 0
        txtProgress.Text = "Checking for Lan Connection..."
        pbStatus.Value = 10
        txbLan.Text = CStr(CheckConn.IsLanConnection())
        txtProgress.Text = "Checking for Modem Connection..."
        pbStatus.Value += 10
        txbModem.Text = CStr(CheckConn.IsModemConnection())
        txtProgress.Text = "Checking for Connection Via Proxy..."
        pbStatus.Value += 10
        txbProxy.Text = CStr(CheckConn.IsProxyConnection())
        txtProgress.Text = "Checking for Any Internet Connection..."
        pbStatus.Value += 10
        txbInternet.Text = CStr(CheckConn.IsConnected())
        txtProgress.Text = "Checking if RAS is installed..."
        pbStatus.Value += 10
        txbRAS.Text = CStr(CheckConn.IsRasInstalled())
        txtProgress.Text = "Checking if can connect to MeaMod..."
        pbStatus.Value += 10
        txbMeaMod.Text = CStr(CheckConn.CanConnectToMeaMod())
        txtProgress.Text = "Getting connection type..."
        pbStatus.Value = 100
        txbDesc.Text = CheckConn.ConnectionTypeMsg()
    End Sub

    Private Sub btnRetest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetest.Click
        pbStatus.Value = 0
        txtProgress.Text = "Checking for Lan Connection..."
        pbStatus.Value = 10
        txbLan.Text = CStr(CheckConn.IsLanConnection())
        txtProgress.Text = "Checking for Modem Connection..."
        pbStatus.Value += 10
        txbModem.Text = CStr(CheckConn.IsModemConnection())
        txtProgress.Text = "Checking for Connection Via Proxy..."
        pbStatus.Value += 10
        txbProxy.Text = CStr(CheckConn.IsProxyConnection())
        txtProgress.Text = "Checking for Any Internet Connection..."
        pbStatus.Value += 10
        txbInternet.Text = CStr(CheckConn.IsConnected())
        txtProgress.Text = "Checking if RAS is installed..."
        pbStatus.Value += 10
        txbRAS.Text = CStr(CheckConn.IsRasInstalled())
        txtProgress.Text = "Checking if can connect to MeaMod..."
        pbStatus.Value += 10
        txbMeaMod.Text = CStr(CheckConn.CanConnectToMeaMod())
        txtProgress.Text = "Getting connection type..."
        pbStatus.Value = 100
        txbDesc.Text = CheckConn.ConnectionTypeMsg()
    End Sub
End Class