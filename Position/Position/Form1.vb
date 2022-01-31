Public Class Form1
    'Tazvik Ziauddin
    'Ch.3 Excer.10

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click

        End

    End Sub

    Private Sub mnuTopleft_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTopleft.Click

        Me.lblPosition.TextAlign = ContentAlignment.TopLeft

    End Sub

    Private Sub mnuTopright_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTopright.Click

        Me.lblPosition.TextAlign = ContentAlignment.TopRight

    End Sub

    Private Sub mnuTopcenter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTopcenter.Click

        Me.lblPosition.TextAlign = ContentAlignment.TopCenter

    End Sub

    Private Sub mnuMiddleright_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuMiddleright.Click

        Me.lblPosition.TextAlign = ContentAlignment.MiddleRight

    End Sub

    Private Sub mnuMiddleleft_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuMiddleleft.Click

        Me.lblPosition.TextAlign = ContentAlignment.MiddleLeft

    End Sub

    Private Sub mnuMiddlecenter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuMiddlecenter.Click

        Me.lblPosition.TextAlign = ContentAlignment.MiddleCenter

    End Sub

    Private Sub mnuBottomright_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBottomright.Click

        Me.lblPosition.TextAlign = ContentAlignment.BottomRight

    End Sub

    Private Sub mnuBottomleft_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBottomleft.Click

        Me.lblPosition.TextAlign = ContentAlignment.BottomLeft

    End Sub

    Private Sub mnuBottomcenter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuBottomcenter.Click

        Me.lblPosition.TextAlign = ContentAlignment.BottomCenter

    End Sub

End Class
