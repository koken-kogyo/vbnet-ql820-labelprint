<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormLabelPrint
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnF1 = New System.Windows.Forms.Button
        Me.btnF2 = New System.Windows.Forms.Button
        Me.btnF3 = New System.Windows.Forms.Button
        Me.btnF4 = New System.Windows.Forms.Button
        Me.txtHMCD = New System.Windows.Forms.TextBox
        Me.lblHMCDTitle = New System.Windows.Forms.Label
        Me.LabelMenu = New System.Windows.Forms.Label
        Me.txtQTY = New System.Windows.Forms.TextBox
        Me.lblQTYTitle = New System.Windows.Forms.Label
        Me.lblPrinter = New System.Windows.Forms.Label
        Me.lblTemplateTitle = New System.Windows.Forms.Label
        Me.txtTemplate = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnF1
        '
        Me.btnF1.BackColor = System.Drawing.Color.Red
        Me.btnF1.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.btnF1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnF1.Location = New System.Drawing.Point(0, 285)
        Me.btnF1.Name = "btnF1"
        Me.btnF1.Size = New System.Drawing.Size(62, 34)
        Me.btnF1.TabIndex = 108
        Me.btnF1.Text = "戻る"
        '
        'btnF2
        '
        Me.btnF2.BackColor = System.Drawing.Color.Blue
        Me.btnF2.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.btnF2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnF2.Location = New System.Drawing.Point(59, 285)
        Me.btnF2.Name = "btnF2"
        Me.btnF2.Size = New System.Drawing.Size(62, 34)
        Me.btnF2.TabIndex = 109
        Me.btnF2.Text = "印刷"
        '
        'btnF3
        '
        Me.btnF3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnF3.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.btnF3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnF3.Location = New System.Drawing.Point(120, 285)
        Me.btnF3.Name = "btnF3"
        Me.btnF3.Size = New System.Drawing.Size(62, 34)
        Me.btnF3.TabIndex = 110
        '
        'btnF4
        '
        Me.btnF4.BackColor = System.Drawing.Color.Gold
        Me.btnF4.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.btnF4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnF4.Location = New System.Drawing.Point(178, 285)
        Me.btnF4.Name = "btnF4"
        Me.btnF4.Size = New System.Drawing.Size(62, 34)
        Me.btnF4.TabIndex = 111
        Me.btnF4.Text = "ｸﾘｱ"
        '
        'txtHMCD
        '
        Me.txtHMCD.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 22.0!, System.Drawing.FontStyle.Regular)
        Me.txtHMCD.Location = New System.Drawing.Point(11, 113)
        Me.txtHMCD.Name = "txtHMCD"
        Me.txtHMCD.Size = New System.Drawing.Size(216, 50)
        Me.txtHMCD.TabIndex = 1
        '
        'lblHMCDTitle
        '
        Me.lblHMCDTitle.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lblHMCDTitle.Location = New System.Drawing.Point(11, 85)
        Me.lblHMCDTitle.Name = "lblHMCDTitle"
        Me.lblHMCDTitle.Size = New System.Drawing.Size(133, 35)
        Me.lblHMCDTitle.Text = "品番："
        '
        'LabelMenu
        '
        Me.LabelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelMenu.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 18.0!, System.Drawing.FontStyle.Regular)
        Me.LabelMenu.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LabelMenu.Location = New System.Drawing.Point(0, 0)
        Me.LabelMenu.Name = "LabelMenu"
        Me.LabelMenu.Size = New System.Drawing.Size(240, 28)
        Me.LabelMenu.Text = "ラベル印刷"
        Me.LabelMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtQTY
        '
        Me.txtQTY.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 22.0!, System.Drawing.FontStyle.Regular)
        Me.txtQTY.Location = New System.Drawing.Point(159, 172)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(69, 50)
        Me.txtQTY.TabIndex = 2
        '
        'lblQTYTitle
        '
        Me.lblQTYTitle.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lblQTYTitle.Location = New System.Drawing.Point(12, 181)
        Me.lblQTYTitle.Name = "lblQTYTitle"
        Me.lblQTYTitle.Size = New System.Drawing.Size(133, 35)
        Me.lblQTYTitle.Text = "印刷枚数："
        '
        'lblPrinter
        '
        Me.lblPrinter.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 18.0!, System.Drawing.FontStyle.Regular)
        Me.lblPrinter.Location = New System.Drawing.Point(12, 38)
        Me.lblPrinter.Name = "lblPrinter"
        Me.lblPrinter.Size = New System.Drawing.Size(225, 29)
        Me.lblPrinter.Text = "QL-820NWB"
        '
        'lblTemplateTitle
        '
        Me.lblTemplateTitle.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lblTemplateTitle.Location = New System.Drawing.Point(12, 237)
        Me.lblTemplateTitle.Name = "lblTemplateTitle"
        Me.lblTemplateTitle.Size = New System.Drawing.Size(150, 35)
        Me.lblTemplateTitle.Text = "ﾃﾝﾌﾟﾚｰﾄ番号："
        '
        'txtTemplate
        '
        Me.txtTemplate.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 22.0!, System.Drawing.FontStyle.Regular)
        Me.txtTemplate.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTemplate.Location = New System.Drawing.Point(159, 228)
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Size = New System.Drawing.Size(69, 50)
        Me.txtTemplate.TabIndex = 115
        '
        'FormLabelPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTemplate)
        Me.Controls.Add(Me.lblTemplateTitle)
        Me.Controls.Add(Me.lblPrinter)
        Me.Controls.Add(Me.txtQTY)
        Me.Controls.Add(Me.lblQTYTitle)
        Me.Controls.Add(Me.LabelMenu)
        Me.Controls.Add(Me.txtHMCD)
        Me.Controls.Add(Me.btnF4)
        Me.Controls.Add(Me.btnF3)
        Me.Controls.Add(Me.btnF2)
        Me.Controls.Add(Me.btnF1)
        Me.Controls.Add(Me.lblHMCDTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLabelPrint"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnF1 As System.Windows.Forms.Button
    Friend WithEvents btnF2 As System.Windows.Forms.Button
    Friend WithEvents btnF3 As System.Windows.Forms.Button
    Friend WithEvents btnF4 As System.Windows.Forms.Button
    Friend WithEvents lblHMCDTitle As System.Windows.Forms.Label
    Friend WithEvents LabelMenu As System.Windows.Forms.Label
    Public WithEvents txtHMCD As System.Windows.Forms.TextBox
    Public WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents lblQTYTitle As System.Windows.Forms.Label
    Friend WithEvents lblPrinter As System.Windows.Forms.Label
    Friend WithEvents lblTemplateTitle As System.Windows.Forms.Label
    Public WithEvents txtTemplate As System.Windows.Forms.TextBox
End Class
