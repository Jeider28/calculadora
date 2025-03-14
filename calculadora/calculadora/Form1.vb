Imports System.Drawing
Imports System.Windows.Forms
Public Class form1

    Private valoruno As Double
    Private valordos As Double
    Private operacion As Integer
    Private resultado As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbresultado.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_valor1.TextChanged
        Dim valor1 = tb_valor1.Text
        Double.TryParse(valor1, valoruno)
    End Sub

    Private Sub tb_valor2_TextChanged(sender As Object, e As EventArgs) Handles tb_valor2.TextChanged
        Dim valor2 = tb_valor2.Text
        Double.TryParse(valor2, valordos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If operacion = 1 Then
            resultado = valoruno + valordos
        End If

        If operacion = 2 Then
            resultado = valoruno - valordos
        End If

        If operacion = 3 Then
            resultado = valoruno * valordos
        End If

        If operacion = 4 Then
            resultado = valoruno / valordos
        End If

        lbresultado.Visible = True
        lbresultado.Text = resultado
    End Sub

    Private Sub btn_suma_Click(sender As Object, e As EventArgs) Handles btn_suma.Click
        operacion = 1
        btn_calcular.Enabled = True
    End Sub

    Private Sub btn_resta_Click(sender As Object, e As EventArgs) Handles btn_resta.Click
        operacion = 2
        btn_calcular.Enabled = True
    End Sub

    Private Sub btn_multiplicacion_Click(sender As Object, e As EventArgs) Handles btn_multiplicacion.Click
        operacion = 3
        btn_calcular.Enabled = True
    End Sub

    Private Sub btn_division_Click(sender As Object, e As EventArgs) Handles btn_division.Click
        operacion = 4
        btn_calcular.Enabled = True
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)
    End Sub
End Class
