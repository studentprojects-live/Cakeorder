Public Class frmreport

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        i = 0
        DataGridView1.Rows.Clear()

        sql = " SELECT orderno, username, ordered, caketype, outside, inside, cakeperkg, stperkg, qty, total"
        sql = sql + " FROM dbo.tbl_order"
        sql = sql + " WHERE (ordered between convert(date,'" & DateTimePicker1.Value & "',103) and convert(date,'" & DateTimePicker2.Value & "',103))"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            DataGridView1.Item(4, i).Value = rs(4).Value
            DataGridView1.Item(5, i).Value = rs(5).Value
            DataGridView1.Item(6, i).Value = rs(6).Value
            DataGridView1.Item(7, i).Value = rs(7).Value
            DataGridView1.Item(8, i).Value = rs(8).Value
            DataGridView1.Item(9, i).Value = rs(9).Value
            i = i + 1
            rs.MoveNext()



        Loop

    End Sub

    Private Sub frmreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()

    End Sub
End Class