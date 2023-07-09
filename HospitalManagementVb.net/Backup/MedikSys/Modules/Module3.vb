Imports System.Data.OleDb
Imports System.Data.SqlClient
Module Module3
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
    Public Sub clear()
        frmxray.txtid.Clear()
        frmxray.txtname.Clear()
        frmxray.txtsur.Clear()
        frmxray.txtage.Clear()
        frmxray.txtdoctor.Clear()
        frmxray.txtseacrh.Clear()
        frmxray.txtrmk1.Clear()
        frmxray.txtrmk2.Clear()
        frmxray.txtrmk3.Clear()
        frmxray.txtrmk4.Clear()
        frmxray.txtrmk5.Clear()
        frmxray.txtrmk6.Clear()
    End Sub
    Sub refreshdgv()
        'fill datagridview with data from data base
        Dim sql As String
        sql = "SELECT * FROM reg3"
        Dim da As New OleDbDataAdapter(sql, con)
        Dim dt As New DataTable("reg3")
        da.Fill(dt)
        'assign data source to datagridview
        frmxray.dgv1.DataSource = dt
    End Sub
    Public Sub confirmation()
        Dim sqlQRY As String = "SELECT * FROM reg WHERE ID = " & frmxray.txtconfirm.Text

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
                frmxray.txtid.Text = row("ID")
                frmxray.txtname.Text = row("First_name")
                frmxray.txtsur.Text = row("Surname")
                frmxray.txtage.Text = row("Age")
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
        frmxray.txtid.Text = frmxray.dgv1.CurrentRow.Cells(0).Value.ToString
        frmxray.txtname.Text = frmxray.dgv1.CurrentRow.Cells(1).Value.ToString
        frmxray.txtsur.Text = frmxray.dgv1.CurrentRow.Cells(2).Value.ToString
        frmxray.txtage.Text = frmxray.dgv1.CurrentRow.Cells(3).Value.ToString
        frmxray.txtrmk1.Text = frmxray.dgv1.CurrentRow.Cells(4).Value.ToString
        frmxray.txtrmk2.Text = frmxray.dgv1.CurrentRow.Cells(5).Value.ToString
        frmxray.txtrmk3.Text = frmxray.dgv1.CurrentRow.Cells(6).Value.ToString
        frmxray.txtrmk4.Text = frmxray.dgv1.CurrentRow.Cells(7).Value.ToString
        frmxray.txtrmk5.Text = frmxray.dgv1.CurrentRow.Cells(8).Value.ToString
        frmxray.txtrmk6.Text = frmxray.dgv1.CurrentRow.Cells(9).Value.ToString
        frmxray.txtdoctor.Text = frmxray.dgv1.CurrentRow.Cells(10).Value.ToString
        frmxray.dtp.Text = frmxray.dgv1.CurrentRow.Cells(11).Value.ToString
    End Sub
    Sub disable()
        frmxray.btncofirm.Enabled = True
        frmxray.btnsave.Enabled = False
        frmxray.btndelete.Enabled = True
        frmxray.btnclear.Enabled = True
    End Sub
    Public Sub autocompleteID()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT patientid FROM reg3"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "reg3") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("patientid").ToString())

        Next
        frmxray.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmxray.txtseacrh.AutoCompleteCustomSource = col
        frmxray.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
    Sub autocompletFirst_Name()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT First_name FROM reg3"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "reg3") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("First_name").ToString())

        Next
        frmxray.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmxray.txtseacrh.AutoCompleteCustomSource = col
        frmxray.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
    Sub autocompletSurname()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT Surname FROM reg3"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "reg3") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Surname").ToString())

        Next
        frmxray.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmxray.txtseacrh.AutoCompleteCustomSource = col
        frmxray.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub

End Module
