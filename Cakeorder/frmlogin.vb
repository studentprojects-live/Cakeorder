Public Class frmlogin

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()

    End Sub
    Sub clear()
        cmdtype.SelectedIndex = -1
        txtpass.Text = ""
        txtname.Text = ""


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmdtype.Text = "" Then
            MsgBox("Enter usertype")
        ElseIf txtname.Text = "" Then
            MsgBox("Enter the username")

        ElseIf txtpass.Text = "" Then
            MsgBox("Enter the password")
        Else
            sql = "select * from tbl_register where usertype='" & cmdtype.Text & "' and username='" & txtname.Text & "' and password='" & txtpass.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
               


                username = txtname.Text
                If cmdtype.Text = "ADMIN" Then

                    Me.Hide()
                    frmwelcome.Show()
                    '    cmdtype.SelectedIndex = -1
                    'txtname.Text = ""
                    txtpass.Text = ""

                ElseIf cmdtype.Text = "RECEPTIONIST" Then
                    Me.Hide()

                    'menuform.PAYROLLToolStripMenuItem.Visible = False
                    frmwelcome.MASTERToolStripMenuItem.Visible = False

                    frmwelcome.Show()
                    '    cmdtype.SelectedIndex = -1
                    '    txtname.Text = ""
                    txtpass.Text = ""
                End If

            Else
                MsgBox("Login Failed")

            End If
            End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()

    End Sub

    Private Sub txtname_ControlRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles txtname.ControlRemoved

    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtname.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True

            End If
        End If
    End Sub
End Class