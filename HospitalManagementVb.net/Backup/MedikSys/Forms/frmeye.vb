Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class frmeye
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
    Dim DataSet1 As New DataSet
    Dim DataAdapter1 As New OleDbDataAdapter
    Dim CMD As New OleDbCommand
    Public Sub FillDGV()
        DataAdapter1 = New OleDbDataAdapter("Select * From regeye", con)
        DataSet1.Clear()
        DataAdapter1.Fill(DataSet1, "regeye")
        dgv1.DataSource = DataSet1
        dgv1.DataMember = "regeye"
        Call moduleeye.refreshdgv()
    End Sub
    Private Sub frmeye_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CenterToScreen()
        con.Open()
        Call FillDGV()
        Call moduleeye.refreshdgv()
        '============================================================================================================
        ' This is our DataAdapter. This executes our SQL Statement above against the Database
        Dim sql As String
        sql = "SELECT * FROM regeye"
        Dim da As New OleDbDataAdapter(sql, con)
        Dim dt As New DataTable("regeye")
        da.Fill(dt)
        'assign data source to datagridview
        dgv1.DataSource = dt

        'disable all buton to confirm if patient is dully registered

        'load cofirmation combobox with various items
        cboconfirm.Items.Add("patientid")
        cboconfirm.Items.Add("First_name")
        cboconfirm.Items.Add("Surname")
        'load items into search combobox
        cbosearch.Items.Add("patientid")
        cbosearch.Items.Add("First_name")
        cbosearch.Items.Add("surname")
        'disable patientID, name and surname as doctor is not authorised to change this fields
        txtid.Enabled = False
        txtname.Enabled = False
        txtsur.Enabled = False
        'allow only confirmation cutton
        Call moduleeye.disable()
        con.Close()
    End Sub
    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        frmhelp.Show()
    End Sub

    Private Sub AdministrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrationToolStripMenuItem.Click

    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationToolStripMenuItem.Click
        frmlogin.Show()
    End Sub

    Private Sub ConsultancyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultancyToolStripMenuItem.Click
        frmconsultlogin.Show()
    End Sub

    Private Sub LabTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabTestToolStripMenuItem.Click
        frmlablogin.Show()
    End Sub

    Private Sub XRayCheckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XRayCheckToolStripMenuItem.Click
        frmxraylogin.Show()
    End Sub

    Private Sub DentalCheckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DentalCheckToolStripMenuItem.Click
        frmdentallogin.Show()
    End Sub

    Private Sub btncofirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncofirm.Click
        If txtconfirm.Text = "" Then
            MsgBox("Please enter patient Id to be confirmed", MsgBoxStyle.Information, "Notification")
        ElseIf cboconfirm.Text = "patientid" Then
            Call moduleeye.confirmation()
            btnsave.Enabled = True
        Else
            MsgBox("Record is not in the data base", MsgBoxStyle.Information, "Notification")
            btnsave.Enabled = False
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim sqlinsert As String
        'check if an important field is missing
        If txtsur.Text = "" Or txtname.Text = "" Or txtid.Text = "" Then
            MsgBox("Important fileds missing", MsgBoxStyle.Exclamation, "Notification")
        Else
            Dim sql As String
            'check to see if a record exists with already existing name
            sql = "SELECT * FROM regeye WHERE patientid ='" & Trim(txtid.Text) & "'"
            Dim da As New OleDbDataAdapter(sql, con)
            Dim dt As New DataTable("regeye")
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                MsgBox("Patient with " & Trim(txtid.Text) & " already exist in database, please assign a different ID", MsgBoxStyle.OkOnly, "Message :")
                txtid.Clear()
            Else

                sqlinsert = "INSERT INTO regeye(patientid,First_name,surname,Age,History,Diagnosis,Defect,treatment,Spectacle,Doctor,date_date)" & _
                "VALUES(@patientid,@First_name,@surname,@Age,@History,@Diagnosis,@Defect,@treatment,@Spectacle,@Doctor,@date_date)"

                'assign values to coloum in data base
                Dim cmd As New OleDbCommand(sqlinsert, con)

                'ensure that correct values are written to correct coloum
                cmd.Parameters.Add(New OleDbParameter("@patientid", txtid.Text))
                cmd.Parameters.Add(New OleDbParameter("@First_name", txtname.Text))
                cmd.Parameters.Add(New OleDbParameter("@surname", txtsur.Text))
                cmd.Parameters.Add(New OleDbParameter("@Age", txtage.Text))
                cmd.Parameters.Add(New OleDbParameter("@History", txthistory.Text))
                cmd.Parameters.Add(New OleDbParameter("@Diagnosis", txtdiagnosis.Text))
                cmd.Parameters.Add(New OleDbParameter("@Defect", txtdefect.Text))
                cmd.Parameters.Add(New OleDbParameter("@treatment", txttreatment.Text))
                cmd.Parameters.Add(New OleDbParameter("@Spectacle", txtseacrh.Text))
                cmd.Parameters.Add(New OleDbParameter("@Doctor", txtdoctor.Text))
                cmd.Parameters.Add(New OleDbParameter("@Date_date", dtp.Text))

                'open the connection, execute the command and then close the connection
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                'call autoID generation
                'refresh DataGridView
                Call moduleeye.refreshdgv()
                'clear each textboxes for new entries
                Call moduleeye.clear()
                'set focus on first entry
                txtname.Focus()
                Call moduleeye.disable()
            End If
        End If
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        'check to see if important fields needed for update is missing
        If txtname.Text = "" Or txtsur.Text = "" Then
            MsgBox("Important fields needed to execute delete command missing", MsgBoxStyle.Critical, "Notification")
        End If
        '============================================================================================================
        ' Here we use the UPDATE Statement to update the information. To be sure we are 
        ' updating the right record we also use the WHERE clause to be sure no information
        ' is added or changed in the other
        Dim sqlupdate As String
        If MsgBox("Are you sure you want to edit data, edited data will be updated in the database", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Notification") = MsgBoxResult.Yes Then
            '==========================================================================================================
            'sql statement for update
            sqlupdate = "UPDATE regeye SET First_name='" & txtname.Text & "', surname = '" & txtsur.Text & "',Age = '" & txtage.Text & "', History = '" & txthistory.Text & "', diagnosis = '" & txtdiagnosis.Text & "', Defect = '" & txtdefect.Text & "', treatment='" & txttreatment.Text & "', Spectacle='" & txtspectacle.Text & "', Doctor ='" & txtdoctor.Text & "',date_date='" & dtp.Text & "' WHERE patientid ='" & (txtid.Text).ToString & "'"
            Dim cmd As New OleDbCommand(sqlupdate, con)
            ' This assigns the values for our columns in the DataBase. 
            ' To ensure the correct values are written to the correct column
            cmd.Parameters.Add(New OleDbParameter("@patientid", txtid.Text))
            cmd.Parameters.Add(New OleDbParameter("@First_name", txtname.Text))
            cmd.Parameters.Add(New OleDbParameter("@surname", txtsur.Text))
            cmd.Parameters.Add(New OleDbParameter("@Age", txtage.Text))
            cmd.Parameters.Add(New OleDbParameter("@History", txthistory.Text))
            cmd.Parameters.Add(New OleDbParameter("@diagnosis", txtdiagnosis.Text))
            cmd.Parameters.Add(New OleDbParameter("@Defect", txtdefect.Text))
            cmd.Parameters.Add(New OleDbParameter("@treatment", txttreatment.Text))
            cmd.Parameters.Add(New OleDbParameter("@Spectacle", txtspectacle.Text))
            cmd.Parameters.Add(New OleDbParameter("@Doctor", txtdoctor.Text))
            cmd.Parameters.Add(New OleDbParameter("@Date_date", dtp.Text))

            ' This is what actually writes our changes to the DataBase.
            ' You have to open the connection, execute the commands and
            ' then close connection.
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            ' This are subs in Module1, to clear all the TextBoxes on the form
            Call moduleeye.clear()
            ' and refresh the DataGridView on the MainForm to show our new records.
            Call moduleeye.refreshdgv()
            '=================================================================================================================
        ElseIf MsgBox("Are you sure you want to edit data, edited data will be updated in the database", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Notification") = MsgBoxResult.No Then
            ' This are subs in Module1, to clear all the TextBoxes on the form
            Call moduleeye.clear()
            ' and refresh the DataGridView on the MainForm to show our new records.
            Call moduleeye.refreshdgv()
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        ' We use the WHERE to be sure only that record that the user has selected is deleted.
        If txtname.Text = "" Or txtsur.Text = "" Or txtid.Text = "" Then
            MsgBox("Important fields needed to execute delete command missing", MsgBoxStyle.Critical, "Notification")
        End If
        '====================================================================================================
        Dim sqldelete As String
        'confirm if user is to be really deleted from database

        If MsgBox("Are you sure want to permanently delete user from database?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            sqldelete = "DELETE * FROM regeye WHERE First_Name ='" & dgv1.CurrentRow.Cells(1).Value.ToString & "'"
            ' This is our DataAdapter. This executes our SQL Statement above against the Database
            ' we defined in the Connection String
            Dim adapter As New OleDbDataAdapter(sqldelete, con)
            ' Gets the records from the table and fills our adapter with those.
            Dim dt As New DataTable("regeye")
            adapter.Fill(dt)
            ' Assigns the edited DataSource on the DataGridView and the refreshes the 
            ' view to ensure everything is up to date in real time.
            dgv1.DataSource = dt
            'confirm that record is deleted
            MsgBox("Record Deleted", MsgBoxStyle.Information, "Medical Notification")
            ' This is a Sub in Module 1 to refresh the DataGridView when information is added,
            '  updated, or deleted.
            Call moduleeye.refreshdgv()
            Call moduleeye.clear()
            Call moduleeye.disable()
        ElseIf MsgBox("Are you sure want to permanently delete user from database?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.No Then
            Call moduleeye.refreshdgv()
            Call moduleeye.clear()
        End If
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Call moduleeye.refreshdgv()
        Call moduleeye.clear()
        txthistory.Focus()
    End Sub

    Private Sub dgv1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellClick
        Call moduleeye.dgv1click()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If txtseacrh.Text = "" Then

            MsgBox("Enter the field u would like to search for", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End If
        If cbosearch.Text = "surname" Then
            Call moduleeye.autocompletSurname()
            DataAdapter1 = New OleDbDataAdapter("Select * From regdental Where " & cbosearch.Text & " like '%" & Trim$(txtseacrh.Text) & "'", con)

        ElseIf cbosearch.Text = "patientid" Then
            Call moduleeye.autocompleteID()
            DataAdapter1 = New OleDbDataAdapter("Select * From regdental Where " & cbosearch.Text & " like '%" & Trim$(txtseacrh.Text) & "'", con)

        ElseIf cbosearch.Text = "First_name" Then
            Call moduleeye.autocompletFirst_Name()
            DataAdapter1 = New OleDbDataAdapter("Select * From regdental Where " & cbosearch.Text & " like '%" & Trim$(txtseacrh.Text) & "'", con)

        Else
            MsgBox("Patient with" & txtseacrh.Text & "does not exist in the database", MsgBoxStyle.Information, "Notidication")
        End If
        DataSet1.Clear()
        DataAdapter1.Fill(DataSet1, "regeye")
        dgv1.DataSource = DataSet1
        dgv1.DataMember = "regeye"
    End Sub

    Private Sub btndone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndone.Click
        With frmeyereport

            If chkprintall.Checked = False Then
                If txtname.Text = "" Then
                    MsgBox("Please select a product to print.", MsgBoxStyle.Critical)

                    Exit Sub
                End If
                .strReport = "Filter"

                .strWhere = "{regeye.patientid} = " & txtid.Text
            Else
                .strReport = "Print All"
            End If

            frmeyereport.ShowDialog()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Are you sure to want to exit Mediksys", MsgBoxStyle.YesNo, "Notification") = MsgBoxResult.Yes Then
            End
        ElseIf MsgBox("Are you sure to want to exit Mediksys", MsgBoxStyle.YesNo, "Notification") = MsgBoxResult.No Then
            Exit Sub
        End If
        Exit Sub
    End Sub
End Class