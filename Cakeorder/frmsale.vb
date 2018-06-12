Public Class frmsale

    Private Sub frmsale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        orderno()
        txtusername.Text = username
    End Sub
    Sub orderno()
        cmdono.Items.Clear()
        sql = "select distinct orderno from tbl_order where status=0"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While rs.EOF = False
            cmdono.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub cmdono_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdono.SelectedIndexChanged
        sql = " Select name from tbl_order where orderno='" & cmdono.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtname.Text = rs(0).Value
        End If

        sql = " Select contact from tbl_order where orderno='" & cmdono.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtcontact.Text = rs(0).Value
        End If

        sql = " Select caketype from tbl_order where orderno='" & cmdono.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtcake.Text = rs(0).Value
        End If

        sql = " Select outside from tbl_order where orderno='" & cmdono.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtout.Text = rs(0).Value
        End If

        sql = " Select inside from tbl_order where orderno='" & cmdono.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtin.Text = rs(0).Value
        End If

        sql = " Select total from tbl_order where orderno='" & cmdono.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txttotal.Text = rs(0).Value
        End If

        'sql = " Select payment from tbl_order where orderno='" & cmdono.Text & "'"
        'If rs.State = 1 Then rs.Close()
        'rs.Open(sql, conn)
        'If rs.EOF = False Then
        '    txtpaid.Text = rs(0).Value
        'End If

        sql = " Select cakeperkg from tbl_order where orderno='" & cmdono.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtcakers.Text = rs(0).Value
        End If

        sql = " Select stperkg from tbl_order where orderno='" & cmdono.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtstuffrs.Text = rs(0).Value
        End If


        i = 0
        DataGridView1.Rows.Clear()

        sql = " SELECT     orderno, totalpkg, qty, total, payment "
        sql = sql + " FROM         dbo.tbl_order"
        sql = sql + " WHERE     (orderno = '" & cmdono.Text & "')"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            DataGridView1.Item(4, i).Value = rs(4).Value
            DataGridView1.Item(5, i).Value = DataGridView1.Item(3, i).Value - DataGridView1.Item(4, i).Value
            i = i + 1
            rs.MoveNext()



        Loop
    End Sub

    Private Sub txtpaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaid.TextChanged

    End Sub
    Sub loadgrid()
        i = 0
        DataGridView1.Rows.Clear()

        sql = "select * from tbl_order where orderno='" & cmdono.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(14).Value
            DataGridView1.Item(2, i).Value = rs(8).Value
            DataGridView1.Item(3, i).Value = rs(9).Value
            DataGridView1.Item(4, i).Value = rs(10).Value
            DataGridView1.Item(5, i).Value = DataGridView1.Item(3, i).Value - DataGridView1.Item(4, i).Value
            i = i + 1
            rs.MoveNext()



        Loop


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmdono.Text = "" Then
            MsgBox("select order no")


        ElseIf txtpaid.Text = "" Then
            MsgBox("enter the payment")
        ElseIf txtpaid.Text > txttotal.Text Then
            MsgBox("Paid amount shoud be lesser than the total amount")
            txtpaid.Text = ""

        Else






            Dim sum As Integer
            sum = txtpaid.Text

            sql = "update tbl_order set payment= payment + '" & sum & "' where orderno='" & cmdono.Text & "'"
            conn.Execute(sql)
            loadgrid()

            Dim paid As Integer
            Dim total As Integer

            sql = " select total, payment from tbl_order where orderno='" & cmdono.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                total = rs(0).Value
                paid = rs(1).Value



            End If
            If total = paid Then
                sql = "update tbl_order set status=1 where orderno='" & cmdono.Text & "'"
                conn.Execute(sql)

            End If

            sql = "insert into tbl_sale(orderno,contact,cake,outside,inside,cakeperkg,stperkg,qty,total,paid,name)"
            sql = sql & " values('" & cmdono.Text & "','" & txtcontact.Text & "','" & txtcake.Text & "','" & txtout.Text & "','" & txtin.Text & "','" & txtcakers.Text & "','" & txtstuffrs.Text & "','" & DataGridView1.CurrentRow.Cells(2).Value & "','" & txttotal.Text & "','" & DataGridView1.CurrentRow.Cells(4).Value & "','" & txtname.Text & "')"
            conn.Execute(sql)
            MsgBox("saved")
            ono = cmdono.Text








        End If



    End Sub
    Sub clear()
        'cmdono.SelectedIndex = -1
        txtname.Text = ""
        txtcontact.Text = ""
        txtcake.Text = ""
        txtout.Text = ""
        txtin.Text = ""
        txtcakers.Text = ""
        txtstuffrs.Text = ""
        txttotal.Text = ""
        txtpaid.Text = ""
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ono = "" Then
            MsgBox("select record to print")

        Else

            Dim Sql = "select * from tbl_settings"
            Dim rs As New ADODB.Recordset
            rs.Open(Sql, conn)
            If rs.EOF = False Then
                server1 = rs(0).Value
                database1 = rs(1).Value
                user1 = rs(2).Value
                password1 = rs(3).Value
            End If
            Dim rpt As New Crystalbill
            rpt.DataSourceConnections.Item(0).SetConnection(server1, database1, user1, password1)
            rpt.DataSourceConnections.Item(0).SetLogon(user1, password1)
            'rpt.RecordSelectionFormula = " {command.receiptNo}='" & txtrno.Text & "'"
            rpt.SetParameterValue("ono", ono)

            frmbill.CrystalReportViewer1.ReportSource = rpt
            frmbill.CrystalReportViewer1.Refresh()
            frmbill.ShowDialog()


        End If
    End Sub
End Class