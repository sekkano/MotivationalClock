Public Class StoreTime

    Dim hour As Integer
    Dim minute As Integer
    Dim second As Integer

    Dim storedTime As New Dictionary(Of String, Integer)

    Dim randomTime As New Random()
    Dim holdTime As Integer

    Dim completeTime As String
    Dim id As Integer
    Dim notes As String


    Public Function RangeTime(userSelectTime1 As Integer, userSelectTime2 As Integer) As Integer
        holdTime = randomTime.Next(userSelectTime1, userSelectTime2)
        Return holdTime
    End Function

    Public Sub New()
        storedTime.Add("hours", 0)
        storedTime.Add("minutes", 0)
        storedTime.Add("seconds", 0)

    End Sub

    Public Property Hours() As Integer
        Get
            Return hour
        End Get
        Set(value As Integer)
            hour = value
        End Set
    End Property

    Public Property Minutes() As Integer
        Get
            Return minute
        End Get
        Set(value As Integer)
            minute = value
        End Set
    End Property

    Public Property Seconds() As Integer
        Get
            Return second
        End Get
        Set(value As Integer)
            second = value
        End Set
    End Property

    Public Property Time() As Dictionary(Of String, Integer)
        Get
            Return storedTime
        End Get
        Set(value As Dictionary(Of String, Integer))
            storedTime = value
        End Set
    End Property

    Public Property dbId() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property dispTime() As String
        Get
            If (completeTime Is Nothing) Then
                Return Format(Hours, "00") & ":" & Format(Minutes, "00") & ":" & Format(Seconds, "00")
            Else
                Return completeTime
            End If

        End Get
        Set(ByVal value As String)
            completeTime = value
        End Set
    End Property

    Public Property dispNotes() As String
        Get
            Return notes
        End Get
        Set(value As String)
            notes = value
        End Set
    End Property


End Class
