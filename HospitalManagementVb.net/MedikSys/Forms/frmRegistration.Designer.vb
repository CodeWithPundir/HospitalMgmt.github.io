<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistration))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtage = New System.Windows.Forms.TextBox
        Me.cbodisability = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtphone = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtwork = New System.Windows.Forms.TextBox
        Me.txtweight = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboblood = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbosex = New System.Windows.Forms.ComboBox
        Me.txtsur = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.txthadd = New System.Windows.Forms.TextBox
        Me.txtkinname = New System.Windows.Forms.TextBox
        Me.cborelate = New System.Windows.Forms.ComboBox
        Me.txtkinadd = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultancyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LabTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.XRayCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DentalCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EyeCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.cbosearch = New System.Windows.Forms.ComboBox
        Me.grpbtn = New System.Windows.Forms.GroupBox
        Me.btngoto = New System.Windows.Forms.Button
        Me.btndone = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.txtid = New System.Windows.Forms.TextBox
        Me.dtpbio2 = New System.Windows.Forms.DateTimePicker
        Me.ChkPrintAll = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.cbodisability)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtphone)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtwork)
        Me.GroupBox1.Controls.Add(Me.txtweight)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboblood)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbosex)
        Me.GroupBox1.Controls.Add(Me.txtsur)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.txthadd)
        Me.GroupBox1.Controls.Add(Me.txtkinname)
        Me.GroupBox1.Controls.Add(Me.cborelate)
        Me.GroupBox1.Controls.Add(Me.txtkinadd)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Colonna MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(972, 228)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bio Data"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(125, 75)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(41, 24)
        Me.txtage.TabIndex = 5
        '
        'cbodisability
        '
        Me.cbodisability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodisability.FormattingEnabled = True
        Me.cbodisability.Location = New System.Drawing.Point(122, 190)
        Me.cbodisability.Name = "cbodisability"
        Me.cbodisability.Size = New System.Drawing.Size(62, 25)
        Me.cbodisability.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(20, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 15)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Disability"
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(740, 154)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(111, 21)
        Me.txtphone.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(588, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 15)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Next Of Kin Phone No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(313, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Work Address"
        '
        'txtwork
        '
        Me.txtwork.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwork.Location = New System.Drawing.Point(419, 107)
        Me.txtwork.Name = "txtwork"
        Me.txtwork.Size = New System.Drawing.Size(348, 21)
        Me.txtwork.TabIndex = 8
        '
        'txtweight
        '
        Me.txtweight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtweight.Location = New System.Drawing.Point(809, 37)
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(72, 21)
        Me.txtweight.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(724, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Body Weight"
        '
        'cboblood
        '
        Me.cboblood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboblood.FormattingEnabled = True
        Me.cboblood.Location = New System.Drawing.Point(646, 35)
        Me.cboblood.Name = "cboblood"
        Me.cboblood.Size = New System.Drawing.Size(62, 25)
        Me.cboblood.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(563, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Blood Group"
        '
        'cbosex
        '
        Me.cbosex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosex.FormattingEnabled = True
        Me.cbosex.Location = New System.Drawing.Point(122, 111)
        Me.cbosex.Name = "cbosex"
        Me.cbosex.Size = New System.Drawing.Size(121, 25)
        Me.cbosex.TabIndex = 7
        '
        'txtsur
        '
        Me.txtsur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsur.Location = New System.Drawing.Point(400, 37)
        Me.txtsur.Name = "txtsur"
        Me.txtsur.Size = New System.Drawing.Size(159, 21)
        Me.txtsur.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(313, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Home Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Name of Next Of Kin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(313, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Address of Next of Kin"
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(122, 34)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(137, 21)
        Me.txtfname.TabIndex = 1
        '
        'txthadd
        '
        Me.txthadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthadd.Location = New System.Drawing.Point(419, 80)
        Me.txthadd.Name = "txthadd"
        Me.txthadd.Size = New System.Drawing.Size(547, 21)
        Me.txthadd.TabIndex = 6
        '
        'txtkinname
        '
        Me.txtkinname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkinname.Location = New System.Drawing.Point(456, 152)
        Me.txtkinname.Name = "txtkinname"
        Me.txtkinname.Size = New System.Drawing.Size(111, 21)
        Me.txtkinname.TabIndex = 10
        '
        'cborelate
        '
        Me.cborelate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cborelate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cborelate.FormattingEnabled = True
        Me.cborelate.Location = New System.Drawing.Point(122, 152)
        Me.cborelate.Name = "cborelate"
        Me.cborelate.Size = New System.Drawing.Size(121, 23)
        Me.cborelate.TabIndex = 9
        '
        'txtkinadd
        '
        Me.txtkinadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkinadd.Location = New System.Drawing.Point(467, 188)
        Me.txtkinadd.Name = "txtkinadd"
        Me.txtkinadd.Size = New System.Drawing.Size(499, 21)
        Me.txtkinadd.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 15)
        Me.Label9.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Marital Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Age"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 15)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Sex"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministratorToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(993, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.ConsultancyToolStripMenuItem, Me.LabTestToolStripMenuItem, Me.XRayCheckToolStripMenuItem, Me.DentalCheckToolStripMenuItem, Me.EyeCheckToolStripMenuItem})
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.AdministratorToolStripMenuItem.Text = "Administrator"
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
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 317)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(972, 297)
        Me.dgv.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label15.Font = New System.Drawing.Font("Chiller", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(311, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(291, 24)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Patient Registration Form for FUTMinna"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(802, 68)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(100, 20)
        Me.txtsearch.TabIndex = 41
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(908, 68)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 42
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'cbosearch
        '
        Me.cbosearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosearch.Font = New System.Drawing.Font("Colonna MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Location = New System.Drawing.Point(712, 68)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(84, 21)
        Me.cbosearch.TabIndex = 43
        '
        'grpbtn
        '
        Me.grpbtn.BackColor = System.Drawing.SystemColors.Control
        Me.grpbtn.Controls.Add(Me.ChkPrintAll)
        Me.grpbtn.Controls.Add(Me.btngoto)
        Me.grpbtn.Controls.Add(Me.btndone)
        Me.grpbtn.Controls.Add(Me.btndelete)
        Me.grpbtn.Controls.Add(Me.btnclear)
        Me.grpbtn.Controls.Add(Me.btnsave)
        Me.grpbtn.Controls.Add(Me.btnedit)
        Me.grpbtn.Location = New System.Drawing.Point(12, 614)
        Me.grpbtn.Name = "grpbtn"
        Me.grpbtn.Size = New System.Drawing.Size(972, 102)
        Me.grpbtn.TabIndex = 45
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
        Me.btngoto.Location = New System.Drawing.Point(863, 10)
        Me.btngoto.Name = "btngoto"
        Me.btngoto.Size = New System.Drawing.Size(89, 86)
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
        Me.btndone.Location = New System.Drawing.Point(700, 12)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(89, 84)
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
        Me.btndelete.Location = New System.Drawing.Point(523, 12)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(89, 84)
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
        Me.btnclear.Location = New System.Drawing.Point(359, 12)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(89, 84)
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
        Me.btnsave.Location = New System.Drawing.Point(20, 13)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(89, 83)
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
        Me.btnedit.Location = New System.Drawing.Point(188, 13)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(89, 83)
        Me.btnedit.TabIndex = 0
        Me.btnedit.Text = "&Edit"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(594, 68)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 46
        Me.txtid.Visible = False
        '
        'dtpbio2
        '
        Me.dtpbio2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpbio2.Location = New System.Drawing.Point(138, 65)
        Me.dtpbio2.Name = "dtpbio2"
        Me.dtpbio2.Size = New System.Drawing.Size(81, 20)
        Me.dtpbio2.TabIndex = 28
        '
        'ChkPrintAll
        '
        Me.ChkPrintAll.AutoSize = True
        Me.ChkPrintAll.Checked = True
        Me.ChkPrintAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPrintAll.Location = New System.Drawing.Point(713, 14)
        Me.ChkPrintAll.Name = "ChkPrintAll"
        Me.ChkPrintAll.Size = New System.Drawing.Size(61, 17)
        Me.ChkPrintAll.TabIndex = 47
        Me.ChkPrintAll.Text = "Print All"
        Me.ChkPrintAll.UseVisualStyleBackColor = True
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 719)
        Me.Controls.Add(Me.dtpbio2)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.grpbtn)
        Me.Controls.Add(Me.cbosearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbtn.ResumeLayout(False)
        Me.grpbtn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboblood As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbosex As System.Windows.Forms.ComboBox
    Friend WithEvents txtsur As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txthadd As System.Windows.Forms.TextBox
    Friend WithEvents txtkinname As System.Windows.Forms.TextBox
    Friend WithEvents cborelate As System.Windows.Forms.ComboBox
    Friend WithEvents txtkinadd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtwork As System.Windows.Forms.TextBox
    Friend WithEvents txtweight As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbodisability As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultancyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XRayCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DentalCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents cbosearch As System.Windows.Forms.ComboBox
    Friend WithEvents grpbtn As System.Windows.Forms.GroupBox
    Friend WithEvents btngoto As System.Windows.Forms.Button
    Friend WithEvents btndone As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents EyeCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents dtpbio2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChkPrintAll As System.Windows.Forms.CheckBox
End Class
