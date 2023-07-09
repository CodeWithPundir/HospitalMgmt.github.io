Public Class frmMainform

    Private Sub RegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationToolStripMenuItem.Click
        Me.Hide()
        frmlogin.Show()
    End Sub

    Private Sub ConsultancyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultancyToolStripMenuItem.Click
        Me.Hide()
        frmconsultlogin.Show()
    End Sub

    Private Sub LabTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabTestToolStripMenuItem.Click
        Me.Hide()
        frmlablogin.Show()
    End Sub

    Private Sub frmMainform_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub

    Private Sub XRayTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XRayTestToolStripMenuItem.Click
        frmxraylogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Exit Sub
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        frmhelp.Show()
    End Sub

    Private Sub EyeCheckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EyeCheckToolStripMenuItem.Click
        frmeyelogin.Show()
    End Sub

    Private Sub DentalCheckToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DentalCheckToolStripMenuItem.Click
        frmdentallogin.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmhelp.Show()
    End Sub
End Class