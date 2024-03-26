Imports System.Security.AccessControl
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports EonaCat.Csv.Model
Imports Microsoft.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Digests
Imports Org.BouncyCastle.Utilities.IO.Pem
Public Class treatment
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Private Sub Populate()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"

        conn.Open()
        Using (conn)
            Dim query = "select * from treatment"
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
        Ptreat.Text = ""
        Pcos.Text = ""
        Pdesc.Text = ""
    End Function

    Private Function TreatmentExists(ByVal Ptreat As String) As Boolean
        Dim exists As Boolean = False
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic"

            If (dbconnect()) Then
                conn.Open()
                Using (conn)
                    Dim query As String = "SELECT COUNT(*) FROM treatment WHERE TName = @treatment"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@treatment", Ptreat)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        exists = True
                    End If
                End Using
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occurred while checking if treatment exists: " & ex.Message, vbCritical)
        End Try
        Return exists
    End Function

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If Ptreat.Text = "" Or Pcos.Text = "" Or Pdesc.Text = "" Then
            MsgBox("Kindly fill out all sections")
        Else
            If TreatmentExists(Ptreat.Text.Trim()) Then
                MsgBox("Treatment already exists.", vbExclamation)
            Else
                conn = New MySqlConnection
                conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic"

                If (dbconnect()) Then


                    conn.Open()
                    Using (conn)
                        Dim cmd = New MySqlCommand("INSERT INTO treatment(TName,TCost,TDesc)VALUES(@treatment,@cost,@description)", conn)

                        With cmd.Parameters

                            .AddWithValue("@treatment", Ptreat.Text.Trim())

                            .AddWithValue("@cost", Pcos.Text.Trim())
                            .AddWithValue("@description", Pdesc.Text.Trim())

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
                End If
            End If
        End If
    End Sub
    Private Sub treatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub pdata_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles pdata.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < pdata.Rows.Count Then
            Dim row As DataGridViewRow = pdata.Rows(e.RowIndex)

            Ptreat.Text = row.Cells("TName").Value.ToString()
            Pcos.Text = row.Cells("TCost").Value.ToString()
            Pdesc.Text = row.Cells("TDesc").Value.ToString()
        Else
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
                Dim selectedTreatmentID As Integer = CInt(pdata.Rows(selectedRowIndex).Cells("TId").Value)

                conn.Open()

                Dim query = "DELETE FROM treatment WHERE TId=@TId"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@TId", selectedTreatmentID)

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("treatment Deleted Successfully")
                Catch ex As MySqlException
                    MsgBox("Error deleting treatment: " & ex.Message)
                End Try

                conn.Close()
            End If
            Populate()
            Reset()
            clear()
        End If
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Dim conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"
        If pdata.SelectedRows.Count = 0 Then
            MsgBox("Missing Information")
        Else
            Dim selectedID As Integer = pdata.SelectedRows(0).Cells("TId").Value
            If TreatmentExists(Ptreat.Text.Trim()) Then
                MsgBox("Treatment already exists.", vbExclamation)
            Else
                conn.Open()

                ' Parameterized query to prevent SQL Injection attacks
                Dim query = "UPDATE treatment SET TName=@name, TCost=@cost WHERE TId=@id"
                Dim cmd As New MySqlCommand(query, conn)

                ' Add parameters to the query
                cmd.Parameters.AddWithValue("@name", Ptreat.Text)
                cmd.Parameters.AddWithValue("@cost", Pcos.Text)
                cmd.Parameters.AddWithValue("@description", Pdesc.Text)
                cmd.Parameters.AddWithValue("@id", selectedID)

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("treatment  Updated Successfully")
                Catch ex As MySqlException
                    MsgBox("Error updating treatment: " & ex.Message)
                End Try
                conn.Close()
            End If
        End If

        Populate()
        clear()
        Reset()
    End Sub
    'LINKS FOR THE FORMS

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        Dim obj = New Patients
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
    'SEARCH BUTTON CODES
    Private Sub SearchTreatment(ByVal searchQuery As String)
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=dental_clinic;Allow Zero Datetime=True"

            conn.Open()
            Using (conn)
                Dim query As String = "SELECT * FROM treatment WHERE TName LIKE '%" & searchQuery & "%'"
                Dim adapter As MySqlDataAdapter
                adapter = New MySqlDataAdapter(query, conn)
                Dim builder As New MySqlCommandBuilder(adapter)
                Dim ds As DataSet
                ds = New DataSet
                adapter.Fill(ds)
                pdata.DataSource = ds.Tables(0)

                ' Check if any records are found
                If ds.Tables(0).Rows.Count = 0 Then
                    MsgBox("No treatments found with the given name.", vbInformation)
                    Populate()
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while searching for treatments: " & ex.Message, vbCritical)
            Populate()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        Dim searchQuery As String = psearch.Text.Trim()
        If Not String.IsNullOrEmpty(searchQuery) Then
            SearchTreatment(searchQuery)
        Else
            MsgBox("Please enter a search query.", vbInformation)
        End If
    End Sub

    Private Sub Logout_click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim confirm = MessageBox.Show("Are you sure you want to logout?", "Confirm exit", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class