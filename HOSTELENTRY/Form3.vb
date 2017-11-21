Public Class Entry_Form

    Dim sqlconn As SqlClient.SqlConnection
    Dim command1 As SqlClient.SqlCommand

    Private Sub Cmb_Purpose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Purpose.SelectedIndexChanged

    End Sub

    Private Sub Entry_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cmb_Purpose.Items.Add("Department")
        Cmb_Purpose.Items.Add("Library")
        Cmb_Purpose.Items.Add("Home")
        Cmb_Purpose.Items.Add("ATM")
        Cmb_Purpose.Items.Add("Canteen")
        Cmb_Purpose.Items.Add("Outing")
        Cmb_Purpose.Items.Add("Others")




    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Dim userid As String = Txt_Aadharno.Text
        sqlconn = New SqlClient.SqlConnection
        sqlconn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Anuradha\Documents\Anuradha.mdf;Integrated Security=True;Connect Timeout=30"

        Try
            If sqlconn.State = ConnectionState.Closed Then
                sqlconn.Open()
            End If


            Dim sda1 As New SqlClient.SqlDataAdapter("select Aadhar from Student where Aadhar = '" + Txt_Aadharno.Text + "'", sqlconn)
            Dim dt1 As New DataTable()
            sda1.Fill(dt1)

            Dim sda As New SqlClient.SqlDataAdapter("select Count from Log_Track where Aadhar = '" + Txt_Aadharno.Text + "' and Current_Status='absent'", sqlconn)
            Dim dt As New DataTable()
            sda.Fill(dt)

            If dt1.Rows.Count <= 0 Then

                MessageBox.Show("Invalid Aadhar..!!")
            ElseIf (dt1.Rows.Count > 0) And ((dt.Rows.Count <= 0)) Then

                command1 = New SqlClient.SqlCommand("AddLogTrack", sqlconn)
                command1.CommandType = CommandType.StoredProcedure
                command1.Parameters.AddWithValue("@Aadhar", userid)
                command1.Parameters.AddWithValue("@Current_Status", "present")
                command1.Parameters.AddWithValue("@LogDate", Date.Today)
                command1.Parameters.AddWithValue("@LoginRecord", Format(Now, "hh:mm:ss tt"))
                command1.Parameters.AddWithValue("@Logoutrecord", "00:00:00")
                command1.Parameters.AddWithValue("@Purpose", Cmb_Purpose.Text)
                command1.Parameters.AddWithValue("@Count", "off")
                command1.ExecuteNonQuery()
                command1 = New SqlClient.SqlCommand("", sqlconn)
                command1.CommandText = ("Update Log_Track set Current_Status='absent',Count='off' where  Aadhar = '" + Txt_Aadharno.Text + "' and Loginrecord='" & TimeOfDay & "'")
                command1.ExecuteNonQuery()
                MessageBox.Show("Login done Successfully..!!")
            Else
                MessageBox.Show("You are already logged in..!! ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)




            End If
            Txt_Aadharno.Clear()


            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()

        End Try

    End Sub

    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs) Handles Btn_Logout.Click

        sqlconn = New SqlClient.SqlConnection
        sqlconn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Anuradha\Documents\Anuradha.mdf;Integrated Security=True;Connect Timeout=30"
        Try
            If sqlconn.State = ConnectionState.Closed Then
                sqlconn.Open()
            End If
            Dim sda As New SqlClient.SqlDataAdapter("select Current_Status from Log_Track where   Aadhar = '" + Txt_Aadharno.Text + "' and Count='off'", sqlconn)
            Dim dt As New DataTable()
            sda.Fill(dt)

            Dim sda1 As New SqlClient.SqlDataAdapter("select Aadhar from Student where Aadhar = '" + Txt_Aadharno.Text + "'", sqlconn)
            Dim dt1 As New DataTable()
            sda1.Fill(dt1)
            If dt1.Rows.Count <= 0 Then
                MessageBox.Show("Invalid Aadhar Number")

            ElseIf dt1.Rows.Count > 0 And dt.Rows.Count > 0 Then

                Dim cmd As New SqlClient.SqlCommand
                Dim cmd1 As New SqlClient.SqlCommand
                cmd1 = New SqlClient.SqlCommand("Update Log_Track set LogoutRecord='" & TimeOfDay & "' where  Aadhar = '" + Txt_Aadharno.Text + "' and Count='off'", sqlconn)
                cmd1.ExecuteNonQuery()

                cmd = New SqlClient.SqlCommand("Update Log_Track set Current_Status='present',Count='on'  where  Aadhar = '" + Txt_Aadharno.Text + "' and  Count='off' ", sqlconn)
                cmd.ExecuteNonQuery()






                MessageBox.Show("Log Out Successfully..!!")


            Else
                MessageBox.Show("To Logout make sure you are logged in..!! ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Txt_Aadharno.Clear()

            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()

        End Try




    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Hide()
        Dim form1 As New Login_Form
        form1.ShowDialog()

        Me.Close()

    End Sub

   

  
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class