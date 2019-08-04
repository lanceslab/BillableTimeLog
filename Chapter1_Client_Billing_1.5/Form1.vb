' Lance Taylor
' 1-29-12
'
' Chapter 1.5
' Client hourly billing tracker

Public Class Form1


    Dim BillingTime As New TimeClock()
    Dim ClientBilling As BillingData



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClientBilling = (New BillingData)    ' ---- I took this out and it still wkd-----------
        ClientBilling.ReadClientFile()

        ' for loop to add Clients to the list for the combobox
        For index = 1 To ClientBilling.Clients.Count
            ComboBoxClientName.Items.Add(ClientBilling.Clients(index).ToString)
        Next



    End Sub
    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        BillingTime.StartClock()
        ' If Name is blank ask 
        If ComboBoxClientName.Text = "" Then
            MessageBox.Show("Enter Name or select from list")  ' else run
        Else

        End If

        LabelStart.Text = BillingTime.StartTime.ToShortTimeString
        LabelBilling.Visible = True
        ButtonStart.Enabled = False
        ButtonExit.Enabled = False
        ComboBoxClientName.Enabled = False
        ButtonStop.Enabled = True

    End Sub

    Private Sub ButtonStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStop.Click

        BillingTime.StopClock()
        ButtonStart.Enabled = True
        ButtonExit.Enabled = True
        LabelBilling.Visible = False
        ComboBoxClientName.Enabled = True
        LabelStop.Text = BillingTime.StopTime.ToShortTimeString

        LabelBillableHrs.Text = BillingTime.ElapsedTime.Hours.ToString & ":" &
                                BillingTime.ElapsedTime.Minutes.ToString & ":" &
                                BillingTime.ElapsedTime.Seconds.ToString
        ' Set the Client Name in the timeclock class
        BillingTime.ClientName = ComboBoxClientName.Text
        ' Write the New client billing information
        ClientBilling.WriteBilling(BillingTime)


    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' close the billing file when form closes
        ' ClientBilling.CloseBilling()

    End Sub


End Class
