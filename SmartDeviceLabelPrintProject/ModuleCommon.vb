Imports System.Runtime.InteropServices
Imports System.Text
Imports Bt.CommLib
Imports Bt.FileLib
Imports Bt.SysLib
Imports Bt

Module ModuleCommon

    ' アプリケーション実行パス
    Public mAppPath As [String] = ""

    ' iniファイル関連
    Private iniFileName As [String] = "LabelPrint.ini"

    Public myPrinter As Integer
    Public myBDAddress As String
    Public aryPrinterName() As String = Split("1:炉中洩検(1階),2:建機工程,3:QL-820NWBc,9:その他", ",")
    Public aryBRAddress() As String = Split("10B1DF73255E,1804ed6bd155,10B1DF73255E,", ",")

    '*******************************************************************************
    '         * 機能 ：iniファイルで1行単位のReadを行います。
    '         * API  ：btIniReadString
    '*******************************************************************************

    Public Function getSettings(ByVal iKey As String, ByVal iDef As String) As String
        Dim ret As Int32 = 0
        Dim disp As [String] = ""

        ' セクション
        Dim sectionSet As New StringBuilder("PRINTER")
        ' キー
        Dim keySet As New StringBuilder(iKey) '"printer"
        ' INIファイル
        Dim filenameSet As New StringBuilder(mAppPath & "\" & iniFileName)
        ' 既定値(ReadString用)
        Dim strDefSet As New StringBuilder(iDef) '"1"
        ' 取得値
        Dim bufaryGet As [Byte]() = New [Byte](LibDef.BT_INI_VALUE_MAXLEN - 1) {}
        ' サイズ
        Dim sizeSet As UInt32 = 0
        ' 取得値(ReadString用)
        Dim strGet As [String] = ""
        Try
            '-----------------------------------------------------------
            ' 読み出し
            '-----------------------------------------------------------
            sizeSet = LibDef.BT_INI_VALUE_MAXLEN
            ret = Ini.btIniReadString(sectionSet, keySet, strDefSet, bufaryGet, sizeSet, filenameSet)
            If ret = 0 Then
                disp = "btIniReadString error ret[" & ret & "]"
                MessageBox.Show(disp, "エラー")
            End If
            strGet = Encoding.Unicode.GetString(bufaryGet, 0, (ret * 2))
            Return strGet
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return strDefSet.ToString
    End Function

    '*******************************************************************************
    '         * 機能 ：iniファイルで1行単位のWriteを行います。
    '         * API  ：btIniWriteString
    '*******************************************************************************
    Public Sub setSettings(ByVal iKey As String, ByVal iVal As String)
        Dim ret As Int32 = 0
        Dim disp As [String] = ""

        ' セクション
        Dim sectionSet As New StringBuilder("PRINTER")
        ' キー
        Dim keySet As New StringBuilder(iKey)
        ' INIファイル
        Dim filenameSet As New StringBuilder(mAppPath & "\" & iniFileName)
        ' 書き込み用
        Dim strSet As New StringBuilder("")
        ' 既定値(ReadString用)
        Dim strDefSet As New StringBuilder("")
        ' サイズ
        Dim sizeSet As UInt32 = 0
        Try
            '-----------------------------------------------------------
            ' 書き込み
            '-----------------------------------------------------------
            strSet = New StringBuilder(iVal)
            ret = Ini.btIniWriteString(sectionSet, keySet, strSet, filenameSet)
            If ret <> LibDef.BT_OK Then
                disp = "btIniWriteString error ret[" & ret & "]"
                MessageBox.Show(disp, "エラー")
                Return
            End If
            disp = "書き込み:" & strSet.ToString()
            'MessageBox.Show(disp, "Iniファイル(文字列)")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    '*******************************************************************************
    '         * 機能 ：Bluetoothをオープンします。
    '         * API  ：btBluetoothOpen
    '*******************************************************************************
    Public Function BTOpen() As Int32
        Dim ret As Int32 = 0
        Dim disp As [String] = ""

        Try
            ret = Bluetooth.btBluetoothOpen()
            If ret = LibDef.BT_OK Or ret = LibDef.BT_ERR_COMM_ALREADY_OPEN Then
                Return LibDef.BT_OK
            Else
                disp = "Bluetoothのオープンに失敗しました [" & ret & "]"
                MessageBox.Show(disp, "エラー")
                Return ret
            End If
        Catch ex As Exception
            Return 999
        End Try
    End Function

    '*******************************************************************************
    '         * 機能 ：Bluetoothをクローズします。
    '         * API  ：btBluetoothClose
    '*******************************************************************************
    Public Sub BTClose()
        Dim ret As Int32 = 0
        Dim disp As [String] = ""

        Try
            ret = Bluetooth.btBluetoothClose()
            If ret <> LibDef.BT_OK Then
                disp = "Bluetoothクローズエラー [" & ret & "]"
                MessageBox.Show(disp, "エラー")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    '*******************************************************************************
    '         * 機能 ：SPP接続を行います。
    '         * API  ：btBluetoothSPPConnect   
    '*******************************************************************************

    Public Function SPPConnect() As Int32
        Dim ret As Int32 = 0
        Dim disp As [String] = ""

        Dim stInfoSet As New LibDef.BT_BLUETOOTH_TARGET()
        Dim timeoutSet As UInt32 = 0

        Try
            timeoutSet = 30000
            If myPrinter = 1 Then

                stInfoSet.addr = "10B1DF73255E"
                stInfoSet.name = "QL-820NWB5054"

            ElseIf myPrinter = 2 Then

                stInfoSet.addr = "1804ed6bd155"
                stInfoSet.name = "QL-820NWB9551"

            ElseIf myPrinter = 3 Then

                stInfoSet.addr = "10B1DF73255E"
                stInfoSet.name = "QL-820NWB5054"

            ElseIf myPrinter = 9 Then

                stInfoSet.addr = myBDAddress
                stInfoSet.name = "OTHER"

            Else
                Return 777
            End If

            ret = Bluetooth.btBluetoothSPPConnect(stInfoSet, timeoutSet)
            If ret <> LibDef.BT_OK Then
                disp = "btBluetoothSPPConnect error ret[" & ret & "]"
                MsgBox(disp, MsgBoxStyle.Critical)
                Return ret
            End If
            Return ret
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical)
            Return 999
        End Try
    End Function

    '*******************************************************************************
    '         * 機能 ：SPPを使用したBluetooth機器へのデータ送信を行います。
    '         * API  ：btBluetoothSPPSend
    '*******************************************************************************

    Public Function SPPSend(ByVal iHMCD As String, ByVal iQTY As String, ByVal iTEMP As String) As Int32
        Dim ret As Int32 = 0
        Dim disp As [String] = ""

        Dim strSendBuf As [String] = ""
        Dim dsizeSet As UInt32 = 0
        Dim ssizeGet As UInt32 = 0
        Dim pBufSet As IntPtr
        Dim bBufSet As [Byte]() = New Byte() {}

        Dim strRecvBuf As [String] = ""
        Dim rsizeGet As UInt32 = 0

        Try
            Dim qtyparm As String = Strings.Right("000" + iQTY.Trim(), 3)
            Dim tempparm As String = Strings.Right("000" + iTEMP.Trim(), 3)
            strSendBuf = "^TS" & tempparm & "^SS01,^CN" & qtyparm & iHMCD & ",^FF"
            bBufSet = System.Text.Encoding.GetEncoding(932).GetBytes(strSendBuf)
            dsizeSet = CType(bBufSet.Length, UInt32)
            pBufSet = Marshal.AllocCoTaskMem(CType(dsizeSet, Int32))
            Marshal.Copy(bBufSet, 0, pBufSet, CType(dsizeSet, Int32))
            'ret = Bluetooth.btBluetoothSPPSend(pBufSet, dsizeSet, ssizeGet)
            ' デバッグ用
            Debug.WriteLine(strSendBuf) ' イミディエイトウィンドウに表示される
            Marshal.FreeCoTaskMem(pBufSet)
            If ret <> LibDef.BT_OK Then
                disp = "btBluetoothSPPSend error ret[" & ret & "]"
                MsgBox(disp, MsgBoxStyle.Critical)
                Return ret
            End If
            Return ret
        Catch ex As Exception
            MsgBox(ex.ToString())
            Return 999
        End Try
    End Function

    '*******************************************************************************
    '         * 機能 ：SPP接続を行います。
    '         * API  ：btBluetoothSPPConnect, btBluetoothSPPSend, btBluetoothSPPRecv, btBluetoothSPPDisconnect
    '*******************************************************************************

    Public Sub SPPDisconnect()
        Dim ret As Int32 = 0
        Dim disp As [String] = ""

        Try
            ret = Bluetooth.btBluetoothSPPDisconnect()
            If ret <> LibDef.BT_OK Then
                disp = "btBluetoothSPPDisconnect error ret[" & ret & "]"
                MessageBox.Show(disp, "エラー")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

End Module
