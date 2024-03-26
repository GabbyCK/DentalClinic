Imports System.Security.AccessControl
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports EonaCat.Csv.Model
Imports Microsoft.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Digests
Imports Org.BouncyCastle.Utilities.IO.Pem
Public Class Patients
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand

    'LINKS FOR THE FORMS
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        Dim obj = New treatment
        obj.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Hide()
        Dim obj = New appointment
        obj.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Hide()
        Dim obj = New prescription
        obj.Show()
    End Sub
    'FUNCTIONS USED IN THE BUTTONS
    Private Sub Populate()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"

        conn.Open()
        Using (conn)
            Dim query = "select * from Patient"
            Dim adapter As MySqlDataAdapter
            adapter = New MySqlDataAdapter(query, conn)
            Dim builder As New MySqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            pdata.DataSource = ds.Tables(0)
        End Using
        conn.Close()
    End Sub
    'function to clear out textboxes
    Public Function clear()
        pname.Text = ""
        pno.Text = ""
        padd.Text = ""
        pdob.Text = ""
        rb1.Checked = False
        rb2.Checked = False
        pall.Text = ""
    End Function

    'FUNCTION TO PREVENT DUPLICTATE ENTRIES
    Private Function PatientExists(ByVal name As String, ByVal phone As String) As Boolean
        Dim exists As Boolean = False
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic"

            If (dbconnect()) Then
                conn.Open()
                Using (conn)
                    Dim query As String = "SELECT COUNT(*) FROM patient WHERE PatName = @name AND PatPhone = @phone"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@phone", phone)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        exists = True
                    End If
                End Using
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred while checking if patient exists: " & ex.Message, vbCritical)
        End Try
        Return exists
    End Function
    Private Sub save_click(sender As Object, e As EventArgs) Handles save.Click
        If pname.Text = "" Or pno.Text = "" Or padd.Text = "" Or pdob.Text = "" Or pall.Text = "" Then
            MsgBox("Kindly fill out all sections")
        Else
            If PatientExists(pname.Text.Trim(), pno.Text.Trim()) Then
                MsgBox("Patient with the same name and phone number already exists.", vbExclamation)
            Else
                Dim conn = New MySqlConnection("server=localhost;userid=root;password='';database=dental_clinic")
                conn.Open()

                Dim query As String = "INSERT INTO patient(PatName, PatPhone, PatAddress, PatDOB, PatGen, PatAll) VALUES (@name, @phone, @address, @dob, @gender, @allergies)"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@name", pname.Text.Trim())
                cmd.Parameters.AddWithValue("@phone", pno.Text.Trim())
                cmd.Parameters.AddWithValue("@address", padd.Text.Trim())
                Dim dobDate As DateTime
                If DateTime.TryParse(pdob.Text.Trim(), dobDate) Then
                    cmd.Parameters.AddWithValue("@dob", dobDate.ToString("yyyy-MM-dd"))
                Else
                    MsgBox("Invalid date format. Please enter date in YYYY-MM-DD format.", vbCritical)
                    conn.Close()
                    Exit Sub ' Exit if date parsing fails
                End If

                cmd.Parameters.AddWithValue("@gender", If(rb1.Checked, rb1.Text.Trim(), rb2.Text.Trim()))
                cmd.Parameters.AddWithValue("@allergies", pall.Text.Trim())

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Patient Saved successfully", vbInformation)
                Catch ex As MySqlException
                    MsgBox("Error saving patient: " & ex.Message)
                End Try

                conn.Close()
            End If
        End If
        Populate()
        clear()
    End Sub

    Private Sub Patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    'DISPLAYING DATA IN TEXTBOXES AFTER SELECTING FROM DATA GRID
    Private Sub patients_dgv_cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles pdata.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < pdata.Rows.Count Then
            ' Get the clicked row
            Dim row As DataGridViewRow = pdata.Rows(e.RowIndex)

            ' Access cell values using column names (assuming you have named columns)
            pname.Text = row.Cells("PatName").Value.ToString()
            pno.Text = row.Cells("PatPhone").Value.ToString()
            padd.Text = row.Cells("PatAddress").Value.ToString()
            pdob.Text = row.Cells("PatDOB").Value.ToString()
            If row.Cells("PatGen").Value = "Male" Then
                rb1.Checked = True
            ElseIf row.Cells("PatGen").Value = "Female" Then
                rb2.Checked = True
            End If
            pall.Text = row.Cells("PatAll").Value.ToString()

        Else
            ' Handle invalid row index (optional)
            MessageBox.Show("Invalid row selected!")
        End If
    End Sub
    'BUTTON FOR DELETE
    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        Dim conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"


        If pdata.SelectedRows.Count = 0 Then
            MsgBox("Missing Information")
        Else
            Dim confirm = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo)
            If confirm = DialogResult.Yes Then
                Dim selectedRowIndex As Integer = pdata.SelectedRows(0).Index
                Dim selectedPatientID As Integer = CInt(pdata.Rows(selectedRowIndex).Cells("PId").Value)

                conn.Open()

                Dim query = "DELETE FROM patient WHERE PId=@PId"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PId", selectedPatientID)

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Patient Deleted Successfully")
                Catch ex As MySqlException
                    MsgBox("Error deleting patient: " & ex.Message)
                End Try

                conn.Close()
            End If
            Populate()
            Reset()

        End If
    End Sub
    'BUTTON FOR EDIT
    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"
        If (dbconnect()) Then
            If pdata.SelectedRows.Count = 0 Then
                MsgBox("Missing Information")
            Else
                Dim selectedID As Integer = pdata.SelectedRows(0).Cells("PId").Value
                If PatientExists(pname.Text.Trim(), pno.Text.Trim()) Then
                    MsgBox("Patient with the same name and phone number already exists.", vbExclamation)
                Else
                    conn.Open()

                    ' Parameterized query to prevent SQL Injection attacks
                    Dim query = "UPDATE patient SET PatName=@name, PatPhone=@phone, PatAddress=@address, PatDOB=@dob, PatGen=@gender, PatAll=@all WHERE Pid=@id"
                    Dim cmd As New MySqlCommand(query, conn)

                    ' Add parameters to the query
                    cmd.Parameters.AddWithValue("@name", pname.Text)
                    cmd.Parameters.AddWithValue("@phone", pno.Text)
                    cmd.Parameters.AddWithValue("@address", padd.Text)
                    Dim dobDate As DateTime
                    If DateTime.TryParse(pdob.Text.Trim(), dobDate) Then
                        cmd.Parameters.AddWithValue("@dob", dobDate.ToString("yyyy-MM-dd"))
                    Else
                        MsgBox("Invalid date format. Please enter date in YYYY-MM-DD format.", vbCritical)
                        Exit Sub ' Exit if date parsing fails
                    End If
                    If rb1.Checked Then
                        cmd.Parameters.AddWithValue("@gender", rb1.Text)
                    ElseIf rb2.Checked Then
                        cmd.Parameters.AddWithValue("@gender", rb2.Text)
                    End If
                    cmd.Parameters.AddWithValue("@all", pall.Text)
                    cmd.Parameters.AddWithValue("@id", selectedID)

                    Try
                        cmd.ExecuteNonQuery()
                        MsgBox("Patient Updated Successfully")
                    Catch ex As MySqlException
                        MsgBox("Error updating patient: " & ex.Message)
                    End Try
                    conn.Close()
                End If
            End If
        End If
        Populate()
        Reset()


    End Sub
    'LOGOUT
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim confirm = MessageBox.Show("Are you sure you want to logout?", "Confirm exit", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub



    'SEARCH BUTTON CODES
    Private Sub SearchPatients(ByVal searchQuery As String)
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"

            conn.Open()
            Using (conn)
                Dim query As String = "SELECT * FROM Patient WHERE PatName LIKE '%" & searchQuery & "%'"
                Dim adapter As MySqlDataAdapter
                adapter = New MySqlDataAdapter(query, conn)
                Dim builder As New MySqlCommandBuilder(adapter)
                Dim ds As DataSet
                ds = New DataSet
                adapter.Fill(ds)
                pdata.DataSource = ds.Tables(0)

                ' Check if any records are found
                If ds.Tables(0).Rows.Count = 0 Then
                    MsgBox("No patients found with the given name.", vbInformation)
                    Populate()
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while searching for patients: " & ex.Message, vbCritical)
            Populate()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        Dim searchQuery As String = psearch.Text.Trim()
        If Not String.IsNullOrEmpty(searchQuery) Then
            SearchPatients(searchQuery)
        Else
            MsgBox("Please enter a search query.", vbInformation)
        End If
    End Sub
End Class