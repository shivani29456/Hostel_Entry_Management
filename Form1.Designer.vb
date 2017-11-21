<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_check = New System.Windows.Forms.Button()
        Me.Btn_Reset = New System.Windows.Forms.Button()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_password = New System.Windows.Forms.TextBox()
        Me.Txt_User = New System.Windows.Forms.TextBox()
        Me.Ptb_logo = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_GS = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Btn_check)
        Me.GroupBox1.Controls.Add(Me.Btn_Reset)
        Me.GroupBox1.Controls.Add(Me.Btn_Login)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_password)
        Me.GroupBox1.Controls.Add(Me.Txt_User)
        Me.GroupBox1.Location = New System.Drawing.Point(521, 322)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 247)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Btn_check
        '
        Me.Btn_check.BackColor = System.Drawing.Color.Transparent
        Me.Btn_check.BackgroundImage = CType(resources.GetObject("Btn_check.BackgroundImage"), System.Drawing.Image)
        Me.Btn_check.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_check.Location = New System.Drawing.Point(72, 213)
        Me.Btn_check.Name = "Btn_check"
        Me.Btn_check.Size = New System.Drawing.Size(86, 28)
        Me.Btn_check.TabIndex = 10
        Me.Btn_check.Text = "Exit"
        Me.Btn_check.UseVisualStyleBackColor = False
        '
        'Btn_Reset
        '
        Me.Btn_Reset.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Reset.BackgroundImage = CType(resources.GetObject("Btn_Reset.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Reset.Location = New System.Drawing.Point(122, 176)
        Me.Btn_Reset.Name = "Btn_Reset"
        Me.Btn_Reset.Size = New System.Drawing.Size(86, 28)
        Me.Btn_Reset.TabIndex = 9
        Me.Btn_Reset.Text = "Reset"
        Me.Btn_Reset.UseVisualStyleBackColor = False
        '
        'Btn_Login
        '
        Me.Btn_Login.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Login.BackgroundImage = CType(resources.GetObject("Btn_Login.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Login.Location = New System.Drawing.Point(30, 176)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(86, 28)
        Me.Btn_Login.TabIndex = 8
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(27, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(27, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(52, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Login  Form"
        '
        'Txt_password
        '
        Me.Txt_password.Location = New System.Drawing.Point(30, 138)
        Me.Txt_password.Name = "Txt_password"
        Me.Txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_password.Size = New System.Drawing.Size(161, 20)
        Me.Txt_password.TabIndex = 3
        '
        'Txt_User
        '
        Me.Txt_User.Location = New System.Drawing.Point(30, 83)
        Me.Txt_User.Name = "Txt_User"
        Me.Txt_User.Size = New System.Drawing.Size(161, 20)
        Me.Txt_User.TabIndex = 2
        '
        'Ptb_logo
        '
        Me.Ptb_logo.Image = CType(resources.GetObject("Ptb_logo.Image"), System.Drawing.Image)
        Me.Ptb_logo.Location = New System.Drawing.Point(225, 28)
        Me.Ptb_logo.Name = "Ptb_logo"
        Me.Ptb_logo.Size = New System.Drawing.Size(909, 78)
        Me.Ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ptb_logo.TabIndex = 1
        Me.Ptb_logo.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(145, 338)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.Lbl_GS)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1378, 31)
        Me.Panel1.TabIndex = 3
        '
        'Lbl_GS
        '
        Me.Lbl_GS.AutoSize = True
        Me.Lbl_GS.BackColor = System.Drawing.Color.DarkBlue
        Me.Lbl_GS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GS.ForeColor = System.Drawing.Color.White
        Me.Lbl_GS.Location = New System.Drawing.Point(437, 3)
        Me.Lbl_GS.Name = "Lbl_GS"
        Me.Lbl_GS.Size = New System.Drawing.Size(419, 20)
        Me.Lbl_GS.TabIndex = 2
        Me.Lbl_GS.Text = "GIRLS HOSTEL ,GURU GHASIDAS UNIVERSITY "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(437, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(414, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "GIRLS HOSTEL GURU GHASIDAS UNIVERSITY "
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1361, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Ptb_logo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login_Form"
        Me.ShowIcon = False
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Txt_User As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Ptb_logo As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Login As System.Windows.Forms.Button
    Friend WithEvents Btn_Reset As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_GS As System.Windows.Forms.Label
    Friend WithEvents Btn_check As System.Windows.Forms.Button

End Class
