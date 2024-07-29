Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Public Class BuscarIndicativo
    Inherits System.Web.UI.Page
    Public ds As DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cnn = New SqlConnection
        cnn.ConnectionString = "Data Source=FABIANPC;Initial Catalog=Telefonia;Integrated Security=True;Encrypt=False"
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sql As String = "SELECT 
    CONCAT(TRIM(m.cod_dept), TRIM(m.codigo)) AS INDICATIVO, 
    m.nombre AS Municipio, 
    d.nombre AS Departamento 
FROM 
    Municipios m
INNER JOIN 
    Departamento d 
ON 
    TRIM(m.cod_dept) = TRIM(d.codigo)
WHERE 
    CONCAT(TRIM(m.cod_dept), TRIM(m.codigo)) LIKE  '" & txtSearch.Text & "'"
        Dim da As New SqlDataAdapter(sql, cnn)
        ds = New DataSet
        da.Fill(ds, "Municipios")
        GridView1.Visible = True
        GridView1.DataSource = ds
        GridView1.DataBind()

        btnClear.Visible = True
    End Sub

    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
        GridView1.Visible = False

    End Sub
End Class