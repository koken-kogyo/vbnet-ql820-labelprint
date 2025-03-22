Public Class FormSetting
    Public Shared FormSettingInstance As FormSetting


    Private Sub FormSetting_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' 初期画面設定
        cmbPrinters.Items.Clear()
        Dim wVar As String
        For Each wVar In aryPrinterName
            cmbPrinters.Items.Add(wVar)
        Next
        If myPrinter = 9 Then
            cmbPrinters.SelectedIndex = cmbPrinters.Items.Count - 1
        Else
            cmbPrinters.SelectedIndex = myPrinter - 1
        End If

        ' フォーム上でキーダウンイベントを取得
        Me.KeyPreview = True

        ' インスタンス保持
        FormSettingInstance = Me

        ' 初期フォーカス ボタンの先頭
        'btnPrint.Focus()

    End Sub

    Private Sub FormSetting_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyValue
            Case Bt.LibDef.BT_VK_F1
                Call btnF1_Click(sender, e)
            Case Bt.LibDef.BT_VK_F2
                Call btnF2_Click(sender, e)
            Case Bt.LibDef.BT_VK_F4
                Call btnF4_Click(sender, e)
        End Select
    End Sub

    Private Sub cmbPrinters_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrinters.SelectedIndexChanged
        If cmbPrinters.SelectedIndex = cmbPrinters.Items.Count - 1 Then
            btnF4.Text = "ｸﾘｱ"
            lblBDAddressTitle.Text = "BDｱﾄﾞﾚｽ直接入力"
            txtBDAddress.Enabled = True
            txtBDAddress.Text = myBDAddress
            txtBDAddress.Focus()
        Else
            btnF4.Text = "選択"
            lblBDAddressTitle.Text = "BDｱﾄﾞﾚｽ："
            txtBDAddress.Enabled = False
            txtBDAddress.BackColor = Color.LightGray
            txtBDAddress.Text = aryBRAddress(cmbPrinters.SelectedIndex)
        End If
    End Sub

    ' 戻る
    Private Sub btnF1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF1.Click
        'If cmbPrinters.SelectedIndex = cmbPrinters.Items.Count - 1 Then
        '    If myPrinter <> 9 Then
        '        If MsgBox("変更は保存されていません." & vbCrLf & "本当に戻ってもよろしいですか？", MsgBoxStyle.Question + MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        '    End If
        'Else
        '    If cmbPrinters.SelectedIndex <> myPrinter - 1 Then
        '        If MsgBox("変更は保存されていません." & vbCrLf & "本当に戻ってもよろしいですか？", MsgBoxStyle.Question + MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Exit Sub
        '    End If
        'End If
        Close()
    End Sub

    ' 設定
    Private Sub btnF2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF2.Click
        setPrinter()
    End Sub

    ' クリアor選択
    Private Sub btnF4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF4.Click
        If txtBDAddress.Enabled = True Then
            If txtBDAddress.Text = "" Then
                cmbPrinters.SelectedIndex = myPrinter - 1
                cmbPrinters.Focus()
            Else
                txtBDAddress.Text = ""
                txtBDAddress.Focus()
            End If
        Else
            cmbPrinters.Focus()
        End If
    End Sub

    ' コンボボックスショートカットキー
    Private Sub cmbPrinters_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPrinters.KeyDown
        Select Case e.KeyValue
            Case Keys.NumPad1
                cmbPrinters.SelectedIndex = 1
            Case Keys.NumPad2
                cmbPrinters.SelectedIndex = 2
            Case Keys.NumPad3
                cmbPrinters.SelectedIndex = 3
        End Select
    End Sub

    ' BDアドレス
    Private Sub txtBDAddress_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBDAddress.GotFocus
        Dim modeSet As UInt32 = Bt.LibDef.BT_KEYINPUT_DIRECT
        Dim ret As Int32 = Bt.SysLib.Display.btSetKeyCharacter(modeSet)
        If ret <> 0 Then
            MessageBox.Show("キー入力設定に失敗しました:" & ret)
        End If
        'Call setScanProperty(1)
        txtBDAddress.SelectionStart = 0
        txtBDAddress.SelectionLength = txtBDAddress.TextLength
        txtBDAddress.BackColor = Color.Aqua
    End Sub

    Private Sub txtBDAddress_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBDAddress.LostFocus
        txtBDAddress.BackColor = Color.White
    End Sub

    ' プリンター番号をセットしてフォーム終了
    Private Sub setPrinter()
        If cmbPrinters.SelectedIndex = cmbPrinters.Items.Count - 1 Then

            ' 9:その他はBDｱﾄﾞﾚｽを使用
            If txtBDAddress.Text = "" Then
                MsgBox("BDｱﾄﾞﾚｽを入力してください", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If InStr(txtBDAddress.Text, ":") > 0 Then
                MsgBox("[:]コロンは入力しないで下さい。変換して以降処理を行います．", MsgBoxStyle.Exclamation)
                txtBDAddress.Text = Replace(txtBDAddress.Text, ":", "")
            End If
            If Len(txtBDAddress.Text) <> 12 Then
                MsgBox("BDｱﾄﾞﾚｽは12桁で入力してください", MsgBoxStyle.Critical)
                Exit Sub
            End If
            myPrinter = 9
            myBDAddress = txtBDAddress.Text

        Else

            ' それ以外はプリンタ番号を使用
            myPrinter = cmbPrinters.SelectedIndex + 1
            myBDAddress = "-"

        End If
        Close()
    End Sub

End Class
