Imports System.Data.OleDb
Imports System.Data.SqlClient
Module Modulelab
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
    Sub refreshdgv()
        'fill datagridview with data from data base
        Dim sql As String
        sql = "SELECT * FROM reglab"
        Dim da As New OleDbDataAdapter(sql, con)
        Dim dt As New DataTable("reglab")
        da.Fill(dt)
        'assign data source to datagridview
        frmlab.dgv1.DataSource = dt
    End Sub
    Public Sub clear()
        frmlab.txtid.Clear()
        frmlab.txtname.Clear()
        frmlab.txtsur.Clear()
        frmlab.txtage.Clear()
        frmlab.txtdoctor.Clear()
        frmlab.txtseacrh.Clear()
        frmlab.chkbio.Checked = False
        frmlab.chkblood.Checked = False
        frmlab.chkcolon.Checked = False
        frmlab.chkecg.Checked = False
        frmlab.chkgas.Checked = False
        frmlab.chksonography.Checked = False
        frmlab.chkstool.Checked = False
        frmlab.chkurine.Checked = False
        frmlab.txtothers.Clear()
        frmlab.txtremark.Clear()
    End Sub
    Public Sub confirmation()
        Dim sqlQRY As String = "SELECT * FROM reg WHERE ID = " & frmlab.txtconfirm.Text

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
                frmlab.txtid.Text = row("ID")
                frmlab.txtname.Text = row("First_name")
                frmlab.txtsur.Text = row("Surname")
                frmlab.txtage.Text = row("Age")
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
        frmlab.txtid.Text = frmlab.dgv1.CurrentRow.Cells(0).Value.ToString
        frmlab.txtname.Text = frmlab.dgv1.CurrentRow.Cells(1).Value.ToString
        frmlab.txtsur.Text = frmlab.dgv1.CurrentRow.Cells(2).Value.ToString
        frmlab.txtage.Text = frmlab.dgv1.CurrentRow.Cells(3).Value.ToString
        frmlab.chkbio.Checked = frmlab.dgv1.CurrentRow.Cells(4).Value.ToString
        frmlab.chkstool.Checked = frmlab.dgv1.CurrentRow.Cells(5).Value.ToString
        frmlab.chkblood.Checked = frmlab.dgv1.CurrentRow.Cells(6).Value.ToString
        frmlab.chkcolon.Checked = frmlab.dgv1.CurrentRow.Cells(7).Value.ToString
        frmlab.chkgas.Checked = frmlab.dgv1.CurrentRow.Cells(8).Value.ToString
        frmlab.chkurine.Checked = frmlab.dgv1.CurrentRow.Cells(9).Value.ToString
        frmlab.chksonography.Checked = frmlab.dgv1.CurrentRow.Cells(10).Value.ToString
        frmlab.chkecg.Checked = frmlab.dgv1.CurrentRow.Cells(11).Value.ToString
        frmlab.txtothers.Text = frmlab.dgv1.CurrentRow.Cells(12).Value.ToString
        frmlab.txtdiagnosis.Text = frmlab.dgv1.CurrentRow.Cells(13).Value.ToString
        frmlab.txtremark.Text = frmlab.dgv1.CurrentRow.Cells(14).Value.ToString
        frmlab.dtp.Text = frmlab.dgv1.CurrentRow.Cells(15).Value.ToString
        frmlab.txtdoctor.Text = frmlab.dgv1.CurrentRow.Cells(16).Value.ToString
    End Sub
    Sub disable()
        frmlab.btnconfirm.Enabled = True
        frmlab.btnsave.Enabled = False
        frmlab.btndelete.Enabled = True
        frmlab.btnclear.Enabled = True
    End Sub
    Public Sub autocompleteID()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT patientid FROM reglab"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "reglab") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("patientid").ToString())

        Next
        frmlab.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmlab.txtseacrh.AutoCompleteCustomSource = col
        frmlab.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
    Sub autocompletFirst_Name()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT First_name FROM reglab"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "reglab") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("First_name").ToString())

        Next
        frmlab.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmlab.txtseacrh.AutoCompleteCustomSource = col
        frmlab.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub
    Sub autocompletSurname()
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
        'Automatically fill detect similar names so as to enable user perform a quick search
        Dim sql As String
        con.Open()
        sql = "SELECT Surname FROM reglab"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "reglab") 'list can be any id u want

        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Surname").ToString())

        Next
        frmlab.txtseacrh.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmlab.txtseacrh.AutoCompleteCustomSource = col
        frmlab.txtseacrh.AutoCompleteMode = AutoCompleteMode.Suggest
        con.Close()
    End Sub

End Module
