<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patients))
        Panel2 = New Panel()
        Logout = New PictureBox()
        Label11 = New Label()
        PictureBox4 = New PictureBox()
        Label10 = New Label()
        PictureBox3 = New PictureBox()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        Label8 = New Label()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        pname = New TextBox()
        pno = New TextBox()
        padd = New TextBox()
        pall = New TextBox()
        rb1 = New RadioButton()
        rb2 = New RadioButton()
        pdob = New DateTimePicker()
        pdata = New DataGridView()
        save = New Button()
        edit = New Button()
        del = New Button()
        Label12 = New Label()
        psearch = New TextBox()
        searchbtn = New Button()
        Panel2.SuspendLayout()
        CType(Logout, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pdata, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGray
        Panel2.Controls.Add(Logout)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1462, 68)
        Panel2.TabIndex = 1
        ' 
        ' Logout
        ' 
        Logout.Image = CType(resources.GetObject("Logout.Image"), Image)
        Logout.Location = New Point(1407, 20)
        Logout.Name = "Logout"
        Logout.Size = New Size(51, 45)
        Logout.SizeMode = PictureBoxSizeMode.Zoom
        Logout.TabIndex = 11
        Logout.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.DarkCyan
        Label11.Location = New Point(1003, 19)
        Label11.Name = "Label11"
        Label11.Size = New Size(120, 23)
        Label11.TabIndex = 10
        Label11.Text = "Prescription"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(913, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(85, 65)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.DarkCyan
        Label10.Location = New Point(729, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(139, 23)
        Label10.TabIndex = 8
        Label10.Text = "Appointment"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(638, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(85, 65)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.DarkCyan
        Label9.Location = New Point(469, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(109, 23)
        Label9.TabIndex = 6
        Label9.Text = "Treatment"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(378, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(85, 65)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.MintCream
        Label8.Location = New Point(104, 32)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 27)
        Label8.TabIndex = 4
        Label8.Text = "Patients"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DarkCyan
        Label7.Location = New Point(94, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(134, 23)
        Label7.TabIndex = 3
        Label7.Text = "Dental Clinic"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(85, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkCyan
        Label1.Location = New Point(79, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 21)
        Label1.TabIndex = 2
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkCyan
        Label2.Location = New Point(79, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 21)
        Label2.TabIndex = 3
        Label2.Text = "Phone"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkCyan
        Label3.Location = New Point(79, 263)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 21)
        Label3.TabIndex = 4
        Label3.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkCyan
        Label4.Location = New Point(560, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 21)
        Label4.TabIndex = 5
        Label4.Text = "DOB"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkCyan
        Label5.Location = New Point(560, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 21)
        Label5.TabIndex = 6
        Label5.Text = "Gender"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkCyan
        Label6.Location = New Point(560, 263)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 21)
        Label6.TabIndex = 7
        Label6.Text = "Allergies"
        ' 
        ' pname
        ' 
        pname.Location = New Point(167, 120)
        pname.Name = "pname"
        pname.Size = New Size(286, 27)
        pname.TabIndex = 8
        ' 
        ' pno
        ' 
        pno.Location = New Point(167, 189)
        pno.Name = "pno"
        pno.Size = New Size(286, 27)
        pno.TabIndex = 9
        ' 
        ' padd
        ' 
        padd.Location = New Point(167, 257)
        padd.Multiline = True
        padd.Name = "padd"
        padd.Size = New Size(286, 109)
        padd.TabIndex = 10
        ' 
        ' pall
        ' 
        pall.Location = New Point(738, 257)
        pall.Multiline = True
        pall.Name = "pall"
        pall.Size = New Size(286, 109)
        pall.TabIndex = 11
        ' 
        ' rb1
        ' 
        rb1.AutoSize = True
        rb1.Font = New Font("Century Gothic", 9F)
        rb1.Location = New Point(737, 189)
        rb1.Name = "rb1"
        rb1.Size = New Size(68, 24)
        rb1.TabIndex = 12
        rb1.TabStop = True
        rb1.Text = "Male"
        rb1.UseVisualStyleBackColor = True
        ' 
        ' rb2
        ' 
        rb2.AutoSize = True
        rb2.Font = New Font("Century Gothic", 9F)
        rb2.Location = New Point(926, 189)
        rb2.Name = "rb2"
        rb2.Size = New Size(83, 24)
        rb2.TabIndex = 13
        rb2.TabStop = True
        rb2.Text = "Female"
        rb2.UseVisualStyleBackColor = True
        ' 
        ' pdob
        ' 
        pdob.Format = DateTimePickerFormat.Custom
        pdob.Location = New Point(738, 123)
        pdob.Name = "pdob"
        pdob.Size = New Size(291, 27)
        pdob.TabIndex = 14
        ' 
        ' pdata
        ' 
        pdata.BackgroundColor = Color.WhiteSmoke
        pdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        pdata.Dock = DockStyle.Bottom
        pdata.Location = New Point(0, 489)
        pdata.Name = "pdata"
        pdata.RowHeadersWidth = 51
        pdata.Size = New Size(1462, 200)
        pdata.TabIndex = 15
        ' 
        ' save
        ' 
        save.BackColor = SystemColors.HotTrack
        save.Font = New Font("Century Gothic", 9F)
        save.ForeColor = SystemColors.GradientInactiveCaption
        save.Location = New Point(1135, 107)
        save.Name = "save"
        save.Size = New Size(103, 40)
        save.TabIndex = 16
        save.Text = "Save"
        save.UseVisualStyleBackColor = False
        ' 
        ' edit
        ' 
        edit.BackColor = SystemColors.HotTrack
        edit.Font = New Font("Century Gothic", 9F)
        edit.ForeColor = SystemColors.GradientInactiveCaption
        edit.Location = New Point(1135, 185)
        edit.Name = "edit"
        edit.Size = New Size(103, 40)
        edit.TabIndex = 17
        edit.Text = "Edit"
        edit.UseVisualStyleBackColor = False
        ' 
        ' del
        ' 
        del.BackColor = SystemColors.HotTrack
        del.Font = New Font("Century Gothic", 9F)
        del.ForeColor = SystemColors.GradientInactiveCaption
        del.Location = New Point(1135, 267)
        del.Name = "del"
        del.Size = New Size(103, 40)
        del.TabIndex = 18
        del.Text = "Delete"
        del.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.DarkCyan
        Label12.Location = New Point(21, 463)
        Label12.Name = "Label12"
        Label12.Size = New Size(119, 23)
        Label12.TabIndex = 19
        Label12.Text = "Patients List"
        ' 
        ' psearch
        ' 
        psearch.BackColor = SystemColors.InactiveCaption
        psearch.BorderStyle = BorderStyle.None
        psearch.Location = New Point(582, 456)
        psearch.Multiline = True
        psearch.Name = "psearch"
        psearch.PlaceholderText = "Search By Name"
        psearch.Size = New Size(337, 27)
        psearch.TabIndex = 20
        ' 
        ' searchbtn
        ' 
        searchbtn.BackColor = Color.RoyalBlue
        searchbtn.Location = New Point(962, 451)
        searchbtn.Margin = New Padding(3, 4, 3, 4)
        searchbtn.Name = "searchbtn"
        searchbtn.Size = New Size(97, 31)
        searchbtn.TabIndex = 21
        searchbtn.Text = "search"
        searchbtn.UseVisualStyleBackColor = False
        ' 
        ' Patients
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1462, 689)
        Controls.Add(searchbtn)
        Controls.Add(psearch)
        Controls.Add(Label12)
        Controls.Add(del)
        Controls.Add(edit)
        Controls.Add(save)
        Controls.Add(pdata)
        Controls.Add(pdob)
        Controls.Add(rb2)
        Controls.Add(rb1)
        Controls.Add(pall)
        Controls.Add(padd)
        Controls.Add(pno)
        Controls.Add(pname)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Patients"
        Text = "Form3"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(Logout, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pdata, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pname As TextBox
    Friend WithEvents pno As TextBox
    Friend WithEvents padd As TextBox
    Friend WithEvents pall As TextBox
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents pdob As DateTimePicker
    Friend WithEvents pdata As DataGridView
    Friend WithEvents save As Button
    Friend WithEvents edit As Button
    Friend WithEvents del As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Logout As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents psearch As TextBox
    Friend WithEvents searchbtn As Button
End Class
