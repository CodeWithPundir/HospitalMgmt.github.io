Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class frmRegistration
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\databank1.mdb")
    Dim DataSet1 As New DataSet
    Dim DataAdapter1 As New OleDbDataAdapter
    Dim CMD As New OleDbCommand
    Public Sub FillDGV()
        DataAdapter1 = New OleDbDataAdapter("Select * From reg", con)
        DataSet1.Clear()
        DataAdapter1.Fill(DataSet1, "reg")
        dgv.DataSource = DataSet1
        dgv.DataMember = "reg"
        Call Module1.refreshdgv()
    End Sub

    Private Sub frmRegistration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '===============================================================================================================
        Me.CenterToScreen()
        con.Open()
        Call FillDGV()
        'txtid.DataBindings.Add("Text", DataSet1, "reg.ID")
        'txtfname.DataBindings.Add("Text", DataSet1, "reg.First_Name")
        'txtsur.DataBindings.Add("Text", DataSet1, "reg.Surname")
        'dtpbio.DataBindings.Add("Text", DataSet1, "reg.DOB")
        'cbosex.DataBindings.Add("Text", DataSet1, "reg.Sex")
        'txtage.DataBindings.Add("Text", DataSet1, "reg.Age")
        'cborelate.DataBindings.Add("Text", DataSet1, "reg.Marital_Status")
        'cboblood.DataBindings.Add("Text", DataSet1, "reg.BloodGroup")
        'txtweight.DataBindings.Add("Text", DataSet1, "reg.BodyWeight")
        'cbodisability.DataBindings.Add("Text", DataSet1, "reg.Disability")
        'txthadd.DataBindings.Add("Text", DataSet1, "reg.Home_Address")
        'txtwork.DataBindings.Add("Text", DataSet1, "reg.Work_Address")

        'txtkinname.DataBindings.Add("Text", DataSet1, "reg.Kin_Name")
        'txtkinadd.DataBindings.Add("Text", DataSet1, "reg.Kin_Address")
        'txtphone.DataBindings.Add("Text", DataSet1, "reg.Kin_Phone")

        Call Module1.refreshdgv()
        ' This is our DataAdapter. This executes our SQL Statement above against the Database
        Dim sql As String
        sql = "SELECT * FROM reg"
        Dim da As New OleDbDataAdapter(sql, con)
        Dim dt As New DataTable("reg")
        da.Fill(dt)
        'assign data source to datagridview
        dgv.DataSource = dt
        '=================================================================================================================
        'load various items into combox
        cboblood.Items.Add("A+")
        cboblood.Items.Add("B+")
        cboblood.Items.Add("O+")
        cboblood.Items.Add("AB+")
        'load disability items
        cbodisability.Items.Add("Yes")
        cbodisability.Items.Add("No")
        'load status items
        cborelate.Items.Add("Single")
        cborelate.Items.Add("Married")
        cborelate.Items.Add("Widow")
        cborelate.Items.Add("Divorced")
        'load search items
        cbosearch.Items.Add("ID")
        cbosearch.Items.Add("First_Name")
        cbosearch.Items.Add("Surname")
        'load sex
        cbosex.Items.Add("Male")
        cbosex.Items.Add("Female")
        '=======================

        CMD.CommandType = CommandType.Text
        CMD.Connection = con
        'close connection
        con.Close()
    End Sub
    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim sqlinsert As String
        'calculate patients ageautomatically
        'check if an important field is missing
        If txtsur.Text = "" Or txtfname.Text = "" Then
            MsgBox("Important fileds missing", MsgBoxStyle.Exclamation, "Notification")

        Else
            Dim sql As String
            'check to see if a record exists with already existing name
            sql = "SELECT * FROM reg WHERE surname ='" & Trim(txtid.Text) & "'"
            Dim da As New OleDbDataAdapter(sql, con)
            Dim dt As New DataTable("reg")
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                MsgBox("Patient with " & Trim(txtid.Text) & " already exist in database, please assign a different ID", MsgBoxStyle.OkOnly, "Message :")
                txtid.Clear()
            Else

                sqlinsert = "INSERT INTO reg(First_Name,Surname,sex,Age,Marital_Status,BloodGroup,BodyWeight,Disability,Home_Address,Work_Address,Kin_Name,Kin_Address,Kin_Phone)" & _
                "VALUES(@First_Name,@Surname,@Sex,@Age,@Marital_Status,@BloodGroup,@BodyWeight,@Disability,@Home_Address,@Work_Address,@Kin_Name,@KIn_Address,@Kin_Phone)"

                'assign values to coloum in data base
                Dim cmd As New OleDbCommand(sqlinsert, con)

                'ensure that correct values are written to correct coloum
                cmd.Parameters.Add(New OleDbParameter("@First_Name", txtfname.Text))
                cmd.Parameters.Add(New OleDbParameter("@Surname", txtsur.Text))
                cmd.Parameters.Add(New OleDbParameter("@sex", cbosex.Text))
                cmd.Parameters.Add(New OleDbParameter("@Age", txtage.Text))
                cmd.Parameters.Add(New OleDbParameter("@Marital_Status", cborelate.Text))
                cmd.Parameters.Add(New OleDbParameter("@BloodGroup", cboblood.Text))
                cmd.Parameters.Add(New OleDbParameter("@BodyWeight", txtweight.Text))
                cmd.Parameters.Add(New OleDbParameter("@Disability", cbodisability.Text))
                cmd.Parameters.Add(New OleDbParameter("@Home_Address", txthadd.Text))
                cmd.Parameters.Add(New OleDbParameter("@Work_Address", txtwork.Text))
                cmd.Parameters.Add(New OleDbParameter("@Kin_Name", txtkinname.Text))
                cmd.Parameters.Add(New OleDbParameter("@Kin_Address", txtkinadd.Text))
                cmd.Parameters.Add(New OleDbParameter("@Kin_Phone", txtphone.Text))
                'open the connection, execute the command and then close the connection
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                'call autoID generation
                Call Module1.AutoNumberNo()
                'refresh DataGridView
                Call Module1.refreshdgv()
                'clear each textboxes for new entries
                Call Module1.clear()
                'set focus on first entry
                txtfname.Focus()
            End If
        End If

    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        'check to see if important fields needed for update is missing
        If txtfname.Text = "" Or txtsur.Text = "" Then
            MsgBox("Important fields needed toexecute delete command missing", MsgBoxStyle.Critical, "Notification")
        End If
        '============================================================================================================
        ' Here we use the UPDATE Statement to update the information. To be sure we are 
        ' updating the right record we also use the WHERE clause to be sure no information
        ' is added or changed in the other
        Dim sqlupdate As String
        If MsgBox("Are you sure you want to edit data, edited data will be updated in the database", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Notification") = MsgBoxResult.Yes Then
            '==========================================================================================================
            'sql statement for update
            sqlupdate = "UPDATE reg SET First_name = '" & txtfname.Text & "', Surname = '" & txtsur.Text & "', sex = '" & cbosex.Text & "', Age = '" & txtage.Text & "', Marital_Status='" & cborelate.Text & "', BloodGroup='" & cboblood.Text & "', BodyWeight ='" & txtweight.Text & "', Disability='" & cbodisability.Text & "', Home_Address='" & txthadd.Text & "', Work_Address='" & txtwork.Text & "', Kin_Name='" & txtkinname.Text & "', Kin_Address='" & txtkinadd.Text & "', Kin_Phone='" & txtphone.Text & "' WHERE ID = " & Integer.Parse(txtid.Text)
            Dim cmd As New OleDbCommand(sqlupdate, con)
            ' This assigns the values for our columns in the DataBase. 
            ' To ensure the correct values are written to the correct column
            cmd.Parameters.Add(New OleDbParameter("@ID", txtid.Text))
            cmd.Parameters.Add(New OleDbParameter("@First_Name", txtfname.Text))
            cmd.Parameters.Add(New OleDbParameter("@Surname", txtsur.Text))

            cmd.Parameters.Add(New OleDbParameter("@sex", cbosex.Text))
            cmd.Parameters.Add(New OleDbParameter("@Age", txtage.Text))
            cmd.Parameters.Add(New OleDbParameter("@Marital_Status", cborelate.Text))
            cmd.Parameters.Add(New OleDbParameter("@BloodGroup", cboblood.Text))
            cmd.Parameters.Add(New OleDbParameter("@BodyWeight", txtweight.Text))
            cmd.Parameters.Add(New OleDbParameter("@Disability", cbodisability.Text))
            cmd.Parameters.Add(New OleDbParameter("@Home_Address", txthadd.Text))
            cmd.Parameters.Add(New OleDbParameter("@Work_Address", txtwork.Text))
            cmd.Parameters.Add(New OleDbParameter("@Kin_Name", txtkinname.Text))
            cmd.Parameters.Add(New OleDbParameter("@Kin_Address", txtkinadd.Text))
            cmd.Parameters.Add(New OleDbParameter("@Kin_Phone", txtphone.Text))
            ' This is what actually writes our changes to the DataBase.
            ' You have to open the connection, execute the commands and
            ' then close connection.
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            ' This are subs in Module1, to clear all the TextBoxes on the form
            Call Module1.clear()
            ' and refresh the DataGridView on the MainForm to show our new records.
            Call Module1.refreshdgv()
            '=================================================================================================================
        ElseIf MsgBox("Are you sure you want to edit data, edited data will be updated in the database", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Notification") = MsgBoxResult.No Then
            ' This are subs in Module1, to clear all the TextBoxes on the form
            Call Module1.clear()
            ' and refresh the DataGridView on the MainForm to show our new records.
            Call Module1.refreshdgv()
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        ' We use the WHERE to be sure only that record that the user has selected is deleted.
        If txtfname.Text = "" Or txtsur.Text = "" Then
            MsgBox("Important fields needed to execute delete command missing", MsgBoxStyle.Critical, "Notification")
        End If
        '====================================================================================================
        Dim sqldelete As String
        'confirm if user is to be really deleted from database

        If MsgBox("Are you sure want to permanently delete user from database?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            sqldelete = "DELETE * FROM reg WHERE First_Name ='" & dgv.CurrentRow.Cells(1).Value.ToString & "'"
            ' This is our DataAdapter. This executes our SQL Statement above against the Database
            ' we defined in the Connection String
            Dim adapter As New OleDbDataAdapter(sqldelete, con)
            ' Gets the records from the table and fills our adapter with those.
            Dim dt As New DataTable("reg")
            adapter.Fill(dt)
            ' Assigns the edited DataSource on the DataGridView and the refreshes the 
            ' view to ensure everything is up to date in real time.
            dgv.DataSource = dt
            'confirm that record is deleted
            MsgBox("Record Deleted", MsgBoxStyle.Information, "Medical Notification")
            ' This is a Sub in Module 1 to refresh the DataGridView when information is added,
            '  updated, or deleted.
            Call Module1.refreshdgv()
            Call Module1.clear()
        ElseIf MsgBox("Are you sure want to permanently delete user from database?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.No Then
            Call Module1.refreshdgv()
            Call Module1.clear()
        End If
        If dgv.CurrentRow.Cells(0).ToString Then
            MsgBox("No record in database to delete", MsgBoxStyle.Information, "Notification")
        End If
    End Sub

    Private Sub dgv_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        'Call Module1.dgvclick()
    End Sub

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        If txtsearch.Text = "" Then

            MsgBox("Enter the field u would like to search for", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End If
        If cbosearch.Text = "Surname" Then
            Call Module1.autocompletSurname()
            DataAdapter1 = New OleDbDataAdapter("Select * From reg Where " & cbosearch.Text & " like '%" & Trim$(txtsearch.Text) & "'", con)

        ElseIf cbosearch.Text = "ID" Then
            Call Module1.autocompleteID()
            DataAdapter1 = New OleDbDataAdapter("Select * From reg Where " & cbosearch.Text & " like '%" & Trim$(txtsearch.Text) & "'", con)

        ElseIf cbosearch.Text = "First_Name" Then
            Call Module1.autocompletFirst_Name()
            DataAdapter1 = New OleDbDataAdapter("Select * From reg Where " & cbosearch.Text & " like '%" & Trim$(txtsearch.Text) & "'", con)

        Else
            MsgBox("Patient with" & txtsearch.Text & "does not exist in the database", MsgBoxStyle.Information, "Notidication")
        End If
        DataSet1.Clear()
        DataAdapter1.Fill(DataSet1, "reg")
        dgv.DataSource = DataSet1
        dgv.DataMember = "reg"

    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Call Module1.dgvclick()
    End Sub

 
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Call Module1.refreshdgv()
        Call Module1.clear()
        txtfname.Focus()
    End Sub

    Private Sub ConsultancyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultancyToolStripMenuItem.Click
        frmconsultlogin.Show()
    End Sub

    Private Sub XRayCheckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XRayCheckToolStripMenuItem.Click
        frmxraylogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Are you sure to want to exit Mediksys", MsgBoxStyle.YesNo, "Notification") = MsgBoxResult.Yes Then
            End
        ElseIf MsgBox("Are you sure to want to exit Mediksys", MsgBoxStyle.YesNo, "Notification") = MsgBoxResult.No Then
            Exit Sub
        End If
        Exit Sub
    End Sub

    Private Sub btndone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndone.Click
        With frmregreport

            If ChkPrintAll.Checked = False Then
                If txtfname.Text = "" Then
                    MsgBox("Please select a product to print.", MsgBoxStyle.Critical)

                    Exit Sub
                End If
                .strReport = "Filter"

                .strWhere = "{reg.ID} = " & txtid.Text
            Else
                .strReport = "Print All"
            End If

            frmregreport.ShowDialog()
        End With
    End Sub

    Private Sub grpbtn_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpbtn.Enter

    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        frmhelp.Show()
    End Sub

    Private Sub LabTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabTestToolStripMenuItem.Click
        frmlablogin.Show()
    End Sub

    Private Sub DentalCheckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DentalCheckToolStripMenuItem.Click
        frmdentallogin.Show()
    End Sub

    Private Sub EyeCheckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EyeCheckToolStripMenuItem.Click
        frmeyelogin.Show()
    End Sub
End Class