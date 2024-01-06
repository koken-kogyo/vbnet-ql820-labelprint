<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormProgress
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
        Me.lblMessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("TTヒラギノUD丸ゴ Mono StdN W4", 14.0!, System.Drawing.FontStyle.Regular)
        Me.lblMessage.Location = New System.Drawing.Point(3, 29)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(218, 43)
        Me.lblMessage.Text = "Label1"
        '
        'FormProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(221, 100)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMessage)
        Me.Location = New System.Drawing.Point(8, 60)
        Me.Name = "FormProgress"
        Me.Text = "印刷中"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
End Class
