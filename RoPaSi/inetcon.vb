'Intenet Connection Module
'Developed by The MeaMod Group
'Copyright 2008 The MeaMod Group
'http://meamod.com
'by James Weston
'--------------------------------
Public Class CheckInternetConnection
    '**************************************
    ' Name: Check internet connection type
    ' This code makes API calls to check for an internet conection and
    ' returns the type of connection through API calls to the wininet.dll


    Public Declare Function InternetGetConnectedState Lib "wininet.dll" (ByRef lpdwFlags As Integer, ByVal dwReserved As Integer) As Integer
    'Internet connection VIA Proxy server.
    Public Const ProxyConnection As Integer = &H4S

    'Modem is busy.
    Public Const ModemConnectionIsBusy As Integer = &H8S

    'Internet connection is currently Offline
    Public Const InternetIsOffline As Integer = &H20S

    'Internet connection is currently configured
    Public Const InternetConnectionIsConfigured As Integer = &H40S

    'Internet connection VIA Modem.
    Public Const ModemConnection As Integer = &H1S

    'Remote Access Server is installed.
    Public Const RasInstalled As Integer = &H10S

    'Internet connection VIA LAN.
    Public Const LanConnection As Integer = &H2S





    Public Function IsLanConnection() As Boolean
        Dim dwflags As Integer
        'return True if LAN connection
        Call InternetGetConnectedState(dwflags, 0)
        IsLanConnection = dwflags And LanConnection
    End Function


    Public Function IsModemConnection() As Boolean
        Dim dwflags As Integer
        'return True if modem connection.
        Call InternetGetConnectedState(dwflags, 0)
        IsModemConnection = dwflags And ModemConnection
    End Function


    Public Function IsProxyConnection() As Boolean
        Dim dwflags As Integer
        'return True if connected through a proxy.
        Call InternetGetConnectedState(dwflags, 0)
        IsProxyConnection = dwflags And ProxyConnection
    End Function


    Public Function IsConnected() As Boolean
        'Returns true if there is any internet connection.
        IsConnected = InternetGetConnectedState(0, 0)
    End Function


    Public Function IsRasInstalled() As Boolean
        Dim dwflags As Integer
        'return True if RAS installed.
        Call InternetGetConnectedState(dwflags, 0)
        IsRasInstalled = dwflags And RasInstalled
    End Function

    Public Function CanConnectToMeaMod() As Boolean
        Dim siteResponds As Boolean = False
        Try
            siteResponds = My.Computer.Network.Ping("meamod.com")
        Catch ex As Exception
            siteResponds = False
        End Try
        CanConnectToMeaMod = siteResponds
    End Function


    Public Function ConnectionTypeMsg() As String
        Dim dwflags As Integer
        Dim msg As String = ""
        'Return Internet connection msg.

        If InternetGetConnectedState(dwflags, 0) Then

            If dwflags And InternetConnectionIsConfigured Then
                msg = msg & "Internet connection is configured." & ControlChars.NewLine
            End If

            If dwflags And LanConnection Then
                msg = msg & "Internet connection via a LAN"
            End If

            If dwflags And ProxyConnection Then
                msg = msg & ", and connection is through a proxy server." & ControlChars.NewLine
            Else
                msg = msg & "." & ControlChars.NewLine
            End If

            If dwflags And ModemConnection Then
                msg = msg & "Internet connection via a Modem" & ControlChars.NewLine
            End If

            If dwflags And InternetIsOffline Then
                msg = msg & "Internet connection is currently offline." & ControlChars.NewLine
            End If

            If dwflags And ModemConnectionIsBusy Then
                msg = msg & "Modem is busy with a non-Internet connection." & ControlChars.NewLine
            End If

            If dwflags And RasInstalled Then
                msg = msg & "Remote Access Services are installed on local system." & ControlChars.NewLine
            End If

            If dwflags And CanConnectToMeaMod() = True Then
                msg = msg & "Connected to MeaMod successfully."
            Else
                msg = msg & ""
            End If

        Else
            msg = "You are currently not connected to the internet."

        End If

        ConnectionTypeMsg = msg

    End Function

End Class