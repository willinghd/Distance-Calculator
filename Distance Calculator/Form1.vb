Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Local Variable declarations
        Dim speed As String = InputBox("Please enter the speed in MPH")
        Dim time As String = InputBox("Please enter the time traveled in hours")

        ' Simple error check to ensure valid data
        If Not IsNumeric(speed) Or Not IsNumeric(time) Then
            MessageBox.Show("Invalid data, enter numeric values only")

            Exit Sub
        End If

        ' Display header information
        TextBox1.Text = "Vehicle Speed: " & speed & " MPH" & vbCrLf
        TextBox1.Text += "Time Traveled: " & time & " hours" & vbCrLf
        TextBox1.Text += vbCrLf
        TextBox1.Text += "Hours" & vbTab & "Distance Traveled" & vbCrLf
        TextBox1.Text += New String("-", 45) & vbCrLf

        ' Get and display distance totals
        For i As Integer = 1 To time
            TextBox1.Text += i.ToString
            TextBox1.Text += vbTab
            TextBox1.Text += (CInt(speed) * i).ToString  
            TextBox1.Text += vbCrLf
        Next

        ' Display Total Distance
        TextBox1.Text += New String("-", 45) & vbCrLf
        TextBox1.Text += "Total Distance: " & (speed * time).ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
