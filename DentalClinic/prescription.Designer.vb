<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prescription))
        PictureBox2 = New PictureBox()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        psearch = New TextBox()
        delete = New Button()
        Logout = New PictureBox()
        Label9 = New Label()
        Label12 = New Label()
        edit = New Button()
        save = New Button()
        pdata = New DataGridView()
        PictureBox4 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label6 = New Label()
        Label11 = New Label()
        PictureBox3 = New PictureBox()
        Label8 = New Label()
        Pmed = New TextBox()
        Pquan = New TextBox()
        Pcost = New TextBox()
        Label3 = New Label()
        searchbtn = New Button()
        Ptreat = New ComboBox()
        Ppat = New ComboBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Logout, ComponentModel.ISupportInitialize).BeginInit()
        CType(pdata, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' psearch
        ' 
        psearch.BackColor = SystemColors.InactiveCaption
        psearch.BorderStyle = BorderStyle.None
        psearch.Location = New Point(540, 455)
        psearch.Multiline = True
        psearch.Name = "psearch"
        psearch.PlaceholderText = "Search By Name"
        psearch.Size = New Size(335, 28)
        psearch.TabIndex = 55
        ' 
        ' delete
        ' 
        delete.BackColor = SystemColors.HotTrack
        delete.Font = New Font("Century Gothic", 9F)
        delete.ForeColor = SystemColors.GradientInactiveCaption
        delete.Location = New Point(1135, 267)
        delete.Name = "delete"
        delete.Size = New Size(103, 40)
        delete.TabIndex = 53
        delete.Text = "Delete"
        delete.UseVisualStyleBackColor = False
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
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.DarkCyan
        Label9.Location = New Point(469, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 23)
        Label9.TabIndex = 6
        Label9.Text = "Patients"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.DarkCyan
        Label12.Location = New Point(21, 460)
        Label12.Name = "Label12"
        Label12.Size = New Size(119, 23)
        Label12.TabIndex = 54
        Label12.Text = "Patients List"
        ' 
        ' edit
        ' 
        edit.BackColor = SystemColors.HotTrack
        edit.Font = New Font("Century Gothic", 9F)
        edit.ForeColor = SystemColors.GradientInactiveCaption
        edit.Location = New Point(1135, 185)
        edit.Name = "edit"
        edit.Size = New Size(103, 40)
        edit.TabIndex = 52
        edit.Text = "Edit"
        edit.UseVisualStyleBackColor = False
        ' 
        ' save
        ' 
        save.BackColor = SystemColors.HotTrack
        save.Font = New Font("Century Gothic", 9F)
        save.ForeColor = SystemColors.GradientInactiveCaption
        save.Location = New Point(1135, 107)
        save.Name = "save"
        save.Size = New Size(103, 40)
        save.TabIndex = 51
        save.Text = "Save"
        save.UseVisualStyleBackColor = False
        ' 
        ' pdata
        ' 
        pdata.BackgroundColor = Color.WhiteSmoke
        pdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        pdata.Dock = DockStyle.Bottom
        pdata.Enabled = False
        pdata.Location = New Point(0, 489)
        pdata.Name = "pdata"
        pdata.RowHeadersWidth = 51
        pdata.Size = New Size(1462, 200)
        pdata.TabIndex = 50
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkCyan
        Label5.Location = New Point(597, 235)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 21)
        Label5.TabIndex = 48
        Label5.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkCyan
        Label4.Location = New Point(75, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 21)
        Label4.TabIndex = 47
        Label4.Text = "Medicine"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkCyan
        Label2.Location = New Point(581, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 21)
        Label2.TabIndex = 46
        Label2.Text = "Treatment"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkCyan
        Label1.Location = New Point(79, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 21)
        Label1.TabIndex = 45
        Label1.Text = "Patient"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGray
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Logout)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(PictureBox4)
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
        Panel2.TabIndex = 44
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkCyan
        Label6.Location = New Point(729, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 23)
        Label6.TabIndex = 12
        Label6.Text = "Treatment"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.DarkCyan
        Label11.Location = New Point(1003, 19)
        Label11.Name = "Label11"
        Label11.Size = New Size(147, 23)
        Label11.TabIndex = 10
        Label11.Text = "Appointments"
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
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.MintCream
        Label8.Location = New Point(104, 32)
        Label8.Name = "Label8"
        Label8.Size = New Size(149, 27)
        Label8.TabIndex = 4
        Label8.Text = "Prescriptions"
        ' 
        ' Pmed
        ' 
        Pmed.Location = New Point(200, 245)
        Pmed.Multiline = True
        Pmed.Name = "Pmed"
        Pmed.Size = New Size(284, 87)
        Pmed.TabIndex = 59
        ' 
        ' Pquan
        ' 
        Pquan.Location = New Point(729, 233)
        Pquan.Name = "Pquan"
        Pquan.Size = New Size(260, 27)
        Pquan.TabIndex = 60
        ' 
        ' Pcost
        ' 
        Pcost.Location = New Point(729, 283)
        Pcost.Name = "Pcost"
        Pcost.Size = New Size(260, 27)
        Pcost.TabIndex = 62
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkCyan
        Label3.Location = New Point(634, 289)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 21)
        Label3.TabIndex = 61
        Label3.Text = "Cost"
        ' 
        ' searchbtn
        ' 
        searchbtn.BackColor = Color.RoyalBlue
        searchbtn.Location = New Point(903, 452)
        searchbtn.Margin = New Padding(3, 4, 3, 4)
        searchbtn.Name = "searchbtn"
        searchbtn.Size = New Size(95, 31)
        searchbtn.TabIndex = 63
        searchbtn.Text = "search"
        searchbtn.UseVisualStyleBackColor = False
        ' 
        ' Ptreat
        ' 
        Ptreat.FormattingEnabled = True
        Ptreat.Location = New Point(729, 125)
        Ptreat.Name = "Ptreat"
        Ptreat.Size = New Size(286, 28)
        Ptreat.TabIndex = 64
        ' 
        ' Ppat
        ' 
        Ppat.FormattingEnabled = True
        Ppat.Location = New Point(198, 125)
        Ppat.Name = "Ppat"
        Ppat.Size = New Size(286, 28)
        Ppat.TabIndex = 65
        ' 
        ' prescription
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1462, 689)
        Controls.Add(Ppat)
        Controls.Add(Ptreat)
        Controls.Add(searchbtn)
        Controls.Add(Pcost)
        Controls.Add(Label3)
        Controls.Add(Pquan)
        Controls.Add(Pmed)
        Controls.Add(psearch)
        Controls.Add(delete)
        Controls.Add(Label12)
        Controls.Add(edit)
        Controls.Add(save)
        Controls.Add(pdata)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "prescription"
        Text = "Form6"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Logout, ComponentModel.ISupportInitialize).EndInit()
        CType(pdata, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents psearch As TextBox
    Friend WithEvents delete As Button
    Friend WithEvents Logout As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents edit As Button
    Friend WithEvents save As Button
    Friend WithEvents pdata As DataGridView
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Pmed As TextBox
    Friend WithEvents Pquan As TextBox
    Friend WithEvents Pcost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents searchbtn As Button
    Friend WithEvents Ptreat As ComboBox
    Friend WithEvents Ppat As ComboBox
End Class
