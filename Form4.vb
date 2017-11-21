Public Class Search_Form




    Dim connection As New SqlClient.SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Shivani\Documents\Shivani.mdf;Integrated Security=True;Connect Timeout=30")




    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "Select  Student.Student_Name, Log_Track.Aadhar,Student.Mobile_Number,Log_Track.Current_Status,Log_Track.LogDate,Log_Track.LoginRecord,Log_Track.LogoutRecord,Room_No From Student,Log_Track Where Student.Aadhar=Log_Track.Aadhar and CONCAT(Log_Track.Aadhar,Student_Name,Current_Status,LogDate,LoginRecord,LogoutRecord,Student.Mobile_Number,Room_No) LIKE '%" & valueToSearch & "%'"


        Dim command As New SqlClient.SqlCommand(searchQuery, connection)
        Dim adapter As New SqlClient.SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Search_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShivaniDataSet2.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.ShivaniDataSet2.Student)
        'TODO: This line of code loads data into the 'ShivaniDataSet2.Log_Track' table. You can move, or remove it, as needed.
        Me.Log_TrackTableAdapter.Fill(Me.ShivaniDataSet2.Log_Track)

        DataGridView1.Visible = False
        FilterData("")



    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click

        Me.Hide()
        Dim form2 As New StudentPortal_Form
        form2.ShowDialog()

        Me.Close()

    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        DataGridView1.Visible = True
        FilterData(TextBox1.Text)
        TextBox1.Clear()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub DataGridView1_VisibleChanged(sender As Object, e As EventArgs) Handles DataGridView1.VisibleChanged

    End Sub
End Class
