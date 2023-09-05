Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hk1 As Double
        Dim hk2 As Double
        hk1 = Double.Parse(txthk1.Text)
        hk2 = Double.Parse(txthk2.Text)
        Dim dtb As New Double()
        dtb = (hk1 + hk2 * 2) / 3
        txttb.Text = dtb
        If dtb >= 5 Then
            txtkq.Text = "Được lên lớp"
        Else
            txtkq.Text = "ở lại lớp"
        End If
        Dim hocluc As String
        If dtb < 5 Then
            hocluc = "Yếu"
        ElseIf (dtb >= 5 And dtb < 7) Then
            hocluc = "Trung Bình"
        ElseIf (dtb >= 7 And dtb < 8) Then
            hocluc = "Kha"
        Else
            hocluc = "Giỏi"
        End If
        txthl.Text = hocluc
    End Sub
End Class
