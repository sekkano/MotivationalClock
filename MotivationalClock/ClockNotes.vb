Imports System.Data.SqlClient

Public Class ClockNotes

    Dim pullDbID As Integer

    Private Sub ClockNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim dbConnection = MotivationalForm.openDbConnection()

        ' Getting the Database ID from MotivationalForm and setting it to pullDbID
        pullDbID = MotivationalForm.getDbID

        Dim sqlString As String = "SELECT notes FROM Times WHERE id=@id"

        Dim selectCommand As New SqlCommand(sqlString, dbConnection)
        selectCommand.Parameters.AddWithValue("@id", pullDbID)

        Dim reader As SqlDataReader = selectCommand.ExecuteReader()

        If (reader.HasRows) Then
            Try
                reader.Read()
                txtNotes.Text = reader.Item("notes")
            Catch ex As Exception
                txtNotes.Text = "Please add your own comments in this window."
            End Try

        End If

        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        Dim dbConnection = MotivationalForm.openDbConnection()

        Dim sqlString As String = "UPDATE Times SET notes = @notes WHERE Id = @id"
        Dim updateCommand As New SqlCommand(sqlString, dbConnection)

        ' Getting the Database ID from MotivationalForm and setting it to pullDbID
        pullDbID = MotivationalForm.getDbID

        Try
            updateCommand.Parameters.Add("@id", Data.SqlDbType.Int).Value = pullDbID
            updateCommand.Parameters.Add("@notes", SqlDbType.VarChar).Value = txtNotes.Text

        Catch ex As Exception
            MessageBox.Show("Failed to update the database.")
        End Try

        Try
            Dim result As Integer = updateCommand.ExecuteNonQuery()
            MessageBox.Show("Notes saved successfully.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        dbConnection.Close()
        dbConnection.Dispose()

        Me.Close()
    End Sub

End Class