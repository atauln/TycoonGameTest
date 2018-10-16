Public Class TycoonTest
    Dim Money = 0
    Dim MoneyPerClick = 1
    Dim MoneyRequired = 20
    Dim MegaClickers = 0
    Dim MoneyPerClickConfirmed = 0
    Dim MoneyRequiredforMegaClicker = 500
    Dim MoneyRequiredforAutoClickers = 400
    Dim AutoClickers = 0

    Public Sub CheckforMoney()

        Label1.Text = Money
        Label2.Text = MoneyRequired
        Label3.Text = MoneyRequiredforMegaClicker
        Label4.Text = MoneyRequiredforAutoClickers
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MoneyPerClickConfirmed = (MegaClickers * 3 * MoneyPerClick) + MoneyPerClick
        Money += MoneyPerClickConfirmed

        CheckforMoney()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = MoneyRequired
        CheckforMoney()

        If Money >= MoneyRequired Then

            Money = Money - MoneyRequired
            MoneyPerClick = MoneyPerClick + 2
            MoneyRequired = 1 * MoneyRequired
            Label1.Text = Money
            Label2.Text = MoneyRequired
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Money > MoneyRequiredforMegaClicker Then

            Money = Money - MoneyRequiredforMegaClicker
            MegaClickers += 1
            Label1.Text = Money
            MoneyRequiredforMegaClicker = MoneyRequiredforMegaClicker * 1

            Label3.Text = MoneyRequiredforMegaClicker
        End If
        CheckforMoney()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckforMoney()
        Money += 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CheckforMoney()
        If Money >= MoneyRequiredforAutoClickers Then
            Money = Money - MoneyRequiredforAutoClickers
            MoneyRequiredforAutoClickers = MoneyRequiredforAutoClickers * 2
            Label4.Text = MoneyRequiredforAutoClickers
            AutoClickers = AutoClickers + 1
            Timer1.Interval = 1000 / AutoClickers
            Timer1.Enabled = True
        End If

    End Sub
End Class
