<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.teachID = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.Department = New System.Windows.Forms.TextBox()
        Me.DateOfBirth = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.PostCode = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.TextBox()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TeacherID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FirstName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LastName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DateofBirth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(315, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(301, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "PostCode"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(315, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(315, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Phone"
        '
        'teachID
        '
        Me.teachID.Location = New System.Drawing.Point(141, 19)
        Me.teachID.Name = "teachID"
        Me.teachID.Size = New System.Drawing.Size(100, 20)
        Me.teachID.TabIndex = 9
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(141, 70)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(100, 20)
        Me.FirstName.TabIndex = 10
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(141, 126)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(100, 20)
        Me.LastName.TabIndex = 11
        '
        'Department
        '
        Me.Department.Location = New System.Drawing.Point(141, 187)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(100, 20)
        Me.Department.TabIndex = 12
        '
        'DateOfBirth
        '
        Me.DateOfBirth.Location = New System.Drawing.Point(141, 252)
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.Size = New System.Drawing.Size(100, 20)
        Me.DateOfBirth.TabIndex = 13
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(417, 19)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(100, 20)
        Me.Address.TabIndex = 14
        '
        'PostCode
        '
        Me.PostCode.Location = New System.Drawing.Point(417, 70)
        Me.PostCode.Name = "PostCode"
        Me.PostCode.Size = New System.Drawing.Size(100, 20)
        Me.PostCode.TabIndex = 15
        '
        'Gender
        '
        Me.Gender.Location = New System.Drawing.Point(417, 122)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(100, 20)
        Me.Gender.TabIndex = 16
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(417, 184)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(100, 20)
        Me.Phone.TabIndex = 17
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(417, 252)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(324, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 25)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Email"
        '
        'Savebtn
        '
        Me.Savebtn.Location = New System.Drawing.Point(574, 12)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(75, 42)
        Me.Savebtn.TabIndex = 20
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = True
        '
        'Searchbtn
        '
        Me.Searchbtn.Location = New System.Drawing.Point(691, 11)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(75, 43)
        Me.Searchbtn.TabIndex = 22
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Location = New System.Drawing.Point(637, 99)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(75, 43)
        Me.Editbtn.TabIndex = 23
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(713, 505)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 290)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(601, 250)
        Me.DataGridView1.TabIndex = 25
        '
        'Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 540)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.PostCode)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.DateOfBirth)
        Me.Controls.Add(Me.Department)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.teachID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Teacher"
        Me.Text = "Teacher"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents teachID As TextBox
    Friend WithEvents FirstName As TextBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents Department As TextBox
    Friend WithEvents DateOfBirth As TextBox
    Friend WithEvents Address As TextBox
    Friend WithEvents PostCode As TextBox
    Friend WithEvents Gender As TextBox
    Friend WithEvents Phone As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Savebtn As Button
    Friend WithEvents Searchbtn As Button
    Friend WithEvents Editbtn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
