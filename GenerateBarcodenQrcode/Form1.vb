Imports ZXing
Imports QRCoder
Public Class Form1
    Private Sub bbarcode_Click(sender As Object, e As EventArgs) Handles bbarcode.Click
        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.CODE_128
        pic1.Image = writer.Write(teks.Text)
    End Sub

    Private Sub bqrcode_Click(sender As Object, e As EventArgs) Handles bqrcode.Click
        Dim generate As New QRCodeGenerator
        Dim data = generate.CreateQrCode(teks.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        pic1.Image = code.GetGraphic(6)
    End Sub
End Class
