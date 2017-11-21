Public Class StudentPortal_Form


    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Hide()
        Dim form1 As New Login_Form
        form1.ShowDialog()

        Me.Close()
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Me.Hide()
        Dim form6 As New Add_Form
        form6.ShowDialog()

        Me.Close()
    End Sub

    Private Sub Btn_Udate_Click(sender As Object, e As EventArgs) Handles Btn_Udate.Click
        Me.Hide()
        Dim form5 As New Update_Form
        form5.ShowDialog()

        Me.Close()
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Me.Hide()
        Dim form4 As New Search_Form
        form4.ShowDialog()

        Me.Close()
    End Sub

   
    Private Sub Lbl_GS_Click(sender As Object, e As EventArgs) Handles Lbl_GS.Click

    End Sub

    Private Sub StudentPortal_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SAPI As Object
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("welcome to student portal ")
    End Sub
End Class