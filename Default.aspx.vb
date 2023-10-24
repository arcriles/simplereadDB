Imports System.Data
Imports System.Data.SqlClient

Partial Class Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim connectionString As String = "Data Source=YourServer;Initial Catalog=HRD;User Id=YourUsername;Password=YourPassword;"
            Dim conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT ID, Username, Password, groupId, RealName, Jabatan FROM Users", conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()

            conn.Open()
            adapter.Fill(ds, "Users")
            conn.Close()

            UsersGridView.DataSource = ds.Tables("Users")
            UsersGridView.DataBind()
        End If
    End Sub
End Class

