Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ListBox1.Items.Add(TextBox1.Text.Trim)
        Label1.Text = TextBox1.Text.Trim
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim Word As String = ListBox1.Text
        If ListBox1.Items.Add(TextBox1.Text.Trim) = True Then
            MessageBox.Show("Item aleady Exists") 'duplication not allowed
        Else
            ListBox1.Items.Add(Word)
        End If
    End Sub
    Private Sub RdToLower_CheckedChanged(sender As Object, e As EventArgs) Handles rdToLower.CheckedChanged
        Label1.Text = Label1.Text.ToLower()
    End Sub
    Private Sub RdToUpper_CheckedChanged(sender As Object, e As EventArgs) Handles rdToUpper.CheckedChanged
        Label1.Text = Label1.Text.ToUpper()
    End Sub
    Private Sub RdPurple_CheckedChanged(sender As Object, e As EventArgs) Handles rdPurple.CheckedChanged
        Label1.ForeColor = Color.Purple
    End Sub
    Private Sub RdBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rdBlue.CheckedChanged
        Label1.ForeColor = Color.Blue
    End Sub
End Class
