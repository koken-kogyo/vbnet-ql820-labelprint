<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormMain
    Inherits System.Windows.Forms.Form

    'Form は、コンポーネント一覧に後処理を実行するために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタでこのプロシージャを変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.LabelMenu = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.btnSetting = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrint.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 18.0!, System.Drawing.FontStyle.Regular)
        Me.btnPrint.Location = New System.Drawing.Point(14, 55)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(213, 38)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "1.ラベル印刷　　"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 18.0!, System.Drawing.FontStyle.Regular)
        Me.btnClose.Location = New System.Drawing.Point(14, 274)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 38)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "9.終了"
        '
        'LabelMenu
        '
        Me.LabelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelMenu.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 18.0!, System.Drawing.FontStyle.Regular)
        Me.LabelMenu.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LabelMenu.Location = New System.Drawing.Point(0, 0)
        Me.LabelMenu.Name = "LabelMenu"
        Me.LabelMenu.Size = New System.Drawing.Size(240, 28)
        Me.LabelMenu.Text = "メニュー"
        Me.LabelMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVersion
        '
        Me.lblVersion.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 12.0!, System.Drawing.FontStyle.Regular)
        Me.lblVersion.Location = New System.Drawing.Point(117, 288)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(110, 22)
        Me.lblVersion.Text = "ver 23.12.22"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSetting
        '
        Me.btnSetting.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 18.0!, System.Drawing.FontStyle.Regular)
        Me.btnSetting.Location = New System.Drawing.Point(14, 230)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(213, 38)
        Me.btnSetting.TabIndex = 2
        Me.btnSetting.Text = "8.プリンタ設定"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(240, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.LabelMenu)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents LabelMenu As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents btnSetting As System.Windows.Forms.Button

End Class
