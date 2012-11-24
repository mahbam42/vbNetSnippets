
Partial Class enc
    Inherits System.Web.UI.Page

   Protected Sub btnEnrypt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEnrypt.Click
      Dim oED As New Encryption64
      Dim strValues As String = txtEncrp.Text
      Dim strURL As String = ""
      'strURL = "http://www.ajula.edu/misc/ajuunsubscribe.aspx?ceid=23&guid="
      strURL += oED.Encrypt(strValues, "!#$a54?3")
      txtKey.Text = strURL

   End Sub

   Protected Sub btnDecrypt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
      Dim oED As New Encryption64
      Dim strValues As String = txtDecrypt.Text
      Dim strURL As String = ""
      'strURL = "http://www.ajula.edu/misc/ajuunsubscribe.aspx?ceid=23&guid="
      strURL += oED.Decrypt(strValues, "!#$a54?3")
      txtResults.Text = strURL

   End Sub
End Class
