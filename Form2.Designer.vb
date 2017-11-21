<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentPortal_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentPortal_Form))
        Me.Ptb_logo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Report = New System.Windows.Forms.Button()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Udate = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Lbl_GS = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Mini = New System.Windows.Forms.Button()
        Me.Btn_Max = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.Ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ptb_logo
        '
        Me.Ptb_logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Ptb_logo.Image = CType(resources.GetObject("Ptb_logo.Image"), System.Drawing.Image)
        Me.Ptb_logo.Location = New System.Drawing.Point(290, 32)
        Me.Ptb_logo.Name = "Ptb_logo"
        Me.Ptb_logo.Size = New System.Drawing.Size(909, 78)
        Me.Ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ptb_logo.TabIndex = 0
        Me.Ptb_logo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btn_Add)
        Me.Panel1.Controls.Add(Me.Btn_Report)
        Me.Panel1.Controls.Add(Me.Btn_Back)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Btn_Search)
        Me.Panel1.Controls.Add(Me.Btn_Udate)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(1, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 697)
        Me.Panel1.TabIndex = 1
        '
        'Btn_Report
        '
        Me.Btn_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Report.BackgroundImage = CType(resources.GetObject("Btn_Report.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Report.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Report.Location = New System.Drawing.Point(24, 406)
        Me.Btn_Report.Name = "Btn_Report"
        Me.Btn_Report.Size = New System.Drawing.Size(208, 49)
        Me.Btn_Report.TabIndex = 5
        Me.Btn_Report.Text = "Report  "
        Me.Btn_Report.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Report.UseVisualStyleBackColor = True
        '
        'Btn_Back
        '
        Me.Btn_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Back.BackgroundImage = CType(resources.GetObject("Btn_Back.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Back.Location = New System.Drawing.Point(24, 475)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(208, 55)
        Me.Btn_Back.TabIndex = 4
        Me.Btn_Back.Text = " Back    "
        Me.Btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(42, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Portal"
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Search.BackgroundImage = CType(resources.GetObject("Btn_Search.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Search.Location = New System.Drawing.Point(24, 262)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(208, 49)
        Me.Btn_Search.TabIndex = 4
        Me.Btn_Search.Text = "Search  "
        Me.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Btn_Udate
        '
        Me.Btn_Udate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Udate.BackgroundImage = CType(resources.GetObject("Btn_Udate.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Udate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Udate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Udate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Udate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Udate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Udate.Location = New System.Drawing.Point(24, 335)
        Me.Btn_Udate.Name = "Btn_Udate"
        Me.Btn_Udate.Size = New System.Drawing.Size(208, 49)
        Me.Btn_Udate.TabIndex = 3
        Me.Btn_Udate.Text = "Update  "
        Me.Btn_Udate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Udate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Udate.UseVisualStyleBackColor = False
        '
        'Btn_Add
        '
        Me.Btn_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Add.BackgroundImage = CType(resources.GetObject("Btn_Add.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Add.Location = New System.Drawing.Point(24, 187)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(208, 48)
        Me.Btn_Add.TabIndex = 2
        Me.Btn_Add.Text = "New Add "
        Me.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Add.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(62, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 95)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Lbl_GS
        '
        Me.Lbl_GS.AutoSize = True
        Me.Lbl_GS.BackColor = System.Drawing.Color.DarkBlue
        Me.Lbl_GS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbl_GS.Location = New System.Drawing.Point(512, 6)
        Me.Lbl_GS.Name = "Lbl_GS"
        Me.Lbl_GS.Size = New System.Drawing.Size(414, 20)
        Me.Lbl_GS.TabIndex = 2
        Me.Lbl_GS.Text = "GIRLS HOSTEL ,GURU GHASIDAS UNIVERSITY"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Controls.Add(Me.Btn_Mini)
        Me.Panel2.Controls.Add(Me.Btn_Max)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Lbl_GS)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1378, 31)
        Me.Panel2.TabIndex = 2
        '
        'Btn_Mini
        '
        Me.Btn_Mini.BackgroundImage = CType(resources.GetObject("Btn_Mini.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Mini.Location = New System.Drawing.Point(1267, 3)
        Me.Btn_Mini.Name = "Btn_Mini"
        Me.Btn_Mini.Size = New System.Drawing.Size(23, 23)
        Me.Btn_Mini.TabIndex = 5
        Me.Btn_Mini.UseVisualStyleBackColor = True
        '
        'Btn_Max
        '
        Me.Btn_Max.BackgroundImage = CType(resources.GetObject("Btn_Max.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Max.Location = New System.Drawing.Point(1296, 3)
        Me.Btn_Max.Name = "Btn_Max"
        Me.Btn_Max.Size = New System.Drawing.Size(23, 23)
        Me.Btn_Max.TabIndex = 4
        Me.Btn_Max.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(1325, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(23, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(300, 132)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1038, 597)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'StudentPortal_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1361, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Ptb_logo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "StudentPortal_Form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.Text = "GIRLS HOSTEL ,GURU GHASIDAS UNIVERSITY"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ptb_logo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Add As System.Windows.Forms.Button
    Friend WithEvents Btn_Udate As System.Windows.Forms.Button
    Friend WithEvents Lbl_GS As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Btn_Back As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Max As System.Windows.Forms.Button
    Friend WithEvents Btn_Mini As System.Windows.Forms.Button
    Friend WithEvents Btn_Report As System.Windows.Forms.Button
End Class
