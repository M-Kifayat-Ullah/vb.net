Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class Form1
    Dim C1 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=KIFAYATKHAN;Initial Catalog=Form1;Integrated Security=True")

        'recieve values
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[Form]
           ([user_Id]
           ,[User_name]
           ,[User_age]
           ,[Subject])   
     VALUES
           ('" + userid.Text + "','" + username.Text + "','" + userage.Text + "','" + C1 + "')", con)
        'send values
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("you have registered sucessfully")

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Physics.CheckedChanged
        If Physics.Checked Then
            Math.Checked = False
            C1 = "physics"

        End If

    End Sub
    Private Sub Math_CheckedChanged(sender As Object, e As EventArgs) Handles Math.CheckedChanged
        If Math.Checked Then
            Physics.Checked = False
            C1 = "Math"
        End If
    End Sub
    Private Sub AddRow_Click(sender As Object, e As EventArgs) Handles AddRow.Click
        Try
            'for database connection
            Dim con As SqlConnection = New SqlConnection("Data Source=KIFAYATKHAN;Initial Catalog=Form1;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("procedure1", con)
            cmd.CommandType = CommandType.StoredProcedure
            'sqldataadaptor for datatable
            Dim da As New SqlDataAdapter(cmd)
            'creating datatable
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            'Me.DataGridView1.Rows.Add(userid.Text, username.Text, userage.Text)
            userid.Text = ""
            username.Text = ""
            userage.Text = ""
        Catch ex As Exception

        End Try

    End Sub


    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click

        Try
            Dim update As DataGridViewRow = DataGridView1.SelectedRows(0)
            update.Cells(0).Value = userid.Text
            update.Cells(1).Value = username.Text
            update.Cells(2).Value = userage.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                DataGridView1.Rows(e.RowIndex).Selected = True
                ' select entire row
                Dim row As DataGridViewRow = DataGridView1.Rows(0)
                'show values to textboxes
                userid.Text = row.Cells(0).Value.ToString()
                username.Text = row.Cells(1).Value.ToString()
                userage.Text = row.Cells(2).Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CrystalReport_Click(sender As Object, e As EventArgs) Handles CrystalReport.Click
        'Dim con As SqlConnection = New SqlConnection("Data Source=KIFAYATKHAN;Initial Catalog=Form1;Integrated Security=True")
        'Dim cmd As SqlCommand = New SqlCommand("procedure1", con)
        'cmd.CommandType = CommandType.StoredProcedure
        ''sqldataadaptor for datatable
        'Dim da As New SqlDataAdapter(cmd)
        ''creating datatable
        'Dim dt As New DataTable()
        'da.Fill(dt)
        'Dim report As New CrystalReport2

        'report.SetDataSource(dt)
        'Form3.CrystalReportViewer1.ReportSource = report
        'Form3.CrystalReportViewer1.Refresh()

        Form3.Show()

    End Sub
End Class
