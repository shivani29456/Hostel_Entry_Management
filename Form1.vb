Public Class Login_Form

    Dim sqlconn As SqlClient.SqlConnection
    Dim command As SqlClient.SqlCommand



   



    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click

        Dim SAPI As Object
        SAPI = CreateObject("SAPI.spvoice")
        If Txt_User.Text = "admin" And Txt_password.Text = 1234 Then
            SAPI.speak("welcome admin ")
            Me.Hide()
            Dim form4 As New StudentPortal_Form
            form4.ShowDialog()
            Me.Close()


        ElseIf Txt_User.Text = "hostler" And Txt_password.Text = 1234 Then
            Me.Hide()

            SAPI.speak("welcome to Entry Form ")
            Dim form3 As New Entry_Form
            form3.ShowDialog()

            Me.Close()


        Else



            MessageBox.Show("Invalid user name or password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If


    End Sub

    Private Sub Btn_Reset_Click(sender As Object, e As EventArgs) Handles Btn_Reset.Click
        Txt_User.Clear()
        Txt_password.Clear()
        Txt_User.Focus()
    End Sub

    Private Sub Btn_check_Click(sender As Object, e As EventArgs) Handles Btn_check.Click
        If MsgBoxResult.No = MsgBox("do you want to exit?", MsgBoxStyle.YesNo) Then Exit Sub
        Me.Close()
    End Sub

    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlconn = New SqlClient.SqlConnection
        sqlconn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Shivani\Documents\Shivani.mdf;Integrated Security=True;Connect Timeout=30"
        Try
            sqlconn.Open()
            ' MessageBox.Show("Connection Successful")
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()
        End Try
    End Sub
End Class
