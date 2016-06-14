' I also need to handel for none integer input in the text boxes for setting time.
' I will not need this for the Notes form since they can do what ever they want.


Imports System
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class MotivationalForm
    Dim currentTime As String
    Dim hours As Integer
    Dim minutes As Integer
    Dim seconds As Integer
    'Dim test2 As Integer

    Dim totalTime As New StoreTime
    Dim timeList As New BindingList(Of StoreTime)

    Public getDbID As Integer

    ' Create a variable to hold the ID that we get from the database
    Dim currentId As Integer
    Dim lastDBId As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Centers screen and disables the start button
        Me.CenterToScreen()
        btnStart.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

        lstEntry.DataSource = timeList
        lstEntry.DisplayMember = "dispTime"

        Dim dbConnection = openDbConnection()

        Dim sqlString As String = "SELECT * FROM Times"
        Dim selectCommand As New SqlCommand(sqlString, dbConnection)

        Try
            Dim reader As SqlDataReader = selectCommand.ExecuteReader()

            If (reader.HasRows) Then
                While (reader.Read)
                    ' create a time object to hold the information
                    ' only exists in the loop (The scope)
                    Dim dbTimeHold As New StoreTime()

                    dbTimeHold.dbId = CInt(reader.Item("Id"))

                    dbTimeHold.dispTime = reader.Item("time").ToString

                    currentId = CInt(reader.Item("Id"))
                    lastDBId = CInt(reader.Item("Id"))

                    ' Add dbTimeHold object to the list box lstEntry
                    timeList.Add(dbTimeHold)

                End While
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        Dim soundCount As Integer = 0
        ' Minus one from seconds every tick (1000ms)
        seconds -= 1

        ' Checks for less than 0 in hours, minutes and seconds and subtracts 1 when appropriate
        If (seconds < 0) Then
            seconds = 59
            minutes -= 1

            If (minutes <= 0 And hours > 0) Then
                hours -= 1
                minutes = 59

            ElseIf (minutes < 0) Then
                minutes = 0
            End If


        ElseIf (seconds <= 0 And minutes <= 0) Then
            tmrTimer.Enabled = False

            Do While (soundCount < 8)
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
                soundCount += 1
            Loop

        End If


        lblCountDown.Text = Format(hours, "00") & ":" & Format(minutes, "00") & ":" & Format(seconds, "00")

    End Sub

    Private Sub btnRangeZeroThirty_Click(sender As Object, e As EventArgs) Handles btnRangeZeroThirty.Click
        currentTime = CreateTime(totalTime.RangeTime(300, 1810))

        If (Not btnStop.Enabled) Then
            btnStop.Enabled = True
        End If

        lblCountDown.Text = currentTime
        tmrTimer.Enabled = True
        tmrTimer.Start()
    End Sub

    Private Sub btnRangeThirtySixty_Click(sender As Object, e As EventArgs) Handles btnRangeThirtySixty.Click
        currentTime = CreateTime(totalTime.RangeTime(1810, 3620))

        If (Not btnStop.Enabled) Then
            btnStop.Enabled = True

        End If

        lblCountDown.Text = currentTime
        tmrTimer.Enabled = True
        tmrTimer.Start()

    End Sub

    Private Sub btnRangeSixtyNinety_Click(sender As Object, e As EventArgs) Handles btnRangeSixtyNinety.Click
        currentTime = CreateTime(totalTime.RangeTime(3620, 7240))

        If (Not btnStop.Enabled) Then
            btnStop.Enabled = True
        End If

        lblCountDown.Text = currentTime
        tmrTimer.Enabled = True
        tmrTimer.Start()
    End Sub

    Public Function CreateTime(Time As Integer) As String
        seconds = Time Mod 60
        minutes = ((Time - seconds) / 60) Mod 60
        hours = ((Time - (seconds + (minutes * 60))) / 3600) Mod 60

        totalTime.Hours = hours
        totalTime.Minutes = minutes
        totalTime.Seconds = seconds

        Return Format(hours, "00") & ":" & Format(minutes, "00") & ":" & Format(seconds, "00")

    End Function

    Public Function CreateTime(hours As Integer, minutes As Integer, seconds As Integer) As String

        totalTime.Hours = hours
        totalTime.Minutes = minutes
        totalTime.Seconds = seconds

        Return Format(hours, "00") & ":" & Format(minutes, "00") & ":" & Format(seconds, "00")

    End Function

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmrTimer.Enabled = False
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrTimer.Enabled = True
        btnStart.Enabled = False
        btnStop.Enabled = True
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnStart.Enabled = False

        currentTime = "00:00:00"
        tmrTimer.Enabled = False
        lblCountDown.Text = "00:00:00"
    End Sub

    Private Sub btnSetTime_Click(sender As Object, e As EventArgs) Handles btnSetTime.Click

        Try
            seconds = CInt(txtSeconds.Text)
            minutes = CInt(txtMinutes.Text)
            hours = CInt(txtHours.Text)

            tmrTimer.Enabled = False

            currentTime = CreateTime(hours, minutes, seconds)
            lblCountDown.Text = currentTime
            btnStart.Enabled = True
            btnStop.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Please enter a number.")
        End Try



    End Sub

    Private Sub btnAddTime_Click(sender As Object, e As EventArgs) Handles btnAddTime.Click

        Dim newTime As New StoreTime

        newTime.Hours = hours
        newTime.Minutes = minutes
        newTime.Seconds = seconds

        ' Checks if there is a value in the time.
        If (IsNothing(currentTime) OrElse currentTime.Contains("00:00:00")) Then
            MessageBox.Show("Please enter a time to store.")
        Else
            ' Adding the chosen time to the list
            newTime.dispTime = currentTime

            Dim dbConnection = openDbConnection()

            ' Creating a new time and creating a new id to be inserted into the database

            newTime.dbId = lastDBId + 1

            Dim saveCommand As SqlCommand

            saveCommand = prepareInsert(dbConnection, newTime)
            lastDBId = newTime.dbId

            Dim result As Integer = saveCommand.ExecuteNonQuery()
            timeList.Add(newTime)

            dbConnection.Close()
            dbConnection.Dispose()
        End If


    End Sub

    Private Sub lstEntry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEntry.SelectedIndexChanged

        If (Not lstEntry.SelectedItem Is Nothing) Then
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            ' Added this to try something
            ' This did it! This code allows the dbID to be set when clicked.
            totalTime = CType(lstEntry.SelectedItem, StoreTime)
            getDbID = totalTime.dbId
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim editForm = New ClockNotes()

        If (Not lstEntry.SelectedItem Is Nothing) Then
            editForm.Show()
        End If

        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Function prepareInsert(dbConnection As SqlConnection, newTime As StoreTime) As SqlCommand
        Dim sqlString As String = "INSERT INTO Times (Id, time, notes) VALUES (@id, @time, @notes)"
        Dim insertCommand As New SqlCommand(sqlString, dbConnection)

        insertCommand.Parameters.Add("@id", Data.SqlDbType.Int).Value = newTime.dbId
        insertCommand.Parameters.Add("@time", SqlDbType.VarChar).Value = newTime.dispTime
        insertCommand.Parameters.Add("@notes", SqlDbType.VarChar).Value = "Please add your own comments in this window."


        Return insertCommand
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dbConnection = openDbConnection()

        Dim sqlString As String = "DELETE FROM Times WHERE Id = @id"
        Dim deleteCommand As New SqlCommand(sqlString, dbConnection)

        deleteCommand.Parameters.AddWithValue("@id", totalTime.dbId)

        Try
            Dim result As Integer = deleteCommand.ExecuteNonQuery()
            MessageBox.Show("The time was successfully deleted.")
        Catch ex As Exception
            MessageBox.Show("The time was not deleted successfully.")
        End Try

        timeList.Remove(CType(lstEntry.SelectedItem, StoreTime))
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Shared Function openDbConnection() As SqlConnection

        'Change the connectionString to the correct Database location.
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Turtle\Dropbox\VisualBasic\MotivationalClock\MotivationalClock\UserTimes.mdf;Integrated Security=True"
        Dim dbConnection As New SqlConnection(connectionString)

        dbConnection.Open()
        Return dbConnection

    End Function
End Class
