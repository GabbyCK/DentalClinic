<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents uname As System.Windows.Forms.TextBox
    Friend WithEvents upass As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        uname = New TextBox()
        upass = New TextBox()
        OK = New Button()
        Cancel = New Button()
        Panel1 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Font = New Font("Century Gothic", 10.2F)
        UsernameLabel.ForeColor = SystemColors.HotTrack
        UsernameLabel.Location = New Point(200, 112)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(104, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "&User name"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Font = New Font("Century Gothic", 10.2F)
        PasswordLabel.ForeColor = SystemColors.HotTrack
        PasswordLabel.Location = New Point(200, 187)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(104, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' uname
        ' 
        uname.Location = New Point(348, 108)
        uname.Name = "uname"
        uname.Size = New Size(220, 27)
        uname.TabIndex = 1
        ' 
        ' upass
        ' 
        upass.Location = New Point(348, 183)
        upass.Name = "upass"
        upass.PasswordChar = "*"c
        upass.Size = New Size(220, 27)
        upass.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.BackColor = SystemColors.HotTrack
        OK.Font = New Font("Century Gothic", 9F)
        OK.ForeColor = SystemColors.ControlLight
        OK.Location = New Point(294, 269)
        OK.Name = "OK"
        OK.Size = New Size(94, 33)
        OK.TabIndex = 4
        OK.Text = "Login"
        OK.UseVisualStyleBackColor = False
        ' 
        ' Cancel
        ' 
        Cancel.BackColor = SystemColors.HotTrack
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Font = New Font("Century Gothic", 9F)
        Cancel.ForeColor = SystemColors.ControlLight
        Cancel.Location = New Point(488, 269)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 33)
        Cancel.TabIndex = 5
        Cancel.Text = "&Cancel"
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(174, 402)
        Panel1.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Italic)
        Label6.ForeColor = Color.DarkCyan
        Label6.Location = New Point(57, 329)
        Label6.Name = "Label6"
        Label6.Size = New Size(33, 40)
        Label6.TabIndex = 12
        Label6.Text = "L"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Italic)
        Label5.ForeColor = Color.DarkCyan
        Label5.Location = New Point(57, 269)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 40)
        Label5.TabIndex = 11
        Label5.Text = "A"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Italic)
        Label4.ForeColor = Color.DarkCyan
        Label4.Location = New Point(57, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 40)
        Label4.TabIndex = 10
        Label4.Text = "T"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Italic)
        Label3.ForeColor = Color.DarkCyan
        Label3.Location = New Point(57, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 40)
        Label3.TabIndex = 9
        Label3.Text = "N"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Italic)
        Label2.ForeColor = Color.DarkCyan
        Label2.Location = New Point(57, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 40)
        Label2.TabIndex = 8
        Label2.Text = "E"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.AppWorkspace
        Label1.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Italic)
        Label1.ForeColor = Color.DarkCyan
        Label1.Location = New Point(57, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 40)
        Label1.TabIndex = 7
        Label1.Text = "D"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(376, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(87, 68)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel
        ClientSize = New Size(717, 402)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(upass)
        Controls.Add(uname)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "LoginForm1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
