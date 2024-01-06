Public Class FormProgress
    Public Sub setMessage(ByVal iMsg As String)
        lblMessage.Text = iMsg
        Refresh()
    End Sub
End Class