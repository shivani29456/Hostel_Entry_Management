<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_Form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Mini = New System.Windows.Forms.Button()
        Me.Btn_Max = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.AnuradhaDataSet2 = New WindowsApplication1.AnuradhaDataSet2()
        Me.LogTrackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Log_TrackTableAdapter = New WindowsApplication1.AnuradhaDataSet2TableAdapters.Log_TrackTableAdapter()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New WindowsApplication1.AnuradhaDataSet2TableAdapters.StudentTableAdapter()
        Me.Student_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AadharDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Current_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginRecord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogoutRecord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mobile_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Branch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Room_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnuradhaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogTrackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.Btn_Mini)
        Me.Panel1.Controls.Add(Me.Btn_Max)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1361, 31)
        Me.Panel1.TabIndex = 0
        '
        'Btn_Mini
        '
        Me.Btn_Mini.BackgroundImage = CType(resources.GetObject("Btn_Mini.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Mini.Location = New System.Drawing.Point(1263, 3)
        Me.Btn_Mini.Name = "Btn_Mini"
        Me.Btn_Mini.Size = New System.Drawing.Size(26, 23)
        Me.Btn_Mini.TabIndex = 7
        Me.Btn_Mini.UseVisualStyleBackColor = True
        '
        'Btn_Max
        '
        Me.Btn_Max.BackgroundImage = CType(resources.GetObject("Btn_Max.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Max.Location = New System.Drawing.Point(1295, 4)
        Me.Btn_Max.Name = "Btn_Max"
        Me.Btn_Max.Size = New System.Drawing.Size(25, 23)
        Me.Btn_Max.TabIndex = 6
        Me.Btn_Max.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1326, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(396, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GIRLS HOSTEL GURU GHASIDAS UNIVERSITY"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(182, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(909, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(12, 338)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1337, 418)
        Me.Panel2.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Student_Name, Me.AadharDataGridViewTextBoxColumn, Me.Current_Status, Me.LogDate, Me.LoginRecord, Me.LogoutRecord, Me.Purpose, Me.Mobile_Number, Me.Branch, Me.Room_No})
        Me.DataGridView1.DataSource = Me.LogTrackBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1337, 418)
        Me.DataGridView1.TabIndex = 0
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.Location = New System.Drawing.Point(643, 134)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(127, 29)
        Me.Btn_Search.TabIndex = 3
        Me.Btn_Search.Text = "Search/Filter"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(263, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search"
        '
        'Btn_Back
        '
        Me.Btn_Back.BackColor = System.Drawing.Color.Blue
        Me.Btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Back.ForeColor = System.Drawing.Color.White
        Me.Btn_Back.Location = New System.Drawing.Point(905, 139)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(84, 29)
        Me.Btn_Back.TabIndex = 6
        Me.Btn_Back.Text = "Back"
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'AnuradhaDataSet2
        '
        Me.AnuradhaDataSet2.DataSetName = "AnuradhaDataSet2"
        Me.AnuradhaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LogTrackBindingSource
        '
        Me.LogTrackBindingSource.DataMember = "Log_Track"
        Me.LogTrackBindingSource.DataSource = Me.AnuradhaDataSet2
        '
        'Log_TrackTableAdapter
        '
        Me.Log_TrackTableAdapter.ClearBeforeFill = True
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.AnuradhaDataSet2
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'Student_Name
        '
        Me.Student_Name.DataPropertyName = "Student_Name"
        Me.Student_Name.HeaderText = "Student_Name"
        Me.Student_Name.Name = "Student_Name"
        '
        'AadharDataGridViewTextBoxColumn
        '
        Me.AadharDataGridViewTextBoxColumn.DataPropertyName = "Aadhar"
        Me.AadharDataGridViewTextBoxColumn.HeaderText = "Aadhar"
        Me.AadharDataGridViewTextBoxColumn.Name = "AadharDataGridViewTextBoxColumn"
        '
        'Current_Status
        '
        Me.Current_Status.DataPropertyName = "Current_Status"
        Me.Current_Status.HeaderText = "Current_Status"
        Me.Current_Status.Name = "Current_Status"
        '
        'LogDate
        '
        Me.LogDate.DataPropertyName = "LogDate"
        Me.LogDate.HeaderText = "LogDate"
        Me.LogDate.Name = "LogDate"
        '
        'LoginRecord
        '
        Me.LoginRecord.DataPropertyName = "LoginRecord"
        Me.LoginRecord.HeaderText = "LoginRecord"
        Me.LoginRecord.Name = "LoginRecord"
        '
        'LogoutRecord
        '
        Me.LogoutRecord.DataPropertyName = "LogoutRecord"
        Me.LogoutRecord.HeaderText = "LogoutRecord"
        Me.LogoutRecord.Name = "LogoutRecord"
        '
        'Purpose
        '
        Me.Purpose.DataPropertyName = "Purpose"
        Me.Purpose.HeaderText = "Purpose"
        Me.Purpose.Name = "Purpose"
        '
        'Mobile_Number
        '
        Me.Mobile_Number.DataPropertyName = "Mobile_Number"
        Me.Mobile_Number.HeaderText = "Mobile_Number"
        Me.Mobile_Number.Name = "Mobile_Number"
        '
        'Branch
        '
        Me.Branch.DataPropertyName = "Branch"
        Me.Branch.HeaderText = "Branch"
        Me.Branch.Name = "Branch"
        '
        'Room_No
        '
        Me.Room_No.DataPropertyName = "Room_No"
        Me.Room_No.HeaderText = "Room_No"
        Me.Room_No.Name = "Room_No"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(377, 136)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 27)
        Me.TextBox1.TabIndex = 7
        '
        'Search_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1361, 768)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Btn_Back)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Search_Form"
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnuradhaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogTrackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Mini As System.Windows.Forms.Button
    Friend WithEvents Btn_Max As System.Windows.Forms.Button
    Friend WithEvents Btn_Back As System.Windows.Forms.Button
    Friend WithEvents AnuradhaDataSet2 As WindowsApplication1.AnuradhaDataSet2
    Friend WithEvents LogTrackBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Log_TrackTableAdapter As WindowsApplication1.AnuradhaDataSet2TableAdapters.Log_TrackTableAdapter
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As WindowsApplication1.AnuradhaDataSet2TableAdapters.StudentTableAdapter
    Friend WithEvents Student_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AadharDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Current_Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoginRecord As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogoutRecord As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Purpose As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mobile_Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Branch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Room_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
