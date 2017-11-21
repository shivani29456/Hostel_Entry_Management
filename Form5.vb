Public Class Update_Form

    Private Sub Update_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShivaniDataSet2.Student' table. You can move, or remove it, as needed.
        ' Me.StudentTableAdapter.Fill(Me.ShivaniDataSet2.Student)
        DataGridView1.Visible = False
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
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AutoGenerateColumns = False

        DataGridView1.Columns(0).Name = "Student_Name"
        DataGridView1.Columns(1).Name = "Fathers_Name"
        DataGridView1.Columns(2).Name = "Mothers_Name"
        DataGridView1.Columns(3).Name = "Aadhar"
        DataGridView1.Columns(4).Name = "DOB"
        DataGridView1.Columns(5).Name = "Mobile_Number"
        DataGridView1.Columns(6).Name = "Email_Id"
        DataGridView1.Columns(7).Name = "Address"
        DataGridView1.Columns(8).Name = "City"
        DataGridView1.Columns(9).Name = "State"
        DataGridView1.Columns(10).Name = "pincode"
        DataGridView1.Columns(11).Name = "Branch"
        DataGridView1.Columns(12).Name = "Dept"
        DataGridView1.Columns(13).Name = "Year"
        DataGridView1.Columns(14).Name = "Room_No"
        FilterData("")


    End Sub

    Dim sqlconn As SqlClient.SqlConnection
    Dim connection As New SqlClient.SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Shivani\Documents\Shivani.mdf;Integrated Security=True;Connect Timeout=30")

    Dim command As SqlClient.SqlCommand


    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "Select * From Student Where CONCAT(Student_Name,Fathers_Name,Mothers_Name,Aadhar,DOB,Mobile_Number,Email_Id,Address,City,State,pincode,Branch,Dept,Year,Room_No) LIKE '%" & valueToSearch & "%'"


        Dim command As New SqlClient.SqlCommand(searchQuery, connection)
        Dim adapter As New SqlClient.SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click


        sqlconn = New SqlClient.SqlConnection
        sqlconn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Shivani\Documents\Shivani.mdf;Integrated Security=True;Connect Timeout=30"
        Try
            sqlconn.Open()


            DataGridView1.SelectedRows(0).Cells(0).Value = Txt_Name.Text
            DataGridView1.SelectedRows(0).Cells(1).Value = Txt_Fathername.Text
            DataGridView1.SelectedRows(0).Cells(2).Value = Txt_Mothername.Text
            DataGridView1.SelectedRows(0).Cells(3).Value = Txt_Aadharno.Text
            DataGridView1.SelectedRows(0).Cells(4).Value = DateTimePicker1.Text
            DataGridView1.SelectedRows(0).Cells(5).Value = Txt_Mobileno.Text
            DataGridView1.SelectedRows(0).Cells(6).Value = Txt_Emailid.Text
            DataGridView1.SelectedRows(0).Cells(7).Value = Txt_Address.Text
            DataGridView1.SelectedRows(0).Cells(8).Value = Txt_City.Text
            DataGridView1.SelectedRows(0).Cells(9).Value = Txt_State.Text
            DataGridView1.SelectedRows(0).Cells(10).Value = Txt_Pincode.Text
            DataGridView1.SelectedRows(0).Cells(11).Value = Cmb_Branch.Text
            DataGridView1.SelectedRows(0).Cells(12).Value = Cmb_Dept.Text
            DataGridView1.SelectedRows(0).Cells(13).Value = Cmb_Year.Text
            DataGridView1.SelectedRows(0).Cells(14).Value = Txt_Roomno.Text


            command = New SqlClient.SqlCommand("", sqlconn)
            command.CommandText = "Update Student SET Student_Name='" & Txt_Name.Text & "',Fathers_Name='" & Txt_Fathername.Text & "',Mothers_Name='" & Txt_Mothername.Text & "',Address='" & Txt_Address.Text & "',City='" & Txt_City.Text & "',State='" & Txt_State.Text & "',Room_No='" & Txt_Roomno.Text & "',pincode='" & Txt_Pincode.Text & "' ,Branch='" & Cmb_Branch.Text & "',Dept='" & Cmb_Dept.Text & "',Year='" & Cmb_Year.Text & "', DOB='" & DateTimePicker1.Text & "',Mobile_Number='" & Txt_Mobileno.Text & "',Email_Id='" & Txt_Emailid.Text & "' where Aadhar='" & Txt_Aadharno.Text & "'"

            command.ExecuteNonQuery()


            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Dispose()

        End Try



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Txt_Name.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim Student_Name As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        Dim Fathers_Name As String = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Dim Mothers_Name As String = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        Dim Aadhar As String = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
        Dim DOB As String = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()

        Dim Mobile_Number As String = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()

        Dim Email_Id As String = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()
        Dim Address As String = DataGridView1.SelectedRows(0).Cells(7).Value.ToString()
        Dim City As String = DataGridView1.SelectedRows(0).Cells(8).Value.ToString()
        Dim State As String = DataGridView1.SelectedRows(0).Cells(9).Value.ToString()
        Dim pincode As String = DataGridView1.SelectedRows(0).Cells(10).Value.ToString()
        Dim Branch As String = DataGridView1.SelectedRows(0).Cells(11).Value.ToString()
        Dim Dept As String = DataGridView1.SelectedRows(0).Cells(12).Value.ToString()
        Dim Year As String = DataGridView1.SelectedRows(0).Cells(13).Value.ToString()
        Dim Room_No As String = DataGridView1.SelectedRows(0).Cells(14).Value.ToString()


        Txt_Name.Text = Student_Name
        Txt_Fathername.Text = Fathers_Name
        Txt_Mothername.Text = Mothers_Name
        Txt_Aadharno.Text = Aadhar
        DateTimePicker1.Text = DOB
        Txt_Mobileno.Text = Mobile_Number
        Txt_Emailid.Text = Email_Id
        Txt_Address.Text = Address
        Txt_City.Text = City
        Txt_State.Text = State
        Txt_Pincode.Text = pincode
        Cmb_Branch.Text = Branch
        Cmb_Dept.Text = Dept
        Cmb_Year.Text = Year
        Txt_Roomno.Text = Room_No


    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        DataGridView1.Visible = True
        FilterData(TextBox1.Text)
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        If MessageBox.Show("Are You Sure To Delete.??", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then

            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
            sqlconn = New SqlClient.SqlConnection
            sqlconn.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Shivani\Documents\Shivani.mdf;Integrated Security=True;Connect Timeout=30"
            Try
                sqlconn.Open()

                command = New SqlClient.SqlCommand("", sqlconn)
                command.CommandText = "Delete From Student  where Aadhar='" & Txt_Aadharno.Text & "'"
                command.ExecuteNonQuery()

                sqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                sqlconn.Dispose()

            End Try


        End If
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Hide()
        Dim form2 As New StudentPortal_Form
        form2.ShowDialog()

        Me.Close()
    End Sub

    Private Sub Btn_Reset_Click(sender As Object, e As EventArgs) Handles Btn_Reset.Click

        Txt_Name.Text = " "
        Txt_Fathername.Text = " "
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

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class
