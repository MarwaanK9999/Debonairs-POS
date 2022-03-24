Public Class frmMainMenu
    Private Sub btnUpdateDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateDetails.Click

        'Hides the current Interface, so that the user cannot access it after the next interface shows.
        Me.Hide()
        'Navigates the user to the Add/Edit Product Details Interface.
        frmProductDetails.Show()

    End Sub

    Private Sub btnUpdateQuantity_Click(sender As Object, e As EventArgs) Handles btnUpdateQuantity.Click

        'Hides the current Interface, so that the user cannot access it after the next interface shows.
        Me.Hide()
        'Navigates the user to the Update Product Quantity Interface.
        frmProductQuantity.Show()

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click

        'Hides the current Interface, so that the user cannot access it after the next interface shows.
        Me.Hide()
        'Navigates the user to the Point of Sales Interface.
        frmPOS.Show()

    End Sub

    Private Sub btnViewInformation_Click(sender As Object, e As EventArgs) Handles btnViewInformation.Click

        'Hides the current Interface, so that the user cannot access it after the next interface shows.
        Me.Hide()
        'Navigates the user to the View Product Information Interface.
        frmProductInformation.Show()

    End Sub

    Private Sub btnViewSales_Click(sender As Object, e As EventArgs) Handles btnViewSales.Click

        'Hides the current Interface, so that the user cannot access it after the next interface shows.
        Me.Hide()
        'Navigates the user to the View Sales Information Interface.
        frmSalesInformation.Show()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

        'Hides the current Interface, so that the user cannot access it after the next interface shows.
        Me.Hide()
        'Navigates the user to the Login Interface.
        frmLogin.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Exits the entire application, so that the user cannot access it after the next interface shows.
        Application.Exit()

    End Sub
End Class