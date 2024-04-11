Public Class Form1
    Dim n1 As Integer
    Dim n2 As Integer
    Dim secondNumber As Boolean = False
    Dim operation As Integer = 0

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If secondNumber = True Then
            TextBox1.Text = TextBox1.Text + "7"
            TextBox2.Text = TextBox2.Text + "7"
        Else
            TextBox1.Text = TextBox1.Text + "7"
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If secondNumber = True Then
            TextBox1.Text = TextBox1.Text + "8"
            TextBox2.Text = TextBox2.Text + "8"
        Else
            TextBox1.Text = TextBox1.Text + "8"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If secondNumber = True Then
            TextBox1.Text = TextBox1.Text + "9"
            TextBox2.Text = TextBox2.Text + "9"
        Else
            TextBox1.Text = TextBox1.Text + "9"
        End If

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If secondNumber = True Then
            TextBox1.Text = TextBox1.Text + "4"
            TextBox2.Text = TextBox2.Text + "4"
        Else
            TextBox1.Text = TextBox1.Text + "4"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If secondNumber = True Then
            TextBox1.Text = TextBox1.Text + "5"
            TextBox2.Text = TextBox2.Text + "5"
        Else
            TextBox1.Text = TextBox1.Text + "5"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If secondNumber = True Then
            TextBox1.Text = TextBox1.Text + "6"
            TextBox2.Text = TextBox2.Text + "6"
        Else
            TextBox1.Text = TextBox1.Text + "6"
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If secondNumber = True Then
            TextBox1.Text = TextBox1.Text + "1"
            TextBox2.Text = TextBox2.Text + "1"
        Else
            TextBox1.Text = TextBox1.Text + "1"
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If secondNumber = True Then
            TextBox1.Text = TextBox1.Text + "2"
            TextBox2.Text = TextBox2.Text + "2"
        Else
            TextBox1.Text = TextBox1.Text + "2"
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If secondNumber = True Then
            TextBox1.Text = TextBox1.Text + "3"
            TextBox2.Text = TextBox2.Text + "3"
        Else
            TextBox1.Text = TextBox1.Text + "3"
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If secondNumber = True Then
            TextBox1.Text = TextBox1.Text + "0"
            TextBox2.Text = TextBox2.Text + "0"
        Else
            TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim N As Integer
        
            If TextBox1.Text = "" Then
                TextBox1.Text = ""
            Else
                N = Val(TextBox1.Text)
                If TextBox1.Text.Length = N.ToString().Length Then
                n1 = TextBox1.Text
                secondNumber = True
                operation = 1
                    TextBox1.Text = TextBox1.Text + "/"
                End If
            End If
        If TextBox2.Text = "" Then

        Else
            If operation > 0 Then
                If operation = 1 Then
                    TextBox1.Text = n1 / Val(TextBox2.Text)
                End If
                If operation = 2 Then
                    TextBox1.Text = n1 - Val(TextBox2.Text)
                End If
                If operation = 3 Then
                    TextBox1.Text = n1 * Val(TextBox2.Text)
                End If
                If operation = 4 Then
                    TextBox1.Text = n1 + Val(TextBox2.Text)
                End If
                TextBox2.Text = ""
                n1 = Val(TextBox1.Text)
                TextBox1.Text = TextBox1.Text + "/"
                operation = 1
            End If
        End If
       

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim N As Integer
        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            N = Val(TextBox1.Text)
            If TextBox1.Text.Length = N.ToString().Length Then
                n1 = TextBox1.Text
                secondNumber = True
                operation = 2
                TextBox1.Text = TextBox1.Text + "-"
            End If
        End If
        If TextBox2.Text = "" Then

        Else
            If operation > 0 Then
                If operation = 1 Then
                    TextBox1.Text = n1 / Val(TextBox2.Text)
                End If
                If operation = 2 Then
                    TextBox1.Text = n1 - Val(TextBox2.Text)
                End If
                If operation = 3 Then
                    TextBox1.Text = n1 * Val(TextBox2.Text)
                End If
                If operation = 4 Then
                    TextBox1.Text = n1 + Val(TextBox2.Text)
                End If
                TextBox2.Text = ""
                n1 = Val(TextBox1.Text)
                TextBox1.Text = TextBox1.Text + "-"
                operation = 2
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim N As Integer
        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            N = Val(TextBox1.Text)
            If TextBox1.Text.Length = N.ToString().Length Then
                n1 = TextBox1.Text
                secondNumber = True
                operation = 3
                TextBox1.Text = TextBox1.Text + "x"
            End If
        End If
        If TextBox2.Text = "" Then

        Else
            If operation > 0 Then
                If operation = 1 Then
                    TextBox1.Text = n1 / Val(TextBox2.Text)
                End If
                If operation = 2 Then
                    TextBox1.Text = n1 - Val(TextBox2.Text)
                End If
                If operation = 3 Then
                    TextBox1.Text = n1 * Val(TextBox2.Text)
                End If
                If operation = 4 Then
                    TextBox1.Text = n1 + Val(TextBox2.Text)
                End If
                TextBox2.Text = ""
                n1 = Val(TextBox1.Text)
                TextBox1.Text = TextBox1.Text + "x"
                operation = 3
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim N As Integer

        If TextBox1.Text = "" Then
            TextBox1.Text = ""
        Else
            N = Val(TextBox1.Text)
            If TextBox1.Text.Length = N.ToString().Length Then
                n1 = TextBox1.Text
                secondNumber = True
                operation = 4
                TextBox1.Text = TextBox1.Text + "+"
            End If
        End If
        If TextBox2.Text = "" Then
           
        Else
            If operation > 0 Then
                If operation = 1 Then
                    TextBox1.Text = n1 / Val(TextBox2.Text)
                End If
                If operation = 2 Then
                    TextBox1.Text = n1 - Val(TextBox2.Text)
                End If
                If operation = 3 Then
                    TextBox1.Text = n1 * Val(TextBox2.Text)
                End If
                If operation = 4 Then
                    TextBox1.Text = n1 + Val(TextBox2.Text)
                End If
                TextBox2.Text = ""
                n1 = Val(TextBox1.Text)
                TextBox1.Text = TextBox1.Text + "+"
                operation = 4
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If operation > 0 Then
            If operation = 1 Then
                TextBox1.Text = n1 / Val(TextBox2.Text)
            End If
            If operation = 2 Then
                TextBox1.Text = n1 - Val(TextBox2.Text)
            End If
            If operation = 3 Then
                TextBox1.Text = n1 * Val(TextBox2.Text)
            End If
            If operation = 4 Then
                TextBox1.Text = n1 + Val(TextBox2.Text)
            End If
            TextBox2.Text = ""
            operation = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        operation = 0
    End Sub
End Class
