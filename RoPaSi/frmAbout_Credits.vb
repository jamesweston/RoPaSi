Public Class frmAbout_Credits

    Private Sub frmAbout_Credits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        wbCredits.DocumentText = "<marquee scrollamount=" + Chr(34) + "1" + Chr(34) + " scrolldelay=" + Chr(34) + "20" + Chr(34) + " direction=" + Chr(34) + "up" + Chr(34) + " height=" + Chr(34) + "255" + Chr(34) + " style=" + Chr(34) + "font-family: Verdana; font-size: 10pt" + Chr(34) + ">Developed by James Weston</br></br>Special Thanks To:</br>The MeaMod Group</br>JSW Computing</br>Mywn Gaming</br>chaos7</br>Channel9</marquee>"
    End Sub
End Class