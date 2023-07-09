Public Class frmconsultlogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtname.Text = "" And txtpassword.Text = "" Then
            MsgBox("Fields missing", MsgBoxStyle.Critical, "Notification")
        ElseIf txtname.Text = "" Then
            MsgBox("Name is missing", MsgBoxStyle.Information, "Notification")
        ElseIf txtpassword.Text = "" Then
            MsgBox("Password iis missing", MsgBoxStyle.Information, "Notification")
        ElseIf txtname.Text = "admin" And txtpassword.Text = "admin" Then
            frmconsultantcy.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password", MsgBoxStyle.Critical, "Access Denied")
        End If
        txtname.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub frmconsultlogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtname.Focus()
        ToolTip1.SetToolTip(txtname, "Enter Username")
        ToolTip1.SetToolTip(txtpassword, "Enter Password")
    End Sub
End Class