Imports System.IO
Imports System.Security.AccessControl
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports EonaCat.Csv.Model
Imports Guna.UI2.WinForms.Suite
Imports Microsoft.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1
Imports Org.BouncyCastle.Crypto.Digests
Imports Org.BouncyCastle.Math.EC.ECCurve
Imports Org.BouncyCastle.Utilities.IO.Pem
Public Class appointment
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Private Sub Populate()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"

        conn.Open()
        Using (conn)
            Dim query = "select * from appointment"
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
        ppat.Text = ""
        ptreat.Text = ""
        pdate.Text = ""
        ptime.Text = ""
    End Function
    Private Sub FillPatientComboBox()
        Dim patients As List(Of String) = New List(Of String)
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"

        conn.Open()

        Try
            Dim query As String = "SELECT PatName FROM Patient"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                patients.Add(reader.GetString(0))
            End While

            reader.Close()
        Catch ex As Exception
            MsgBox("An error occurred while searching for patients: " & ex.Message, vbCritical)
            Populate()
        Finally
            conn.Close()
        End Try

        ppat.DataSource = patients
    End Sub
    Private Sub FillTreatmentComboBox()
        Dim treatment As List(Of String) = New List(Of String)
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"

        conn.Open()

        Try
            Dim query As String = "SELECT TName FROM treatment"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                treatment.Add(reader.GetString(0))
            End While

            reader.Close()
        Catch ex As Exception
            MsgBox("An error occurred while searching for patients: " & ex.Message, vbCritical)
            Populate()
        Finally
            conn.Close()
        End Try

        ptreat.DataSource = treatment
    End Sub

    Private Sub appointment_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        FillPatientComboBox()
        FillTreatmentComboBox()
        clear()
    End Sub


    Private Sub Searchappointment(ByVal searchQuery As String)
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"

            conn.Open()
            Using (conn)
                Dim query As String = "SELECT * FROM appointment WHERE ApPat LIKE '%" & searchQuery & "%'"
                Dim adapter As MySqlDataAdapter
                adapter = New MySqlDataAdapter(query, conn)
                Dim builder As New MySqlCommandBuilder(adapter)
                Dim ds As DataSet
                ds = New DataSet
                adapter.Fill(ds)
                pdata.DataSource = ds.Tables(0)

                ' Check if any records are found
                If ds.Tables(0).Rows.Count = 0 Then
                    MsgBox("No appointment found with the given name.", vbInformation)
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while searching for prescription: " & ex.Message, vbCritical)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim confirm = MessageBox.Show("Are you sure you want to logout?", "Confirm exit", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Label9_Click_1(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        Dim obj = New Patients
        obj.Show()
    End Sub

    Private Sub Label10_Click_1(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Hide()
        Dim obj = New treatment
        obj.Show()
    End Sub

    Private Sub Label11_Click_1(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Hide()
        Dim obj = New prescription
        obj.Show()
    End Sub

    Private Sub pdata_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles pdata.CellContentClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < pdata.Rows.Count Then
            Dim row = pdata.Rows(e.RowIndex)

            ppat.Text = row.Cells("ApPat").Value.ToString
            ptreat.Text = row.Cells("ApTreat").Value.ToString

            ' Assuming ApDate and ApTime are the names of your columns for the appointment date and time
            Dim appointmentDate As Date
            Dim appointmentTime As Date

            ' Parse the date and time from the DataGridView row. Adjust the format as necessary.
            If Date.TryParse(row.Cells("ApDate").Value.ToString, appointmentDate) Then
                pdate.Value = appointmentDate
            Else
                MessageBox.Show("Invalid date format in the selected row.")
            End If

            If Date.TryParse(row.Cells("ApTime").Value.ToString, appointmentTime) Then
                ' Since DateTimePicker can't just display time, we combine the date from the DateTimePickerDate
                ' with the time from the appointmentTime to ensure the DateTimePickerTime shows the correct time.
                ' This is under the assumption that your system's format for time is compatible. If it stores time
                ' in a different format, additional parsing may be needed.
                ptime.Value = pdate.Value.Date.AddHours(appointmentTime.Hour).AddMinutes(appointmentTime.Minute).AddSeconds(appointmentTime.Second)
            Else
                MessageBox.Show("Invalid time format in the selected row.")
            End If
        Else
            MessageBox.Show("Invalid row selected!")
        End If


    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        If pdata.SelectedRows.Count > 0 Then
            ' Get the selected appointment's ID
            Dim selectedID = Convert.ToInt32(pdata.SelectedRows(0).Cells("ApId").Value)

            ' Fetch the appointment details from the database based on the ID
            Dim query = "SELECT * FROM appointment WHERE ApId = @id"
            Using conn As New MySqlConnection("server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"),
                cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", selectedID)
                conn.Open()

                Dim reader = cmd.ExecuteReader
                If reader.Read Then
                    ' Populate the form fields with the fetched appointment details
                    ppat.Text = reader("ApPat").ToString
                    ptreat.Text = reader("ApTreat").ToString

                    Dim appointmentDate = Convert.ToDateTime(reader("ApDate"))
                    pdate.Value = appointmentDate.Date

                    ' Fetch the appointment time as TimeSpan
                    Dim appointmentTime As TimeSpan = reader("ApTime")
                    ' Combine the appointment date from pdate and appointment time to set ptime
                    Dim combinedDateTime = pdate.Value.Date.Add(appointmentTime)
                    ptime.Value = combinedDateTime
                End If
            End Using
        Else
            MsgBox("Please select an appointment to edit.")
        End If

        Populate()
        clear()
        Reset()

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If ppat.Text = "" Or pdate.Text = "" Or ptime.Text = " " Then
            MsgBox("Kindly fill out all sections")
        Else
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic"

            If dbconnect() Then


                conn.Open()

                Using conn
                    Dim cmd = New MySqlCommand("INSERT INTO appointment(ApPat,ApTreat,ApDate,ApTime)VALUES(@patient,@treatment,@date,@time)", conn)
                    With cmd.Parameters

                        .AddWithValue("@patient", ppat.Text.Trim)

                        .AddWithValue("@treatment", ptreat.Text.Trim)

                        Dim pdateDate As Date
                        If Date.TryParse(pdate.Text.Trim, pdateDate) Then
                            .AddWithValue("@date", pdateDate.ToString("yyyy-MM-dd"))
                        Else
                            MsgBox("Invalid date format. Please enter date in YYYY-MM-DD format.", vbCritical)
                            Exit Sub ' Exit if date parsing fails
                        End If
                        Dim ptimeDate As Date
                        .AddWithValue("@time", ptimeDate.ToString("HH:mm:ss"))



                    End With
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Patient Saved successfully", vbInformation)
                    Else
                        MsgBox("Could not Register!!", vbCritical)
                    End If

                End Using
                conn.Close()


            End If
        End If
        Populate()
        Reset()
        clear()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        If pdata.SelectedRows.Count > 0 Then
            Dim confirm = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Delete", MessageBoxButtons.YesNo)
            If confirm = DialogResult.Yes Then
                ' Get the selected appointment's ID
                Dim selectedID = Convert.ToInt32(pdata.SelectedRows(0).Cells("ApId").Value)

                ' Delete the appointment from the database
                Dim query = "DELETE FROM appointment WHERE ApId = @id"
                Using conn As New MySqlConnection("server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"),
                  cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", selectedID)
                    conn.Open()

                    Dim rowsAffected = cmd.ExecuteNonQuery
                    If rowsAffected > 0 Then
                        MsgBox("Appointment deleted successfully.")
                    Else
                        MsgBox("Failed to delete appointment.")
                    End If
                End Using

                ' Refresh the DataGridView after deletion
                Populate()
            End If
        Else
            MsgBox("Please select an appointment to delete.")
        End If


        Reset()
        clear()
    End Sub

    Private Sub psearch_Click(sender As Object, e As EventArgs) Handles psearch.Click
        Dim searchQuery As String = psearch.Text.Trim()
        If Not String.IsNullOrEmpty(searchQuery) Then
            Searchappointment(searchQuery)
        Else
            MsgBox("Please enter a search query.", vbInformation)
        End If
    End Sub
End Class
