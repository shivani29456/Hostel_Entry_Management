Public Class Add_Form
    Dim sqlconn As SqlClient.SqlConnection
    Dim command As SqlClient.SqlCommand
    Private Sub Add_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmb_Branch.Items.Add("CSE")
        Cmb_Branch.Items.Add("IT")
        Cmb_Branch.Items.Add("ECE")
        Cmb_Branch.Items.Add("CIVIL")
        Cmb_Branch.Items.Add("OTHER")
        Cmb_Dept.Items.Add("IT")
        Cmb_Dept.Items.Add("PHARMACY")
        Cmb_Dept.Items.Add("BOTANY")
        Cmb_Dept.Items.Add("OTHER")
        Cmb_Year.Items.Add("First")
        Cmb_Year.Items.Add("Second")
        Cmb_Year.Items.Add("Third")
        Cmb_Year.Items.Add("Fourth")
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click

        sqlconn = New SqlClient.SqlConnection
        sqlconn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Anuradha\Documents\Anuradha.mdf;Integrated Security=True;Connect Timeout=30"
        Try
            sqlconn.Open()


            command = New SqlClient.SqlCommand("Student_Data", sqlconn)

            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@Student_Name", Txt_Name.Text)
            command.Parameters.AddWithValue("@Fathers_Name", Txt_FathersName.Text)
            command.Parameters.AddWithValue("@Mothers_Name", Txt_Mothername.Text)
            command.Parameters.AddWithValue("@Aadhar", Txt_Aadharno.Text)


            command.Parameters.AddWithValue("DOB", DateTimePicker1.Text)
            command.Parameters.AddWithValue("@Mobile_Number", Txt_Mobileno.Text)
            command.Parameters.AddWithValue("@Email_Id", Txt_Emailid.Text)
            command.Parameters.AddWithValue("@Address", Txt_Address.Text)
            command.Parameters.AddWithValue("@City", Txt_City.Text)
            command.Parameters.AddWithValue("@State", Txt_State.Text)
            command.Parameters.AddWithValue("@Pincode", Txt_Pincode.Text)

            command.Parameters.AddWithValue("@Branch", Cmb_Branch.Text)
            command.Parameters.AddWithValue("@Dept", Cmb_Dept.Text)
            command.Parameters.AddWithValue("@Year", Cmb_Year.Text)

            command.Parameters.AddWithValue("@Room_No", Txt_Roomno.Text)

            command.ExecuteNonQuery()

            MessageBox.Show("Successfully Added..!!")
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()

        End Try

        Txt_Name.Text = " "
        Txt_FathersName.Text = " "
        Txt_Mothername.Text = " "
        Txt_Aadharno.Text = " "
        Txt_Address.Text = " "
        Txt_City.Text = " "



        Txt_State.Text = " "
        Txt_Pincode.Text = " "
        Txt_Emailid.Text = " "
        Txt_Roomno.Text = " "
        Cmb_Branch.Text = ""
        Cmb_Dept.Text = " "
        Cmb_Year.Text = " "
        Txt_Mobileno.Text = " "
        MessageBox.Show("Enter New Data")

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Txt_State_TextChanged(sender As Object, e As EventArgs) Handles Txt_State.TextChanged

    End Sub

    Private Sub Btn_Reset_Click(sender As Object, e As EventArgs) Handles Btn_Reset.Click

        Txt_Name.Text = " "
        Txt_FathersName.Text = " "
        Txt_Mothername.Text = " "
        Txt_Aadharno.Text = " "
        Txt_Address.Text = " "
        Txt_City.Text = " "



        Txt_State.Text = " "
        Txt_Pincode.Text = " "
        Txt_Emailid.Text = " "
        Txt_Roomno.Text = " "
        Cmb_Branch.Text = ""
        Cmb_Dept.Text = " "
        Cmb_Year.Text = " "
        Txt_Mobileno.Text = " "
        MessageBox.Show("Enter New Data")

    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click

        Me.Hide()
        Dim form2 As New StudentPortal_Form
        form2.ShowDialog()
        Me.Close()

    End Sub


    Private Sub Txt_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Name.KeyPress
        If ((e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso (e.KeyChar < "A" OrElse e.KeyChar > "Z")) Then
            e.Handled = True
        End If
        If e.KeyChar = ControlChars.Back Then
            e.Handled = False
        End If
    End Sub
    Private Sub TxtFathersName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_FathersName.KeyPress
        If ((e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso (e.KeyChar < "A" OrElse e.KeyChar > "Z")) Then
            e.Handled = True
        End If
        If e.KeyChar = ControlChars.Back Then
            e.Handled = False
        End If
    End Sub
    Private Sub Txt_Mothername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Mothername.KeyPress
        If ((e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso (e.KeyChar < "A" OrElse e.KeyChar > "Z")) Then
            e.Handled = True
        End If
        If e.KeyChar = ControlChars.Back Then
            e.Handled = False
        End If
    End Sub
    Private Sub Txt_City_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_City.KeyPress
        If ((e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso (e.KeyChar < "A" OrElse e.KeyChar > "Z")) Then
            e.Handled = True
        End If
        If e.KeyChar = ControlChars.Back Then
            e.Handled = False
        End If
    End Sub
    Private Sub Txt_State_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_State.KeyPress
        If ((e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso (e.KeyChar < "A" OrElse e.KeyChar > "Z")) Then
            e.Handled = True
        End If
        If e.KeyChar = ControlChars.Back Then
            e.Handled = False
        End If
    End Sub
    Private Sub Txt_Mobileno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Mobileno.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
            e.Handled = True
        End If
        If e.KeyChar = ControlChars.Back Then
            e.Handled = False
        End If
    End Sub
    Private Sub Txt_Pincode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Pincode.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
            e.Handled = True
        End If
        If e.KeyChar = ControlChars.Back Then
            e.Handled = False
        End If
    End Sub

End Class