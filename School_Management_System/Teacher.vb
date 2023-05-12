Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Teacher
    Private Connection As SqlConnection

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click


    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Savebtn.Click

        Dim emails As String = EmailTextBox.Text

        ' Perform email validation
        Dim email As String = EmailTextBox.Text
        If Not EmailIsValid(email) Then
            MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim phoneNumber As String = Phone.Text
        If Not ValidatePhoneNumber(phoneNumber) Then
            MessageBox.Show("Invalid phone number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If



        Dim postcoe As String = PostCode.Text
        If Not ValidateUKPostcode(postcoe) Then
            MessageBox.Show("Invalid UK postcode format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Try

            Using connection As New SqlConnection("Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

                Dim sql As String = "INSERT INTO teacher (TeacherID, FirstName, LastName, Department, DateOfBirth, Address, PostCode, Gender, Phone, Email) 
                             VALUES (@TchID, @fname, @lname, @departmnt, @DoB, @addres, @postcod, @gendr, @phne,@emal)"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@TchID", teachID.Text)
                    command.Parameters.AddWithValue("@fname", FirstName.Text)
                    command.Parameters.AddWithValue("@lname", LastName.Text)
                    command.Parameters.AddWithValue("@departmnt", Department.Text)
                    command.Parameters.AddWithValue("@DoB", DateOfBirth.Text)
                    command.Parameters.AddWithValue("@addres", Address.Text)
                    command.Parameters.AddWithValue("@phne", Phone.Text)
                    command.Parameters.AddWithValue("postcod", PostCode.Text)
                    command.Parameters.AddWithValue("@gendr", Gender.Text)
                    command.Parameters.AddWithValue("@emal", EmailTextBox.Text)
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                End Using

                ' Refresh DataGridView
                RefreshDataGridView()

                MessageBox.Show("Student Details Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                teachID.Clear()
                FirstName.Clear()
                LastName.Clear()
                Department.Clear()
                DateOfBirth.Clear()
                Address.Clear()
                Phone.Clear()
                PostCode.Clear()
                Gender.Clear()
                EmailTextBox.Clear()


            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub RefreshDataGridView()
        Try
            Using connection As New SqlConnection("Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

                Using command As New SqlCommand("SELECT * FROM teacher", connection)
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


    Private Function EmailIsValid(email As String) As Boolean
        ' Define the email pattern
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        ' Create a regex instance with the pattern
        Dim regex As New Regex(pattern)

        ' Check if the email matches the pattern
        Return regex.IsMatch(email)
    End Function


    Private Function ValidatePhoneNumber(phoneNumber As String) As Boolean
        ' Remove any non-digit characters from the phone number

        phoneNumber = Regex.Replace(phoneNumber, "[^\d]", "")

        ' Check if the phone number has exactly 11 digits
        Return phoneNumber.Length = 11
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


    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub teachID_TextChanged(sender As Object, e As EventArgs) Handles teachID.TextChanged

    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged

    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click




        Dim SearchKeyword As String = teachID.Text.Trim()

        Using connection As New SqlConnection("Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            connection.Open()

            Dim query As String = "SELECT * FROM teacher WHERE TeacherID LIKE @Keyword"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Keyword", "%" & SearchKeyword & "%")

            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable

            connection.Close()
        End Using



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.White





        Label1.ForeColor = Color.FromArgb(44, 62, 80)
        Label1.Font = New Font("Arial", 14, FontStyle.Bold)

        ' Set the button styles
        Savebtn.BackColor = Color.FromArgb(52, 152, 219)
        Savebtn.ForeColor = Color.White
        Savebtn.Font = New Font("Arial", 12, FontStyle.Bold)
        Savebtn.FlatStyle = FlatStyle.Flat
        Savebtn.FlatAppearance.BorderSize = 0

        ' Set the textbox styles
        EmailTextBox.BorderStyle = BorderStyle.None
        EmailTextBox.BackColor = Color.FromArgb(236, 240, 241)
        EmailTextBox.Font = New Font("Arial", 12)
        ' Add padding to the textbox
        EmailTextBox.Padding = New Padding(5)

        ' Set the gridview styles
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80)
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)
        DataGridView1.GridColor = Color.FromArgb(189, 195, 199)
        DataGridView1.RowHeadersVisible = False





        Using Connection = New SqlConnection("Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            Dim command As New SqlCommand("SELECT * FROM teacher", Connection)

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show(" Are you you want to Exit?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then

            Student_Teacher.Show()
            Me.Hide()
            'Application.Exit()
        End If



    End Sub
End Class