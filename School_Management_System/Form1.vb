
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form1

    Inherits System.Windows.Forms.Form
    Private Connection As SqlConnection
    Private myCMD As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private Sub SchoolTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SchoolTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SchoolTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolDataSet1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.LightGray

        ' DatagridviewStyles

        DataGridView1.BorderStyle = BorderStyle.FixedSingle
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.GridColor = Color.DimGray
        DataGridView1.DefaultCellStyle.BackColor = Color.White
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.SteelBlue
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

        'Button styles

        Save.BackColor = Color.DodgerBlue
        Save.ForeColor = Color.White
        delete.BackColor = Color.Crimson
        delete.ForeColor = Color.White
        Exitb.BackColor = Color.Gray
        Exitb.ForeColor = Color.White




        Using Connection = New SqlConnection("Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            Dim command As New SqlCommand("SELECT * FROM Student", Connection)

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            ' Open the connection
            Connection.Open()

            ' Execute the query and fill the DataTable
            dataTable.Load(command.ExecuteReader())



            Connection.Close()
            ' Bind the DataTable to the DataGridView
            DataGridView1.DataSource = dataTable


        End Using
        Connection = New SqlConnection("Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        Me.WindowState = FormWindowState.Normal


    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Exitb.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show(" Are you you want to Exit?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then

            'Dim Form1 As New Student_Teacher()
            Student_Teacher.Show()
            Me.Hide()
            ' Application.Exit()

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Save.Click

        Dim dateOfBirthText As String = DateOfBirthTexBOx.Text
        Dim dateOfBirth As DateTime
        If Not DateTime.TryParse(dateOfBirthText, dateOfBirth) Then
            MessageBox.Show("Invalid date of birth format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If

        Dim phoneNumber As String = Mobile_NumTextBox.Text
        If Not ValidatePhoneNumber(phoneNumber) Then
            MessageBox.Show("Invalid phone number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Mobile_NumTextBox.Clear()
            Return
        End If

        ' Perform email validation
        Dim email As String = EmailTextBox.Text
        If Not EmailIsValid(email) Then
            MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EmailTextBox.Clear()

            Return
        End If


        Dim postcode As String = PostcodeTextBox.Text
        If Not ValidateUKPostcode(postcode) Then
            MessageBox.Show("Invalid UK postcode format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PostcodeTextBox.Clear()
            Return
        End If


        ' Save data to database
        Try
            Using connection As New SqlConnection("Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                ' Construct the INSERT query with parameterized values
                Dim sql As String = "INSERT INTO Student (StudentID, FirstName, LastName, DateOfBirth, Address, PostCode, Gender, Phone, Email) 
                                 VALUES (@StdID, @FirstName, @LastName, @DOB, @Address, @PostCode, @Gender, @Mobile, @Email)"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@StdID", Student_IDTextBox.Text)
                    command.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text)
                    command.Parameters.AddWithValue("@LastName", LastNameTextBox.Text)
                    command.Parameters.AddWithValue("@DOB", DateOfBirthTexBOx.Text)
                    command.Parameters.AddWithValue("@Address", AddressTextBox.Text)
                    command.Parameters.AddWithValue("@PostCode", PostcodeTextBox.Text)
                    command.Parameters.AddWithValue("@Gender", GenderTextBox.Text)
                    command.Parameters.AddWithValue("@Mobile", Mobile_NumTextBox.Text)
                    command.Parameters.AddWithValue("@Email", EmailTextBox.Text)
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                End Using

                ' Refresh DataGridView
                RefreshDataGridView()

                MessageBox.Show("Student Details Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Student_IDTextBox.Clear()
                FirstNameTextBox.Clear()
                LastNameTextBox.Clear()
                DateOfBirthTexBOx.Clear()
                AddressTextBox.Clear()
                PostcodeTextBox.Clear()
                GenderTextBox.Clear()
                Mobile_NumTextBox.Clear()
                EmailTextBox.Clear()

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub RefreshDataGridView()
        Try
            ' Using connection As New SqlConnection("Your_Connection_String")

            Using connection As New SqlConnection("Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

                Using command As New SqlCommand("SELECT * FROM Student", connection)
                    ' Create a DataTable to hold the data
                    Dim dataTable As New DataTable()

                    ' Open the connection
                    connection.Open()

                    ' Execute the query and fill the DataTable
                    dataTable.Load(command.ExecuteReader())

                    ' Bind the DataTable to the DataGridView
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Function ValidatePhoneNumber(phoneNumber As String) As Boolean
        ' Remove any non-digit characters from the phone number

        phoneNumber = Regex.Replace(phoneNumber, "[^\d]", "")

        ' Check if the phone number has exactly 11 digits
        Return phoneNumber.Length = 11
    End Function


    Private Function ValidateEmail(email As String) As Boolean
        ' Use a simple regex pattern to check the email format
        Dim pattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"

        Dim regex As New Regex(pattern)
        Dim match As Match = regex.Match(email)

        Return match.Success
    End Function


    Private Function ValidateUKPostcode(postcode As String) As Boolean
        ' Define the regex pattern for UK postcode format

        Dim pattern As String = "^(GIR ?0AA|[A-PR-UWYZ](?:[0-9]{0,2}|[0-9][A-HJKMNPR-Y]|[A-HK-Y][0-9]{0,2}|[A-HK-Y][0-9][ABEHMNPRV-Y])) ?[0-9][ABD-HJLNP-UW-Z]{2}$"

        ' Create a regex object and match the pattern against the postcode
        Dim regex As New Regex(pattern)
        Dim match As Match = regex.Match(postcode)

        ' Return true if the postcode matches the pattern, false otherwise
        Return match.Success
    End Function


    Private Function EmailIsValid(email As String) As Boolean
        ' Define the email pattern
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        ' Create a regex instance with the pattern
        Dim regex As New Regex(pattern)

        ' Check if the email matches the pattern
        Return regex.IsMatch(email)
    End Function


    Private Sub Button4_Click(sender As Object, e As EventArgs)

        Try
            Me.SchoolTableBindingSource.MoveFirst()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Try
            Me.SchoolTableBindingSource.MoveLast()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Try
            Me.SchoolTableBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Try
            Me.SchoolTableBindingSource.MoveNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Try
            Me.SchoolTableBindingSource.AddNew()
            FirstNameTextBox.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles delete.Click



        If DataGridView1.SelectedRows.Count > 0 Then


            Dim deleteconfirmation As DialogResult = MessageBox.Show("Are you sure you what to delete??", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If deleteconfirmation = DialogResult.Yes Then



                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim itemToDelete As DataRowView = selectedRow.DataBoundItem
                Dim StdID As Int32 = selectedRow.DataBoundItem.Row.ItemArray(0)

                ' Get the DataTable from the DataSource of the DataGridView
                Dim dataTable As DataTable = DirectCast(DataGridView1.DataSource, DataTable)

                ' Remove the item from the DataTable
                dataTable.Rows.Remove(itemToDelete.Row)

                ' Refresh the DataGridView to reflect the changes
                DataGridView1.Refresh()

                ' Delete the item from the database
                Using connection As New SqlConnection("Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                    Dim deleteQuery As String = "DELETE FROM Student WHERE StudentID =@StdID"
                    Using command As New SqlCommand(deleteQuery, connection)
                        command.Parameters.AddWithValue("@StdID", StdID) ' Assuming StudentID is the primary key column
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    End Using
                End Using

                ' Display delete message
                MessageBox.Show("Item deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
                ' No item is selected, display a message or take appropriate action
                MessageBox.Show("Please select an item to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged

        'Print(EmailTextBox.Text().ToString)
    End Sub

    Private Sub Mobile_NumTextBox_TextChanged(sender As Object, e As EventArgs) Handles Mobile_NumTextBox.TextChanged

    End Sub

    Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



    End Sub

    Private Sub Searchb_Click(sender As Object, e As EventArgs) Handles Searchb.Click

        Dim SearchKeyword As String = Student_IDTextBox.Text()

        Using connection As New SqlConnection("Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

            connection.Open()

            Dim query As String = "SELECT * FROM Student WHERE StudentID Like @Keyword"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Keyword", "%" & SearchKeyword & "%")

            Dim adapter As New SqlDataAdapter(command)

            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)


            DataGridView1.DataSource = dataTable

            connection.Close()
        End Using


    End Sub

    Private Sub Student_IDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Editbn.Click


        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            Dim id As Integer = CInt(selectedRow.Cells("IDColumn").Value)
            Dim name As String = CStr(selectedRow.Cells("NameColumn").Value)

            'IDTextBox.Text = id.ToString()
            'NameTextBox.Text = name

        End If
    End Sub

    Private Sub Student_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles Student_IDTextBox.TextChanged

    End Sub


    ' Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged

    'End Sub




End Class
