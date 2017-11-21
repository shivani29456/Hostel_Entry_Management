<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entry_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entry_Form))
        Me.Lbl_GS = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Mini = New System.Windows.Forms.Button()
        Me.Btn_Max = New System.Windows.Forms.Button()
        Me.Btn_Cross = New System.Windows.Forms.Button()
        Me.Ptb_logo = New System.Windows.Forms.PictureBox()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cmb_Purpose = New System.Windows.Forms.ComboBox()
        Me.Txt_Aadharno = New System.Windows.Forms.TextBox()
        Me.Btn_Logout = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_GS
        '
        Me.Lbl_GS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_GS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Lbl_GS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbl_GS.Location = New System.Drawing.Point(420, 3)
        Me.Lbl_GS.Name = "Lbl_GS"
        Me.Lbl_GS.Size = New System.Drawing.Size(476, 25)
        Me.Lbl_GS.TabIndex = 0
        Me.Lbl_GS.Text = "GIRLS HOSTEL GURU GHASIDAS UNIVERSITY"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.Btn_Mini)
        Me.Panel1.Controls.Add(Me.Btn_Max)
        Me.Panel1.Controls.Add(Me.Btn_Cross)
        Me.Panel1.Controls.Add(Me.Lbl_GS)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1361, 31)
        Me.Panel1.TabIndex = 1
        '
        'Btn_Mini
        '
        Me.Btn_Mini.BackgroundImage = CType(resources.GetObject("Btn_Mini.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Mini.Location = New System.Drawing.Point(1266, 3)
        Me.Btn_Mini.Name = "Btn_Mini"
        Me.Btn_Mini.Size = New System.Drawing.Size(23, 23)
        Me.Btn_Mini.TabIndex = 7
        Me.Btn_Mini.UseVisualStyleBackColor = True
        '
        'Btn_Max
        '
        Me.Btn_Max.BackgroundImage = CType(resources.GetObject("Btn_Max.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Max.Location = New System.Drawing.Point(1295, 3)
        Me.Btn_Max.Name = "Btn_Max"
        Me.Btn_Max.Size = New System.Drawing.Size(23, 23)
        Me.Btn_Max.TabIndex = 6
        Me.Btn_Max.UseVisualStyleBackColor = True
        '
        'Btn_Cross
        '
        Me.Btn_Cross.BackgroundImage = CType(resources.GetObject("Btn_Cross.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Cross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Cross.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cross.Location = New System.Drawing.Point(1324, 3)
        Me.Btn_Cross.Name = "Btn_Cross"
        Me.Btn_Cross.Size = New System.Drawing.Size(23, 23)
        Me.Btn_Cross.TabIndex = 1
        Me.Btn_Cross.UseVisualStyleBackColor = True
        '
        'Ptb_logo
        '
        Me.Ptb_logo.Image = CType(resources.GetObject("Ptb_logo.Image"), System.Drawing.Image)
        Me.Ptb_logo.Location = New System.Drawing.Point(190, 31)
        Me.Ptb_logo.Name = "Ptb_logo"
        Me.Ptb_logo.Size = New System.Drawing.Size(909, 81)
        Me.Ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ptb_logo.TabIndex = 2
        Me.Ptb_logo.TabStop = False
        '
        'Btn_Login
        '
        Me.Btn_Login.BackColor = System.Drawing.Color.Blue
        Me.Btn_Login.BackgroundImage = CType(resources.GetObject("Btn_Login.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Login.Location = New System.Drawing.Point(55, 170)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(75, 26)
        Me.Btn_Login.TabIndex = 0
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Aadhar_No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "purpose"
        '
        'Cmb_Purpose
        '
        Me.Cmb_Purpose.FormattingEnabled = True
        Me.Cmb_Purpose.Location = New System.Drawing.Point(147, 113)
        Me.Cmb_Purpose.Name = "Cmb_Purpose"
        Me.Cmb_Purpose.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_Purpose.TabIndex = 3
        '
        'Txt_Aadharno
        '
        Me.Txt_Aadharno.Location = New System.Drawing.Point(147, 62)
        Me.Txt_Aadharno.Name = "Txt_Aadharno"
        Me.Txt_Aadharno.Size = New System.Drawing.Size(177, 20)
        Me.Txt_Aadharno.TabIndex = 4
        '
        'Btn_Logout
        '
        Me.Btn_Logout.BackgroundImage = CType(resources.GetObject("Btn_Logout.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Logout.Location = New System.Drawing.Point(147, 170)
        Me.Btn_Logout.Name = "Btn_Logout"
        Me.Btn_Logout.Size = New System.Drawing.Size(75, 26)
        Me.Btn_Logout.TabIndex = 5
        Me.Btn_Logout.Text = "Logout"
        Me.Btn_Logout.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(25, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = " GIRLS ENTRY"
        '
        'Btn_Back
        '
        Me.Btn_Back.BackColor = System.Drawing.Color.Blue
        Me.Btn_Back.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Back.Location = New System.Drawing.Point(244, 169)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(69, 26)
        Me.Btn_Back.TabIndex = 3
        Me.Btn_Back.Text = "Back"
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.Btn_Logout)
        Me.Panel2.Controls.Add(Me.Btn_Back)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Btn_Login)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Cmb_Purpose)
        Me.Panel2.Controls.Add(Me.Txt_Aadharno)
        Me.Panel2.Location = New System.Drawing.Point(502, 365)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(357, 259)
        Me.Panel2.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(126, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1152, 562)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Entry_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1364, 768)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Ptb_logo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Entry_Form"
        Me.Text = "GIRLS HOSTEL ENTRY"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.Ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_GS As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Ptb_logo As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Login As System.Windows.Forms.Button
    Friend WithEvents Btn_Logout As System.Windows.Forms.Button
    Friend WithEvents Txt_Aadharno As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_Purpose As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Btn_Cross As System.Windows.Forms.Button
    Friend WithEvents Btn_Back As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Mini As System.Windows.Forms.Button
    Friend WithEvents Btn_Max As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
