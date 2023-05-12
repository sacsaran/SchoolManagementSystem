Public Class Student_Teacher
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Student_Teacher As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Student_Teacher As New Teacher()
        Teacher.Show()
        Me.Hide()
    End Sub

    Private Sub Student_Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set button styles
        Button1.FlatStyle = FlatStyle.Flat
        Button1.BackColor = Color.SteelBlue
        Button1.ForeColor = Color.White

        Button2.FlatStyle = FlatStyle.Flat
        Button2.BackColor = Color.SteelBlue
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        Dim iExit As DialogResult
        iExit = MessageBox.Show(" Are you want to Logout?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            LoginForm.Show()
            Me.Hide()

        End If

    End Sub




End Class