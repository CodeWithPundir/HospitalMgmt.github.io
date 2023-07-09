Imports System.Data.OleDb
Imports System.Data.SqlClient
Module Module1
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
    Public Sub clear()
        frmRegistration.txtfname.Clear()
        frmRegistration.txtsur.Clear()
        frmRegistration.txthadd.Clear()
        frmRegistration.txtid.Clear()
        frmRegistration.txtkinadd.Clear()
        frmRegistration.txtkinname.Clear()
        frmRegistration.txtage.Clear()
        frmRegistration.txtphone.Clear()
        frmRegistration.txtweight.Clear()
        frmRegistration.txtwork.Clear()
    End Sub
    Sub refreshdgv()
        'fill datagridview with data from data base
        Dim sql As String
        sql = "SELECT * FROM reg"
        Dim da As New OleDbDataAdapter(sql, con)
        Dim dt As New DataTable("reg")
        da.Fill(dt)
        'assign data source to datagridview
        frmRegistration.dgv.DataSource = dt
    End Sub
    Sub AutoNumberNo()
        Dim myReader As SqlDataReader
        con.Open()
        Dim temp As String
        Try
            Dim sql As String = "SELECT MAX(NO) 'ID' FROM reg"
            Dim comm As SqlCommand = New SqlCommand(sql)
            myReader = comm.ExecuteReader
            If myReader.HasRows Then
                While myReader.Read()
                    temp = myReader.Item("ID") + 1
                End While
            End If
            myReader.Close()
        Catch ex As Exception
        End Try
        con.Close()
        frmRegistration.txtid.Text = String.Concat(temp)
        ' result will appear in textbox txtId
    End Sub
    Sub dgvclick()

        ' What this does is when the User selects a record in the DataGridView
        ' it will populate the textbox on the other form with the corresponding
        'Cell Value.
        frmRegistration.txtid.Text = frmRegistration.dgv.CurrentRow.Cells(0).Value.ToString
        frmRegistration.txtfname.Text = frmRegistration.dgv.CurrentRow.Cells(1).Value.ToString
        frmRegistration.txtsur.Text = frmRegistration.dgv.CurrentRow.Cells(2).Value.ToString


        frmRegistration.cbosex.Text = frmRegistration.dgv.CurrentRow.Cells(3).Value.ToString
        frmRegistration.txtage.Text = frmRegistration.dgv.CurrentRow.Cells(4).Value.ToString
        frmRegistration.cborelate.Text = frmRegistration.dgv.CurrentRow.Cells(5).Value.ToString
        frmRegistration.cboblood.Text = frmRegistration.dgv.CurrentRow.Cells(6).Value.ToString

        frmRegistration.txtweight.Text = frmRegistration.dgv.CurrentRow.Cells(7).Value.ToString
        frmRegistration.cbodisability.Text = frmRegistration.dgv.CurrentRow.Cells(8).Value.ToString
        frmRegistration.txthadd.Text = frmRegistration.dgv.CurrentRow.Cells(9).Value.ToString
        frmRegistration.txtwork.Text = frmRegistration.dgv.CurrentRow.Cells(10).Value.ToString
        frmRegistration.txtkinname.Text = frmRegistration.dgv.CurrentRow.Cells(11).Value.ToString

        frmRegistration.txtkinadd.Text = frmRegistration.dgv.CurrentRow.Cells(12).Value.ToString
        frmRegistration.txtphone.Text = frmRegistration.dgv.CurrentRow.Cells(13).Value.ToString
    End Sub
    Public Sub autocompleteID()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT ID FROM reg"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "reg") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("ID").ToString())

        Next
        frmRegistration.txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmRegistration.txtsearch.AutoCompleteCustomSource = col
        frmRegistration.txtsearch.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
    Sub autocompletFirst_Name()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT First_Name FROM reg"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "reg") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("First_Name").ToString())

        Next
        frmRegistration.txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmRegistration.txtsearch.AutoCompleteCustomSource = col
        frmRegistration.txtsearch.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
    Sub autocompletSurname()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT Surname FROM reg"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "reg") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Surname").ToString())

        Next
        frmRegistration.txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmRegistration.txtsearch.AutoCompleteCustomSource = col
        frmRegistration.txtsearch.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
End Module
