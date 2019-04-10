Public Class Form1
	Dim operacion As String
	Dim valor As Nullable(Of Double) = Nothing
	Dim valor1 As Nullable(Of Double) = Nothing
	Dim presionar As Boolean
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		evaluaRestricciones()
		TextResultado.Text &= "1"
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		evaluaRestricciones()
		TextResultado.Text &= "2"
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		evaluaRestricciones()
		TextResultado.Text &= "3"
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		evaluaRestricciones()
		TextResultado.Text &= "4"
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		evaluaRestricciones()
		TextResultado.Text &= "5"

	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		evaluaRestricciones()
		TextResultado.Text &= "6"
	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		evaluaRestricciones()
		TextResultado.Text &= "7"
	End Sub

	Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
		evaluaRestricciones()
		TextResultado.Text &= "8"
	End Sub

	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		evaluaRestricciones()
		TextResultado.Text &= "9"
	End Sub

	Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
		evaluaRestricciones()
		TextResultado.Text &= "0"
	End Sub

	Private Sub Buttonpunto_Click(sender As Object, e As EventArgs) Handles Buttonpunto.Click
		If TextResultado.Text = "" Then
			TextResultado.Text = "0."
		ElseIf comprobar(TextResultado.Text) = False Then
			TextResultado.Text = TextResultado.Text & "."

		End If

	End Sub

	Private Function comprobar(ByVal cadena As String) As Boolean
		Dim largo As Integer
		Dim respuesta As Boolean = False
		largo = cadena.Length
		For i As Integer = 1 To largo Step 1
			If Mid(cadena, i, 1) = "." Then
				respuesta = True
			End If
		Next
		Return respuesta
	End Function


	Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
		haceroperacion()
		operacion = "+"
	End Sub
	Public Sub haceroperacion()
		presionar = True
		valor1 = Val(TextResultado.Text)
		If valor IsNot Nothing Then
			Select Case operacion
				Case "+"
					valor = valor + valor1
				Case "-"
					valor = valor - valor1
				Case "*"
					valor = valor * valor1
				Case "/"
					valor = valor / valor1
				Case "√"
					valor = valor1 ^ (1 / 2)
				Case "^"
					valor = valor1 ^ 2
				Case "^3"
					valor = valor1 ^ 3
				Case "^4"
					valor = valor1 ^ 4
				Case "^5"
					valor = valor1 ^ 5
			End Select
			TextResultado.Text = valor
		Else
			valor = valor1
		End If
	End Sub

	Private Sub ButtonRestar_Click(sender As Object, e As EventArgs) Handles ButtonRestar.Click
		haceroperacion()
		operacion = "-"
	End Sub

	Private Sub ButtonDividir_Click(sender As Object, e As EventArgs) Handles ButtonDividir.Click
		haceroperacion()
		operacion = "/"
	End Sub

	Private Sub ButtonMultiplicar_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicar.Click
		haceroperacion()
		operacion = "*"
	End Sub

	Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
		haceroperacion()
		operacion = ""
	End Sub
	Public Sub evaluaRestricciones()
		If presionar = True Then
			TextResultado.Text = ""
			presionar = False
		ElseIf Textresultado.text = "0" Then
			TextResultado.Text = ""
		End If
	End Sub

	Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
		TextResultado.Text = "0"
		valor = Nothing
		valor1 = Nothing
	End Sub

	Private Sub ButtonExponente_Click(sender As Object, e As EventArgs) Handles ButtonExponente.Click
		haceroperacion()
		operacion = "^"
	End Sub

	Private Sub ButtonRaiz_Click(sender As Object, e As EventArgs) Handles ButtonRaiz.Click
		haceroperacion()
		operacion = "√"
	End Sub

	Private Sub ButtonElevar3_Click(sender As Object, e As EventArgs) Handles ButtonElevar3.Click
		haceroperacion()
		operacion = "^3"
	End Sub

	Private Sub ButtonElevar4_Click(sender As Object, e As EventArgs) Handles ButtonElevar4.Click
		haceroperacion()
		operacion = "^4"
	End Sub

	Private Sub ButtonElevar5_Click(sender As Object, e As EventArgs) Handles ButtonElevar5.Click
		haceroperacion()
		operacion = "^5"
	End Sub
End Class
