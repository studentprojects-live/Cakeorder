Public Class frmuserreport

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        i = 0
        DataGridView1.Rows.Clear()

        sql = " SELECT orderno, caketype, cakeperkg, stperkg, qty, total, ordered, username "
        sql = sql + " FROM dbo.tbl_order"
        sql = sql + " WHERE (ordered between convert(date,'" & DateTimePicker1.Value & "',103) and convert(date,'" & DateTimePicker2.Value & "',103)) and  (username = '" & cmduser.Text & "')"
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
            i = i + 1
            rs.MoveNext()


        Loop
    End Sub

    Private Sub frmuserreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        username()


    End Sub
    Sub username()
        cmduser.Items.Clear()
        sql = "select distinct username from tbl_order"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            cmduser.Items.Add(rs(0).Value)
            rs.MoveNext()

        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sum As Integer
        sum = 0
        For a = 0 To DataGridView1.Rows.Count - 1
            sum = sum + DataGridView1.Rows(a).Cells(5).Value


        Next
        txttotal.Text = sum
    End Sub
End Class