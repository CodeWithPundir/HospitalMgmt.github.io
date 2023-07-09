Imports System.Data.OleDb
Imports System.Data.SqlClient
Module moduledental
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
    Sub refreshdgv()
        'fill datagridview with data from data base
        Dim sql As String
        sql = "SELECT * FROM regdental"
        Dim da As New OleDbDataAdapter(sql, con)
        Dim dt As New DataTable("regdental")
        da.Fill(dt)
        'assign data source to datagridview
        frmdental.dgv1.DataSource = dt
    End Sub
    Sub disable()
        frmdental.btncofirm.Enabled = True
        frmdental.btnsave.Enabled = False
        frmdental.btndelete.Enabled = True
        frmdental.btnclear.Enabled = True
    End Sub
    Public Sub confirmation()
        Dim sqlQRY As String = "SELECT * FROM reg WHERE ID = " & frmdental.txtconfirm1.Text

        'Create connection
        Try
            ' Open connection
            con.Open()
            'create data adapter
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlQRY, con)
            'create dataset
            Dim ds As DataSet = New DataSet
            'fill dataset
            da.Fill(ds, "reg")
            'get data table
            Dim dt As DataTable = ds.Tables("reg")
            'display data
            Dim row As DataRow

            For Each row In dt.Rows
                frmdental.txtid.Text = row("ID")
                frmdental.txtname.Text = row("First_name")
                frmdental.txtsur.Text = row("Surname")
                frmdental.txtage.Text = row("Age")
            Next row
        Catch ex As OleDbException
            MsgBox("Error: " & ex.ToString & vbCrLf)
        Finally
            ' Close connection
            con.Close()
        End Try
    End Sub
    Public Sub clear()
        frmdental.txtname.Clear()
        frmdental.txtsur.Clear()
        frmdental.txthistory.Clear()
        frmdental.txtid.Clear()
        frmdental.txtdiagnosis.Clear()
        frmdental.txtdefect.Clear()
        frmdental.txttreatment.Clear()
        frmdental.txtconfirm.Clear()
        frmdental.txtdoctor.Clear()
    End Sub
    Sub dgv1click()
        ' What this does is when the User selects a record in the DataGridView
        ' it will populate the textbox on the other form with the corresponding
        'Cell Value.
        frmdental.txtid.Text = frmdental.dgv1.CurrentRow.Cells(0).Value.ToString
        frmdental.txtname.Text = frmdental.dgv1.CurrentRow.Cells(1).Value.ToString
        frmdental.txtsur.Text = frmdental.dgv1.CurrentRow.Cells(2).Value.ToString
        frmdental.txtage.Text = frmdental.dgv1.CurrentRow.Cells(3).Value.ToString
        frmdental.txthistory.Text = frmdental.dgv1.CurrentRow.Cells(4).Value.ToString
        frmdental.txtdiagnosis.Text = frmdental.dgv1.CurrentRow.Cells(5).Value.ToString
        frmdental.txtdefect.Text = frmdental.dgv1.CurrentRow.Cells(6).Value.ToString
        frmdental.txttreatment.Text = frmdental.dgv1.CurrentRow.Cells(7).Value.ToString
        frmdental.txtdoctor.Text = frmdental.dgv1.CurrentRow.Cells(8).Value.ToString
        frmdental.dtp.Text = frmdental.dgv1.CurrentRow.Cells(9).Value.ToString
    End Sub
    Public Sub autocompleteID()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT patientid FROM regdental"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "regdental") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("patientid").ToString())

        Next
        frmdental.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmdental.txtseacrh.AutoCompleteCustomSource = col
        frmdental.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
    Sub autocompletFirst_Name()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT First_name FROM regdental"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "regdental") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("First_name").ToString())

        Next
        frmdental.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmdental.txtseacrh.AutoCompleteCustomSource = col
        frmdental.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
    Sub autocompletSurname()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT Surname FROM regdental"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "regdental") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Surname").ToString())

        Next
        frmdental.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmdental.txtseacrh.AutoCompleteCustomSource = col
        frmdental.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
End Module
