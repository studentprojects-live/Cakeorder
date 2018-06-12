Public Class frmcake

    Private Sub frmcake_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadgrid()
        cakeno()


    End Sub
    Sub cakeno()
        Dim j
        j = 1
        txtcno.Text = j
        sql = "select max(cakeno) from tbl_cake"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            j = rs(0).Value
            j = j + 1
            txtcno.Text = j

        End If
    End Sub
    Sub loadgrid()
        i = 0
        DataGridView1.Rows.Clear()
        sql = "select * from tbl_cake"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            i = i + 1
            rs.MoveNext()



        Loop
    End Sub
    Sub clear()
        txtcno.Text = ""
        txtcake.Text = ""
        txtrate.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtcake.Text = "" Then
            MsgBox("enter the cake name")
        ElseIf txtrate.Text = "" Then
            MsgBox("enter the rate")
        Else




            sql = "insert into tbl_cake(cakeno,cakename,amount)"
            sql = sql & "values('" & txtcno.Text & "','" & txtcake.Text & "','" & txtrate.Text & "')"
            conn.Execute(sql)
            MsgBox("saved successsfully")
            loadgrid()


            clear()
            cakeno()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sql = "delete from tbl_cake where cakeno='" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        conn.Execute(sql)
        MsgBox("record deleted")
        loadgrid()
        
        clear()
        cakeno()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtcake.Text = "" Then
            MsgBox("enter the cake name")
        ElseIf txtrate.Text = "" Then
            MsgBox("enter the rate")
        Else


            sql = "update tbl_cake set cakename='" & txtcake.Text & "' ,amount= '" & txtrate.Text & "' where cakeno='" & DataGridView1.CurrentRow.Cells(0).Value & "' "
            conn.Execute(sql)
            MsgBox("record updated")
            loadgrid()


            clear()
            cakeno()
        End If

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtcno.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtcake.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtrate.Text = DataGridView1.CurrentRow.Cells(2).Value

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        clear()

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


    Private Sub txtcake_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcake.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtcake.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True

            End If
        End If


    End Sub
End Class
