Imports System.Threading
Imports System.Runtime.InteropServices

Public Class FormLabelPrint

    ' このWindowのインスタンス
    Public Shared FormLabelPrintInstance As FormLabelPrint

    Private Const PROCESS_EXIT_WAIT_TIME As Integer = 200

    ' テンプレート番号の初期値
    Private Const cTEMPLATE As String = "1"


    Private Sub FormLabelPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Blutooth Open
        BTOpen()

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
        FormLabelPrintInstance = Me

        ' 設定プリンター名
        setPrinterText()

        ' 初期テンプレート番号
        txtTemplate.Text = cTEMPLATE

        ' 初期カーソルを品番へ
        txtClear()

    End Sub

    Private Sub FormLabelPrint_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

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

    End Sub

    Private Sub FormLabelPrint_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyValue
            Case Bt.LibDef.BT_VK_F1
                Call btnF1_Click(sender, e)
            Case Bt.LibDef.BT_VK_F2
                Call btnF2_Click(sender, e)
            Case Bt.LibDef.BT_VK_F3
                Call btnF3_Click(sender, e)
            Case Bt.LibDef.BT_VK_F4
                Call btnF4_Click(sender, e)
        End Select
    End Sub

    ' 設定プリンター名を表示
    Private Sub setPrinterText()
        If myPrinter = 9 Then
            lblPrinter.Text = "[" & Mid(myBDAddress, 1, 2) & ":" & Mid(myBDAddress, 3, 2) & ":" & Mid(myBDAddress, 5, 2) _
                            & ":" & Mid(myBDAddress, 7, 2) & ":" & Mid(myBDAddress, 9, 2) & ":" & Mid(myBDAddress, 11, 2) & "]"
        Else
            lblPrinter.Text = "場所 " & aryPrinterName(myPrinter - 1)
        End If
    End Sub

    ' F1キー（終了）
    Private Sub btnF1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF1.Click
        Close()
    End Sub

    ' F2キー（印刷）
    Private Sub btnF2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF2.Click
        myPrint()
    End Sub

    ' F3キー（設定変更）
    Private Sub btnF3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF3.Click
        Dim frm As Form = New FormSetting()
        frm.ShowDialog()
        setPrinterText()
    End Sub

    ' F4キー（クリア）
    Private Sub btnF4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF4.Click
        Call txtClear()
    End Sub

    ' クリア処理
    Private Sub txtClear()
        txtHMCD.Text = ""
        txtQTY.Text = "1"
        txtHMCD.Focus()
    End Sub

    ' 品番
    Private Sub txtHMCD_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHMCD.GotFocus
        Dim modeSet As UInt32 = Bt.LibDef.BT_KEYINPUT_DIRECT
        Dim ret As Int32 = Bt.SysLib.Display.btSetKeyCharacter(modeSet)
        If ret <> 0 Then
            MessageBox.Show("キー入力設定に失敗しました:" & ret)
        End If
        'Call setScanProperty(1)
        txtHMCD.SelectionStart = 0
        txtHMCD.SelectionLength = txtHMCD.TextLength
        txtHMCD.BackColor = Color.Aqua
    End Sub

    Private Sub txtHMCD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHMCD.LostFocus
        ' エラーチェック
        If txtHMCD.TextLength > 24 Or Strings.Left(txtHMCD.Text, 2) = "**" Then
            MessageBox.Show("社内品番を読み取ってください")
            txtHMCD.Focus()
            Return
        End If
        txtHMCD.BackColor = Color.White
    End Sub

    Private Sub txtHMCD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHMCD.KeyDown
        Select Case e.KeyCode
            Case System.Windows.Forms.Keys.Up
                txtQTY.Focus()
            Case System.Windows.Forms.Keys.Down
                txtQTY.Focus()
            Case System.Windows.Forms.Keys.Enter
                If txtHMCD.Text <> "" Then
                    txtQTY.Focus()
                End If
        End Select
    End Sub

    ' 印刷枚数
    Private Sub txtQTY_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQTY.GotFocus
        Dim modeSet As UInt32 = Bt.LibDef.BT_KEYINPUT_DIRECT
        Dim ret As Int32 = Bt.SysLib.Display.btSetKeyCharacter(modeSet)
        If ret <> 0 Then
            MessageBox.Show("キー入力設定に失敗しました:" & ret)
        End If
        txtQTY.SelectionStart = 0
        txtQTY.SelectionLength = txtQTY.TextLength
        txtQTY.BackColor = Color.Aqua
    End Sub

    Private Sub txtQTY_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQTY.LostFocus
        txtQTY.BackColor = Color.White
    End Sub

    ' 印刷枚数
    Private Sub txtQTY_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQTY.KeyDown
        Select Case e.KeyCode
            Case System.Windows.Forms.Keys.Up
                txtHMCD.Focus()
            Case System.Windows.Forms.Keys.Down
                txtTemplate.Focus()
            Case System.Windows.Forms.Keys.Back
                If txtQTY.Text = "" Then
                    txtHMCD.Focus()
                End If
            Case System.Windows.Forms.Keys.Enter ' ラベル印刷
                Call myPrint()
        End Select
    End Sub

    ' テンプレート番号
    Private Sub txtTemplate_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim modeSet As UInt32 = Bt.LibDef.BT_KEYINPUT_DIRECT
        Dim ret As Int32 = Bt.SysLib.Display.btSetKeyCharacter(modeSet)
        If ret <> 0 Then
            MessageBox.Show("キー入力設定に失敗しました:" & ret)
        End If
        txtTemplate.SelectionStart = 0
        txtTemplate.SelectionLength = txtTemplate.TextLength
        txtTemplate.BackColor = Color.Aqua
    End Sub

    Private Sub txtTemplate_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtTemplate.BackColor = Color.White
    End Sub

    Private Sub txtTemplate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case System.Windows.Forms.Keys.Up
                txtQTY.Focus()
            Case System.Windows.Forms.Keys.Down
                txtHMCD.Focus()
            Case System.Windows.Forms.Keys.Enter
                btnF2.Focus()
                ' ラベル印刷
                Call myPrint()
        End Select
    End Sub

    ' ラベル印刷
    Private Sub myPrint()
        Dim hmcd As String = txtHMCD.Text
        Dim qty As String = txtQTY.Text
        Dim temp As String = txtTemplate.Text
        If hmcd = "" Then
            MessageBox.Show("社内品番を入力してください")
            txtHMCD.Focus()
            Return
        ElseIf qty = "" Then
            MessageBox.Show("印刷枚数を入力してください")
            txtQTY.Focus()
            Return
        ElseIf temp = "" Then
            MessageBox.Show("テンプレート番号を入力してください")
            txtTemplate.Focus()
            Return
        End If

        ' 進捗ダイアログ表示
        FormProgress.Show()

        ' Blutooth Open
        'FormProgress.setMessage("Blutooth オープン")
        'Refresh()
        'If BTOpen() <> 0 Then
        '    FormProgress.Hide()
        '    Exit Sub
        'End If
        'System.Threading.Thread.Sleep(200)

        ' SPP Connect
        FormProgress.setMessage("接続中...") 'Blutooth(SPP)接続
        Refresh()
        If SPPConnect() <> 0 Then
            FormProgress.Hide()
            GoTo BT_End
        End If
        'System.Threading.Thread.Sleep(100)

        ' SPP Send
        FormProgress.setMessage("データ送信中...")
        Refresh()
        If SPPSend(hmcd, qty, temp) <> 0 Then GoTo SPP_END
        'System.Threading.Thread.Sleep(100)

        FormProgress.setMessage("ラベル出力指示完了.")

        txtClear()

        txtHMCD.Focus()

SPP_END:
        ' 進捗画面非表示
        FormProgress.Hide()

        ' SPP DisConnect
        SPPDisconnect()

BT_END:
        ' Bluetooth Close
        ' BTClose()

    End Sub

End Class
