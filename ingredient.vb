Public Class Ingredient
    Dim n As Integer
    'Dim add1 As String  '讀配料的ID
    'Dim add2 As String
    ' Dim add3 As String
    'Dim add4 As String
    Dim number As Integer = 0
    Sub plus(ByVal name As Object, ByVal add As String)
        If Val(name.text) < 2 And ListBox1.Items.Count < number Then
            name.text = Val(name.text) + 1.ToString
            ListBox1.Items.Add(add)
        End If
    End Sub
    Sub minus(ByVal name As Object, ByVal remove As String)
        If Val(name.text) > 0 Then
            name.text = Val(name.text) - 1.ToString
            ListBox1.Items.RemoveAt(ListBox1.FindString(remove))
        End If
    End Sub

    Private Sub Ingredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        number = orderpage.a
        n = orderpage.n
    End Sub

    Private Sub done_Click(sender As Object, e As EventArgs) Handles done.Click
        Dim add(3) As String
        Dim list(3) As String



        For j = 0 To ListBox1.Items.Count - 1
            list(j) = ListBox1.Items(j)
            Select Case list(j)
                Case "花生"
                    add(j) = 1
                Case "雪蓮子"
                    add(j) = 2
                Case "紅豆"
                    add(j) = 3
                Case "綠豆"
                    add(j) = 4
                Case "薏仁"
                    add(j) = 5
                Case "粉圓"
                    add(j) = 6
                Case "芋圓"
                    add(j) = 7
                Case "地瓜圓"
                    add(j) = 8
                Case "黑糖粉粿"
                    add(j) = 9
            End Select
        Next


        'Label1.Text = add(0)
        'Label2.Text = add(1)
        'Label3.Text = add(2)
        'Label4.Text = add(3)
        orderpage.add1(n) = add(0)
        orderpage.add2(n) = add(1)
        orderpage.add3(n) = add(2)
        orderpage.add4(n) = add(3)

        Me.Close()
    End Sub

    Private Sub Peanut_plus_Click(sender As Object, e As EventArgs) Handles Peanut_plus.Click
        plus(Peanut_num, "花生")
    End Sub

    Private Sub Peanut_minus_Click(sender As Object, e As EventArgs) Handles Peanut_minus.Click
        minus(Peanut_num, "花生")
    End Sub

    Private Sub Chickpea_minus_Click(sender As Object, e As EventArgs) Handles Chickpea_minus.Click
        minus(Chickpea_num, "雪蓮子")
    End Sub

    Private Sub Chickpea_plus_Click(sender As Object, e As EventArgs) Handles Chickpea_plus.Click
        plus(Chickpea_num, "雪蓮子")
    End Sub

    Private Sub Redbean_minus_Click(sender As Object, e As EventArgs) Handles Redbean_minus.Click
        minus(RedBean_num, "紅豆")
    End Sub

    Private Sub Redbean_plus_Click(sender As Object, e As EventArgs) Handles Redbean_plus.Click
        plus(RedBean_num, "紅豆")
    End Sub

    Private Sub Greenbean_minus_Click(sender As Object, e As EventArgs) Handles Greenbean_minus.Click
        minus(GreenBean_num, "綠豆")
    End Sub

    Private Sub Greenbean_plus_Click(sender As Object, e As EventArgs) Handles Greenbean_plus.Click
        plus(GreenBean_num, "綠豆")
    End Sub

    Private Sub PearlBarley_minus_Click(sender As Object, e As EventArgs) Handles PearlBarley_minus.Click
        minus(PearlBarley_num, "薏仁")
    End Sub

    Private Sub PearlBarley_plus_Click(sender As Object, e As EventArgs) Handles PearlBarley_plus.Click
        plus(PearlBarley_num, "薏仁")
    End Sub

    Private Sub bubble_minus_Click(sender As Object, e As EventArgs) Handles bubble_minus.Click
        minus(bubble_num, "粉圓")
    End Sub

    Private Sub bubble_plus_Click(sender As Object, e As EventArgs) Handles bubble_plus.Click
        plus(bubble_num, "粉圓")
    End Sub

    Private Sub TaroBall_minus_Click(sender As Object, e As EventArgs) Handles TaroBall_minus.Click
        minus(TaroBall_num, "芋圓")
    End Sub

    Private Sub TaroBall_plus_Click(sender As Object, e As EventArgs) Handles TaroBall_plus.Click
        plus(TaroBall_num, "芋圓")
    End Sub

    Private Sub SweetPotatoBall_minus_Click(sender As Object, e As EventArgs) Handles SweetPotatoBall_minus.Click
        minus(SweetPotatoBall_num, "地瓜圓")
    End Sub

    Private Sub SweetPotatoBall_plus_Click(sender As Object, e As EventArgs) Handles SweetPotatoBall_plus.Click
        plus(SweetPotatoBall_num, "地瓜圓")
    End Sub

    Private Sub BrownSugarJellyCake_minus_Click(sender As Object, e As EventArgs) Handles BrownSugarJellyCake_minus.Click
        minus(BrownSugarJellyCake_num, "黑糖粉粿")
    End Sub

    Private Sub BrownSugarJellyCake_plus_Click(sender As Object, e As EventArgs) Handles BrownSugarJellyCake_plus.Click
        plus(BrownSugarJellyCake_num, "黑糖粉粿")
    End Sub

    Private Sub Chickpea_Click(sender As Object, e As EventArgs) Handles Chickpea.Click

    End Sub
End Class