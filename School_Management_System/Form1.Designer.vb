<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Mobile_NumLabel As System.Windows.Forms.Label
        Dim CourseNameLabel As System.Windows.Forms.Label
        Dim TutorLabel As System.Windows.Forms.Label
        Dim PostcodeLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SchoolDataSet1 = New School_Management_System.SchoolDataSet1()
        Me.SchoolTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolTableTableAdapter = New School_Management_System.SchoolDataSet1TableAdapters.SchoolTableTableAdapter()
        Me.TableAdapterManager = New School_Management_System.SchoolDataSet1TableAdapters.TableAdapterManager()
        Me.SchoolTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SchoolTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_NumTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirthTexBOx = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.PostcodeTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Editbn = New System.Windows.Forms.Button()
        Me.Searchb = New System.Windows.Forms.Button()
        Me.Exitb = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Student_IDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Mobile_NumLabel = New System.Windows.Forms.Label()
        CourseNameLabel = New System.Windows.Forms.Label()
        TutorLabel = New System.Windows.Forms.Label()
        PostcodeLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CType(Me.SchoolDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SchoolTableBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(26, 28)
        Student_IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(130, 29)
        Student_IDLabel.TabIndex = 1
        Student_IDLabel.Text = "Student ID:"
        AddHandler Student_IDLabel.Click, AddressOf Me.Student_IDLabel_Click
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(14, 74)
        FirstNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(137, 29)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(15, 127)
        LastNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(134, 29)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(51, 180)
        EmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(80, 29)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "Email:"
        '
        'Mobile_NumLabel
        '
        Mobile_NumLabel.AutoSize = True
        Mobile_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mobile_NumLabel.Location = New System.Drawing.Point(14, 236)
        Mobile_NumLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Mobile_NumLabel.Name = "Mobile_NumLabel"
        Mobile_NumLabel.Size = New System.Drawing.Size(150, 29)
        Mobile_NumLabel.TabIndex = 9
        Mobile_NumLabel.Text = "Mobile Num:"
        '
        'CourseNameLabel
        '
        CourseNameLabel.AutoSize = True
        CourseNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CourseNameLabel.Location = New System.Drawing.Point(-3, 278)
        CourseNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CourseNameLabel.Name = "CourseNameLabel"
        CourseNameLabel.Size = New System.Drawing.Size(141, 29)
        CourseNameLabel.TabIndex = 11
        CourseNameLabel.Text = "Data of birth"
        '
        'TutorLabel
        '
        TutorLabel.AutoSize = True
        TutorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TutorLabel.Location = New System.Drawing.Point(61, 330)
        TutorLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        TutorLabel.Name = "TutorLabel"
        TutorLabel.Size = New System.Drawing.Size(94, 29)
        TutorLabel.TabIndex = 13
        TutorLabel.Text = "Gender"
        '
        'PostcodeLabel
        '
        PostcodeLabel.AutoSize = True
        PostcodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PostcodeLabel.Location = New System.Drawing.Point(22, 402)
        PostcodeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PostcodeLabel.Name = "PostcodeLabel"
        PostcodeLabel.Size = New System.Drawing.Size(121, 29)
        PostcodeLabel.TabIndex = 15
        PostcodeLabel.Text = "Postcode:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(22, 456)
        AddressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(108, 29)
        AddressLabel.TabIndex = 17
        AddressLabel.Text = "Address:"
        '
        'SchoolDataSet1
        '
        Me.SchoolDataSet1.DataSetName = "SchoolDataSet1"
        Me.SchoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SchoolTableBindingSource
        '
        Me.SchoolTableBindingSource.DataMember = "SchoolTable"
        Me.SchoolTableBindingSource.DataSource = Me.SchoolDataSet1
        '
        'SchoolTableTableAdapter
        '
        Me.SchoolTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SchoolTableTableAdapter = Me.SchoolTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = School_Management_System.SchoolDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SchoolTableBindingNavigator
        '
        Me.SchoolTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SchoolTableBindingNavigator.BindingSource = Me.SchoolTableBindingSource
        Me.SchoolTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SchoolTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SchoolTableBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SchoolTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SchoolTableBindingNavigatorSaveItem})
        Me.SchoolTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SchoolTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SchoolTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SchoolTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SchoolTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SchoolTableBindingNavigator.Name = "SchoolTableBindingNavigator"
        Me.SchoolTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SchoolTableBindingNavigator.Size = New System.Drawing.Size(1002, 27)
        Me.SchoolTableBindingNavigator.TabIndex = 0
        Me.SchoolTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'SchoolTableBindingNavigatorSaveItem
        '
        Me.SchoolTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SchoolTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("SchoolTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SchoolTableBindingNavigatorSaveItem.Name = "SchoolTableBindingNavigatorSaveItem"
        Me.SchoolTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.SchoolTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Student ID", True))
        Me.Student_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(181, 24)
        Me.Student_IDTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Student_IDTextBox.Multiline = True
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(193, 34)
        Me.Student_IDTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(181, 79)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FirstNameTextBox.Multiline = True
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(193, 41)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(181, 132)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LastNameTextBox.Multiline = True
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(193, 38)
        Me.LastNameTextBox.TabIndex = 6
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(181, 175)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EmailTextBox.Multiline = True
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(193, 36)
        Me.EmailTextBox.TabIndex = 8
        '
        'Mobile_NumTextBox
        '
        Me.Mobile_NumTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Mobile_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Mobile Num", True))
        Me.Mobile_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_NumTextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Mobile_NumTextBox.Location = New System.Drawing.Point(181, 232)
        Me.Mobile_NumTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Mobile_NumTextBox.Multiline = True
        Me.Mobile_NumTextBox.Name = "Mobile_NumTextBox"
        Me.Mobile_NumTextBox.Size = New System.Drawing.Size(193, 34)
        Me.Mobile_NumTextBox.TabIndex = 10
        '
        'DateOfBirthTexBOx
        '
        Me.DateOfBirthTexBOx.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateOfBirthTexBOx.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "CourseName", True))
        Me.DateOfBirthTexBOx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfBirthTexBOx.Location = New System.Drawing.Point(181, 282)
        Me.DateOfBirthTexBOx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateOfBirthTexBOx.Multiline = True
        Me.DateOfBirthTexBOx.Name = "DateOfBirthTexBOx"
        Me.DateOfBirthTexBOx.Size = New System.Drawing.Size(193, 28)
        Me.DateOfBirthTexBOx.TabIndex = 12
        '
        'GenderTextBox
        '
        Me.GenderTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Tutor", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(181, 330)
        Me.GenderTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GenderTextBox.Multiline = True
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(188, 47)
        Me.GenderTextBox.TabIndex = 14
        '
        'PostcodeTextBox
        '
        Me.PostcodeTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PostcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Postcode", True))
        Me.PostcodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostcodeTextBox.Location = New System.Drawing.Point(181, 392)
        Me.PostcodeTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PostcodeTextBox.Multiline = True
        Me.PostcodeTextBox.Name = "PostcodeTextBox"
        Me.PostcodeTextBox.Size = New System.Drawing.Size(188, 40)
        Me.PostcodeTextBox.TabIndex = 16
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(181, 456)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(188, 41)
        Me.AddressTextBox.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Editbn)
        Me.Panel1.Controls.Add(Me.Searchb)
        Me.Panel1.Controls.Add(Me.Exitb)
        Me.Panel1.Controls.Add(Me.delete)
        Me.Panel1.Controls.Add(Me.Save)
        Me.Panel1.Location = New System.Drawing.Point(444, 328)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 187)
        Me.Panel1.TabIndex = 21
        '
        'Editbn
        '
        Me.Editbn.Location = New System.Drawing.Point(2, 57)
        Me.Editbn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Editbn.Name = "Editbn"
        Me.Editbn.Size = New System.Drawing.Size(106, 45)
        Me.Editbn.TabIndex = 9
        Me.Editbn.Text = "Edit "
        Me.Editbn.UseVisualStyleBackColor = True
        '
        'Searchb
        '
        Me.Searchb.Location = New System.Drawing.Point(344, 4)
        Me.Searchb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Searchb.Name = "Searchb"
        Me.Searchb.Size = New System.Drawing.Size(95, 54)
        Me.Searchb.TabIndex = 8
        Me.Searchb.Text = "Search"
        Me.Searchb.UseVisualStyleBackColor = True
        '
        'Exitb
        '
        Me.Exitb.Location = New System.Drawing.Point(323, 139)
        Me.Exitb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Exitb.Name = "Exitb"
        Me.Exitb.Size = New System.Drawing.Size(135, 46)
        Me.Exitb.TabIndex = 7
        Me.Exitb.Text = "Exit"
        Me.Exitb.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.delete.Location = New System.Drawing.Point(154, 4)
        Me.delete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(158, 42)
        Me.delete.TabIndex = 2
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(-2, 0)
        Me.Save.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(135, 42)
        Me.Save.TabIndex = 0
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(444, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(558, 294)
        Me.DataGridView1.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 524)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Student_IDLabel)
        Me.Controls.Add(Me.Student_IDTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Mobile_NumLabel)
        Me.Controls.Add(Me.Mobile_NumTextBox)
        Me.Controls.Add(CourseNameLabel)
        Me.Controls.Add(Me.DateOfBirthTexBOx)
        Me.Controls.Add(TutorLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(PostcodeLabel)
        Me.Controls.Add(Me.PostcodeTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.SchoolTableBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SchoolDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SchoolTableBindingNavigator.ResumeLayout(False)
        Me.SchoolTableBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SchoolDataSet1 As SchoolDataSet1
    Friend WithEvents SchoolTableBindingSource As BindingSource
    Friend WithEvents SchoolTableTableAdapter As SchoolDataSet1TableAdapters.SchoolTableTableAdapter
    Friend WithEvents TableAdapterManager As SchoolDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents SchoolTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SchoolTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Student_IDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Mobile_NumTextBox As TextBox
    Friend WithEvents DateOfBirthTexBOx As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents PostcodeTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Exitb As Button
    Friend WithEvents delete As Button
    Friend WithEvents Save As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Searchb As Button
    Friend WithEvents Editbn As Button
End Class
