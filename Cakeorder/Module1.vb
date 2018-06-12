
Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public conn As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public rss As New ADODB.Recordset
    Public sql As String
    Public server1 As String
    Public database1 As String
    Public user1 As String
    Public password1 As String
    Public oid As String
    Public ono As String
    Public d As Date
    Public dt As String
    Public username As String

    Public con As New SqlConnection("Server=SUSHANTH-PC;Database=Cakeorder;Trusted_Connection=false;user id=sa;password=q1w2e3r4/;")
    Public i As Integer
    Public Function opendb()

        If conn.State = 1 Then conn.Close()
        conn.Open("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;password=q1w2e3r4/;Initial Catalog=Cakeorder;Data Source=SUSHANTH-PC")
        Return 0
    End Function

    Public Sub SetConnection(Optional ByVal Firstcomp As Boolean = False)
        Dim str As String
        str = "Data Source=SUSHANTH-PC;Initial Catalog=Cakeorder;User ID=sa;Password=q1w2e3r4/"
        Try
            If IsNothing(con) = False Then
                If con.State = ConnectionState.Closed Then
                    con.Close()
                End If
            End If
            con = New SqlConnection(str)
            con.Open()
        Catch ex As System.Exception
            MsgBox(ex.Message)
            MsgBox("Not Connecting to Database Server.Please check your network.")
        End Try
    End Sub
End Module
