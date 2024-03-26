Imports System.Security.AccessControl
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports EonaCat.Csv.Model
Imports Microsoft.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Digests
Imports Org.BouncyCastle.Utilities.IO.Pem
Public Class prescription
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Private Sub Populate()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"

        conn.Open()
        Using (conn)
            Dim query = "select * from prescription"
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
        Ppat.Text = ""
        Ptreat.Text = ""
        Pmed.Text = ""
        Pquan.Text = ""
        Pcost.Text = ""

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

        Ppat.DataSource = patients
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

        Ptreat.DataSource = treatment
    End Sub
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If Ppat.Text = "" Or Pmed.Text = "" Or Pcost.Text = "" Or Pquan.Text = "" Then
            MsgBox("Kindly fill out all sections")
        Else
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic"

            If (dbconnect()) Then

                conn.Open()
                Using (conn)

                    Dim cmd = New MySqlCommand("INSERT INTO prescription(PatName,TreatName,TreatCost,Medicine,Qty)VALUES(@patient,@treatment,@cost,@medicine,@quantity)", conn)

                    With cmd.Parameters
                        '.AddWithValue("@pid", pname.Text.Trim())
                        .AddWithValue("@patient", Ppat.Text.Trim())
                        .AddWithValue("@treatment", Ptreat.Text.Trim())
                        .AddWithValue("@cost", Pcost.Text.Trim())
                        .AddWithValue("@medicine", Pmed.Text.Trim())
                        .AddWithValue("@quantity", Pquan.Text.Trim())
                    End With
                    i = cmd.ExecuteNonQuery()
                    If (i > 0) Then
                        MsgBox("treatment Saved successfully", vbInformation)
                    Else
                        MsgBox("Could not Register!!", vbCritical)
                    End If

                End Using
                conn.Close()

                Populate()
                clear()
                Reset()
            End If
        End If
    End Sub
    Private Sub Prescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        FillPatientComboBox()
        FillTreatmentComboBox()
        clear()

    End Sub

    Private Sub pdata_cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles pdata.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < pdata.Rows.Count Then
            ' Get the clicked row
            Dim row As DataGridViewRow = pdata.Rows(e.RowIndex)

            ' Access cell values using column names (assuming you have named columns)
            Ppat.Text = row.Cells("PatName").Value.ToString()
            Ptreat.Text = row.Cells("TreatName").Value.ToString()
            Pmed.Text = row.Cells("Medicine").Value.ToString()
            Pcost.Text = row.Cells("TreatCost").Value.ToString()
            Pquan.Text = row.Cells("Qty").Value.ToString()

        Else
            ' Handle invalid row index (optional)
            MessageBox.Show("Invalid row selected!")
        End If

    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
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

                Dim query = "DELETE FROM prescription WHERE PId=@id"
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

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"
        If pdata.SelectedRows.Count = 0 Then
            MsgBox("Missing Information")
        Else
            Dim selectedID As Integer = pdata.SelectedRows(0).Cells("PId").Value
            conn.Open()

            ' Parameterized query to prevent SQL Injection attacks
            Dim query = "UPDATE prescription SET PatName=@patient, TreatName=@treatment, TreatCost=@cost, Medicine=@medicine ,Qty=@quantity WHERE PId=@id"
            Dim cmd As New MySqlCommand(query, conn)

            ' Add parameters to the query
            cmd.Parameters.AddWithValue("@patient", Ppat.Text)
            cmd.Parameters.AddWithValue("@treatment", Ptreat.Text)
            cmd.Parameters.AddWithValue("@cost", Pcost.Text)
            cmd.Parameters.AddWithValue("@medicine", Pmed.Text)
            cmd.Parameters.AddWithValue("@quantity", Pquan.Text)
            cmd.Parameters.AddWithValue("@id", selectedID)

            Try
                cmd.ExecuteNonQuery()
                MsgBox("treatment  Updated Successfully")
            Catch ex As MySqlException
                MsgBox("Error updating treatment: " & ex.Message)
            End Try
            conn.Close()
        End If

        Populate()
        Reset()
        clear()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        Dim obj = New Patients
        obj.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Dim obj = New treatment
        obj.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Hide()
        Dim obj = New appointment
        obj.Show()
    End Sub
    Private Sub SearchPrescription(ByVal searchQuery As String)
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"

            conn.Open()
            Using (conn)
                Dim query As String = "SELECT * FROM prescription WHERE PatName LIKE '%" & searchQuery & "%'"
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

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        Dim searchQuery As String = psearch.Text.Trim()
        If Not String.IsNullOrEmpty(searchQuery) Then
            SearchPrescription(searchQuery)
        Else
            MsgBox("Please enter a search query.", vbInformation)
        End If
        clear()

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim confirm = MessageBox.Show("Are you sure you want to logout?", "Confirm exit", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


End Class