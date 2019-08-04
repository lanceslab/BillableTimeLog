
Imports System.IO
Imports System.IO.File


Public Class BillingData

    Private ClientFileWriter As StreamWriter ' to add to the client file
    Private ClientFileReader As StreamReader ' to read the client file

    Private BillingFileWriter As StreamWriter
    ' create a collection for the clients
    Private ClientsCollection As New Collection

    ' Property to return the Clients collection
    Public ReadOnly Property Clients As Collection
        Get
            Return ClientsCollection
        End Get
    End Property
    ' Constructr for reading the two files
    Public Sub ReadClientFile()
        Try
            ClientFileReader = OpenText("clients.txt")
            ' check for the end of the string
            While Not ClientFileReader.EndOfStream
                ClientsCollection.Add(ClientFileReader.ReadLine())
            End While
            ' when we reach the end of the file this closes the file
            ClientFileReader.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to open file")
        End Try

    End Sub



    ' method to write to the billing file
    ' takes a string as the input and writeline as output
    Public Sub WriteBilling(ByVal record As TimeClock) ' datatype of timeclock class

        Dim clientBillString As String
        clientBillString = Date.Now.ToString & "," & record.ClientName & "," _
                            & record.StartTime.ToShortTimeString & "," _
                            & record.StopTime.ToShortTimeString & "," _
                            & record.ElapsedTime.Minutes.ToString

        Dim foundClient As Boolean = False

        For index As Integer = 1 To Clients.Count
            ' Loop thru the client list & check to see if ClientName is present
            ' If they're the same then EXIT the loop
            If record.ClientName.ToUpper = Clients(index).ToString.ToUpper Then
                foundClient = False
                Exit For

            End If
            ' If they're Not the same CHANGE boolean to true
            If record.ClientName.ToUpper <> Clients(index).ToString.ToUpper Then
                foundClient = True
            End If
        Next
        ' If boolean true add Name to client list
        If foundClient = True Then
            ClientFileWriter = New StreamWriter("clients.txt", True)
            ClientFileWriter.WriteLine(record.ClientName)
            ClientFileWriter.Close()
        End If

        ' -------------- Write to the billing file -------------
        Try
            If Exists("billing.txt") Then
                ' if the file exists then we append to it
                BillingFileWriter = AppendText("billing.txt")
                BillingFileWriter.WriteLine(clientBillString)
                BillingFileWriter.Close()
            Else
                ' if not , we create the txt file
                BillingFileWriter = CreateText("billing.txt")
                BillingFileWriter.WriteLine(clientBillString)
                BillingFileWriter.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to open or create file")
        End Try


    End Sub
    ' method to close the billing file
    Public Sub CloseBilling()
        BillingFileWriter.Close()
    End Sub



End Class
