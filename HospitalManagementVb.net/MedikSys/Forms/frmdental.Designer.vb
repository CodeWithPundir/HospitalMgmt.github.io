<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdental
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdental))
        Me.txtconfirm = New System.Windows.Forms.TextBox
        Me.cbosearch = New System.Windows.Forms.ComboBox
        Me.txtseacrh = New System.Windows.Forms.TextBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btncofirm = New System.Windows.Forms.Button
        Me.txtsur = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.cboconfirm = New System.Windows.Forms.ComboBox
        Me.txtid = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtp = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtdoctor = New System.Windows.Forms.TextBox
        Me.txttreatment = New System.Windows.Forms.TextBox
        Me.txtdefect = New System.Windows.Forms.TextBox
        Me.txtdiagnosis = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txthistory = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.grpbtn = New System.Windows.Forms.GroupBox
        Me.btngoto = New System.Windows.Forms.Button
        Me.btndone = New System.Windows.Forms.Button
        Me.chkprintall = New System.Windows.Forms.CheckBox
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultancyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LabTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.XRayCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DentalCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EyeCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtage = New System.Windows.Forms.TextBox
        Me.cbocnfirm1 = New System.Windows.Forms.ComboBox
        Me.txtconfirm1 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbtn.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtconfirm
        '
        Me.txtconfirm.Location = New System.Drawing.Point(-95, 235)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.Size = New System.Drawing.Size(79, 20)
        Me.txtconfirm.TabIndex = 62
        '
        'cbosearch
        '
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Location = New System.Drawing.Point(659, 58)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(80, 21)
        Me.cbosearch.TabIndex = 61
        '
        'txtseacrh
        '
        Me.txtseacrh.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.txtseacrh.Location = New System.Drawing.Point(750, 60)
        Me.txtseacrh.Name = "txtseacrh"
        Me.txtseacrh.Size = New System.Drawing.Size(77, 20)
        Me.txtseacrh.TabIndex = 60
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(833, 58)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(72, 23)
        Me.btnsearch.TabIndex = 59
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(326, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Surname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "First name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(194, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Patient ID"
        '
        'btncofirm
        '
        Me.btncofirm.Location = New System.Drawing.Point(84, 65)
        Me.btncofirm.Name = "btncofirm"
        Me.btncofirm.Size = New System.Drawing.Size(75, 23)
        Me.btncofirm.TabIndex = 57
        Me.btncofirm.Text = "Confirmation"
        Me.btncofirm.UseVisualStyleBackColor = True
        '
        'txtsur
        '
        Me.txtsur.Location = New System.Drawing.Point(315, 66)
        Me.txtsur.Name = "txtsur"
        Me.txtsur.Size = New System.Drawing.Size(65, 20)
        Me.txtsur.TabIndex = 56
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(249, 67)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(60, 20)
        Me.txtname.TabIndex = 55
        '
        'cboconfirm
        '
        Me.cboconfirm.FormattingEnabled = True
        Me.cboconfirm.Location = New System.Drawing.Point(-95, 208)
        Me.cboconfirm.Name = "cboconfirm"
        Me.cboconfirm.Size = New System.Drawing.Size(81, 21)
        Me.cboconfirm.TabIndex = 54
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(195, 67)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(46, 20)
        Me.txtid.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Chiller", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(382, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 24)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Dental Consultancy"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtdoctor)
        Me.GroupBox1.Controls.Add(Me.txttreatment)
        Me.GroupBox1.Controls.Add(Me.txtdefect)
        Me.GroupBox1.Controls.Add(Me.txtdiagnosis)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txthistory)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 224)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(310, 178)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(108, 20)
        Me.dtp.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(259, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Doctor"
        '
        'txtdoctor
        '
        Me.txtdoctor.Location = New System.Drawing.Point(64, 178)
        Me.txtdoctor.Name = "txtdoctor"
        Me.txtdoctor.Size = New System.Drawing.Size(72, 20)
        Me.txtdoctor.TabIndex = 10
        '
        'txttreatment
        '
        Me.txttreatment.Location = New System.Drawing.Point(64, 136)
        Me.txttreatment.Multiline = True
        Me.txttreatment.Name = "txttreatment"
        Me.txttreatment.Size = New System.Drawing.Size(357, 32)
        Me.txttreatment.TabIndex = 9
        '
        'txtdefect
        '
        Me.txtdefect.Location = New System.Drawing.Point(64, 95)
        Me.txtdefect.Multiline = True
        Me.txtdefect.Name = "txtdefect"
        Me.txtdefect.Size = New System.Drawing.Size(357, 32)
        Me.txtdefect.TabIndex = 8
        '
        'txtdiagnosis
        '
        Me.txtdiagnosis.Location = New System.Drawing.Point(64, 56)
        Me.txtdiagnosis.Multiline = True
        Me.txtdiagnosis.Name = "txtdiagnosis"
        Me.txtdiagnosis.Size = New System.Drawing.Size(357, 32)
        Me.txtdiagnosis.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Doctor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Treatment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Defect"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "History"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Diagnosis"
        '
        'txthistory
        '
        Me.txthistory.Location = New System.Drawing.Point(65, 16)
        Me.txthistory.Multiline = True
        Me.txthistory.Name = "txthistory"
        Me.txthistory.Size = New System.Drawing.Size(357, 32)
        Me.txthistory.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(439, 87)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(470, 224)
        Me.dgv1.TabIndex = 11
        '
        'grpbtn
        '
        Me.grpbtn.BackColor = System.Drawing.SystemColors.Control
        Me.grpbtn.Controls.Add(Me.btngoto)
        Me.grpbtn.Controls.Add(Me.btndone)
        Me.grpbtn.Controls.Add(Me.chkprintall)
        Me.grpbtn.Controls.Add(Me.btndelete)
        Me.grpbtn.Controls.Add(Me.btnclear)
        Me.grpbtn.Controls.Add(Me.btnsave)
        Me.grpbtn.Controls.Add(Me.btnedit)
        Me.grpbtn.Location = New System.Drawing.Point(183, 314)
        Me.grpbtn.Name = "grpbtn"
        Me.grpbtn.Size = New System.Drawing.Size(548, 106)
        Me.grpbtn.TabIndex = 65
        Me.grpbtn.TabStop = False
        '
        'btngoto
        '
        Me.btngoto.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btngoto.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btngoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btngoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btngoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngoto.ForeColor = System.Drawing.SystemColors.Control
        Me.btngoto.Image = CType(resources.GetObject("btngoto.Image"), System.Drawing.Image)
        Me.btngoto.Location = New System.Drawing.Point(476, 20)
        Me.btngoto.Name = "btngoto"
        Me.btngoto.Size = New System.Drawing.Size(66, 68)
        Me.btngoto.TabIndex = 5
        Me.btngoto.Text = "&Goto"
        Me.btngoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngoto.UseVisualStyleBackColor = False
        '
        'btndone
        '
        Me.btndone.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btndone.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btndone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btndone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndone.ForeColor = System.Drawing.SystemColors.Control
        Me.btndone.Image = CType(resources.GetObject("btndone.Image"), System.Drawing.Image)
        Me.btndone.Location = New System.Drawing.Point(382, 18)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(65, 67)
        Me.btndone.TabIndex = 4
        Me.btndone.Text = "&Print"
        Me.btndone.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndone.UseVisualStyleBackColor = False
        '
        'chkprintall
        '
        Me.chkprintall.AutoSize = True
        Me.chkprintall.Checked = True
        Me.chkprintall.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkprintall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkprintall.Location = New System.Drawing.Point(382, 89)
        Me.chkprintall.Name = "chkprintall"
        Me.chkprintall.Size = New System.Drawing.Size(70, 17)
        Me.chkprintall.TabIndex = 68
        Me.chkprintall.Text = "Print All"
        Me.chkprintall.UseVisualStyleBackColor = True
        Me.chkprintall.Visible = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.Control
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.Location = New System.Drawing.Point(293, 18)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(61, 68)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "&Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.SystemColors.Control
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(200, 17)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(72, 68)
        Me.btnclear.TabIndex = 2
        Me.btnclear.Text = "&Refresh"
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Gray
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(26, 17)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(64, 68)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Gray
        Me.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnedit.Image = CType(resources.GetObject("btnedit.Image"), System.Drawing.Image)
        Me.btnedit.Location = New System.Drawing.Point(117, 18)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(57, 67)
        Me.btnedit.TabIndex = 0
        Me.btnedit.Text = "&Edit"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrationToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(921, 24)
        Me.MenuStrip1.TabIndex = 66
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.ConsultancyToolStripMenuItem, Me.LabTestToolStripMenuItem, Me.XRayCheckToolStripMenuItem, Me.DentalCheckToolStripMenuItem, Me.EyeCheckToolStripMenuItem})
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.AdministrationToolStripMenuItem.Text = "Administration"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'ConsultancyToolStripMenuItem
        '
        Me.ConsultancyToolStripMenuItem.Name = "ConsultancyToolStripMenuItem"
        Me.ConsultancyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ConsultancyToolStripMenuItem.Text = "Consultancy"
        '
        'LabTestToolStripMenuItem
        '
        Me.LabTestToolStripMenuItem.Name = "LabTestToolStripMenuItem"
        Me.LabTestToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.LabTestToolStripMenuItem.Text = "Lab Test"
        '
        'XRayCheckToolStripMenuItem
        '
        Me.XRayCheckToolStripMenuItem.Name = "XRayCheckToolStripMenuItem"
        Me.XRayCheckToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.XRayCheckToolStripMenuItem.Text = "X-Ray Check"
        '
        'DentalCheckToolStripMenuItem
        '
        Me.DentalCheckToolStripMenuItem.Name = "DentalCheckToolStripMenuItem"
        Me.DentalCheckToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DentalCheckToolStripMenuItem.Text = "Dental Check"
        '
        'EyeCheckToolStripMenuItem
        '
        Me.EyeCheckToolStripMenuItem.Name = "EyeCheckToolStripMenuItem"
        Me.EyeCheckToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.EyeCheckToolStripMenuItem.Text = "Eye Check"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(386, 66)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(47, 20)
        Me.txtage.TabIndex = 67
        '
        'cbocnfirm1
        '
        Me.cbocnfirm1.FormattingEnabled = True
        Me.cbocnfirm1.Location = New System.Drawing.Point(12, 44)
        Me.cbocnfirm1.Name = "cbocnfirm1"
        Me.cbocnfirm1.Size = New System.Drawing.Size(62, 21)
        Me.cbocnfirm1.TabIndex = 69
        '
        'txtconfirm1
        '
        Me.txtconfirm1.Location = New System.Drawing.Point(10, 69)
        Me.txtconfirm1.Name = "txtconfirm1"
        Me.txtconfirm1.Size = New System.Drawing.Size(62, 20)
        Me.txtconfirm1.TabIndex = 70
        '
        'frmdental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 425)
        Me.Controls.Add(Me.txtconfirm1)
        Me.Controls.Add(Me.cbocnfirm1)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grpbtn)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtconfirm)
        Me.Controls.Add(Me.cbosearch)
        Me.Controls.Add(Me.txtseacrh)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btncofirm)
        Me.Controls.Add(Me.txtsur)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.cboconfirm)
        Me.Controls.Add(Me.txtid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmdental"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dental Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbtn.ResumeLayout(False)
        Me.grpbtn.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtconfirm As System.Windows.Forms.TextBox
    Friend WithEvents cbosearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtseacrh As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btncofirm As System.Windows.Forms.Button
    Friend WithEvents txtsur As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents cboconfirm As System.Windows.Forms.ComboBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txthistory As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdoctor As System.Windows.Forms.TextBox
    Friend WithEvents txttreatment As System.Windows.Forms.TextBox
    Friend WithEvents txtdefect As System.Windows.Forms.TextBox
    Friend WithEvents txtdiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents grpbtn As System.Windows.Forms.GroupBox
    Friend WithEvents btngoto As System.Windows.Forms.Button
    Friend WithEvents btndone As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultancyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XRayCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DentalCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EyeCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents chkprintall As System.Windows.Forms.CheckBox
    Friend WithEvents cbocnfirm1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtconfirm1 As System.Windows.Forms.TextBox
End Class
