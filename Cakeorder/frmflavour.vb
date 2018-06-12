Public Class frmflavour

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtoutside.Text = "" Then
            MsgBox("enter the outside stuffing")
        ElseIf txtinside.Text = "" Then
            MsgBox("enter the inside stuffing")
        ElseIf txtrate.Text = "" Then
            MsgBox("enter the rate")
        Else
            sql = "update tbl_flavour set outside='" & txtoutside.Text & "', inside='" & txtinside.Text & "', rate='" & txtrate.Text & "' where fno='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
            conn.Execute(sql)
            MsgBox("record updated")
            loadgrid()

            clear()
            fno()
        End If



    End Sub
    Sub fno()
        Dim i
        i = 1
        txtfno.Text = i
        sql = "select max(fno) from tbl_flavour"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            i = rs(0).Value
            i = i + 1
            txtfno.Text = i

        End If
    End Sub

    Private Sub frmflavour_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadgrid()
        fno()


    End Sub
    Sub loadgrid()
        i = 0
        DataGridView1.Rows.Clear()
        sql = "select * from tbl_flavour"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            i = i + 1
            rs.MoveNext()



        Loop
    End Sub
    Sub clear()
        txtfno.Text = ""
        txtoutside.Text = ""
        txtinside.Text = ""
        txtrate.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        clear()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtoutside.Text = "" Then
            MsgBox("enter the outside stuffing")
        ElseIf txtinside.Text = "" Then
            MsgBox("enter the inside stuffing")
        ElseIf txtrate.Text = "" Then
            MsgBox("enter the rate")
        Else



            sql = "insert into tbl_flavour(fno,outside,inside,rate)"
            sql = sql & "values('" & txtfno.Text & "','" & txtoutside.Text & "','" & txtinside.Text & "','" & txtrate.Text & "')"
            conn.Execute(sql)
            MsgBox("saved successfully")

            loadgrid()


            clear()

            fno()

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sql = "delete from tbl_flavour where fno='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conn.Execute(sql)
        MsgBox("record deleted")
        loadgrid()
        clear()
        fno()


    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtfno.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtoutside.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtinside.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtrate.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Private Sub txtoutside_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtoutside.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtoutside.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True

            End If
        End If
    End Sub



    Private Sub txtinside_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtinside.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtinside.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub txtrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrate.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtrate.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True

            End If
        End If
    End Sub
End Class