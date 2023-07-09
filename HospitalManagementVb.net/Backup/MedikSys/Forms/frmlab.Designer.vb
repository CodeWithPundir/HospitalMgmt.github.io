<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlab))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtconfirm = New System.Windows.Forms.TextBox
        Me.btnconfirm = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AdiminstratioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LabTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.XRayCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DentalCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EyeCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtid = New System.Windows.Forms.TextBox
        Me.txtothers = New System.Windows.Forms.TextBox
        Me.txtremark = New System.Windows.Forms.TextBox
        Me.txtdiagnosis = New System.Windows.Forms.TextBox
        Me.txtage = New System.Windows.Forms.TextBox
        Me.txtsur = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.cboconfirm = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtdoctor = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtp = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chksonography = New System.Windows.Forms.CheckBox
        Me.chkurine = New System.Windows.Forms.CheckBox
        Me.chkgas = New System.Windows.Forms.CheckBox
        Me.chkcolon = New System.Windows.Forms.CheckBox
        Me.chkecg = New System.Windows.Forms.CheckBox
        Me.chkblood = New System.Windows.Forms.CheckBox
        Me.chkstool = New System.Windows.Forms.CheckBox
        Me.chkbio = New System.Windows.Forms.CheckBox
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.cbosearch = New System.Windows.Forms.ComboBox
        Me.txtseacrh = New System.Windows.Forms.TextBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.grpbtn = New System.Windows.Forms.GroupBox
        Me.btngoto = New System.Windows.Forms.Button
        Me.btndone = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.ChkPrintAll = New System.Windows.Forms.CheckBox
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(300, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Other test"
        '
        'txtconfirm
        '
        Me.txtconfirm.Location = New System.Drawing.Point(12, 80)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.Size = New System.Drawing.Size(81, 20)
        Me.txtconfirm.TabIndex = 1
        '
        'btnconfirm
        '
        Me.btnconfirm.Location = New System.Drawing.Point(99, 78)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(75, 27)
        Me.btnconfirm.TabIndex = 2
        Me.btnconfirm.Text = "Confirmation"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdiminstratioToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1006, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdiminstratioToolStripMenuItem
        '
        Me.AdiminstratioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.CoToolStripMenuItem, Me.LabTestToolStripMenuItem, Me.XRayCheckToolStripMenuItem, Me.DentalCheckToolStripMenuItem, Me.EyeCheckToolStripMenuItem})
        Me.AdiminstratioToolStripMenuItem.Name = "AdiminstratioToolStripMenuItem"
        Me.AdiminstratioToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.AdiminstratioToolStripMenuItem.Text = "Administraion"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'CoToolStripMenuItem
        '
        Me.CoToolStripMenuItem.Name = "CoToolStripMenuItem"
        Me.CoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CoToolStripMenuItem.Text = "Consultancy"
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
        Me.XRayCheckToolStripMenuItem.Text = "X-Ray check"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Patient Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "First name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Surname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(417, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Age"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Chiller", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(438, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Lab Test"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Diagnosis"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(180, 80)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(67, 20)
        Me.txtid.TabIndex = 10
        '
        'txtothers
        '
        Me.txtothers.Location = New System.Drawing.Point(364, 16)
        Me.txtothers.Multiline = True
        Me.txtothers.Name = "txtothers"
        Me.txtothers.Size = New System.Drawing.Size(93, 48)
        Me.txtothers.TabIndex = 11
        '
        'txtremark
        '
        Me.txtremark.Location = New System.Drawing.Point(76, 167)
        Me.txtremark.Multiline = True
        Me.txtremark.Name = "txtremark"
        Me.txtremark.Size = New System.Drawing.Size(387, 37)
        Me.txtremark.TabIndex = 12
        '
        'txtdiagnosis
        '
        Me.txtdiagnosis.Location = New System.Drawing.Point(76, 141)
        Me.txtdiagnosis.Name = "txtdiagnosis"
        Me.txtdiagnosis.Size = New System.Drawing.Size(100, 20)
        Me.txtdiagnosis.TabIndex = 13
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(397, 80)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(67, 20)
        Me.txtage.TabIndex = 14
        '
        'txtsur
        '
        Me.txtsur.Location = New System.Drawing.Point(325, 80)
        Me.txtsur.Name = "txtsur"
        Me.txtsur.Size = New System.Drawing.Size(67, 20)
        Me.txtsur.TabIndex = 15
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(253, 80)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(67, 20)
        Me.txtname.TabIndex = 16
        '
        'cboconfirm
        '
        Me.cboconfirm.FormattingEnabled = True
        Me.cboconfirm.Location = New System.Drawing.Point(12, 52)
        Me.cboconfirm.Name = "cboconfirm"
        Me.cboconfirm.Size = New System.Drawing.Size(81, 21)
        Me.cboconfirm.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdoctor)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dtp)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtdiagnosis)
        Me.GroupBox1.Controls.Add(Me.txtremark)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 239)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'txtdoctor
        '
        Me.txtdoctor.Location = New System.Drawing.Point(76, 210)
        Me.txtdoctor.Name = "txtdoctor"
        Me.txtdoctor.Size = New System.Drawing.Size(100, 20)
        Me.txtdoctor.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Doctor"
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(353, 141)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(110, 20)
        Me.dtp.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(220, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Consultation date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Remark"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chksonography)
        Me.GroupBox2.Controls.Add(Me.chkurine)
        Me.GroupBox2.Controls.Add(Me.chkgas)
        Me.GroupBox2.Controls.Add(Me.chkcolon)
        Me.GroupBox2.Controls.Add(Me.chkecg)
        Me.GroupBox2.Controls.Add(Me.chkblood)
        Me.GroupBox2.Controls.Add(Me.txtothers)
        Me.GroupBox2.Controls.Add(Me.chkstool)
        Me.GroupBox2.Controls.Add(Me.chkbio)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Californian FB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 116)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Test For Patients"
        '
        'chksonography
        '
        Me.chksonography.AutoSize = True
        Me.chksonography.Location = New System.Drawing.Point(211, 19)
        Me.chksonography.Name = "chksonography"
        Me.chksonography.Size = New System.Drawing.Size(93, 18)
        Me.chksonography.TabIndex = 9
        Me.chksonography.Text = "Sonography"
        Me.chksonography.UseVisualStyleBackColor = True
        '
        'chkurine
        '
        Me.chkurine.AutoSize = True
        Me.chkurine.Location = New System.Drawing.Point(110, 80)
        Me.chkurine.Name = "chkurine"
        Me.chkurine.Size = New System.Drawing.Size(58, 18)
        Me.chkurine.TabIndex = 7
        Me.chkurine.Text = "Urine"
        Me.chkurine.UseVisualStyleBackColor = True
        '
        'chkgas
        '
        Me.chkgas.AutoSize = True
        Me.chkgas.Location = New System.Drawing.Point(111, 49)
        Me.chkgas.Name = "chkgas"
        Me.chkgas.Size = New System.Drawing.Size(94, 18)
        Me.chkgas.TabIndex = 6
        Me.chkgas.Text = "Gastroscopy"
        Me.chkgas.UseVisualStyleBackColor = True
        '
        'chkcolon
        '
        Me.chkcolon.AutoSize = True
        Me.chkcolon.Location = New System.Drawing.Point(110, 16)
        Me.chkcolon.Name = "chkcolon"
        Me.chkcolon.Size = New System.Drawing.Size(90, 18)
        Me.chkcolon.TabIndex = 5
        Me.chkcolon.Text = "Colonscopy"
        Me.chkcolon.UseVisualStyleBackColor = True
        '
        'chkecg
        '
        Me.chkecg.AutoSize = True
        Me.chkecg.Location = New System.Drawing.Point(212, 51)
        Me.chkecg.Name = "chkecg"
        Me.chkecg.Size = New System.Drawing.Size(51, 18)
        Me.chkecg.TabIndex = 4
        Me.chkecg.Text = "ECG"
        Me.chkecg.UseVisualStyleBackColor = True
        '
        'chkblood
        '
        Me.chkblood.AutoSize = True
        Me.chkblood.Location = New System.Drawing.Point(11, 79)
        Me.chkblood.Name = "chkblood"
        Me.chkblood.Size = New System.Drawing.Size(59, 18)
        Me.chkblood.TabIndex = 2
        Me.chkblood.Text = "Blood"
        Me.chkblood.UseVisualStyleBackColor = True
        '
        'chkstool
        '
        Me.chkstool.AutoSize = True
        Me.chkstool.Location = New System.Drawing.Point(11, 48)
        Me.chkstool.Name = "chkstool"
        Me.chkstool.Size = New System.Drawing.Size(54, 18)
        Me.chkstool.TabIndex = 1
        Me.chkstool.Text = "Stool"
        Me.chkstool.UseVisualStyleBackColor = True
        '
        'chkbio
        '
        Me.chkbio.AutoSize = True
        Me.chkbio.Location = New System.Drawing.Point(10, 16)
        Me.chkbio.Name = "chkbio"
        Me.chkbio.Size = New System.Drawing.Size(98, 18)
        Me.chkbio.TabIndex = 0
        Me.chkbio.Text = "Biochemistry"
        Me.chkbio.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(493, 111)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(503, 235)
        Me.dgv1.TabIndex = 17
        '
        'cbosearch
        '
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Location = New System.Drawing.Point(750, 84)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(80, 21)
        Me.cbosearch.TabIndex = 53
        '
        'txtseacrh
        '
        Me.txtseacrh.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.txtseacrh.Location = New System.Drawing.Point(836, 86)
        Me.txtseacrh.Name = "txtseacrh"
        Me.txtseacrh.Size = New System.Drawing.Size(77, 20)
        Me.txtseacrh.TabIndex = 52
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(919, 84)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(72, 23)
        Me.btnsearch.TabIndex = 51
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'grpbtn
        '
        Me.grpbtn.BackColor = System.Drawing.SystemColors.Control
        Me.grpbtn.Controls.Add(Me.btngoto)
        Me.grpbtn.Controls.Add(Me.btndone)
        Me.grpbtn.Controls.Add(Me.btndelete)
        Me.grpbtn.Controls.Add(Me.btnclear)
        Me.grpbtn.Controls.Add(Me.btnsave)
        Me.grpbtn.Controls.Add(Me.btnedit)
        Me.grpbtn.Location = New System.Drawing.Point(225, 347)
        Me.grpbtn.Name = "grpbtn"
        Me.grpbtn.Size = New System.Drawing.Size(562, 91)
        Me.grpbtn.TabIndex = 54
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
        Me.btnclear.Location = New System.Drawing.Point(200, 18)
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
        'ChkPrintAll
        '
        Me.ChkPrintAll.AutoSize = True
        Me.ChkPrintAll.Checked = True
        Me.ChkPrintAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPrintAll.Location = New System.Drawing.Point(140, 418)
        Me.ChkPrintAll.Name = "ChkPrintAll"
        Me.ChkPrintAll.Size = New System.Drawing.Size(61, 17)
        Me.ChkPrintAll.TabIndex = 55
        Me.ChkPrintAll.Text = "Print All"
        Me.ChkPrintAll.UseVisualStyleBackColor = True
        Me.ChkPrintAll.Visible = False
        '
        'frmlab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 450)
        Me.Controls.Add(Me.ChkPrintAll)
        Me.Controls.Add(Me.grpbtn)
        Me.Controls.Add(Me.cbosearch)
        Me.Controls.Add(Me.txtseacrh)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboconfirm)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtsur)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.txtconfirm)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmlab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab Test"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbtn.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtconfirm As System.Windows.Forms.TextBox
    Friend WithEvents btnconfirm As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtothers As System.Windows.Forms.TextBox
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents txtdiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtsur As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents cboconfirm As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chksonography As System.Windows.Forms.CheckBox
    Friend WithEvents chkurine As System.Windows.Forms.CheckBox
    Friend WithEvents chkgas As System.Windows.Forms.CheckBox
    Friend WithEvents chkcolon As System.Windows.Forms.CheckBox
    Friend WithEvents chkecg As System.Windows.Forms.CheckBox
    Friend WithEvents chkblood As System.Windows.Forms.CheckBox
    Friend WithEvents chkstool As System.Windows.Forms.CheckBox
    Friend WithEvents chkbio As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbosearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtseacrh As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents AdiminstratioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpbtn As System.Windows.Forms.GroupBox
    Friend WithEvents btngoto As System.Windows.Forms.Button
    Friend WithEvents btndone As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents ChkPrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XRayCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DentalCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EyeCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtdoctor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
