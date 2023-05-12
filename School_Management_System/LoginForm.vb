

Imports System.Data.SqlClient

Public Class LoginForm

    Private ConnectionString As String = "Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim user As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        Dim ValidLogin As Boolean = ValidateLogin(user, password)

        If ValidLogin Then

            MessageBox.Show("Login Successfull!", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim dashboaordForm As New Student_Teacher()
            Student_Teacher.Show()
            Me.Hide()

        Else

            MessageBox.Show("Invalid username or Password Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If


        Button1.BackColor = Color.FromArgb(64, 64, 64)
        Button1.ForeColor = Color.White
        Button1.Font = New Font("Arial", 10, FontStyle.Bold)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0

    End Sub

    Private Function ValidateLogin(Username As String, Password As String) As Boolean
        Dim databaseConection As String = "Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        Using connection As New SqlConnection(databaseConection)
            Dim adminQuery As String = "SELECT COUNT(*) FROM admindetails WHERE Username=@Username AND Password=@Password"

            Using command As New SqlCommand(adminQuery, connection)
                command.Parameters.AddWithValue("@Username", Username)
                command.Parameters.AddWithValue("@Password", Password)

                connection.Open()

                Dim result As Integer = CInt(command.ExecuteScalar())
                connection.Close()

                Return (result > 0)
            End Using
        End Using

    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


        TextBox2.UseSystemPasswordChar = Not String.IsNullOrEmpty(TextBox2.Text)


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles StudentButton.Click


        Dim mydatatable As New DataTable()
        Using connection As New SqlConnection("Data Source=DESKTOP-R6PGKKP\SQLEXPRESS02;Initial Catalog=School Administration System;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
            connection.Open()

            Dim query As String = "

select  CourseName, description, RoomNumber, CLassDay, FirstName + ' ' + LastName TeacherName,Email as TeacherEmail from course full outer join Teacher on 
course.TeacherID= Teacher.TeacherID inner join classs on Course.CourseID= Classs.CourseID
order by CourseName"


            Using command As New SqlCommand(query, connection)
                Using adapter As New SqlDataAdapter(command)

                    adapter.Fill(mydatatable)

                End Using
            End Using

        End Using


        Dim CourseDetail As New CourseDetails()
        CourseDetail.DataSource = mydatatable
        CourseDetail.Show()
        Me.Hide()


        'Dim CourseDetail As New CourseDetails()

        'CourseDetail.ShowData(mydatatable)

        CourseDetail.Show()

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class