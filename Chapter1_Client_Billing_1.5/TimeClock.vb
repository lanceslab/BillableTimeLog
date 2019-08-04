

Public Class TimeClock

    ' keeps track of the Start & Stop time for the client billing
    Private DateStartTime As DateTime ' shared class variable
    Private DateStopTime As DateTime ' shared class variable
    Private TimespanElapsedTime As TimeSpan
    Private StringClientName As String

    Public ReadOnly Property StartTime() As DateTime
        Get
            Return DateStartTime
        End Get
    End Property

    Public ReadOnly Property StopTime() As DateTime
        Get
            Return DateStopTime
        End Get
    End Property

    Public ReadOnly Property ElapsedTime() As TimeSpan
        Get
            Return DateStartTime - DateStopTime
        End Get
    End Property

    Public Property ClientName() As String
        Get
            Return StringClientName
        End Get
        Set(ByVal value As String)
            StringClientName = value

        End Set
    End Property

    ' Public function to set the StartTime time stamp
    Public Sub StartClock() ' instance variable
        DateStartTime = DateTime.Now()
    End Sub
    ' Public function to set the StoptTime time stamp
    Public Sub StopClock() ' instance variable
        DateStopTime = DateTime.Now()
    End Sub


End Class
