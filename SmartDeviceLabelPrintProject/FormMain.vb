
Public Class FormMain
    Public Shared FormMainInstance As FormMain

    Private Sub FormMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' スキャナ設定初期値を保存
        backupScanProperty()

        ' 実行パスを取得
        Dim path As [String] = Me.[GetType]().Assembly.GetModules()(0).FullyQualifiedName
        Dim en As Int32 = path.LastIndexOf("\")
        mAppPath = path.Substring(0, en)

        ' 設定ファイル読み込み
        myPrinter = getSettings("printer", "1")
        myBDAddress = getSettings("bdaddress", "1")

        ' フォーム上でキーダウンイベントを取得
        Me.KeyPreview = True

        ' インスタンス保持
        FormMainInstance = Me

        ' Bluetooth Open
        If BTOpen() <> 0 Then Exit Sub

        ' 初期フォーカス ボタンの先頭
        btnPrint.Focus()

    End Sub

    Private Sub FormMain_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        ' Bluetooth Close
        BTClose()

        ' スキャナ設定初期値に戻す
        restoreScanProperty()

        ' 設定ファイルに保存
        setSettings("printer", myPrinter)
        setSettings("bdaddress", myBDAddress)

        ' インスタンス破棄
        If FormSetting.FormSettingInstance IsNot Nothing Then
            FormSetting.FormSettingInstance.Dispose()
        End If
        If FormLabelPrint.FormLabelPrintInstance IsNot Nothing Then
            FormLabelPrint.FormLabelPrintInstance.Dispose()
        End If
        If FormMain.FormMainInstance IsNot Nothing Then
            FormMain.FormMainInstance.Dispose()
        End If

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As Form = New FormLabelPrint()
        frm.Show()
    End Sub

    Private Sub btnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click
        Dim frm As Form = New FormSetting()
        frm.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FormMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyValue
            Case Keys.NumPad1
                Call btnPrint_Click(sender, e)
            Case Keys.NumPad8
                Call btnSetting_Click(sender, e)
            Case Keys.NumPad9
                Call btnClose_Click(sender, e)
        End Select
    End Sub
End Class
