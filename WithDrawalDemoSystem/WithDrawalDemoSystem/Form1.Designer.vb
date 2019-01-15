<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBalance = New System.Windows.Forms.TextBox()
        Me.TextWithdraw = New System.Windows.Forms.TextBox()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(195, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ตกลง"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ยอดเงินคงเหลือ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "จำนวนที่จะถอน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ชนิดธนบัตรที่จะถอน"
        '
        'TextBalance
        '
        Me.TextBalance.Enabled = False
        Me.TextBalance.Location = New System.Drawing.Point(128, 15)
        Me.TextBalance.Name = "TextBalance"
        Me.TextBalance.Size = New System.Drawing.Size(133, 20)
        Me.TextBalance.TabIndex = 4
        '
        'TextWithdraw
        '
        Me.TextWithdraw.Location = New System.Drawing.Point(128, 53)
        Me.TextWithdraw.Name = "TextWithdraw"
        Me.TextWithdraw.Size = New System.Drawing.Size(133, 20)
        Me.TextWithdraw.TabIndex = 5
        '
        'LabelResult
        '
        Me.LabelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelResult.Location = New System.Drawing.Point(125, 124)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(136, 151)
        Me.LabelResult.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 295)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.TextWithdraw)
        Me.Controls.Add(Me.TextBalance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBalance As TextBox
    Friend WithEvents TextWithdraw As TextBox
    Friend WithEvents LabelResult As Label
End Class
