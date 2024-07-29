Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.Globalization
Public Class Municipio
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub Municipio_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=FABIANPC;Initial Catalog=Telefonia;Integrated Security=True;Encrypt=False"
            Dim sql As String = "select * from Municipios"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Municipios")
            txtNameMun.Text = ds.Tables("Municipios").Rows(0).Item("nombre")
            txtCodMun.Text = ds.Tables("Municipios").Rows(0).Item("codigo")
            txtCodDept.Text = ds.Tables("Municipios").Rows(0).Item("cod_dept")
        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Protected Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        contMun = 0
        txtNameMun.Text = ds.Tables("Municipios").Rows(0).Item("nombre")
        txtCodMun.Text = ds.Tables("Municipios").Rows(0).Item("codigo")
        txtCodDept.Text = ds.Tables("Municipios").Rows(0).Item("cod_dept")
    End Sub

    Protected Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        contMun = contMun - 1
        If contMun > 0 Then
            contMun = contMun + 1
            txtNameMun.Text = ds.Tables("Municipios").Rows(0).Item("nombre")
            txtCodMun.Text = ds.Tables("Municipios").Rows(0).Item("codigo")
            txtCodDept.Text = ds.Tables("Municipios").Rows(0).Item("cod_dept")
        Else
            txtNameMun.Text = ds.Tables("Municipios").Rows(0).Item("nombre")
            txtCodMun.Text = ds.Tables("Municipios").Rows(0).Item("codigo")
            txtCodDept.Text = ds.Tables("Municipios").Rows(0).Item("cod_dept")
        End If
    End Sub

    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        contMun = contMun + 1
        If contMun >= ds.Tables("Municipios").Rows.Count Then
            contMun = ds.Tables("Departamento").Rows.Count
            contMun = contMun - 1
        End If
        txtNameMun.Text = ds.Tables("Municipios").Rows(0).Item("nombre")
        txtCodMun.Text = ds.Tables("Municipios").Rows(0).Item("codigo")
        txtCodDept.Text = ds.Tables("Municipios").Rows(0).Item("cod_dept")
    End Sub

    Protected Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        contMun = ds.Tables("Municipios").Rows.Count
        contMun = contMun - 1
        txtNameMun.Text = ds.Tables("Municipios").Rows(0).Item("nombre")
        txtCodMun.Text = ds.Tables("Municipios").Rows(0).Item("codigo")
        txtCodDept.Text = ds.Tables("Municipios").Rows(0).Item("cod_dept")
    End Sub

    Protected Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtNameMun.Text = ""
        txtCodMun.Text = ""
        txtCodDept.Text = ""
        txtCodDept.Enabled = True
        btnNew.Enabled = False
        btnUpdate.Enabled = False
        btnDelet.Enabled = False
    End Sub

    Protected Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Call ejecutar("insert into Municipios(codigo,nombre,cod_dept) values('" & txtCodMun.Text & "', '" & txtNameMun.Text & "', '" & txtCodDept.Text & "')")
        btnDelet.Enabled = False
        btnUpdate.Enabled = False
        contDept = 0
        Response.Redirect("Municipio.aspx")
    End Sub
End Class