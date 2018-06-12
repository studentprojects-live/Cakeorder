Public Class frmwelcome

    Private Sub MASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MASTERToolStripMenuItem.Click

    End Sub

    Private Sub frmwelcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'opendb()

    End Sub

    Private Sub FLAVOURToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FLAVOURToolStripMenuItem.Click
        frmflavour.Show()

    End Sub

    Private Sub CAKESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CAKESToolStripMenuItem.Click
        frmcake.Show()

    End Sub

    Private Sub REGISTRATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRATIONToolStripMenuItem.Click
        frmreg.Show()

    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        If MsgBoxResult.No = MsgBox("DO YOU WANT TO EXIT?", MsgBoxStyle.YesNo) Then Exit Sub
        Application.Exit()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        If MsgBoxResult.No = MsgBox("DO YOU WANT TO LOGOUT?", MsgBoxStyle.YesNo, "TICKET") Then Exit Sub

        Me.Close()
        frmlogin.Show()
    End Sub

    Private Sub ORDERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ORDERToolStripMenuItem.Click
        frmorder.Show()

    End Sub

    Private Sub SALESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALESToolStripMenuItem.Click
        frmsale.Show()

    End Sub

    Private Sub REPORTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTSToolStripMenuItem.Click


    End Sub

    Private Sub ORDERREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ORDERREPORTToolStripMenuItem.Click
        frmreport.Show()
    End Sub

    Private Sub USERREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERREPORTToolStripMenuItem.Click
        frmuserreport.Show()

    End Sub
End Class