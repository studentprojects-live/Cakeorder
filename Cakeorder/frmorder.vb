Public Class frmorder

    Private Sub frmorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        txtpayment.Text = 0
        txtordertaken.Text = username
        cake()
        outside()
        inside()
        orderno()
        DateTimePicker2.MinDate = Today.Date






    End Sub
    Sub orderno()
        Dim j
        j = 1
        txtono.Text = j
        sql = " select max(orderno) from tbl_order"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            j = rs(0).Value
            j = j + 1
            txtono.Text = j

        End If

    End Sub
    
    Sub cake()
        cmdcake.Items.Clear()
        sql = "select distinct cakename from tbl_cake"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While rs.EOF = False
            cmdcake.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Sub outside()
        cmdout.Items.Clear()
        sql = "select distinct outside from tbl_flavour"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While rs.EOF = False
            cmdout.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Sub inside()
        cmdin.Items.Clear()
        sql = "select distinct inside from tbl_flavour"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While rs.EOF = False
            cmdin.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()

    End Sub
    Sub clear()
        txtono.Text = ""
        txtname.Text = ""
        txtcontact.Text = ""
        txtpayment.Text = ""
        DataGridView1.Rows.Clear()
        'cmdcake.SelectedIndex = -1
        'cmdin.SelectedIndex = -1
        'cmdout.SelectedIndex = -1
        DateTimePicker2.Value = Today.Date




    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtono.Text = "" Then
            MsgBox("insert order no")
        ElseIf txtname.Text = "" Then
            MsgBox("Enter the name")
        ElseIf txtcontact.Text = "" Then
            MsgBox("Enter the contact no")
        ElseIf txtpayment.Text = "" Then
            MsgBox("Enter the advance payment")
        ElseIf cmdcake.Text = "" Then
            MsgBox("select the cake")
        ElseIf cmdin.Text = "" Then
            MsgBox("select the inside stuffing")
        ElseIf cmdout.Text = "" Then
            MsgBox("select the outside stuffing")

        Else


            sql = "insert into tbl_order(orderno,name,contact,ordered,caketype,delivery,outside,inside,qty,total,payment,username,cakeperkg,stperkg,totalpkg,status)"
            sql = sql & " values('" & txtono.Text & "','" & txtname.Text & "','" & txtcontact.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),'" & cmdcake.Text & "',convert(date,'" & DateTimePicker2.Value & "',103),'" & cmdout.Text & "','" & cmdin.Text & "','" & DataGridView1.CurrentRow.Cells(6).Value & "','" & DataGridView1.CurrentRow.Cells(7).Value & "','" & txtpayment.Text & "','" & txtordertaken.Text & "', '" & DataGridView1.CurrentRow.Cells(3).Value & "','" & DataGridView1.CurrentRow.Cells(4).Value & "','" & DataGridView1.CurrentRow.Cells(5).Value & "',0)"
            conn.Execute(sql)
            MsgBox("saved")
            ono = txtono.Text

            clear()
            orderno()
            loadgrid()
           
        End If




    End Sub

    Private Sub cmdcake_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcake.SelectedIndexChanged
      
    End Sub
    Sub loadgrid()
        i = 0
        DataGridView1.Rows.Clear()

        sql = " SELECT dbo.tbl_flavour.outside, dbo.tbl_flavour.inside, dbo.tbl_flavour.rate, dbo.tbl_cake.cakename, dbo.tbl_cake.amount "
        sql = sql + " FROM dbo.tbl_flavour CROSS JOIN"
        sql = sql + " dbo.tbl_cake"
        sql = sql + " WHERE dbo.tbl_cake.cakename = '" & cmdcake.Text & "' AND dbo.tbl_flavour.outside = '" & cmdout.Text & "' AND dbo.tbl_flavour.inside = '" & cmdin.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)

        Do While Not rs.EOF




            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(3).Value
            DataGridView1.Item(1, i).Value = rs(0).Value
            DataGridView1.Item(2, i).Value = rs(1).Value
            DataGridView1.Item(3, i).Value = rs(4).Value
            If cmdin.Text = "nothing" Or cmdout.Text = "nothing" Then
                DataGridView1.Item(4, i).Value = "10"
            Else


                DataGridView1.Item(4, i).Value = rs(2).Value
            End If
            DataGridView1.Item(5, i).Value = DataGridView1.Item(3, i).Value + DataGridView1.Item(4, i).Value
            i = i + 1
            rs.MoveNext()



        Loop
    End Sub

    Private Sub cmdin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdin.SelectedIndexChanged
        If cmdcake.Text = "" Then
            MsgBox("select cake")
        ElseIf cmdout.Text = "" Then
            MsgBox("select outside stuffing")
        ElseIf cmdin.Text = "" Then
            MsgBox("select inside stuffing")
        Else

            loadgrid()


           
        End If

    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Try


            If e.ColumnIndex = 6 Then
                If DataGridView1.CurrentRow.Cells(6).Value <> "" Then
                    DataGridView1.CurrentRow.Cells(7).Value = Val(DataGridView1.CurrentRow.Cells(5).Value) * Val(DataGridView1.CurrentRow.Cells(6).Value)
                End If
            End If
        Catch ex As Exception

        End Try
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

    Private Sub txtcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontact.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtcontact.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub txtpayment_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtpayment.DragDrop

    End Sub

    Private Sub txtpayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpayment.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtpayment.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True

            End If
        End If
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
            Dim rpt As New Crystalorderbill
            rpt.DataSourceConnections.Item(0).SetConnection(server1, database1, user1, password1)
            rpt.DataSourceConnections.Item(0).SetLogon(user1, password1)
            'rpt.RecordSelectionFormula = " {command.receiptNo}='" & txtrno.Text & "'"
            rpt.SetParameterValue("ono", ono)

            frmorderbill.CrystalReportViewer1.ReportSource = rpt
            frmorderbill.CrystalReportViewer1.Refresh()
            frmorderbill.ShowDialog()


        End If
    End Sub
End Class