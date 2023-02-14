Public Class frmBurger


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        picPrime.Visible = True
        picVeggie.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        btnPrime.Enabled = False
        btnVeggie.Enabled = False
        lblConfirmation.Visible = True
        lblInstructions.Visible = False
        btnSelectMeal.Enabled = False
        btnExit.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        picPrime.Visible = False
        picVeggie.Visible = True
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub lblChoice_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click

    End Sub

    Private Sub btnPrime_MouseCaptureChanged(sender As Object, e As EventArgs) Handles btnPrime.MouseCaptureChanged

    End Sub

    Private Sub picPrime_Click(sender As Object, e As EventArgs) Handles picPrime.Click

    End Sub
End Class
