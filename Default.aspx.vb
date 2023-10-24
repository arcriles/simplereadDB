Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("QL_CONN").ConnectionString
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmd As New SqlCommand("SELECT ID, Username, Password, groupId, RealName, Jabatan FROM Users", conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        UsersGridView.DataSource = reader
                        UsersGridView.DataBind()
                    End Using
                End Using
            End Using
        End If
    End Sub
End Class


