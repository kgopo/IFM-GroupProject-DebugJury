<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMember
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
        Me.txtMemberNumber = New System.Windows.Forms.TextBox()
        Me.txtDisplayMembers = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 76)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add Member"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtMemberNumber
        '
        Me.txtMemberNumber.Location = New System.Drawing.Point(12, 31)
        Me.txtMemberNumber.Multiline = True
        Me.txtMemberNumber.Name = "txtMemberNumber"
        Me.txtMemberNumber.Size = New System.Drawing.Size(114, 28)
        Me.txtMemberNumber.TabIndex = 1
        '
        'txtDisplayMembers
        '
        Me.txtDisplayMembers.Location = New System.Drawing.Point(132, 12)
        Me.txtDisplayMembers.Multiline = True
        Me.txtDisplayMembers.Name = "txtDisplayMembers"
        Me.txtDisplayMembers.Size = New System.Drawing.Size(233, 129)
        Me.txtDisplayMembers.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "How many members"
        '
        'frmAddMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 148)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDisplayMembers)
        Me.Controls.Add(Me.txtMemberNumber)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmAddMember"
        Me.Text = "frmAddMember"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtMemberNumber As TextBox
    Friend WithEvents txtDisplayMembers As TextBox
    Friend WithEvents Label1 As Label
End Class
