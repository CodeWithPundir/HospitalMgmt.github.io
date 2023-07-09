Imports System.Data.OleDb
Imports System.Data.SqlClient
Module moduleeye
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
    Sub refreshdgv()
        'fill datagridview with data from data base
        Dim sql As String
        sql = "SELECT * FROM regeye"
        Dim da As New OleDbDataAdapter(sql, con)
        Dim dt As New DataTable("regeye")
        da.Fill(dt)
        'assign data source to datagridview
        frmeye.dgv1.DataSource = dt
    End Sub
    Sub disable()
        frmeye.btncofirm.Enabled = True
        frmeye.btnsave.Enabled = False
        frmeye.btndelete.Enabled = True
        frmeye.btnclear.Enabled = True
    End Sub
    Public Sub confirmation()
        Dim sqlQRY As String = "SELECT * FROM reg WHERE ID = " & frmeye.txtconfirm.Text

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
                frmeye.txtid.Text = row("ID")
                frmeye.txtname.Text = row("First_name")
                frmeye.txtsur.Text = row("Surname")
                frmeye.txtage.Text = row("Age")
            Next row
        Catch ex As OleDbException
            MsgBox("Error: " & ex.ToString & vbCrLf)
        Finally
            ' Close connection
            con.Close()
        End Try
    End Sub
    Public Sub clear()
        frmeye.txtname.Clear()
        frmeye.txtsur.Clear()
        frmeye.txthistory.Clear()
        frmeye.txtid.Clear()
        frmeye.txtdiagnosis.Clear()
        frmeye.txtdefect.Clear()
        frmeye.txttreatment.Clear()
        frmeye.txtconfirm.Clear()
        frmeye.txtdoctor.Clear()
        frmeye.txtage.Clear()
        frmeye.txtid.Clear()
        frmeye.txtspectacle.Clear()
    End Sub
    Sub dgv1click()
        ' What this does is when the User selects a record in the DataGridView
        ' it will populate the textbox on the other form with the corresponding
        'Cell Value.
        frmeye.txtid.Text = frmeye.dgv1.CurrentRow.Cells(0).Value.ToString
        frmeye.txtname.Text = frmeye.dgv1.CurrentRow.Cells(1).Value.ToString
        frmeye.txtsur.Text = frmeye.dgv1.CurrentRow.Cells(2).Value.ToString
        frmeye.txtage.Text = frmeye.dgv1.CurrentRow.Cells(3).Value.ToString
        frmeye.txthistory.Text = frmeye.dgv1.CurrentRow.Cells(4).Value.ToString
        frmeye.txtdiagnosis.Text = frmeye.dgv1.CurrentRow.Cells(5).Value.ToString
        frmeye.txtdefect.Text = frmeye.dgv1.CurrentRow.Cells(6).Value.ToString
        frmeye.txttreatment.Text = frmeye.dgv1.CurrentRow.Cells(7).Value.ToString
        frmeye.txtspectacle.Text = frmeye.dgv1.CurrentRow.Cells(8).Value.ToString
        frmeye.txtdoctor.Text = frmeye.dgv1.CurrentRow.Cells(9).Value.ToString
        frmeye.dtp.Text = frmeye.dgv1.CurrentRow.Cells(10).Value.ToString
    End Sub
    Public Sub autocompleteID()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT patientid FROM regeye"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "regeye") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("patientid").ToString())

        Next
        frmeye.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmeye.txtseacrh.AutoCompleteCustomSource = col
        frmeye.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
    Sub autocompletFirst_Name()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT First_name FROM regeye"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "regeye") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("First_name").ToString())

        Next
        frmeye.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmeye.txtseacrh.AutoCompleteCustomSource = col
        frmeye.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
    Sub autocompletSurname()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT Surname FROM regeye"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "regeye") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Surname").ToString())

        Next
        frmeye.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmeye.txtseacrh.AutoCompleteCustomSource = col
        frmeye.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
End Module
