Imports System.Data.OleDb
Imports System.Data.SqlClient
Module Module2
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
    Public Sub clear()
        frmconsultantcy.txtname.Clear()
        frmconsultantcy.txtsur.Clear()
        frmconsultantcy.txthistory.Clear()
        frmconsultantcy.txtid.Clear()
        frmconsultantcy.txtdiagnoses.Clear()
        frmconsultantcy.txtsympton.Clear()
        frmconsultantcy.txttreatment.Clear()
        frmconsultantcy.txtconfirm.Clear()
        frmconsultantcy.txtdoctor.Clear()
    End Sub
    Sub refreshdgv()
        'fill datagridview with data from data base
        Dim sql As String
        sql = "SELECT * FROM reg2"
        Dim da As New OleDbDataAdapter(sql, con)
        Dim dt As New DataTable("reg2")
        da.Fill(dt)
        'assign data source to datagridview
        frmconsultantcy.dgv1.DataSource = dt
    End Sub
    Public Sub confirmation()
        Dim sqlQRY As String = "SELECT * FROM reg WHERE ID = " & frmconsultantcy.txtconfirm.Text

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
                frmconsultantcy.txtid.Text = row("ID")
                frmconsultantcy.txtname.Text = row("First_name")
                frmconsultantcy.txtsur.Text = row("Surname")
                frmconsultantcy.txtage.Text = row("Age")
            Next row
        Catch ex As OleDbException
            MsgBox("Error: " & ex.ToString & vbCrLf)
        Finally
            ' Close connection
            con.Close()
        End Try
    End Sub
    Sub dgv1click()
        ' What this does is when the User selects a record in the DataGridView
        ' it will populate the textbox on the other form with the corresponding
        'Cell Value.
        frmconsultantcy.txtid.Text = frmconsultantcy.dgv1.CurrentRow.Cells(0).Value.ToString
        frmconsultantcy.txtname.Text = frmconsultantcy.dgv1.CurrentRow.Cells(1).Value.ToString
        frmconsultantcy.txtsur.Text = frmconsultantcy.dgv1.CurrentRow.Cells(2).Value.ToString
        frmconsultantcy.txtage.Text = frmconsultantcy.dgv1.CurrentRow.Cells(3).Value.ToString
        frmconsultantcy.txthistory.Text = frmconsultantcy.dgv1.CurrentRow.Cells(4).Value.ToString
        frmconsultantcy.txtdiagnoses.Text = frmconsultantcy.dgv1.CurrentRow.Cells(5).Value.ToString
        frmconsultantcy.txtsympton.Text = frmconsultantcy.dgv1.CurrentRow.Cells(6).Value.ToString
        frmconsultantcy.txttreatment.Text = frmconsultantcy.dgv1.CurrentRow.Cells(7).Value.ToString
        frmconsultantcy.txtdoctor.Text = frmconsultantcy.dgv1.CurrentRow.Cells(8).Value.ToString
        frmconsultantcy.dtp.Text = frmconsultantcy.dgv1.CurrentRow.Cells(9).Value.ToString
    End Sub
    Sub disable()
        frmconsultantcy.btncofirm.Enabled = True
        frmconsultantcy.btnsave.Enabled = False
        frmconsultantcy.btndelete.Enabled = True
        frmconsultantcy.btnclear.Enabled = True
    End Sub
    Public Sub autocompleteID()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT patientid FROM reg2"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "reg2") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("patientid").ToString())

        Next
        frmconsultantcy.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmconsultantcy.txtseacrh.AutoCompleteCustomSource = col
        frmconsultantcy.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
    Sub autocompletFirst_Name()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT First_name FROM reg2"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "reg2") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("First_name").ToString())

        Next
        frmconsultantcy.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmconsultantcy.txtseacrh.AutoCompleteCustomSource = col
        frmconsultantcy.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
    Sub autocompletSurname()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT Surname FROM reg2"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "reg2") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Surname").ToString())

        Next
        frmconsultantcy.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmconsultantcy.txtseacrh.AutoCompleteCustomSource = col
        frmconsultantcy.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
End Module
