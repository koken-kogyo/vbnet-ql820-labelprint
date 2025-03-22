<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormSetting
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
        Me.LabelMenu = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.cmbPrinters = New System.Windows.Forms.ComboBox
        Me.txtBDAddress = New System.Windows.Forms.TextBox
        Me.lblSelectPrinter = New System.Windows.Forms.Label
        Me.lblBDAddressTitle = New System.Windows.Forms.Label
        Me.btnF4 = New System.Windows.Forms.Button
        Me.btnF3 = New System.Windows.Forms.Button
        Me.btnF2 = New System.Windows.Forms.Button
        Me.btnF1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'LabelMenu
        '
        Me.LabelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelMenu.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 18.0!, System.Drawing.FontStyle.Regular)
        Me.LabelMenu.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LabelMenu.Location = New System.Drawing.Point(0, 0)
        Me.LabelMenu.Name = "LabelMenu"
        Me.LabelMenu.Size = New System.Drawing.Size(240, 28)
        Me.LabelMenu.Text = "プリンタ設定"
        Me.LabelMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 18.0!, System.Drawing.FontStyle.Regular)
        Me.lblTitle.Location = New System.Drawing.Point(12, 38)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(215, 29)
        Me.lblTitle.Text = "QL-820NWBc"
        '
        'cmbPrinters
        '
        Me.cmbPrinters.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 18.0!, System.Drawing.FontStyle.Regular)
        Me.cmbPrinters.Items.Add("1:酸洗梱包")
        Me.cmbPrinters.Items.Add("2:炉中洩検(1階)")
        Me.cmbPrinters.Items.Add("3:建機工程")
        Me.cmbPrinters.Items.Add("4:QL-820NWBc(製造事務所)")
        Me.cmbPrinters.Items.Add("9:その他")
        Me.cmbPrinters.Location = New System.Drawing.Point(11, 112)
        Me.cmbPrinters.Name = "cmbPrinters"
        Me.cmbPrinters.Size = New System.Drawing.Size(216, 42)
        Me.cmbPrinters.TabIndex = 1
        '
        'txtBDAddress
        '
        Me.txtBDAddress.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtBDAddress.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 22.0!, System.Drawing.FontStyle.Regular)
        Me.txtBDAddress.Location = New System.Drawing.Point(11, 202)
        Me.txtBDAddress.Name = "txtBDAddress"
        Me.txtBDAddress.Size = New System.Drawing.Size(216, 50)
        Me.txtBDAddress.TabIndex = 2
        '
        'lblSelectPrinter
        '
        Me.lblSelectPrinter.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lblSelectPrinter.Location = New System.Drawing.Point(11, 84)
        Me.lblSelectPrinter.Name = "lblSelectPrinter"
        Me.lblSelectPrinter.Size = New System.Drawing.Size(183, 35)
        Me.lblSelectPrinter.Text = "プリンタ選択："
        '
        'lblBDAddressTitle
        '
        Me.lblBDAddressTitle.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lblBDAddressTitle.Location = New System.Drawing.Point(12, 174)
        Me.lblBDAddressTitle.Name = "lblBDAddressTitle"
        Me.lblBDAddressTitle.Size = New System.Drawing.Size(215, 35)
        Me.lblBDAddressTitle.Text = "BDｱﾄﾞﾚｽ入力："
        '
        'btnF4
        '
        Me.btnF4.BackColor = System.Drawing.Color.Gold
        Me.btnF4.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.btnF4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnF4.Location = New System.Drawing.Point(178, 285)
        Me.btnF4.Name = "btnF4"
        Me.btnF4.Size = New System.Drawing.Size(62, 34)
        Me.btnF4.TabIndex = 6
        Me.btnF4.Text = "ｸﾘｱ"
        '
        'btnF3
        '
        Me.btnF3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnF3.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.btnF3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnF3.Location = New System.Drawing.Point(120, 285)
        Me.btnF3.Name = "btnF3"
        Me.btnF3.Size = New System.Drawing.Size(62, 34)
        Me.btnF3.TabIndex = 5
        '
        'btnF2
        '
        Me.btnF2.BackColor = System.Drawing.Color.Blue
        Me.btnF2.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.btnF2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnF2.Location = New System.Drawing.Point(59, 285)
        Me.btnF2.Name = "btnF2"
        Me.btnF2.Size = New System.Drawing.Size(62, 34)
        Me.btnF2.TabIndex = 4
        Me.btnF2.Text = "設定"
        '
        'btnF1
        '
        Me.btnF1.BackColor = System.Drawing.Color.Red
        Me.btnF1.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.btnF1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnF1.Location = New System.Drawing.Point(0, 285)
        Me.btnF1.Name = "btnF1"
        Me.btnF1.Size = New System.Drawing.Size(62, 34)
        Me.btnF1.TabIndex = 3
        Me.btnF1.Text = "戻る"
        '
        'FormSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(240, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnF4)
        Me.Controls.Add(Me.btnF3)
        Me.Controls.Add(Me.btnF2)
        Me.Controls.Add(Me.btnF1)
        Me.Controls.Add(Me.txtBDAddress)
        Me.Controls.Add(Me.lblBDAddressTitle)
        Me.Controls.Add(Me.cmbPrinters)
        Me.Controls.Add(Me.lblSelectPrinter)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.LabelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSetting"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelMenu As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmbPrinters As System.Windows.Forms.ComboBox
    Friend WithEvents txtBDAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblSelectPrinter As System.Windows.Forms.Label
    Friend WithEvents lblBDAddressTitle As System.Windows.Forms.Label
    Friend WithEvents btnF4 As System.Windows.Forms.Button
    Friend WithEvents btnF3 As System.Windows.Forms.Button
    Friend WithEvents btnF2 As System.Windows.Forms.Button
    Friend WithEvents btnF1 As System.Windows.Forms.Button

End Class
