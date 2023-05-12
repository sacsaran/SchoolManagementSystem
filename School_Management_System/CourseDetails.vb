Imports System.Data
Public Class CourseDetails
    Public Sub BindDataToGridView(dataTable As DataTable)
        DataGridView1.DataSource = dataTable

        DataGridView1.Refresh()
    End Sub

    Public Property DataSource As DataTable
        Get
            Return DataGridView1.DataSource
        End Get
        Set(value As DataTable)
            DataGridView1.DataSource = value
            DataGridView1.Refresh()
        End Set
    End Property

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to sign in as Admin?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then

            LoginForm.Show()
            Me.Hide()
            'Application.Exit()
        End If


    End Sub
End Class