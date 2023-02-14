Imports System.Configuration
Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view()
        view_Name()
    End Sub
    Sub view_Name()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\bookStore\bookStoreDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select b_name from books", conn)
        Dim cmd As New OleDbCommand()
        Dim ds As New DataSet()
        adp.Fill(ds, "books")
        ttls.DataSource = ds.Tables("books")
        ttls.ValueMember = "b_name"
        ttls.DisplayMember = "b_name"
        conn.Close()
    End Sub
    Sub view()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\bookStore\bookStoreDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from books", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "books")
        GridView.DataSource = ds.Tables("books")
        conn.Close()

    End Sub

    Private Sub dlt_Click(sender As Object, e As EventArgs) Handles dlt.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\bookStore\bookStoreDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from books where b_no= " & bno.Value & " "
        cmd.ExecuteNonQuery()
        MsgBox("Record deleted successfully!")
        conn.Close()
        view()
    End Sub

    Private Sub ttls_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ttls.SelectedIndexChanged
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\bookStore\bookStoreDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from books where b_name='" & ttls.Text & "'", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "books")
        GridView.DataSource = ds.Tables("books")
        conn.Close()
    End Sub

    Private Sub show_Click(sender As Object, e As EventArgs) Handles show.Click
        view()
    End Sub
End Class
