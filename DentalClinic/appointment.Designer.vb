<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(appointment))
        TextBox5 = New TextBox()
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
        Label12 = New Label()
        button3 = New Button()
        button2 = New Button()
        button1 = New Button()
        pdata = New DataGridView()
        pdate = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        ppat = New ComboBox()
        ptime = New DateTimePicker()
        psearch = New Button()
        ptreat = New ComboBox()
        CType(Logout, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pdata, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.InactiveCaption
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Location = New Point(582, 456)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Search By Name"
        TextBox5.Size = New Size(337, 27)
        TextBox5.TabIndex = 40
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
        PictureBox4.Location = New Point(931, 3)
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
        Label10.Size = New Size(109, 23)
        Label10.TabIndex = 8
        Label10.Text = "Treatment"
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
        Label9.Size = New Size(86, 23)
        Label9.TabIndex = 6
        Label9.Text = "Patients"
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
        Label8.Size = New Size(149, 27)
        Label8.TabIndex = 4
        Label8.Text = "Appointments"
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
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.DarkCyan
        Label12.Location = New Point(21, 463)
        Label12.Name = "Label12"
        Label12.Size = New Size(119, 23)
        Label12.TabIndex = 39
        Label12.Text = "Patients List"
        ' 
        ' button3
        ' 
        button3.BackColor = SystemColors.HotTrack
        button3.Font = New Font("Century Gothic", 9F)
        button3.ForeColor = SystemColors.GradientInactiveCaption
        button3.Location = New Point(1135, 267)
        button3.Name = "button3"
        button3.Size = New Size(103, 40)
        button3.TabIndex = 38
        button3.Text = "Delete"
        button3.UseVisualStyleBackColor = False
        ' 
        ' button2
        ' 
        button2.BackColor = SystemColors.HotTrack
        button2.Font = New Font("Century Gothic", 9F)
        button2.ForeColor = SystemColors.GradientInactiveCaption
        button2.Location = New Point(1135, 185)
        button2.Name = "button2"
        button2.Size = New Size(103, 40)
        button2.TabIndex = 37
        button2.Text = "edit"
        button2.UseVisualStyleBackColor = False
        ' 
        ' button1
        ' 
        button1.BackColor = SystemColors.HotTrack
        button1.Font = New Font("Century Gothic", 9F)
        button1.ForeColor = SystemColors.GradientInactiveCaption
        button1.Location = New Point(1135, 107)
        button1.Name = "button1"
        button1.Size = New Size(103, 40)
        button1.TabIndex = 36
        button1.Text = "save"
        button1.UseVisualStyleBackColor = False
        ' 
        ' pdata
        ' 
        pdata.BackgroundColor = Color.WhiteSmoke
        pdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        pdata.Enabled = False
        pdata.Location = New Point(0, 489)
        pdata.Name = "pdata"
        pdata.RowHeadersWidth = 51
        pdata.Size = New Size(1458, 200)
        pdata.TabIndex = 35
        ' 
        ' pdate
        ' 
        pdate.Location = New Point(663, 124)
        pdate.Name = "pdate"
        pdate.Size = New Size(291, 27)
        pdate.TabIndex = 34
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkCyan
        Label5.Location = New Point(560, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 21)
        Label5.TabIndex = 26
        Label5.Text = "Time"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkCyan
        Label4.Location = New Point(560, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 21)
        Label4.TabIndex = 25
        Label4.Text = "Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Century", 10.2F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkCyan
        Label2.Location = New Point(50, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 21)
        Label2.TabIndex = 23
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
        Label1.TabIndex = 22
        Label1.Text = "Patient"
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
        Panel2.Size = New Size(1471, 68)
        Panel2.TabIndex = 21
        ' 
        ' ppat
        ' 
        ppat.FormattingEnabled = True
        ppat.Location = New Point(198, 124)
        ppat.Name = "ppat"
        ppat.Size = New Size(286, 28)
        ppat.TabIndex = 41
        ' 
        ' ptime
        ' 
        ptime.Location = New Point(663, 195)
        ptime.Name = "ptime"
        ptime.Size = New Size(291, 27)
        ptime.TabIndex = 42
        ' 
        ' psearch
        ' 
        psearch.BackColor = Color.RoyalBlue
        psearch.Location = New Point(944, 451)
        psearch.Margin = New Padding(3, 4, 3, 4)
        psearch.Name = "psearch"
        psearch.Size = New Size(97, 31)
        psearch.TabIndex = 63
        psearch.Text = "search"
        psearch.UseVisualStyleBackColor = False
        ' 
        ' ptreat
        ' 
        ptreat.FormattingEnabled = True
        ptreat.Location = New Point(198, 185)
        ptreat.Name = "ptreat"
        ptreat.Size = New Size(286, 28)
        ptreat.TabIndex = 64
        ' 
        ' appointment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1471, 689)
        Controls.Add(ptreat)
        Controls.Add(psearch)
        Controls.Add(ptime)
        Controls.Add(ppat)
        Controls.Add(TextBox5)
        Controls.Add(Label12)
        Controls.Add(button3)
        Controls.Add(button2)
        Controls.Add(button1)
        Controls.Add(pdata)
        Controls.Add(pdate)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "appointment"
        Text = "Form5"
        CType(Logout, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pdata, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Logout As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents button3 As Button
    Friend WithEvents button2 As Button
    Friend WithEvents button1 As Button
    Friend WithEvents pdata As DataGridView
    Friend WithEvents pdate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ppat As ComboBox
    Friend WithEvents ptime As DateTimePicker

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Dim confirm = MessageBox.Show("Are you sure you want to logout?", "Confirm exit", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Close
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)
        Hide
        Dim obj = New Patients
        obj.Show
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)
        Hide
        Dim obj = New treatment
        obj.Show
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)
        Hide
        Dim obj = New Prescription
        obj.Show
    End Sub

    Friend WithEvents psearch As Button
    Friend WithEvents ptreat As ComboBox
End Class
