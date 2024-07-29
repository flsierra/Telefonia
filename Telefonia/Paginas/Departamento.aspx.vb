Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.Globalization
Public Class About
    Inherits System.Web.UI.Page
    Public ds As DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Private Sub About_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=FABIANPC;Initial Catalog=Telefonia;Integrated Security=True;Encrypt=False"
            Dim sql As String = "select * from Departamento"
            Dim da As New SqlDataAdapter(sql, cnn)
            ds = New DataSet
            da.Fill(ds, "Departamento")
            txtName.Text = ds.Tables("Departamento").Rows(0).Item("nombre")
            txtCod.Text = ds.Tables("Departamento").Rows(0).Item("codigo")
        Catch ex As Exception
            MsgBox("Error de conexion :" + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Protected Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        contDept = 0
        txtName.Text = ds.Tables("Departamento").Rows(contDept).Item("nombre")
        txtCod.Text = ds.Tables("Departamento").Rows(contDept).Item("codigo")
    End Sub

    Protected Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        contDept = contDept - 1
        If contDept > 0 Then
            contDept = contDept + 1
            txtName.Text = ds.Tables("Departamento").Rows(contDept).Item("nombre")
            txtCod.Text = ds.Tables("Departamento").Rows(contDept).Item("codigo")
        Else
            txtName.Text = ds.Tables("Departamento").Rows(contDept).Item("nombre")
            txtCod.Text = ds.Tables("Departamento").Rows(contDept).Item("codigo")
        End If
    End Sub

    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        contDept = contDept + 1
        If contDept >= ds.Tables("Departamento").Rows.Count Then
            contDept = ds.Tables("Departamento").Rows.Count
            contDept = contDept - 1
        End If
        txtName.Text = ds.Tables("Departamento").Rows(contDept).Item("nombre")
        txtCod.Text = ds.Tables("Departamento").Rows(contDept).Item("codigo")
    End Sub

    Protected Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        contDept = ds.Tables("Departamento").Rows.Count
        contDept = contDept - 1
        txtName.Text = ds.Tables("Departamento").Rows(contDept).Item("nombre")
        txtCod.Text = ds.Tables("Departamento").Rows(contDept).Item("codigo")
    End Sub

    Protected Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtName.Text = ""
        txtCod.Text = ""
        btnNew.Enabled = False
        btnUpdate.Enabled = False
        btnDelet.Enabled = False
    End Sub

    Protected Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Call ejecutar("insert into Departamento(codigo,nombre) values('" & txtCod.Text & "', '" & txtName.Text & "')")
        btnDelet.Enabled = False
        btnUpdate.Enabled = False
        contDept = 0
        Response.Redirect("Departamento.aspx")
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call ejecutar("update Departamento set codigo ='" & txtNewCod.Text & "', nombre= '" & txtName.Text & "' where codigo= '" & txtCod.Text & "' ")
        Response.Redirect("Departamento.aspx")
    End Sub

    Protected Sub btnDelet_Click(sender As Object, e As EventArgs) Handles btnDelet.Click
        If MsgBox("¿Esta seguro de eliminar este registro ?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.Yes Then
            Call ejecutar("delete from Departamento where codigo=" & txtCod.Text & " ")
            contDept = 0
            Response.Redirect("Departamento.aspx")
        Else
            Exit Sub
        End If
    End Sub

    Protected Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        btnUpdate.Visible = True
        txtCod.Enabled = False
        btnAction.Visible = False
        lbCod.Visible = True
        txtNewCod.Visible = True

    End Sub
End Class